﻿using System;
using GroupDocs.Editor.Options;

namespace GroupDocs.Editor.Examples.CSharp.BasicUsage
{
    class GetHtmlContentWithPrefix
    {
        internal static void Run()
        {
            using (Editor editor = new Editor(FilesHelper.Docx, delegate { return new WordProcessingLoadOptions(); }))
            {
                using (EditableDocument document = editor.Edit(new WordProcessingEditOptions()))
                {
                    string externalImagesPrefix = "http://www.mywebsite.com/images/id=";
                    string externalCssPrefix = "http://www.mywebsite.com/css/id=";
                    string prefixedHtmlContent = document.GetContent(externalImagesPrefix, externalCssPrefix);
                    Console.WriteLine("HTML content of the input document with custom image and stylesheet prefixes: {0}", prefixedHtmlContent);
                }
            }
        }
    }
}