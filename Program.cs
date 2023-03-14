namespace EjercicioTema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            
            cliente.Edad = 46;
            cliente.Nombre = "Darío";
            cliente.NumTelefono = "+349271836211";
            cliente.Credito = 5000;

            Console.WriteLine("Nombre: " + cliente.Nombre + ", Edad: " + cliente.Edad + ", Número de teléfono: " + cliente.NumTelefono + ", Crédito: " + cliente.Credito);

            Trabajador trabajador = new Trabajador();

            trabajador.Edad = 29;
            trabajador.Nombre = "Mabel";
            trabajador.NumTelefono = "+54341883064";
            trabajador.Salario = 1500;

            Console.WriteLine("Nombre: " + trabajador.Nombre + ", Edad: " + trabajador.Edad + ", Número de teléfono: " + trabajador.NumTelefono + ", Salario: " + trabajador.Salario);
        }
    }

    public class Persona
    {
        private int edad;
        private string nombre;
        private string numTelefono;


        public string NumTelefono
        {
            get { return numTelefono; }
            set { numTelefono = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }

    public class Cliente : Persona
    {
        private int credito;

        public int Credito
        {
            get { return credito; }
            set { credito = value; }
        }

    }

    public class Trabajador : Persona
    {
        private int salario;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

    }
}