
namespace Simulacion
{
    partial class Simulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.FondoCielo = new System.Windows.Forms.Panel();
            this.LLuvia = new System.Windows.Forms.Panel();
            this.FondoCampo = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maiz = new System.Windows.Forms.Panel();
            this.Prueba = new System.Windows.Forms.Label();
            this.Continuar = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.ListaImagenesBuenaCalidad = new System.Windows.Forms.ImageList(this.components);
            this.Aspersor2 = new System.Windows.Forms.Panel();
            this.Aspersor1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Detener = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SemanaNumero = new System.Windows.Forms.Label();
            this.DiaNumero = new System.Windows.Forms.Label();
            this.MinutoNumero = new System.Windows.Forms.Label();
            this.HoraNumero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CrecimientoEstado = new System.Windows.Forms.Label();
            this.RiegoNumero = new System.Windows.Forms.Label();
            this.HorasRiego = new System.Windows.Forms.Label();
            this.MinutosRiego = new System.Windows.Forms.Label();
            this.Regando = new System.Windows.Forms.Label();
            this.AguaRequerida = new System.Windows.Forms.Label();
            this.AguaActualmente = new System.Windows.Forms.Label();
            this.LluviaIndicador = new System.Windows.Forms.Label();
            this.AguaLluvia = new System.Windows.Forms.Label();
            this.InicioLluvia = new System.Windows.Forms.Label();
            this.AguaRegada = new System.Windows.Forms.Label();
            this.AguaRiego = new System.Windows.Forms.Label();
            this.AguaRegadaMinuto = new System.Windows.Forms.Label();
            this.FondoCielo.SuspendLayout();
            this.LLuvia.SuspendLayout();
            this.FondoCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "Fondo.png");
            this.ListaImagenes.Images.SetKeyName(1, "Fondo dia.png");
            this.ListaImagenes.Images.SetKeyName(2, "Fondo Noche.png");
            // 
            // FondoCielo
            // 
            this.FondoCielo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FondoCielo.BackgroundImage")));
            this.FondoCielo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FondoCielo.Controls.Add(this.LLuvia);
            this.FondoCielo.Location = new System.Drawing.Point(553, 12);
            this.FondoCielo.Name = "FondoCielo";
            this.FondoCielo.Size = new System.Drawing.Size(461, 454);
            this.FondoCielo.TabIndex = 0;
            // 
            // LLuvia
            // 
            this.LLuvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LLuvia.Controls.Add(this.FondoCampo);
            this.LLuvia.Location = new System.Drawing.Point(0, 0);
            this.LLuvia.Name = "LLuvia";
            this.LLuvia.Size = new System.Drawing.Size(461, 454);
            this.LLuvia.TabIndex = 5;
            // 
            // FondoCampo
            // 
            this.FondoCampo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FondoCampo.BackgroundImage")));
            this.FondoCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FondoCampo.Controls.Add(this.panel11);
            this.FondoCampo.Controls.Add(this.Aspersor1);
            this.FondoCampo.Controls.Add(this.Aspersor2);
            this.FondoCampo.Controls.Add(this.panel9);
            this.FondoCampo.Controls.Add(this.panel8);
            this.FondoCampo.Controls.Add(this.panel7);
            this.FondoCampo.Controls.Add(this.panel6);
            this.FondoCampo.Controls.Add(this.panel5);
            this.FondoCampo.Controls.Add(this.panel4);
            this.FondoCampo.Controls.Add(this.panel3);
            this.FondoCampo.Controls.Add(this.panel2);
            this.FondoCampo.Controls.Add(this.panel1);
            this.FondoCampo.Controls.Add(this.maiz);
            this.FondoCampo.Location = new System.Drawing.Point(0, 0);
            this.FondoCampo.Name = "FondoCampo";
            this.FondoCampo.Size = new System.Drawing.Size(461, 454);
            this.FondoCampo.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 263);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(79, 62);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(61, 376);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(79, 62);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(71, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(79, 62);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(146, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(79, 62);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(230, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(79, 62);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(212, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 62);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(379, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 62);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(334, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 62);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(305, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 62);
            this.panel1.TabIndex = 4;
            // 
            // maiz
            // 
            this.maiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maiz.BackgroundImage")));
            this.maiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maiz.Location = new System.Drawing.Point(279, 239);
            this.maiz.Name = "maiz";
            this.maiz.Size = new System.Drawing.Size(79, 62);
            this.maiz.TabIndex = 3;
            // 
            // Prueba
            // 
            this.Prueba.AutoSize = true;
            this.Prueba.Location = new System.Drawing.Point(172, 172);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(0, 13);
            this.Prueba.TabIndex = 1;
            // 
            // Continuar
            // 
            this.Continuar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Continuar.Location = new System.Drawing.Point(113, 452);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(78, 24);
            this.Continuar.TabIndex = 2;
            this.Continuar.Text = "Empezar";
            this.Continuar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 10;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // ListaImagenesBuenaCalidad
            // 
            this.ListaImagenesBuenaCalidad.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenesBuenaCalidad.ImageStream")));
            this.ListaImagenesBuenaCalidad.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenesBuenaCalidad.Images.SetKeyName(0, "5a349eb07b6d51.9356546715133979365056.png");
            this.ListaImagenesBuenaCalidad.Images.SetKeyName(1, "Aspersor como objeto inteligente-1.png");
            this.ListaImagenesBuenaCalidad.Images.SetKeyName(2, "Aspersor no regando como objeto inteligente-1.png");
            // 
            // Aspersor2
            // 
            this.Aspersor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aspersor2.BackgroundImage")));
            this.Aspersor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Aspersor2.Location = new System.Drawing.Point(230, 368);
            this.Aspersor2.Name = "Aspersor2";
            this.Aspersor2.Size = new System.Drawing.Size(108, 68);
            this.Aspersor2.TabIndex = 5;
            // 
            // Aspersor1
            // 
            this.Aspersor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aspersor1.BackgroundImage")));
            this.Aspersor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Aspersor1.Location = new System.Drawing.Point(133, 290);
            this.Aspersor1.Name = "Aspersor1";
            this.Aspersor1.Size = new System.Drawing.Size(109, 62);
            this.Aspersor1.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(108, 223);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(79, 62);
            this.panel11.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulacion de un \r\nSistema de riego para un cultivo de maiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Detener
            // 
            this.Detener.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Detener.Location = new System.Drawing.Point(213, 452);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(78, 24);
            this.Detener.TabIndex = 4;
            this.Detener.Text = "Detener";
            this.Detener.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Detener.UseVisualStyleBackColor = true;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo del Cultivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de semana: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(232, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dia de la semana:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(230, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minuto : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SemanaNumero
            // 
            this.SemanaNumero.AutoSize = true;
            this.SemanaNumero.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SemanaNumero.Location = new System.Drawing.Point(144, 108);
            this.SemanaNumero.Name = "SemanaNumero";
            this.SemanaNumero.Size = new System.Drawing.Size(0, 14);
            this.SemanaNumero.TabIndex = 10;
            this.SemanaNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiaNumero
            // 
            this.DiaNumero.AutoSize = true;
            this.DiaNumero.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DiaNumero.Location = new System.Drawing.Point(347, 108);
            this.DiaNumero.Name = "DiaNumero";
            this.DiaNumero.Size = new System.Drawing.Size(0, 14);
            this.DiaNumero.TabIndex = 11;
            this.DiaNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinutoNumero
            // 
            this.MinutoNumero.AutoSize = true;
            this.MinutoNumero.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinutoNumero.Location = new System.Drawing.Point(293, 138);
            this.MinutoNumero.Name = "MinutoNumero";
            this.MinutoNumero.Size = new System.Drawing.Size(0, 14);
            this.MinutoNumero.TabIndex = 12;
            this.MinutoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraNumero
            // 
            this.HoraNumero.AutoSize = true;
            this.HoraNumero.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HoraNumero.Location = new System.Drawing.Point(57, 138);
            this.HoraNumero.Name = "HoraNumero";
            this.HoraNumero.Size = new System.Drawing.Size(0, 14);
            this.HoraNumero.TabIndex = 13;
            this.HoraNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado de Riego";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(13, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado de crecimiento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(13, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Horas de riego: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(13, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Número de riego de la semana:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(230, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 14);
            this.label11.TabIndex = 18;
            this.label11.Text = "Minutos de riego:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(12, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "Regando:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(230, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 14);
            this.label13.TabIndex = 20;
            this.label13.Text = "Agua Requerida:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(12, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 14);
            this.label14.TabIndex = 21;
            this.label14.Text = "Agua Regando Actualmente:  ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(12, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Estado de Riego";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(13, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 14);
            this.label16.TabIndex = 23;
            this.label16.Text = "Lluvia:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(230, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 14);
            this.label17.TabIndex = 24;
            this.label17.Text = "Inicio de lluvia:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(13, 388);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 14);
            this.label18.TabIndex = 25;
            this.label18.Text = "Agua lluvia:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(230, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 14);
            this.label19.TabIndex = 26;
            this.label19.Text = "Agua De Riego:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(13, 419);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 14);
            this.label20.TabIndex = 27;
            this.label20.Text = "Agua Regada:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(230, 419);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 14);
            this.label21.TabIndex = 28;
            this.label21.Text = "Agua Regada por Minuto:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrecimientoEstado
            // 
            this.CrecimientoEstado.AutoSize = true;
            this.CrecimientoEstado.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CrecimientoEstado.Location = new System.Drawing.Point(159, 199);
            this.CrecimientoEstado.Name = "CrecimientoEstado";
            this.CrecimientoEstado.Size = new System.Drawing.Size(0, 14);
            this.CrecimientoEstado.TabIndex = 29;
            this.CrecimientoEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RiegoNumero
            // 
            this.RiegoNumero.AutoSize = true;
            this.RiegoNumero.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RiegoNumero.Location = new System.Drawing.Point(204, 226);
            this.RiegoNumero.Name = "RiegoNumero";
            this.RiegoNumero.Size = new System.Drawing.Size(0, 14);
            this.RiegoNumero.TabIndex = 30;
            this.RiegoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HorasRiego
            // 
            this.HorasRiego.AutoSize = true;
            this.HorasRiego.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HorasRiego.Location = new System.Drawing.Point(117, 251);
            this.HorasRiego.Name = "HorasRiego";
            this.HorasRiego.Size = new System.Drawing.Size(0, 14);
            this.HorasRiego.TabIndex = 31;
            this.HorasRiego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinutosRiego
            // 
            this.MinutosRiego.AutoSize = true;
            this.MinutosRiego.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinutosRiego.Location = new System.Drawing.Point(341, 251);
            this.MinutosRiego.Name = "MinutosRiego";
            this.MinutosRiego.Size = new System.Drawing.Size(0, 14);
            this.MinutosRiego.TabIndex = 32;
            this.MinutosRiego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Regando
            // 
            this.Regando.AutoSize = true;
            this.Regando.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Regando.Location = new System.Drawing.Point(78, 275);
            this.Regando.Name = "Regando";
            this.Regando.Size = new System.Drawing.Size(0, 14);
            this.Regando.TabIndex = 33;
            this.Regando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaRequerida
            // 
            this.AguaRequerida.AutoSize = true;
            this.AguaRequerida.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaRequerida.Location = new System.Drawing.Point(338, 275);
            this.AguaRequerida.Name = "AguaRequerida";
            this.AguaRequerida.Size = new System.Drawing.Size(0, 14);
            this.AguaRequerida.TabIndex = 34;
            this.AguaRequerida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaActualmente
            // 
            this.AguaActualmente.AutoSize = true;
            this.AguaActualmente.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaActualmente.Location = new System.Drawing.Point(197, 299);
            this.AguaActualmente.Name = "AguaActualmente";
            this.AguaActualmente.Size = new System.Drawing.Size(0, 14);
            this.AguaActualmente.TabIndex = 35;
            this.AguaActualmente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LluviaIndicador
            // 
            this.LluviaIndicador.AutoSize = true;
            this.LluviaIndicador.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LluviaIndicador.Location = new System.Drawing.Point(59, 360);
            this.LluviaIndicador.Name = "LluviaIndicador";
            this.LluviaIndicador.Size = new System.Drawing.Size(0, 14);
            this.LluviaIndicador.TabIndex = 36;
            this.LluviaIndicador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaLluvia
            // 
            this.AguaLluvia.AutoSize = true;
            this.AguaLluvia.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaLluvia.Location = new System.Drawing.Point(92, 388);
            this.AguaLluvia.Name = "AguaLluvia";
            this.AguaLluvia.Size = new System.Drawing.Size(0, 14);
            this.AguaLluvia.TabIndex = 37;
            this.AguaLluvia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InicioLluvia
            // 
            this.InicioLluvia.AutoSize = true;
            this.InicioLluvia.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InicioLluvia.Location = new System.Drawing.Point(328, 360);
            this.InicioLluvia.Name = "InicioLluvia";
            this.InicioLluvia.Size = new System.Drawing.Size(0, 14);
            this.InicioLluvia.TabIndex = 38;
            this.InicioLluvia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaRegada
            // 
            this.AguaRegada.AutoSize = true;
            this.AguaRegada.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaRegada.Location = new System.Drawing.Point(105, 419);
            this.AguaRegada.Name = "AguaRegada";
            this.AguaRegada.Size = new System.Drawing.Size(0, 14);
            this.AguaRegada.TabIndex = 39;
            this.AguaRegada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaRiego
            // 
            this.AguaRiego.AutoSize = true;
            this.AguaRiego.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaRiego.Location = new System.Drawing.Point(331, 388);
            this.AguaRiego.Name = "AguaRiego";
            this.AguaRiego.Size = new System.Drawing.Size(0, 14);
            this.AguaRiego.TabIndex = 40;
            this.AguaRiego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AguaRegadaMinuto
            // 
            this.AguaRegadaMinuto.AutoSize = true;
            this.AguaRegadaMinuto.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AguaRegadaMinuto.Location = new System.Drawing.Point(384, 419);
            this.AguaRegadaMinuto.Name = "AguaRegadaMinuto";
            this.AguaRegadaMinuto.Size = new System.Drawing.Size(0, 14);
            this.AguaRegadaMinuto.TabIndex = 41;
            this.AguaRegadaMinuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1026, 505);
            this.Controls.Add(this.AguaRegadaMinuto);
            this.Controls.Add(this.AguaRiego);
            this.Controls.Add(this.AguaRegada);
            this.Controls.Add(this.InicioLluvia);
            this.Controls.Add(this.AguaLluvia);
            this.Controls.Add(this.LluviaIndicador);
            this.Controls.Add(this.AguaActualmente);
            this.Controls.Add(this.AguaRequerida);
            this.Controls.Add(this.Regando);
            this.Controls.Add(this.MinutosRiego);
            this.Controls.Add(this.HorasRiego);
            this.Controls.Add(this.RiegoNumero);
            this.Controls.Add(this.CrecimientoEstado);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HoraNumero);
            this.Controls.Add(this.MinutoNumero);
            this.Controls.Add(this.DiaNumero);
            this.Controls.Add(this.SemanaNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.FondoCielo);
            this.Name = "Simulacion";
            this.Text = "Simulacion";
            this.FondoCielo.ResumeLayout(false);
            this.LLuvia.ResumeLayout(false);
            this.FondoCampo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ListaImagenes;
        private System.Windows.Forms.Panel FondoCielo;
        private System.Windows.Forms.Label Prueba;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Panel LLuvia;
        private System.Windows.Forms.ImageList ListaImagenesBuenaCalidad;
        private System.Windows.Forms.Panel maiz;
        private System.Windows.Forms.Panel FondoCampo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Aspersor2;
        private System.Windows.Forms.Panel Aspersor1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Detener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SemanaNumero;
        private System.Windows.Forms.Label DiaNumero;
        private System.Windows.Forms.Label MinutoNumero;
        private System.Windows.Forms.Label HoraNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label CrecimientoEstado;
        private System.Windows.Forms.Label RiegoNumero;
        private System.Windows.Forms.Label HorasRiego;
        private System.Windows.Forms.Label MinutosRiego;
        private System.Windows.Forms.Label Regando;
        private System.Windows.Forms.Label AguaRequerida;
        private System.Windows.Forms.Label AguaActualmente;
        private System.Windows.Forms.Label LluviaIndicador;
        private System.Windows.Forms.Label AguaLluvia;
        private System.Windows.Forms.Label InicioLluvia;
        private System.Windows.Forms.Label AguaRegada;
        private System.Windows.Forms.Label AguaRiego;
        private System.Windows.Forms.Label AguaRegadaMinuto;
    }
}