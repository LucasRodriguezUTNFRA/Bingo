using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bingo2E
{

    public partial class FrmBolillero : Form
    {
        static Random rnd;
        List<int> numerosDisponibles;
        List<int> numerosCantados;

        public FrmBolillero()
        {
            InitializeComponent();
            rnd = new Random();
            numerosDisponibles = new List<int>();
            numerosCantados = new List<int>();
            SetearEstadoInicial();
        }

        private void SetearEstadoInicial()
        {
            numerosCantados.Clear();

            for (int i = 0; i < 100; i++)
            {
                numerosDisponibles.Add(i);
            }
        }

        private int ObtenerNumero()
        {
            int numeroQueSalio = rnd.Next(0, numerosDisponibles.Count);

            numeroQueSalio = numerosDisponibles[numeroQueSalio];

            numerosDisponibles.Remove(numeroQueSalio);

            numerosCantados.Add(numeroQueSalio);

            return numeroQueSalio;
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            int numero = ObtenerNumero();
            label2.Text = "Ultimo Numero:" + numero.ToString();

        }

        public void CantarBingo(string nombre)
        {
            MessageBox.Show("Ganador!!! : " + nombre);

            this.btn_numero.Enabled = false;

        }


        private void FrmBolillero_Load(object sender, EventArgs e)
        {

            new FrmCarton("pepe").Show();
            new FrmCarton("Juana").Show();
            new FrmCarton("Caro").Show();

        }
    }
}
