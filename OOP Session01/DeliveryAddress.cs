namespace OOP_Session01;

public struct DeliveryAddress
{
    #region Theo.Q1

    //public string city;
    //public string street;
    #endregion

    #region Pract.Smart Delivery Management System
    private string City;
    private string Street;
    private int BuildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }
    public string city
    {
        get { return City; }
        set { City = value; }
    }
    public string street
    {
        get { return Street; }
        set { Street = value; }
    }
    public int buildingNumber
    {
        get { return BuildingNumber; }
        set { BuildingNumber = value; }
    }

    public string GetFullAddress()
    {
        return $"{BuildingNumber} {Street} {City}";
    }
    #endregion


}
