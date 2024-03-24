using ConsoleApp16;

namespace ConsoleApp16
{
    public class Array : IOutput, IMath
    {
        public void Show(int[] num)
        {
            foreach (int i in num) { Console.Write(i + " "); }
        }
        public void Show(int[] num, string info)
        {
            Console.WriteLine("\nInfo: " + info);
            foreach (int i in num) { Console.Write(i + " "); }
        }

        public int Max(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > temp) { temp = num[i]; }
            }
            Console.WriteLine(temp);
            return temp;
        }
        public int Min(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < temp) { temp = num[i]; }
            }
            Console.WriteLine(temp);
            return temp;
        }
        public float Avg(int[] num)
        {
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                temp += num[i];
            }
            Console.WriteLine(temp / num.Length);
            return temp / num.Length;
        }
        public bool Search(int[] num, int valueToSearch)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == valueToSearch)
                {
                    Console.WriteLine(true);
                }
                else Console.WriteLine(false);
            }
            return false;
        }
    }
}