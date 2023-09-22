namespace LeaderAnalytics.Vyntix.Elements;

public enum DownloadResult
{
    Aborted,        // User shuts down or computer powers off or premature shut down for external reason with no exception thrown
    Faulted,        // An exception is thrown and caught
    Canceled,       // User cancels and download gracefully terminates
    Successful
}
