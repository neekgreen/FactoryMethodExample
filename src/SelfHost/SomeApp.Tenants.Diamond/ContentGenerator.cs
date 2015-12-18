namespace SomeApp
{
    using System;
    using System.Linq;

    public class ContentGenerator : IContentGenerator 
    {
        string IContentGenerator.GenerateContent()
        {
            return Guid.NewGuid().ToString();
        }
    }
}