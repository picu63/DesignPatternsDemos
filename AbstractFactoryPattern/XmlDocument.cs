namespace AbstractFactoryPattern;

public class XmlDocument : IDocument
{
    public string Name { get; set; }
    public byte[] Data { get; set; }
}