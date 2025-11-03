namespace Observers
{
    public class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ICollection<IObserver<AbstractStringSubject>> observers;

        public AbstractStringSubject()
        {
            observers = new HashSet<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoverObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }
    }
}