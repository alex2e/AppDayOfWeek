using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayOfWeek
{
    public partial class Form1 : Form
    {
        #region Variables, references and constructor
        String result;
        const String ERROR ="Los datos introducidos son incorrectos";
        int age;
        String dayText;
        enum dayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            EnableBtnMethod();
        }
        
        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
            EnableBtnMethod();
        }

        private void btnCalculateClasses_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbxAge.Text.ToString(), out age))
            {
                if (!string.IsNullOrEmpty(dayText) && age >= 0)
                {
                    if (age <= 18 && !dayText.Equals(dayOfWeek.Saturday.ToString()) && !dayText.Equals(dayOfWeek.Sunday.ToString()))
                    {
                        result = string.Format("{0} you have lessons today", tbxName.Text);
                    }
                    else
                    {
                        result = string.Format("{0} you have NOT lessons today", tbxName.Text);
                    }
                }
                else
                {
                    result = string.Format("{0} your information is incorrect");
                }
            }
            else
            {
                result = string.Format("{0} your age is incorrect", tbxName.Text);
            }

            lblSolution.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbnMonday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnTuesday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnWednesday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnThursday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnFriday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnSaturday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender, e);
        }

        private void rbnSunday_CheckedChanged(object sender, EventArgs e)
        {
            ChooseDay(sender,e);
        }

        //Own Event
        private void ChooseDay(object sender, EventArgs e)
        {
            String dayNumber = ((RadioButton)sender).Text;

            switch (dayNumber)
            {
                case "1":
                    dayText = dayOfWeek.Monday.ToString();
                    break;
                case "2":
                    dayText = dayOfWeek.Tuesday.ToString();
                    break;
                case "3":
                    dayText = dayOfWeek.Wednesday.ToString();
                    break;
                case "4":
                    dayText = dayOfWeek.Thursday.ToString();
                    break;
                case "5":
                    dayText = dayOfWeek.Friday.ToString();
                    break;
                case "6":
                    dayText = dayOfWeek.Saturday.ToString();
                    break;
                case "7":
                    dayText = dayOfWeek.Sunday.ToString();
                    break;
            }

        }
        #endregion

        #region Aux Methods
        /// <summary>
        /// Disable calculate button if any field is empty
        /// </summary>
        private void EnableBtnMethod()
        {
            if (string.IsNullOrEmpty(this.tbxName.Text) || string.IsNullOrEmpty(this.tbxAge.Text))
            {
                btnCalculateClasses.Enabled = false;
            }
            else
            {
                btnCalculateClasses.Enabled = true;
            }
        }  
        #endregion

       
    }

}
