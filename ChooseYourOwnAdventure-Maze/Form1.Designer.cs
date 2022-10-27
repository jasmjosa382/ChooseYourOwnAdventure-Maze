namespace ChooseYourOwnAdventure_Maze
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titleLabel.Location = new System.Drawing.Point(-4, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(398, 58);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Halloween Maze";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 155);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(12, 296);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(63, 45);
            this.option1Button.TabIndex = 2;
            this.option1Button.Text = "option1 Button";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(12, 365);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(63, 38);
            this.option2Button.TabIndex = 3;
            this.option2Button.Text = "option2 Button";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(96, 312);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(274, 29);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "option1Label";
            // 
            // option2Label
            // 
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(96, 371);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(285, 32);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "option2Label";
           // this.option2Label.Click += new System.EventHandler(this.option2Label_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(26, 57);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(345, 53);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "outputLabel";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(12, 418);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(63, 38);
            this.option3Button.TabIndex = 7;
            this.option3Button.Text = "option3 Button";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(96, 424);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(285, 32);
            this.option3Label.TabIndex = 8;
            this.option3Label.Text = "option3Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 468);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Halloween Maze";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
    }
}

