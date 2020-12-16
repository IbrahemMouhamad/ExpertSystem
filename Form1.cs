using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipsNET;

namespace ESLab1
{
    public partial class Form1 : Form
    {
        ClipsEngine ce = new ClipsEngine();
        private Deftemplate computer_problem;
        Fact f;
        private delegate void UserFunction(IntPtr p);
        private string name = null;
        private int value = 0;
        private double cf = 1.0;
        private string solution = "";
        double[] CF = new double[8];
        private int state = 1;
        public Form1()
        {
            InitializeComponent();
            ce.DefineFunction(new UserFunction(Finish1));
            ce.DefineFunction(new UserFunction(Finish2));
            ce.DefineFunction(new UserFunction(Finish3));
            ce.DefineFunction(new UserFunction(Finish4));
            ce.DefineFunction(new UserFunction(Finish5));
            ce.DefineFunction(new UserFunction(Finish6));
            ce.DefineFunction(new UserFunction(Finish7));
            ce.DefineFunction(new UserFunction(Finish8));
            ce.DefineFunction(new UserFunction(Finish9));
            ce.DefineFunction(new UserFunction(Finish10));
            ce.DefineFunction(new UserFunction(Finish11));
            ce.DefineFunction(new UserFunction(Finish12));
            ce.DefineFunction(new UserFunction(Finish13));
            ce.DefineFunction(new UserFunction(Finish14));
            ce.DefineFunction(new UserFunction(Finish15));
            ce.DefineFunction(new UserFunction(Finish16));
            ce.DefineFunction(new UserFunction(Finish17));
            ce.DefineFunction(new UserFunction(Finish18));
            ce.DefineFunction(new UserFunction(Finish19));
            ce.DefineFunction(new UserFunction(Finish20));
            ce.DefineFunction(new UserFunction(Finish21));
            ce.DefineFunction(new UserFunction(Finish22));
            ce.DefineFunction(new UserFunction(Finish23));
            ce.DefineFunction(new UserFunction(Finish24));
            ce.DefineFunction(new UserFunction(Finish25));
            ce.DefineFunction(new UserFunction(Finish26));
            ce.DefineFunction(new UserFunction(Finish27));
            ce.Load(@"rules.clp");
            computer_problem = ce.Deftemplates["computer_problem"];
            f = new Fact(computer_problem);
            comboBox1.Items.Add("Definitely");
            comboBox1.SelectedIndex = 0;
            comboBox1.Items.Add("Almost certainly");
            comboBox1.Items.Add("Probably");
            comboBox1.Items.Add("Maybe");
            comboBox1.Items.Add("Maybe not");
            comboBox1.Items.Add("Probably not");
            comboBox1.Items.Add("Almost certainly not");
            comboBox1.Items.Add("Definitely not");
            richTextBox1.Visible = false;
            button2.Visible = false;
            CF[0] = 1.0;
            CF[1] = 0.8;
            CF[2] = 0.6;
            CF[3] = 0.4;
            CF[4] = 0.4;
            CF[5] = 0.6;
            CF[6] = 0.8;
            CF[7] = 1.0;
        }
        private string getAccurcy(double cf)
        {
            if (cf >= 0.8)
            {
                return "Definitely ";
            }
            else if (cf >= 0.6)
            {
                return "Almost certainly ";
            }
            else if (cf >= 0.4)
            {
                return "Probably ";
            }
            else
            {
                return "Maybe ";
            }
        }
        private void Finish1(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.75;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("computer failed to do POWER ON SELF TEST", "Rule1", cf);
                solution = "If you recentlay added a new component remove it else,remove components one by one and test your computer after every one.";
            }
            else
            {
                showResult("Unable to solve the problem because cf <= 0.2", "", -1.0);
            }
        }
        private void Finish2(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.65;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the disk in the CD-ROM prevent computer to start working", "Rule2", cf);
                solution = "you have to eject the cd from CD-ROM.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish3(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.65;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the driver which is used to start the system does not contain requierd files", "Rule3", cf);
                solution = "you have to repair the system by system-CD.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish4(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.95;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule4", cf);
                solution = "Need to develop the system by adding more experience.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish5(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.80;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the mouse not working", "Rule5", cf);
                solution = "you have to replace the mouse.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish6(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.90;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("The cabel of mouse not connected", "Rule6", cf);
                solution = "you have to connect the mouse cabel.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish7(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.70;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the keyboard not working", "Rule7", cf);
                solution = "you have to replace the keyboard.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish8(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.88;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("The cabel of keyboard not connected", "Rule8", cf);
                solution = "you have to connect the keyboard cabel>";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", " ", -1.0);
            }
        }
        private void Finish9(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.78;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("The Printer is out of ink", "Rule9", cf);
                solution = "you should fill the printer with ink.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish10(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.70;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("The header of printing not clear", "Rule10", cf);
                solution = "clean the printer with cleaning program then print a test paper.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish11(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.75;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule11", cf);
                solution = "بحاجة لتطوير النظام بإضافة خبرة أكبر."; ;
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish12(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.85;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem in sound card,it is not defined.", "Rule12", cf);
                solution = "you have to install the driver software.";

            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish13(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.95;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("Mute all is selected, the sound won't appear", "Rule13", cf);
                solution = "open sound setting and remove the selection>";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish14(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.65;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("Speakers are not connected, must be connected to hear the sound", "Rule14", cf);
                solution = "Connect the speakers to hear the sound.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish15(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.85;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("Speakers do not make sound clear.", "Rule15", cf);
                solution = "you have to replace the speakers>";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish16(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.95;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule16", cf);
                solution = "بحاجة لتطوير النظام بإضافة خبرة أكبر.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish17(IntPtr p)
        {

            double factor = 1.0;
            double ruleFactor = 0.85;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("It is a graphic card problem", "Rule17", cf);
                solution = "You have to replace the graphic card.";
            }
            else
            {
                showResult("Unable to solve the problem because cf<= 0.2", "", -1.0);
            }
        }
        private void Finish18(IntPtr p)
        {

            double factor = 1.0;
            double ruleFactor = 0.65;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem in the cabel of the screen or the screen its self.", "Rule18", cf);
                solution = "You have to change the cabel and if the problem is not solved then change the screen.";
            }
            else
            {
                showResult("Unable to solve the problem because cf<= 0.2", "", -1.0);
            }
        }
        private void Finish19(IntPtr p)
        {

            double factor = 1.0;
            double ruleFactor = 0.76;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem in the graphic card.", "Rule19", cf);
                solution = "You should replace the graphic card.";
            }
            else
            {
                showResult("Unable to solve the problem because cf<= 0.2", "", -1.0);
            }
        }
        private void Finish20(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.95;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule20", cf);
                solution = "بحاجة لتطوير النظام بإضافة خبرة أكبر.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish21(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.95;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem with a magnatic field.", "Rule21", cf);
                solution = "You should replace the location of the secreen.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish22(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.80;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the phone line is not connected to the right port.", "Rule22", cf);
                solution = "You should connect phone line with correct port.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish23(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.79;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem with the modem setting.", "Rule23", cf);
                solution = "You should check the modem setting and correct them.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish24(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.74;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("you are dialing the wrong number.", "Rule24", cf);
                solution = "You should enter the right number to solve the problem.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish25(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.84;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule25", cf);
                solution = "بحاجة لتطوير النظام بإضافة خبرة أكبر.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish26(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.70;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("the problem in the dialing setting.", "Rule26", cf);
                solution = "You should enter the right right dialing setting to solve the problem.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        private void Finish27(IntPtr p)
        {
            double factor = 1.0;
            double ruleFactor = 0.9;
            string factorString = null;
            for (int i = 0; i < ce.FactList.Count; i++)
            {
                factorString = ce.FactList[i].ToString().Split(' ').Last();
                double min = 1.0;
                if (factorString.ToString().Length == 6)
                    min = double.Parse(factorString.Substring(0, 4));
                else
                    min = double.Parse(factorString.Substring(0, 3));
                if (min < factor)
                    factor = min;
            }
            double cf = factor * ruleFactor;
            if (cf > 0.2)
            {
                showResult("unable to find the problem,there is no more option", "Rule27", cf);
                solution = "بحاجة لتطوير النظام بإضافة خبرة أكبر.";
            }
            else
            {
                showResult("Unable to solve the problem because > 0.2", "", -1.0);
            }
        }
        void assert()
        {
            f = new Fact(computer_problem);
            f["name"] = name;
            f["value"] = value;
            f["cf"] = cf;
            ce.Assert(f);
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.DarkGreen;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.GreenYellow;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "computerworking";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Is it a mouse problem";
                }
                else
                {
                    state = 100;
                    name = "computerworking";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?You hear sound like Beeps";
                }
            }
            else if (state == 2)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "mouseproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?is the cable of the mouse connected";
                }
                else
                {
                    state = 5;
                    label1.Text = "?Is it a keyboard problem";
                }
            }
            else if (state == 3)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "mcabel";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "mcabel";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 5)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "keyboardproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?is the cable of the keyboard connected";
                }
                else
                {
                    state = 10;
                    label1.Text = "?Is it a printer problem";
                }
            }
            else if (state == 6)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "kcabel";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "kcabel";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 10)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "printerproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Is the printer print";
                }
                else
                {
                    state = 20;
                    label1.Text = "?Is it a sound problem";
                }
            }
            else if (state == 11)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "printerprint";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Is the printing clear";
                }
                else
                {
                    state = 0;
                    name = "printerprint";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 12)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "printclear";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "printclear";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 20)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 21;
                    name = "soundproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?does the sound appear";
                }
                else
                {
                    state = 30;
                    label1.Text = "?Is it a screen problem";
                }
            }
            else if (state == 21)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "soundappear";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?does the sound clear";
                }
                else
                {
                    state = 25;
                    name = "soundappear";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?does the speaker connected";
                }
            }
            else if (state == 22)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "soundclear";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "soundclear";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 25)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "speakerconnected";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Is the choice (mute all) selected";
                }
                else
                {
                    state = 0;
                    name = "speakerconnected";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 26)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "muteall";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "muteall";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 30)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "screenproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?does the screen work";
                }
                else
                {
                    state = 50;
                    label1.Text = "?Is it a modem problem";
                }
            }
            else if (state == 31)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "screenwork";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?can you put the colors in suitable way";
                }
                else
                {
                    state = 40;
                    name = "screenwork";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?does the lamp of the screen work";
                }
            }
            else if (state == 32)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "suitablecolor";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?are three basic colors appearing";
                }
                else
                {
                    state = 0;
                    name = "suitablecolor";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 33)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "basiccolor";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "basiccolor";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 40)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "lampwork";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 40;
                    name = "lampwork";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 50)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "modemproblem";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?do you hear the ring of dial up ";
                }
                else
                {
                    state = 0;
                    name = "modemproblem";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 51)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "ringup";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?check if the modem is dialing the wrong number";
                }
                else
                {
                    state = 60;
                    name = "ringup";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?is phone line connected to the right port";
                }
            }
            else if (state == 52)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "wrongnumber";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state++;
                    name = "wrongnumber";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?are the setting of dialing up correct";
                }
            }
            else if (state == 53)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "dialsetting";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "dialsetting";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 60)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "phoneline";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "phoneline";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 100)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "beepssound";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state++;
                    name = "beepssound";
                    value = 0;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Invalid System Disk Message Appear";
                }
            }
            else if (state == 101)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state++;
                    name = "isdmessage";
                    value = 1;
                    cf = CF[index];
                    assert();
                    label1.Text = "?Is there a disk in the CD-ROM";
                }
                else
                {
                    state = 0;
                    name = "isdmessage";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            else if (state == 102)
            {
                int index = comboBox1.SelectedIndex;
                if (index < 4)
                {
                    state = 0;
                    name = "cd-romdisk";
                    value = 1;
                    cf = CF[index];
                    assert();
                }
                else
                {
                    state = 0;
                    name = "cd-romdisk";
                    value = 0;
                    cf = CF[index];
                    assert();
                }
            }
            ce.Run();

        }
        private void showResult(string problem, string rule, double cf)
        {
            if (cf != -1.0)
            {
                label1.Text = getAccurcy(cf) + problem;
                label1.ForeColor = Color.BlueViolet;
                richTextBox1.Visible = true;
                string result = "\n Added Facts with its cf are:\n";
                for (int i = 0; i < ce.FactList.Count; i++)
                {
                    result = result + ce.FactList[i].ToString() + "\n";
                }
                result = result + "\n Fired Rule is: " + rule + "\n";
                richTextBox1.Text = result;
                button2.Visible = true;
                comboBox1.Visible = false;
                button1.Visible = false;
            }
            else
            {
                label1.Text = problem;
                label1.ForeColor = Color.Red;
                comboBox1.Visible = false;
                button1.Visible = false;
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(solution);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
