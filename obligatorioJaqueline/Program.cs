namespace obligatorioJaqueline
{
    internal class Program
    {
        /// <summary>
        /// Método burbuja para ordenar un String
        /// </summary>
        /// <autor>nrojlla 20243101 </autor>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño que tendra su array");
            string usuario = Console.ReadLine();

            //convierte el input a int
            int resultado = Int32.Parse(usuario);

            //array del input
            string[] strings = new string[resultado];

            //pide al cliente el numero de elementos a ingresar
            for (int i = 0; i < resultado; i++)
            {
                Console.WriteLine("Ingrese el elemento " + (i + 1) + " :");
                //agrega lo ingresado al array
                strings[i] = Console.ReadLine();
            }

            Console.WriteLine("Aqui estan sus elementos");
            //muestra los elementos que ha ingresado en su orden original
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine("Aqui estan sus elementos ordenados alfabeticamente en ascendente");

            Burbuja(strings); //ordena con el metodo burbuja
            Array.Sort(strings); //ordena alfabeticamente

            //muestra por consola los elementos ordenados y en alfabeto
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

        }
        /// <summary>
        /// Metodo de ordenar por burbuja
        /// </summary>
        /// <param name="strings"></param>
        private static void Burbuja(string[] strings)
        {
            int burbuja = strings.Length;

            for (int i = 0; i < burbuja - 1; i++)
            {
                for (int j = 0; j < burbuja - i - 1; j++)
                {
                    if (strings[j].CompareTo(strings[j + 1]) > 0)
                    {
                        string temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
        }
    }
}
