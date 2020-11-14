using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.Kazan.FormsApp
{
    public partial class Form1 : Form
    {
        static int toplam = 0;
        static int sure = 7;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void tmrButton_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblSkor.Text = $"Skor:{toplam}";
            btn.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                tmrButton.Stop();

                DialogResult cevap = MessageBox.Show($"Skor:{toplam} \nYeniden başlamak ister misiniz?", "Oyun Bitti!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    sure = 7;
                    toplam = 0;
                    tmrSure.Start();
                    tmrButton.Start();
                }
                else
                {
                    Application.Exit();
                }


            }
        }
    }
}
