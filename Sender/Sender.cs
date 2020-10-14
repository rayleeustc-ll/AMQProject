using Amqp;
using System;

namespace Sender
{
    class Sender
    {
        static void Main(string[] args)
        {
            Address address = new Address("amqp://guest:guest@localhost:5672");
            Connection connection = new Connection(address);
            Session session = new Session(connection);

            SenderLink sender = new SenderLink(session, "sender-link", "amqp");
            Message message = null;
            foreach (string s in TestCase.data)
            {
                message = new Message(s);
                sender.Send(message);
                Console.WriteLine("Sent {0}!", s);
            }

            sender.Close();
            session.Close();
            connection.Close();
        }
    }
}
