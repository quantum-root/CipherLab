namespace CipherLab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            btnNavHistory = new Button();
            btnTextCrypto = new Button();
            pnlContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNavHistory);
            panel1.Controls.Add(btnTextCrypto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 511);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 122);
            button1.Name = "button1";
            button1.Size = new Size(200, 56);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNavHistory
            // 
            btnNavHistory.FlatAppearance.BorderColor = Color.Silver;
            btnNavHistory.FlatStyle = FlatStyle.Flat;
            btnNavHistory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNavHistory.ForeColor = Color.White;
            btnNavHistory.Location = new Point(0, 275);
            btnNavHistory.Name = "btnNavHistory";
            btnNavHistory.Size = new Size(200, 56);
            btnNavHistory.TabIndex = 1;
            btnNavHistory.Text = "History";
            btnNavHistory.UseVisualStyleBackColor = true;
            btnNavHistory.Click += btnNavHistory_Click;
            // 
            // btnTextCrypto
            // 
            btnTextCrypto.FlatAppearance.BorderColor = Color.Silver;
            btnTextCrypto.FlatStyle = FlatStyle.Flat;
            btnTextCrypto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTextCrypto.ForeColor = Color.White;
            btnTextCrypto.Location = new Point(0, 196);
            btnTextCrypto.Name = "btnTextCrypto";
            btnTextCrypto.Size = new Size(200, 56);
            btnTextCrypto.TabIndex = 0;
            btnTextCrypto.Text = "Crypto Tool";
            btnTextCrypto.UseVisualStyleBackColor = true;
            btnTextCrypto.Click += btnTextCrypto_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(200, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(684, 511);
            pnlContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(884, 511);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CipherLab";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContainer;
        private Button btnTextCrypto;
        private Button btnNavHistory;
        private Button button1;
    }
}
