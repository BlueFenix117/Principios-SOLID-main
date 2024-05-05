using System;

namespace InterfaceSegregation
{
    public class Developer : IDevActivities
    {
        public void Design()
        {
            Console.WriteLine("I'm designing functionalities.");
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required.");
        }

        public void Test()
        {
            Console.WriteLine("I'm testing the functionalities.");
        }
    }
}
