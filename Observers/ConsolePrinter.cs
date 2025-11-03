namespace 
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        public void Update(AbstractStringSubject sub)
        {
            Console.WriteLine(sub);
        }
    }
}