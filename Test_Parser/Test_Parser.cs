using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using personInfo;

namespace personInfo
{
    [TestClass]
    public class Test_Parser
    {
        [TestMethod]
        public void theParserShouldReturnTwoSources()
        {
            var p = new Parser();

            var d = p.ParserConfig(@"[{""field"":""name"",""source"":""google"",""sourceField"":""FullName""},{""field"":""hightestQualification"",""source"":""linkedIn"",""sourceField"":""MaxQual""}]");

            Assert.AreEqual(d.Sources.Count,2);
        }


        [TestMethod]
        public void theParserShouldReturnSourceWithOneField()
        {
            var p = new Parser();

            var d = p.ParserConfig(@"[{""field"":""name"",""source"":""google"",""sourceField"":""FullName""}]");

            Assert.AreEqual(d.Sources[0].Fields.Count, 1);
        }
    }
}
