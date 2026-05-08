namespace BCSH1_SemestralniPrace_Suttner.Forms
{
    partial class FormHlavni
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHlavni));
            notifyIcon1 = new NotifyIcon(components);
            flpanelLeft = new FlowLayoutPanel();
            panel2 = new Panel();
            btnInzerce = new Button();
            panel3 = new Panel();
            btnPridatVozidlo = new Button();
            panelTop = new Panel();
            pbResize = new PictureBox();
            panelInzeraty = new FlowLayoutPanel();
            flpanelLeft.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResize).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "Autobazar";
            notifyIcon1.Visible = true;
            // 
            // flpanelLeft
            // 
            flpanelLeft.BackColor = Color.Black;
            flpanelLeft.Controls.Add(panel2);
            flpanelLeft.Controls.Add(panel3);
            flpanelLeft.Dock = DockStyle.Left;
            flpanelLeft.Location = new Point(0, 50);
            flpanelLeft.Name = "flpanelLeft";
            flpanelLeft.Size = new Size(194, 494);
            flpanelLeft.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInzerce);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 62);
            panel2.TabIndex = 1;
            // 
            // btnInzerce
            // 
            btnInzerce.BackColor = Color.Black;
            btnInzerce.FlatStyle = FlatStyle.Flat;
            btnInzerce.Font = new Font("Segoe UI Semilight", 10F);
            btnInzerce.ForeColor = Color.White;
            btnInzerce.Image = (Image)resources.GetObject("btnInzerce.Image");
            btnInzerce.ImageAlign = ContentAlignment.MiddleLeft;
            btnInzerce.Location = new Point(-10, -10);
            btnInzerce.Name = "btnInzerce";
            btnInzerce.Padding = new Padding(25, 0, 0, 0);
            btnInzerce.Size = new Size(220, 80);
            btnInzerce.TabIndex = 4;
            btnInzerce.Text = "        Inzerce";
            btnInzerce.TextAlign = ContentAlignment.MiddleLeft;
            btnInzerce.UseVisualStyleBackColor = false;
            btnInzerce.Click += btnInzerce_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPridatVozidlo);
            panel3.Location = new Point(0, 62);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 62);
            panel3.TabIndex = 2;
            // 
            // btnPridatVozidlo
            // 
            btnPridatVozidlo.BackColor = Color.Black;
            btnPridatVozidlo.FlatStyle = FlatStyle.Flat;
            btnPridatVozidlo.Font = new Font("Segoe UI Semilight", 10F);
            btnPridatVozidlo.ForeColor = Color.White;
            btnPridatVozidlo.Image = (Image)resources.GetObject("btnPridatVozidlo.Image");
            btnPridatVozidlo.ImageAlign = ContentAlignment.MiddleLeft;
            btnPridatVozidlo.Location = new Point(-10, -10);
            btnPridatVozidlo.Name = "btnPridatVozidlo";
            btnPridatVozidlo.Padding = new Padding(25, 0, 0, 0);
            btnPridatVozidlo.Size = new Size(220, 80);
            btnPridatVozidlo.TabIndex = 5;
            btnPridatVozidlo.Text = "        Přidat vozidlo";
            btnPridatVozidlo.TextAlign = ContentAlignment.MiddleLeft;
            btnPridatVozidlo.UseVisualStyleBackColor = false;
            btnPridatVozidlo.Click += btnPridatVozidlo_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(pbResize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(928, 50);
            panelTop.TabIndex = 3;
            // 
            // pbResize
            // 
            pbResize.Dock = DockStyle.Left;
            pbResize.Image = (Image)resources.GetObject("pbResize.Image");
            pbResize.Location = new Point(0, 0);
            pbResize.Name = "pbResize";
            pbResize.Size = new Size(60, 50);
            pbResize.SizeMode = PictureBoxSizeMode.CenterImage;
            pbResize.TabIndex = 4;
            pbResize.TabStop = false;
            pbResize.Click += pbResize_Click;
            // 
            // panelInzeraty
            // 
            panelInzeraty.AutoScroll = true;
            panelInzeraty.BackColor = Color.DarkGray;
            panelInzeraty.Dock = DockStyle.Fill;
            panelInzeraty.Location = new Point(194, 50);
            panelInzeraty.Name = "panelInzeraty";
            panelInzeraty.Size = new Size(734, 494);
            panelInzeraty.TabIndex = 4;
            // 
            // FormHlavni
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 544);
            Controls.Add(panelInzeraty);
            Controls.Add(flpanelLeft);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormHlavni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autobazar Suttner";
            flpanelLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private FlowLayoutPanel flpanelLeft;
        private Panel panel2;
        private Button btnInzerce;
        private Panel panelTop;
        private FlowLayoutPanel panelInzeraty;
        private PictureBox pbResize;
        private Panel panel3;
        private Button btnPridatVozidlo;
    }
}