using HtmlAgilityPack;
using System;
using System.IO;
using System.Collections.Generic;
using System.Net;

namespace subTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write site address!");
            string path = Console.ReadLine();
            StreamWriter sr = new StreamWriter(@"file.txt");
            sr.WriteLine($"This file contains all links, phones and e-mails from {path}");
            foreach (var outp in HtmlAgilityPack(path))
            {
                Console.WriteLine(outp);
                sr.WriteLine(outp);
            }
            sr.Close();
            Console.ReadKey();
        }

        public static IEnumerable<string> HtmlAgilityPack(string path)
        {
            HtmlDocument htmlSnippet = new HtmlDocument();
            WebClient wc = new WebClient();
            htmlSnippet.LoadHtml(wc.DownloadString(@path));

            List<string> hrefTags = new List<string>();

            foreach (HtmlNode link in htmlSnippet.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute att = link.Attributes["href"];
                hrefTags.Add(att.Value);
            }

            return hrefTags;
        }
    }
}
