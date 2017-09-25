using Door_of_Soul.Core.Client;

namespace Door_of_Soul.Client
{
    public class ClientWorld : VirtualWorld
    {
        public override string ToString()
        {
            return $"Client{base.ToString()}";
        }
    }
}
