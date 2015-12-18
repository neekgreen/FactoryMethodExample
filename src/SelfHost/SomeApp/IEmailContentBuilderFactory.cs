namespace SomeApp
{
    using System;
    using System.Linq;

    public interface IEmailContentBuilderFactory
    {
        IEmailContentBuilder GetBuilder(ITenant tenant);
    }
}