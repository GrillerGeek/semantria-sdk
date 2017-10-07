namespace Semantria.Com
{
    public enum TaskStatus
    {
        UNDEFINED,
        FAILED,
        QUEUED,
        PROCESSED
    }

    public enum QueryMethod 
    { 
        GET,
        POST,
        PUT,
        DELETE 
    }

    public enum StatsMethod
    {
        Interval,
        Range,
        GroupedRange
    }

    public enum StatsInterval
    {
        Day,
        Week,
        Month,
        Year,
        All
    }
}
