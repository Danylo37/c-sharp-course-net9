namespace Lessons_net9;

public delegate void Notify(string msg);

class MessagePublisher
{
    public event Notify OnNotify;

    public void RaiseEvent(string msg)
    {
        OnNotify?.Invoke(msg);
    }
}

class SmsSubscriber
{
    public void ReceiveSms(string msg)
    {
        Console.WriteLine("Sms received: " + msg);
    }
}

class EmailSubscriber
{
    public void ReceiveEmail(string msg)
    {
        Console.WriteLine("Email received: " + msg);
    }
}

internal static class Program 
{
    private static void Main()
    {
        MessagePublisher messagePublisher = new MessagePublisher();

        var smsReceiver = new SmsSubscriber();
        var emailReceiver = new EmailSubscriber();

        messagePublisher.OnNotify += smsReceiver.ReceiveSms;
        messagePublisher.OnNotify += emailReceiver.ReceiveEmail;

        messagePublisher.RaiseEvent("Hello World!");
        
        Console.WriteLine();

        messagePublisher.OnNotify -= smsReceiver.ReceiveSms;

        messagePublisher.RaiseEvent("Hello World!");
    }
}
