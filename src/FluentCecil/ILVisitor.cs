using System;
using System.Linq.Expressions;

namespace FluentCecil
{
    public class ILVisitor : ExpressionVisitor
    {
        private readonly FluentMethodBody body;

        public ILVisitor(FluentMethodBody body)
        {
            this.body = body;
        }

        public void Evaluate(Expression node)
        {
            Visit(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var next = base.VisitMethodCall(node);

            body.Call(node.Method);

            return next;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            var next = base.VisitConstant(node);

            if (node.Type == typeof(string))
                body.Ldstr((string)node.Value);

            return next;
        }
    }
}