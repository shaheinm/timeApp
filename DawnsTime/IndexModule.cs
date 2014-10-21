using Nancy;

namespace DawnsTime
{
    public class TimeModule : NancyModule
    {
        public TimeModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}