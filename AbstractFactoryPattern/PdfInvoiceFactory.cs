namespace AbstractFactoryPattern;

public class PdfInvoiceFactory : IInvoiceFactory<PdfDocument>
{
    private readonly string savingDirectory;

    public PdfInvoiceFactory(string savingDirectory)
    {
        this.savingDirectory = savingDirectory;
    }

    public PdfDocument CreateDocument(Invoice invoice)
    {
        return new PdfDocument() { Name = $"PdfDoc: {invoice.Id}", Data = System.Text.Encoding.UTF8.GetBytes("pdf document") };
    }
}