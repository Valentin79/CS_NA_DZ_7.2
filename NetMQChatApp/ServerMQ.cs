
using NetMQ;
using NetMQ.Sockets;

namespace NetMQChatApp
{
    public class ServerMQ
    {
        public static void Server()
        {
            
            using (var server = new ResponseSocket())
            {
                //server.Bind("tcp://*:5555");
                server.Bind("tcp://127.0.0.1:5556");
                Console.WriteLine("Запускаю сервер");
                while (true)
                {
                    var message = server.ReceiveFrameString();
                    Console.WriteLine("Received:", message);
                    server.SendFrame("Сообщение получено");
                }
            }
        }
    }
}
