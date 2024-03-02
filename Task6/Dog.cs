namespace Task6;

 class Dog:Animal
{
    public Dog(string name):base(name)
    {
        
    }
    public override void Greets()
    {
        Console.WriteLine("Woof");
    } 
    public virtual void Greets(Dog another)
    {
        Console.WriteLine("Wooof");
    }
} 
