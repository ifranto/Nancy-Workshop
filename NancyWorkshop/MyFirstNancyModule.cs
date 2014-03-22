using Nancy;

namespace NancyWorkshop
{
    public class MyFirstNancyModule : NancyModule
    {
        public MyFirstNancyModule()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}