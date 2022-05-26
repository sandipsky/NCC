namespace StackProgram
{
    public class Stack
    {
        int max = 20;
        int[] stack = new int[20];
        int top = -1;
        int data;
        public void push()
        {
            if(top<=max-1)
            {
                Console.WriteLine("Enter a data");
                data = Convert.ToInt32(Console.ReadLine());
                top++;
                stack[top] = data;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
            Console.WriteLine("Elements of stack");
            for(int i = -1; i < top; i++)
            {
                Console.WriteLine(stack[top]);
            }
        }

        public void pop()
        {
            if(top>-1)
            {
                top--;
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
            Console.WriteLine("Elements of stack");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(stack[top]);
            }
        }
    }
}
