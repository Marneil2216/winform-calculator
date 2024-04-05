namespace Calculator_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.deletebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.zerobutton = new System.Windows.Forms.Button();
            this.equalsbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.twobutton = new System.Windows.Forms.Button();
            this.threebutton = new System.Windows.Forms.Button();
            this.onebutton = new System.Windows.Forms.Button();
            this.timesbutton = new System.Windows.Forms.Button();
            this.fivebutton = new System.Windows.Forms.Button();
            this.sixbutton = new System.Windows.Forms.Button();
            this.fourbutton = new System.Windows.Forms.Button();
            this.dividebutton = new System.Windows.Forms.Button();
            this.eightbutton = new System.Windows.Forms.Button();
            this.ninebutton = new System.Windows.Forms.Button();
            this.sevenbutton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.SlateGray;
            this.deletebutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(151, 82);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(125, 43);
            this.deletebutton.TabIndex = 36;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.SlateGray;
            this.clearbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(15, 82);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(121, 42);
            this.clearbutton.TabIndex = 35;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.TotaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.ForeColor = System.Drawing.Color.White;
            this.TotaltextBox.Location = new System.Drawing.Point(14, 9);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TotaltextBox.Multiline = true;
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(262, 64);
            this.TotaltextBox.TabIndex = 34;
            this.TotaltextBox.Text = "0";
            this.TotaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.SlateGray;
            this.addbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(221, 358);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(55, 55);
            this.addbutton.TabIndex = 33;
            this.addbutton.Text = "+";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // zerobutton
            // 
            this.zerobutton.BackColor = System.Drawing.Color.SteelBlue;
            this.zerobutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zerobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.zerobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zerobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerobutton.ForeColor = System.Drawing.Color.White;
            this.zerobutton.Location = new System.Drawing.Point(15, 358);
            this.zerobutton.Name = "zerobutton";
            this.zerobutton.Size = new System.Drawing.Size(55, 55);
            this.zerobutton.TabIndex = 32;
            this.zerobutton.Text = "0";
            this.zerobutton.UseVisualStyleBackColor = false;
            this.zerobutton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // equalsbutton
            // 
            this.equalsbutton.BackColor = System.Drawing.Color.SlateGray;
            this.equalsbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equalsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.equalsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsbutton.ForeColor = System.Drawing.Color.White;
            this.equalsbutton.Location = new System.Drawing.Point(151, 358);
            this.equalsbutton.Name = "equalsbutton";
            this.equalsbutton.Size = new System.Drawing.Size(55, 55);
            this.equalsbutton.TabIndex = 31;
            this.equalsbutton.Text = "=";
            this.equalsbutton.UseVisualStyleBackColor = false;
            this.equalsbutton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // minusbutton
            // 
            this.minusbutton.BackColor = System.Drawing.Color.SlateGray;
            this.minusbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minusbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.minusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbutton.ForeColor = System.Drawing.Color.White;
            this.minusbutton.Location = new System.Drawing.Point(221, 286);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(55, 55);
            this.minusbutton.TabIndex = 30;
            this.minusbutton.Text = "-";
            this.minusbutton.UseVisualStyleBackColor = false;
            this.minusbutton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // twobutton
            // 
            this.twobutton.BackColor = System.Drawing.Color.SteelBlue;
            this.twobutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.twobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twobutton.ForeColor = System.Drawing.Color.White;
            this.twobutton.Location = new System.Drawing.Point(81, 286);
            this.twobutton.Name = "twobutton";
            this.twobutton.Size = new System.Drawing.Size(55, 55);
            this.twobutton.TabIndex = 29;
            this.twobutton.Text = "2";
            this.twobutton.UseVisualStyleBackColor = false;
            this.twobutton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threebutton
            // 
            this.threebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.threebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.threebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.threebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebutton.ForeColor = System.Drawing.Color.White;
            this.threebutton.Location = new System.Drawing.Point(151, 286);
            this.threebutton.Name = "threebutton";
            this.threebutton.Size = new System.Drawing.Size(55, 55);
            this.threebutton.TabIndex = 28;
            this.threebutton.Text = "3";
            this.threebutton.UseVisualStyleBackColor = false;
            this.threebutton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // onebutton
            // 
            this.onebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.onebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.onebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.onebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebutton.ForeColor = System.Drawing.Color.White;
            this.onebutton.Location = new System.Drawing.Point(14, 286);
            this.onebutton.Name = "onebutton";
            this.onebutton.Size = new System.Drawing.Size(55, 55);
            this.onebutton.TabIndex = 27;
            this.onebutton.Text = "1";
            this.onebutton.UseVisualStyleBackColor = false;
            this.onebutton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // timesbutton
            // 
            this.timesbutton.BackColor = System.Drawing.Color.SlateGray;
            this.timesbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timesbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.timesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesbutton.ForeColor = System.Drawing.Color.White;
            this.timesbutton.Location = new System.Drawing.Point(221, 213);
            this.timesbutton.Name = "timesbutton";
            this.timesbutton.Size = new System.Drawing.Size(55, 55);
            this.timesbutton.TabIndex = 26;
            this.timesbutton.Text = "x";
            this.timesbutton.UseVisualStyleBackColor = false;
            this.timesbutton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // fivebutton
            // 
            this.fivebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.fivebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fivebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.fivebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fivebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivebutton.ForeColor = System.Drawing.Color.White;
            this.fivebutton.Location = new System.Drawing.Point(81, 213);
            this.fivebutton.Name = "fivebutton";
            this.fivebutton.Size = new System.Drawing.Size(55, 55);
            this.fivebutton.TabIndex = 25;
            this.fivebutton.Text = "5";
            this.fivebutton.UseVisualStyleBackColor = false;
            this.fivebutton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixbutton
            // 
            this.sixbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.sixbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.sixbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixbutton.ForeColor = System.Drawing.Color.White;
            this.sixbutton.Location = new System.Drawing.Point(151, 213);
            this.sixbutton.Name = "sixbutton";
            this.sixbutton.Size = new System.Drawing.Size(55, 55);
            this.sixbutton.TabIndex = 24;
            this.sixbutton.Text = "6";
            this.sixbutton.UseVisualStyleBackColor = false;
            this.sixbutton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // fourbutton
            // 
            this.fourbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.fourbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fourbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.fourbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourbutton.ForeColor = System.Drawing.Color.White;
            this.fourbutton.Location = new System.Drawing.Point(14, 213);
            this.fourbutton.Name = "fourbutton";
            this.fourbutton.Size = new System.Drawing.Size(55, 55);
            this.fourbutton.TabIndex = 23;
            this.fourbutton.Text = "4";
            this.fourbutton.UseVisualStyleBackColor = false;
            this.fourbutton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // dividebutton
            // 
            this.dividebutton.BackColor = System.Drawing.Color.SlateGray;
            this.dividebutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.dividebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebutton.ForeColor = System.Drawing.Color.White;
            this.dividebutton.Location = new System.Drawing.Point(221, 141);
            this.dividebutton.Name = "dividebutton";
            this.dividebutton.Size = new System.Drawing.Size(55, 55);
            this.dividebutton.TabIndex = 22;
            this.dividebutton.Text = "/";
            this.dividebutton.UseVisualStyleBackColor = false;
            this.dividebutton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // eightbutton
            // 
            this.eightbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.eightbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eightbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.eightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightbutton.ForeColor = System.Drawing.Color.White;
            this.eightbutton.Location = new System.Drawing.Point(81, 141);
            this.eightbutton.Name = "eightbutton";
            this.eightbutton.Size = new System.Drawing.Size(55, 55);
            this.eightbutton.TabIndex = 21;
            this.eightbutton.Text = "8";
            this.eightbutton.UseVisualStyleBackColor = false;
            this.eightbutton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // ninebutton
            // 
            this.ninebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.ninebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ninebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.ninebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebutton.ForeColor = System.Drawing.Color.White;
            this.ninebutton.Location = new System.Drawing.Point(151, 141);
            this.ninebutton.Name = "ninebutton";
            this.ninebutton.Size = new System.Drawing.Size(55, 55);
            this.ninebutton.TabIndex = 20;
            this.ninebutton.Text = "9";
            this.ninebutton.UseVisualStyleBackColor = false;
            this.ninebutton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // sevenbutton
            // 
            this.sevenbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.sevenbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sevenbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.sevenbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbutton.ForeColor = System.Drawing.Color.White;
            this.sevenbutton.Location = new System.Drawing.Point(14, 141);
            this.sevenbutton.Name = "sevenbutton";
            this.sevenbutton.Size = new System.Drawing.Size(55, 55);
            this.sevenbutton.TabIndex = 19;
            this.sevenbutton.Text = "7";
            this.sevenbutton.UseVisualStyleBackColor = false;
            this.sevenbutton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PointButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.PointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointButton.ForeColor = System.Drawing.Color.White;
            this.PointButton.Location = new System.Drawing.Point(81, 358);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(55, 55);
            this.PointButton.TabIndex = 37;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = false;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 427);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.zerobutton);
            this.Controls.Add(this.equalsbutton);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.twobutton);
            this.Controls.Add(this.threebutton);
            this.Controls.Add(this.onebutton);
            this.Controls.Add(this.timesbutton);
            this.Controls.Add(this.fivebutton);
            this.Controls.Add(this.sixbutton);
            this.Controls.Add(this.fourbutton);
            this.Controls.Add(this.dividebutton);
            this.Controls.Add(this.eightbutton);
            this.Controls.Add(this.ninebutton);
            this.Controls.Add(this.sevenbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button zerobutton;
        private System.Windows.Forms.Button equalsbutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button twobutton;
        private System.Windows.Forms.Button threebutton;
        private System.Windows.Forms.Button onebutton;
        private System.Windows.Forms.Button timesbutton;
        private System.Windows.Forms.Button fivebutton;
        private System.Windows.Forms.Button sixbutton;
        private System.Windows.Forms.Button fourbutton;
        private System.Windows.Forms.Button dividebutton;
        private System.Windows.Forms.Button eightbutton;
        private System.Windows.Forms.Button ninebutton;
        private System.Windows.Forms.Button sevenbutton;
        private System.Windows.Forms.Button PointButton;
    }
}

