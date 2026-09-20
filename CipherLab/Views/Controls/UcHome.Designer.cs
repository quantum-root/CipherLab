namespace CipherLab.Views.Controls
{
    partial class UcHome
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
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(89, 228);
            label2.Name = "label2";
            label2.Size = new Size(436, 85);
            label2.TabIndex = 1;
            label2.Text = "A secure, clean, and modern text encryption and decryption tool.\n\nNote: This project was built for learning and educational purposes.\n\nUse the left menu to start encrypting or view your history";
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(126, 73);
            label1.Name = "label1";
            label1.Size = new Size(321, 33);
            label1.TabIndex = 0;
            label1.Text = "Welcome to CipherLab";
            // 
            // UcHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UcHome";
            Size = new Size(610, 391);
            Load += UcHome_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
    }
}
