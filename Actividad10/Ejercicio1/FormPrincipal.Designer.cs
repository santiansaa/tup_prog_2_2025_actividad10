namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportarSolicitudes = new Button();
            lsbverResultados = new ListBox();
            label1 = new Label();
            btnConfirmarAtencion = new Button();
            lbsolicitudseleccionada = new Label();
            lsbColaSolicitudesAtender = new ListBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(28, 33);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(86, 47);
            btnImportarSolicitudes.TabIndex = 0;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // lsbverResultados
            // 
            lsbverResultados.FormattingEnabled = true;
            lsbverResultados.ItemHeight = 15;
            lsbverResultados.Location = new Point(28, 117);
            lsbverResultados.Name = "lsbverResultados";
            lsbverResultados.Size = new Size(240, 199);
            lsbverResultados.TabIndex = 1;
            lsbverResultados.SelectedIndexChanged += lsbverResultados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 99);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 2;
            label1.Text = "Lista De Solicitudes Entrantes";
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(289, 176);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(86, 47);
            btnConfirmarAtencion.TabIndex = 3;
            btnConfirmarAtencion.Text = "Importar Solicitudes";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            // 
            // lbsolicitudseleccionada
            // 
            lbsolicitudseleccionada.AutoSize = true;
            lbsolicitudseleccionada.Location = new Point(274, 148);
            lbsolicitudseleccionada.Name = "lbsolicitudseleccionada";
            lbsolicitudseleccionada.Size = new Size(160, 15);
            lbsolicitudseleccionada.TabIndex = 4;
            lbsolicitudseleccionada.Text = "Lista De Solicitudes Entrantes";
            // 
            // lsbColaSolicitudesAtender
            // 
            lsbColaSolicitudesAtender.FormattingEnabled = true;
            lsbColaSolicitudesAtender.ItemHeight = 15;
            lsbColaSolicitudesAtender.Location = new Point(469, 117);
            lsbColaSolicitudesAtender.Name = "lsbColaSolicitudesAtender";
            lsbColaSolicitudesAtender.Size = new Size(240, 199);
            lsbColaSolicitudesAtender.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbColaSolicitudesAtender);
            Controls.Add(lbsolicitudseleccionada);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(label1);
            Controls.Add(lsbverResultados);
            Controls.Add(btnImportarSolicitudes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImportarSolicitudes;
        private ListBox lsbverResultados;
        private Label label1;
        private Button btnConfirmarAtencion;
        private Label lbsolicitudseleccionada;
        private ListBox lsbColaSolicitudesAtender;
    }
}
