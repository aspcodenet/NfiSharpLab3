using System;

namespace NfiSharpLab3
{
    class Program
    {
        /*
         Skapa en variabel string name med ditt namn
        Skapa en int age med din ålder.
        Skriv sedan ut Jag heter Kalle (innehållet i name) och är 27(innehållet i age) år.


         */
        static void Main(string[] args)
        {

            var name = "Stefan";
            var age = 48;
            Console.WriteLine(name);
            if(age > 48)
                Console.WriteLine("Herlölo");
            Console.WriteLine(age);

        }
    }
}
