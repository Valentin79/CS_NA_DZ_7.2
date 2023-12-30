using NetMQChatApp;
namespace SolutionMQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ServerMQ.Server();
            }
            else
            {
                ClientMQ.SendMessage(args[0]);
            }
        }
    }
}
