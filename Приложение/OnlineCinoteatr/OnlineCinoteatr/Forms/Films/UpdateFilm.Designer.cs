namespace OnlineCinoteatr.Forms.Films
{
    partial class UpdateFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFilm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMult = new System.Windows.Forms.CheckBox();
            this.checkFilm = new System.Windows.Forms.CheckBox();
            this.checkKor = new System.Windows.Forms.CheckBox();
            this.checkSer = new System.Windows.Forms.CheckBox();
            this.dateTimeBuild = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AgeResText = new System.Windows.Forms.TextBox();
            this.DescText = new System.Windows.Forms.TextBox();
            this.countryBuild = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Изменить фильм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название фильма";
            // 
            // nameFilm
            // 
            this.nameFilm.Location = new System.Drawing.Point(26, 113);
            this.nameFilm.Name = "nameFilm";
            this.nameFilm.Size = new System.Drawing.Size(228, 20);
            this.nameFilm.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата выхода";
            // 
            // checkMult
            // 
            this.checkMult.AutoSize = true;
            this.checkMult.Location = new System.Drawing.Point(93, 338);
            this.checkMult.Name = "checkMult";
            this.checkMult.Size = new System.Drawing.Size(90, 17);
            this.checkMult.TabIndex = 31;
            this.checkMult.Text = "мультфильм";
            this.checkMult.UseVisualStyleBackColor = true;
            this.checkMult.CheckedChanged += new System.EventHandler(this.checkMult_CheckedChanged);
            // 
            // checkFilm
            // 
            this.checkFilm.AutoSize = true;
            this.checkFilm.Location = new System.Drawing.Point(23, 337);
            this.checkFilm.Name = "checkFilm";
            this.checkFilm.Size = new System.Drawing.Size(60, 17);
            this.checkFilm.TabIndex = 30;
            this.checkFilm.Text = "фильм";
            this.checkFilm.UseVisualStyleBackColor = true;
            this.checkFilm.CheckedChanged += new System.EventHandler(this.checkFilm_CheckedChanged);
            // 
            // checkKor
            // 
            this.checkKor.AutoSize = true;
            this.checkKor.Location = new System.Drawing.Point(93, 314);
            this.checkKor.Name = "checkKor";
            this.checkKor.Size = new System.Drawing.Size(118, 17);
            this.checkKor.TabIndex = 29;
            this.checkKor.Text = "короткометражка";
            this.checkKor.UseVisualStyleBackColor = true;
            this.checkKor.CheckedChanged += new System.EventHandler(this.checkKor_CheckedChanged);
            // 
            // checkSer
            // 
            this.checkSer.AutoSize = true;
            this.checkSer.Location = new System.Drawing.Point(23, 314);
            this.checkSer.Name = "checkSer";
            this.checkSer.Size = new System.Drawing.Size(62, 17);
            this.checkSer.TabIndex = 28;
            this.checkSer.Text = "сериал\r\n";
            this.checkSer.UseVisualStyleBackColor = true;
            this.checkSer.CheckedChanged += new System.EventHandler(this.checkSer_CheckedChanged);
            // 
            // dateTimeBuild
            // 
            this.dateTimeBuild.Location = new System.Drawing.Point(26, 161);
            this.dateTimeBuild.Name = "dateTimeBuild";
            this.dateTimeBuild.Size = new System.Drawing.Size(225, 20);
            this.dateTimeBuild.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Возрастное ограничение (16+)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Страна";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Red;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(23, 366);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(228, 36);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Изменить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AgeResText
            // 
            this.AgeResText.Location = new System.Drawing.Point(26, 243);
            this.AgeResText.Name = "AgeResText";
            this.AgeResText.Size = new System.Drawing.Size(228, 20);
            this.AgeResText.TabIndex = 22;
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(26, 288);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(228, 20);
            this.DescText.TabIndex = 21;
            // 
            // countryBuild
            // 
            this.countryBuild.Location = new System.Drawing.Point(26, 204);
            this.countryBuild.Name = "countryBuild";
            this.countryBuild.Size = new System.Drawing.Size(228, 20);
            this.countryBuild.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(583, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkMult);
            this.Controls.Add(this.checkFilm);
            this.Controls.Add(this.checkKor);
            this.Controls.Add(this.checkSer);
            this.Controls.Add(this.dateTimeBuild);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AgeResText);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.countryBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateFilm";
            this.Text = "UpdateFilm";
            this.Load += new System.EventHandler(this.UpdateFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkMult;
        private System.Windows.Forms.CheckBox checkFilm;
        private System.Windows.Forms.CheckBox checkKor;
        private System.Windows.Forms.CheckBox checkSer;
        private System.Windows.Forms.DateTimePicker dateTimeBuild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AgeResText;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.TextBox countryBuild;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}