using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa_constructora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Categoria;

   
        public void button1_Click(object sender, EventArgs e)
        {

      

            Categoria = CboxCategoria.Text;
            switch (Categoria)
            {
                case "CategoriaA":
                    
                    double snetoa = 2.10 * Convert.ToDouble(TxtHoras.Text) + Convert.ToDouble(TxtBasico.Text);
                    LblNetoaPagar.Text = Convert.ToString(snetoa) + "  PESOS";
                    break;
               
                case "CategoriaB":

                    double snetob = 2.30 * Convert.ToDouble(TxtHoras.Text) + Convert.ToDouble(TxtBasico.Text);
                    LblNetoaPagar.Text = Convert.ToString(snetob)  + "  PESOS";
                    break;

                case "CategoriaC":

                    double snetoc = 2.80 * Convert.ToDouble(TxtHoras.Text) + Convert.ToDouble(TxtBasico.Text);
                    LblNetoaPagar.Text = Convert.ToString(snetoc) + "  PESOS";
                    break;

             }
           
        }

   
    }
}
