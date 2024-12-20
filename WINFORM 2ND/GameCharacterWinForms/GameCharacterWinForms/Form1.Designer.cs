namespace GameCharacterWinForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Health";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Intelligence";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(79, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 13);
            this.txtName.TabIndex = 7;
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Location = new System.Drawing.Point(79, 53);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(121, 13);
            this.txtLevel.TabIndex = 8;
            // 
            // txtHealth
            // 
            this.txtHealth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtHealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealth.Location = new System.Drawing.Point(79, 86);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(121, 13);
            this.txtHealth.TabIndex = 9;
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Location = new System.Drawing.Point(79, 147);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(121, 13);
            this.txtStrength.TabIndex = 10;
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(79, 116);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(121, 21);
            this.cmbCharacterType.TabIndex = 11;
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterType_SelectedIndexChanged);
            // 
            // txtMana
            // 
            this.txtMana.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMana.Location = new System.Drawing.Point(79, 177);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(121, 13);
            this.txtMana.TabIndex = 12;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntelligence.Location = new System.Drawing.Point(79, 212);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(121, 13);
            this.txtIntelligence.TabIndex = 13;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCharacter.Location = new System.Drawing.Point(107, 251);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(93, 23);
            this.btnAddCharacter.TabIndex = 14;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = false;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBoxCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.Location = new System.Drawing.Point(15, 294);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(184, 91);
            this.listBoxCharacters.TabIndex = 15;
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.Location = new System.Drawing.Point(106, 412);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(94, 23);
            this.btnSelectCharacter.TabIndex = 16;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.ATTACK;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(244, 361);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(126, 74);
            this.btnAttack.TabIndex = 17;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.Defend;
            this.btnDefend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefend.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDefend.Location = new System.Drawing.Point(396, 361);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(126, 74);
            this.btnDefend.TabIndex = 18;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.LevelUP;
            this.btnLevelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelUp.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelUp.Location = new System.Drawing.Point(549, 361);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(126, 74);
            this.btnLevelUp.TabIndex = 19;
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCharacterDetails.Location = new System.Drawing.Point(517, 23);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(158, 314);
            this.txtCharacterDetails.TabIndex = 20;
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.Color.DarkGray;
            this.battleLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLog.FormattingEnabled = true;
            this.battleLog.Location = new System.Drawing.Point(696, 23);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(142, 407);
            this.battleLog.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCharacterWinForms.Properties.Resources.GCBACKG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 465);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.listBoxCharacters);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.ListBox battleLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

