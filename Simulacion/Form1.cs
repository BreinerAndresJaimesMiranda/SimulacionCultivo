using Simulacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class Simulacion : Form
    {
        public Cultivo cultivo1;
  
        public Simulacion()
        {
            cultivo1 = new Cultivo();
            InitializeComponent();
            cultivo1.NumeroDiaDeSemana = 3;
            cultivo1.NumeroDeSemana = 1;
            maiz.BackColor = Color.Transparent;
            LLuvia.BackColor = Color.Transparent;
            FondoCampo.BackColor = Color.Transparent;
            FondoCielo.BackgroundImage = ListaImagenes.Images[2];
            
        }



        public void AvanzarTiempo()
        {
            
            SemanaNumero.Text = cultivo1.NumeroDeSemana.ToString();
            DiaNumero.Text= cultivo1.NumeroDiaDeSemana.ToString();
            HoraNumero.Text= cultivo1.HoraDeDia.ToString();
            MinutoNumero.Text= cultivo1.MinutoDeDia.ToString();
            CrecimientoEstado.Text= cultivo1.Estado.ToString();
            RiegoNumero.Text= cultivo1.NumeroDeRiegoEnLaSemana.ToString();
            HorasRiego.Text= cultivo1.HorasDeRiego.ToString();
            MinutosRiego.Text= cultivo1.MinutosDeRiego.ToString();
            Regando.Text= cultivo1.Riego.ToString();
            AguaRequerida.Text= cultivo1.AguaRequerida.ToString();
            AguaActualmente.Text = cultivo1.CalcularAguaRegando().ToString();
            LluviaIndicador.Text= cultivo1.Lluvia.ToString();
            InicioLluvia.Text= cultivo1.InicioDeLluvia.ToString();
            AguaLluvia.Text = cultivo1.AguaLluvia.ToString();
            AguaRiego.Text= cultivo1.AguaDeRiego.ToString();
            AguaRegada.Text= cultivo1.AguaRegada.ToString();
            AguaRegadaMinuto.Text= cultivo1.AguaRegadaPorMinuto.ToString();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            
            Tiempo.Enabled = true;
            
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            
            cultivo1.AvanzarMinuto();
            AvanzarTiempo();
            if (cultivo1.HoraDeDia == 18)
            {
                FondoCielo.BackgroundImage = ListaImagenes.Images[2];
            }
            if (cultivo1.HoraDeDia == 6)
            {
                FondoCielo.BackgroundImage = ListaImagenes.Images[1];
            }
            if (cultivo1.Lluvia == true)
            {
                LLuvia.BackgroundImage= ListaImagenesBuenaCalidad.Images[0];
            }
            if (cultivo1.Lluvia == false)
            {
                LLuvia.BackgroundImage = null;
            }
            if (cultivo1.Riego == true)
            {
                Tiempo.Interval = 1000;
                Aspersor1.BackgroundImage = ListaImagenesBuenaCalidad.Images[1];
                Aspersor2.BackgroundImage = ListaImagenesBuenaCalidad.Images[1];
            }
            if (cultivo1.Riego == false)
            {
                Tiempo.Interval = 10;
                Aspersor1.BackgroundImage = ListaImagenesBuenaCalidad.Images[2];
                Aspersor2.BackgroundImage = ListaImagenesBuenaCalidad.Images[2];
            }
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            Tiempo.Enabled = false;
        }
    }
}
