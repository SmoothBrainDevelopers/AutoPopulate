﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTests.Tests
{
    internal class DelegateCallbackTest : TestBase
    {
        [Test]
        public void DelegateTest()
        {
            var callback = new DelegateCallback().Test;
            var orig = EntityGenerator.DefaultValues[typeof(string)];
            EntityGenerator.DefaultValues[typeof(string)] = callback;

            var response = EntityGenerator.CreateFake<DelegateCallback>();

            Assert.That(response.ItemsSuccessfullyPopulated(), Is.True);

            EntityGenerator.DefaultValues[typeof(string)] = orig;
        }
    }
}
