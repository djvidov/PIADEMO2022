using System;

namespace EventsDelegates
{
    public class Notifier
    {
        public Notifier(int seconds, string message)
        {
            Seconds = seconds;
            Message = message;
            Timer timer = new Timer(NotifierCallback, null, seconds * 1000, 0);
        }
        int Seconds { get; set; }
        string Message { get; set; }

        void NotifierCallback(object? sender)
        {
            if(Notify != null)
            {
                Notify(this, new NotifierEventArgs
                {
                    Seconds = Seconds,
                    Message = Message
                });
            }
        }

        public event NotifierCallback Notify;
    }

    public delegate void NotifierCallback(object? sender, NotifierEventArgs eventArgs);

    public class NotifierEventArgs: EventArgs
    {
        public int Seconds { get; set; }
        public string Message { get; set; } = string.Empty;
    }

}