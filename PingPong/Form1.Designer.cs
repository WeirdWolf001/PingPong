namespace PingPong
{
    partial class frmPingPong
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmPingPong));
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.ovsBall = new System.Windows.Forms.PictureBox();
            this.picSchlaegerRechts = new System.Windows.Forms.PictureBox();
            this.j = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlaegerRechts = new System.Windows.Forms.VScrollBar();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHoch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ovsBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picSchlaegerRechts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pnlSpiel.BackgroundImage")));
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.ovsBall);
            this.pnlSpiel.Controls.Add(this.picSchlaegerRechts);
            this.pnlSpiel.Location = new System.Drawing.Point(63, 48);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(999, 574);
            this.pnlSpiel.TabIndex = 0;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.Blue;
            this.ovsBall.Location = new System.Drawing.Point(235, 438);
            this.ovsBall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.Size = new System.Drawing.Size(35, 35);
            this.ovsBall.TabIndex = 2;
            this.ovsBall.TabStop = false;
            this.ovsBall.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picSchlaegerRechts
            // 
            this.picSchlaegerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlaegerRechts.Location = new System.Drawing.Point(984, 6);
            this.picSchlaegerRechts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picSchlaegerRechts.Name = "picSchlaegerRechts";
            this.picSchlaegerRechts.Size = new System.Drawing.Size(7, 78);
            this.picSchlaegerRechts.TabIndex = 1;
            this.picSchlaegerRechts.TabStop = false;
            // 
            // j
            // 
            this.j.BackColor = System.Drawing.Color.Yellow;
            this.j.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.j.Location = new System.Drawing.Point(27, 3);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(1, 1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(64, 728);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 5;
            this.tmrSpiel.Tick += new System.EventHandler(this.TmrSpiel_Tick);
            // 
            // vsbSchlaegerRechts
            // 
            this.vsbSchlaegerRechts.Location = new System.Drawing.Point(1062, 48);
            this.vsbSchlaegerRechts.Name = "vsbSchlaegerRechts";
            this.vsbSchlaegerRechts.Size = new System.Drawing.Size(17, 578);
            this.vsbSchlaegerRechts.TabIndex = 2;
            this.vsbSchlaegerRechts.Value = 50;
            this.vsbSchlaegerRechts.Scroll +=
                new System.Windows.Forms.ScrollEventHandler(this.VsbSchlaegerRechts_Scroll);
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPunkte.Location = new System.Drawing.Point(58, 661);
            this.lblPunkte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(95, 28);
            this.lblPunkte.TabIndex = 4;
            this.lblPunkte.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPunkte.Location = new System.Drawing.Point(176, 656);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(108, 42);
            this.txtPunkte.TabIndex = 5;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1256, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Image = ((System.Drawing.Image) (resources.GetObject("btnHoch.Image")));
            this.btnHoch.Location = new System.Drawing.Point(1282, 268);
            this.btnHoch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(62, 44);
            this.btnHoch.TabIndex = 7;
            this.btnHoch.Tag = "ho";
            this.btnHoch.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1297, 371);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {this.j});
            this.shapeContainer2.Size = new System.Drawing.Size(1563, 1010);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 1010);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.vsbSchlaegerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Controls.Add(this.shapeContainer2);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.FrmPingPong_Load);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.ovsBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picSchlaegerRechts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picSchlaegerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlaegerRechts;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button button3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape j;
        private System.Windows.Forms.PictureBox ovsBall;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}

