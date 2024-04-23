using dicom_backend.src.endpoints.interfaces;

namespace dicom_backend.src.endpoints.common
{

    public abstract class SingleEndpoint : IEndpoint
    {
        public string BasePath { get; set; } = "/api";
        public string ApiVersion { get; set; }
        public string EndpointPath { get; set; }
        public IWebHostEnvironment Env { get; set; }
        public IConfiguration Config { get; set; }

        public SingleEndpoint(string apiVersion, string endpointPath)
        {
            ApiVersion = apiVersion.StartsWith("/") ? apiVersion : "/" + apiVersion;
            EndpointPath = endpointPath.StartsWith("/") ? endpointPath : "/" + endpointPath;
        }

        public string BuildPath(string path)
        {
            return BasePath
            + (ApiVersion.StartsWith("/") ? ApiVersion : "/" + ApiVersion)
            + (EndpointPath.StartsWith("/") ? EndpointPath : "/" + EndpointPath)
            + (path.StartsWith("/") ? path : "/" + path);
        }

        public abstract void Map(WebApplication app);

        public void SetEnv(IWebHostEnvironment env)
        {
            this.Env = env;
        }

        public void SetConfig(IConfiguration config)
        {
            this.Config = config;
        }
    }
}