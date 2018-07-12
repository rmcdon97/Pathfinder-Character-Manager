using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder
{
    public partial class CharacterForm : Form
    {
        #region Variables

        PlayerCharacter character;
        List<ClassAttributeInfo> classVariables;

        #endregion Variables

        public CharacterForm()
        {
            InitializeComponent();
            classSelector.DataSource = Enum.GetValues(typeof(Classes));
            raceSelector.DataSource = Enum.GetValues(typeof(Races));
            
            //this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            character = new PlayerCharacter();
        }

        /// <summary>
        /// Saves all current character data into an xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "XML Files|*.xml";
            saveFileDialog1.Title = "Select Save Location";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                character.SaveCharacterToXML(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a Character Xml File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                character.OpenCharacterFromXML(openFileDialog1.FileName);
                //System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                //sr.Close();
            }
            InGame_DisplaySkillRanks();
            InitializeFormOnCharacterLoad();
        }

        private void InitializeFormOnCharacterLoad()
        {
            maxHpLabel.Text = character.maxHP.ToString();
            currentHPLabel.Text = character.currentHP.ToString();
            nonLethalLabel.Text = character.nonLethalDamage.ToString();
            ACLabel.Text = character.armorClass.ToString();
            flatFootedLabel.Text = character.flatFootedArmorClass.ToString();
            touchACLabel.Text = character.touchArmorClass.ToString();
            //currentBurnLabel.DataBindings.Add(new Binding())
        }

        private void Editing_DisplaySkillRanks()
        {
            skillRanksTable.SuspendLayout();
            this.Cursor = Cursors.WaitCursor;
            skillRanksTable.Visible = false;
            Application.DoEvents();
                
            skillRanksTable.Controls.Clear();
            skillRanksTable.RowCount = 0;
            foreach (SkillValues skill in character.skills)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = skill.name;
                skillRanksTable.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.AutoSize = true;
                lbl2.Text = skill.bonus.ToString();
                skillRanksTable.Controls.Add(lbl2);

                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.SuspendLayout();
                numericUpDown.Dock = DockStyle.Fill;
                numericUpDown.DecimalPlaces = 0;
                numericUpDown.Minimum = 0;
                numericUpDown.Maximum = character.level;
                numericUpDown.Value = skill.ranks;
                numericUpDown.ResumeLayout();
                skillRanksTable.Controls.Add(numericUpDown);
            }
            skillRanksTable.ResumeLayout();
            skillRanksTable.Visible = true;
            this.Cursor = Cursors.Default;
        }

        private void InGame_DisplaySkillRanks()
        {
            InGameSkillRanksTable.SuspendLayout();
            this.Cursor = Cursors.WaitCursor;
            InGameSkillRanksTable.Visible = false;
            Application.DoEvents();

            InGameSkillRanksTable.Controls.Clear();
            InGameSkillRanksTable.RowCount = 0;
            foreach (SkillValues skill in character.skills)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = skill.name.ToString();
                InGameSkillRanksTable.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.AutoSize = true;
                lbl2.Text = skill.bonus.ToString();
                InGameSkillRanksTable.Controls.Add(lbl2);
            }
            InGameSkillRanksTable.ResumeLayout();
            InGameSkillRanksTable.Visible = true;
            this.Cursor = Cursors.Default;
        }

        private decimal RoundDown(decimal number)
        {
            if (number < 0)
                return number + (number % 1);
            else
                return number - (number % 1);
        }

        private void CalculateAttackRoll(int roll)
        {
            int finalResult = roll;
            finalResult += character.baseAttackBonus;
            finalResult += character.race.sizeMod;

            if (character.playerClass.className.Equals("Kineticist"))
            {
                finalResult += (within30ft.Checked) ? 1 : 0;
                if (useKineticBlade.Checked)
                    finalResult += (int)RoundDown(((decimal)character.attributeStats.strength - 10) / 2);
                else
                    finalResult += (int)RoundDown(((decimal)character.attributeStats.dexterity - 10) / 2);
                if (int.Parse(currentBurnLabel.Text) > 0)
                    finalResult++;
            }

            attackResultLabel.Text = finalResult.ToString();
        }

        private void CalculateDamageRoll(int roll)
        {
            int finalResult = roll;
            if (int.Parse(attackDiceRollTB.Text) == 20)
                finalResult *= 2;
            finalResult += (int)RoundDown(((decimal)character.attributeStats.constitution - 10) / 2) / 2;

            if (character.playerClass.className.Equals("Kineticist"))
            {
                finalResult += (within30ft.Checked) ? 1 : 0;
                if (int.Parse(currentBurnLabel.Text) > 0)
                    finalResult += 2;
            }

            damageResultLabel.Text = finalResult.ToString();
        }

        #region Form Actions

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            character = new PlayerCharacter();
        }

        private void STRScore_ValueChanged(object sender, EventArgs e)
        {
            if(STRScore.Value > 0)
            {
                STRLabel.Text = ((int)RoundDown((STRScore.Value - 10) / 2)).ToString();
            }
        }

        private void DEXScore_ValueChanged(object sender, EventArgs e)
        {
            if (DEXScore.Value > 0)
            {
                DEXLabel.Text = ((int)RoundDown((DEXScore.Value - 10) / 2)).ToString();
            }
        }

        private void CONScore_ValueChanged(object sender, EventArgs e)
        {
            if (CONScore.Value > 0)
            {
                CONLabel.Text = ((int)RoundDown((CONScore.Value - 10) / 2)).ToString();
            }
        }

        private void INTScore_ValueChanged(object sender, EventArgs e)
        {
            if (INTScore.Value > 0)
            {
                INTLabel.Text = ((int)RoundDown((INTScore.Value - 10) / 2)).ToString();
            }
        }

        private void WISScore_ValueChanged(object sender, EventArgs e)
        {
            if (WISScore.Value > 0)
            {
                WISLabel.Text = ((int)RoundDown((WISScore.Value - 10) / 2)).ToString();
            }
        }

        private void CHAScore_ValueChanged(object sender, EventArgs e)
        {
            if (CHAScore.Value > 0)
            {
                CHALabel.Text = ((int)RoundDown((CHAScore.Value - 10) / 2)).ToString();
            }
        }

        private void currentHpUp_Click(object sender, EventArgs e)
        {
            character.currentHP++;
            currentHPLabel.Text = character.currentHP.ToString();
        }

        private void currentHpDown_Click(object sender, EventArgs e)
        {
            character.currentHP--;
            currentHPLabel.Text = character.currentHP.ToString();
        }

        private void currentBurnUp_Click(object sender, EventArgs e)
        {
            int tempCurrentBurn = int.Parse(currentBurnLabel.Text);
            currentBurnLabel.Text = (tempCurrentBurn + 1).ToString();
            int currentNonLethal = int.Parse(nonLethalLabel.Text);
            nonLethalLabel.Text = (currentNonLethal + character.level).ToString();
        }

        private void editSkillsBtn_Click(object sender, EventArgs e)
        {
            Editing_DisplaySkillRanks();
        }

        private void attackResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void attackDiceRollTB_TextChanged(object sender, EventArgs e)
        {
            int roll;
            if (int.TryParse(attackDiceRollTB.Text, out roll))
            {
                CalculateAttackRoll(roll);
            }
        }

        #endregion Form Actions

        private void within30ft_CheckedChanged(object sender, EventArgs e)
        {
            int roll;
            if (int.TryParse(attackDiceRollTB.Text, out roll))
            {
                CalculateAttackRoll(roll);
            }
        }

        private void useKineticBlade_CheckedChanged(object sender, EventArgs e)
        {
            int roll;
            if (int.TryParse(attackDiceRollTB.Text, out roll))
            {
                CalculateAttackRoll(roll);
            }
        }

        private void currentBurnDown_Click(object sender, EventArgs e)
        {
            int currentBurn = int.Parse(currentBurnLabel.Text);
            if (currentBurn > 0)
            {
                currentBurnLabel.Text = (currentBurn - 1).ToString();
                int currentNonLethal = int.Parse(nonLethalLabel.Text);
                nonLethalLabel.Text = (currentNonLethal - character.level).ToString();
            }
        }

        private void currentBurnLabel_Click(object sender, EventArgs e)
        {

        }

        private void damageDiceRollTB_TextChanged(object sender, EventArgs e)
        {
            int roll;
            if (int.TryParse(damageDiceRollTB.Text, out roll))
            {
                CalculateDamageRoll(roll);
            }
        }
    }
}
