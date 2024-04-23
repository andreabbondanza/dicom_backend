using src.models.common;
namespace dicom_backend.src.models.response;

public class SRQR_Response
{
    public string PatientName { get; set; }
    public string PatientId { get; set; }
    public string PatientBirthDate { get; set; }
    public string PatientSex { get; set; }
    public List<Study> Studies { get; set; }
}

public class Study
{

    public string StudyInstanceUID { get; set; }
    public string StudyDate { get; set; }
    public string StudyDescription { get; set; }
    public string AccessionNumber { get; set; }
    public DateTime DateTime { get; set; }
    public string Modality { get; set; }
}

/*ES RISPOSTA:

[
  {
    "patientName": "DE MARIA^GIUSEPPE",
    "patientId": "0000009009",
    "patientBirthDate": "19640507",
    "patientSex": "M",
    "studyInstanceUID": "1.2.250.1.59.911.1001.1001.10000156996.20231006080655.1427",
    "studyDate": "20231006",
    "studyDescription": "RX BACINO E ANCHE",
    "date": "2023-10-06T00:00:00"
  },
  {
    "patientName": "DE MARIA^GIUSEPPE",
    "patientId": "0000009009",
    "patientBirthDate": "19640507",
    "patientSex": "M",
    "studyInstanceUID": "1.2.250.1.59.911.1001.1001.10000156997.20231006080655.1518",
    "studyDate": "20231006",
    "studyDescription": "RX RACHIDE LOMBO-SACRALE",
    "date": "2023-10-06T00:00:00"
  }
]
*/