using System;
namespace HelloWorld
{
    class Program
    {
        [Flags]
        public enum Knowledges
        {
            // Для читаемости разряды можно разделять знаком подчёркивания.
            // Они никак не влияют на значение.
            Database = 0b_000001,
            Algorithms = 0b_000010,
            CSharp = 0b_000100,
            JavaScript = 0b_001000,
            Git = 0b_010000,
            Design = 0b_100000,
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // Маски профессий
            Knowledges backendRequirements = Knowledges.Database | Knowledges.Algorithms | Knowledges.CSharp | Knowledges.Git;
            Knowledges frontendRequirements = Knowledges.Algorithms | Knowledges.JavaScript | Knowledges.Git;
            Knowledges designRequirements = Knowledges.Git | Knowledges.Design;

            //Знания студента в числовой записи
            Knowledges allKnowledges = (Knowledges)0b011111;

            // Те навыки из каждой профессии, которые присутствуют у студента:
            Knowledges backenderKnowledges = allKnowledges & backendRequirements;
            Knowledges frontenderKnowledges = allKnowledges & frontendRequirements;
            Knowledges designerKnowledges = allKnowledges & designRequirements;

            bool isBackender = backenderKnowledges == backendRequirements;
            bool isFrontender = frontenderKnowledges == frontendRequirements;
            bool isDesigner = designerKnowledges == designRequirements;

            Console.WriteLine($"Знания студента: {allKnowledges}");

            if (isBackender)
            {
                Console.WriteLine("Студент может стать backend-разработчиком");
            }

            if (isFrontender)
            {
                Console.WriteLine("Студент может стать frontend-разработчиком");
            }

            if (isDesigner)
            {
                Console.WriteLine("Студент может стать дизайнером");
            }
        }
    }
}
