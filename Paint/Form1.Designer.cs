namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.OdabirBoje = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLinija = new System.Windows.Forms.Button();
            this.btnKvadrat = new System.Windows.Forms.Button();
            this.btnElipsa = new System.Windows.Forms.Button();
            this.btnGumica = new System.Windows.Forms.Button();
            this.btnOlovka = new System.Windows.Forms.Button();
            this.btnPopuni = new System.Windows.Forms.Button();
            this.btnBoja = new System.Windows.Forms.Button();
            this.izabranaBoja = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdabirBoje)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOcisti);
            this.panel1.Controls.Add(this.OdabirBoje);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.izabranaBoja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 98);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(982, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.Transparent;
            this.btnOcisti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOcisti.Location = new System.Drawing.Point(982, 55);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(127, 31);
            this.btnOcisti.TabIndex = 8;
            this.btnOcisti.Text = "Ocisti";
            this.btnOcisti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // OdabirBoje
            // 
            this.OdabirBoje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OdabirBoje.Image = global::Paint.Properties.Resources.color_palette;
            this.OdabirBoje.Location = new System.Drawing.Point(0, 0);
            this.OdabirBoje.Name = "OdabirBoje";
            this.OdabirBoje.Size = new System.Drawing.Size(337, 98);
            this.OdabirBoje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OdabirBoje.TabIndex = 9;
            this.OdabirBoje.TabStop = false;
            this.OdabirBoje.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.btnLinija);
            this.panel3.Controls.Add(this.btnKvadrat);
            this.panel3.Controls.Add(this.btnElipsa);
            this.panel3.Controls.Add(this.btnGumica);
            this.panel3.Controls.Add(this.btnOlovka);
            this.panel3.Controls.Add(this.btnPopuni);
            this.panel3.Controls.Add(this.btnBoja);
            this.panel3.Location = new System.Drawing.Point(392, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 83);
            this.panel3.TabIndex = 8;
            // 
            // btnLinija
            // 
            this.btnLinija.BackColor = System.Drawing.Color.Transparent;
            this.btnLinija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLinija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinija.Image = global::Paint.Properties.Resources.line;
            this.btnLinija.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLinija.Location = new System.Drawing.Point(498, 5);
            this.btnLinija.Name = "btnLinija";
            this.btnLinija.Size = new System.Drawing.Size(75, 65);
            this.btnLinija.TabIndex = 6;
            this.btnLinija.Text = "Linija";
            this.btnLinija.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinija.UseVisualStyleBackColor = false;
            this.btnLinija.Click += new System.EventHandler(this.btnLinija_Click);
            // 
            // btnKvadrat
            // 
            this.btnKvadrat.BackColor = System.Drawing.Color.Transparent;
            this.btnKvadrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKvadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKvadrat.Image = global::Paint.Properties.Resources.rectangle;
            this.btnKvadrat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKvadrat.Location = new System.Drawing.Point(417, 5);
            this.btnKvadrat.Name = "btnKvadrat";
            this.btnKvadrat.Size = new System.Drawing.Size(75, 65);
            this.btnKvadrat.TabIndex = 5;
            this.btnKvadrat.Text = "Kvadrat";
            this.btnKvadrat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKvadrat.UseVisualStyleBackColor = false;
            this.btnKvadrat.Click += new System.EventHandler(this.btnKvadrat_Click);
            // 
            // btnElipsa
            // 
            this.btnElipsa.BackColor = System.Drawing.Color.Transparent;
            this.btnElipsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnElipsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElipsa.Image = global::Paint.Properties.Resources.circle;
            this.btnElipsa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnElipsa.Location = new System.Drawing.Point(336, 5);
            this.btnElipsa.Name = "btnElipsa";
            this.btnElipsa.Size = new System.Drawing.Size(75, 65);
            this.btnElipsa.TabIndex = 4;
            this.btnElipsa.Text = "Elipsa";
            this.btnElipsa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElipsa.UseVisualStyleBackColor = false;
            this.btnElipsa.Click += new System.EventHandler(this.btnElipsa_Click);
            // 
            // btnGumica
            // 
            this.btnGumica.BackColor = System.Drawing.Color.Transparent;
            this.btnGumica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGumica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGumica.Image = global::Paint.Properties.Resources.eraser;
            this.btnGumica.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGumica.Location = new System.Drawing.Point(255, 5);
            this.btnGumica.Name = "btnGumica";
            this.btnGumica.Size = new System.Drawing.Size(75, 65);
            this.btnGumica.TabIndex = 3;
            this.btnGumica.Text = "Gumica";
            this.btnGumica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGumica.UseVisualStyleBackColor = false;
            this.btnGumica.Click += new System.EventHandler(this.btnGumica_Click);
            // 
            // btnOlovka
            // 
            this.btnOlovka.BackColor = System.Drawing.Color.Transparent;
            this.btnOlovka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOlovka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlovka.Image = global::Paint.Properties.Resources.pencil;
            this.btnOlovka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOlovka.Location = new System.Drawing.Point(174, 5);
            this.btnOlovka.Name = "btnOlovka";
            this.btnOlovka.Size = new System.Drawing.Size(75, 65);
            this.btnOlovka.TabIndex = 2;
            this.btnOlovka.Text = "Olovka";
            this.btnOlovka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOlovka.UseVisualStyleBackColor = false;
            this.btnOlovka.Click += new System.EventHandler(this.btnOlovka_Click);
            // 
            // btnPopuni
            // 
            this.btnPopuni.BackColor = System.Drawing.Color.Transparent;
            this.btnPopuni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPopuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopuni.Image = global::Paint.Properties.Resources.bucket;
            this.btnPopuni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopuni.Location = new System.Drawing.Point(93, 5);
            this.btnPopuni.Name = "btnPopuni";
            this.btnPopuni.Size = new System.Drawing.Size(75, 65);
            this.btnPopuni.TabIndex = 1;
            this.btnPopuni.Text = "Popuni";
            this.btnPopuni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPopuni.UseVisualStyleBackColor = false;
            this.btnPopuni.Click += new System.EventHandler(this.btnPopuni_Click);
            // 
            // btnBoja
            // 
            this.btnBoja.BackColor = System.Drawing.Color.Transparent;
            this.btnBoja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoja.Image = ((System.Drawing.Image)(resources.GetObject("btnBoja.Image")));
            this.btnBoja.Location = new System.Drawing.Point(12, 5);
            this.btnBoja.Name = "btnBoja";
            this.btnBoja.Size = new System.Drawing.Size(75, 65);
            this.btnBoja.TabIndex = 0;
            this.btnBoja.Text = "Boja";
            this.btnBoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBoja.UseVisualStyleBackColor = false;
            this.btnBoja.Click += new System.EventHandler(this.btnBoja_Click);
            // 
            // izabranaBoja
            // 
            this.izabranaBoja.Location = new System.Drawing.Point(343, 25);
            this.izabranaBoja.Name = "izabranaBoja";
            this.izabranaBoja.Size = new System.Drawing.Size(44, 39);
            this.izabranaBoja.TabIndex = 7;
            this.izabranaBoja.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 821);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 29);
            this.panel2.TabIndex = 1;
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picColor.Location = new System.Drawing.Point(0, 98);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(1121, 723);
            this.picColor.TabIndex = 2;
            this.picColor.TabStop = false;
            this.picColor.Paint += new System.Windows.Forms.PaintEventHandler(this.picColor_Paint);
            this.picColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseClick);
            this.picColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseDown);
            this.picColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseMove);
            this.picColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 850);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OdabirBoje)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox picColor;
        private Button btnBoja;
        private Button btnLinija;
        private Button btnKvadrat;
        private Button btnElipsa;
        private Button btnGumica;
        private Button btnOlovka;
        private Button btnPopuni;
        private Panel panel3;
        private Button izabranaBoja;
        private PictureBox OdabirBoje;
        private Button btnSave;
        private Button btnOcisti;
    }
}