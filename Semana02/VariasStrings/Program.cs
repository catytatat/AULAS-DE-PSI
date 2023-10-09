using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;    

        string s = "Uma string";
        string t = "Outra string";
        string r = @"""Uma string entre aspas""";
        string i = @"\Uma string sem aspas\";
        string n = "\u00A9 e \u2665";
        string g = @"\u00A9 e \u2665 sem UTF";

    // Concatenação
       
        string cs = "pretinho" + "Teamo" +2;
        string ct = r + c + x;

    // Formatação com Console.WriteLine
        Console.WriteLine{"Valor de {0} mais "}
            Console.WriteLine($"{dd:f2})");   
            Console.WriteLine($"{dd:p1})");   
            Console.WriteLine($"{ii:x})");   
            Console.WriteLine($"{ii:c})");   
            

    
    


            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(g);

        }
    }
}
