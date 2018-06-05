﻿namespace Pathfinder
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.inGameTab = new System.Windows.Forms.TabPage();
            this.kineticistPanel = new System.Windows.Forms.Panel();
            this.kineticistHealthPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nonLethalLabel = new System.Windows.Forms.Label();
            this.maxHpLabel = new System.Windows.Forms.Label();
            this.currentBurnLabel = new System.Windows.Forms.Label();
            this.currentHPLabel = new System.Windows.Forms.Label();
            this.currentBurnUp = new System.Windows.Forms.Button();
            this.currentBurnDown = new System.Windows.Forms.Button();
            this.currentHpUp = new System.Windows.Forms.Button();
            this.currentHpDown = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.characterEditorTab = new System.Windows.Forms.TabPage();
            this.BasicCharacterDetailsPanel = new System.Windows.Forms.Panel();
            this.raceSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharacterName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.inGameTab.SuspendLayout();
            this.kineticistPanel.SuspendLayout();
            this.kineticistHealthPanel.SuspendLayout();
            this.characterEditorTab.SuspendLayout();
            this.BasicCharacterDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1345, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newCharacterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.inGameTab);
            this.TabControl.Controls.Add(this.characterEditorTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 26);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1345, 862);
            this.TabControl.TabIndex = 1;
            // 
            // inGameTab
            // 
            this.inGameTab.Controls.Add(this.kineticistPanel);
            this.inGameTab.Location = new System.Drawing.Point(4, 25);
            this.inGameTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inGameTab.Name = "inGameTab";
            this.inGameTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inGameTab.Size = new System.Drawing.Size(1337, 833);
            this.inGameTab.TabIndex = 0;
            this.inGameTab.Text = "In-game";
            this.inGameTab.UseVisualStyleBackColor = true;
            // 
            // kineticistPanel
            // 
            this.kineticistPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.kineticistPanel.Controls.Add(this.kineticistHealthPanel);
            this.kineticistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kineticistPanel.Location = new System.Drawing.Point(2, 2);
            this.kineticistPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kineticistPanel.Name = "kineticistPanel";
            this.kineticistPanel.Size = new System.Drawing.Size(1333, 829);
            this.kineticistPanel.TabIndex = 0;
            // 
            // kineticistHealthPanel
            // 
            this.kineticistHealthPanel.BackColor = System.Drawing.Color.Tomato;
            this.kineticistHealthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kineticistHealthPanel.Controls.Add(this.label4);
            this.kineticistHealthPanel.Controls.Add(this.nonLethalLabel);
            this.kineticistHealthPanel.Controls.Add(this.maxHpLabel);
            this.kineticistHealthPanel.Controls.Add(this.currentBurnLabel);
            this.kineticistHealthPanel.Controls.Add(this.currentHPLabel);
            this.kineticistHealthPanel.Controls.Add(this.currentBurnUp);
            this.kineticistHealthPanel.Controls.Add(this.currentBurnDown);
            this.kineticistHealthPanel.Controls.Add(this.currentHpUp);
            this.kineticistHealthPanel.Controls.Add(this.currentHpDown);
            this.kineticistHealthPanel.Controls.Add(this.label6);
            this.kineticistHealthPanel.Controls.Add(this.label5);
            this.kineticistHealthPanel.Controls.Add(this.label3);
            this.kineticistHealthPanel.Location = new System.Drawing.Point(14, 15);
            this.kineticistHealthPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kineticistHealthPanel.Name = "kineticistHealthPanel";
            this.kineticistHealthPanel.Size = new System.Drawing.Size(409, 273);
            this.kineticistHealthPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max HP:";
            // 
            // nonLethalLabel
            // 
            this.nonLethalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonLethalLabel.AutoSize = true;
            this.nonLethalLabel.BackColor = System.Drawing.Color.Salmon;
            this.nonLethalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nonLethalLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonLethalLabel.Location = new System.Drawing.Point(251, 144);
            this.nonLethalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nonLethalLabel.MinimumSize = new System.Drawing.Size(54, 2);
            this.nonLethalLabel.Name = "nonLethalLabel";
            this.nonLethalLabel.Size = new System.Drawing.Size(54, 41);
            this.nonLethalLabel.TabIndex = 11;
            this.nonLethalLabel.Text = "0";
            this.nonLethalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxHpLabel
            // 
            this.maxHpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxHpLabel.AutoSize = true;
            this.maxHpLabel.BackColor = System.Drawing.Color.Salmon;
            this.maxHpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxHpLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHpLabel.Location = new System.Drawing.Point(122, 11);
            this.maxHpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxHpLabel.MinimumSize = new System.Drawing.Size(54, 2);
            this.maxHpLabel.Name = "maxHpLabel";
            this.maxHpLabel.Size = new System.Drawing.Size(59, 41);
            this.maxHpLabel.TabIndex = 10;
            this.maxHpLabel.Text = "25";
            this.maxHpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentBurnLabel
            // 
            this.currentBurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBurnLabel.AutoSize = true;
            this.currentBurnLabel.BackColor = System.Drawing.Color.Salmon;
            this.currentBurnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBurnLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBurnLabel.Location = new System.Drawing.Point(251, 209);
            this.currentBurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentBurnLabel.MinimumSize = new System.Drawing.Size(54, 2);
            this.currentBurnLabel.Name = "currentBurnLabel";
            this.currentBurnLabel.Size = new System.Drawing.Size(54, 41);
            this.currentBurnLabel.TabIndex = 9;
            this.currentBurnLabel.Text = "0";
            this.currentBurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentHPLabel
            // 
            this.currentHPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentHPLabel.AutoSize = true;
            this.currentHPLabel.BackColor = System.Drawing.Color.Salmon;
            this.currentHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentHPLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHPLabel.Location = new System.Drawing.Point(251, 79);
            this.currentHPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentHPLabel.MinimumSize = new System.Drawing.Size(54, 2);
            this.currentHPLabel.Name = "currentHPLabel";
            this.currentHPLabel.Size = new System.Drawing.Size(59, 41);
            this.currentHPLabel.TabIndex = 8;
            this.currentHPLabel.Text = "25";
            this.currentHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentBurnUp
            // 
            this.currentBurnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBurnUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBurnUp.Location = new System.Drawing.Point(311, 204);
            this.currentBurnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentBurnUp.Name = "currentBurnUp";
            this.currentBurnUp.Size = new System.Drawing.Size(69, 48);
            this.currentBurnUp.TabIndex = 7;
            this.currentBurnUp.Text = "+";
            this.currentBurnUp.UseVisualStyleBackColor = true;
            // 
            // currentBurnDown
            // 
            this.currentBurnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBurnDown.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBurnDown.Location = new System.Drawing.Point(177, 204);
            this.currentBurnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentBurnDown.Name = "currentBurnDown";
            this.currentBurnDown.Size = new System.Drawing.Size(69, 48);
            this.currentBurnDown.TabIndex = 6;
            this.currentBurnDown.Text = "-";
            this.currentBurnDown.UseVisualStyleBackColor = true;
            // 
            // currentHpUp
            // 
            this.currentHpUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentHpUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHpUp.Location = new System.Drawing.Point(311, 75);
            this.currentHpUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentHpUp.Name = "currentHpUp";
            this.currentHpUp.Size = new System.Drawing.Size(69, 48);
            this.currentHpUp.TabIndex = 5;
            this.currentHpUp.Text = "+";
            this.currentHpUp.UseVisualStyleBackColor = true;
            // 
            // currentHpDown
            // 
            this.currentHpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentHpDown.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHpDown.Location = new System.Drawing.Point(177, 75);
            this.currentHpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentHpDown.Name = "currentHpDown";
            this.currentHpDown.Size = new System.Drawing.Size(69, 48);
            this.currentHpDown.TabIndex = 4;
            this.currentHpDown.Text = "-";
            this.currentHpDown.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Current burn:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Non-lethal damage:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current HP:";
            // 
            // characterEditorTab
            // 
            this.characterEditorTab.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.characterEditorTab.Controls.Add(this.BasicCharacterDetailsPanel);
            this.characterEditorTab.Location = new System.Drawing.Point(4, 25);
            this.characterEditorTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterEditorTab.Name = "characterEditorTab";
            this.characterEditorTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterEditorTab.Size = new System.Drawing.Size(1337, 833);
            this.characterEditorTab.TabIndex = 1;
            this.characterEditorTab.Text = "Character Editor";
            // 
            // BasicCharacterDetailsPanel
            // 
            this.BasicCharacterDetailsPanel.BackColor = System.Drawing.Color.Silver;
            this.BasicCharacterDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasicCharacterDetailsPanel.Controls.Add(this.raceSelector);
            this.BasicCharacterDetailsPanel.Controls.Add(this.label2);
            this.BasicCharacterDetailsPanel.Controls.Add(this.classSelector);
            this.BasicCharacterDetailsPanel.Controls.Add(this.label1);
            this.BasicCharacterDetailsPanel.Controls.Add(this.CharacterName);
            this.BasicCharacterDetailsPanel.Controls.Add(this.textBox1);
            this.BasicCharacterDetailsPanel.Location = new System.Drawing.Point(14, 14);
            this.BasicCharacterDetailsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BasicCharacterDetailsPanel.Name = "BasicCharacterDetailsPanel";
            this.BasicCharacterDetailsPanel.Size = new System.Drawing.Size(406, 185);
            this.BasicCharacterDetailsPanel.TabIndex = 1;
            // 
            // raceSelector
            // 
            this.raceSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceSelector.FormattingEnabled = true;
            this.raceSelector.Location = new System.Drawing.Point(186, 121);
            this.raceSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raceSelector.Name = "raceSelector";
            this.raceSelector.Size = new System.Drawing.Size(191, 33);
            this.raceSelector.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race:";
            // 
            // classSelector
            // 
            this.classSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelector.FormattingEnabled = true;
            this.classSelector.Location = new System.Drawing.Point(186, 77);
            this.classSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classSelector.Name = "classSelector";
            this.classSelector.Size = new System.Drawing.Size(191, 33);
            this.classSelector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class:";
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterName.Location = new System.Drawing.Point(18, 31);
            this.CharacterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(161, 25);
            this.CharacterName.TabIndex = 1;
            this.CharacterName.Text = "Character Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(186, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 30);
            this.textBox1.TabIndex = 0;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1345, 888);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CharacterForm";
            this.Text = "Pathfinder Character Manager";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.inGameTab.ResumeLayout(false);
            this.kineticistPanel.ResumeLayout(false);
            this.kineticistHealthPanel.ResumeLayout(false);
            this.kineticistHealthPanel.PerformLayout();
            this.characterEditorTab.ResumeLayout(false);
            this.BasicCharacterDetailsPanel.ResumeLayout(false);
            this.BasicCharacterDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage inGameTab;
        private System.Windows.Forms.TabPage characterEditorTab;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.Panel kineticistPanel;
        private System.Windows.Forms.Panel kineticistHealthPanel;
        private System.Windows.Forms.Label nonLethalLabel;
        private System.Windows.Forms.Label maxHpLabel;
        private System.Windows.Forms.Label currentBurnLabel;
        private System.Windows.Forms.Label currentHPLabel;
        private System.Windows.Forms.Button currentBurnUp;
        private System.Windows.Forms.Button currentBurnDown;
        private System.Windows.Forms.Button currentHpUp;
        private System.Windows.Forms.Button currentHpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BasicCharacterDetailsPanel;
        private System.Windows.Forms.ComboBox raceSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox classSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

