using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentCecil
{
    public class ILVisitor : ExpressionVisitor
    {
        private readonly FluentMethodBody body;
        private readonly Stack<Action> results;

        public ILVisitor(FluentMethodBody body)
        {
            this.body = body;
            results = new Stack<Action>();
        }

        public void Evaluate(Expression node)
        {
            Visit(node);

            while (results.Count > 0)
            {
                results.Pop()();
            }
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            results.Push(() => body.Call(node.Method));

            return base.VisitMethodCall(node);
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type == typeof(string))
                results.Push(() => body.Ldstr((string)node.Value));

            return base.VisitConstant(node);
        }
    }
}