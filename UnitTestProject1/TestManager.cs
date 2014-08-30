using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telerik.WebAii.Controls.Html;

namespace CustomLibraryAutomation
{
    public class TestManager:BaseTest
    {
        private static Browser _browser;
        private RadTextBox _radtext;
        public void NavigateUrl()
        {
            Manager.LaunchNewBrowser(BrowserType.InternetExplorer);
            ActiveBrowser.NavigateTo(@"http://localhost/MathsWebsite/MathsPage.aspx");
            ActiveBrowser.WaitUntilReady();
            _browser = ActiveBrowser;
        }

        public TestManager()
        {
            Initialize(false, Console.Out.WriteLine);
        }

        public RadTextBox GetTextBox(string id)
        {
            //_browser.Find.ById(id+"_wrapper").ChildNodes[0].Attributes[2].Value = text;
            //_radtext = _browser.Find.ByAttributes<RadTextBox>(id);
            //return _browser.Find.ByAttributes<HtmlInputText>(id);
            return _browser.Find.ById<RadTextBox>(id);
        }

        public void SetText1(string id, string text)
        {
            _browser.Find.ById(id).ChildNodes[0].Attributes[2].Value = text;
        }
        

        public void ClickButton(string id)
        {
            RadButton obj = _browser.Find.ByAttributes<RadButton>(id);
                          
            obj.MouseClick(MouseClickType.LeftClick);
            
            _browser.WaitForAjax(10000);
            _browser.WaitUntilReady();
            //Thread.Sleep(5000);
        }
        
    }
}
