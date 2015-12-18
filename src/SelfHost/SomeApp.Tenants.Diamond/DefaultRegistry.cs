namespace SomeApp
{
    using System;
    using System.Linq;
    using StructureMap;

    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            For<IContentGenerator>().Use<ContentGenerator>();
        }
    }
}