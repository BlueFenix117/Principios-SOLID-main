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
            Console.WriteLine("I'm planning user stories");
        }

        public void Communicate()
        {
            Console.WriteLine("I'm talking to the team user");
        }
    }
}
