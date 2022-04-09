namespace AbstractFactoryPattern;

public interface IDocumentFactory<in TInput, out TDocument> where TDocument : IDocument
{
    Type DocumentType => typeof(TDocument);
    TDocument CreateDocument(TInput data);
}