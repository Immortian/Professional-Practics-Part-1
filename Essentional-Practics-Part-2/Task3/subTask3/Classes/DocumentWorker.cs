using System;
namespace subTask3.Classes
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Фалй открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine($"Доступно начиная с версии Pro");
            Program.Upgrade();
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine($"Доступно начиная с версии Pro");
            Program.Upgrade();
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Изменения внесены");
        }
        public override void SaveDocument()
        {
            Console.WriteLine($"Сохранено в старом формате, сохранение в остальных форматах доступно начиная с версии Expert");
            Program.Upgrade();
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine($"Сохранено в новом формате");
        }
    }

}
