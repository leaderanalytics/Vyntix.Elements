namespace LeaderAnalytics.Vyntix.Elements;

public interface IDataProvider
{
    int ID { get; set; }
    string Name { get; set; }
    int SystemID { get; set; }
    string Setting1 { get; set; }
    string Setting2 { get; set; }
    string Password { get; set; }
    DateTime? LastDownloadDate { get; set; }
    DownloadResult LastDownloadResult { get; set; }
    int UserID { get; set; }
}
