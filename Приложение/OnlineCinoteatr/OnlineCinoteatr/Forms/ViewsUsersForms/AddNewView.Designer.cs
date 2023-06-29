namespace OnlineCinoteatr.Forms.ViewsUsersForms
{
    partial class AddNewView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewView));
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimeView = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.iduseraText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idfilmaText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Red;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(5, 254);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(228, 36);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimeView
            // 
            this.dateTimeView.Location = new System.Drawing.Point(5, 204);
            this.dateTimeView.Name = "dateTimeView";
            this.dateTimeView.Size = new System.Drawing.Size(225, 20);
            this.dateTimeView.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Дата просмотра";
            // 
            // iduseraText
            // 
            this.iduseraText.Location = new System.Drawing.Point(5, 152);
            this.iduseraText.Name = "iduseraText";
            this.iduseraText.Size = new System.Drawing.Size(228, 20);
            this.iduseraText.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Код пользователя";
            // 
            // idfilmaText
            // 
            this.idfilmaText.Location = new System.Drawing.Point(5, 101);
            this.idfilmaText.Name = "idfilmaText";
            this.idfilmaText.Size = new System.Drawing.Size(228, 20);
            this.idfilmaText.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Код фильма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 55);
            this.label1.TabIndex = 41;
            this.label1.Text = "Добавить просмотр";
            // 
            // AddNewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(534, 303);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimeView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iduseraText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idfilmaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewView";
            this.Text = "Добавить новый просмотр";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimeView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iduseraText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idfilmaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}