namespace SelfHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SomeApp;

    public class EmailContentBuilderFactory : IEmailContentBuilderFactory
    {
        private readonly IEnumerable<IEmailContentBuilder> emailContentBuilders;
        private readonly IEmailContentBuilder defaultEmailContentBuilder;

        public EmailContentBuilderFactory(IEnumerable<IEmailContentBuilder> emailContentBuilders)
        {
            this.emailContentBuilders = emailContentBuilders;

            this.defaultEmailContentBuilder =
                this.emailContentBuilders
                    .OfType<IDefaultImplementation>()
                    .OfType<IEmailContentBuilder>()
                    .FirstOrDefault();
        }

        IEmailContentBuilder IEmailContentBuilderFactory.GetBuilder(ITenant tenant)
        {
            var result = GetTenantSpecificEmailContentBuilder(tenant);

            if (result == null)
                result = defaultEmailContentBuilder;

            if (result == null)
                result = emailContentBuilders.FirstOrDefault();

            if (result == null)
                throw new ArgumentNullException();

            return result;
        }


        private IEmailContentBuilder GetTenantSpecificEmailContentBuilder(ITenant tenant)
        {
            var result =
                this.emailContentBuilders
                    .OfType<ITenantOverride>()
                    .Where(t => t.IsForThisTenant(tenant))
                    .OfType<IEmailContentBuilder>()
                    .FirstOrDefault();

            return result;
        }
    }
}