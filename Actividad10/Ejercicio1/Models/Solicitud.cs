
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Solicitud : IExportable
    {
        public int Numero { get; set; }
        public string Motivo { get; set; }
        public Solicitud() { }
        public Solicitud(int numero,string motivo) 
        {
            this.Numero = numero;   
            this.Motivo = motivo;
        }
        public string Exportar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo que me permite importar datos desde un formato separado con punto y 
        /// coma
        /// </summary>
        /// <param name="datos">linea a importar </param>
        public void Importar(string datos)
        {
            string[] campos = datos.Split(';');
            Numero = Convert.ToInt32(campos[0]);
            Motivo =campos[1];
        }
        public override string ToString()
        {
            return $"Numero:{Numero}- Motivo{Motivo}";
        }
    }
}
