namespace WebAPI.DTOs
{
    public class OrderRequest
    {
        public List<int> ProductIds { get; set; } = new();
    }
}