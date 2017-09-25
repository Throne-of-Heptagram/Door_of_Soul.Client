using Door_of_Soul.Core.Client;

namespace Door_of_Soul.Client
{
    public class ClientAvatar : VirtualAvatar
    {
        public ClientAvatar(int avatarId, int entityId, string avatarName) : base(avatarId, entityId, avatarName)
        {
        }
        public override string ToString()
        {
            return $"Client{base.ToString()}";
        }
    }
}
