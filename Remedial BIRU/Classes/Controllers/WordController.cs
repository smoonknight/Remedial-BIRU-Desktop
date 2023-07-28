using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Remedial_BIRU.DataCollections;
using Remedial_BIRU.Properties;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Remedial_BIRU.Classes.Controllers
{
    class WordController
    {
        public static void ConvertCustomerArrearsDataToWord(List<CustomerArrearsData> customerArrearsDatas)
        {
            string templatePath = "Data/template.docx";
            string currentDate = DateTime.Today.ToString("dd/MM/yyyy");

            DocX docX = DocX.Load("Data/placeholder.docx");
            DocX document = DocX.Load(templatePath);

            docX.Bookmarks["date"].SetText(currentDate);
            int increment = 0;
            foreach (CustomerArrearsData customerArrearsData in customerArrearsDatas)
            {
                increment++;
                DocX duplicator = document;
                duplicator.Bookmarks["route"].SetText(increment.ToString());
                duplicator.Bookmarks["name"].SetText(customerArrearsData.name);
                duplicator.Bookmarks["address"].SetText(customerArrearsData.address);
                duplicator.Bookmarks["contactNumber"].SetText(customerArrearsData.contactNumber);
                duplicator.Bookmarks["daysInArrears"].SetText(customerArrearsData.daysInArrears);
                duplicator.Bookmarks["dueDate"].SetText(customerArrearsData.dueDate);
                duplicator.Bookmarks["ceiling"].SetText(TextController.FormatRupiah(customerArrearsData.ceiling));
                duplicator.Bookmarks["totalPayment"].SetText(TextController.FormatRupiah(customerArrearsData.totalPayment));
                duplicator.Bookmarks["col"].SetText(customerArrearsData.col);
                duplicator.Bookmarks["uid"].SetText(customerArrearsData.uid);
                duplicator.Bookmarks["latitude"].SetText(customerArrearsData.latitude.ToString());
                duplicator.Bookmarks["longitude"].SetText(customerArrearsData.longitude.ToString());

                Picture foto;
                if (File.Exists($"Data/{customerArrearsData.uid}.png"))
                {
                    foto = duplicator.AddImage($"Data/{customerArrearsData.uid}.png").CreatePicture();
                }
                else
                {
                    foto = duplicator.AddImage("Data/placeholder.png").CreatePicture();
                }
                document.Bookmarks["photo"].Paragraph.AppendPicture(foto);

                foto.Remove();
                docX.InsertDocument(duplicator);
            }
            docX.SaveAs("filename.docx");
            Process.Start("filename.docx");
        }
    }
}
