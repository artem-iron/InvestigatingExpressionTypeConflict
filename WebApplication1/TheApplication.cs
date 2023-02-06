using Common.Utilities;
using DataAccess;
using IronXL;
using MMS.Business;
using MMS.Contracts;
using System.Linq.Expressions;

namespace WebApplication1
{
    public class TheApplication
    {
        public TheContract TheContract { get; set; }
        public TheUtility TheUtility { get; set; }
        public TheDataAccess TheDataAccess { get; set; }
        public TheBusiness TheBusiness { get; set; }

        public ExpressionType ExpressionTypeFromTheContract { get; set; }
        public ExpressionType ExpressionTypeFromTheUtility { get; set; }
        public ExpressionType ExpressionTypeFromTheDataAccess { get; set; }
        public ExpressionType ExpressionTypeFromTheBusiness { get; set; }
        public ExpressionType OwnExpressionType { get; set; }

        public WorkBook WorkBookFromTheUtility { get; set; }
        public WorkBook WorkBookFromTheBusiness { get; set; }
        public WorkBook OwnWorkBook { get; set; }

        public TheApplication()
        {
            TheBusiness = new TheBusiness();
            TheDataAccess = TheBusiness.TheDataAccess;
            TheUtility = TheDataAccess.TheUtility;
            TheContract = TheUtility.TheContract;

            ExpressionTypeFromTheContract = TheContract.OwnExpressionType;
            ExpressionTypeFromTheUtility = TheUtility.OwnExpressionType;
            ExpressionTypeFromTheDataAccess = TheDataAccess.OwnExpressionType;
            ExpressionTypeFromTheBusiness = TheBusiness.OwnExpressionType;
            OwnExpressionType = ExpressionType.TypeAs;

            WorkBookFromTheBusiness = TheBusiness.OwnWorkBook;
            WorkBookFromTheUtility = TheUtility.OwnWorkBook;
            OwnWorkBook = WorkBook.Create();
            OwnWorkBook.DefaultWorkSheet["A1"].Value = "WorbookValue from TheApplication";
        }
    }
}