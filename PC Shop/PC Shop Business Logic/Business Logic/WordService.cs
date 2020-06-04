using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using PC_Shop_Business_Logic.Helpers;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class WordService
    {
        public static void CreateDoc(WordInfo info)
        {
            using (WordprocessingDocument doc = WordprocessingDocument
                .Create(info.FileName, WordprocessingDocumentType.Document))
            {
                string header = "Отчет по заявке №" + info.RequestID.ToString();
                Paragraph headerParagraph = CreateParagraph (0, 24, header, true, JustificationValues.Center);
                string supplier = "Поставщик: " + info.SupplierName;
                Paragraph supplierParagraph = CreateParagraph(0, 24, supplier, false, JustificationValues.Left);
                string date = "Дата исполнения: " + info.CompletionDate.ToString();
                Paragraph dateParagraph = CreateParagraph(0, 24, date, false, JustificationValues.Left);

                List<TableRow> tableRows = new List<TableRow>();

                Paragraph idHeaderParagraph = CreateParagraph
                    (0, 20, "ID", true, JustificationValues.Center);
                TableCell idHeaderCell = CreateCell(idHeaderParagraph, 1000);
                Paragraph nameHeaderPargraph = CreateParagraph
                    (100, 20, "Название", true, JustificationValues.Left);
                TableCell nameHeaderCell = CreateCell(nameHeaderPargraph, 7500);
                Paragraph countHeaderParagraph = CreateParagraph
                    (0, 20, "Количество", true, JustificationValues.Center);
                TableCell countHeaderCell = CreateCell(countHeaderParagraph, 2500);
                List<TableCell> headerCells = new List<TableCell>()
                {
                    idHeaderCell, nameHeaderCell, countHeaderCell
                };
                TableRow headerRow = CreateRow(headerCells);
                tableRows.Add(headerRow);

                foreach (var element in info.RequestComponents)
                {
                    List<TableCell> tableCells = new List<TableCell>();
                    Paragraph idParagraph = CreateParagraph
                        (0, 20, element.Key.ToString(), false, JustificationValues.Center);
                    TableCell idCell = CreateCell(idParagraph, 1000);
                    Paragraph nameParagraph = CreateParagraph
                        (100, 20, element.Value.Item1, false, JustificationValues.Left);
                    TableCell nameCell = CreateCell(nameParagraph, 7500);
                    Paragraph countParagraph = CreateParagraph
                        (0, 20, element.Value.Item2.ToString(), false, JustificationValues.Center);
                    TableCell countCell = CreateCell(countParagraph, 2500);
                    tableCells.Add(idCell);
                    tableCells.Add(nameCell);
                    tableCells.Add(countCell);
                    TableRow tableRow = CreateRow(tableCells);
                    tableRows.Add(tableRow);
                }

                Table table = CreateTable(tableRows);
                SectionProperties sectionProperties = CreateSectionProperties();
                List<OpenXmlElement> docElements = new List<OpenXmlElement>
                {
                    headerParagraph,
                    supplierParagraph,
                    dateParagraph,
                    table,
                    sectionProperties
                };

                Body body = CreateBody(docElements);
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Document();
                mainPart.Document.Append(body);
                doc.MainDocumentPart.Document.Save();
            }
        }

        private static TableCell CreateCell(Paragraph paragraph, int width)
        {
            TableCell tableCell = new TableCell();

            TableCellProperties tableCellProperties = new TableCellProperties();

            TableCellWidth tableCellWidth = new TableCellWidth()
            {
                Width = width.ToString(),
                Type = TableWidthUnitValues.Dxa
            };

            TableCellVerticalAlignment tableCellVerticalAlignment = new TableCellVerticalAlignment()
            {
                Val = TableVerticalAlignmentValues.Center
            };

            tableCellProperties.Append(tableCellWidth);
            tableCellProperties.Append(tableCellVerticalAlignment);

            tableCell.Append(tableCellProperties);
            tableCell.Append(paragraph);

            return tableCell;
        }

        private static TableRow CreateRow(List<TableCell> cells)
        {
            TableRow tableRow = new TableRow()
            {
                RsidTableRowMarkRevision = "00860290",
                RsidTableRowAddition = "00860290",
                RsidTableRowProperties = "00860290"
            };

            TableRowProperties tableRowProperties = new TableRowProperties();
            TableRowHeight tableRowHeight = new TableRowHeight() 
            { 
                Val = (UInt32Value)680U, 
                HeightType = HeightRuleValues.Exact 
            };

            TableJustification tableJustification = new TableJustification()
            {
                Val = TableRowAlignmentValues.Center
            };

            tableRowProperties.Append(tableRowHeight);
            tableRowProperties.Append(tableJustification);

            tableRow.Append(tableRowProperties);

            foreach (TableCell cell in cells)
            {
                tableRow.Append(cell);
            }

            return tableRow;
        }

        private static Table CreateTable(List<TableRow> rows)
        {
            Table table = new Table();

            TableProperties tableProperties = new TableProperties(
                new TableBorders(new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 },
                new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 },
                new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 },
                new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 },
                new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 },
                new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Birds), Size = 1 })
            );

            TableStyle tableStyle = new TableStyle() { Val = "a5" };

            TableWidth tableWidth = new TableWidth()
            {
                Width = "10000",
                Type = TableWidthUnitValues.Dxa
            };


            TableLook tableLook = new TableLook()
            {
                Val = "04A0", 
                FirstRow = true, 
                LastRow = false, 
                FirstColumn = true, 
                LastColumn = false, 
                NoHorizontalBand = false, 
                NoVerticalBand = true 
            };

            TableJustification tableJustification = new TableJustification()
            {
                Val = TableRowAlignmentValues.Center
            };

            tableProperties.Append(tableStyle);
            tableProperties.Append(tableWidth);
            tableProperties.Append(tableJustification);
            tableProperties.Append(tableLook);

            TableGrid tableGrid = new TableGrid();

            GridColumn gridColumn1 = new GridColumn() { Width = "1500" };
            GridColumn gridColumn2 = new GridColumn() { Width = "6000" };
            GridColumn gridColumn3 = new GridColumn() { Width = "2500" };

            tableGrid.Append(gridColumn1);
            tableGrid.Append(gridColumn2);
            tableGrid.Append(gridColumn3);

            table.Append(tableProperties);
            table.Append(tableGrid);

            foreach (TableRow row in rows)
            {
                table.Append(row);
            }

            return table;
        }

        private static Paragraph CreateParagraph(int identation, int size, 
            string data, bool isBold, JustificationValues justValue)
        {
            Paragraph paragraph = new Paragraph()
            {
                RsidParagraphMarkRevision = "00930FB9",
                RsidParagraphAddition = "0022650D",
                RsidParagraphProperties = "00860290",
                RsidRunAdditionDefault = "00860290"
            };

            ParagraphProperties paragraphProperties = new ParagraphProperties();

            SpacingBetweenLines spacingBetweenLines = new SpacingBetweenLines()
            {
                Before = "0",
                After = "0"
            };

            Indentation indentation = new Indentation() { FirstLine = identation.ToString() };

            Justification justification = new Justification() { Val = justValue };

            ParagraphMarkRunProperties paragraphMarkRunProperties = new ParagraphMarkRunProperties();
            RunFonts markRunFonts = new RunFonts()
            {
                Ascii = "Century Gothic",
                HighAnsi = "Century Gothic"
            };

            paragraphMarkRunProperties.Append(markRunFonts);

            if (isBold)
            {
                Bold bold = new Bold();
                BoldComplexScript boldComplexScript = new BoldComplexScript();
                paragraphMarkRunProperties.Append(bold);
                paragraphMarkRunProperties.Append(boldComplexScript);
            }

            FontSize markRunfontSize = new FontSize() { Val = size.ToString() };
            paragraphMarkRunProperties.Append(markRunfontSize);

            paragraphProperties.Append(spacingBetweenLines);
            paragraphProperties.Append(indentation);
            paragraphProperties.Append(justification);
            paragraphProperties.Append(paragraphMarkRunProperties);

            Run run = new Run() { RsidRunProperties = "00930FB9" };

            RunProperties runProperties = new RunProperties();
            RunFonts runFonts = new RunFonts()
            {
                Ascii = "Century Gothic",
                HighAnsi = "Century Gothic"
            };

            runProperties.Append(runFonts);

            Text text = new Text
            {
                Text = data
            };

            if (isBold)
            {
                Bold bold = new Bold();
                BoldComplexScript boldComplexScript = new BoldComplexScript();
                runProperties.Append(bold);
                runProperties.Append(boldComplexScript);
            }

            FontSize runfontSize = new FontSize() { Val = size.ToString() };
            runProperties.Append(runfontSize);

            run.Append(runProperties);
            run.Append(text);

            paragraph.Append(paragraphProperties);
            paragraph.Append(run);

            return paragraph;
        }

        private static Body CreateBody(List<OpenXmlElement> elements)
        {
            Body body = new Body();

            foreach (OpenXmlElement element in elements)
            {
                body.Append(element);
            }

            return body;
        }

        private static SectionProperties CreateSectionProperties()
        {
            SectionProperties sectionProperties = new SectionProperties()
            {
                RsidRPr = "00860290",
                RsidR = "00860290",
                RsidSect = "00860290"
            };
            PageSize pageSize = new PageSize()
            {
                Width = (UInt32Value)11906U,
                Height = (UInt32Value)16838U
            };
            PageMargin pageMargin = new PageMargin()
            {
                Top = 720,
                Right = (UInt32Value)720U,
                Bottom = 720,
                Left = (UInt32Value)720U,
                Header = (UInt32Value)708U,
                Footer = (UInt32Value)708U,
                Gutter = (UInt32Value)0U
            };

            Columns columns = new Columns() { Space = "708" };
            DocGrid docGrid = new DocGrid() { LinePitch = 381 };

            sectionProperties.Append(pageSize);
            sectionProperties.Append(pageMargin);
            sectionProperties.Append(columns);
            sectionProperties.Append(docGrid);

            return sectionProperties;
        }
    }
}