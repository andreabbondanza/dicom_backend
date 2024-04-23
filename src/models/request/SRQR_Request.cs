using src.models.common;

namespace dicom_backend.src.models.request;
public class StudioRootQueryRetriver_Request
{
    public string PatientId { get; set; }
    public string PatientName { get; set; }
    public DateTime? StudyFromDate { get; set; }
    public DateTime? StudyToDate { get; set; }
    public List<ModalityType> Modalities { get; set; }
}


