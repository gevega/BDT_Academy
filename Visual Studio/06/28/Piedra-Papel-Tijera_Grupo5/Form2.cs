using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Piedra_Papel_Tijera_Grupo5
{
    public partial class Form2 : Form
    {
        List<string> nomList = new List<string>();
        int jug = 0, cant = 0, cont = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego(nomList, jug, cant);
            this.Hide();
            juego.ShowDialog();
            this.Close();
        }

        private void btnAcept1_Click(object sender, EventArgs e)
        {
            jug = int.TryParse(txtjug.Text, out int res1)? Convert.ToInt16(txtjug.Text) : 0;
            cant = int.TryParse(txtcant.Text, out int res2) ? Convert.ToInt16(txtcant.Text) : 0;
            ValidarNum(jug, 1, 10, txtjug);
            ValidarNum(cant, 1, 10, txtcant);

            if (errorProvider1.GetError(txtjug) == "" && errorProvider1.GetError(txtcant) == "")
            {
                txtjug.Enabled = false;
                txtcant.Enabled = false;
                btnAcept1.Enabled = false;
                txtnom.Enabled = true;
                btnadd.Enabled = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string nomAdd = txtnom.Text;

            if (validarString(nomAdd, txtnom) && cont != jug)
            {
                nomList.Add(nomAdd);
                lstnom.ItemHeight = cant;
                lstnom.Items.Add(txtnom.Text);
                txtnom.Clear();
                txtnom.Focus();
                cont++;
            }
            if (cont == jug)
            {
                txtnom.Enabled = false;
                btnadd.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        public void ValidarNum(int var, int piso, int tope, Control element)
        {
            if (var < piso || var > tope)
            {
                errorProvider1.SetError(element, "Ingresar numero entre 1 y 10");
            }
            else
            {
                errorProvider1.SetError(element, "");
            }
        }

        public bool validarString(string var, Control element)
        {
            if (String.IsNullOrEmpty(var) || String.IsNullOrWhiteSpace(var))
            {
                errorProvider1.SetError(element, "La cadena no puede ser vacía");
                return false;
            }
            else if (nomList.Contains(var))
            {
                errorProvider1.SetError(element, "El nombre ya existe");
                return false;
            }
            else
            {
                errorProvider1.SetError(element, "");
                return true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            txtnom.Enabled = false;
            btnadd.Enabled = false;
            btnStart.Enabled = false;
        }
    }
}
