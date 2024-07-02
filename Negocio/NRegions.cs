using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
    public class NRegions
    {
        DRegions datos = new DRegions();

        public List<ERegions> Listar()
        {
            List<ERegions> result = new List<ERegions>();
            result = datos.Listar();
            return result;
        }

        public string Registrar(string strNombre, bool bitEnabled)
        {
            return datos.Registrar(strNombre, bitEnabled);
        }

        public string Editar(int intId, string strNombre, bool bitEnabled)
        {
            return datos.Editar(intId, strNombre, bitEnabled);
        }
    }


}
