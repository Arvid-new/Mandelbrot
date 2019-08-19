namespace mandelbrot_set
{
    partial class MandelbrotSet
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandelbrotSet));
            this.pbkresleni = new System.Windows.Forms.PictureBox();
            this.butZmackni = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.butOdzoom = new System.Windows.Forms.Button();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblAktP = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitObrázekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápadyProJuliovuMnožinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmavýRežimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitPoziciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.načístPoziciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butLenost = new System.Windows.Forms.Button();
            this.butVybrBar = new System.Windows.Forms.Button();
            this.panBarva = new System.Windows.Forms.Panel();
            this.chJuliasSet = new System.Windows.Forms.CheckBox();
            this.hodiny = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nudZmenaVelikosti = new System.Windows.Forms.NumericUpDown();
            this.panelPosuv = new System.Windows.Forms.Panel();
            this.butZmenJS = new System.Windows.Forms.Button();
            this.tabMocnina = new System.Windows.Forms.TabPage();
            this.rbNa4 = new System.Windows.Forms.RadioButton();
            this.rbNa3 = new System.Windows.Forms.RadioButton();
            this.rbNa5 = new System.Windows.Forms.RadioButton();
            this.rbNa2 = new System.Windows.Forms.RadioButton();
            this.rbNa6 = new System.Windows.Forms.RadioButton();
            this.rbVlastMoc = new System.Windows.Forms.RadioButton();
            this.tabMnozna = new System.Windows.Forms.TabPage();
            this.rbBileP = new System.Windows.Forms.RadioButton();
            this.rbCerneP = new System.Windows.Forms.RadioButton();
            this.rbVlastniM = new System.Windows.Forms.RadioButton();
            this.panPoprediM = new System.Windows.Forms.Panel();
            this.tabPozadi = new System.Windows.Forms.TabPage();
            this.rbJednBar = new System.Windows.Forms.RadioButton();
            this.rbTmaveni = new System.Windows.Forms.RadioButton();
            this.rbSvetleni = new System.Windows.Forms.RadioButton();
            this.rbTmavejsi = new System.Windows.Forms.RadioButton();
            this.rbNegativ = new System.Windows.Forms.RadioButton();
            this.rbNorm = new System.Windows.Forms.RadioButton();
            this.rbStinovani = new System.Windows.Forms.RadioButton();
            this.butZmenaBarvyJB = new System.Windows.Forms.Button();
            this.panJB = new System.Windows.Forms.Panel();
            this.rbProfi = new System.Windows.Forms.RadioButton();
            this.tc = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbkresleni)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZmenaVelikosti)).BeginInit();
            this.panelPosuv.SuspendLayout();
            this.tabMocnina.SuspendLayout();
            this.tabMnozna.SuspendLayout();
            this.tabPozadi.SuspendLayout();
            this.tc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbkresleni
            // 
            this.pbkresleni.BackColor = System.Drawing.Color.Black;
            this.pbkresleni.Location = new System.Drawing.Point(8, 43);
            this.pbkresleni.Name = "pbkresleni";
            this.pbkresleni.Size = new System.Drawing.Size(800, 800);
            this.pbkresleni.TabIndex = 0;
            this.pbkresleni.TabStop = false;
            this.pbkresleni.Paint += new System.Windows.Forms.PaintEventHandler(this.pbkresleni_Paint);
            this.pbkresleni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mysdlo);
            this.pbkresleni.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pankresleni_MouseMove);
            this.pbkresleni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mysnah);
            // 
            // butZmackni
            // 
            this.butZmackni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butZmackni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butZmackni.Location = new System.Drawing.Point(3, 3);
            this.butZmackni.Name = "butZmackni";
            this.butZmackni.Size = new System.Drawing.Size(170, 23);
            this.butZmackni.TabIndex = 1;
            this.butZmackni.Text = "add iterations";
            this.butZmackni.UseVisualStyleBackColor = true;
            this.butZmackni.Click += new System.EventHandler(this.button1_Click);
            // 
            // butReset
            // 
            this.butReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReset.Location = new System.Drawing.Point(3, 32);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(170, 23);
            this.butReset.TabIndex = 2;
            this.butReset.Text = "reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // butOdzoom
            // 
            this.butOdzoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOdzoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOdzoom.Location = new System.Drawing.Point(3, 61);
            this.butOdzoom.Name = "butOdzoom";
            this.butOdzoom.Size = new System.Drawing.Size(170, 23);
            this.butOdzoom.TabIndex = 9;
            this.butOdzoom.Text = "zoom out";
            this.butOdzoom.UseVisualStyleBackColor = true;
            this.butOdzoom.Click += new System.EventHandler(this.Odzoom);
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(5, 27);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(36, 13);
            this.lblHR.TabIndex = 12;
            this.lblHR.Text = "-2 + 2i";
            // 
            // lblAktP
            // 
            this.lblAktP.AutoSize = true;
            this.lblAktP.Location = new System.Drawing.Point(6, 440);
            this.lblAktP.Name = "lblAktP";
            this.lblAktP.Size = new System.Drawing.Size(33, 13);
            this.lblAktP.TabIndex = 14;
            this.lblAktP.Text = "0 + 0i";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vypnoutAplikaciToolStripMenuItem,
            this.uložitObrázekToolStripMenuItem,
            this.nápadyProJuliovuMnožinuToolStripMenuItem,
            this.tmavýRežimToolStripMenuItem,
            this.uložitPoziciToolStripMenuItem,
            this.načístPoziciToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.nastaveníToolStripMenuItem.Text = "options";
            // 
            // vypnoutAplikaciToolStripMenuItem
            // 
            this.vypnoutAplikaciToolStripMenuItem.Name = "vypnoutAplikaciToolStripMenuItem";
            this.vypnoutAplikaciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.vypnoutAplikaciToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vypnoutAplikaciToolStripMenuItem.Text = "close";
            this.vypnoutAplikaciToolStripMenuItem.Click += new System.EventHandler(this.vypnoutAplikaciToolStripMenuItem_Click);
            // 
            // uložitObrázekToolStripMenuItem
            // 
            this.uložitObrázekToolStripMenuItem.Name = "uložitObrázekToolStripMenuItem";
            this.uložitObrázekToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.uložitObrázekToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.uložitObrázekToolStripMenuItem.Text = "save picture";
            this.uložitObrázekToolStripMenuItem.Click += new System.EventHandler(this.uložitObrázekToolStripMenuItem_Click);
            // 
            // nápadyProJuliovuMnožinuToolStripMenuItem
            // 
            this.nápadyProJuliovuMnožinuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.iToolStripMenuItem1,
            this.iToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.iToolStripMenuItem3,
            this.iToolStripMenuItem4,
            this.iToolStripMenuItem5});
            this.nápadyProJuliovuMnožinuToolStripMenuItem.Name = "nápadyProJuliovuMnožinuToolStripMenuItem";
            this.nápadyProJuliovuMnožinuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nápadyProJuliovuMnožinuToolStripMenuItem.Text = "ideas for julia set";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem.Text = "-0,4 + 0.6i";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem1
            // 
            this.iToolStripMenuItem1.Name = "iToolStripMenuItem1";
            this.iToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem1.Text = "0.285 + 0i";
            this.iToolStripMenuItem1.Click += new System.EventHandler(this.iToolStripMenuItem1_Click);
            // 
            // iToolStripMenuItem2
            // 
            this.iToolStripMenuItem2.Name = "iToolStripMenuItem2";
            this.iToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem2.Text = "0.285 + 0.01i";
            this.iToolStripMenuItem2.Click += new System.EventHandler(this.iToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem2.Text = "-0,7017 - 0,3842i";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem3.Text = "-0,835 - 0,2321i";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // iToolStripMenuItem3
            // 
            this.iToolStripMenuItem3.Name = "iToolStripMenuItem3";
            this.iToolStripMenuItem3.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem3.Text = "-0,8 + 0,156i";
            this.iToolStripMenuItem3.Click += new System.EventHandler(this.iToolStripMenuItem3_Click);
            // 
            // iToolStripMenuItem4
            // 
            this.iToolStripMenuItem4.Name = "iToolStripMenuItem4";
            this.iToolStripMenuItem4.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem4.Text = "-0,7269 + 0,1889i";
            this.iToolStripMenuItem4.Click += new System.EventHandler(this.iToolStripMenuItem4_Click);
            // 
            // iToolStripMenuItem5
            // 
            this.iToolStripMenuItem5.Name = "iToolStripMenuItem5";
            this.iToolStripMenuItem5.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem5.Text = "0 - 0.8i";
            this.iToolStripMenuItem5.Click += new System.EventHandler(this.iToolStripMenuItem5_Click);
            // 
            // tmavýRežimToolStripMenuItem
            // 
            this.tmavýRežimToolStripMenuItem.Name = "tmavýRežimToolStripMenuItem";
            this.tmavýRežimToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tmavýRežimToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.tmavýRežimToolStripMenuItem.Text = "dark/light mode";
            this.tmavýRežimToolStripMenuItem.Click += new System.EventHandler(this.tmavýRežimToolStripMenuItem_Click);
            // 
            // uložitPoziciToolStripMenuItem
            // 
            this.uložitPoziciToolStripMenuItem.Name = "uložitPoziciToolStripMenuItem";
            this.uložitPoziciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.uložitPoziciToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.uložitPoziciToolStripMenuItem.Text = "save position";
            this.uložitPoziciToolStripMenuItem.Click += new System.EventHandler(this.UlozeniPozice);
            // 
            // načístPoziciToolStripMenuItem
            // 
            this.načístPoziciToolStripMenuItem.Name = "načístPoziciToolStripMenuItem";
            this.načístPoziciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.načístPoziciToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.načístPoziciToolStripMenuItem.Text = "load position";
            this.načístPoziciToolStripMenuItem.Click += new System.EventHandler(this.NacistPozici);
            // 
            // butLenost
            // 
            this.butLenost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLenost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLenost.Location = new System.Drawing.Point(7, 414);
            this.butLenost.Name = "butLenost";
            this.butLenost.Size = new System.Drawing.Size(166, 23);
            this.butLenost.TabIndex = 16;
            this.butLenost.Text = "add 20 iterations";
            this.butLenost.UseVisualStyleBackColor = true;
            this.butLenost.Click += new System.EventHandler(this.butLenost_Click);
            // 
            // butVybrBar
            // 
            this.butVybrBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butVybrBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVybrBar.Location = new System.Drawing.Point(3, 90);
            this.butVybrBar.Name = "butVybrBar";
            this.butVybrBar.Size = new System.Drawing.Size(170, 23);
            this.butVybrBar.TabIndex = 17;
            this.butVybrBar.Text = "change main color";
            this.butVybrBar.UseVisualStyleBackColor = true;
            this.butVybrBar.Click += new System.EventHandler(this.butVybrBar_Click);
            // 
            // panBarva
            // 
            this.panBarva.BackColor = System.Drawing.Color.Blue;
            this.panBarva.Location = new System.Drawing.Point(3, 119);
            this.panBarva.Name = "panBarva";
            this.panBarva.Size = new System.Drawing.Size(170, 66);
            this.panBarva.TabIndex = 18;
            // 
            // chJuliasSet
            // 
            this.chJuliasSet.AutoSize = true;
            this.chJuliasSet.Location = new System.Drawing.Point(7, 456);
            this.chJuliasSet.Name = "chJuliasSet";
            this.chJuliasSet.Size = new System.Drawing.Size(64, 17);
            this.chJuliasSet.TabIndex = 19;
            this.chJuliasSet.Text = "Julia set";
            this.chJuliasSet.UseVisualStyleBackColor = true;
            this.chJuliasSet.CheckedChanged += new System.EventHandler(this.chJuliasSet_CheckedChanged);
            // 
            // hodiny
            // 
            this.hodiny.Interval = 1;
            this.hodiny.Tick += new System.EventHandler(this.hodiny_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "size of window";
            // 
            // nudZmenaVelikosti
            // 
            this.nudZmenaVelikosti.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudZmenaVelikosti.Location = new System.Drawing.Point(7, 518);
            this.nudZmenaVelikosti.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudZmenaVelikosti.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudZmenaVelikosti.Name = "nudZmenaVelikosti";
            this.nudZmenaVelikosti.Size = new System.Drawing.Size(162, 20);
            this.nudZmenaVelikosti.TabIndex = 3;
            this.nudZmenaVelikosti.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudZmenaVelikosti.ValueChanged += new System.EventHandler(this.nudZmenaVelikosti_ValueChanged);
            // 
            // panelPosuv
            // 
            this.panelPosuv.Controls.Add(this.butZmenJS);
            this.panelPosuv.Controls.Add(this.label1);
            this.panelPosuv.Controls.Add(this.butZmackni);
            this.panelPosuv.Controls.Add(this.nudZmenaVelikosti);
            this.panelPosuv.Controls.Add(this.butReset);
            this.panelPosuv.Controls.Add(this.butOdzoom);
            this.panelPosuv.Controls.Add(this.butLenost);
            this.panelPosuv.Controls.Add(this.tc);
            this.panelPosuv.Controls.Add(this.butVybrBar);
            this.panelPosuv.Controls.Add(this.chJuliasSet);
            this.panelPosuv.Controls.Add(this.panBarva);
            this.panelPosuv.Controls.Add(this.lblAktP);
            this.panelPosuv.Location = new System.Drawing.Point(814, 27);
            this.panelPosuv.Name = "panelPosuv";
            this.panelPosuv.Size = new System.Drawing.Size(180, 754);
            this.panelPosuv.TabIndex = 27;
            // 
            // butZmenJS
            // 
            this.butZmenJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butZmenJS.Location = new System.Drawing.Point(3, 476);
            this.butZmenJS.Name = "butZmenJS";
            this.butZmenJS.Size = new System.Drawing.Size(166, 23);
            this.butZmenJS.TabIndex = 24;
            this.butZmenJS.Text = "change options for jusla set";
            this.butZmenJS.UseVisualStyleBackColor = true;
            this.butZmenJS.Click += new System.EventHandler(this.butZmenJS_Click);
            // 
            // tabMocnina
            // 
            this.tabMocnina.BackColor = System.Drawing.Color.White;
            this.tabMocnina.Controls.Add(this.rbVlastMoc);
            this.tabMocnina.Controls.Add(this.rbNa6);
            this.tabMocnina.Controls.Add(this.rbNa2);
            this.tabMocnina.Controls.Add(this.rbNa5);
            this.tabMocnina.Controls.Add(this.rbNa3);
            this.tabMocnina.Controls.Add(this.rbNa4);
            this.tabMocnina.Location = new System.Drawing.Point(4, 22);
            this.tabMocnina.Name = "tabMocnina";
            this.tabMocnina.Padding = new System.Windows.Forms.Padding(3);
            this.tabMocnina.Size = new System.Drawing.Size(162, 191);
            this.tabMocnina.TabIndex = 2;
            this.tabMocnina.Text = "Powers";
            // 
            // rbNa4
            // 
            this.rbNa4.AutoSize = true;
            this.rbNa4.Location = new System.Drawing.Point(8, 53);
            this.rbNa4.Name = "rbNa4";
            this.rbNa4.Size = new System.Drawing.Size(89, 17);
            this.rbNa4.TabIndex = 2;
            this.rbNa4.Text = "On 4th power";
            this.rbNa4.UseVisualStyleBackColor = true;
            this.rbNa4.Click += new System.EventHandler(this.naKolik);
            // 
            // rbNa3
            // 
            this.rbNa3.AutoSize = true;
            this.rbNa3.Location = new System.Drawing.Point(8, 30);
            this.rbNa3.Name = "rbNa3";
            this.rbNa3.Size = new System.Drawing.Size(89, 17);
            this.rbNa3.TabIndex = 1;
            this.rbNa3.Text = "On 3rd power";
            this.rbNa3.UseVisualStyleBackColor = true;
            this.rbNa3.Click += new System.EventHandler(this.naKolik);
            // 
            // rbNa5
            // 
            this.rbNa5.AutoSize = true;
            this.rbNa5.Location = new System.Drawing.Point(8, 76);
            this.rbNa5.Name = "rbNa5";
            this.rbNa5.Size = new System.Drawing.Size(89, 17);
            this.rbNa5.TabIndex = 3;
            this.rbNa5.Text = "On 5th power";
            this.rbNa5.UseVisualStyleBackColor = true;
            this.rbNa5.Click += new System.EventHandler(this.naKolik);
            // 
            // rbNa2
            // 
            this.rbNa2.AutoSize = true;
            this.rbNa2.Checked = true;
            this.rbNa2.Location = new System.Drawing.Point(8, 7);
            this.rbNa2.Name = "rbNa2";
            this.rbNa2.Size = new System.Drawing.Size(92, 17);
            this.rbNa2.TabIndex = 0;
            this.rbNa2.TabStop = true;
            this.rbNa2.Text = "On 2nd power";
            this.rbNa2.UseVisualStyleBackColor = true;
            this.rbNa2.Click += new System.EventHandler(this.naKolik);
            // 
            // rbNa6
            // 
            this.rbNa6.AutoSize = true;
            this.rbNa6.Location = new System.Drawing.Point(8, 99);
            this.rbNa6.Name = "rbNa6";
            this.rbNa6.Size = new System.Drawing.Size(89, 17);
            this.rbNa6.TabIndex = 4;
            this.rbNa6.Text = "On 6th power";
            this.rbNa6.UseVisualStyleBackColor = true;
            this.rbNa6.Click += new System.EventHandler(this.naKolik);
            // 
            // rbVlastMoc
            // 
            this.rbVlastMoc.AutoSize = true;
            this.rbVlastMoc.Location = new System.Drawing.Point(8, 122);
            this.rbVlastMoc.Name = "rbVlastMoc";
            this.rbVlastMoc.Size = new System.Drawing.Size(60, 17);
            this.rbVlastMoc.TabIndex = 6;
            this.rbVlastMoc.Text = "Custom";
            this.rbVlastMoc.UseVisualStyleBackColor = true;
            this.rbVlastMoc.Click += new System.EventHandler(this.rbVlastMoc_CheckedChanged);
            // 
            // tabMnozna
            // 
            this.tabMnozna.BackColor = System.Drawing.Color.White;
            this.tabMnozna.Controls.Add(this.panPoprediM);
            this.tabMnozna.Controls.Add(this.rbVlastniM);
            this.tabMnozna.Controls.Add(this.rbCerneP);
            this.tabMnozna.Controls.Add(this.rbBileP);
            this.tabMnozna.ForeColor = System.Drawing.Color.Black;
            this.tabMnozna.Location = new System.Drawing.Point(4, 22);
            this.tabMnozna.Name = "tabMnozna";
            this.tabMnozna.Padding = new System.Windows.Forms.Padding(3);
            this.tabMnozna.Size = new System.Drawing.Size(162, 191);
            this.tabMnozna.TabIndex = 1;
            this.tabMnozna.Text = "Color of set";
            // 
            // rbBileP
            // 
            this.rbBileP.AutoSize = true;
            this.rbBileP.ForeColor = System.Drawing.Color.Black;
            this.rbBileP.Location = new System.Drawing.Point(6, 29);
            this.rbBileP.Name = "rbBileP";
            this.rbBileP.Size = new System.Drawing.Size(53, 17);
            this.rbBileP.TabIndex = 1;
            this.rbBileP.Text = "White";
            this.rbBileP.UseVisualStyleBackColor = true;
            this.rbBileP.CheckedChanged += new System.EventHandler(this.rbCerna_CheckedChanged);
            // 
            // rbCerneP
            // 
            this.rbCerneP.AutoSize = true;
            this.rbCerneP.Checked = true;
            this.rbCerneP.ForeColor = System.Drawing.Color.Black;
            this.rbCerneP.Location = new System.Drawing.Point(6, 6);
            this.rbCerneP.Name = "rbCerneP";
            this.rbCerneP.Size = new System.Drawing.Size(52, 17);
            this.rbCerneP.TabIndex = 0;
            this.rbCerneP.TabStop = true;
            this.rbCerneP.Text = "Black";
            this.rbCerneP.UseVisualStyleBackColor = true;
            this.rbCerneP.CheckedChanged += new System.EventHandler(this.rbCerna_CheckedChanged);
            // 
            // rbVlastniM
            // 
            this.rbVlastniM.AutoSize = true;
            this.rbVlastniM.ForeColor = System.Drawing.Color.Black;
            this.rbVlastniM.Location = new System.Drawing.Point(6, 52);
            this.rbVlastniM.Name = "rbVlastniM";
            this.rbVlastniM.Size = new System.Drawing.Size(60, 17);
            this.rbVlastniM.TabIndex = 2;
            this.rbVlastniM.TabStop = true;
            this.rbVlastniM.Text = "Custom";
            this.rbVlastniM.UseVisualStyleBackColor = true;
            this.rbVlastniM.Click += new System.EventHandler(this.colorDrb);
            // 
            // panPoprediM
            // 
            this.panPoprediM.BackColor = System.Drawing.Color.DarkGray;
            this.panPoprediM.Location = new System.Drawing.Point(77, 52);
            this.panPoprediM.Name = "panPoprediM";
            this.panPoprediM.Size = new System.Drawing.Size(40, 21);
            this.panPoprediM.TabIndex = 13;
            this.panPoprediM.Visible = false;
            // 
            // tabPozadi
            // 
            this.tabPozadi.BackColor = System.Drawing.Color.White;
            this.tabPozadi.Controls.Add(this.rbProfi);
            this.tabPozadi.Controls.Add(this.panJB);
            this.tabPozadi.Controls.Add(this.butZmenaBarvyJB);
            this.tabPozadi.Controls.Add(this.rbStinovani);
            this.tabPozadi.Controls.Add(this.rbNorm);
            this.tabPozadi.Controls.Add(this.rbNegativ);
            this.tabPozadi.Controls.Add(this.rbTmavejsi);
            this.tabPozadi.Controls.Add(this.rbSvetleni);
            this.tabPozadi.Controls.Add(this.rbTmaveni);
            this.tabPozadi.Controls.Add(this.rbJednBar);
            this.tabPozadi.Location = new System.Drawing.Point(4, 22);
            this.tabPozadi.Name = "tabPozadi";
            this.tabPozadi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPozadi.Size = new System.Drawing.Size(162, 191);
            this.tabPozadi.TabIndex = 0;
            this.tabPozadi.Text = "Color of background";
            // 
            // rbJednBar
            // 
            this.rbJednBar.AutoSize = true;
            this.rbJednBar.ForeColor = System.Drawing.Color.Black;
            this.rbJednBar.Location = new System.Drawing.Point(5, 55);
            this.rbJednBar.Name = "rbJednBar";
            this.rbJednBar.Size = new System.Drawing.Size(110, 17);
            this.rbJednBar.TabIndex = 4;
            this.rbJednBar.Text = "One color change";
            this.rbJednBar.UseVisualStyleBackColor = true;
            this.rbJednBar.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbTmaveni
            // 
            this.rbTmaveni.AutoSize = true;
            this.rbTmaveni.ForeColor = System.Drawing.Color.Black;
            this.rbTmaveni.Location = new System.Drawing.Point(5, 78);
            this.rbTmaveni.Name = "rbTmaveni";
            this.rbTmaveni.Size = new System.Drawing.Size(48, 17);
            this.rbTmaveni.TabIndex = 6;
            this.rbTmaveni.Text = "Dark";
            this.rbTmaveni.UseVisualStyleBackColor = true;
            this.rbTmaveni.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbSvetleni
            // 
            this.rbSvetleni.AutoSize = true;
            this.rbSvetleni.ForeColor = System.Drawing.Color.Black;
            this.rbSvetleni.Location = new System.Drawing.Point(5, 101);
            this.rbSvetleni.Name = "rbSvetleni";
            this.rbSvetleni.Size = new System.Drawing.Size(48, 17);
            this.rbSvetleni.TabIndex = 7;
            this.rbSvetleni.Text = "Light";
            this.rbSvetleni.UseVisualStyleBackColor = true;
            this.rbSvetleni.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbTmavejsi
            // 
            this.rbTmavejsi.AutoSize = true;
            this.rbTmavejsi.ForeColor = System.Drawing.Color.Black;
            this.rbTmavejsi.Location = new System.Drawing.Point(5, 124);
            this.rbTmavejsi.Name = "rbTmavejsi";
            this.rbTmavejsi.Size = new System.Drawing.Size(57, 17);
            this.rbTmavejsi.TabIndex = 8;
            this.rbTmavejsi.Text = "Darker";
            this.rbTmavejsi.UseVisualStyleBackColor = true;
            this.rbTmavejsi.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbNegativ
            // 
            this.rbNegativ.AutoSize = true;
            this.rbNegativ.ForeColor = System.Drawing.Color.Black;
            this.rbNegativ.Location = new System.Drawing.Point(5, 147);
            this.rbNegativ.Name = "rbNegativ";
            this.rbNegativ.Size = new System.Drawing.Size(68, 17);
            this.rbNegativ.TabIndex = 9;
            this.rbNegativ.TabStop = true;
            this.rbNegativ.Text = "Negative";
            this.rbNegativ.UseVisualStyleBackColor = true;
            this.rbNegativ.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbNorm
            // 
            this.rbNorm.AutoSize = true;
            this.rbNorm.Checked = true;
            this.rbNorm.ForeColor = System.Drawing.Color.Black;
            this.rbNorm.Location = new System.Drawing.Point(6, 7);
            this.rbNorm.Name = "rbNorm";
            this.rbNorm.Size = new System.Drawing.Size(58, 17);
            this.rbNorm.TabIndex = 5;
            this.rbNorm.TabStop = true;
            this.rbNorm.Text = "Normal";
            this.rbNorm.UseVisualStyleBackColor = true;
            this.rbNorm.Click += new System.EventHandler(this.vyberMod);
            // 
            // rbStinovani
            // 
            this.rbStinovani.AutoSize = true;
            this.rbStinovani.ForeColor = System.Drawing.Color.Black;
            this.rbStinovani.Location = new System.Drawing.Point(5, 30);
            this.rbStinovani.Name = "rbStinovani";
            this.rbStinovani.Size = new System.Drawing.Size(78, 17);
            this.rbStinovani.TabIndex = 10;
            this.rbStinovani.TabStop = true;
            this.rbStinovani.Text = "Shadowing";
            this.rbStinovani.UseVisualStyleBackColor = true;
            this.rbStinovani.Click += new System.EventHandler(this.vyberMod);
            // 
            // butZmenaBarvyJB
            // 
            this.butZmenaBarvyJB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butZmenaBarvyJB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butZmenaBarvyJB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.butZmenaBarvyJB.Location = new System.Drawing.Point(110, 49);
            this.butZmenaBarvyJB.Name = "butZmenaBarvyJB";
            this.butZmenaBarvyJB.Size = new System.Drawing.Size(40, 23);
            this.butZmenaBarvyJB.TabIndex = 11;
            this.butZmenaBarvyJB.Text = "color";
            this.butZmenaBarvyJB.UseVisualStyleBackColor = true;
            this.butZmenaBarvyJB.Visible = false;
            this.butZmenaBarvyJB.Click += new System.EventHandler(this.butZmenaBarvyJB_Click);
            // 
            // panJB
            // 
            this.panJB.BackColor = System.Drawing.Color.Aqua;
            this.panJB.Location = new System.Drawing.Point(110, 78);
            this.panJB.Name = "panJB";
            this.panJB.Size = new System.Drawing.Size(40, 21);
            this.panJB.TabIndex = 12;
            this.panJB.Visible = false;
            // 
            // rbProfi
            // 
            this.rbProfi.AutoSize = true;
            this.rbProfi.ForeColor = System.Drawing.Color.Black;
            this.rbProfi.Location = new System.Drawing.Point(5, 168);
            this.rbProfi.Name = "rbProfi";
            this.rbProfi.Size = new System.Drawing.Size(82, 17);
            this.rbProfi.TabIndex = 13;
            this.rbProfi.TabStop = true;
            this.rbProfi.Text = "Professional";
            this.rbProfi.UseVisualStyleBackColor = true;
            this.rbProfi.Click += new System.EventHandler(this.vyberMod);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPozadi);
            this.tc.Controls.Add(this.tabMnozna);
            this.tc.Controls.Add(this.tabMocnina);
            this.tc.Location = new System.Drawing.Point(3, 191);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(170, 217);
            this.tc.TabIndex = 23;
            // 
            // MandelbrotSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 850);
            this.Controls.Add(this.panelPosuv);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.pbkresleni);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MandelbrotSet";
            this.Text = "Mandelbrot set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MandelbrotSet_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MandelbrotSet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbkresleni)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZmenaVelikosti)).EndInit();
            this.panelPosuv.ResumeLayout(false);
            this.panelPosuv.PerformLayout();
            this.tabMocnina.ResumeLayout(false);
            this.tabMocnina.PerformLayout();
            this.tabMnozna.ResumeLayout(false);
            this.tabMnozna.PerformLayout();
            this.tabPozadi.ResumeLayout(false);
            this.tabPozadi.PerformLayout();
            this.tc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbkresleni;
        private System.Windows.Forms.Button butZmackni;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button butOdzoom;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblAktP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypnoutAplikaciToolStripMenuItem;
        private System.Windows.Forms.Button butLenost;
        private System.Windows.Forms.Button butVybrBar;
        private System.Windows.Forms.Panel panBarva;
        private System.Windows.Forms.ToolStripMenuItem uložitObrázekToolStripMenuItem;
        private System.Windows.Forms.CheckBox chJuliasSet;
        private System.Windows.Forms.ToolStripMenuItem nápadyProJuliovuMnožinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tmavýRežimToolStripMenuItem;
        private System.Windows.Forms.Timer hodiny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudZmenaVelikosti;
        private System.Windows.Forms.Panel panelPosuv;
        private System.Windows.Forms.ToolStripMenuItem uložitPoziciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem načístPoziciToolStripMenuItem;
        private System.Windows.Forms.Button butZmenJS;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabPozadi;
        private System.Windows.Forms.RadioButton rbProfi;
        private System.Windows.Forms.Panel panJB;
        private System.Windows.Forms.Button butZmenaBarvyJB;
        private System.Windows.Forms.RadioButton rbStinovani;
        private System.Windows.Forms.RadioButton rbNorm;
        private System.Windows.Forms.RadioButton rbNegativ;
        private System.Windows.Forms.RadioButton rbTmavejsi;
        private System.Windows.Forms.RadioButton rbSvetleni;
        private System.Windows.Forms.RadioButton rbTmaveni;
        private System.Windows.Forms.RadioButton rbJednBar;
        private System.Windows.Forms.TabPage tabMnozna;
        private System.Windows.Forms.Panel panPoprediM;
        private System.Windows.Forms.RadioButton rbVlastniM;
        private System.Windows.Forms.RadioButton rbCerneP;
        private System.Windows.Forms.RadioButton rbBileP;
        private System.Windows.Forms.TabPage tabMocnina;
        private System.Windows.Forms.RadioButton rbVlastMoc;
        private System.Windows.Forms.RadioButton rbNa6;
        private System.Windows.Forms.RadioButton rbNa2;
        private System.Windows.Forms.RadioButton rbNa5;
        private System.Windows.Forms.RadioButton rbNa3;
        private System.Windows.Forms.RadioButton rbNa4;
    }
}

