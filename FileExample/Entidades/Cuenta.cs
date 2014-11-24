namespace Entidades
{
    public class Cuenta
    {
        #region Campos de la clase
        int numero;

        string titular;

        double saldo;
        #endregion

        #region Propiedades de la clase
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        #endregion

        #region Constructores de la clase
        public Cuenta(int num, string tit, double sald)
        {
            this.numero = num; this.titular = tit; this.saldo = sald;
        }
        #endregion
    }
}
