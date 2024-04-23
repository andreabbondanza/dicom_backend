namespace dicom_backend.src.settings;

public class DicomSettings
{
    public string Ip { get; set; }
    public int Port { get; set; }
    public bool UseTLS{ get; set; }
    public string ServerAETitle { get; set; }
    public string ClientAETitle { get; set; }
}
