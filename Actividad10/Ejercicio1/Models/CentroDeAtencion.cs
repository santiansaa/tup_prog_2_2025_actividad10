

using System.Text.Json.Serialization;

namespace Ejercicio1.Models;

[Serializable]
public class CentroDeAtencion
{
    private LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
    private Queue<Solicitud> coladeatencion = new Queue<Solicitud>();
    private Stack<Solicitud> piladeatencion = new Stack<Solicitud>();


    public void ImportarCsvSolicitudesEntrantes(FileStream fs)
    {
        StreamReader sr = new StreamReader(fs);
        //leemos el encabezado
        sr.ReadLine();
        while (sr.EndOfStream == false)
        {
            string linea = sr.ReadLine();
            Solicitud solicitud = new Solicitud();
            solicitud.Importar(linea);

            //
            solicitudesEntrantes.AddLast(solicitud);

        }
        sr.Close();
    }
    public LinkedListNode<Solicitud> GetSolicitudPendiente()
    {
        return solicitudesEntrantes.First;
    }

    public void Antender(Solicitud solicitud)
    {
        //remuevo de la lista solicitudes entrantes
        if (solicitudesEntrantes.Remove(solicitud) == true)
        {
            //agregamos a la cola
            coladeatencion.Enqueue(solicitud);
        }

    }

    public string[] VerDescripcionesColaAtencion()
    {
        string[] descripciones = new string[coladeatencion.Count];
        int n = 0;
        foreach (Solicitud s in coladeatencion) 
        {
            descripciones[n++] = s.ToString();
        }
        return descripciones;
    }

    internal void ResolverSolicitudEnEspera(Solicitud soli)
    {
        if (coladeatencion.Peek() == soli)
        {
            coladeatencion.Dequeue();
            piladeatencion.Push(soli);
        }
       
    }
}
