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
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPingPong));
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picSchlaegerRechts = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovsBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlaegerRechts = new System.Windows.Forms.VScrollBar();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHoch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlaegerRechts);
            this.pnlSpiel.Controls.Add(this.shapeContainer1);
            this.pnlSpiel.Location = new System.Drawing.Point(38, 25);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(600, 300);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picSchlaegerRechts
            // 
            this.picSchlaegerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlaegerRechts.Location = new System.Drawing.Point(591, 3);
            this.picSchlaegerRechts.Name = "picSchlaegerRechts";
            this.picSchlaegerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlaegerRechts.TabIndex = 1;
            this.picSchlaegerRechts.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovsBall});
            this.shapeContainer1.Size = new System.Drawing.Size(598, 298);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.Yellow;
            this.ovsBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsBall.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ovsBall.Location = new System.Drawing.Point(262, 113);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.Size = new System.Drawing.Size(25, 25);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(39, 378);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 120;
            this.tmrSpiel.Tick += new System.EventHandler(this.TmrSpiel_Tick);
            // 
            // vsbSchlaegerRechts
            // 
            this.vsbSchlaegerRechts.Location = new System.Drawing.Point(637, 25);
            this.vsbSchlaegerRechts.Name = "vsbSchlaegerRechts";
            this.vsbSchlaegerRechts.Size = new System.Drawing.Size(17, 300);
            this.vsbSchlaegerRechts.TabIndex = 2;
            this.vsbSchlaegerRechts.Value = 50;
            this.vsbSchlaegerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VsbSchlaegerRechts_Scroll);
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte.Location = new System.Drawing.Point(35, 344);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(64, 18);
            this.lblPunkte.TabIndex = 4;
            this.lblPunkte.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunkte.Location = new System.Drawing.Point(105, 341);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(67, 31);
            this.txtPunkte.TabIndex = 5;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Image = ((System.Drawing.Image)(resources.GetObject("btnHoch.Image")));
            this.btnHoch.Location = new System.Drawing.Point(769, 139);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(37, 23);
            this.btnHoch.TabIndex = 7;
            this.btnHoch.Tag = "ho";
            this.btnHoch.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(778, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Image = ((System.Drawing.Image)(resources.GetObject("btnRechts.Image")));
            this.btnRechts.Location = new System.Drawing.Point(793, 164);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(24, 23);
            this.btnRechts.TabIndex = 9;
            this.btnRechts.Tag = "re";
            this.btnRechts.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 96);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tastatursteuerung:\r\n Taste\r\n     H        Horizontale Flugrichtung umkehren\r\n    " +
    " V         Vertikale Flugrichtung umkehren\r\n     P         Spiel Pausieren\r\n    " +
    " S         Spiel weiterlaufen lassen";
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.vsbSchlaegerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.FrmPingPong_Load);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSpiel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovsBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picSchlaegerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlaegerRechts;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Label label1;
    }
}

