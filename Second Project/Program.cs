using System;

namespace Converter
{
    class Program
    {
        class Converter
        {
            double usd_1;
            double eur_1;

            public Converter(double usd, double eur)
            {
                this.usd_1 = usd;
                this.eur_1 = eur;
            }

            public double usdTOuah(double usd)
            {
                return usd * usd_1;
            }
            public double usdTOeur(double usd)
            {
                return usd * (usd_1 / eur_1);
            }
            public double eurTOusd(double eur)
            {
                return eur * (eur_1 / usd_1);
            }
            public double eurTOuah(double eur)
            {
                return eur * eur_1;
            }
            public double uahTOusd(double uah)
            {
                return uah / usd_1;
            }
            public double uahTOeur(double uah)
            {
                return uah / eur_1;
            }

            public double Conv(double value, string to, string from)
            {
                string[] curr = { "usd", "uah", "eur" };

                if (from == "uah")
                {
                    if (to == "usd")
                    {
                        return this.uahTOusd(value);
                    }
                    else 
                    {
                        return this.uahTOeur(value);
                    }
                }

                else if (from == "usd")
                {
                    if (to == "eur")
                    {
                        return this.usdTOeur(value);
                    }
                    else
                    {
                        return this.usdTOuah(value);
                    }
                }

                else if (from == "eur")
                {
                    if (to == "usd")
                    {
                        return this.eurTOusd(value);
                    }
                    else
                    {
                        return this.eurTOuah(value);
                    }
                }

                else
                {
                    return 0;
                }
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Нiкiта Орляк К-24");

                Console.WriteLine("Введiть курс usd по вiдношенню до uah: ");
                double usd = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введiть курс eur по вiдношенню до uah: ");
                double eur = Convert.ToDouble(Console.ReadLine());

                Converter conv = new Converter(usd, eur);

                Console.WriteLine("З якоi валюти перевести? (uah, eur, usd) ");
                string from = Console.ReadLine();

                Console.WriteLine("В яку валюту переводити? (uah, eur, usd) ");
                string to = Console.ReadLine();

                Console.WriteLine("Введiть сумму: ");
                double value = Convert.ToDouble(Console.ReadLine());

                double result = conv.Conv(value, to, from);

                Console.WriteLine($"{value} {from} = {result} {to}");  

                Console.ReadKey();
            }
        }
    }
}
