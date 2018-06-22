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

            var d = p.ParserConfig(json);

            Assert.AreEqual(d.Sources.Count,2);
        }


        [TestMethod]
        public void theParserShouldReturnGoogleSourceWithTwoFields()
        {
            var p = new Parser();

            var d = p.ParserConfig(json);

            var source = d.Sources["google"];

            Assert.AreEqual(source.Fields.Count, 2);
        }


        [TestMethod]
        public void theParserShouldReturnLinkedInSourceWithOneFields()
        {
            var p = new Parser();

            var d = p.ParserConfig(json);

            var source = d.Sources["linkedIn"];

            Assert.AreEqual(source.Fields.Count, 1);
        }


        [TestMethod]
        public void theParserShouldReturnSourceWithOneFieldFullName()
        {
            var p = new Parser();

            var data = p.ParserConfig(json);

            var source = data.Sources["google"];

            var field = source.Fields["FullName"];

            Assert.AreEqual(field.Name, "FullName");
        }

        const string json = @"[{""field"":""name"",""source"":""google"",""sourceField"":""FullName""},{""field"":""hightestQualification"",""source"":""linkedIn"",""sourceField"":""MaxQual""},{""field"":""age"",""source"":""google"",""sourceField"":""Age""}]";
    }
}
