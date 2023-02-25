
namespace SistemSembako
{
    partial class UC_Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.img_beras = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_lunas = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_hutang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.img_telur = new Guna.UI2.WinForms.Guna2PictureBox();
            this.img_kecap = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tb_qty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.img_barcode = new System.Windows.Forms.PictureBox();
            this.btn_barcode = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_beras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_telur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_kecap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Barang";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 38);
            this.panel1.TabIndex = 1;
            // 
            // tb_code
            // 
            this.tb_code.BorderColor = System.Drawing.Color.White;
            this.tb_code.BorderRadius = 8;
            this.tb_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_code.DefaultText = "";
            this.tb_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_code.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.tb_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_code.Font = new System.Drawing.Font("Lato", 8.999999F);
            this.tb_code.ForeColor = System.Drawing.Color.Black;
            this.tb_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_code.Location = new System.Drawing.Point(54, 159);
            this.tb_code.Name = "tb_code";
            this.tb_code.PasswordChar = '\0';
            this.tb_code.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_code.PlaceholderText = "Kode Barang";
            this.tb_code.SelectedText = "";
            this.tb_code.Size = new System.Drawing.Size(219, 32);
            this.tb_code.TabIndex = 7;
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ITEM";
            // 
            // tb_name
            // 
            this.tb_name.BorderColor = System.Drawing.Color.White;
            this.tb_name.BorderRadius = 8;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.DefaultText = "";
            this.tb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.tb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Font = new System.Drawing.Font("Lato", 8.999999F);
            this.tb_name.ForeColor = System.Drawing.Color.Black;
            this.tb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Location = new System.Drawing.Point(54, 208);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_name.PlaceholderText = "Nama Barang";
            this.tb_name.ReadOnly = true;
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(265, 32);
            this.tb_name.TabIndex = 8;
            // 
            // tb_desc
            // 
            this.tb_desc.BorderColor = System.Drawing.Color.White;
            this.tb_desc.BorderRadius = 8;
            this.tb_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_desc.DefaultText = "";
            this.tb_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.tb_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_desc.Font = new System.Drawing.Font("Lato", 8.999999F);
            this.tb_desc.ForeColor = System.Drawing.Color.Black;
            this.tb_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_desc.Location = new System.Drawing.Point(54, 256);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.PasswordChar = '\0';
            this.tb_desc.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_desc.PlaceholderText = "Deskripsi";
            this.tb_desc.SelectedText = "";
            this.tb_desc.Size = new System.Drawing.Size(265, 67);
            this.tb_desc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(485, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "QTY";
            // 
            // img_beras
            // 
            this.img_beras.BorderRadius = 8;
            this.img_beras.Image = ((System.Drawing.Image)(resources.GetObject("img_beras.Image")));
            this.img_beras.ImageRotate = 0F;
            this.img_beras.Location = new System.Drawing.Point(54, 351);
            this.img_beras.Name = "img_beras";
            this.img_beras.Size = new System.Drawing.Size(265, 125);
            this.img_beras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_beras.TabIndex = 13;
            this.img_beras.TabStop = false;
            this.img_beras.Visible = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(488, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 2);
            this.label3.TabIndex = 14;
            // 
            // rb_lunas
            // 
            this.rb_lunas.AutoSize = true;
            this.rb_lunas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_lunas.CheckedState.BorderThickness = 0;
            this.rb_lunas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.rb_lunas.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_lunas.CheckedState.InnerOffset = -4;
            this.rb_lunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_lunas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_lunas.Location = new System.Drawing.Point(489, 209);
            this.rb_lunas.Name = "rb_lunas";
            this.rb_lunas.Size = new System.Drawing.Size(54, 17);
            this.rb_lunas.TabIndex = 15;
            this.rb_lunas.Text = "Lunas";
            this.rb_lunas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_lunas.UncheckedState.BorderThickness = 1;
            this.rb_lunas.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_lunas.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_lunas.CheckedChanged += new System.EventHandler(this.rb_lunas_CheckedChanged);
            // 
            // rb_hutang
            // 
            this.rb_hutang.AutoSize = true;
            this.rb_hutang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_hutang.CheckedState.BorderThickness = 0;
            this.rb_hutang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.rb_hutang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_hutang.CheckedState.InnerOffset = -4;
            this.rb_hutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_hutang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_hutang.Location = new System.Drawing.Point(572, 209);
            this.rb_hutang.Name = "rb_hutang";
            this.rb_hutang.Size = new System.Drawing.Size(60, 17);
            this.rb_hutang.TabIndex = 16;
            this.rb_hutang.Text = "Hutang";
            this.rb_hutang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_hutang.UncheckedState.BorderThickness = 1;
            this.rb_hutang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_hutang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_hutang.CheckedChanged += new System.EventHandler(this.rb_hutang_CheckedChanged);
            // 
            // tb_price
            // 
            this.tb_price.BorderColor = System.Drawing.Color.White;
            this.tb_price.BorderRadius = 8;
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.DefaultText = "";
            this.tb_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.tb_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.Font = new System.Drawing.Font("Lato", 8.999999F);
            this.tb_price.ForeColor = System.Drawing.Color.Black;
            this.tb_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_price.Location = new System.Drawing.Point(488, 291);
            this.tb_price.Name = "tb_price";
            this.tb_price.PasswordChar = '\0';
            this.tb_price.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_price.PlaceholderText = "Rp. 0,00";
            this.tb_price.ReadOnly = true;
            this.tb_price.SelectedText = "";
            this.tb_price.Size = new System.Drawing.Size(280, 32);
            this.tb_price.TabIndex = 18;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(485, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "TOTAL HARGA";
            // 
            // btn_clear
            // 
            this.btn_clear.BorderRadius = 8;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.Yellow;
            this.btn_clear.Font = new System.Drawing.Font("Lato Semibold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(489, 542);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 35);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 8;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_add.Font = new System.Drawing.Font("Lato Semibold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(654, 542);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 35);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Tambah";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // img_telur
            // 
            this.img_telur.BorderRadius = 8;
            this.img_telur.Image = ((System.Drawing.Image)(resources.GetObject("img_telur.Image")));
            this.img_telur.ImageRotate = 0F;
            this.img_telur.Location = new System.Drawing.Point(54, 351);
            this.img_telur.Name = "img_telur";
            this.img_telur.Size = new System.Drawing.Size(265, 125);
            this.img_telur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_telur.TabIndex = 21;
            this.img_telur.TabStop = false;
            this.img_telur.Visible = false;
            // 
            // img_kecap
            // 
            this.img_kecap.BorderRadius = 8;
            this.img_kecap.Image = ((System.Drawing.Image)(resources.GetObject("img_kecap.Image")));
            this.img_kecap.ImageRotate = 0F;
            this.img_kecap.Location = new System.Drawing.Point(54, 351);
            this.img_kecap.Name = "img_kecap";
            this.img_kecap.Size = new System.Drawing.Size(265, 125);
            this.img_kecap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_kecap.TabIndex = 22;
            this.img_kecap.TabStop = false;
            this.img_kecap.Visible = false;
            // 
            // tb_qty
            // 
            this.tb_qty.BackColor = System.Drawing.Color.Transparent;
            this.tb_qty.BorderRadius = 8;
            this.tb_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_qty.Location = new System.Drawing.Point(488, 159);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(107, 32);
            this.tb_qty.TabIndex = 23;
            this.tb_qty.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.tb_qty.UpDownButtonForeColor = System.Drawing.Color.White;
            this.tb_qty.ValueChanged += new System.EventHandler(this.tb_qty_ValueChanged);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // img_barcode
            // 
            this.img_barcode.Location = new System.Drawing.Point(488, 351);
            this.img_barcode.Name = "img_barcode";
            this.img_barcode.Size = new System.Drawing.Size(277, 125);
            this.img_barcode.TabIndex = 27;
            this.img_barcode.TabStop = false;
            // 
            // btn_barcode
            // 
            this.btn_barcode.BorderRadius = 8;
            this.btn_barcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_barcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_barcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_barcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_barcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_barcode.Font = new System.Drawing.Font("Lato Semibold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btn_barcode.ForeColor = System.Drawing.Color.White;
            this.btn_barcode.Location = new System.Drawing.Point(694, 159);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(71, 32);
            this.btn_barcode.TabIndex = 28;
            this.btn_barcode.Text = "Barcode";
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // UC_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_barcode);
            this.Controls.Add(this.img_barcode);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.img_kecap);
            this.Controls.Add(this.img_telur);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_hutang);
            this.Controls.Add(this.rb_lunas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_beras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Add";
            this.Size = new System.Drawing.Size(841, 608);
            ((System.ComponentModel.ISupportInitialize)(this.img_beras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_telur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_kecap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_code;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tb_name;
        private Guna.UI2.WinForms.Guna2TextBox tb_desc;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox img_beras;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RadioButton rb_lunas;
        private Guna.UI2.WinForms.Guna2RadioButton rb_hutang;
        private Guna.UI2.WinForms.Guna2TextBox tb_price;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2PictureBox img_telur;
        private Guna.UI2.WinForms.Guna2PictureBox img_kecap;
        private Guna.UI2.WinForms.Guna2NumericUpDown tb_qty;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.PictureBox img_barcode;
        private Guna.UI2.WinForms.Guna2Button btn_barcode;
    }
}
