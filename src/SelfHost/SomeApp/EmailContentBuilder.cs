namespace SomeApp
{
    using System;
    using System.Linq;

    public class EmailContentBuilder : IEmailContentBuilder, IDefaultImplementation
    {
        EmailContent IEmailContentBuilder.GenerateContent(ITenant tenant)
        {
            return new EmailContent
            {
                MessageBody = "This is the default content."
            };
        }
    }
}