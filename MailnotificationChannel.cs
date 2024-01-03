namespace Polymorphism
{
    public class MailnotificationChannel : INotificationChannel
	{
		public void Send(Message message)
		{
			Console.WriteLine("SENDING MAIL...");
		}
	}
}

