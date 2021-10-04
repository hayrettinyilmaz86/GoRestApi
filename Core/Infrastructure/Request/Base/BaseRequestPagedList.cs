namespace Core.Infrastructure.Request.Base
{
    public class BaseRequestPagedList
    {
        public BaseRequestPagedList()
        {
            page = 1;
            limit = 10;
        }
        public int page { get; set; }
        public int limit { get; set; }
    }
}
