namespace SelfHost
{
    using System;
    using System.Linq;
    using SomeApp;
    using StructureMap;
    using StructureMap.Graph;

    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.AssemblyContainingType<Program>();
                scan.AssembliesFromApplicationBaseDirectory(t => t.FullName.StartsWith("SomeApp"));
                scan.WithDefaultConventions();
                scan.LookForRegistries();
                scan.ExcludeObsoleteTypes();

                scan.AddAllTypesOf<IEmailContentBuilder>();
            });
        }
    }
}