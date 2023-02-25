using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSembako
{
    public partial class UC_Edit : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JLQE19LM\SQLEXPRESS;Initial Catalog=db_sembako;Integrated Security=True");
        SqlCommand cmd;
        int isLunas = 0;

        public UC_Edit()
        {
            InitializeComponent();
        }

        private string toRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }

        private int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void tb_code_TextChanged(object sender, EventArgs e)
        {
            if (tb_code.Text == "1")
            {
                img_beras.Visible = true;
                img_telur.Visible = false;
                img_kecap.Visible = false;
                tb_name.Text = "Beras";
            }
            else if (tb_code.Text == "2")
            {
                img_beras.Visible = false;
                img_telur.Visible = true;
                img_kecap.Visible = false;
                tb_name.Text = "Telur";
            }
            else if (tb_code.Text == "3")
            {
                img_beras.Visible = false;
                img_telur.Visible = false;
                img_kecap.Visible = true;
                tb_name.Text = "Kecap";
            }
            else
            {
                img_beras.Visible = false;
                img_telur.Visible = false;
                img_kecap.Visible = false;
                tb_price.Text = toRupiah(0);
                tb_name.Text = "";
            }
        }

        private void tb_qty_ValueChanged(object sender, EventArgs e)
        {
            int price = 0;
            int qty = 0;

            if (tb_code.Text == "1")
            {
                if (tb_qty.Value.ToString() != "")
                {
                    qty = int.Parse(tb_qty.Value.ToString());
                }

                price = 20000 * qty;
                tb_price.Text = toRupiah(price);
            }
            else if (tb_code.Text == "2")
            {
                if (tb_qty.Value.ToString() != "")
                {
                    qty = int.Parse(tb_qty.Value.ToString());
                }

                price = 1000 * qty;
                tb_price.Text = toRupiah(price);
            }
            else if (tb_code.Text == "3")
            {
                if (tb_qty.Value.ToString() != "")
                {
                    qty = int.Parse(tb_qty.Value.ToString());
                }

                price = 5000 * qty;
                tb_price.Text = toRupiah(price);
            }
            else
            {
                tb_price.Text = toRupiah(0);
            }
        }

        private void rb_lunas_CheckedChanged(object sender, EventArgs e)
        {
            isLunas = 1;
        }

        private void rb_hutang_CheckedChanged(object sender, EventArgs e)
        {
            isLunas = 0;
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            img_barcode.Image = brCode.Draw(tb_price.Text, 40);
        }

        private void clear()
        {
            tb_code.Clear();
            tb_name.Clear();
            tb_desc.Clear();
            tb_qty.Value = 0;
            tb_price.Clear();
            img_barcode.Visible = false;
            img_beras.Visible = false;
            img_telur.Visible = false;
            img_kecap.Visible = false;
            rb_lunas.Checked = false;
            rb_hutang.Checked = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tb_items] set code = '" + int.Parse(this.tb_code.Text) + "', name = '" + this.tb_name.Text + "' , descr = '" + this.tb_desc.Text + "' , qty = '" + this.tb_qty.Value + "' , is_lunas = '" + isLunas + "' , total = '" + toAngka(tb_price.Text) + "' where code = '" + int.Parse(this.tb_code.Text) + "' ";
            cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Data berhasil diedit");
        }
    }
}
