using System;

namespace ClassDemo2021ExtraDialog
{
    public class InsertCodeHere
    {
        private int direction = 0; // 0=nord, 90=øst, 180=syd, 270=vest

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
                    case "V":
                        direction = (direction + 270) % 360;
                        break;
                    case "H":
                        direction = (direction + 90) % 360;
                        break;
                    case "O":
                        direction = direction + 0;
                        break;
                    case "N":
                        direction = (direction + 180) % 360;
                        break;

                    case "STOP":
                        Console.WriteLine("Vi stopper programmet");
                        fortsæt = false;
                        break;
                    default:
                        Console.WriteLine("Du bør bruge V,H,O,N eller stop !");
                        break;
                }


                switch (direction)
                {
                    case 0:
                        Console.WriteLine("Går mod Nord");
                        break;
                    case 90:
                        Console.WriteLine("Går mod øst");
                        break;
                    case 180:
                        Console.WriteLine("Går mod syd");
                        break;
                    case 270:
                        Console.WriteLine("Går mod vest");
                        break;

                    default:
                        Console.WriteLine("intern fejl !");
                        break;
                }

            }
        }
    }
}