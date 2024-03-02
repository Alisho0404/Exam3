using Task6;
var dog = new Dog("Rex");
var bigDog = new BigDog("Sharik"); 

dog.Greets();
dog.Greets(bigDog); 
bigDog.Greets();
bigDog.Greets(bigDog);  