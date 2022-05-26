namespace StackProgram
{
    public class Program
    {
        public static void Main()
        {
            int choice;
            Stack s = new Stack();

            while(true)
            {
                Console.WriteLine("Enter a choice\n 1. Push 2.pop");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        s.push();
                        break;

                    case 2:
                        s.pop();
                        break;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
            
        }
    }
}
