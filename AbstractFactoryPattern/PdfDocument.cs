namespace AbstractFactoryPattern;

public class PdfDocument : IDocument
{
    public string Name { get; set; }
    public byte[] Data { get; set; }
}