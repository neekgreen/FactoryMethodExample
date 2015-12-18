namespace Common
{
    using System;
    using System.Linq;

    public interface ITenantOverride
    {
        bool IsForThisTenant(ITenant tenant);
    }
}