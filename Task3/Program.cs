 /* Полиморфизм як кисми дигари ООП буда бисёршаклиро мефахмонад. Полимарфизм бо 3 рох истифода бурда мешавад 
 1. Virtual 2. Abstarct  3yumashro holo naxondem 
 Virtual як рохи истифодабарии полиморфизм аст ва маънояш ин аст ки агар мо хохиши изменит кардани 
 ягон методи класси асосиро дар класси бачаги дошта бошем онро тавассути virtual menavisem ва дар 
 класси бачаги ин метод бояд override шавад. Методхои виртуали монанди дигар методхо астанд ва фаркияташон ин аст 
 ки онхоро хатман бояд override namoem. 
 class Person
{
     public virtual void PrintPerson()
    {
        Console.WriteLine("Hey guys");
    }
}  

class Student: Person
{
    public override void PrintPerson()
    {
        Console.WriteLine("Hey Student");
    }
} 
Чуноне ки дидем классе ки мерос мегирад методро ба таври дигар истифода бурд. 
 */