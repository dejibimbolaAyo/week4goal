using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_App;


namespace Library_App
{
    public partial class FormLibraryHome : Form
    {
        public FormLibraryHome()
        {
            InitializeComponent();
        }

        private void FormLibraryHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            FormEnroll formEnroll_page = new FormEnroll();
            formEnroll_page.Show();
           
        }

        private void buttonBorrowBooks_Click(object sender, EventArgs e)
        {
            borrowBook borrow = new borrowBook();
            borrow.Show();
        }
    }
}
