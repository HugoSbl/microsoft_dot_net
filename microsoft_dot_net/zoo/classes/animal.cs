namespace zoo.classes;

//class abstract permettant de definir les animaux du zoo
public abstract class Animal
{
    private string name;
    private int age;
    
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public abstract void Eat();
    public abstract void Sleep();
}