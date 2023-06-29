namespace OnlineCinoteatr.Forms.Функции
{
    partial class UpdatePricePodpiska
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updatePriceButton = new System.Windows.Forms.Button();
            this.updateDataGrid = new System.Windows.Forms.DataGridView();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePriceButton
            // 
            this.updatePriceButton.BackColor = System.Drawing.Color.Salmon;
            this.updatePriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatePriceButton.Location = new System.Drawing.Point(349, 71);
            this.updatePriceButton.Name = "updatePriceButton";
            this.updatePriceButton.Size = new System.Drawing.Size(108, 23);
            this.updatePriceButton.TabIndex = 43;
            this.updatePriceButton.Text = "Обновить";
            this.updatePriceButton.UseVisualStyleBackColor = false;
            this.updatePriceButton.Click += new System.EventHandler(this.updatePriceButton_Click);
            // 
            // updateDataGrid
            // 
            this.updateDataGrid.BackgroundColor = System.Drawing.Color.Khaki;
            this.updateDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.updateDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.updateDataGrid.GridColor = System.Drawing.Color.Salmon;
            this.updateDataGrid.Location = new System.Drawing.Point(32, 100);
            this.updateDataGrid.Name = "updateDataGrid";
            this.updateDataGrid.Size = new System.Drawing.Size(545, 338);
            this.updateDataGrid.TabIndex = 42;
            this.updateDataGrid.Visible = false;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(170, 72);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(148, 20);
            this.priceText.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Введите цену";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Данное обновление данных нужно для того, чтобы увеличить стоимость всех подписок " +
    "на определённое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Обновление";
            // 
            // UpdatePricePodpiska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.updatePriceButton);
            this.Controls.Add(this.updateDataGrid);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UpdatePricePodpiska";
            this.Text = "UpdatePricePodpiska";
            this.Load += new System.EventHandler(this.UpdatePricePodpiska_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatePriceButton;
        private System.Windows.Forms.DataGridView updateDataGrid;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}