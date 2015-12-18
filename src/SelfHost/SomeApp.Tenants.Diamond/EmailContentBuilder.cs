namespace SomeApp
{
    using System;
    using System.Linq;

    public class EmailContentBuilder : IEmailContentBuilder, ITenantOverride
    {
        private readonly IContentGenerator someService;

        public EmailContentBuilder(IContentGenerator someService)
        {
            this.someService = someService;
        }

        EmailContent IEmailContentBuilder.GenerateContent(ITenant tenant)
        {
            return new EmailContent
            {
                MessageBody = this.someService.GenerateContent()
            };
        }
        bool ITenantOverride.IsForThisTenant(ITenant tenant)
        {
            return tenant != null && tenant.TenantId == "diamond";
        }
    }
}