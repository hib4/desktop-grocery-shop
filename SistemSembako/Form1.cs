using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSembako
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-JLQE19LM\SQLEXPRESS;Initial Catalog=db_sembako;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count (*) from tb_auth where username = '" + tb_username.Text + "' and password = '" + tb_password.Text + "' ", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2 = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Kredensial tidak sesuai!", "Warning");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
