using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmPingPong : Form
    {
        int punkte;
        int XRichtung = 5;
        int YRichtung = 2;
        public frmPingPong()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Timer start
            tmrSpiel.Enabled = true;
            
        }

        private void TmrSpiel_Tick(object sender, EventArgs e)
        {
            txtPunkte.Text = punkte.ToString();

            //to find the location of the ball so we could points. 
            if(ovsBall.Location.X >= pnlSpiel.Width - ovsBall.Width - picSchlaegerRechts.Width &&
               ovsBall.Location.Y >= picSchlaegerRechts.Location.Y - ovsBall.Height &&
               ovsBall.Location.Y <= picSchlaegerRechts.Location.Y + picSchlaegerRechts.Height)
            {
                XRichtung = -XRichtung;
                punkte += 01;
            }
            // if the ball doesn't hit the bat well lose
            if (ovsBall.Location.X >= pnlSpiel.Width)
            {
                tmrSpiel.Enabled = false;
                MessageBox.Show("You Fucking SUCK!");
            }

            if(ovsBall.Location.Y >= pnlSpiel.Height - ovsBall.Height)
            {
                YRichtung = -YRichtung;
            }
            if(ovsBall.Location.X <= 0)
            {
                XRichtung = -XRichtung;
            }
            if(ovsBall.Location.Y <= 0)
            {
                YRichtung = -YRichtung;
            }

            ovsBall.Location = new Point(ovsBall.Location.X + XRichtung, ovsBall.Location.Y + YRichtung);
        }

        private void VsbSchlaegerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            //Schläger bewegt mit scrollbar 
            picSchlaegerRechts.Location = new Point(picSchlaegerRechts.Location.X, vsbSchlaegerRechts.Value);
        }

       

        private void FrmPingPong_Load(object sender, EventArgs e)
        {
            //Schläger ganz recht ins Panel setzen
            picSchlaegerRechts.Location = new Point(pnlSpiel.Width - picSchlaegerRechts.Width, pnlSpiel.Height / 2);
            //Scrollbar rechts neben Panel setzen
            vsbSchlaegerRechts.Location = new Point(pnlSpiel.Location.X + pnlSpiel.Width, pnlSpiel.Location.Y);
            //Grösse einstellen: gleiche Höhe wie Panel
            vsbSchlaegerRechts.Height = pnlSpiel.Height;
            //Minimum einstellen auf 0
            vsbSchlaegerRechts.Minimum = 0;
            //Maximum einstellen auf maximale Pixelzahl im Panel
            vsbSchlaegerRechts.Maximum = pnlSpiel.Height - picSchlaegerRechts.Height + vsbSchlaegerRechts.LargeChange;
            //aktuellen Wert einstellen von Schläger
            vsbSchlaegerRechts.Value = picSchlaegerRechts.Location.Y;
        }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.W)
            {
                ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y - 20); return true;
            }
            else if (keyData == Keys.S)
            {
                ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y + 20); return true;
            }
            else if (keyData == Keys.A)
            {
                ovsBall.Location = new Point(ovsBall.Location.X - 20, ovsBall.Location.Y); return true;
            }
            else if (keyData == Keys.D)
            {
                ovsBall.Location = new Point(ovsBall.Location.X + 20, ovsBall.Location.Y); return true;
            }
            else return base.ProcessDialogKey(keyData);
        }

    }
}
