using System;

namespace ClassDermo2021Dialog
{
    public class InsertCodeHere
    {
        public InsertCodeHere()
        {
        }

        public void MyCode()
        {
            bool fortsæt = true;
            while (fortsæt)
            {
                Console.WriteLine("Hvor vil du hen ?");
                Console.WriteLine("V: venstre");
                Console.WriteLine("H: højre");
                Console.WriteLine("O: op");
                Console.WriteLine("N: ned");
                Console.WriteLine("stop: stopper program");

                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "V": Console.WriteLine("Går mod vest");
                        break;
                    case "H":
                        Console.WriteLine("Går mod øst");
                        break;
                    case "O":
                        Console.WriteLine("Går mod nord");
                        break;
                    case "N":
                        Console.WriteLine("Går mod syd");
                        break;
                    case "STOP":
                        Console.WriteLine("Vi stopper programmet");
                        fortsæt = false;
                        break;
                    default:
                        Console.WriteLine("Du bør bruge V,H,O,N eller stop !");
                        break;
                }

            }

        }
    }
}