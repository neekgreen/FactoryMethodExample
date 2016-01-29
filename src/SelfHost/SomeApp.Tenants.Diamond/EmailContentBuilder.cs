namespace SomeApp
{
    using System;
    using System.Linq;

    [Obsolete ]
    public class EmailContentBuilder : IEmailContentBuilder, ITenantImplementation, IObsoleteImplementation
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
        bool ITenantImplementation.IsForThisTenant(ITenant tenant)
        {
            return tenant != null && tenant.TenantId == "diamond";
        }
    }
}