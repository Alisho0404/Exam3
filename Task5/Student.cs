namespace Task5;

public class Student:Person
{
private string _programm; 
private int _year; 
private double _fee; 
public Student(string name,string address,string programm, int year, double fee):base(name,address)
{
    _programm=programm; 
    _year=year; 
    _fee=fee;
} 
public string GetProgramm()
{
    return _programm;
} 
public void SetProgramm(string programm)
{
_programm=programm;
} 
public int GetYear()
{
    return _year; 
} 
public void SetYear(int year)
{
     _year=year;
} 
public double GetFee()
{
    return _fee;
} 
public void SetFee(double fee)
{
    _fee=fee;
}
    public override string ToString()
    {
        return $"{base.ToString()} programm: {_programm} year: {_year} fee: {_fee}";
    }
}
