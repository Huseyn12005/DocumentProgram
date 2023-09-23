namespace DocumentProgram
{
    internal class Document_Program
    {

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }

    internal class ProDocumentProgram : Document_Program
    {

        new public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        sealed override public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }

    internal class ExpertDocument : ProDocumentProgram
    {

        new public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
