using Amqp;
using System;

namespace Receiver
{
    class Receiver
    {
        static void Main(string[] args)
        {
            Address address = new Address("amqp://guest:guest@localhost:5672");
            Connection connection = new Connection(address);
            Session session = new Session(connection);
            ReceiverLink receiver = new ReceiverLink(session, "receiver-link", "amqp");

            Console.WriteLine("Receiver connected to broker.");
            Message message = receiver.Receive();
            while (message != null)
            {
                Console.WriteLine("Received " + message.Body);
                receiver.Accept(message);
                message = receiver.Receive();
            }

            receiver.Close();
            session.Close();
            connection.Close();
        }
    }
}
