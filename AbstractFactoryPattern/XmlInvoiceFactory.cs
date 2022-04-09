namespace AbstractFactoryPattern;

public class XmlInvoiceFactory : IInvoiceFactory<XmlDocument>
{
    private readonly string savingDirectory;

    public XmlInvoiceFactory(string savingDirectory)
    {
        this.savingDirectory = savingDirectory;
    }

    public XmlDocument CreateDocument(Invoice data)
    {
        return new XmlDocument() { Name = $"XmlDoc: {data.Id}", Data = System.Text.Encoding.UTF8.GetBytes("<xml document>")};
    }
}