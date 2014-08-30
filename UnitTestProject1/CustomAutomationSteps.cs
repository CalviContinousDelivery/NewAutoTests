using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Telerik.WebAii.Controls.Html;

namespace CustomLibraryAutomation
{
    [Binding]
    public class CustomAutomationSteps
    {
        TestManager obj = new TestManager();
        private RadButton _radButton;
        private static HtmlInputText _text;
        private static RadTextBox _txtbox;

        [BeforeScenario]
        public static void ClearTextBoxes()
        {
            TestManager obj = new TestManager();
            _txtbox = obj.GetTextBox("txtNumber1_wrapper");
            _txtbox.Clear();
            _txtbox = obj.GetTextBox("txtNumber2_wrapper");
            _txtbox.Clear();
            _txtbox = obj.GetTextBox("txtResult_wrapper");
            _txtbox.Clear();
        }

        [Given(@"Enter (.*) and (.*)")]
        public void GivenEnterAnd(int p0, int p1)
        {
            _txtbox = obj.GetTextBox("txtNumber1_wrapper");
            _txtbox.TypeText(p0.ToString());

            _txtbox = obj.GetTextBox("txtNumber2_wrapper");
            _txtbox.TypeText(p1.ToString());

        }

        [When(@"Click on Add button")]
        public void WhenClickOnAddButton()
        {
            obj.ClickButton("id=btnAdd_input");
        }
        [When(@"Click on Subtract button")]
        public void WhenClickOnSubtractButton()
        {
            obj.ClickButton("id=btnSubtract_input");
        }

        [When(@"Click on Multiply button")]
        public void WhenClickOnMultiplyButton()
        {
            obj.ClickButton("id=btnMultiply_input");
        }

        [Then(@"Verfiy that result is (.*)")]
        public void ThenVerfiyThatResultIs(int p0)
        {
            _txtbox = obj.GetTextBox("txtResult_wrapper");
            NUnit.Framework.Assert.AreEqual(Convert.ToInt32(_txtbox.TextBoxValue), p0);
        }
    }
}
