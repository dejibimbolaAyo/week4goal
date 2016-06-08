using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Library_App;

namespace Library_App
{
    public partial class borrowBook : Form
    {
        public borrowBook()
        {
            InitializeComponent();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            
            string myConnectionString = "server=localhost;port=8080;database=library;uid=root;pwd=root;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand cmd;
            connection.Open();

            // MessageBox.Show("Data Submitted to Database \n Data waiting for Validation");



            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText = cmd.CommandText = "INSERT INTO borrowed_books(student_ID,book_ID) VALUES(@student_ID,@book_ID)";
                cmd.Parameters.AddWithValue("@student_ID", textBoxStudentID.Text);
                cmd.Parameters.AddWithValue("@book_ID", textBoxBookID.Text);

                cmd.ExecuteNonQuery();
                this.Close();
            }
            catch(MySqlException ex)
        
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }
        }

    public class stdFormInput
        {
            public string student_ID;
            public string book_ID;
        }
    }
}
