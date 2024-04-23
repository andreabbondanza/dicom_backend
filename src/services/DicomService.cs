using dicom_backend.src.endpoints.interfaces;
using dicom_backend.src.models;
using FellowOakDicom.Network;
using FellowOakDicom.Network.Client;
namespace dicom_backend.src.services;

public class DicomService: IService {
    private IDicomClient _client;

    public DicomService(string dicomServerIP, int dicomServerPort, bool useTls, string dicomServerAETitle, string dicomClientAETitle) {
        _client = DicomClientFactory.Create(dicomServerIP, dicomServerPort, useTls, dicomServerAETitle, dicomClientAETitle);
        // _client = DicomClientFactory.Create("127.0.0.1", 4242, false, "ORTHANC", "ORTHANC");
    }

    public void init()  
    {
        
    }

    public async Task<StandardResponse<DicomCFindResponse>> QueryRetrievePatient(string patientId, string patientName)
    {
        try
        {
            var tcs = new TaskCompletionSource<DicomCFindResponse>();
            var cfind = DicomCFindRequest.CreatePatientQuery(patientId, patientName);
            cfind.OnResponseReceived += (DicomCFindRequest rq, DicomCFindResponse rp) =>
            {
                
            };
            
        }
        catch (System.Exception)
        {
            
        }
        var response = new Object() as DicomCFindResponse;
        return new StandardResponse<DicomCFindResponse>(response);
    } 
}