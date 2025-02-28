﻿namespace FakeTests.Tests
{
    [TestFixture]
    public class ComplexObjectTest : TestBase
    {
        private class SampleComplexObject
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        [Test]
        public void Should_Generate_Complex_Object()
        {
            SampleComplexObject result = EntityGenerator.CreateFake<SampleComplexObject>();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<SampleComplexObject>());
        }

        [Test]
        public void ComplexObject_Test1()
        {
            var response = (ComplexObject?)EntityGeneratorOrig.CreateFake(typeof(ComplexObject));

            Assert.That(response?.ItemsSuccessfullyPopulated(), Is.True);
        }

        [Test]
        public void ComplexObject_Test2()
        {
            var response = EntityGeneratorOrig.CreateFake<ComplexObject>();

            Assert.That(response.ItemsSuccessfullyPopulated(), Is.True);
        }
    }
}
