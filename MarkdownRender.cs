using System;
using System.Collections.Generic;
using System.Text;
using Markdig;

namespace Margit
{
    static class MarkdownRender
    {
        private static readonly string styleLink = "<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/github-markdown-css/3.0.1/github-markdown.min.css'>";
        private static readonly string wrapperStart = "<div class='markdown-body'>";
        private static readonly string wrapperEnd = "</div>";

        static public string Md2HTML(string MdContent)
        {
            string HtmlContent;
            string RenderContent;

            HtmlContent = Markdown.ToHtml(MdContent);
            RenderContent = styleLink + wrapperStart + HtmlContent + wrapperEnd;
            return RenderContent;
        }
    }
}
