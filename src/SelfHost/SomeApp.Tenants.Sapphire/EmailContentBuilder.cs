namespace SomeApp
{
    using System;
    using System.Linq;

    public class EmailContentBuilder : IEmailContentBuilder, ITenantOverride
    {
        EmailContent IEmailContentBuilder.GenerateContent(ITenant tenant)
        {
            return new EmailContent
            {
                MessageBody = "This is content for sapphire tenant."
            };
        }
        bool ITenantOverride.IsForThisTenant(ITenant tenant)
        {
            return tenant != null && tenant.TenantId == "sapphire";
        }
    }
}