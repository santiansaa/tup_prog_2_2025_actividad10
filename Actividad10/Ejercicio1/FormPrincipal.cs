using Ejercicio1.Models;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    CentroDeAtencion centro = new CentroDeAtencion();
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnImportarSolicitudes_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK) 
        {
            string path = openFileDialog1.FileName;
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                centro.ImportarCsvSolicitudesEntrantes(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                if (fs != null) 
                {
                    fs.Close();
                }
                VersolicitudesPendientes();
            }
        }
    }
    protected void VersolicitudesPendientes() 
    {
        lsbverResultados.Items.Clear();
        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();
        //
        while(nodo!=null) 
        {
            lsbverResultados.Items.Add(nodo.Value);
            nodo = nodo.Next;
        }

    

    }

}
