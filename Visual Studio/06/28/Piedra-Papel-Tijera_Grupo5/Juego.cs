using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra_Papel_Tijera_Grupo5
{
    public partial class Juego : Form
    {
        int[] opc_per = new int[] { 1, 2, 0 };
        List<string> nombres = new List<string>();
        int[] puntos = new int[0];
        int[] puntos_parc = new int[] { 0, 0, 0 };

        int jug_c, cant_c, cont = 0, contJug = 0;
        public Juego(List<string> nom, int jug, int cant)
        {
            InitializeComponent();
            nombres = nom;
            jug_c = jug;
            cant_c = cant;
            Array.Resize(ref puntos, nombres.Count);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            lblGan.Visible = true;
            lblPer.Visible = true;
            lblEm.Visible = true;
            string[] opc = new string[] { "Piedra", "Papel", "Tijera" };
            int elec = rbPiedra.Checked ? 0 : rbPapel.Checked ? 1 : 2;
            Random num = new Random();
            int num_t = Convert.ToInt16(num.Next(0, 3));

            if (opc_per[elec] == num_t)
            {
                lblRes.Visible = true;
                lblRes.Text = $"Elegí {opc[num_t]}, perdiste";
                puntos[contJug] = puntos[contJug] - 1;
                lblRes.ForeColor = Color.Red;
                puntos_parc[1]++;
                lblPer.Text = $"G:{puntos_parc[1]}";
            }
            else if (opc_per[elec] != num_t && elec != num_t)
            {
                lblRes.Visible = true;
                lblRes.Text = $"Elegí {opc[num_t]}, ganaste";
                puntos[contJug] = puntos[contJug] + 2;
                lblRes.ForeColor = Color.Green;
                puntos_parc[0]++;
                lblGan.Text = $"P:{puntos_parc[0]}";
            }
            else
            {
                lblRes.Visible = true;
                lblRes.Text = $"Elegí {opc[num_t]}, empate";
                lblRes.ForeColor = Color.Black;
                puntos_parc[2]++;
                lblEm.Text = $"E:{puntos_parc[2]}";
            }
            btnJugar.Visible = false;
            if (cont == cant_c - 1)
            {
                btnFin.Visible = true;
                lblFin.Visible = true;
                if (puntos_parc[0] > puntos_parc[1])
                {
                    lblFin.Text = "GANASTE";
                    lblFin.ForeColor = Color.Green;
                }
                else if (puntos_parc[1] > puntos_parc[0])
                {
                    lblFin.Text = "PERDISTE";
                    lblFin.ForeColor = Color.Red;
                }
                else
                {
                    lblFin.Text = "EMPATE";
                    lblFin.ForeColor = Color.Black;
                }
            }
            else
            { btnNext.Visible = true; }
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            lblWel.Text = $"¡Bienvenido {nombres[contJug]}!";
            lblRound.Text = $"Ronda N°{cont + 1}";
            lblGan.Visible = false;
            lblPer.Visible = false;
            lblEm.Visible = false;
            lblRes.Visible = false;
            btnNext.Visible = false;
            btnFin.Visible = false;
            lblFin.Visible = false;
            btnRank.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnJugar.Visible = true;
            btnNext.Visible = false;
            lblRes.Visible = false;
            cont++;
            lblRound.Text = $"Ronda N°{cont + 1}";
            if (cont == cant_c)
            {
                btnJugar.Visible = false;
                btnFin.Visible = true;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            contJug++;
            if (contJug < jug_c)
            {
                cont = 0;
                lblWel.Text = $"¡Bienvenido {nombres[contJug]}!";
                lblRound.Text = $"Ronda N°{cont + 1}";
                lblGan.Visible = false;
                lblPer.Visible = false;
                lblEm.Visible = false;
                lblFin.Visible = false;
                lblRes.Visible = false;
                btnFin.Visible = false;
                btnJugar.Visible = true;

                for (int i = 0; i < puntos_parc.Length; i++)
                {
                    puntos_parc[i] = 0;
                }
            }
            else
            {
                btnFin.Visible = false;
                btnRank.Visible = true;
            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            ranking rank = new ranking(nombres, puntos);
            this.Hide();
            rank.ShowDialog();
            this.Close();
        }
    }
}
