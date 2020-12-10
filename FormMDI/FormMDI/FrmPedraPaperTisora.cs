using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmPedraPaperTisora : Form
    {
        public event EventHandler emTanquen;
        public FrmPedraPaperTisora()
        {
            InitializeComponent();
        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            quiGuanya(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            quiGuanya(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            quiGuanya(2);
        }

        private void quiGuanya(int jugador)
        {
            int pc;
            String opcio;
            Random r = new Random();
            pc = r.Next(0, 2);

            if (pc == 0) opcio = "piedra";
            else if (pc == 1) opcio = "papel";
            else opcio = "tijera";

            if (jugador == pc) MessageBox.Show("Los dos jugadores han sacado " + opcio, "EMPATE");
            else
            {
                if (jugador == 0)
                {
                    if (pc == 1) MessageBox.Show("Ha ganado el ordenador ya que " + opcio + " gana a piedra", "GANA ORDENADOR");
                    else MessageBox.Show("Has ganado al ordenador ya que piedra gana a " + opcio, "GANA JUGADOR");
                }
                else
                {
                    if (jugador == 1)
                    {
                        if (pc == 2) MessageBox.Show("Ha ganado el ordenador ya que " + opcio + " gana a papel", "GANA ORDENADOR");
                        else MessageBox.Show("Has ganado al ordenador ya que papel gana a " + opcio, "GANA JUGADOR");
                    }
                    else
                    {
                        if (pc == 0) MessageBox.Show("Ha ganado el ordenador ya que " + opcio + " gana a tijera", "GANA ORDENADOR");
                        else MessageBox.Show("Has ganado al ordenador ya que tijera gana a " + opcio, "GANA JUGADOR");
                    }
                }
            }
        }
    }
}
