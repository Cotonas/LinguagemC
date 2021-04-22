using System;
using System.Globalization;

namespace TopicosEspeciais {
    class Program {
        static void Main(string[] args) {

            // utilizar o var é um modo do C# inferir o tipo das váriaveis.
            // Porém a utilização do mesmo pode abrir uma brecha para possíveis descuidos no tipo de suas variaveis.
            var x1 = 10;
            var y2 = 20.0;
            var z3 = "Maria";

            Console.WriteLine(x1);
            Console.WriteLine(y2);
            Console.WriteLine(z3);
            Console.WriteLine("-----------------------------");

            //Utilizando Switch-case

            int x2 = int.Parse(Console.ReadLine());
            string day;

            switch (x2) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
            Console.WriteLine("--------------------------");

            //expressão condicional ternária
            // ( condição ) ? valor_se_verdadeira : valor_se_falso

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
            Console.WriteLine("--------------------------");

            // Modos diferentes de trabalhar a saída de dados de uma String

            string original = "abcde FGHIJ ABC abc DEFH";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            /*verifica se o string esta null ou vazia*/
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf: -" + n1 + "-");
            Console.WriteLine("LastIndexOf: -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3,5): -" + s5 + "-");
            Console.WriteLine("Replace 'a' por 'x': -" + s6 + "-");
            Console.WriteLine("Is null or empty: " + b1 + "-");
            Console.WriteLine("Is null or white space: " + b2 + "-");

            //Time Span

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t11 = TimeSpan.FromDays(1.5);
            TimeSpan t12 = TimeSpan.FromHours(1.5);
            TimeSpan t13 = TimeSpan.FromMinutes(1.5);
            TimeSpan t14 = TimeSpan.FromSeconds(1);
            TimeSpan t15 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t16 = TimeSpan.FromTicks(900000000L);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("Um dia e meio: " + t11);
            Console.WriteLine("Uma hora e meia: " + t12);
            Console.WriteLine("Um minuto e meio: " + t13);
            Console.WriteLine("Um segundo e meio: " + t14);
            Console.WriteLine("Um milesimo de segundo e meio: " + t15);
            Console.WriteLine("900000000L de ticks equivale a : " + t16);

            //Propriedades Date Time
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            DateTime d = new DateTime(2021, 4, 22, 15, 20, 58, 275);
            DateTime d1 = new DateTime(2021, 4, 22, 15, 20, 58);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("4) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());

            string w1 = d.ToShortDateString();
            Console.WriteLine(w1);

            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d.ToString());

            Console.WriteLine(d.ToString("yyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyy-MM-dd HH:mm:ss.fff"));

            DateTime d2 = d.AddHours(2);
            Console.WriteLine("Adicionando duas horas: " + d2);

            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine("Adicionando Três minutos: " + d3);

            DateTime dA = DateTime.Now;
            Console.WriteLine(dA);
            DateTime dA2 = dA.AddDays(7);
            Console.WriteLine("7 Dias após a data atual. " + dA2);

            TimeSpan t = d.Subtract(DateTime.Now);
            Console.WriteLine("Diferença de uma data até a outra: " + t);

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            // TimeSpan

            TimeSpan t21 = new TimeSpan(1, 30, 10);
            TimeSpan t22 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t21.Add(t22);
            TimeSpan dif = t21.Subtract(t22);
            TimeSpan mult = t22.Multiply(2.0);
            TimeSpan div = t22.Divide(2.0);


            Console.WriteLine("Soma: " + sum);
            Console.WriteLine("Diferença: " + dif);
            Console.WriteLine("Multiplicado por 2: " + mult);
            Console.WriteLine("Dividido por 2: " + div);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            //DateTimeKind Tipo de enumerado especial que define três valores possíveis para localidade da data:
            //Local ; UTC ; Unspecified;

            DateTime d11 = new DateTime(2021, 4, 22, 16, 43, 58, DateTimeKind.Local);
            DateTime d12 = new DateTime(2021, 4, 22, 16, 43, 58, DateTimeKind.Utc);
            DateTime d13 = new DateTime(2021, 4, 22, 16, 43, 58);

            DateTime d14 = DateTime.Parse("2021-04-22T16:43:58");

            Console.WriteLine("d11: " + d11);
            Console.WriteLine("d11 Kind: " + d11.Kind);
            Console.WriteLine("d11 Local: " + d11.ToLocalTime());
            Console.WriteLine("d11 UTC: " + d11.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d12: " + d12);
            Console.WriteLine("d12 Kind: " + d12.Kind);
            Console.WriteLine("d12 Local: " + d12.ToLocalTime());
            Console.WriteLine("d12 UTC: " + d12.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d13: " + d13);
            Console.WriteLine("d13 Kind: " + d13.Kind);
            Console.WriteLine("d13 Local: " + d13.ToLocalTime());
            Console.WriteLine("d13 UTC: " + d13.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("Variavel D14 já instanciada na ISO 8601: " + d14.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
