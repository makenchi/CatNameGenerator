using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using chocolicia.src.utils;
using chocolicia.src.models.errors;
using System.IO;

namespace chocolicia.tests
{
    [TestFixture]
    public class PromptTests
    {
        Prompt _prompt;      

        [SetUp]
        public void SetUp()
        {
            _prompt = new Prompt();
        }

        [Test]
        public void TestShowOnConsole()
        {
            //throw new NotImplementedException("You must implement a task.");
           
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                
                _prompt.ask("ola mundo?");

                string consoleOutput = stringWriter.ToString();

                NUnit.Framework.Assert.IsTrue(consoleOutput == "ola mundo?\r\n", "Deu ruim");
            }
        }

        [Test]
        public void TestSexCat()
        {
            NUnit.Framework.Assert.Throws<SexCatExceptions>(() =>
            {
                _prompt.askSexCat("5");
            });            
        }
    }
}
