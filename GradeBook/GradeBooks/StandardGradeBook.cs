using System;
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) 
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}