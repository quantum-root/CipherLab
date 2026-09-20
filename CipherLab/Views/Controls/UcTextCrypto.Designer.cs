namespace CipherLab.Views.Controls
{
    partial class UcTextCrypto
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
            label1 = new Label();
            txtInput = new TextBox();
            label2 = new Label();
            txtKey = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label3 = new Label();
            txtOutput = new TextBox();
            btnCOPY = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 0;
            label1.Text = "Input Text :";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtInput.Location = new Point(20, 45);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(600, 100);
            txtInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 153);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 2;
            label2.Text = "Secret Key :";
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKey.Location = new Point(20, 182);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(444, 22);
            txtKey.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = SystemColors.GradientActiveCaption;
            btnEncrypt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEncrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnEncrypt.Location = new Point(20, 228);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(207, 38);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = SystemColors.GradientActiveCaption;
            btnDecrypt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDecrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrypt.Location = new Point(257, 228);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(207, 38);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(20, 303);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 6;
            label3.Text = "Output Result :";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOutput.Location = new Point(20, 339);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(600, 100);
            txtOutput.TabIndex = 7;
            // 
            // btnCOPY
            // 
            btnCOPY.BackColor = SystemColors.GradientActiveCaption;
            btnCOPY.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCOPY.ForeColor = SystemColors.ActiveCaptionText;
            btnCOPY.Location = new Point(20, 454);
            btnCOPY.Name = "btnCOPY";
            btnCOPY.Size = new Size(98, 26);
            btnCOPY.TabIndex = 8;
            btnCOPY.Text = "COPY";
            btnCOPY.UseVisualStyleBackColor = false;
            btnCOPY.Click += btnCOPY_Click;
            // 
            // UcTextCrypto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCOPY);
            Controls.Add(txtOutput);
            Controls.Add(label3);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtKey);
            Controls.Add(label2);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "UcTextCrypto";
            Size = new Size(759, 503);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Label label2;
        private TextBox txtKey;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label3;
        private TextBox txtOutput;
        private Button btnCOPY;
    }
}
