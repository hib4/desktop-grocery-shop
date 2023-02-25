
namespace SistemSembako
{
    partial class Form2
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btn_exit);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.p1);
            this.guna2ShadowPanel1.Controls.Add(this.btn_5);
            this.guna2ShadowPanel1.Controls.Add(this.btn_4);
            this.guna2ShadowPanel1.Controls.Add(this.btn_2);
            this.guna2ShadowPanel1.Controls.Add(this.btn_1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 15;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(218, 608);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BorderRadius = 4;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Lato Semibold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(50, 546);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 36);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(32, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Warung Bu Imah";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.p1.Location = new System.Drawing.Point(0, 122);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 45);
            this.p1.TabIndex = 5;
            this.p1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_5
            // 
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Lato Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_5.Location = new System.Drawing.Point(3, 275);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(212, 45);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "Tampilkan";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Lato Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_4.Location = new System.Drawing.Point(3, 224);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(212, 45);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "Cari";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Lato Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_2.Location = new System.Drawing.Point(3, 173);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(212, 45);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Edit";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Lato Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_1.Location = new System.Drawing.Point(3, 122);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(212, 45);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Tambah";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(218, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(841, 608);
            this.container.TabIndex = 1;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 608);
            this.Controls.Add(this.container);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private System.Windows.Forms.Panel container;
    }
}