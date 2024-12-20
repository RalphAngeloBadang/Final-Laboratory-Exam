namespace SlotMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.btnTheme = new System.Windows.Forms.Button();
            this.txtStake = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSpin = new SlotMachine.CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(159, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(332, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(511, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // timerSpin
            // 
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick);
            // 
            // btnTheme
            // 
            this.btnTheme.Location = new System.Drawing.Point(23, 16);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(84, 46);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.Text = "Change Theme\n";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // txtStake
            // 
            this.txtStake.Location = new System.Drawing.Point(142, 308);
            this.txtStake.Name = "txtStake";
            this.txtStake.Size = new System.Drawing.Size(129, 20);
            this.txtStake.TabIndex = 5;
            this.txtStake.Enter += new System.EventHandler(this.txtStake_Enter);
            this.txtStake.Leave += new System.EventHandler(this.txtStake_Leave);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(145, 49);
            this.lblResult.MaximumSize = new System.Drawing.Size(500, 30);
            this.lblResult.MinimumSize = new System.Drawing.Size(500, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(500, 30);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "!SPIN NOW!";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(521, 303);
            this.lblBalance.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblBalance.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(200, 30);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance: P1000";
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.BackgroundImage = global::SlotMachine.Properties.Resources.button_spin_removebg_preview;
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Location = new System.Drawing.Point(313, 281);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(163, 72);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotMachine.Properties.Resources._4680;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtStake);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Super Ace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.TextBox txtStake;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblBalance;
        private CircleButton btnSpin;
    }
}

