using dicom_backend.src.endpoints.interfaces;

namespace dicom_backend.src.endpoints.common;

public static class AppEndpointExtension
{
    public static WebApplication RegisterEndpoints(this WebApplication app, IEndpoint endpoint)
    {   
        endpoint.SetEnv(app.Environment);
        endpoint.SetConfig(app.Configuration);
        endpoint.Map(app);
        return app;
    }
}