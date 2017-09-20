using Door_of_Soul.Core;

namespace Door_of_Soul.Client
{
    public class EntityFactory : GenericSubjectRepository<int, ClientEntity>
    {
        public static EntityFactory Instance { get; private set; } = new EntityFactory();

        private EntityFactory()
        {

        }
    }
}
