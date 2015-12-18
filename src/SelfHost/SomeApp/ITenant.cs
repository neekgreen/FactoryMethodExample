namespace SomeApp
{
    using System;
    using System.Linq;

    public interface ITenant
    {
        string TenantId { get; }
        string CommonName { get; }
    }
}