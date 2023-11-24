namespace LeaderAnalytics.Vyntix.Elements;

public class APIResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
}

public class APIResult<T> : APIResult
{
    public T Data { get; set; }

    public APIResult() { }

    public APIResult(T data, bool success = true)
    {
        this.Success = success;
        this.Data = data;
    }
}
