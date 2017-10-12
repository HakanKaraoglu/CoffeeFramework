
namespace Coffee.Service.Api
{
    public class Settings
    {


        public Service Service { get; set; }
    }
    public class Service
    {
        public string BaseUrls { get; set; }
        public string ServiceName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
