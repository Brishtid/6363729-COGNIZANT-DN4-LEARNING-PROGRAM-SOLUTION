// IDocument.cs
public interface IDocument
{
    void Open();
}
// WordDocument.cs
public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a Word document.");
    }
}

// PdfDocument.cs
public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a PDF document.");
    }
}

// ExcelDocument.cs
public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening an Excel document.");
    }
}
