using System;
using System.IO;
using Mono.Cecil;
using Xunit;

namespace FluentCecil.Tests
{
    public class TestClass
    {
        [Fact]
        public void TestMethod()
        {
            var module = LoadModule();
            var type = module.GetType("FluentCecil.TestAssembly", "Class1");

            type.AddMethod("FluentMethod", MethodAttributes.Public | MethodAttributes.HideBySig, typeof(void))
                .Call(() => Console.WriteLine("Hello World"))
                .Ret();

            Assert.Equal(2, type.Methods.Count);

            module.Write("TestMethod.dll", new WriterParameters { WriteSymbols = true });
        }

        private ModuleDefinition LoadModule()
        {
            var assemblyPath = Path.GetFullPath(@"..\..\..\FluentCecil.TestAssembly\bin\Debug\FluentCecil.TestAssembly.dll");

            return ModuleDefinition.ReadModule(assemblyPath, new ReaderParameters { ReadSymbols = true });
        }
    }
}