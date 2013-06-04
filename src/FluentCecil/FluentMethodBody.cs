using System;
using System.Linq.Expressions;
using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace FluentCecil
{
    public partial class FluentMethodBody
    {
        private readonly ModuleDefinition module;
        private readonly ILProcessor ilProcessor;
        private readonly Action<Instruction> addInstruction;

        public FluentMethodBody(ModuleDefinition module, ILProcessor ilProcessor, Action<Instruction> addInstruction)
        {
            this.module = module;
            this.ilProcessor = ilProcessor;
            this.addInstruction = addInstruction;
        }

        public FluentMethodBody Call(Expression<Action> action)
        {
            var visitor = new ILVisitor(this);
            visitor.Evaluate(action.Body);

            return this;
        }

        public FluentMethodBody Call(MethodInfo method)
        {
            var methodReference = module.Import(method);
            return Call(methodReference);
        }
    }
}