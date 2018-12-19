using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{

    class PDFHandler
    {
        PdfDocument doc = new PdfDocument();
        public void createPDF(Recept recept)
        {
            doc.Info.Title = recept.naam;
           
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            XFont smallFont = new XFont("Verdana", 11, XFontStyle.Regular);
            XFont heading2Font = new XFont("Verdana", 14, XFontStyle.Bold);
            gfx.DrawString(recept.naam, font, XBrushes.Black, new XRect(0,10 , page.Width, 40), XStringFormats.TopCenter);
            gfx.DrawString("________________________________________________________________________", smallFont, XBrushes.Black, new XRect(0, 25, page.Width, 40), XStringFormats.TopCenter);
            gfx.DrawString("Benodigdheden", heading2Font, XBrushes.Black, new XRect(20, 50, page.Width, 40), XStringFormats.TopLeft);
            int listHeight = 70;
            for(int i = 0; i < recept.benodigdheden.Length; i++)
            {
                gfx.DrawString(" - " + recept.benodigdheden[i], smallFont, XBrushes.Black, new XRect(20, listHeight, page.Width, 40), XStringFormats.TopLeft);
                listHeight += 12;
            }
            string root = @"C:\CookIT";
            string subdir = @"C:\CookIT";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            const string filename = @"C:\CookIt\Recept.pdf";
            doc.Save(filename);
            Process.Start(filename);
        }
    }
}
