using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiaLink.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace DiaLink.Controllers.Tests
{
    [TestClass()]
    public class FamilyDoctorControllerTests
    {
        [TestMethod()]
        public void FamilyDoctorTest_GetPatientData_Success()
        {
            //Arrange
            FamilyDoctorController family = new FamilyDoctorController();
            //Act
            IActionResult result = family.FamilyDoctor();
            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}