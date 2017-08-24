using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace TestCalcWPFnWF
{
    public class OM
    {
        string but1  = "butOne";
        string but2 = "butTwo";
        string but3 = "butThree";
        string but4 = "butFour";
        string but5 = "butFive";
        string but6 = "butSix";
        string but7 = "butSeven";
        string but8 = "butEight";
        string but9 = "butNine";
        string but0 = "butZero";
        string butPlus = "butPlus";
        string butMinus = "butMinus";
        string butMult = "butMult";
        string butDiv = "butDiv";
        string butEqual = "butCalculate";
        string txtResult = "txtResult";

        Window window;
        public OM(Window window)
        {
            this.window = window;
        }

        public Button GetButton(string s)
        {
            Button flag = null;
            if(s == nameof(but1))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but1));
            else if(s == nameof(but2))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but2));
            else if (s == nameof(but3))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but3));
            else if (s == nameof(but4))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but4));
            else if (s == nameof(but5))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but5));
            else if (s == nameof(but6))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but6));
            else if (s == nameof(but7))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but7));
            else if (s == nameof(but8))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but8));
            else if (s == nameof(but9))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but9));
            else if (s == nameof(but0))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(but0));
            else if (s == nameof(butMinus))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(butMinus));
            else if (s == nameof(butPlus))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(butPlus));
            else if (s == nameof(butDiv))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(butDiv));
            else if (s == nameof(butEqual))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(butEqual));
            else if (s == nameof(butMult))
                flag = window.Get<Button>(SearchCriteria.ByAutomationId(butMult));         
            return flag;
        }

        public TextBox GetTextBox(string s)
        {
            TextBox flag = null;
            if (s == nameof(txtResult))
                flag = window.Get<TextBox>(SearchCriteria.ByAutomationId(txtResult));   
            return flag;
        }
    }
}

