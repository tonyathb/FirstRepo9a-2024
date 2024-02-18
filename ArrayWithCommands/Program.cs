namespace ArrayWithCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the elements i array");
            string[] arr = Console.ReadLine().Split().ToArray();

            int commandCount = int.Parse(Console.ReadLine());

            for (int command = 0; command< commandCount; command++)
            {
                string input = Console.ReadLine();
                switch(input)
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        string[] resultArr=arr.Distinct().ToArray();
                        arr = resultArr;
                        break;
                    default://input = Replace 6 "jhjhj"
                        string[] comands = input.Split().ToArray();
                        int index = int.Parse(comands[1]);
                        
                        if (comands[0] =="Replace")
                        {
                            arr[index] = comands[2];
                        }
                        else
                        {
                            if (true)
                            {

                            }
                            //break;
                            break;
                            //drugi comsands
                        }
                        break;

                }
                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
