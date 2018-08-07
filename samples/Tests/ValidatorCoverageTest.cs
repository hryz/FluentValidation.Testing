using System;
using System.Threading;
using Api.Controllers;
using Api.Validators;
using FluentValidation.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ValidatorCoverageTest
    {
        [DataTestMethod]
        [FluentValidationDataSource(
            controllerAssembly: new[]
            {
                typeof(AController), //controllers (N assemblies)
            },
            validatorAssembly: new[]
            {
                typeof(AValidator), //validators (N assemblies)
            },
            ignoreTypes: new[]
            {
                typeof(string),
                typeof(decimal),
                typeof(DateTime),
                typeof(Guid),
            })]
        public void EverythingIsCovered(FluentValidationTestContext ctx)
        {
            FluentValidationTestRunner.Check(ctx);
        }
    }
}
