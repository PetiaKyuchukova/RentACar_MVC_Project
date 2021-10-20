namespace RentACar.Models
{
    public class Customer : User
    {       
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string DebitCard { get; set; }
    }
}
