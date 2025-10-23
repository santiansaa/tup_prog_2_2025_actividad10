

using System.Text.Json.Serialization;

namespace Ejercicio1.Models;

[Serializable]
public class CentroDeAtencion
{
     private LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
    public void ImportarCsvSolicitudesEntrantes(FileStream fs) 
    { 
        StreamReader sr = new StreamReader(fs);
        //leemos el encabezado
        sr.ReadLine();
        while (sr.EndOfStream==false) 
        {
            string linea =sr.ReadLine();
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
}
