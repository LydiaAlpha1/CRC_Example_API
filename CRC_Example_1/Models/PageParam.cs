namespace CRC_Example_1.Models
{
    public class PageParam
    {
        private int _maxPageSize = 50;
        private int itemPerPage;
        public int PageNumber { get; set; } = 1;
        public int itemsPerPage
        {
            get { return itemPerPage; } 
            set { itemPerPage = (value > _maxPageSize) ? _maxPageSize : value; }
        }
    }
}
