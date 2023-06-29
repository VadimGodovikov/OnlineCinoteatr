namespace OnlineCinoteatr.Forms.Функции
{
    partial class KolvoUserBuyPodpiska
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hranimProcButton = new System.Windows.Forms.Button();
            this.scalfuncView = new System.Windows.Forms.DataGridView();
            this.idpodpiskaText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scalfuncView)).BeginInit();
            this.SuspendLayout();
            // 
            // hranimProcButton
            // 
            this.hranimProcButton.BackColor = System.Drawing.Color.Salmon;
            this.hranimProcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hranimProcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hranimProcButton.Location = new System.Drawing.Point(342, 70);
            this.hranimProcButton.Name = "hranimProcButton";
            this.hranimProcButton.Size = new System.Drawing.Size(108, 23);
            this.hranimProcButton.TabIndex = 43;
            this.hranimProcButton.Text = "Вывод";
            this.hranimProcButton.UseVisualStyleBackColor = false;
            this.hranimProcButton.Click += new System.EventHandler(this.hranimProcButton_Click);
            // 
            // scalfuncView
            // 
            this.scalfuncView.BackgroundColor = System.Drawing.Color.Khaki;
            this.scalfuncView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scalfuncView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scalfuncView.DefaultCellStyle = dataGridViewCellStyle1;
            this.scalfuncView.GridColor = System.Drawing.Color.Salmon;
            this.scalfuncView.Location = new System.Drawing.Point(27, 100);
            this.scalfuncView.Name = "scalfuncView";
            this.scalfuncView.Size = new System.Drawing.Size(545, 340);
            this.scalfuncView.TabIndex = 42;
            this.scalfuncView.Visible = false;
            // 
            // idpodpiskaText
            // 
            this.idpodpiskaText.Location = new System.Drawing.Point(165, 74);
            this.idpodpiskaText.Name = "idpodpiskaText";
            this.idpodpiskaText.Size = new System.Drawing.Size(148, 20);
            this.idpodpiskaText.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Введите код подписки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Подсчёт пользователей с определённой подпиской";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Скалярная функция";
            // 
            // KolvoUserBuyPodpiska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(598, 451);
            this.Controls.Add(this.hranimProcButton);
            this.Controls.Add(this.scalfuncView);
            this.Controls.Add(this.idpodpiskaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "KolvoUserBuyPodpiska";
            this.Text = "KolvoUserBuyPodpiska";
            ((System.ComponentModel.ISupportInitialize)(this.scalfuncView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hranimProcButton;
        private System.Windows.Forms.DataGridView scalfuncView;
        private System.Windows.Forms.TextBox idpodpiskaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}