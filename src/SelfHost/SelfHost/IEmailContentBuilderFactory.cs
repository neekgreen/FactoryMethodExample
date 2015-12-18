namespace SelfHost
{
    using System;
    using System.Linq;
    using SomeApp;

    public interface IEmailContentBuilderFactory
    {
        IEmailContentBuilder GetBuilder(ITenant tenant);
    }
}