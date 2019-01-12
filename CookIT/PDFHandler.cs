using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CookIT
{

    class PDFHandler
    {
        PdfDocument doc = new PdfDocument();
        LogHandler er = new LogHandler();
        public void createPDF(Recept recept)
        {
            doc.Info.Title = recept.naam;
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            XFont smallFont = new XFont("Verdana", 11, XFontStyle.Regular);
            XFont heading2Font = new XFont("Verdana", 14, XFontStyle.Bold);
            gfx.DrawString(recept.naam, font, XBrushes.Black, new XRect(0, 10, page.Width, 40), XStringFormats.TopCenter);
            gfx.DrawString("Auteur: " + recept.auteur, smallFont, XBrushes.Black, new XRect(20, 10, page.Width, 40), XStringFormats.TopLeft);
            
            gfx.DrawString("_________________________________________________________________________________________________________", smallFont, XBrushes.Black, new XRect(0, 30, page.Width, 40), XStringFormats.TopCenter);
            gfx.DrawString("Description: " + recept.desc, smallFont, XBrushes.Black, new XRect(20, 50, page.Width, 40), XStringFormats.TopLeft);
            int listHeight = 100;
            gfx.DrawString("Benodigdheden", heading2Font, XBrushes.Black, new XRect(20, 100, page.Width, page.Height), XStringFormats.TopLeft);
            listHeight = listHeight + 20;
            for (int i = 0; i < recept.benodigdheden.Count; i++)
            {
                gfx.DrawString(" - " + recept.benodigdheden[i], smallFont, XBrushes.Black, new XRect(20, listHeight, page.Width, 40), XStringFormats.TopLeft);
                listHeight += 12;
            }
            listHeight = 120;
            gfx.DrawString("Ingredienten", heading2Font, XBrushes.Black, new XRect(300, 100, page.Width, 40), XStringFormats.TopLeft);
            for (int i = 0; i < recept.ingredienten.Count; i++)
            {
                gfx.DrawString("-" + recept.ingredienten[i], smallFont, XBrushes.Black, new XRect(310, listHeight, page.Width, 40), XStringFormats.TopLeft);
                listHeight += 12;
            }
            listHeight = listHeight + 20;
            gfx.DrawString("Stappen", heading2Font, XBrushes.Black, new XRect(20, listHeight, page.Width, page.Height), XStringFormats.TopLeft);
            listHeight = listHeight + 40;
            for (int i = 0; i < recept.stappen.Count; i++)
            {
                gfx.DrawString("O     " + recept.stappen[i], smallFont, XBrushes.Black, new XRect(40, listHeight, page.Width, 40), XStringFormats.TopLeft);
                listHeight += 12;
            }
            string root = @"C:\CookIT\Recepten\";
           
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string filename = @"C:\CookIT\Recepten\" + recept.naam + "_Recept.pdf";
            try
            {
                doc.Save(filename);
                MessageBox.Show("Succesfully Created "+  recept.naam +"_Recept.pdf \n" +
                    "Location:  " + filename + "" );
            }
            catch (IOException io)
            {
                MessageBox.Show("Please close your previous window using this file");
                er.AddLineToLog(io.Message);
            }
            Process.Start(filename);
        }

        
    }
}
