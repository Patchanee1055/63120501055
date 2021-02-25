using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string password, agency;
            bool pass=false;
            char[] numb = { };
            Console.WriteLine("Input password");
            password = Console.ReadLine();
            numb = password.ToCharArray();
            Console.WriteLine("Input agency");
            agency = Console.ReadLine();
            if (agency == "CIA" || agency == "FBI" || agency == "NSA")
            {
                if (agency == "CIA" && numb[5] % 3 == 0 && numb[4] != '1' && numb[4] != '3' && numb[4] != '5'&&int.Parse(numb[2].ToString())>=6&&numb[2]!='8') { pass = true; }
                else if (agency == "FBI" && int.Parse(numb[0].ToString()) >= 4 && int.Parse(numb[4].ToString()) < 7 && int.Parse(numb[3].ToString()) % 2 == 0 && numb[3] != '6' && int.Parse(numb[1].ToString()) % 2 != 0) { pass = true; }
                else if(agency=="NSA"&&30%int.Parse(numb[5].ToString())==0&&int.Parse(numb[3].ToString())%3==0&& int.Parse(numb[3].ToString()) % 2 != 0 &&password.Contains("7")) { pass = true; }
            }
            else { pass = false; }
            Console.WriteLine("Output " + pass);

        }
    }
}
