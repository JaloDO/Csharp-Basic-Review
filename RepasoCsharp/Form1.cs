using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoCsharp
{
    public partial class Form1 : Form
    {
        int[] numeros;
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void activarControl()
        {
            btnOrdenar.Enabled = true;
            btnBuscar.Enabled = true;
            btnPosicion.Enabled = true;
            btnMedia.Enabled = true;
            btnContar.Enabled = true;
            btnInvertir.Enabled = true;
            btnContar25.Enabled = true;
            btnContarX.Enabled = true;

            txtPosicion.Enabled = true;
            txtContar.Enabled = true;
            tbContarX.Enabled = true;

            lblMayor.Enabled = true;
            lblMenor.Enabled = true;
            lblMedia.Enabled = true;
            lblPosicion.Enabled = true;
            lblContar.Enabled = true;
            lblPos.Enabled = true;
            lblContar25.Enabled = true;
            lblContarX.Enabled = true;

            rb1.Enabled = true;
            rb2.Enabled = true;
        }

        public void limpiarControl()
        {
            txtContar.Text = "";
            txtPosicion.Text = "";

            lblContar.Text = "";
            lblMayor.Text = "";
            lblMedia.Text = "";
            lblMenor.Text = "";
            lblPosicion.Text = "";
            lblPos.Text = "";

            lbPantalla.Items.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            limpiarControl();
            activarControl();
            int aux = 0;
            String cadAux = "";

            numeros = new int[50];
            lbPantalla.Items.Add("Vector con 50 numeros aleatorios de 1 a 100");
            if (!cbRepeticiones.Checked)
            {
                for (int i = 0; i < numeros.Length;i++)
            {
                
                numeros[i] = aleatorio.Next(100)+1;
                cadAux +=numeros[i] + ", ";
                aux++;
                if (aux == 5)
                {
                    lbPantalla.Items.Add(cadAux);
                    cadAux = "";
                    aux = 0;
                }

            }
            }
            
            lblPos.Text = "Posicion 20: nº" + numeros[19] + ", Posicion 30: nº" + numeros[29];
            lblMayor.Text = "Mayor: ";
            lblMenor.Text = "Menor: ";
            lblMedia.Text = "Media del vector: ";
            lblPosicion.Text = "Posicion n, Numero nº";
            lblContar.Text = "nº aparece n veces en el vector";
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        { 
            lbPantalla.Items.Clear();
            Array.Sort(numeros);
            if (rb2.Checked)
            {
                Array.Reverse(numeros);
            }

            int aux=0;
            String cadAux="";
            
            lbPantalla.Items.Add("Vector con 50 numeros aleatorios de 1 a 100");
            lbPantalla.Items.Add("****ORDENADOS****");
            for (int i = 0; i < numeros.Length; i++)
            {
                cadAux +=numeros[i] + ", ";
                aux++;
                if (aux == 5)
                {
                    lbPantalla.Items.Add(cadAux);
                    cadAux = "";
                    aux = 0;
                }

            }
            lblPos.Text = "";
            lblPos.Text = "Posicion 20: nº" + numeros[19] + ", Posicion 30: nº" + numeros[29];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }
            lblMayor.Text = "";
            lblMenor.Text = "";
            lblMayor.Text="Mayor: "+mayor;
            lblMenor.Text+="Menor: "+numeros.Min();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            try
            {
                lblPosicion.Text = "";
                lblPosicion.Text = "Posicion " + txtPosicion.Text + ", Numero " + numeros[Convert.ToInt16(txtPosicion.Text)-1];
            }catch(Exception ex)
            {
                MessageBox.Show("Introduce un nº entero, entre 1 y 50");
            }
            
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            lblMedia.Text = "";
            lblMedia.Text = "Media del vector: " +(float)numeros.Sum()/numeros.Count();

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtContar.Text) < 1 || Convert.ToInt16(txtContar.Text) > 100)
                {
                    MessageBox.Show("Introduce un nº entero, entre 1 y 100");
                }
                else
                {
                    lblContar.Text = "";
                    int c = 0;
                    foreach (int i in numeros)
                    {
                        if (i == Convert.ToInt16(txtContar.Text)) c++;
                    }

                    if (c == 1) lblContar.Text = "Aparece " + c + " vez en el vector";
                    else lblContar.Text = "Aparece " + c + " veces en el vector";
                }


            }
            catch(Exception ex){
                MessageBox.Show("Introduce un nº entero, entre 1 y 100");
            }

            
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text == null || Math.Floor(Math.Log10(Convert.ToInt32(txtDNI.Text)) + 1) == 8)
                {

                    int dni = Convert.ToInt32(txtDNI.Text);
                    txtDNI.Text = "";
                    lblNIF.Text = "";
                    char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                    lblNIF.Text = dni.ToString() + letras[dni % 23];
                }
                else
                {
                    MessageBox.Show("Introduce un nº con formato DNI '00000000' (8 digitos)");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El campo de texto esta vacio");
            }
            
            
        }

        private void txtDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Introduce un nº con formato DNI '00000000' (8 digitos)");
        }


        private void btnRepetidos_Click(object sender, EventArgs e)
        {
            numeros = numeros.Reverse().ToArray();
            lbPantalla.Items.Clear();

            int aux = 0;
            String cadAux = "";

            lbPantalla.Items.Add("Vector con 50 numeros aleatorios de 1 a 100");
            for (int i = 0; i < numeros.Length; i++)
            {
                cadAux += numeros[i] + ", ";
                aux++;
                if (aux == 5)
                {
                    lbPantalla.Items.Add(cadAux);
                    cadAux = "";
                    aux = 0;
                }
            }
            lblPos.Text = "Posicion 20: nº" + numeros[19] + ", Posicion 30: nº" + numeros[29];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContar25_Click(object sender, EventArgs e)
        {
            int mas = 0, menos = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 25)
                {
                    menos++;
                }else if (numeros[i] > 25)
                {
                    mas++;
                }
            }
            lblContar25.Text = "";
            lblContar25.Text = "Mayor que 25: " + mas + ", menor: " + menos + ", igual: " + (50 -(mas + menos));
        }

        private void btnContarX_Click(object sender, EventArgs e)
        {
            int mas = 0, menos = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < Convert.ToInt16(tbContarX.Text))
                {
                    menos++;
                }
                else if (numeros[i] > Convert.ToInt16(tbContarX.Text))
                {
                    mas++;
                }
            }
            lblContarX.Text = "";
            lblContarX.Text = "Mayor que "+ tbContarX.Text + ": " + mas + ", menor: " + menos + ", igual: " + (50 - (mas + menos));
        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            int[] array = new int[10];
            int mas=0;
            int menos=0;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = aleatorio.Next(301) - 100;
                lb2.Items.Add(array[i]);
                if (array[i] > 0) mas++;
                else if (array[i] < 0) menos++;
            }
            lb2.Items.Add("Positivos: " + mas);
            lb2.Items.Add("Negativos: " + menos);
            lb2.Items.Add("Ceros: " + (10 - (mas + menos)));

        }

        private void btnArray3_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            float media = 0;
            int[] array3 = new int[50];
            for(int i = 0; i < array3.Length; i++)
            {
                array3[i] = aleatorio.Next(101);
                media += array3[i];
                lb2.Items.Add(array3[i]);
            }
            media = media / array3.Count();
            lb2.Items.Add("Media: " + media);

            int mayor = 0, menor = 0;
            for(int j = 0; j < array3.Length; j++)
            {
                if (array3[j] < media) menor++;
                else mayor++;
            }
            lb2.Items.Add(mayor + " nºs superan la media");
            lb2.Items.Add(menor + " nºs no superan la media");
        }

        private void btn3Array_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            int[] principal = new int[20];
            int[] par = new int[20];
            int[] impar = new int[20];

            lb2.Items.Add("Vector Completo");
            for(int i = 0; i < principal.Length; i++)
            {
                principal[i] = aleatorio.Next(101);
                if (principal[i] % 2 == 0) par[i] = principal[i];
                else impar[i] = principal[i];

                lb2.Items.Add(principal[i]);
            }
            lb2.Items.Add("Vector Par");
            for (int i = 0; i < par.Length; i++)
            {
                lb2.Items.Add(par[i]);
            }

            lb2.Items.Add("Vector Impar");
            for (int i = 0; i < impar.Length; i++)
            {
                lb2.Items.Add(impar[i]);
            }
            lb2.Items.Add("Aparecen los ceros porque");
            lb2.Items.Add("los 3 arrays debian tener");
            lb2.Items.Add("el mismo tamaño");
        }
    }
}
