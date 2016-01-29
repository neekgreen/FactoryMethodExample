namespace SomeApp
{
    using System;
    using System.Linq;
    using StructureMap;

    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.ExcludeObsoleteTypes();
            });

            For<IContentGenerator>().Use<ContentGenerator>();
        }
    }
}