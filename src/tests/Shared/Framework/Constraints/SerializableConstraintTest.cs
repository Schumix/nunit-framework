// ***********************************************************************
// Copyright (c) 2007 Charlie Poole
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

using System;
using System.Collections;
#if CLR_2_0
using System.Collections.Generic;
#endif

namespace NUnit.Framework.Constraints.Tests
{
    [TestFixture]
    public class BinarySerializableTest : ConstraintTestBaseWithArgumentException
    {
		[SetUp]
        public void SetUp()
        {
            theConstraint = new BinarySerializableConstraint();
            expectedDescription = "binary serializable";
            stringRepresentation = "<binaryserializable>";
        }

        object[] SuccessData = new object[] { 1, "a", new ArrayList(), new InternalWithSerializableAttributeClass() };
        
        object[] FailureData = new object[] { new InternalClass() };

        string[] ActualValues = new string[] { "<InternalClass>" }; 

        object[] InvalidData = new object[] { null };
    }

    [TestFixture]
    public class XmlSerializableTest : ConstraintTestBaseWithArgumentException
    {
        [SetUp]
        public void SetUp()
        {
            theConstraint = new XmlSerializableConstraint();
            expectedDescription = "xml serializable";
            stringRepresentation = "<xmlserializable>";
        }

        object[] SuccessData = new object[] { 1, "a", new ArrayList() };

#if CLR_2_0
		object[] FailureData = new object[] { new Dictionary<string, string>(), new InternalClass(), new InternalWithSerializableAttributeClass() };
        string[] ActualValues = new string[] { "<Dictionary`2>", "<InternalClass>", "<InternalWithSerializableAttributeClass>" };
#else
		object[] FailureData = new object[] { new InternalClass(), new InternalWithSerializableAttributeClass() };
		string[] ActualValues = new string[] { "<InternalClass>", "<InternalWithSerializableAttributeClass>" };
#endif


        object[] InvalidData = new object[] { null };
    }

    internal class InternalClass
    {}

    [Serializable]
    internal class InternalWithSerializableAttributeClass
    {}
}