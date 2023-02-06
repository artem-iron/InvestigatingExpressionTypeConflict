using Common.Utilities;
using MMS.Contracts;
using System.Linq.Expressions;

namespace DataAccess
{
    public class TheDataAccess
    {
        public TheUtility TheUtility { get; set; }
        public TheContract TheContract { get; set; }

        public ExpressionType ExpressionFromTheContract { get; set; }
        public ExpressionType ExpressionFromTheUtility { get; set; }
        public ExpressionType OwnExpressionType { get; set; }

        public TheDataAccess()
        {
            TheUtility = new TheUtility();
            TheContract = TheUtility.TheContract;

            ExpressionFromTheContract = TheContract.OwnExpressionType;
            ExpressionFromTheUtility = TheUtility.OwnExpressionType;
            OwnExpressionType = ExpressionType.UnaryPlus;
        }
    }
}
