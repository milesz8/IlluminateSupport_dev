using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IlluminateSupport_dev
{
    public partial class Form2 : Form
    {
        PointInfoGetter InfoGetter = new PointInfoGetter();
        public Form2(string PointID)
        {
            InitializeComponent();
            Print(InfoGetter.GetPointInfo(PointID, PointID.Substring(0, 3)));
        }

        private void Print(PointInfo s)
        {

                descriptionLabel.Text = (s.pointDescription == null || s.pointDescription == "") ? "empty" : s.pointDescription;
                numberTitleLabel.Text = (s.pointNumber == null || s.pointNumber == "") ? "Number: empty" : "Number: " + s.pointNumber;
                typeTitleLabel.Text = (s.type == null || s.type == "") ? "Type: empty" : "Type: " + s.type;
                createdOnTitleLabel.Text = (s.createdDate == null || s.createdDate == "") ? "Created on: empty" : "Created on: " + s.createdDate;
                lastUpdateTitleLabel.Text = (s.updatedDate == null || s.updatedDate == "") ? "Last updated: empty" : "Last updated: " + s.updatedDate;
                stateTitleLabel.Text = (s.state == null || s.state == "") ? "State: empty" : "State: " + s.state;
                solutionLabel.Text = (s.solution == null || s.solution == "") ? "empty" : s.solution;

                try
                {
                    SetPriorityColor(int.Parse(s.priorityID));
                }
                catch
                {
                    ResetAllColorBlack();
                }

                PrintNotes(s.notes);
            
        }

        private void SetPriorityColor(int priorityID)
        {
            lowPriorityLabel.ForeColor = priorityID == 1 ? Color.Green : Color.Black;
            mediumPriorityLabel.ForeColor = priorityID == 2 ? Color.Green : Color.Black;
            highPriorityLabel.ForeColor = priorityID == 4 ? Color.Green : Color.Black;
            urgentPriorityLabel.ForeColor = priorityID == 8 ? Color.Green : Color.Black;
        }

        private void ResetAllColorBlack()
        {
            lowPriorityLabel.ForeColor = Color.Black;
            mediumPriorityLabel.ForeColor = Color.Black;
            highPriorityLabel.ForeColor = Color.Black;
            urgentPriorityLabel.ForeColor = Color.Black;
        }

        private void PrintNotes(List<Note> noteList)
        {
            string toWrite = Environment.NewLine + "";
            foreach (Note n in noteList)
            {
                //notesTextBox.SelectionStart = 0;
                //notesTextBox.SelectionLength = n.notedBy.Length;

                //notesTextBox.SelectionFont = new Font(notesTextBox.Font, FontStyle.Bold);
                StringBuilder sb = new StringBuilder();
                toWrite = toWrite + n.notedBy + "            " + n.dateNoteMade + Environment.NewLine + Environment.NewLine + n.noteDescription + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
            if (toWrite == "")
            {
                notesTextBox.Text = "empty";
            }
            else
            {
                notesTextBox.Text = toWrite;
            }
        }

        private void closePointViewButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}