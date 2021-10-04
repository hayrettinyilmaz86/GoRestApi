namespace Core.Infrastructure.Data.PagedList
{
    public class pagination
    {
        public pagination()
        {
            page = 1;
        }
        public int total { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int pages { get; set; }
    }
}