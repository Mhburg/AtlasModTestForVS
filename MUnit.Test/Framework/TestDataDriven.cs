﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnit.Test.Framework
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestDataDriven
    {
        [TestMethod]
        public void TestDataMethod()
        {
            AssemblyPrep.RunSingleTest(typeof(MockDataDrivenClass), "DataDrivenTest");
        }
    }
}
