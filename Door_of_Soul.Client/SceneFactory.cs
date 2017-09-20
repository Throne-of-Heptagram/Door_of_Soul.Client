using Door_of_Soul.Core;

namespace Door_of_Soul.Client
{
    public class SceneFactory : GenericSubjectRepository<int, ClientScene>
    {
        public static SceneFactory Instance { get; private set; } = new SceneFactory();

        private SceneFactory()
        {

        }
    }
}
