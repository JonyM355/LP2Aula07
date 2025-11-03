namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ICollection<IObserver<AbstractStringSubject>> observers;

        private string item;
        public string Item
        {
            get => item;
            protected set
            {
                if (value != item)
                {
                    item = value;
                    foreach (IObserver<AbstractStringSubject> obs in observers)
                    {
                        obs.Update(this);
                    }
                }
            }
        }

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