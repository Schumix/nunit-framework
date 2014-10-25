﻿// ***********************************************************************
// Copyright (c) 2011 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System.IO;
using NUnit.Framework.Interfaces;
using NUnit.TestData.TestContextData;
using NUnit.TestUtilities;

namespace NUnit.Framework.Tests
{
    [TestFixture]
    public class TestContextTests
    {
        [Test]
        public void TestCanAccessItsOwnName()
        {
            Assert.That(TestContext.CurrentContext.Test.Name, Is.EqualTo("TestCanAccessItsOwnName"));
        }
        
        [TestCase(5)]
        public void TestCaseCanAccessItsOwnName(int x)
        {
            Assert.That(TestContext.CurrentContext.Test.Name, Is.EqualTo("TestCaseCanAccessItsOwnName(5)"));
        }

        [Test]
        public void TestCanAccessItsOwnFullName()
        {
            Assert.That(TestContext.CurrentContext.Test.FullName,
                Is.EqualTo("NUnit.Framework.Tests.TestContextTests.TestCanAccessItsOwnFullName"));
        }

        [TestCase(42)]
        public void TestCaseCanAccessItsOwnFullName(int x)
        {
            Assert.That(TestContext.CurrentContext.Test.FullName,
                Is.EqualTo("NUnit.Framework.Tests.TestContextTests.TestCaseCanAccessItsOwnFullName(42)"));
        }

        [Test]
        public void TestCanAccessItsOwnMethodName()
        {
            Assert.That(TestContext.CurrentContext.Test.MethodName, Is.EqualTo("TestCanAccessItsOwnMethodName"));
        }
        
        [TestCase(5)]
        public void TestCaseCanAccessItsOwnMethodName(int x)
        {
            Assert.That(TestContext.CurrentContext.Test.MethodName, Is.EqualTo("TestCaseCanAccessItsOwnMethodName"));
        }

        [Test]
        public void TestCanAccessItsOwnId()
        {
            Assert.That(TestContext.CurrentContext.Test.ID, Is.GreaterThan(0));
        }

        [Test]
        [Property("Answer", 42)]
        public void TestCanAccessItsOwnProperties()
        {
            Assert.That(TestContext.CurrentContext.Test.Properties.Get("Answer"), Is.EqualTo(42));
        }

        [Test]
        public void TestCanAccessWorkDirectory()
        {
            string workDirectory = TestContext.CurrentContext.WorkDirectory;
            Assert.NotNull(workDirectory);
            // CF and SL tests may be running on the desktop
#if !NETCF && !SILVERLIGHT
            Assert.That(Directory.Exists(workDirectory), string.Format("Directory {0} does not exist", workDirectory));
#endif
        }

        [Test]
        public void TestCanAccessTestState_PassingTest()
        {
            TestStateRecordingFixture fixture = new TestStateRecordingFixture();
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.stateList, Is.EqualTo("Inconclusive=>Inconclusive=>Passed"));
        }

        [Test]
        public void TestCanAccessTestState_FailureInSetUp()
        {
            TestStateRecordingFixture fixture = new TestStateRecordingFixture();
            fixture.setUpFailure = true;
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.stateList, Is.EqualTo("Inconclusive=>=>Failed"));
        }

        [Test]
        public void TestCanAccessTestState_FailingTest()
        {
            TestStateRecordingFixture fixture = new TestStateRecordingFixture();
            fixture.testFailure = true;
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.stateList, Is.EqualTo("Inconclusive=>Inconclusive=>Failed"));
        }

        [Test]
        public void TestCanAccessTestState_IgnoredInSetUp()
        {
            TestStateRecordingFixture fixture = new TestStateRecordingFixture();
            fixture.setUpIgnore = true;
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.stateList, Is.EqualTo("Inconclusive=>=>Skipped:Ignored"));
        }

        private const string SOME_TEXT = "Should go to the result";
        private static readonly string NL = NUnit.Env.NewLine;

        [Test]
        public void TestContextOut_WritesToResult()
        {
            TestContext.Out.WriteLine(SOME_TEXT);
            Assert.That(Internal.TestExecutionContext.CurrentContext.CurrentResult.Output, Is.EqualTo(SOME_TEXT + NL));
        }

        [Test]
        public void TestContextWrite_WritesToResult()
        {
            TestContext.Write(SOME_TEXT);
            Assert.That(Internal.TestExecutionContext.CurrentContext.CurrentResult.Output, Is.EqualTo(SOME_TEXT));
        }

        [Test]
        public void TestContextWriteLine_WritesToResult()
        {
            TestContext.WriteLine(SOME_TEXT);
            Assert.That(Internal.TestExecutionContext.CurrentContext.CurrentResult.Output, Is.EqualTo(SOME_TEXT + NL));
        }

        [Test]
        public void TestContextStoresFailureInfoForTearDown()
        {
            var fixture = new TestTestContextInTearDown();
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.FailCount, Is.EqualTo(1));
            Assert.That(fixture.Message, Is.EqualTo("Deliberate failure"));
            Assert.That(fixture.StackTrace, Does.Contain("NUnit.TestData.TestContextData.TestTestContextInTearDown.FailingTest"));
        }

        [Test]
        public void TestContextStoresFailureInfoForOneTimeTearDown()
        {
            var fixture = new TestTestContextInOneTimeTearDown();
            TestBuilder.RunTestFixture(fixture);
            Assert.That(fixture.PassCount, Is.EqualTo(2));
            Assert.That(fixture.FailCount, Is.EqualTo(1));
            Assert.That(fixture.SkipCount, Is.EqualTo(3));
            Assert.That(fixture.InconclusiveCount, Is.EqualTo(4));
            Assert.That(fixture.Message, Is.EqualTo("One or more child tests had errors"));
            Assert.That(fixture.StackTrace, Is.Null);
        }
    }

    [TestFixture]
    public class TestContextTearDownTests
    {
        private const int THE_MEANING_OF_LIFE = 42;

        [Test]
        public void TestTheMeaningOfLife()
        {
            Assert.That(THE_MEANING_OF_LIFE, Is.EqualTo(42));
        }

        [TearDown]
        public void TearDown()
        {
            TestContext context = TestContext.CurrentContext;
            Assert.That(context, Is.Not.Null);
            Assert.That(context.Test, Is.Not.Null);
            Assert.That(context.Test.Name, Is.EqualTo("TestTheMeaningOfLife"));
            Assert.That(context.Result, Is.Not.Null);
            Assert.That(context.Result.Outcome, Is.EqualTo(ResultState.Success));
            Assert.That(context.Result.PassCount, Is.EqualTo(1));
            Assert.That(context.Result.FailCount, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class TestContextOneTimeTearDownTests
    {
        [Test]
        public void TestTruth()
        {
            Assert.That(true, Is.True);
        }

        [Test]
        public void TestFalsehood()
        {
            Assert.That(false, Is.False);
        }

        [Test, Explicit]
        public void TestExplicit()
        {
            Assert.Pass("Always passes if you run it!");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext context = TestContext.CurrentContext;
            Assert.That(context, Is.Not.Null);
            Assert.That(context.Test, Is.Not.Null);
            Assert.That(context.Test.Name, Is.EqualTo("TestContextOneTimeTearDownTests"));
            Assert.That(context.Result, Is.Not.Null);
            Assert.That(context.Result.Outcome, Is.EqualTo(ResultState.Success));
            Assert.That(context.Result.PassCount, Is.EqualTo(2));
            Assert.That(context.Result.FailCount, Is.EqualTo(0));
            // TODO: Should we be counting Explicit?
            Assert.That(context.Result.SkipCount, Is.EqualTo(0));
        }
    }
}
