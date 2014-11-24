using Entidades;

namespace Negocio
{
    public class Controlador
    {
        public static Cuenta[] ConsultarCuentasCSV()
        {
            return FileReaderHelper.ConsultarCuentasCSV();
        }
    }
}
