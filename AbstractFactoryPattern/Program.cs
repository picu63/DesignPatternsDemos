
using System.Text.Json;
using AbstractFactoryPattern;

var invoice = new Invoice(1, "Walmart", "Monthly subscription", 19.99);
Console.WriteLine($"Created invoice: {JsonSerializer.Serialize(invoice)}");
IInvoiceFactory<PdfDocument> pdfFactory = new PdfInvoiceFactory("pdfs\\.");
var pdfFile = pdfFactory.CreateDocument(invoice);
PrintDocument(pdfFile);
IInvoiceFactory<XmlDocument> xmlFactory = new XmlInvoiceFactory("xmls\\.");
var xmlFile = xmlFactory.CreateDocument(invoice);
PrintDocument(xmlFile);
static void PrintDocument(IDocument document)
{
    Console.WriteLine($"Document name: {document.Name}, data: {System.Text.Encoding.UTF8.GetString(document.Data)}");
}