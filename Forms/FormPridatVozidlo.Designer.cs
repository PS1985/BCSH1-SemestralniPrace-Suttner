namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    partial class FormPridatVozidlo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPridatVozidlo));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            panel14 = new Panel();
            btnZpet = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel13 = new Panel();
            label7 = new Label();
            cmbZnacka = new ComboBox();
            panel4 = new Panel();
            label1 = new Label();
            txtModel = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtVin = new TextBox();
            panel5 = new Panel();
            label3 = new Label();
            txtRokVyroby = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            txtKilometry = new TextBox();
            panel8 = new Panel();
            cmbMena = new ComboBox();
            label5 = new Label();
            txtCena = new TextBox();
            panel9 = new Panel();
            label6 = new Label();
            cmbPalivo = new ComboBox();
            panel15 = new Panel();
            label8 = new Label();
            txtProdejce = new TextBox();
            panel16 = new Panel();
            label9 = new Label();
            txtKontakt = new TextBox();
            panel2 = new Panel();
            panel17 = new Panel();
            pbFotoVozidla = new PictureBox();
            panel10 = new Panel();
            panel12 = new Panel();
            btnUlozit = new Button();
            panel11 = new Panel();
            btnNahratFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel14.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel13.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel2.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoVozidla).BeginInit();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 52);
            panel1.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel14.Controls.Add(btnZpet);
            panel14.Location = new Point(722, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(53, 44);
            panel14.TabIndex = 0;
            // 
            // btnZpet
            // 
            btnZpet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZpet.DialogResult = DialogResult.Cancel;
            btnZpet.Image = (Image)resources.GetObject("btnZpet.Image");
            btnZpet.Location = new Point(0, 0);
            btnZpet.Name = "btnZpet";
            btnZpet.Size = new Size(53, 44);
            btnZpet.TabIndex = 0;
            btnZpet.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel15);
            flowLayoutPanel1.Controls.Add(panel16);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.Location = new Point(0, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(348, 512);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Controls.Add(label7);
            panel13.Controls.Add(cmbZnacka);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(339, 50);
            panel13.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 6;
            label7.Text = "Značka:";
            // 
            // cmbZnacka
            // 
            cmbZnacka.BackColor = SystemColors.ControlLightLight;
            cmbZnacka.FormattingEnabled = true;
            cmbZnacka.Location = new Point(85, 13);
            cmbZnacka.Name = "cmbZnacka";
            cmbZnacka.Size = new Size(251, 33);
            cmbZnacka.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtModel);
            panel4.Location = new Point(3, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 50);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 1;
            label1.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.None;
            txtModel.BackColor = SystemColors.ControlLightLight;
            txtModel.ForeColor = SystemColors.MenuText;
            txtModel.Location = new Point(78, 12);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(258, 31);
            txtModel.TabIndex = 0;
            txtModel.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtVin);
            panel3.Location = new Point(3, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 50);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 2;
            label2.Text = "VIN:";
            // 
            // txtVin
            // 
            txtVin.BackColor = SystemColors.ControlLightLight;
            txtVin.Location = new Point(57, 14);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(279, 31);
            txtVin.TabIndex = 1;
            txtVin.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtRokVyroby);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 171);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 50);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 3;
            label3.Text = "Rok výroby:";
            // 
            // txtRokVyroby
            // 
            txtRokVyroby.BackColor = SystemColors.ControlLightLight;
            txtRokVyroby.Location = new Point(117, 14);
            txtRokVyroby.Name = "txtRokVyroby";
            txtRokVyroby.Size = new Size(219, 31);
            txtRokVyroby.TabIndex = 2;
            txtRokVyroby.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 72);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 66);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(label4);
            panel7.Controls.Add(txtKilometry);
            panel7.Location = new Point(3, 227);
            panel7.Name = "panel7";
            panel7.Size = new Size(339, 50);
            panel7.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 4;
            label4.Text = "Kilometry:";
            // 
            // txtKilometry
            // 
            txtKilometry.BackColor = SystemColors.ControlLightLight;
            txtKilometry.Location = new Point(105, 9);
            txtKilometry.Name = "txtKilometry";
            txtKilometry.Size = new Size(231, 31);
            txtKilometry.TabIndex = 3;
            txtKilometry.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.Controls.Add(cmbMena);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(txtCena);
            panel8.Location = new Point(3, 283);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 50);
            panel8.TabIndex = 4;
            // 
            // cmbMena
            // 
            cmbMena.FormattingEnabled = true;
            cmbMena.Location = new Point(274, 10);
            cmbMena.Name = "cmbMena";
            cmbMena.Size = new Size(62, 33);
            cmbMena.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 5;
            label5.Text = "Cena:";
            // 
            // txtCena
            // 
            txtCena.BackColor = SystemColors.ControlLightLight;
            txtCena.Location = new Point(68, 12);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(200, 31);
            txtCena.TabIndex = 4;
            txtCena.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.Controls.Add(label6);
            panel9.Controls.Add(cmbPalivo);
            panel9.Location = new Point(3, 339);
            panel9.Name = "panel9";
            panel9.Size = new Size(339, 50);
            panel9.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 6;
            label6.Text = "Palivo:";
            // 
            // cmbPalivo
            // 
            cmbPalivo.BackColor = SystemColors.ControlLightLight;
            cmbPalivo.FormattingEnabled = true;
            cmbPalivo.Location = new Point(68, 13);
            cmbPalivo.Name = "cmbPalivo";
            cmbPalivo.Size = new Size(268, 33);
            cmbPalivo.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.Controls.Add(label8);
            panel15.Controls.Add(txtProdejce);
            panel15.Location = new Point(3, 395);
            panel15.Name = "panel15";
            panel15.Size = new Size(339, 50);
            panel15.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 4;
            label8.Text = "Prodejce:";
            // 
            // txtProdejce
            // 
            txtProdejce.BackColor = SystemColors.ControlLightLight;
            txtProdejce.Location = new Point(105, 9);
            txtProdejce.Name = "txtProdejce";
            txtProdejce.Size = new Size(231, 31);
            txtProdejce.TabIndex = 3;
            txtProdejce.TextAlign = HorizontalAlignment.Center;
            // 
            // panel16
            // 
            panel16.Controls.Add(label9);
            panel16.Controls.Add(txtKontakt);
            panel16.Location = new Point(3, 451);
            panel16.Name = "panel16";
            panel16.Size = new Size(339, 50);
            panel16.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 4;
            label9.Text = "Kontakt:";
            // 
            // txtKontakt
            // 
            txtKontakt.BackColor = SystemColors.ControlLightLight;
            txtKontakt.Location = new Point(89, 9);
            txtKontakt.Name = "txtKontakt";
            txtKontakt.Size = new Size(247, 31);
            txtKontakt.TabIndex = 3;
            txtKontakt.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel17);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(348, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 512);
            panel2.TabIndex = 3;
            // 
            // panel17
            // 
            panel17.Controls.Add(pbFotoVozidla);
            panel17.Controls.Add(panel10);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(430, 512);
            panel17.TabIndex = 2;
            // 
            // pbFotoVozidla
            // 
            pbFotoVozidla.BackColor = Color.WhiteSmoke;
            pbFotoVozidla.Dock = DockStyle.Fill;
            pbFotoVozidla.Location = new Point(0, 0);
            pbFotoVozidla.Name = "pbFotoVozidla";
            pbFotoVozidla.Size = new Size(430, 397);
            pbFotoVozidla.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoVozidla.TabIndex = 2;
            pbFotoVozidla.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.Controls.Add(panel12);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 397);
            panel10.Name = "panel10";
            panel10.Size = new Size(430, 115);
            panel10.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnUlozit);
            panel12.Location = new Point(6, 76);
            panel12.Name = "panel12";
            panel12.Size = new Size(421, 36);
            panel12.TabIndex = 1;
            // 
            // btnUlozit
            // 
            btnUlozit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUlozit.AutoSize = true;
            btnUlozit.DialogResult = DialogResult.OK;
            btnUlozit.ImageAlign = ContentAlignment.MiddleLeft;
            btnUlozit.Location = new Point(0, 0);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new Size(421, 36);
            btnUlozit.TabIndex = 0;
            btnUlozit.TabStop = false;
            btnUlozit.Text = "Přidat inzerát";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += btnUlozit_Click_1;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnNahratFoto);
            panel11.Location = new Point(6, 8);
            panel11.Name = "panel11";
            panel11.Size = new Size(421, 62);
            panel11.TabIndex = 0;
            // 
            // btnNahratFoto
            // 
            btnNahratFoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNahratFoto.AutoSize = true;
            btnNahratFoto.BackColor = Color.White;
            btnNahratFoto.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNahratFoto.Image = (Image)resources.GetObject("btnNahratFoto.Image");
            btnNahratFoto.ImageAlign = ContentAlignment.MiddleLeft;
            btnNahratFoto.Location = new Point(0, 0);
            btnNahratFoto.Name = "btnNahratFoto";
            btnNahratFoto.Padding = new Padding(20, 0, 0, 0);
            btnNahratFoto.Size = new Size(421, 62);
            btnNahratFoto.TabIndex = 2;
            btnNahratFoto.Text = "Nahrát fotku";
            btnNahratFoto.UseVisualStyleBackColor = false;
            btnNahratFoto.Click += btnNahratFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPridatVozidlo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 564);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FormPridatVozidlo";
            Text = "FormPridatVozidlo";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel14.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel2.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFotoVozidla).EndInit();
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtModel;
        private TextBox txtVin;
        private Panel panel5;
        private TextBox txtRokVyroby;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtKilometry;
        private Panel panel8;
        private TextBox txtCena;
        private Panel panel9;
        private ComboBox cmbPalivo;
        private Label label1;
        private Panel panel10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbMena;
        private Panel panel11;
        private Button btnNahratFoto;
        private OpenFileDialog openFileDialog1;
        private Panel panel12;
        private Button btnUlozit;
        private Panel panel13;
        private Label label7;
        private ComboBox cmbZnacka;
        private Panel panel14;
        private Button btnZpet;
        private Panel panel15;
        private Label label8;
        private TextBox txtProdejce;
        private Panel panel16;
        private Label label9;
        private TextBox txtKontakt;
        private Panel panel17;
        private PictureBox pbFotoVozidla;
    }
}