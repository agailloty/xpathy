using System.Collections.Generic;
using HtmlAgilityPack;

namespace XpathRunner.Service;

public class XpathService
{
    public IList<string> ExtractHtmlContent(string filepath, string xpath)
    {
        var content = new List<string>();
        var doc = new HtmlDocument();
        doc.Load(filepath);

        var results = doc.DocumentNode.SelectNodes(xpath);
        if (results == null)
            return content;

        foreach (var result in results)
            content.Add(result.InnerText);
        return content;
    }
}