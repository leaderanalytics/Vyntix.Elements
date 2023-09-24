namespace LeaderAnalytics.Vyntix.Elements;

public interface IDataProvider
{
    int ID { get; set; }
    string Name { get; set; }
    int SystemID { get; set; }
    string DownloadURI { get; set; }
    string Login { get; set; }
    string Password { get; set; }
    DateTime? LastDownload { get; set; }
    DownloadResult LastDownloadResult { get; set; }
    int UserID { get; set; }
}
