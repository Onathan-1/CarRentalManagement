namespace CarRentalManagement.Domain {
    public class Vehicle : BaseDomainModel { 
        public int Year { get; set; }
        public String? LicensePlateNumber { get; set;}
        public int MakeID { get; set;}
        public int modelID { get; set; }
        public int ColourID { get; set; }
    }
}