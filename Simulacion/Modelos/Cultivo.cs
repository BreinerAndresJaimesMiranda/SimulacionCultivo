using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion.Modelos
{
    public class Cultivo
    {
        //CAUDAL = l/h
        //SUPERFICIE = m2
        //PLUVIOMETRIA = mm/h
        //AGUA REQUERIDA = mm
        public Double AguaLluvia { set; get; }
        public Double AguaDeRiego { set; get; }
        public int HoraDeDia { set; get; }
        public Double AguaRegadaPorMinuto { get; set; }
        public int HoraInicioDeRiego { set; get; }
        public int InicioDeLluvia { set; get; }
        public int HorasDeLluvia { set; get; }
        public String Estado { set; get; }
        public int NumeroDeSemana { set; get; }
        public int NumeroDiaDeSemana { set; get; }
        public int NumeroDeRiegoEnLaSemana { get; set; }
        public bool Lluvia { set; get; }
        public int MinutoDeDia { set; get; }
        public Double NumeroDeAspersores { set; get; }
        public Double HorasDeRiego { set; get; }
        public Double MinutosDeRiego { set; get; }
        public bool Riego { set; get; }
        public Double AguaRequerida { set; get; }//AGUA EN l
        public Double AguaRegada { set; get; }
        public Double TamanioTerrenom2 { set; get; }
        public Double CaudalDeAspersor { set; get; }
        public Entidad[,] Terreno { set; get; }

        public Cultivo()
        {
            SetSemanaInicial();
            RellenarPlantas();
        }

        private void SetSemanaInicial()
        {
            Estado = "Siembra";
            Lluvia = false;
            Riego = false;
            AguaRegada = 0;
            NumeroDeSemana = 0;
            NumeroDiaDeSemana = 1;
            AguaRequerida = 42;
            InicioDeLluvia = 0;
            HorasDeLluvia = 0;
            TamanioTerrenom2 = 100;
            NumeroDeAspersores = 4;
            HorasDeRiego = 0;
            MinutosDeRiego = 0;
            CaudalDeAspersor = 1400;//l/m2/h
            AguaDeRiego = 0;
            AguaRegadaPorMinuto = 0;
        }
        private void RellenarPlantas()
        {
            int tamanioCultivo = 11;
            if (tamanioCultivo % 2 == 0) { tamanioCultivo++; }
            Terreno = new Entidad[tamanioCultivo, tamanioCultivo];
            for (int i = 0; i< Terreno.GetLength(1);i++ )
            {
                for (int j = 0; j < Terreno.GetLength(0); j++)
                {
                    Terreno[i, j] = new Entidad();
                    Terreno[i, j].Nombre = "Planta";
                    Terreno[i,j].Vida = true;
                }
            }
            Terreno[((tamanioCultivo - 1) / 2), ((tamanioCultivo - 1) / 2)].Nombre = "Aspersor";
        }

        private void AvanzarSemana()
        {
            NumeroDeSemana++;
            NumeroDeRiegoEnLaSemana = 0;
            AguaRegada = 0;
            switch (NumeroDeSemana)
            {
                case 1:{ Estado = "Siembra"; break;}
                case 2:{ Estado = "Nascencia"; break;}
                case 3:{ Estado = "Desarrollo Primario"; break; }
                case 5:{ Estado = "Crecimiento"; break;}
                case 8:{ Estado = "Floracion"; break;}
                case 9:{ Estado = "Polinizacion"; break;}
                case 11:{ Estado = "Fecundacion"; break;}
                case 12:{ Estado = "Fecundacion del grano"; break;}
            }
            if (NumeroDeSemana <= 2) { AguaRequerida = 42; }
            if (NumeroDeSemana ==3 ) { AguaRequerida = 52; }
            if (NumeroDeSemana == 4 ) { AguaRequerida = 88; }
            if (NumeroDeSemana == 5 ) { AguaRequerida = 120; }
            if (NumeroDeSemana ==6 ) { AguaRequerida = 150; }
            if (NumeroDeSemana == 7 ) { AguaRequerida = 165; }
            if (NumeroDeSemana == 8 ) { AguaRequerida = 185; }
            if (NumeroDeSemana == 9 || NumeroDeSemana==15 ) { AguaRequerida = 190; }
            if (NumeroDeSemana == 10 ) { AguaRequerida = 230; }
            if (NumeroDeSemana == 11 ) { AguaRequerida = 200; }
            if (NumeroDeSemana >=12 && NumeroDeSemana<=14 ) { AguaRequerida = 192; }
        }

        private void ProbabilidadLluvia()
        {
            var random = new Random();
            int probabilidad = random.Next(1,200);
            if (probabilidad <= 1) 
            {
                HorasDeLluvia =random.Next(1,3);
                InicioDeLluvia = HoraDeDia;
                AguaLluvia = AguaLluvia + (5*HorasDeLluvia);
                Lluvia = true;

            }
            else
            {
                Lluvia = false;
            }
        }



        public void AvanzarDiaDeSemana()
        {
            if (NumeroDiaDeSemana == 7)
            {
                AvanzarSemana();
                NumeroDiaDeSemana = 1;
            }
            else
            {
                NumeroDiaDeSemana++;
            }
        }


        public void AvanzarHora()
        {
            if (HoraDeDia == 23)
            {
                AvanzarDiaDeSemana();
                HoraDeDia = 0;
            }
            else
            { 
                HoraDeDia++;
                if (HorasDeLluvia == 0)
                {
                    ProbabilidadLluvia();
                }
                if (HoraDeDia == 14  && Lluvia == false)
                {
                    Regar();
                }
                if ((InicioDeLluvia + HorasDeLluvia == HoraDeDia))
                {
                    Lluvia =false;
                    if (InicioDeLluvia<=14 && InicioDeLluvia+HorasDeLluvia >14)
                    {
                        Regar();
                    }
                    InicioDeLluvia = 0;
                    HorasDeLluvia = 0;
                }
            }
            if ((HoraDeDia == 0 && HorasDeLluvia > 0))
            {
                HorasDeLluvia = HorasDeLluvia + InicioDeLluvia - 24;
                InicioDeLluvia = 0;
            }
            Genocidio();
        }

        public void AvanzarMinuto() 
        {
            if (MinutoDeDia==59)
            {
                MinutoDeDia = 0;
                AvanzarHora();
            }
            else
            {
                
                MinutoDeDia++;
                
                if (Riego)
                {
                    AguaRegadaPorMinuto =AguaRegadaPorMinuto+ (AguaDeRiego/((HorasDeRiego*60)+MinutosDeRiego));
                }
                ApagarRiego();
            }

        }

        private void Regar() 
        {
            if (AguaRegada + AguaLluvia < AguaRequerida)
            {
                if ((NumeroDeSemana >= 1) && (NumeroDiaDeSemana == 3 || NumeroDiaDeSemana == 5 ||
                NumeroDiaDeSemana == 7))
                {
                    NumeroDeRiegoEnLaSemana++;
                    AguaRegada = AguaRegada + AguaLluvia;
                    if (NumeroDeRiegoEnLaSemana == 1) { AguaRegada = AguaRegada + ((AguaRequerida - AguaRegada) / 3); AguaDeRiego = AguaRegada - AguaLluvia; }
                    if (NumeroDeRiegoEnLaSemana == 2) { AguaRegada = AguaRegada + ((AguaRequerida - AguaRegada) / 2); AguaDeRiego = AguaRegada - AguaLluvia - AguaDeRiego; }
                    if (NumeroDeRiegoEnLaSemana == 3) { AguaRegada = AguaRegada + ((AguaRequerida - AguaRegada) / 1); AguaDeRiego = AguaRegada - AguaLluvia - (AguaDeRiego*2); }
                    EstablecerTiempoDeRiego();
                    AguaLluvia = 0;
                    HoraInicioDeRiego = HoraDeDia;
                    Riego = true;
                }
                else
                {
                    Riego = false;
                }
            }
        }


        private void Genocidio()
        {
            if (AguaRegada + AguaLluvia >= AguaRequerida+20)
            {
                for (int i = 0; i < Terreno.GetLength(1); i++)
                {
                    for (int j = 0; j < Terreno.GetLength(0); j++)
                    {
                        var probabilidad = new Random();

                        if (probabilidad.Next(1, 100)<=60)
                        {
                            Terreno[i, j].Vida = false;
                        }
                        
                    }
                }
            }
        }

        

        private void EstablecerTiempoDeRiego()
        {
            Double Pluviometria = 0;
            Double TiempoDeRiego;
            Pluviometria = (CaudalDeAspersor * NumeroDeAspersores) / TamanioTerrenom2;
            TiempoDeRiego = Math.Truncate((AguaDeRiego / Pluviometria)*10);
            TiempoDeRiego = TiempoDeRiego / 10;
            HorasDeRiego = Math.Truncate(TiempoDeRiego);
            MinutosDeRiego = (TiempoDeRiego-Math.Truncate(TiempoDeRiego)) *60;
        }

        public void ApagarRiego()
        {
            if ((HoraDeDia == HoraInicioDeRiego + HorasDeRiego) && (MinutoDeDia == MinutosDeRiego))
            {
                Riego = false;
                AguaRegadaPorMinuto = 0;
                MinutosDeRiego = 0;
                HorasDeRiego = 0;
            }
        }

        public Double CalcularAguaRegando()
        {
            Double AguaResultante = 0;
            if (Riego)
            {
                if (NumeroDeRiegoEnLaSemana==1)
                {
                    AguaResultante = AguaRegadaPorMinuto+AguaLluvia;
                }
                else
                {
                    if (NumeroDeRiegoEnLaSemana==2) { AguaResultante = AguaRegada / 2; }
                    if (NumeroDeRiegoEnLaSemana==3) { AguaResultante = (AguaRegada / 3)*2; }

                    AguaResultante = AguaResultante + AguaRegadaPorMinuto + AguaLluvia;
                }
            }
            else
            {
                AguaResultante = AguaRegada;
            }
            return AguaResultante;
        }


    }
}
