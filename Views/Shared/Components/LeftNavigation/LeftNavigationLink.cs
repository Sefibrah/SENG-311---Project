using System;

namespace lab2.Models
{
    public class LeftNavigationLink
    {
        public LeftNavigationLink(string text, string url)
        {
            Text = text;
            Url = url;
        }

        public string Text { get; set; }
        public string Url { get; set; }
    }
}
