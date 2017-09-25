using Door_of_Soul.Core.Client;

namespace Door_of_Soul.Client
{
    public class ClientAnswer : VirtualAnswer
    {
        public ClientAnswer(int answerId, string answerName) : base(answerId, answerName)
        {
        }
        public override string ToString()
        {
            return $"Client{base.ToString()}";
        }

        public override void LoadProxySoul(int soulId, string soulName, bool isActivated, int answerId, int[] avatarIds)
        {
            ClientSoul soul;
            if (SoulFactory.Instance.Create(soulId, soulName, isActivated, answerId, avatarIds, out soul))
            {
                LinkSoul(soulId);
            }
        }
    }
}
