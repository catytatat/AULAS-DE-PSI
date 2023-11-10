using System;

namespace PrimeiroMetodo
{
    class Program
    {
        private static void Main(string[] args)
        {
        /// <summary>
        /// Método para testar métodos de contagem.
        /// </summary>
        private static void Main()
        {
            // Invocar método ContarAte10 duas vezes
            ContarAte10();
            Console.WriteLine();
            ContarAte10();

            Console.WriteLine();

            // Invocar método ContarAteN duas vezes, com valores diferentes
            ContarAteN(n1,n2);
            Console.WriteLine();
            ContarAte();
        }

        /// <summary>
        /// Método para imprimir números de 1 a 10 na consola.
        /// </summary>
        private static void ContarAte10()
        {
            // Utilizar método ContarAteN com valor 10
            ContarAteN(10);
        }
        
        /// <summary>
        /// Método para imprimir números de 1 a n na consola.
        /// </summary>
        /// <param name="n">Valor passado no método main</param>
        private static void ContarAteN(int n)
        {   
            // Ciclo até número dado ser igual a i
            for (int i = 1; i <= n; i++)
            {
                // Imprimir um número por linha
                Console.WriteLine(i);
            }
           
           

        } criar uma função q imprima n1 e n2 e depois devolva para o repositorio remoto
    }
}
