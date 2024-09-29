namespace DependencyInjectionDemo.Services
{
    public class TransientServiceDemo : ITransientService
    {
        private readonly Guid _id;

        public TransientServiceDemo()
        {
            _id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _id.ToString();
        }
    }
}
