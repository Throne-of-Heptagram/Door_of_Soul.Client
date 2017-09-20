using Door_of_Soul.Core;

namespace Door_of_Soul.Client
{
    public class AvatarFactory : GenericSubjectRepository<int, ClientAvatar>
    {
        public static AvatarFactory Instance { get; private set; } = new AvatarFactory();

        private AvatarFactory()
        {

        }

        public bool Create(int avatarId, int entityId, string avatarName, int[] soulIds, out ClientAvatar avatar)
        {
            avatar = new ClientAvatar(avatarId, entityId, avatarName);
            for (int i = 0; i < soulIds.Length; i++)
            {
                avatar.LinkSoul(soulIds[i]);
            }
            return Add(avatarId, avatar);
        }
    }
}
