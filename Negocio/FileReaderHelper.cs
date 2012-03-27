using Entidades;
using System.IO;
using System;
using System.Collections.Generic;

namespace Negocio
{
    class FileReaderHelper
    {
        private static string RUTA_PROYECTO = @"C:\Users\jagudopr\Documents\Visual Studio 2010\Projects\FileExample";
        public static Cuenta[] ConsultarCuentasCSV()
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            FileStream fs = null;
            StreamReader streamReader = null;
            try
            {
                fs = new FileStream(RUTA_PROYECTO + @"\Negocio\cuentas.csv", FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fs);
                string s;
                while ((s = streamReader.ReadLine()) != null)
                {
                    cuentas.Add(LeerLineaCuenta(s));
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error abriendo o leyendo fichero fichero 'cuentas.csv'. Motivo: " + e.Message);
                return null;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error no controlado. Motivo: " + e.Message);
                return null;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (fs != null)
                {
                    streamReader.Close();
                }
            }
            return cuentas.ToArray();
        }

        private static Cuenta LeerLineaCuenta(string lineaCuenta)
        {
            string[] valores = lineaCuenta.Split(';');
            return new Cuenta(Convert.ToInt32(valores[0]), valores[1], Convert.ToDouble(valores[2]));
        }
    }
}
