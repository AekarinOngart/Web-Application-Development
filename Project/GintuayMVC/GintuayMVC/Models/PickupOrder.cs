namespace Gintuay.Models
{
    public class PickupOrder
    {
        public int PickupOrderId { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Price { get; set; }
        public string Other { get; set; }
        public string EndTime { get; set; }
        public int User_UserId { get; set; }
        public int Image_ImageID { get; set; }
        public string Qrcode { get; set; }

    }
}