using System;



namespace InterfaceSegregation
{
    public interface IScrumMasterActivities
    {
        void Plan();
        void Communicate();
    }

    public class ScrumMaster : IScrumMasterActivities
    {
        public void Plan()
        {
            Console.WriteLine("Soy un planeador");
        }

        public void Communicate()
        {
            Console.WriteLine("Esta hablando con el usuario");
        }
    }
}
