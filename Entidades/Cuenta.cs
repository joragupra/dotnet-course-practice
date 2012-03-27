namespace Entidades
{
    public class Cuenta
    {
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        string titular;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Cuenta(int num, string tit, double sald)
        {
            this.numero = num; this.titular = tit; this.saldo = sald;
        }
    }
}
