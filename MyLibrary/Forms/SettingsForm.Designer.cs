
namespace MyLibrary.Forms
{
    partial class SettingsForm
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
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnNormalMode = new System.Windows.Forms.Button();
            this.btnBlackMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(167, 276);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(429, 106);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "Usuń konto";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnNormalMode
            // 
            this.btnNormalMode.Location = new System.Drawing.Point(167, 72);
            this.btnNormalMode.Name = "btnNormalMode";
            this.btnNormalMode.Size = new System.Drawing.Size(196, 158);
            this.btnNormalMode.TabIndex = 1;
            this.btnNormalMode.Text = "Normalny";
            this.btnNormalMode.UseVisualStyleBackColor = true;
            this.btnNormalMode.Click += new System.EventHandler(this.BtnNormalMode_Click);
            // 
            // btnBlackMode
            // 
            this.btnBlackMode.Location = new System.Drawing.Point(400, 72);
            this.btnBlackMode.Name = "btnBlackMode";
            this.btnBlackMode.Size = new System.Drawing.Size(196, 158);
            this.btnBlackMode.TabIndex = 2;
            this.btnBlackMode.Text = "Szary";
            this.btnBlackMode.UseVisualStyleBackColor = true;
            this.btnBlackMode.Click += new System.EventHandler(this.BtnBlackMode_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBlackMode);
            this.Controls.Add(this.btnNormalMode);
            this.Controls.Add(this.btnDeleteAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnNormalMode;
        private System.Windows.Forms.Button btnBlackMode;
    }
}