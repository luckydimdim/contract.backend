namespace contract.backend
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World");
        }
    }
}
