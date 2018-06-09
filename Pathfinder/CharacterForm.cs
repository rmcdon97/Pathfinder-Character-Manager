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
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            character = new PlayerCharacter();
        }
    }
}
