namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    partial class FormDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetail));
            panel1 = new Panel();
            btnZpet = new Button();
            lblNazev = new Label();
            panel3 = new Panel();
            panel10 = new Panel();
            btnSmazat = new Button();
            btnUpravit = new Button();
            pbVelkaFotka = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            lblVin = new Label();
            panel2 = new Panel();
            lblRokVyroby = new Label();
            panel5 = new Panel();
            lblKilometry = new Label();
            panel6 = new Panel();
            lblPalivo = new Label();
            panel7 = new Panel();
            lblCena = new Label();
            panel8 = new Panel();
            lblProdejceJmeno = new Label();
            panel9 = new Panel();
            lblProdejceKontakt = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVelkaFotka).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnZpet);
            panel1.Controls.Add(lblNazev);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 50);
            panel1.TabIndex = 0;
            // 
            // btnZpet
            // 
            btnZpet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZpet.DialogResult = DialogResult.Cancel;
            btnZpet.Image = (Image)resources.GetObject("btnZpet.Image");
            btnZpet.Location = new Point(872, 3);
            btnZpet.Name = "btnZpet";
            btnZpet.Size = new Size(53, 44);
            btnZpet.TabIndex = 1;
            btnZpet.UseVisualStyleBackColor = true;
            btnZpet.Click += btnZpet_Click;
            // 
            // lblNazev
            // 
            lblNazev.AutoSize = true;
            lblNazev.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazev.Location = new Point(12, 9);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(0, 32);
            lblNazev.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(pbVelkaFotka);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(428, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 394);
            panel3.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSmazat);
            panel10.Controls.Add(btnUpravit);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 339);
            panel10.Name = "panel10";
            panel10.Size = new Size(500, 55);
            panel10.TabIndex = 2;
            // 
            // btnSmazat
            // 
            btnSmazat.Location = new Point(232, 9);
            btnSmazat.Name = "btnSmazat";
            btnSmazat.Size = new Size(265, 34);
            btnSmazat.TabIndex = 1;
            btnSmazat.Text = "Smazat";
            btnSmazat.UseVisualStyleBackColor = true;
            btnSmazat.Click += btnSmazat_Click;
            // 
            // btnUpravit
            // 
            btnUpravit.Location = new Point(6, 9);
            btnUpravit.Name = "btnUpravit";
            btnUpravit.Size = new Size(220, 34);
            btnUpravit.TabIndex = 0;
            btnUpravit.Text = "Upravit";
            btnUpravit.UseVisualStyleBackColor = true;
            btnUpravit.Click += btnUpravit_Click;
            // 
            // pbVelkaFotka
            // 
            pbVelkaFotka.BackColor = Color.LightGray;
            pbVelkaFotka.Dock = DockStyle.Top;
            pbVelkaFotka.Location = new Point(0, 0);
            pbVelkaFotka.Name = "pbVelkaFotka";
            pbVelkaFotka.Size = new Size(500, 339);
            pbVelkaFotka.SizeMode = PictureBoxSizeMode.Zoom;
            pbVelkaFotka.TabIndex = 3;
            pbVelkaFotka.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(428, 394);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblVin);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(417, 50);
            panel4.TabIndex = 1;
            // 
            // lblVin
            // 
            lblVin.AutoSize = true;
            lblVin.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblVin.Location = new Point(9, 13);
            lblVin.Name = "lblVin";
            lblVin.Size = new Size(0, 28);
            lblVin.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblRokVyroby);
            panel2.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            panel2.Location = new Point(3, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 50);
            panel2.TabIndex = 2;
            // 
            // lblRokVyroby
            // 
            lblRokVyroby.AutoSize = true;
            lblRokVyroby.Location = new Point(9, 13);
            lblRokVyroby.Name = "lblRokVyroby";
            lblRokVyroby.Size = new Size(0, 28);
            lblRokVyroby.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblKilometry);
            panel5.Location = new Point(3, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(417, 50);
            panel5.TabIndex = 3;
            // 
            // lblKilometry
            // 
            lblKilometry.AutoSize = true;
            lblKilometry.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblKilometry.Location = new Point(9, 13);
            lblKilometry.Name = "lblKilometry";
            lblKilometry.Size = new Size(0, 28);
            lblKilometry.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblPalivo);
            panel6.Location = new Point(3, 171);
            panel6.Name = "panel6";
            panel6.Size = new Size(417, 50);
            panel6.TabIndex = 4;
            // 
            // lblPalivo
            // 
            lblPalivo.AutoSize = true;
            lblPalivo.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblPalivo.Location = new Point(9, 11);
            lblPalivo.Name = "lblPalivo";
            lblPalivo.Size = new Size(0, 28);
            lblPalivo.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblCena);
            panel7.Location = new Point(3, 227);
            panel7.Name = "panel7";
            panel7.Size = new Size(417, 50);
            panel7.TabIndex = 5;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblCena.Location = new Point(9, 13);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(0, 28);
            lblCena.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblProdejceJmeno);
            panel8.Location = new Point(3, 283);
            panel8.Name = "panel8";
            panel8.Size = new Size(417, 50);
            panel8.TabIndex = 6;
            // 
            // lblProdejceJmeno
            // 
            lblProdejceJmeno.AutoSize = true;
            lblProdejceJmeno.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblProdejceJmeno.Location = new Point(9, 12);
            lblProdejceJmeno.Name = "lblProdejceJmeno";
            lblProdejceJmeno.Size = new Size(0, 28);
            lblProdejceJmeno.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(lblProdejceKontakt);
            panel9.Location = new Point(3, 339);
            panel9.Name = "panel9";
            panel9.Size = new Size(417, 50);
            panel9.TabIndex = 7;
            // 
            // lblProdejceKontakt
            // 
            lblProdejceKontakt.AutoSize = true;
            lblProdejceKontakt.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblProdejceKontakt.Location = new Point(9, 11);
            lblProdejceKontakt.Name = "lblProdejceKontakt";
            lblProdejceKontakt.Size = new Size(0, 28);
            lblProdejceKontakt.TabIndex = 1;
            // 
            // FormDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 444);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FormDetail";
            Text = "FormDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVelkaFotka).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pbVelkaFotka;
        private Label lblNazev;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label lblVin;
        private Panel panel2;
        private Label lblRokVyroby;
        private Panel panel5;
        private Label lblKilometry;
        private Panel panel6;
        private Label lblPalivo;
        private Panel panel7;
        private Label lblCena;
        private Panel panel8;
        private Label lblProdejceJmeno;
        private Panel panel9;
        private Label lblProdejceKontakt;
        private Button btnZpet;
        private Panel panel10;
        private Button btnSmazat;
        private Button btnUpravit;
    }
}