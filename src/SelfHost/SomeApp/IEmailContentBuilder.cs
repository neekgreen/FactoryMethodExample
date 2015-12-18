namespace SomeApp
{
    using System;
    using System.Linq;

    public interface IEmailContentBuilder
    {
        EmailContent GenerateContent(ITenant tenant);
    }
}