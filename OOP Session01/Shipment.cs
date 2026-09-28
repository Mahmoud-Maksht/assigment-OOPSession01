using System.Threading.Channels;

namespace OOP_Session01
{
    public struct Shipment
    {
        #region Theo.Q2

        //public string Description;
        //public double Weight; 
        //public decimal Salary;

        //Three problems with this struct:
        //1- All fileds are public
        //2- No constructor to initialize the fields
        //3- No validation for the fields (e.g., weight should be positive, salary should be non-negative)

        //private string Description;
        //private double Weight;
        //private decimal Salary;
        //public string GetDescription()
        //{
        //    return Description; 
        //}
        //public void SetDescription(string description)
        //{
        //    Description = description;
        //}

        //public double GetWeight()
        //{
        //    return Weight;
        //}
        //public void SetWeight(double weight)
        //{
        //    Weight = weight > 0 ? weight : throw new ArgumentException("Weight must be positive."); 
        //}

        //public decimal GetSalary()
        //{
        //    return Salary;
        //}
        //public void SetSalary(decimal salary)
        //{
        //    Salary = salary > 0 ? salary : throw new ArgumentException("Salary must be non-negative.");
        //}
        #endregion

        #region Pract.Smart Delivery Management System
        private string trackingcode;
        private string description;
        private double weight;
        private decimal deliveryfee;
        private DeliveryAddress destention;
        public string TrackingCode
        {
            get { return trackingcode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value)) trackingcode = value;
            }
               
        }
        public string Description
        {
            get { return description; }
            set { if(!string.IsNullOrWhiteSpace(value)) description = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }   
        public decimal DeliveryFee
        {
            get { return deliveryfee; }
            private set { if (value > 0) deliveryfee = value; }
        }
        public DeliveryAddress Destention
        {
            get { return destention; }
            set { destention = value; }
        }
        public decimal EstimatedCost()
        { 
            return deliveryfee + (decimal)(Weight * 5);
        }
        public Shipment(string trackingcode)
        {
            TrackingCode= trackingcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destention = default;
        }
        public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destention)
        {
            TrackingCode = trackingcode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryfee;
            Destention = destention;
        }
        public decimal UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
            return DeliveryFee;
        }
        public void PrintShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destention.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost()}");
        }   

        #endregion
    }
}
