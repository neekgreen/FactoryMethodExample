namespace SelfHost
{
    using System;
    using System.Linq;
    using SomeApp;

    public class Tenant : ITenant
    {
        public string TenantId { get; set; }
        public string CommonName { get; set; }
    }
}