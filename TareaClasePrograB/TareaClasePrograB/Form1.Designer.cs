
namespace TareaClasePrograB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonFrenarPoco = new System.Windows.Forms.Button();
            this.buttonFrenarDeGolpe = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(464, 254);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(216, 157);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(464, 417);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Canción";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(591, 417);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(89, 23);
            this.btnreproducir.TabIndex = 2;
            this.btnreproducir.Text = "Reproducir";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(549, 441);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(35, 13);
            this.lblruta.TabIndex = 5;
            this.lblruta.Text = "label1";
            this.lblruta.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|**";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear Carro Honda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.Location = new System.Drawing.Point(228, 12);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(133, 30);
            this.buttonBMW.TabIndex = 7;
            this.buttonBMW.Text = "Crear Carro BMW";
            this.buttonBMW.UseVisualStyleBackColor = true;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEncender.Location = new System.Drawing.Point(58, 88);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(133, 30);
            this.buttonEncender.TabIndex = 8;
            this.buttonEncender.Text = "Encender y apagar carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(58, 135);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(133, 30);
            this.buttonAcelerar.TabIndex = 9;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonFrenarPoco
            // 
            this.buttonFrenarPoco.Location = new System.Drawing.Point(58, 186);
            this.buttonFrenarPoco.Name = "buttonFrenarPoco";
            this.buttonFrenarPoco.Size = new System.Drawing.Size(133, 30);
            this.buttonFrenarPoco.TabIndex = 10;
            this.buttonFrenarPoco.Text = "Frenar poco a poco";
            this.buttonFrenarPoco.UseVisualStyleBackColor = true;
            this.buttonFrenarPoco.Click += new System.EventHandler(this.buttonFrenarPoco_Click);
            // 
            // buttonFrenarDeGolpe
            // 
            this.buttonFrenarDeGolpe.Location = new System.Drawing.Point(58, 242);
            this.buttonFrenarDeGolpe.Name = "buttonFrenarDeGolpe";
            this.buttonFrenarDeGolpe.Size = new System.Drawing.Size(133, 30);
            this.buttonFrenarDeGolpe.TabIndex = 11;
            this.buttonFrenarDeGolpe.Text = "Frenar de golpe";
            this.buttonFrenarDeGolpe.UseVisualStyleBackColor = true;
            this.buttonFrenarDeGolpe.Click += new System.EventHandler(this.buttonFrenarDeGolpe_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(342, 97);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(37, 13);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "..........";
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(342, 135);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(37, 13);
            this.labelEstadoVelocidad.TabIndex = 14;
            this.labelEstadoVelocidad.Text = "..........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonFrenarDeGolpe);
            this.Controls.Add(this.buttonFrenarPoco);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonFrenarPoco;
        private System.Windows.Forms.Button buttonFrenarDeGolpe;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEstadoVelocidad;
    }
}

