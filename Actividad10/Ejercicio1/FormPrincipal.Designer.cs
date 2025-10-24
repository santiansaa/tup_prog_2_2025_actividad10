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
            label2 = new Label();
            btnResolverSolicitud = new Button();
            groupBox1 = new GroupBox();
            lsbHistorialResoluciones = new ListBox();
            btnExportarResoluciones = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(12, 12);
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
            lsbverResultados.Location = new Point(112, 12);
            lsbverResultados.Name = "lsbverResultados";
            lsbverResultados.Size = new Size(424, 124);
            lsbverResultados.TabIndex = 1;
            lsbverResultados.SelectedIndexChanged += lsbverResultados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(94, 49);
            label1.TabIndex = 2;
            label1.Text = "Lista De Solicitudes Entrantes";
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(12, 190);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(86, 72);
            btnConfirmarAtencion.TabIndex = 3;
            btnConfirmarAtencion.Text = "Confirmar Seleccion Hacia La Cola";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // lbsolicitudseleccionada
            // 
            lbsolicitudseleccionada.Location = new Point(0, 275);
            lbsolicitudseleccionada.Name = "lbsolicitudseleccionada";
            lbsolicitudseleccionada.Size = new Size(115, 39);
            lbsolicitudseleccionada.TabIndex = 4;
            lbsolicitudseleccionada.Text = "Lista De Solicitudes Entrantes";
            // 
            // lsbColaSolicitudesAtender
            // 
            lsbColaSolicitudesAtender.FormattingEnabled = true;
            lsbColaSolicitudesAtender.ItemHeight = 15;
            lsbColaSolicitudesAtender.Location = new Point(112, 190);
            lsbColaSolicitudesAtender.Name = "lsbColaSolicitudesAtender";
            lsbColaSolicitudesAtender.Size = new Size(424, 139);
            lsbColaSolicitudesAtender.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(112, 332);
            label2.Name = "label2";
            label2.Size = new Size(72, 39);
            label2.TabIndex = 6;
            label2.Text = "Cola";
            // 
            // btnResolverSolicitud
            // 
            btnResolverSolicitud.Location = new Point(542, 195);
            btnResolverSolicitud.Name = "btnResolverSolicitud";
            btnResolverSolicitud.Size = new Size(81, 63);
            btnResolverSolicitud.TabIndex = 7;
            btnResolverSolicitud.Text = "Resolver Solicitud";
            btnResolverSolicitud.UseVisualStyleBackColor = true;
            btnResolverSolicitud.Click += btnResolverSolicitud_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(lsbHistorialResoluciones);
            groupBox1.Controls.Add(btnExportarResoluciones);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(629, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 317);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lsbHistorialResoluciones
            // 
            lsbHistorialResoluciones.FormattingEnabled = true;
            lsbHistorialResoluciones.ItemHeight = 15;
            lsbHistorialResoluciones.Location = new Point(6, 122);
            lsbHistorialResoluciones.Name = "lsbHistorialResoluciones";
            lsbHistorialResoluciones.Size = new Size(375, 154);
            lsbHistorialResoluciones.TabIndex = 10;
            // 
            // btnExportarResoluciones
            // 
            btnExportarResoluciones.BackColor = SystemColors.Highlight;
            btnExportarResoluciones.Location = new Point(117, 36);
            btnExportarResoluciones.Name = "btnExportarResoluciones";
            btnExportarResoluciones.Size = new Size(166, 63);
            btnExportarResoluciones.TabIndex = 9;
            btnExportarResoluciones.Text = "Exportar Resoluciones";
            btnExportarResoluciones.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Location = new Point(6, 293);
            label3.Name = "label3";
            label3.Size = new Size(72, 39);
            label3.TabIndex = 9;
            label3.Text = "PIla";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 353);
            Controls.Add(groupBox1);
            Controls.Add(btnResolverSolicitud);
            Controls.Add(label2);
            Controls.Add(lsbColaSolicitudesAtender);
            Controls.Add(lbsolicitudseleccionada);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(label1);
            Controls.Add(lsbverResultados);
            Controls.Add(btnImportarSolicitudes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label2;
        private Button btnResolverSolicitud;
        private GroupBox groupBox1;
        private ListBox lsbHistorialResoluciones;
        private Button btnExportarResoluciones;
        private Label label3;
    }
}
