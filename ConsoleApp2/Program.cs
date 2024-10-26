namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            MyStack<int> stack = new MyStack<int>();
            //Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int x = stack.Pop();
            
            Console.WriteLine(x);

        }
    }
}
