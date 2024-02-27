using System.Text;

namespace StringMethodsHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //while (true)
            //{
            //    ShowMenu();
            //    string c = Console.ReadLine();
            //    if (c == "5")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        OperationsSwitchCase(c);
            //    }

            //}
            #endregion

            //string s = "Lorem ipsum doler Ayxan Kamran Nihad";
            //Console.WriteLine(CountOfWords(s));

            //Console.WriteLine(SumOfDigits("213"));

            //Console.WriteLine(ReversedString("salam"));

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(PowerOfNumbers(a,b));

            //string word = "abc + cba * asd ///asdas";
            //char[] arr = {'+','*','/'};
            //Console.WriteLine(SumOfSymbols(word, arr));

            //ToPositiveOfMinus(2, -3, 4, -5, 7);

                   

        }

        static void ShowMenu()
        {
            Console.WriteLine("Proses secin: ");
            Console.WriteLine("1.Toplama ");
            Console.WriteLine("2.Cixma ");
            Console.WriteLine("3.Vurma ");
            Console.WriteLine("4.Bolme ");
            Console.WriteLine("5.Sonlandir ");

        }

        static int SumOfSymbols(string word, char[] arr)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void OperationsSwitchCase(string c)
        {
            Console.WriteLine("1-ci ededi daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin:");
            int b = int.Parse(Console.ReadLine());

            switch (c)
            {
                case "1":
                    Console.WriteLine(a + b);
                    break;
                case "2":
                    Console.WriteLine(a - b);
                    break;
                case "3":
                    Console.WriteLine(a * b);
                    break;
                case "4":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Duzgun eded daxil et");
                    break;
            }
        }
        static int CountOfWords(string s)
        {
            s += " ";
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==' ')
                {
                    if (s[i - 1] != ' ') count++;
                }
            }
            return count;
        }
        static int SumOfDigits(string s)
        {
            int result=Convert.ToInt32(s);
            int sum = default;
            while (result>0)
            {
                int a = result % 10;
                sum += a;
                result/=10;
            }
            return sum;
        }

        static int PowerOfNumbers(int a,int b)
        {
            int quvvet = 1;
            for (int i = 0; i < b; i++)
            {
                quvvet *= a;
            }
            return quvvet;
        }

        static void ToPositiveOfMinus(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] *= -1;
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }
        }

        static string ReversedString(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
    }
}