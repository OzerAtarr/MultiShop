namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProcutStock { get; set; }
        public string ProcutImageUrl { get; set; }
        public string ProcutDescription { get; set; }
        public string CategoryId { get; set; }
    }
}
