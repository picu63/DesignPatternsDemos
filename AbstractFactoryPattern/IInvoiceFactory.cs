namespace AbstractFactoryPattern;

public interface IInvoiceFactory<out T> : IDocumentFactory<Invoice, T> where T : IDocument
{ }