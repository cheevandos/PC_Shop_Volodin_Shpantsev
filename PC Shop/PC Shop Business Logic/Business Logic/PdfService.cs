using iTextSharp.text;
using iTextSharp.text.pdf;
using PC_Shop_Business_Logic.Helpers;
using PC_Shop_Business_Logic.View_Models;
using System.Collections.Generic;
using System.IO;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class PdfService
    {
        public static void CreateDoc(OrdersReportInfo reportInfo)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(reportInfo.FileName, FileMode.Create));
            document.Open();
            BaseFont baseFont = BaseFont.CreateFont(
                @"C:\Windows\Fonts\arial.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.NOT_EMBEDDED);
            Font font = new Font(baseFont, 8, Font.NORMAL);
            PdfPTable table = new PdfPTable(6);
            PdfPCell headerCell = new PdfPCell(new Phrase(
                "Отчет по заказам с "
                + reportInfo.StartDate.ToShortDateString()
                + " по "
                + reportInfo.EndDate.ToShortDateString(), font))
            {
                Colspan = 6,
                HorizontalAlignment = 1,
                Border = 0
            };
            table.AddCell(headerCell);
            PdfPCell emptyCell = new PdfPCell(new Phrase(" ", font))
            {
                Colspan = 6,
                HorizontalAlignment = 1,
                Border = 0
            };
            table.AddCell(emptyCell);
            SetHeaders(table, font);
            SetData(reportInfo.Orders, table, font);
            document.Add(table);
            document.Close();
        }

        private static void SetHeaders(PdfPTable table, Font font)
        {
            PdfPCell nameCell = new PdfPCell(new Phrase("Компьютер", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(nameCell);
            PdfPCell countCell = new PdfPCell(new Phrase("Количество", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(countCell);
            PdfPCell statusCell = new PdfPCell(new Phrase("Статус", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(statusCell);
            PdfPCell creationCell = new PdfPCell(new Phrase("Создан", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(creationCell);
            PdfPCell completionCell = new PdfPCell(new Phrase("Завершен", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(completionCell);
            PdfPCell amountCell = new PdfPCell(new Phrase("Сумма", font))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            table.AddCell(amountCell);
        }

        private static void SetData(List<ReportOrderViewModel> orders, PdfPTable table, Font font)
        {
            foreach(var order in orders)
            {
                table.AddCell(new Phrase(order.ComputerName, font));
                table.AddCell(new Phrase(order.Count.ToString(), font));
                table.AddCell(new Phrase(order.Status.ToString(), font));
                table.AddCell(new Phrase(order.CreationDate.ToShortDateString(), font));
                if (order.CompletionDate.HasValue)
                {
                    table.AddCell(new Phrase(order.CompletionDate.Value.ToShortDateString(), font));
                }
                else
                {
                    table.AddCell(new Phrase("-", font));
                }
                table.AddCell(new Phrase(order.Amount.ToString(), font));
            }
        }
    }
}
