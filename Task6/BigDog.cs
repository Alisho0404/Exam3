namespace Task6;

 class BigDog : Dog
{
    public BigDog(string name):base(name)
    {
        
    }
    public override void Greets()
    {
        Console.WriteLine("Wooow");
    }
    public override void Greets(Dog another)
    {
        Console.WriteLine("Woooooow");
    } 

    public void Greets(BigDog another)
    {
        Console.WriteLine("Woooooooooooooooooooow");
    }
}
