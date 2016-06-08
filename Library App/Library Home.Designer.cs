namespace Library_App
{
    partial class FormLibraryHome
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
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.buttonBorrowBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.Location = new System.Drawing.Point(91, 294);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(208, 23);
            this.buttonEnroll.TabIndex = 0;
            this.buttonEnroll.Text = "Enroll";
            this.buttonEnroll.UseVisualStyleBackColor = true;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // buttonBorrowBooks
            // 
            this.buttonBorrowBooks.Location = new System.Drawing.Point(91, 348);
            this.buttonBorrowBooks.Name = "buttonBorrowBooks";
            this.buttonBorrowBooks.Size = new System.Drawing.Size(208, 23);
            this.buttonBorrowBooks.TabIndex = 0;
            this.buttonBorrowBooks.Text = "Borrow Book";
            this.buttonBorrowBooks.UseVisualStyleBackColor = true;
            this.buttonBorrowBooks.Click += new System.EventHandler(this.buttonBorrowBooks_Click);
            // 
            // FormLibraryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.buttonBorrowBooks);
            this.Controls.Add(this.buttonEnroll);
            this.Name = "FormLibraryHome";
            this.Text = "Library Home";
            this.Load += new System.EventHandler(this.FormLibraryHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Button buttonBorrowBooks;
    }
}

