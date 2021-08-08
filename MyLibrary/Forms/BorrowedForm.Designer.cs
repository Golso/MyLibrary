
namespace MyLibrary.Forms
{
    partial class BorrowedForm
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
            this.dataGridViewBorrowed = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.autorText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrowed
            // 
            this.dataGridViewBorrowed.AllowUserToAddRows = false;
            this.dataGridViewBorrowed.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowed.Location = new System.Drawing.Point(298, 68);
            this.dataGridViewBorrowed.Name = "dataGridViewBorrowed";
            this.dataGridViewBorrowed.ReadOnly = true;
            this.dataGridViewBorrowed.RowHeadersWidth = 51;
            this.dataGridViewBorrowed.RowTemplate.Height = 24;
            this.dataGridViewBorrowed.Size = new System.Drawing.Size(449, 301);
            this.dataGridViewBorrowed.TabIndex = 0;
            this.dataGridViewBorrowed.TabStop = false;
            this.dataGridViewBorrowed.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBorrowed_CellMouseClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(51, 228);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(221, 83);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Zwrócone";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor:";
            // 
            // titleText
            // 
            this.titleText.Enabled = false;
            this.titleText.Location = new System.Drawing.Point(127, 73);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(145, 22);
            this.titleText.TabIndex = 4;
            // 
            // autorText
            // 
            this.autorText.Enabled = false;
            this.autorText.Location = new System.Drawing.Point(127, 117);
            this.autorText.Name = "autorText";
            this.autorText.Size = new System.Drawing.Size(145, 22);
            this.autorText.TabIndex = 5;
            // 
            // BorrowedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridViewBorrowed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowedForm";
            this.Text = "BorrowedForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrowed;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox autorText;
    }
}