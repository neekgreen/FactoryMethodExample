namespace SomeApp
{
    using System;
    using System.Linq;

    public interface ITenantImplementation
    {
        bool IsForThisTenant(ITenant tenant);
    }
}