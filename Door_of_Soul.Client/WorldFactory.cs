using Door_of_Soul.Core;

namespace Door_of_Soul.Client
{
    public class WorldFactory : GenericSubjectRepository<int, ClientWorld>
    {
        public static WorldFactory Instance { get; private set; } = new WorldFactory();

        private WorldFactory()
        {

        }
    }
}
