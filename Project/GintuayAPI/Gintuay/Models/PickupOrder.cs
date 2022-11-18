namespace Gintuay.Models
{
    public class PickupOrder
    {
        public int PickupOrderId { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Price { get; set; }
        public string Other { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int User_UserId { get; set; }
        public string Add1 { get; set; }
        public int Price1 { get; set; }
        public string Add2 { get; set; }
        public int Price2 { get; set; }
        public int Image_ImageID { get; set; }

    }
}
