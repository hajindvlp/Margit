using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Markdig;

namespace Margit
{
    static class MarkdownRender
    { 
        private static readonly string wrapperStart = "<div class='markdown-body'>";
        private static readonly string wrapperEnd = "</div>";
        private static readonly string encoding = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>";

        static public string Md2HTML(string MdContent, bool isDark)
        {
            string style = Style.GetStyle(isDark);
            string styleHtml = "<style>" + style + "</style>";
            string HtmlContent;
            string RenderContent;

            HtmlContent = Markdown.ToHtml(MdContent);
            RenderContent = encoding + styleHtml + wrapperStart + HtmlContent + wrapperEnd;

            return RenderContent;
        }
    }
}
