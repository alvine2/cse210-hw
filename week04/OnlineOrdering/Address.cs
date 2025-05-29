using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetStreetAddress() 
    { 
        return _streetAddress; 
    }
    
    public void SetStreetAddress(string streetAddress) 
    { 
        _streetAddress = streetAddress; 
    }

    public string GetCity() 
    { 
        return _city; 
    }
    
    public void SetCity(string city) 
    { 
        _city = city; 
    }

    public string GetStateProvince() 
    { 
        return _stateProvince; 
    }
    
    public void SetStateProvince(string stateProvince) 
    { 
        _stateProvince = stateProvince; 
    }

    public string GetCountry() 
    { 
        return _country; 
    }
    
    public void SetCountry(string country) 
    { 
        _country = country; 
    }

    // Check if address is in Uganda
    public bool IsInUganda()
    {
        return _country.ToUpper() == "UGANDA" || 
               _country.ToUpper() == "UG" || 
               _country.ToUpper() == "REPUBLIC OF UGANDA";
    }

    // Return formatted address string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}
