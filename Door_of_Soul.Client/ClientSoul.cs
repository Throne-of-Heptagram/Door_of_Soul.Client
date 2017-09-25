using Door_of_Soul.Core.Client;

namespace Door_of_Soul.Client
{
    public class ClientSoul : VirtualSoul
    {
        public ClientSoul(int soulId, string soulName, bool isActivated) : base(soulId, soulName, isActivated)
        {
        }
        public override string ToString()
        {
            return $"Client{base.ToString()}";
        }

        public override void LoadProxyAvatar(int avatarId, int entityId, string avatarName, int[] soulIds)
        {
            ClientAvatar avatar;
            if(AvatarFactory.Instance.Create(avatarId, entityId, avatarName, soulIds, out avatar))
            {
                LinkAvatar(avatarId);
            }
        }
    }
}
