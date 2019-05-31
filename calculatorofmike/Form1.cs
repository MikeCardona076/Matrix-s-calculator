using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorofMike
{
    public partial class CUADROPRINCIPAL : Form
    {
        public CUADROPRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A2_TextChanged(object sender, EventArgs e)
        {

        }

        private void accion_Click(object sender, EventArgs e)
        {
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int matriz_1 = int.Parse(A1.Text);
            int matriz2_1 = int.Parse(D1.Text);
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int matriz_1 = int.Parse(A1.Text);
            int matriz_2 = int.Parse(A2.Text);
            int matriz_3 = int.Parse(A3.Text);

            int matriz_4 = int.Parse(B1.Text);
            int matriz_5 = int.Parse(B2.Text);
            int matriz_6 = int.Parse(B3.Text);

            int matriz_7 = int.Parse(C1.Text);
            int matriz_8 = int.Parse(C2.Text);
            int matriz_9 = int.Parse(C3.Text);


            int matriz2_1 = int.Parse(D1.Text);
            int matriz2_2 = int.Parse(D2.Text);
            int matriz2_3 = int.Parse(D3.Text);

            int matriz2_4 = int.Parse(E1.Text);
            int matriz2_5 = int.Parse(E2.Text);
            int matriz2_6 = int.Parse(E3.Text);

            int matriz2_7 = int.Parse(F1.Text);
            int matriz2_8 = int.Parse(F2.Text);
            int matriz2_9 = int.Parse(F3.Text);

            G1.Text = Convert.ToString(matriz_1 + matriz2_1);
            G2.Text = Convert.ToString(matriz_2 + matriz2_2);
            G3.Text = Convert.ToString(matriz_3 + matriz2_3);

            H1.Text = Convert.ToString(matriz_4 + matriz2_4);
            H2.Text = Convert.ToString(matriz_5 + matriz2_5);
            H3.Text = Convert.ToString(matriz_6 + matriz2_6);

            I1.Text = Convert.ToString(matriz_7 + matriz2_7);
            I2.Text = Convert.ToString(matriz_8 + matriz2_8);
            I3.Text = Convert.ToString(matriz_9 + matriz2_9);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int matriz_1 = int.Parse(A1.Text);
            int matriz_2 = int.Parse(A2.Text);
            int matriz_3 = int.Parse(A3.Text);

            int matriz_4 = int.Parse(B1.Text);
            int matriz_5 = int.Parse(B2.Text);
            int matriz_6 = int.Parse(B3.Text);

            int matriz_7 = int.Parse(C1.Text);
            int matriz_8 = int.Parse(C2.Text);
            int matriz_9 = int.Parse(C3.Text);


            int matriz2_1 = int.Parse(D1.Text);
            int matriz2_2 = int.Parse(D2.Text);
            int matriz2_3 = int.Parse(D3.Text);

            int matriz2_4 = int.Parse(E1.Text);
            int matriz2_5 = int.Parse(E2.Text);
            int matriz2_6 = int.Parse(E3.Text);

            int matriz2_7 = int.Parse(F1.Text);
            int matriz2_8 = int.Parse(F2.Text);
            int matriz2_9 = int.Parse(F3.Text);

            G1.Text = Convert.ToString(matriz_1 - matriz2_1);
            G2.Text = Convert.ToString(matriz_2 - matriz2_2);
            G3.Text = Convert.ToString(matriz_3 - matriz2_3);

            H1.Text = Convert.ToString(matriz_4 - matriz2_4);
            H2.Text = Convert.ToString(matriz_5 - matriz2_5);
            H3.Text = Convert.ToString(matriz_6 - matriz2_6);

            I1.Text = Convert.ToString(matriz_7 - matriz2_7);
            I2.Text = Convert.ToString(matriz_8 - matriz2_8);
            I3.Text = Convert.ToString(matriz_9 - matriz2_9);

        }

        private void A1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
