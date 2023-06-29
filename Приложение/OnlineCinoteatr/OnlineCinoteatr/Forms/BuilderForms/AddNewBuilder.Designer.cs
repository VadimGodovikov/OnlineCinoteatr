namespace OnlineCinoteatr.Forms.BuilderForms
{
    partial class AddNewBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBuilder));
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KolvoFilmovText = new System.Windows.Forms.TextBox();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.postText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Red;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(319, 359);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(272, 36);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(29, 192);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(228, 20);
            this.middleNameText.TabIndex = 51;
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.Location = new System.Drawing.Point(29, 276);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(225, 20);
            this.dateTimeBirthday.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Количество фильмов в которых снимался";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Отчество";
            // 
            // KolvoFilmovText
            // 
            this.KolvoFilmovText.Location = new System.Drawing.Point(29, 231);
            this.KolvoFilmovText.Name = "KolvoFilmovText";
            this.KolvoFilmovText.Size = new System.Drawing.Size(228, 20);
            this.KolvoFilmovText.TabIndex = 46;
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(29, 152);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(228, 20);
            this.firstnameText.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Имя";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(29, 101);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(228, 20);
            this.surnameText.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 55);
            this.label1.TabIndex = 41;
            this.label1.Text = "Добавить создателя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Телефон";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(29, 325);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(228, 20);
            this.phoneText.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Должность";
            // 
            // postText
            // 
            this.postText.Location = new System.Drawing.Point(29, 375);
            this.postText.Name = "postText";
            this.postText.Size = new System.Drawing.Size(228, 20);
            this.postText.TabIndex = 57;
            // 
            // AddNewBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(608, 412);
            this.Controls.Add(this.postText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KolvoFilmovText);
            this.Controls.Add(this.firstnameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewBuilder";
            this.Text = "Добавить создателя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KolvoFilmovText;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox postText;
    }
}