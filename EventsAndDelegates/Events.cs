using System.Security.Cryptography;

public class Events
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            System.Console.WriteLine("Event received " + message);
        }
    }
}