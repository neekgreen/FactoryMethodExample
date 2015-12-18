namespace SelfHost
{
    using System;
    using System.Linq;
    using SomeApp;

    public interface IEmailContentBuilder
    {
        EmailContent GenerateContent(ITenant tenant);
    }
}