namespace OOPBasics
{
    public class Person
    {    
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name{
            get { return name; }
        }
        public int Age {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age=value; //blocked negative age
                }
            }

        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }
}
