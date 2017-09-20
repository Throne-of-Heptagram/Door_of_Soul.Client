using Door_of_Soul.Core;

namespace Door_of_Soul.Client
{
    public class AnswerFactory : GenericSubjectRepository<int, ClientAnswer>
    {
        public static AnswerFactory Instance { get; private set; } = new AnswerFactory();

        private AnswerFactory()
        {

        }

        public bool Create(int answerId, string answerName, int[] soulIds, out ClientAnswer answer)
        {
            answer = new ClientAnswer(answerId, answerName);
            for (int i = 0; i < soulIds.Length; i++)
            {
                answer.LinkSoul(soulIds[i]);
            }
            return Add(answerId, answer);
        }
    }
}
