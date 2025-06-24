class Program
{
    static void Main()
    {
        Console.WriteLine("Factory Method Pattern : ");
      

        
        DocumentFactory wordFactory = new WordDocumentFactory();
        Console.WriteLine($"Factory: {wordFactory.GetType().Name}");  
        IDocument wordDoc = wordFactory.CreateDocument();
        Console.WriteLine($"Created: {wordDoc.GetType().Name}");
        wordDoc.Open();
        Console.WriteLine();

        
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Console.WriteLine($"Factory: {pdfFactory.GetType().Name}");   
        IDocument pdfDoc = pdfFactory.CreateDocument();
        Console.WriteLine($"Created: {pdfDoc.GetType().Name}");
        pdfDoc.Open();
        Console.WriteLine();

        
        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Console.WriteLine($"Factory: {excelFactory.GetType().Name}"); 
        IDocument excelDoc = excelFactory.CreateDocument();
        Console.WriteLine($"Created: {excelDoc.GetType().Name}");
        excelDoc.Open();
    }
}