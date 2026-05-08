namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    partial class InzeratControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbFotoVozidla = new PictureBox();
            panel1 = new Panel();
            lblPopisModel = new Label();
            btnDetail = new Button();
            lblCena = new Label();
            lblRokVyroby = new Label();
            lblModel = new Label();
            lblPopisCena = new Label();
            lblPopisRokVyroby = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoVozidla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel1.Controls.Add(pbFotoVozidla);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(684, 150);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pbFotoVozidla
            // 
            pbFotoVozidla.BackColor = Color.LightGray;
            pbFotoVozidla.Location = new Point(3, 3);
            pbFotoVozidla.Name = "pbFotoVozidla";
            pbFotoVozidla.Size = new Size(236, 144);
            pbFotoVozidla.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoVozidla.TabIndex = 0;
            pbFotoVozidla.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblPopisModel);
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(lblCena);
            panel1.Controls.Add(lblRokVyroby);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(lblPopisCena);
            panel1.Controls.Add(lblPopisRokVyroby);
            panel1.Location = new Point(245, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 144);
            panel1.TabIndex = 1;
            // 
            // lblPopisModel
            // 
            lblPopisModel.AutoSize = true;
            lblPopisModel.Font = new Font("Segoe UI Semilight", 9F);
            lblPopisModel.Location = new Point(3, 12);
            lblPopisModel.Name = "lblPopisModel";
            lblPopisModel.Size = new Size(65, 25);
            lblPopisModel.TabIndex = 7;
            lblPopisModel.Text = "Model:";
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Segoe UI Semilight", 9F);
            btnDetail.Location = new Point(3, 107);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(430, 34);
            btnDetail.TabIndex = 6;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click_1;
            // 
            // lblCena
            // 
            lblCena.Font = new Font("Segoe UI Semilight", 9F);
            lblCena.Location = new Point(69, 79);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(200, 25);
            lblCena.TabIndex = 5;
            // 
            // lblRokVyroby
            // 
            lblRokVyroby.AutoSize = true;
            lblRokVyroby.Font = new Font("Segoe UI Semilight", 9F);
            lblRokVyroby.Location = new Point(115, 46);
            lblRokVyroby.Name = "lblRokVyroby";
            lblRokVyroby.Size = new Size(0, 25);
            lblRokVyroby.TabIndex = 4;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI Semilight", 9F);
            lblModel.Location = new Point(76, 12);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(0, 25);
            lblModel.TabIndex = 3;
            // 
            // lblPopisCena
            // 
            lblPopisCena.AutoSize = true;
            lblPopisCena.Font = new Font("Segoe UI Semilight", 9F);
            lblPopisCena.Location = new Point(3, 80);
            lblPopisCena.Name = "lblPopisCena";
            lblPopisCena.Size = new Size(60, 25);
            lblPopisCena.TabIndex = 2;
            lblPopisCena.Text = "Cena: ";
            // 
            // lblPopisRokVyroby
            // 
            lblPopisRokVyroby.AutoSize = true;
            lblPopisRokVyroby.Font = new Font("Segoe UI Semilight", 9F);
            lblPopisRokVyroby.Location = new Point(3, 46);
            lblPopisRokVyroby.Name = "lblPopisRokVyroby";
            lblPopisRokVyroby.Size = new Size(98, 25);
            lblPopisRokVyroby.TabIndex = 1;
            lblPopisRokVyroby.Text = "Rok výroby:";
            // 
            // InzeratControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "InzeratControl";
            Size = new Size(684, 150);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFotoVozidla).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pbFotoVozidla;
        private Panel panel1;
        private Button btnDetail;
        private Label lblCena;
        private Label lblRokVyroby;
        private Label lblModel;
        private Label lblPopisModel;
        private Label lblPopisCena; 
        private Label lblPopisRokVyroby; 
    }
}