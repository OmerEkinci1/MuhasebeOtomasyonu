namespace ExcelVerileriCekme_AtknUludagCom
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
            this.VerileriCekButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VerileriTekTekCekButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VerileriCekButton
            // 
            this.VerileriCekButton.Location = new System.Drawing.Point(12, 12);
            this.VerileriCekButton.Name = "VerileriCekButton";
            this.VerileriCekButton.Size = new System.Drawing.Size(144, 50);
            this.VerileriCekButton.TabIndex = 0;
            this.VerileriCekButton.Text = "Verileri DataGrid\'e Çek";
            this.VerileriCekButton.UseVisualStyleBackColor = true;
            this.VerileriCekButton.Click += new System.EventHandler(this.VerileriCekButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 115);
            this.dataGridView1.TabIndex = 1;
            // 
            // VerileriTekTekCekButton
            // 
            this.VerileriTekTekCekButton.Location = new System.Drawing.Point(162, 12);
            this.VerileriTekTekCekButton.Name = "VerileriTekTekCekButton";
            this.VerileriTekTekCekButton.Size = new System.Drawing.Size(197, 50);
            this.VerileriTekTekCekButton.TabIndex = 2;
            this.VerileriTekTekCekButton.Text = "Verileri Tek Tek Göster";
            this.VerileriTekTekCekButton.UseVisualStyleBackColor = true;
            this.VerileriTekTekCekButton.Click += new System.EventHandler(this.VerileriTekTekCekButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 189);
            this.Controls.Add(this.VerileriTekTekCekButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.VerileriCekButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel\'deki Verileri Çekme - AtknUludag.Com";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerileriCekButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VerileriTekTekCekButton;
    }
}

