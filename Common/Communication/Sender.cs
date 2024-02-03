using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Communication
{
    public class Sender
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send(object argument)
        {
            formatter.Serialize(stream, argument);
        }
    }
}
