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
            Editing_DisplaySkillRanks();
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

                lbl.Text = skill.bonus.ToString();
                skillRanksTable.Controls.Add(lbl);

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
                lbl.Text = skill.name;
                InGameSkillRanksTable.Controls.Add(lbl);

                lbl.Text = skill.bonus.ToString();
                InGameSkillRanksTable.Controls.Add(lbl);
            }
        }

        private decimal RoundDown(decimal number)
        {
            if (number < 0)
                return number + (number % 1);
            else
                return number - (number % 1);
        }

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
    }
}
