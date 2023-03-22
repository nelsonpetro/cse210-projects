using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddres(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsUsa()
    {
        return _address.Usa();
    }
}