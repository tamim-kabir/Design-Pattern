using Builder;

PDFReport pdfReport = new PDFReport();
ReportDirector reportDirector = new ReportDirector();
Report report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();

ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();
Console.WriteLine("Hello, World!");
