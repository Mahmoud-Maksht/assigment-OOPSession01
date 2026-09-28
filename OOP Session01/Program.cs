namespace OOP_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theo.Q1
            //address1 don't change because it's a struct and struct is a value type

            //DeliveryAddress address1 = new DeliveryAddress();
            //address1.city = "New York";
            //address1.street = "123 Main St";
            //Console.WriteLine($"Address 1 - City: {address1.city}, Street: {address1.street}");
            //DeliveryAddress address2 = address1; // Copying the struct
            //address2.city = "Los Angeles"; // Modifying the copy
            //address2.street = "456 Elm St"; // Modifying the copy
            //Console.WriteLine($"Address 1 - City: {address1.city}, Street: {address1.street}");
            //Console.WriteLine($"Address 2 - City: {address2.city}, Street: {address2.street}");

            ////customer1 change because it's a class and class is a reference type
            //Customer customer1 = new Customer();
            //customer1.name = "Ahmed";
            //Console.WriteLine($"Customer 1 - Name: {customer1.name}");
            //Customer customer2 = customer1; // Copying the reference
            //customer2.name = "Mahmoud"; // Modifying the copy
            //Console.WriteLine($"Customer 1 - Name: {customer1.name}");
            //Console.WriteLine($"Customer 2 - Name: {customer2.name}");
            #endregion

            #region Pract.Smart Delivery Management System
            #region Delivery Address

            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Eltahrir St", 456);
            DeliveryAddress address2 = address1;
            address2.city = "Elmonifia";
            address2.street = "Denshwai St";
            address2.buildingNumber = 789;
            Console.WriteLine("----------Struct copy test----------");
            Console.WriteLine($"Original Address: {address1.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {address2.GetFullAddress()}");
            #endregion

            DeliveryCenter deliverycenter = new DeliveryCenter();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Entre Shipment{i+1}");
                Console.Write("Tracking code :");
                string trackingcode = Console.ReadLine();
                Console.Write("Entre Decription :");
                string decription = Console.ReadLine();
                Console.Write("Entre Weight :");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Entre DeliveryFee :");
                decimal deliveryfee = decimal.Parse(Console.ReadLine());
                Console.Write("Enter city :");
                string city = Console.ReadLine();
                Console.Write("Entre Street :");
                string street = Console.ReadLine();
                Console.Write("Entre BuildingNumber :");
                int buildingNumber = int.Parse(Console.ReadLine());
                DeliveryAddress deliveryAddress = new DeliveryAddress(city,street,buildingNumber);
                Shipment shipment = new Shipment(trackingcode,decription, weight, deliveryfee, deliveryAddress); 
                if (deliverycenter.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment Added Successfuly");
                }
            }
                Console.WriteLine("---------All Shipments---------");
                for (int i = 0; i<3; i++)
                {
                deliverycenter[i].PrintShipmentDetails();
                }
            Console.WriteLine("Entre TrackingCode");
            string searchcode = Console.ReadLine();
            Shipment found = deliverycenter[searchcode];
            if (found.TrackingCode != null)
            {
                Console.WriteLine($"Shaipment found {found.TrackingCode} :: {found.Description}");
            }
                else
                {
                    Console.WriteLine("The TrackingCode Not Found");
                }
            }
            #endregion


        }
    }

