namespace Gintuay.Models
{
    public class BuyOrder
    {
        public int BuyOrderId { get; set; }
        public int User_UserId { get; set; }
        public int PickupOrder_PickupOrderId { get; set; }
        public int PickupOrder_User_UserId { get; set; }
        public int Addon_AddonID { get; set; }
        public string Location { get; set; }
        public string Other { get; set; }
        public string Status { get; set; }
        public string Bill { get; set; }
    }
}
