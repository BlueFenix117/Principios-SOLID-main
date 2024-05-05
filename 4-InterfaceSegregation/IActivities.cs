namespace InterfaceSegregation
{

    public interface IActivities
    {
        void Plan();
        void Communicate();
        void Design();
        void Develop();
        void Test();
    }


    public interface IDevActivities
    {
        void Design();
        void Develop();
        void Test();
    }


    public interface IPlanCommActivities
    {
        void Plan();
        void Communicate();
    }
}
