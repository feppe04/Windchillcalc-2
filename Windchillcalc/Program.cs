using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Laboration_2
{
    
    internal class Program
    {
        // När programmet debuggas kan man se variabler, parameterar (args) och returvärden.
        static void Main(string[] args)
        {
            // Huvudmeny loop
            bool programRunning = true;
            while (programRunning)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till WCT kalkylatorn!");
                Console.WriteLine();

                Console.WriteLine("Välj mellan följande alternativ (svara med 1 eller 2)");
                Console.WriteLine("1. Beräkna WCT");
                Console.WriteLine("2. Avsluta programmet");
                Console.Write("Ditt val:");

                string choice = Console.ReadLine();

                // Switch sats för att hantera användarens val
                switch (choice)
                {
                    // Alternativ 1: Beräkna WCT
                    case "1":
                        double temperature = 0;

                        double windSpeed = 0;
                        
                        // Be om temperaturen från användaren
                        Console.WriteLine("Ange temperaturen i Celsius:");
                        // Läs in temperaturen och konvertera till double
                        temperature = Convert.ToDouble(Console.ReadLine());

                        // Be om vindhastigheten från användaren
                        Console.WriteLine("Ange vindhastigheten i km/h:");
                        // Läs in vindhastigheten och konvertera till double
                        windSpeed = Convert.ToDouble(Console.ReadLine());

                        double wct = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);


                        if (wct > -25)
                        {
                            Console.WriteLine(String.Format("WCT är: {0:F2}. Det är kallt", wct));
                        }
                        else if (wct <= -25 && wct >= -35)
                            Console.WriteLine(String.Format("WTC är {0:F2}. Det är mycket kallt", wct));
                        else if (wct < -35 && wct >= -60)
                            Console.WriteLine(String.Format("WTC är {0:F2}. Risk för frostskador", wct));
                        else if (wct < -60)
                            Console.WriteLine(String.Format("WTC är {0:F2}. Stor risk för frostskada", wct));

                        Console.ReadKey();

                        break;

                        // Alternativ 2: Avsluta programmet
                        case "2":
                        Console.WriteLine("Avslutar programmet...");
                        programRunning = false;
                        break;

                        // Standardfall: Ogiltigt val
                       default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        Console.ReadKey();
                        break;

                }
            }
            
            
        }
    }
}