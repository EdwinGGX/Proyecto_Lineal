using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussJordan
{
    public partial class Form1 : Form
    {
        double[,] matriz = new double[3, 4];
        public Form1()
        {
            InitializeComponent();
        }
        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (verificarInfo())
            {
                if (obtenerMatriz())
                {
                    buscarPivoteIntercambiar(matriz);
                    algoritmoGauss(matriz);
                    dibujarResultado(matriz);
                }
            }
            else { MessageBox.Show("Llene la matriz"); }
        }
        private Boolean verificarInfo()
        {
            foreach (Control txt in tlpMatriz.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private Boolean obtenerMatriz()
        {
            try
            {
                foreach (Control txt in tlpMatriz.Controls)
                {
                    if (txt is TextBox)
                    {
                        string nom = txt.Name;
                        int posX = Convert.ToInt32(nom.Substring(1, 1));
                        int posY = Convert.ToInt32(nom.Substring(2, 1));
                        matriz[posX, posY] = Convert.ToDouble(txt.Text);
                    }
                }
                int tamMatrizX = matriz.GetUpperBound(1);
                int tamMatrizY = matriz.GetUpperBound(0);
                rchTeOperaciones.Text += "" + Environment.NewLine + Environment.NewLine;
                rchTeOperaciones.Text += "Matriz aumentada: " + Environment.NewLine + Environment.NewLine;
                for (int i = 0; i <= tamMatrizY; i++)
                {
                    for (int j = 0; j <= tamMatrizX; j++)
                    {
                        rchTeOperaciones.Text += "   " + matriz[i, j] + "     ";

                    }
                    rchTeOperaciones.Text += Environment.NewLine;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void buscarPivoteIntercambiar(Double[,] matriz)
        {
            int tamMatriz = matriz.GetUpperBound(1);
            int pivote = 0;
            rchTeOperaciones.Text += " " + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < tamMatriz; i++)
            {
                if (matriz[pivote, pivote] != 1)
                {

                    for (int r = 0; r < tamMatriz; r++)
                    {
                        if (Convert.ToString(matriz[r, i]) == "1" && ((r + i) != (pivote + pivote)))
                        {
                            rchTeOperaciones.Text += "Pivote:" + i + Environment.NewLine;

                            for (int j = 0; j < tamMatriz + 1; j++)
                            {
                                Double temp = matriz[pivote, j];
                                matriz[pivote, j] = matriz[r, j];
                                matriz[r, j] = temp;
                            }
                            rchTeOperaciones.Text += "* Se cambia renglon: " + i + " por renglon: " + r + Environment.NewLine;
                            rchTeOperaciones.Text += "" + Environment.NewLine + Environment.NewLine;
                            rchTeOperaciones.Text += "La nueva matriz aumentada  es: " + Environment.NewLine + Environment.NewLine;
                            for (int re = 0; re <= 2; re++)
                            {

                                for (int j = 0; j <= 3; j++)
                                {
                                    rchTeOperaciones.Text += "   " + matriz[re, j] + "     ";

                                }

                                rchTeOperaciones.Text += Environment.NewLine;

                            }
                            buscarPivoteIntercambiar(matriz);
                        }
                    }
                }
                pivote++;
            }
        }
        private void dibujarResultado(Double[,] matriz)
        {
            int tamMatriz = matriz.GetUpperBound(1);
            rchTeOperaciones.Text += Environment.NewLine;
            rchTeOperaciones.Text += "------- Resultados -------- " + Environment.NewLine;
            for (int i = 0; i <= tamMatriz - 1; i++)
            {
                rchTeOperaciones.Text += "Resultado X" + i + " : " + matriz[i, tamMatriz] + Environment.NewLine;
            }
            rchTeOperaciones.Text += "------------------------------" + Environment.NewLine;
        }
        private void algoritmoGauss(Double[,] matriz)
        {
            int tamMatriz = matriz.GetUpperBound(1);
            int pivote = 0;

            for (int i = 0; i <= tamMatriz - 1; i++)
            {
                if (matriz[i, i] == 0)
                {
                    rchTeOperaciones.Text +=  "La ecuación no tiene solución :(";
                }
                else
                {
                    if (matriz[i, i] != 1)
                    {
                        Double divisorPiv = matriz[i, i];
                        for (int col = 0; col <= tamMatriz; col++)
                        {
                            matriz[i, col] = matriz[i, col] / divisorPiv;
                        }
                    }
                    for (int ren = 0; ren < tamMatriz; ren++)
                    {
                        if (ren != pivote)
                        {
                            Double val0 = -Convert.ToDouble(matriz[ren, i]);
                            for (int col = 0; col <= tamMatriz; col++)
                            {
                                matriz[ren, col] = matriz[i, col] * val0 + matriz[ren, col];
                            }
                        }
                    }
                }
                pivote++;
            }
        }
    }
}
