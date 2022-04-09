namespace AbstractFactoryPattern;

public interface IDocument
{
    string Name { get; set; }
    byte[] Data { get; set; }
}