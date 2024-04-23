namespace dicom_backend.src.endpoints.interfaces;

public interface IEndpoint
{
    public string BasePath { get; set; }
    public string ApiVersion { get; set; }
    public string EndpointPath { get; set; }
    public IWebHostEnvironment Env { get; set; }
    public IConfiguration Config { get; set; }
    public string BuildPath(string path);
    public void Map(WebApplication app);
    public void SetEnv(IWebHostEnvironment env);
    public void SetConfig(IConfiguration config);
}