using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        string trans_grade = null;
        decimal total_ave;


        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
        }

        private void G1to10Button_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value;

            if (quizzesTab1TextBox.Text == string.Empty || monthlyTestTab1TextBox.Text == string.Empty || assignmentTab1TextBox.Text == string.Empty || recitationTab1TextBox.Text == string.Empty
                   || projectTab1TextBox.Text == string.Empty || themesTab1TextBox.Text == string.Empty || groupActivityTab1TextBox.Text == string.Empty || periodicalTestTab1TextBox.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all fields are filled.");
            }
            if (int.TryParse(quizzesTab1TextBox.Text, out value) && int.TryParse(monthlyTestTab1TextBox.Text, out value) && int.TryParse(assignmentTab1TextBox.Text, out value)
                 && int.TryParse(recitationTab1TextBox.Text, out value) && int.TryParse(projectTab1TextBox.Text, out value) && int.TryParse(themesTab1TextBox.Text, out value)
                 && int.TryParse(groupActivityTab1TextBox.Text, out value) && int.TryParse(periodicalTestTab1TextBox.Text, out value))
            {
                decimal quizzes = decimal.Parse(quizzesTab1TextBox.Text);
                decimal monthlyTest = decimal.Parse(monthlyTestTab1TextBox.Text);
                decimal assignment = decimal.Parse(assignmentTab1TextBox.Text);
                decimal recitation = decimal.Parse(recitationTab1TextBox.Text);
                decimal project = decimal.Parse(projectTab1TextBox.Text);
                decimal themes = decimal.Parse(themesTab1TextBox.Text);
                decimal groupActivity = decimal.Parse(groupActivityTab1TextBox.Text);
                decimal periodicaTest = decimal.Parse(periodicalTestTab1TextBox.Text);
                decimal thirtyPercent = 0.3M;
                decimal fiftyPercent = 0.5M;
                decimal twentyPercent = 0.2M;


               
                if (60M > quizzes || quizzes > 100M || 60M > monthlyTest || monthlyTest > 100M || 60M > assignment || assignment > 100M || 60M > recitation || recitation > 100M || 60M > project || project > 100M || 60M > themes || themes > 100M || 60M > groupActivity || groupActivity > 100M || 60M > periodicaTest || periodicaTest > 100M)
                {
                    MessageBox.Show("Please make sure all values are not less than 60 and greater than 100.");
                }
                else
                {
                    decimal ww_total_ave = (((quizzes + monthlyTest + assignment) / 3) * thirtyPercent);
                    decimal pt_total_ave = (((recitation + project + themes + groupActivity) / 4) * fiftyPercent);
                    decimal qa_total_ave = periodicaTest * twentyPercent;

                    total_ave = ww_total_ave + pt_total_ave + qa_total_ave;

                    transmuteGrade();

                    //MessageBox.Show(total_ave);

                    initialGradeTab1Label.Text = total_ave.ToString("N3");
                    transmutedGradeTab1Label.Text = trans_grade;

                }
               
            }
            else
            {
                MessageBox.Show("Please make sure all values are numbers.");
            }
        }

        private void g1to10Tab1_Click(object sender, EventArgs e)
        {
            tab1Panel.Visible = true;
            tab2Panel.Visible = false;
            tab3Panel.Visible = false;
        }

        private void g1to10Tab2_Click(object sender, EventArgs e)
        {
            tab1Panel.Visible = false;
            tab2Panel.Visible = true;
            tab3Panel.Visible = false;
        }

        private void g1to10Tab3_Click(object sender, EventArgs e)
        {
            tab1Panel.Visible = false;
            tab2Panel.Visible = false;
            tab3Panel.Visible = true;
        }

        private void submitTab2Button_Click(object sender, EventArgs e)
        {

            int value;

            if (quizzesTab2TextBox.Text == string.Empty || monthlyTestTab2TextBox.Text == string.Empty || assignmentTab2TextBox.Text == string.Empty || recitationTab2TextBox.Text == string.Empty
                   || projectTab2TextBox.Text == string.Empty || groupActivityTab2TextBox.Text == string.Empty || periodicalTestTab2TextBox.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all fields are filled.");
            }
            if (int.TryParse(quizzesTab2TextBox.Text, out value) && int.TryParse(monthlyTestTab2TextBox.Text, out value) && int.TryParse(assignmentTab2TextBox.Text, out value)
                 && int.TryParse(recitationTab2TextBox.Text, out value) && int.TryParse(projectTab2TextBox.Text, out value)
                 && int.TryParse(groupActivityTab2TextBox.Text, out value) && int.TryParse(periodicalTestTab2TextBox.Text, out value))
            {
                decimal quizzes = decimal.Parse(quizzesTab2TextBox.Text);
                decimal monthlyTest = decimal.Parse(monthlyTestTab2TextBox.Text);
                decimal assignment = decimal.Parse(assignmentTab2TextBox.Text);
                decimal recitation = decimal.Parse(recitationTab2TextBox.Text);
                decimal project = decimal.Parse(projectTab2TextBox.Text);
                decimal groupActivity = decimal.Parse(groupActivityTab2TextBox.Text);
                decimal periodicaTest = decimal.Parse(periodicalTestTab2TextBox.Text);
                decimal thirtyPercent = 0.3M;
                decimal fiftyPercent = 0.5M;
                decimal twentyPercent = 0.2M;

                if (60M > quizzes || quizzes > 100M || 60M > monthlyTest || monthlyTest > 100M || 60M > assignment || assignment > 100M || 60M > recitation || recitation > 100M || 60M > project || project > 100M || 60M > groupActivity || groupActivity > 100M || 60M > periodicaTest || periodicaTest > 100M)
                {
                    MessageBox.Show("Please make sure all values are not less than 60 and greater than 100.");
                }
                else
                {

                    decimal ww_total_ave = (((quizzes + monthlyTest + assignment) / 3) * thirtyPercent);
                    decimal pt_total_ave = (((recitation + project + groupActivity) / 3) * fiftyPercent);
                    decimal qa_total_ave = periodicaTest * twentyPercent;

                    total_ave = ww_total_ave + pt_total_ave + qa_total_ave;
                    transmuteGrade();


                    initialGradeTab2Label.Text = total_ave.ToString("N3");
                    transmutedGradeTab2Label.Text = trans_grade;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all values are numbers.");
            }
        }

        private void submitTab3Button_Click(object sender, EventArgs e)
        {
            int value;

            if (quizzesTab3TextBox.Text == string.Empty || monthlyTestTab3TextBox.Text == string.Empty || assignmentTab3TextBox.Text == string.Empty || recitationTab3TextBox.Text == string.Empty
                   || projectTab3TextBox.Text == string.Empty || groupActivityTab3TextBox.Text == string.Empty || periodicalTestTab3TextBox.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all fields are filled.");
            }
            if (int.TryParse(quizzesTab3TextBox.Text, out value) && int.TryParse(monthlyTestTab3TextBox.Text, out value) && int.TryParse(assignmentTab3TextBox.Text, out value)
                 && int.TryParse(recitationTab3TextBox.Text, out value) && int.TryParse(projectTab3TextBox.Text, out value)
                 && int.TryParse(groupActivityTab3TextBox.Text, out value) && int.TryParse(periodicalTestTab3TextBox.Text, out value))
            {

                decimal quizzes = decimal.Parse(quizzesTab3TextBox.Text);
                decimal monthlyTest = decimal.Parse(monthlyTestTab3TextBox.Text);
                decimal assignment = decimal.Parse(assignmentTab3TextBox.Text);
                decimal recitation = decimal.Parse(recitationTab3TextBox.Text);
                decimal project = decimal.Parse(projectTab3TextBox.Text);
                decimal groupActivity = decimal.Parse(groupActivityTab3TextBox.Text);
                decimal periodicaTest = decimal.Parse(periodicalTestTab3TextBox.Text);
                decimal thirtyPercent = 0.3M;
                decimal fiftyPercent = 0.5M;
                decimal twentyPercent = 0.2M;

                if (60M > quizzes || quizzes > 100M || 60M > monthlyTest || monthlyTest > 100M || 60M > assignment || assignment > 100M || 60M > recitation || recitation > 100M || 60M > project || project > 100M || 60M > groupActivity || groupActivity > 100M || 60M > periodicaTest || periodicaTest > 100M)
                {
                    MessageBox.Show("Please make sure all values are not less than 60 and greater than 100.");
                }
                else
                {

                    decimal ww_total_ave = (((quizzes + monthlyTest + assignment) / 3) * thirtyPercent);
                    decimal pt_total_ave = (((recitation + project + groupActivity) / 3) * fiftyPercent);
                    decimal qa_total_ave = periodicaTest * twentyPercent;

                    total_ave = ww_total_ave + pt_total_ave + qa_total_ave;

                    transmuteGrade();


                    initialGradeTab3Label.Text = total_ave.ToString("N3");
                    transmutedGradeTab3Label.Text = trans_grade;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all values are numbers.");
            }
        }

        public void transmuteGrade()
        {
            if (total_ave == 100)
            {
                trans_grade = "100";
            }
            else if (98.40M <= total_ave && total_ave <= 99.99M)
            {
                trans_grade = "99";
            }
            else if (96.80M <= total_ave && total_ave <= 98.39M)
            {
                trans_grade = "98";
            }
            else if (95.20M <= total_ave && total_ave <= 96.79M)
            {
                trans_grade = "97";
            }
            else if (93.60M <= total_ave && total_ave <= 95.19M)
            {
                trans_grade = "96";
            }
            else if (92.00M <= total_ave && total_ave <= 93.59M)
            {
                trans_grade = "95";
            }
            else if (90.40M <= total_ave && total_ave <= 91.99M)
            {
                trans_grade = "94";
            }
            else if (88.80M <= total_ave && total_ave <= 90.39M)
            {
                trans_grade = "93";
            }
            else if (87.20M <= total_ave && total_ave <= 88.79M)
            {
                trans_grade = "92";
            }
            else if (85.60M <= total_ave && total_ave <= 87.19M)
            {
                trans_grade = "91";
            }
            else if (84.00M <= total_ave && total_ave <= 85.59M)
            {
                trans_grade = "90";
            }
            else if (82.40M <= total_ave && total_ave <= 83.99M)
            {
                trans_grade = "89";
            }
            else if (80.80M <= total_ave && total_ave <= 82.39M)
            {
                trans_grade = "88";
            }
            else if (79.20M <= total_ave && total_ave <= 80.79M)
            {
                trans_grade = "87";
            }
            else if (77.60M <= total_ave && total_ave <= 79.19M)
            {
                trans_grade = "86";
            }
            else if (76.00M <= total_ave && total_ave <= 77.59M)
            {
                trans_grade = "85";
            }
            else if (74.40M <= total_ave && total_ave <= 75.99M)
            {
                trans_grade = "84";
            }
            else if (72.80M <= total_ave && total_ave <= 74.39M)
            {
                trans_grade = "83";
            }
            else if (71.20M <= total_ave && total_ave <= 72.79M)
            {
                trans_grade = "82";
            }
            else if (69.60M <= total_ave && total_ave <= 71.19M)
            {
                trans_grade = "81";
            }
            else if (68.00M <= total_ave && total_ave <= 69.59M)
            {
                trans_grade = "80";
            }
            else if (66.40M <= total_ave && total_ave <= 67.99M)
            {
                trans_grade = "79";
            }
            else if (64.80M <= total_ave && total_ave <= 66.39M)
            {
                trans_grade = "78";
            }
            else if (63.20M <= total_ave && total_ave <= 64.79M)
            {
                trans_grade = "77";
            }
            else if (61.60M <= total_ave && total_ave <= 63.19M)
            {
                trans_grade = "76";
            }
            else if (60.00M <= total_ave && total_ave <= 61.59M)
            {
                trans_grade = "75";
            }
            else if (56.00M <= total_ave && total_ave <= 59.99M)
            {
                trans_grade = "74";
            }
            else if (52.00M <= total_ave && total_ave <= 55.99M)
            {
                trans_grade = "73";
            }
            else if (48.00M <= total_ave && total_ave <= 51.99M)
            {
                trans_grade = "72";
            }
            else if (44.00M <= total_ave && total_ave <= 47.99M)
            {
                trans_grade = "71";
            }
            else if (40.00M <= total_ave && total_ave <= 43.99M)
            {
                trans_grade = "70";
            }
            else if (36.00M <= total_ave && total_ave <= 39.99M)
            {
                trans_grade = "69";
            }
            else if (32.00M <= total_ave && total_ave <= 35.99M)
            {
                trans_grade = "68";
            }
            else if (28.00M <= total_ave && total_ave <= 31.99M)
            {
                trans_grade = "67";
            }
            else if (24.00M <= total_ave && total_ave <= 27.99M)
            {
                trans_grade = "66";
            }
            else if (20.00M <= total_ave && total_ave <= 23.99M)
            {
                trans_grade = "65";
            }
            else if (16.00M <= total_ave && total_ave <= 19.99M)
            {
                trans_grade = "64";
            }
            else if (12.00M <= total_ave && total_ave <= 15.99M)
            {
                trans_grade = "63";
            }
            else if (8.00M <= total_ave && total_ave <= 11.99M)
            {
                trans_grade = "62";
            }
            else if (4.00M <= total_ave && total_ave <= 7.99M)
            {
                trans_grade = "61";
            }
            else if (0.00M <= total_ave && total_ave <= 3.99M)
            {
                trans_grade = "60";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quizzesTab1TextBox.Text = String.Empty;
            monthlyTestTab1TextBox.Text = String.Empty;
            assignmentTab1TextBox.Text = String.Empty;
            recitationTab1TextBox.Text = String.Empty;
            projectTab1TextBox.Text = String.Empty;
            themesTab1TextBox.Text = String.Empty;
            groupActivityTab1TextBox.Text = String.Empty;
            periodicalTestTab1TextBox.Text = String.Empty;
            initialGradeTab1Label.Text = "000";
            transmutedGradeTab1Label.Text = "000";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            quizzesTab2TextBox.Text = String.Empty;
            monthlyTestTab2TextBox.Text = String.Empty;
            assignmentTab2TextBox.Text = String.Empty;
            recitationTab2TextBox.Text = String.Empty;
            projectTab2TextBox.Text = String.Empty;
            groupActivityTab2TextBox.Text = String.Empty;
            periodicalTestTab2TextBox.Text = String.Empty;
            initialGradeTab2Label.Text = "000";
            transmutedGradeTab2Label.Text = "000";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            quizzesTab3TextBox.Text = String.Empty;
            monthlyTestTab3TextBox.Text = String.Empty;
            assignmentTab3TextBox.Text = String.Empty;
            recitationTab3TextBox.Text = String.Empty;
            projectTab3TextBox.Text = String.Empty;
            groupActivityTab3TextBox.Text = String.Empty;
            periodicalTestTab3TextBox.Text = String.Empty;
            initialGradeTab3Label.Text = "000";
            transmutedGradeTab3Label.Text = "000";
        }

    }
}
