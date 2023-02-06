using Common.Utilities;
using DataAccess;
using IronXL;
using MMS.Contracts;
using System.Linq.Expressions;

namespace MMS.Business
{
    public class TheBusiness
    {
        public TheContract TheContract { get; set; }
        public TheUtility TheUtility { get; set; }
        public TheDataAccess TheDataAccess { get; set; }

        public ExpressionType ExpressionTypeFromTheContract { get; set; }
        public ExpressionType ExpressionTypeFromTheUtility { get; set; }
        public ExpressionType ExpressionTypeFromTheDataAccess { get; set; }
        public ExpressionType OwnExpressionType { get; set; }

        public WorkBook WorkBookFromTheUtility { get; set; }
        public WorkBook OwnWorkBook { get; set; }

        public TheBusiness()
        {
            TheDataAccess = new TheDataAccess();
            TheUtility = TheDataAccess.TheUtility;
            TheContract = TheUtility.TheContract;

            ExpressionTypeFromTheContract = TheContract.OwnExpressionType;
            ExpressionTypeFromTheUtility = TheUtility.OwnExpressionType;
            ExpressionTypeFromTheDataAccess = TheDataAccess.OwnExpressionType;
            OwnExpressionType = ExpressionType.TypeEqual;

            WorkBookFromTheUtility = TheUtility.OwnWorkBook;
            OwnWorkBook = WorkBook.Create();
            OwnWorkBook.DefaultWorkSheet["A1"].Value = "Ass from TheBusiness";
        }
    }
}
