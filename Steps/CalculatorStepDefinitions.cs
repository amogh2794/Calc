using TechTalk.SpecFlow;
using System.Windows.Automation;
using System;
using TestStack.White;

namespace Calc.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public static Application app;
        public static AutomationElement calcUI;
        public void FindAndClickButton(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Button");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern btnPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            btnPattern.Invoke();
        }

        public void closebutton(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Button");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern btnPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            btnPattern.Invoke();
        }

        public void ClickHistory(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "ToolTip");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement ToolTip = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern HistPattern = ToolTip.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            HistPattern.Invoke();
        }

        public void SelectScientific(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "List Item");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern lstPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            lstPattern.Invoke();
        }

        public void SelectStandard(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "List Item");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern lstPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            lstPattern.Invoke();
        }

        public void SelectDate(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "List Item");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern lstPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            lstPattern.Invoke();
        }

        public void SelecttextHex(string AutomationId, string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Radio Button");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, AutomationId);
            Condition condition3 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2, condition3);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern rdPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            rdPattern.Invoke();
        }
        public void SelecttextOct(string AutomationId, string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Radio Button");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, AutomationId);
            Condition condition3 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2, condition3);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern rdPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            rdPattern.Invoke();
        }
        public void SelecttextDec(string AutomationId, string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Radio Button");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, AutomationId);
            Condition condition3 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2, condition3);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern rdPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            rdPattern.Invoke();
        }
        public void SelecttextBin(string AutomationId, string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "Radio Button");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, AutomationId);
            Condition condition3 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2, condition3);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern rdPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            rdPattern.Invoke();
        }

        public void ClickDatepicker(string AutomationId)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "CalenderDatePicker");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, AutomationId);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern DtPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            DtPattern.Invoke();
        }

        public void Dateselect(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "CalenderViewDayItem");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern cdPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            cdPattern.Invoke();
        }

        public void CaptureDifference(string Automationid, string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "TextBlock");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, Automationid);
            Condition condition3 = new PropertyCondition(AutomationElement.NameProperty, name);
            Condition condition = new AndCondition(condition1, condition2, condition3);
            AutomationElement button = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern diffPattern = button.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            diffPattern.Invoke();
        }

        public void CheckDisplay(string name)
        {
            Condition condition1 = new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty,name);
            Condition condition = new AndCondition(condition1,condition2);
            AutomationElement text = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern txtPattern = text.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            txtPattern.Invoke();
        }

        public void CheckListView()
        {
            Condition condition1 = new PropertyCondition(AutomationElement.AutomationIdProperty, "HistoryListView");
            Condition condition2 = new PropertyCondition(AutomationElement.ClassNameProperty, "ListView");
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement list = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern lstvPattern = list.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            lstvPattern.Invoke();
        }

        public void SelectListViewItem()
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "TextBlock");
            Condition condition2 = new PropertyCondition(AutomationElement.AutomationIdProperty, "HistoryItemExpression");
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement text = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern txtPattern = text.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            txtPattern.Invoke();
        }

        /*public void RetrieveMemory()
        {
            Condition condition1 = new PropertyCondition(AutomationElement.ClassNameProperty, "TextBlock");
            Condition condition2 = new PropertyCondition(AutomationElement.NameProperty, "Memory recall (Ctrl+R)");
            Condition condition = new AndCondition(condition1, condition2);
            AutomationElement text = calcUI.FindFirst(TreeScope.Descendants, condition);
            InvokePattern memoryPatternr = text.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            memoryPatternr.Invoke();
        }*/


        [Given(@"Calculator is launched")]
        public void GivenCalculatorIsLaunched()
        {
            app = Application.Launch("C:/Windows/System32/calc.exe");
        }

        /*[Given(@"calculator is reset")]
        public void GivenCalculatorIsReset()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Clear");
            }
            Console.WriteLine("Calculator is Reset successfully");
        }*/


        //Generic Method for Clicking on Menu button
        [Given(@"I click on menu")]
        public void GivenIClickOnScientificMode()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectScientific("Open Navigation");
                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine("Menu is pressed");
        }

        //Generic step for closing the calculator
        [Then(@"Close Application")]
        public void ThenCloseApplication()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition1 = new PropertyCondition(AutomationElement.NameProperty, "Close Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition1);
            if (calcUI != null)
            {
                closebutton("Close Calculator");
            }
            Console.WriteLine("Application Closed");

        }

        //TC 1 Step 2
        [Given(@"I select Programmer mode")]
        public void GivenISelectProgrammerMode()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectScientific("Programmer Calculator");
            }
            Console.WriteLine("Programmer mode Selected");
        }

        //TC1 Step 3 is Generic step
        //TC1 Step 4

        [Then(@"I verify the values displayed")]
        public void ThenIVerifyTheValuesDisplayed()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelecttextHex("hexButton", "HexaDecimal 5");
                SelecttextBin("binaryButton", "Binary 0 1 0 1");
                SelecttextOct("octolButton", "Octal 5");
                SelecttextDec("decimalButton", "Decimal 5");

            }
            Console.WriteLine("Hex value is correct");
            Console.WriteLine("Octal value is correct");
            Console.WriteLine("Binary value is correct");
            Console.WriteLine("Decimal value is correct");
        }

        //TC2 Start

        //TC 2 Step 1 is Generic
        //TC 2 Step 2
        [Given(@"I Select Scientific")]
        public void GivenISelectScientific()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectScientific("Scientific Calculator");

            }
            Console.WriteLine("Scientific Selected");
        }

        //TC 2 Step 3
        [Given(@"I click first no")]
        public void GivenIClickFirstNo()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Five");
            }
            Console.WriteLine("5 is pressed");
        }


        //TC 2 Step 4
        [Given(@"I click plus button")]
        public void GivenIClickPlusButton()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Plus");
            }
            Console.WriteLine("Plus is pressed");
        }

        //TC 2 Step 5
        [Given(@"I click second no")]
        public void GivenIClickSecondNo()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Five");
            }
            Console.WriteLine("5 is pressed");
        }

        //TC 2 Step 6
        [Given(@"I click equal button")]
        public void GivenIClickEqualButton()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Equals");
            }

            Console.WriteLine("Equal is pressed");

            //Condition conditionResult = new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults");
            //var result = calcUI.FindFirst(TreeScope.Descendants, conditionResult);

            //Console.WriteLine("The Sum is:"+ result.Current.Name);
        }

        //TC 3  Start
        //TC 3 Step 1 is generic
        //TC 3 Step 2
        [Given(@"I select Date mode")]
        public void GivenISelectDateMode()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectScientific("Date Calculation Calculator");
            }
            Console.WriteLine("Date mode Selected");
        }

        //TC3 Step 3
        [Given(@"I select from date")]
        public void GivenISelectFromDate()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                ClickDatepicker("DateDiff_FromDate");
                Dateselect("26");
            }
            Console.WriteLine("From Date opened");
            Console.WriteLine("26 is selected");
        }

        //TC 3  Step 4
        [Then(@"Date Difference is displayed")]
        public void ThenDateDifferenceIsDisplayed()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                CaptureDifference("DateDiffAllUnitsResultLabel", "Difference 1 week, 3 days");

            }
            Console.WriteLine("Date Difference is captured Successfully");
        }

        //TC 4 Start
        // TC 4 Step 1 is Generic

        //TC 4 Step 2
        [Given(@"I select Standard mode")]
        public void GivenISelectStandardMode()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectStandard("Standard Calculator");

            }
            Console.WriteLine("Standard mode Selected");
        }


        //Step 3, 4, 5, 6 is generic
        // TC 4 Step 7

        [Then(@"Validate displayed result")]
        public void ThenValidateDisplayedResult()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                CheckDisplay("Display is 10");
            }
            Console.WriteLine("Displayed Result is Correct");
        }

        //TC 4 Step 8

        [Then(@"I click on Cancel")]
        public void ThenIClickOnCancel()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Clear");
            }
            Console.WriteLine("Clear is pressed");
        }

        //TC 4 Step 8

        [Then(@"I click on History")]
        public void ThenIClickOnHistory()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                ClickHistory("History (Ctrl+H)");
            }
            Console.WriteLine("History is pressed");
        }

        //TC 4 Step 9

        /*[Then(@"I select First Item")]
        public void ThenISelectFirstItem()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                SelectListViewItem();
            }
            Console.WriteLine("List Item Selected");
        }*/

        // TC4 Step 10
        [Then(@"I Click on Memory")]
        public void ThenIClickOnMemory()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Memory Add");
            }
            Console.WriteLine("M+ is pressed");
        }
        // TC 4 Step 11
        [Then(@"I Click on Memory Retrieve")]
        public void ThenIClickOnMemoryRetrieve()
        {
            AutomationElement root = AutomationElement.RootElement;
            Condition condition = new PropertyCondition(AutomationElement.NameProperty, "Calculator");

            calcUI = root.FindFirst(TreeScope.Children, condition);
            if (calcUI != null)
            {
                FindAndClickButton("Memory Recall");
            }
            Console.WriteLine("MR is pressed");            
        }



    }
}
