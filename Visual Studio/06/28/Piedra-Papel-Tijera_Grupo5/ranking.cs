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
    public partial class ranking : Form
    {
        List<string> nombres = new List<string>();
        int[] puntos_c = new int[0];
        public ranking(List<string> nom, int[] puntos)
        {
            InitializeComponent();
            nombres = nom;
            puntos_c = puntos;
            Array.Resize(ref puntos, nombres.Count);
        }

        private void ranking_Load(object sender, EventArgs e)
        {
            String[] nom_c = new string[nombres.Count];
            for (int i = 0; i < nombres.Count; i++)
            {
                nom_c[i] = nombres[i];
            }
            Array.Sort(puntos_c, nom_c);
            Array.Reverse(puntos_c);
            Array.Reverse(nom_c);
            for (int j = 0; j < nombres.Count; j++)
            {
                lstRank.Items.Add($"{nombres[j]}  |  {puntos_c[j]} puntos");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
