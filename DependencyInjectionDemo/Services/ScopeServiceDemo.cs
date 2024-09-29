namespace DependencyInjectionDemo.Services
{
    public class ScopeServiceDemo : IScopeService
    {
        private readonly Guid _id;

        public ScopeServiceDemo()
        {
            _id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _id.ToString();
        }
    }
}
