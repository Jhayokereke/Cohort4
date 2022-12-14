namespace InputOutput
{
    public class Text
    {
        public void Share(List<string> members)
        {
            Console.WriteLine(string.Join(", ", members));
        }
    }
}