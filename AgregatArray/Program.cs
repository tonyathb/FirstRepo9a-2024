namespace AgregatArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day broy na elementite: ");
            int n=int.Parse(Console.ReadLine());
            //array
            int[] numbers = new int[n];
            //1.input the elements
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                Console.Write($"num[{i}] = ");
                numbers[i]= int.Parse(Console.ReadLine());
            }

            //2.Sum
            long sum = 0l;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Sum= {sum}");
            //4.min
            int min = int.MaxValue;
            int minPos = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min= numbers[i];
                    minPos = i;
                }
            }
            Console.WriteLine($"{min} ==> {minPos} index");

            //5.print ALL elements
            for (int i = 0;i <= numbers.Length-1; i++)
            {
                Console.WriteLine($"num[{i}] = {numbers[i]}");
            }


        }
    }
}
