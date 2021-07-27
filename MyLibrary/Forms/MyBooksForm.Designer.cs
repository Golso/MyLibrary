
namespace MyLibrary.Forms
{
    partial class MyBooksForm
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.borrowedBox = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(25, 182);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(257, 69);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Dodaj";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(71, 68);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(211, 22);
            this.titleText.TabIndex = 3;
            // 
            // borrowedBox
            // 
            this.borrowedBox.AutoSize = true;
            this.borrowedBox.Location = new System.Drawing.Point(25, 112);
            this.borrowedBox.Name = "borrowedBox";
            this.borrowedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.borrowedBox.Size = new System.Drawing.Size(99, 21);
            this.borrowedBox.TabIndex = 5;
            this.borrowedBox.Text = "Pożyczone";
            this.borrowedBox.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 74);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(298, 68);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(449, 301);
            this.dataGridViewMain.TabIndex = 7;
            this.dataGridViewMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_CellMouseClick);
            // 
            // MyBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.borrowedBox);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyBooksForm";
            this.Text = "MyBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.CheckBox borrowedBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}