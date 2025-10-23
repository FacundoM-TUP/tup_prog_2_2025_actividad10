using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad._10.Models
{
    public class Solicitud: IExportable
    {
        public int Numero {  get; set; }
        public string Motivo {  get; set; }

        public void Importar(string datos)
        {
            string[] campos = datos.Split(';');
            Numero = Convert.ToInt32(campos[0]);
            Motivo = campos[1];
        }

        override public string ToString()
        {
            return $"{Numero}({Motivo})";
        }
    }
}
