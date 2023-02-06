using IronXL;
using MMS.Contracts;
using System.Linq.Expressions;

namespace Common.Utilities
{
    public class TheUtility
    {
        public TheContract TheContract { get; set; }

        public WorkBook OwnWorkBook { get; set; }

        public ExpressionType ExpressionTypeFromTheConract { get; set; }
        public ExpressionType OwnExpressionType { get; set; }

        public TheUtility()
        {
            TheContract = new TheContract();

            ExpressionTypeFromTheConract = TheContract.OwnExpressionType;
            OwnExpressionType = ExpressionType.TypeIs;

            OwnWorkBook = WorkBook.Create();
            OwnWorkBook.DefaultWorkSheet["A1"].Value = "Ass from TheUtility";
        }
    }
}
