namespace DependencyInjectionDemo.Services
{
    public class SingletonServiceDemo : ISingletonService
    {
        private readonly Guid _id;

        public SingletonServiceDemo()
        {
            _id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _id.ToString();
        }
    }
}
