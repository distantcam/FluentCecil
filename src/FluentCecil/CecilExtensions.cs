using System;
using Mono.Cecil;

namespace FluentCecil
{
    public static class CecilExtensions
    {
        public static FluentMethodBody AddMethod(this TypeDefinition typeDefinition, string name, MethodAttributes methodAttributes, Type returnType)
        {
            var module = typeDefinition.Module;
            var returnReference = module.Import(returnType);

            var method = new MethodDefinition(name, methodAttributes, returnReference);
            typeDefinition.Methods.Add(method);

            var ilProcessor = method.Body.GetILProcessor();

            return new FluentMethodBody(module, ilProcessor, method.Body.Instructions.Add);
        }
    }
}