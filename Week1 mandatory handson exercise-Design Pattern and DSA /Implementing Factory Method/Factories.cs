// DocumentFactory.cs
public abstract class DocumentFactory
{
 public abstract IDocument CreateDocument();
    public void DisplayFactoryType()
    {
        Console.WriteLine($"Factory: {this.GetType().Name}");
    }
}
// WordDocumentFactory.cs
public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

// PdfDocumentFactory.cs
public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

// ExcelDocumentFactory.cs
public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}
