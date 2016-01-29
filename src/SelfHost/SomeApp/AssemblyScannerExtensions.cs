namespace SomeApp
{
    using System;
    using System.Linq;
    using StructureMap.Graph;

    public static class AssemblyScannerExtensions
    {
        public static void ExcludeObsoleteTypes(this IAssemblyScanner scan)
        {
            scan.Exclude(x => x.GetCustomAttributes(false).OfType<ObsoleteAttribute>().Any());
            scan.Exclude(x => x.GetInterfaces().OfType<IObsoleteImplementation>().Any());
        }
    }
}