namespace CipherLab.Views.Controls
{
    partial class UcHistory
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            dgvHistory = new DataGridView();
            panel1 = new Panel();
            btnEncrypt = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 0);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(855, 515);
            dgvHistory.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEncrypt);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 48);
            panel1.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = SystemColors.GradientActiveCaption;
            btnEncrypt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEncrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnEncrypt.Location = new Point(312, 7);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(207, 38);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Clear history";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // UcHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dgvHistory);
            Name = "UcHistory";
            Size = new Size(855, 515);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistory;
        private Panel panel1;
        private Button btnEncrypt;
    }
}
