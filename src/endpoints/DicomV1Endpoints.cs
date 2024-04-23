using dicom_backend.src.models;
using dicom_backend.src.endpoints.common;
using dicom_backend.src.models.response;
namespace dicom_backend.src.endpoints;

public class DicomV1Endpoints(string apiVersion, string endpointPath) : SingleEndpoint(apiVersion, endpointPath)
{
    public override void Map(WebApplication app)
    {
        app.MapGet("/test", () => new StandardResponse<bool>(true));
        app.MapGet("/study_request", SRQRRequest);
    }

    public async Task<StandardResponse<SRQR_Response>> SRQRRequest()
    {
        var result = new StandardResponse<SRQR_Response>(new SRQR_Response());
        return result;
    }


    
}