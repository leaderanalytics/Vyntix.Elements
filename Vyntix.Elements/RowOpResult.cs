﻿namespace LeaderAnalytics.Vyntix.Elements;

public class RowOpResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
}

public class RowOpResult<T> : RowOpResult
{
    public T Item { get; set; }

    public RowOpResult() { }

    public RowOpResult(T item, bool success = true)
    {
        this.Success = success;
        this.Item = item;
    }
}
