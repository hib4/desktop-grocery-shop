using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemSembako
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            p1.Height = btn_1.Height;
            position(btn_1);
            UC_Add uc = new UC_Add();
            addUserControl(uc);
        }

        private void position(Button b)
        {
            p1.Location = new Point(b.Location.X / 2 - 4, b.Location.Y);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            position(btn_1);
            UC_Add uc = new UC_Add();
            addUserControl(uc);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            position(btn_2);
            UC_Edit uc = new UC_Edit();
            addUserControl(uc);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            position(btn_4);
            UC_Search uc = new UC_Search();
            addUserControl(uc);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            position(btn_5);
            UC_Display uc = new UC_Display();
            addUserControl(uc);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
