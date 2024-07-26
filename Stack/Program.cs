namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);
            for (int i = 0; i < 3; i++)
            {
                stack.Push("blachers");
                stack.Push("beesesr");
                stack.Push("feels");
            }
            stack.Pop();
            stack.Peek();

            while (!stack.isEmpty())
            {
                var var = stack.Pop();
                Console.WriteLine(var);
            }

        }
    }
}
