
using System.Xml.Linq;

namespace FirstApplication
{
    public class Logic
    {
        static public String answer(String name1, String name2)
        {
            var set = new Dictionary<char, int>();
            String answer = "";
            for (int i = 0; i < name1.Length; i++)
            {
                set[name1[i]] = 0;
            }

            for (int i = 0; i < name1.Length; i++)
            {
                set[name1[i]]++;

                if (set[name1[i]] == 1 && name2.Contains(name1[i]))
                {
                    answer += "да ";
                }
                else if (set[name1[i]] == 1)
                {
                    answer += "нет ";
                }
            }


            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var name1 = Console.ReadLine();
            var name2 = Console.ReadLine();

            var outMessage = Logic.answer(name1, name2);

            Console.WriteLine(outMessage);



        }

    }
}

