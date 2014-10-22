namespace DawnsTime
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
        protected virtual Nancy.Bootstrapper.NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                return Nancy.Bootstrapper.NancyInternalConfiguration.Default;
            }
        }
    }
}