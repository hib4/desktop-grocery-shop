using DGVPrinterHelper;
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
    public partial class UC_Search : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JLQE19LM\SQLEXPRESS;Initial Catalog=db_sembako;Integrated Security=True");
        SqlCommand cmd;

        public UC_Search()
        {
            InitializeComponent();
        }

        public void displayData()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_items]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_items] where code = '" + int.Parse(tb_code.Text) + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah kamu yakin ingin menghapus data?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [tb_items] where code = '" + int.Parse(tb_code.Text) + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                tb_code.Clear();
                displayData();
                MessageBox.Show("Data berhasil dihapus");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Sembako";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dddd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Hibatullah Fawwaz Hana";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            dataGridView1.Columns[1].Width = 108;
            dataGridView1.Columns[2].Width =
                dataGridView1.Width
                - dataGridView1.Columns[0].Width
                - dataGridView1.Columns[1].Width - 92;
        }
    }
}
