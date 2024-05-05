using System;

namespace InterfaceSegregation
{
    // Interfaz espec�fica para las responsabilidades de un Tester
    public interface ITesterActivities
    {
        void Test();
    }

    public class Tester : ITesterActivities
    {
        public void Test()
        {
            Console.WriteLine("Soy un app de testeo");
        }
    }
}
