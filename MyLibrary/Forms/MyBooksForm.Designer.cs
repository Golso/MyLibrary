
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.autorText = new System.Windows.Forms.TextBox();
            this.lblBooksAmount = new System.Windows.Forms.Label();
            this.txtBoxTitleSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 167);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(257, 48);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Dodaj";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(58, 75);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(211, 22);
            this.titleText.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(288, 75);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(449, 301);
            this.dataGridViewMain.TabIndex = 7;
            this.dataGridViewMain.TabStop = false;
            this.dataGridViewMain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewMain_CellMouseClick);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(12, 281);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(257, 42);
            this.btnUpdateBook.TabIndex = 4;
            this.btnUpdateBook.Text = "Edytuj";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(12, 221);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(257, 54);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Pożycz";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autor:";
            // 
            // autorText
            // 
            this.autorText.Location = new System.Drawing.Point(58, 124);
            this.autorText.Name = "autorText";
            this.autorText.Size = new System.Drawing.Size(211, 22);
            this.autorText.TabIndex = 1;
            // 
            // lblBooksAmount
            // 
            this.lblBooksAmount.AutoSize = true;
            this.lblBooksAmount.Location = new System.Drawing.Point(288, 407);
            this.lblBooksAmount.Name = "lblBooksAmount";
            this.lblBooksAmount.Size = new System.Drawing.Size(179, 17);
            this.lblBooksAmount.TabIndex = 12;
            this.lblBooksAmount.Text = "Ilość posiadanych książek: ";
            // 
            // txtBoxTitleSearch
            // 
            this.txtBoxTitleSearch.Location = new System.Drawing.Point(291, 47);
            this.txtBoxTitleSearch.Name = "txtBoxTitleSearch";
            this.txtBoxTitleSearch.Size = new System.Drawing.Size(446, 22);
            this.txtBoxTitleSearch.TabIndex = 13;
            this.txtBoxTitleSearch.Text = "Szukaj po tytule...";
            this.txtBoxTitleSearch.TextChanged += new System.EventHandler(this.TxtBoxTitleSearch_TextChanged);
            // 
            // MyBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxTitleSearch);
            this.Controls.Add(this.lblBooksAmount);
            this.Controls.Add(this.autorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox autorText;
        private System.Windows.Forms.Label lblBooksAmount;
        private System.Windows.Forms.TextBox txtBoxTitleSearch;
    }
}