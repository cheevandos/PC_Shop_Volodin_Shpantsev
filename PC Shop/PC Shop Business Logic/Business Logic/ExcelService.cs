using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using PC_Shop_Business_Logic.Helpers;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;

namespace PC_Shop_Business_Logic.Business_Logic
{
    public class ExcelService
    {
        public static void CreatePackage(RequestReportInfo info)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument
                .Create(info.FileName, SpreadsheetDocumentType.Workbook))
            {
                CreateParts(package, info);
            }
        }

        private static void CreateParts(SpreadsheetDocument document, RequestReportInfo info)
        {
            WorkbookPart workbookPart = document.AddWorkbookPart();
            GenerateWorkbookPartContent(workbookPart);

            WorkbookStylesPart workbookStylesPart1 = workbookPart.AddNewPart<WorkbookStylesPart>("rId3");
            GenerateWorkbookStylesPartContent(workbookStylesPart1);

            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPartContent(worksheetPart, info);
        }

        private static void GenerateWorkbookPartContent(WorkbookPart workbookPart)
        {
            Workbook workbook = new Workbook() 
            {
                MCAttributes = new MarkupCompatibilityAttributes() 
                {
                    Ignorable = "x15 xr xr6 xr10 xr2" 
                } 
            };
            workbook.AddNamespaceDeclaration(
                "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            workbook.AddNamespaceDeclaration(
                "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            workbook.AddNamespaceDeclaration(
                "x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            workbook.AddNamespaceDeclaration(
                "xr", "http://schemas.microsoft.com/office/spreadsheetml/2014/revision");
            workbook.AddNamespaceDeclaration(
                "xr6", "http://schemas.microsoft.com/office/spreadsheetml/2016/revision6");
            workbook.AddNamespaceDeclaration(
                "xr10", "http://schemas.microsoft.com/office/spreadsheetml/2016/revision10");
            workbook.AddNamespaceDeclaration
                ("xr2", "http://schemas.microsoft.com/office/spreadsheetml/2015/revision2");

            WorkbookProperties workbookProperties = new WorkbookProperties();

            Sheets sheets = new Sheets();
            Sheet sheet = new Sheet() 
            { 
                Name = "Лист1",
                SheetId = (UInt32Value)1U,
                Id = "rId1"
            };

            sheets.Append(sheet);

            workbook.Append(workbookProperties);
            workbook.Append(sheets);

            workbookPart.Workbook = workbook;
        }

        private static void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart)
        {
            Stylesheet stylesheet = new Stylesheet() 
            { 
                MCAttributes = new MarkupCompatibilityAttributes() 
                {
                    Ignorable = "x14ac x16r2 xr" 
                } 
            };
            stylesheet.AddNamespaceDeclaration(
                "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet.AddNamespaceDeclaration(
                "x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            stylesheet.AddNamespaceDeclaration(
                "x16r2", "http://schemas.microsoft.com/office/spreadsheetml/2015/02/main");
            stylesheet.AddNamespaceDeclaration(
                "xr", "http://schemas.microsoft.com/office/spreadsheetml/2014/revision");

            Fonts fonts = new Fonts() { Count = (UInt32Value)1U, KnownFonts = true };

            Font font = new Font();
            FontSize fontSize = new FontSize() { Val = 11D };
            Color color = new Color() { Theme = (UInt32Value)1U };
            FontName fontName = new FontName() { Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering = new FontFamilyNumbering() { Val = 2 };
            FontScheme fontScheme = new FontScheme() { Val = FontSchemeValues.Minor };

            font.Append(fontSize);
            font.Append(color);
            font.Append(fontName);
            font.Append(fontFamilyNumbering);
            font.Append(fontScheme);

            fonts.Append(font);

            Fills fills1 = new Fills() { Count = (UInt32Value)2U };

            Fill fill1 = new Fill();
            PatternFill patternFill1 = new PatternFill() { PatternType = PatternValues.None };

            fill1.Append(patternFill1);

            Fill fill2 = new Fill();
            PatternFill patternFill2 = new PatternFill() { PatternType = PatternValues.Gray125 };

            fill2.Append(patternFill2);

            fills1.Append(fill1);
            fills1.Append(fill2);

            Borders borders = new Borders() { Count = (UInt32Value)2U };

            Border borderDefault = new Border();
            LeftBorder leftBorderDefault = new LeftBorder();
            RightBorder rightBorderDefault = new RightBorder();
            TopBorder topBorderDefault = new TopBorder();
            BottomBorder bottomBorderDefault = new BottomBorder();
            DiagonalBorder diagonalBorderDefault = new DiagonalBorder();

            borderDefault.Append(leftBorderDefault);
            borderDefault.Append(rightBorderDefault);
            borderDefault.Append(topBorderDefault);
            borderDefault.Append(bottomBorderDefault);
            borderDefault.Append(diagonalBorderDefault);

            Border borderThin = new Border();

            LeftBorder leftBorderThin = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color2 = new Color() { Indexed = (UInt32Value)64U };

            leftBorderThin.Append(color2);

            RightBorder rightBorderThin = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color3 = new Color() { Indexed = (UInt32Value)64U };

            rightBorderThin.Append(color3);

            TopBorder topBorderThin = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color4 = new Color() { Indexed = (UInt32Value)64U };

            topBorderThin.Append(color4);

            BottomBorder bottomBorderThin = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color5 = new Color() { Indexed = (UInt32Value)64U };

            bottomBorderThin.Append(color5);
            DiagonalBorder diagonalBorderThin = new DiagonalBorder();

            borderThin.Append(leftBorderThin);
            borderThin.Append(rightBorderThin);
            borderThin.Append(topBorderThin);
            borderThin.Append(bottomBorderThin);
            borderThin.Append(diagonalBorderThin);

            borders.Append(borderDefault);
            borders.Append(borderThin);

            CellStyleFormats cellStyleFormats = new CellStyleFormats() { Count = (UInt32Value)1U };
            CellFormat cellFormat1 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U, 
                FontId = (UInt32Value)0U, 
                FillId = (UInt32Value)0U, 
                BorderId = (UInt32Value)0U 
            };

            cellStyleFormats.Append(cellFormat1);

            CellFormats cellFormats = new CellFormats() { Count = (UInt32Value)7U };
            CellFormat cellFormat2 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U,
                FontId = (UInt32Value)0U,
                FillId = (UInt32Value)0U, 
                BorderId = (UInt32Value)0U,
                FormatId = (UInt32Value)0U
            };

            CellFormat cellFormat3 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U,
                FontId = (UInt32Value)0U, 
                FillId = (UInt32Value)0U,
                BorderId = (UInt32Value)0U, 
                FormatId = (UInt32Value)0U, 
                ApplyAlignment = true 
            };
            Alignment alignment1 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center };

            cellFormat3.Append(alignment1);

            CellFormat cellFormat4 = new CellFormat()
            { 
                NumberFormatId = (UInt32Value)0U, 
                FontId = (UInt32Value)0U, 
                FillId = (UInt32Value)0U, 
                BorderId = (UInt32Value)0U,
                FormatId = (UInt32Value)0U,
                ApplyAlignment = true 
            };
            Alignment alignment2 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center };

            cellFormat4.Append(alignment2);

            CellFormat cellFormat5 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U, 
                FontId = (UInt32Value)0U,
                FillId = (UInt32Value)0U,
                BorderId = (UInt32Value)0U,
                FormatId = (UInt32Value)0U,
                ApplyAlignment = true 
            };
            Alignment alignment3 = new Alignment() { Horizontal = HorizontalAlignmentValues.Left };

            cellFormat5.Append(alignment3);

            CellFormat cellFormat6 = new CellFormat() 
            {
                NumberFormatId = (UInt32Value)0U, 
                FontId = (UInt32Value)0U,
                FillId = (UInt32Value)0U,
                BorderId = (UInt32Value)0U,
                FormatId = (UInt32Value)0U,
                ApplyAlignment = true 
            };
            Alignment alignment4 = new Alignment() { Horizontal = HorizontalAlignmentValues.Left };

            cellFormat6.Append(alignment4);

            CellFormat cellFormat7 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U, 
                FontId = (UInt32Value)0U,
                FillId = (UInt32Value)0U,
                BorderId = (UInt32Value)1U,
                FormatId = (UInt32Value)0U,
                ApplyBorder = true, 
                ApplyAlignment = true
            };
            Alignment alignment5 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center };

            cellFormat7.Append(alignment5);

            CellFormat cellFormat8 = new CellFormat() 
            { 
                NumberFormatId = (UInt32Value)0U,
                FontId = (UInt32Value)0U,
                FillId = (UInt32Value)0U, 
                BorderId = (UInt32Value)1U,
                FormatId = (UInt32Value)0U, 
                ApplyBorder = true, 
                ApplyAlignment = true 
            };
            Alignment alignment6 = new Alignment() { Horizontal = HorizontalAlignmentValues.Left };

            cellFormat8.Append(alignment6);

            cellFormats.Append(cellFormat2);
            cellFormats.Append(cellFormat3);
            cellFormats.Append(cellFormat4);
            cellFormats.Append(cellFormat5);
            cellFormats.Append(cellFormat6);
            cellFormats.Append(cellFormat7);
            cellFormats.Append(cellFormat8);

            CellStyles cellStyles = new CellStyles() { Count = (UInt32Value)1U };
            CellStyle cellStyle = new CellStyle() 
            { 
                Name = "Обычный",
                FormatId = (UInt32Value)0U,
                BuiltinId = (UInt32Value)0U
            };

            cellStyles.Append(cellStyle);

            TableStyles tableStyles = new TableStyles() 
            { 
                Count = (UInt32Value)0U, 
                DefaultTableStyle = "TableStyleMedium2", 
                DefaultPivotStyle = "PivotStyleLight16" 
            };

            StylesheetExtensionList stylesheetExtensionList = new StylesheetExtensionList();

            StylesheetExtension stylesheetExtension1 = new StylesheetExtension() 
            { 
                Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" 
            };

            stylesheetExtension1.AddNamespaceDeclaration(
                "x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() 
            { 
                DefaultSlicerStyle = "SlicerStyleLight1" 
            };

            stylesheetExtension1.Append(slicerStyles1);

            StylesheetExtension stylesheetExtension2 = new StylesheetExtension()
            { 
                Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" 
            };

            stylesheetExtension2.AddNamespaceDeclaration(
                "x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles()
            { 
                DefaultTimelineStyle = "TimeSlicerStyleLight1" 
            };

            stylesheetExtension2.Append(timelineStyles1);

            stylesheetExtensionList.Append(stylesheetExtension1);
            stylesheetExtensionList.Append(stylesheetExtension2);

            stylesheet.Append(fonts);
            stylesheet.Append(fills1);
            stylesheet.Append(borders);
            stylesheet.Append(cellStyleFormats);
            stylesheet.Append(cellFormats);
            stylesheet.Append(cellStyles);
            stylesheet.Append(tableStyles);
            stylesheet.Append(stylesheetExtensionList);

            workbookStylesPart.Stylesheet = stylesheet;
        }

        private static void GenerateWorksheetPartContent(WorksheetPart worksheetPart, RequestReportInfo info)
        {
            Worksheet worksheet = new Worksheet() 
            {
                MCAttributes = new MarkupCompatibilityAttributes()
                { 
                    Ignorable = "x14ac xr xr2 xr3"
                }
            };
            worksheet.AddNamespaceDeclaration(
                "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet.AddNamespaceDeclaration(
                "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet.AddNamespaceDeclaration(
                "x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            worksheet.AddNamespaceDeclaration(
                "xr", "http://schemas.microsoft.com/office/spreadsheetml/2014/revision");
            worksheet.AddNamespaceDeclaration(
                "xr2", "http://schemas.microsoft.com/office/spreadsheetml/2015/revision2");
            worksheet.AddNamespaceDeclaration(
                "xr3", "http://schemas.microsoft.com/office/spreadsheetml/2016/revision3");

            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties()
            { 
                DefaultRowHeight = 15D, 
                DyDescent = 0.25D
            };

            Columns columns = new Columns();

            Column column1 = new Column() 
            { 
                Min = (UInt32Value)1U,
                Max = (UInt32Value)1U,
                Width = 5.7109375D,
                Style = (UInt32Value)1U, 
                CustomWidth = true 
            };
            Column column2 = new Column() 
            {
                Min = (UInt32Value)2U,
                Max = (UInt32Value)2U,
                Width = 50.7109375D, 
                Style = (UInt32Value)3U, 
                CustomWidth = true 
            };
            Column column3 = new Column() 
            { 
                Min = (UInt32Value)3U, 
                Max = (UInt32Value)3U,
                Width = 15.7109375D,
                Style = (UInt32Value)1U,
                CustomWidth = true
            };

            columns.Append(column1);
            columns.Append(column2);
            columns.Append(column3);

            SheetData sheetData = new SheetData();

            Row rowRequest = new Row() 
            {
                RowIndex = (UInt32Value)1U, 
                Spans = new ListValue<StringValue>() 
                { 
                    InnerText = "1:3" 
                }, 
                DyDescent = 0.25D 
            };
            Cell cell1 = new Cell() 
            { 
                CellReference = "A1", 
                StyleIndex = (UInt32Value)2U,
                DataType = CellValues.String
            };
            CellValue cellValue1 = new CellValue
            {
                Text = "Отчет по заявке №" + info.RequestID.ToString()
            };
            cell1.Append(cellValue1);
            Cell cell2 = new Cell() { CellReference = "B1", StyleIndex = (UInt32Value)2U };
            Cell cell3 = new Cell() { CellReference = "C1", StyleIndex = (UInt32Value)2U };
            rowRequest.Append(cell1);
            rowRequest.Append(cell2);
            rowRequest.Append(cell3);

            Row rowSupplier = new Row() 
            {
                RowIndex = (UInt32Value)2U, 
                Spans = new ListValue<StringValue>() 
                {
                    InnerText = "1:3" 
                },
                DyDescent = 0.25D 
            };
            Cell cell4 = new Cell() 
            {
                CellReference = "A2",
                StyleIndex = (UInt32Value)4U,
                DataType = CellValues.String
            };
            CellValue cellValue2 = new CellValue
            {
                Text = "Поставщик: " + info.SupplierName
            };
            cell4.Append(cellValue2);
            Cell cell5 = new Cell() { CellReference = "B2", StyleIndex = (UInt32Value)4U };
            Cell cell6 = new Cell() { CellReference = "C2", StyleIndex = (UInt32Value)4U };
            rowSupplier.Append(cell4);
            rowSupplier.Append(cell5);
            rowSupplier.Append(cell6);

            Row rowDate = new Row() 
            { 
                RowIndex = (UInt32Value)3U, 
                Spans = new ListValue<StringValue>() 
                { 
                    InnerText = "1:3" 
                },
                DyDescent = 0.25D 
            };
            Cell cell7 = new Cell() 
            { 
                CellReference = "A3", 
                StyleIndex = (UInt32Value)4U,
                DataType = CellValues.String
            };
            CellValue cellValue3 = new CellValue
            {
                Text = "Дата исполнения: " + info.CompletionDate.ToShortDateString()
            };
            cell7.Append(cellValue3);
            Cell cell8 = new Cell() { CellReference = "B3", StyleIndex = (UInt32Value)4U };
            Cell cell9 = new Cell() { CellReference = "C3", StyleIndex = (UInt32Value)4U };
            rowDate.Append(cell7);
            rowDate.Append(cell8);
            rowDate.Append(cell9);

            Row rowHeaders = new Row()
            {
                RowIndex = (UInt32Value)4U,
                Spans = new ListValue<StringValue>()
                {
                    InnerText = "1:3"
                },
                DyDescent = 0.25D
            };

            Cell cellID = new Cell()
            {
                CellReference = "A4",
                StyleIndex = (UInt32Value)5U,
                DataType = CellValues.String
            };
            CellValue cellValueID = new CellValue()
            {
                Text = "ID"
            };
            cellID.Append(cellValueID);

            Cell cellName = new Cell()
            {
                CellReference = "B4",
                StyleIndex = (UInt32Value)5U,
                DataType = CellValues.String
            };
            CellValue cellValueName = new CellValue()
            {
                Text = "Название"
            };
            cellName.Append(cellValueName);

            Cell cellCount = new Cell()
            {
                CellReference = "C4",
                StyleIndex = (UInt32Value)5U,
                DataType = CellValues.String
            };
            CellValue cellValueCount = new CellValue()
            {
                Text = "Количество"
            };
            cellCount.Append(cellValueCount);

            rowHeaders.Append(cellID);
            rowHeaders.Append(cellName);
            rowHeaders.Append(cellCount);

            sheetData.Append(rowRequest);
            sheetData.Append(rowSupplier);
            sheetData.Append(rowDate);
            sheetData.Append(rowHeaders);

            uint rowIndex = 5;

            foreach (var requestComponent in info.RequestComponents)
            {
                Row row = new Row()
                {
                    RowIndex = rowIndex,
                    Spans = new ListValue<StringValue>()
                    {
                        InnerText = "1:3"
                    },
                    DyDescent = 0.25D
                };
                Cell firstCell = new Cell()
                {
                    CellReference = "A" + rowIndex.ToString(),
                    StyleIndex = (UInt32Value)5U,
                    DataType = CellValues.Number
                };
                CellValue firstCellValue = new CellValue()
                {
                    Text = requestComponent.Key.ToString()
                };
                firstCell.Append(firstCellValue);
                Cell secondCell = new Cell()
                {
                    CellReference = "B" + rowIndex.ToString(),
                    StyleIndex = (UInt32Value)6U,
                    DataType = CellValues.String
                };
                CellValue secondCellValue = new CellValue()
                {
                    Text = requestComponent.Value.Item1
                };
                secondCell.Append(secondCellValue);
                Cell thirdCell = new Cell()
                {
                    CellReference = "C" + rowIndex.ToString(),
                    StyleIndex = (UInt32Value)5U,
                    DataType = CellValues.Number
                };
                CellValue thirdCellValue = new CellValue()
                {
                    Text = requestComponent.Value.Item2.ToString()
                };
                thirdCell.Append(thirdCellValue);
                row.Append(firstCell);
                row.Append(secondCell);
                row.Append(thirdCell);
                sheetData.Append(row);
                rowIndex++;
            }

            MergeCells mergeCells = new MergeCells() { Count = (UInt32Value)3U };
            MergeCell mergeCell1 = new MergeCell() { Reference = "A1:C1" };
            MergeCell mergeCell2 = new MergeCell() { Reference = "A2:C2" };
            MergeCell mergeCell3 = new MergeCell() { Reference = "A3:C3" };

            mergeCells.Append(mergeCell1);
            mergeCells.Append(mergeCell2);
            mergeCells.Append(mergeCell3);
            PageMargins pageMargins = new PageMargins() 
            { 
                Left = 0.7D, 
                Right = 0.7D, 
                Top = 0.75D, 
                Bottom = 0.75D, 
                Header = 0.3D, 
                Footer = 0.3D 
            };

            worksheet.Append(sheetFormatProperties1);
            worksheet.Append(columns);
            worksheet.Append(sheetData);
            worksheet.Append(mergeCells);
            worksheet.Append(pageMargins);

            worksheetPart.Worksheet = worksheet;
        }
    }
}
