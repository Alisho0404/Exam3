namespace Task5;

public class Person
{
private string _name; 
private string _address; 
public Person(string name,string address)
{
   _name=name; 
   _address=address; 
} 
public string GetName()
{
    return _name;
} 
public string GetAdress()
{
    return _address;
} 
public void SetAdress(string address)
{
_address=address;
}
    public override string ToString()
    {
        return $"Name: {_name} Adress: {_address}";
    }
}
