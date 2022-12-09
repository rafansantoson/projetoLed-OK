using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprojetoled
{
    public partial class LED : Form
    {
        private Leds leds;

        public LED()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }

        private void LED_Load(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(1))
            {
                leds.apagar(1);
            }
            else
            {
                leds.acender(1);
            }
            atualizaInterface();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(2))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            atualizaInterface();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(3))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);

            }
            atualizaInterface();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(4))
            {
                leds.apagar(4);
            }
            else
            {
                leds.acender(4);
            }
            atualizaInterface();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(5))
            {
                leds.apagar(5);
            }
            else
            {
                leds.acender(5);
            }
            atualizaInterface();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(6))
            {
                leds.apagar(6);
            }
            else
            {
                leds.acender(6);
            }
            atualizaInterface();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(7))
            {
                leds.apagar(7);
            }
            else
            {
                leds.acender(7);
            }
            atualizaInterface();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (leds.getEstado(8))
            {
                leds.apagar(8);
            }
            else
            {
                leds.acender(8);
            }
            atualizaInterface();
        }


        private void atualizaInterface()
        {
            btn1.Text = (leds.getEstado(1) ? "Off" : "ON");
            checkled1.Checked = (leds.getEstado(1) ? true : false);

            btn2.Text = (leds.getEstado(2) ? "Off" : "ON");
            checkled2.Checked = (leds.getEstado(2) ? true : false);

            btn3.Text = (leds.getEstado(3) ? "Off" : "ON");
            checkled3.Checked = (leds.getEstado(3) ? true : false);

            btn4.Text = (leds.getEstado(4) ? "Off" : "ON");
            checkled4.Checked = (leds.getEstado(4) ? true : false);

            btn5.Text = (leds.getEstado(5) ? "Off" : "ON");
            checkled5.Checked = (leds.getEstado(5) ? true : false);

            btn6.Text = (leds.getEstado(6) ? "Off" : "ON");
            checkled6.Checked = (leds.getEstado(6) ? true : false);

            btn7.Text = (leds.getEstado(7) ? "Off" : "ON");
            checkled7.Checked = (leds.getEstado(7) ? true : false);

            btn8.Text = (leds.getEstado(8) ? "Off" : "ON");
            checkled8.Checked = (leds.getEstado(8) ? true : false);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int x;

            x = int.Parse(txtLed.Text);

            leds.getEstado(x);

            checkstatus.Checked = (leds.getEstado(x) ? true : false);
            
        }
    }
}
