﻿using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            // Arrange
            ShopComputerModel shopModel = new ShopComputerModel();

            // Act
            shopModel.Start();
            Thread.Sleep(25000);
            shopModel.Stop();

            // Assert

        }
    }
}