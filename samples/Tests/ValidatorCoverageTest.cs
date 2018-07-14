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
        //In case of multiple controller assemblies or multiple validator assemblies
        //just create N tests and specify one assembly pair in each or them

        [DataTestMethod]
        [FluentValidationDataSource(
            typeof(AController), //Assembly that contain Controllers
            typeof(AValidator), //Assembly that contain Validators

            //ignored types
            typeof(decimal),
            typeof(DateTime),
            typeof(Guid))
        ]
        public void EverythingIsCovered(FluentValidationTestContext ctx)
        {
            FluentValidationTestRunner.Check(ctx);
        }
    }
}
