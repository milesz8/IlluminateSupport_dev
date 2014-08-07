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
using System.Xml;
using System.Xml.Linq;
using System.IO;
                    
namespace IlluminateSupport_dev
{           
    public partial class PointViewerForm : Form
    {
        PointInfoGetter InfoGetter = new PointInfoGetter();
        
        public PointViewerForm()
        {   
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = PointIDTB.Text;
            Form2 pointViewForm = new Form2(search);
            pointViewForm.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           IdListBox.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
           IdListBox.DoubleClick += new EventHandler(IdListBox_DoubleClick);
           PrintPointList(InfoGetter.GetPointList());
        }

        private void pointGroupBox_Enter(object sender, EventArgs e)
        {
             
        }

        private void descriptionGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void IdListBox_DoubleClick(object sender, EventArgs e)
        {
            if (IdListBox.SelectedItem != null)
            {
                PointIDTB.Text = IdListBox.SelectedItem.ToString();
                string search = PointIDTB.Text;
                Form2 pointViewForm = new Form2(search);
                pointViewForm.Show();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdListBox.SelectedItem != null)
            {
                PointIDTB.Text = IdListBox.SelectedItem.ToString();
            }
        }

        public void PrintPointList(List<PointSummary> pointSumL)
        {
            IdListBox.Items.Clear();
            foreach (PointSummary p in pointSumL)
            {
                IdListBox.Items.Add(p.pointNumber + ": " + p.summary + Environment.NewLine + Environment.NewLine);
            }
            IdListBox.Show();
        }

        private void ViewListButton_Click(object sender, EventArgs e)
        {
            
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter filterWindow = new filter(this);
            filterWindow.Show();
        }

        public void showResetButton()
        {
            resetFiltersButton.Visible = true;
        }
      

        private void closePointSelectorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void resetFiltersButton_Click(object sender, EventArgs e)
        {
            resetFiltersButton.Visible = false;
            PrintPointList(InfoGetter.GetPointList());
        }

        private void exsportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML files (*.xml)|*.xml";
            saveFile.ShowDialog();
            using (Stream stream = saveFile.OpenFile())
            {
                XDocument Doc = exsportInfo();

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(Doc.ToString());
                }
            }
            MessageBox.Show("finished");    
            
            
            
        }

        public XDocument exsportInfo()
        {
            List<PointInfo> PointInfoList = getExsportInfo(InfoGetter.getCurrentList());

            List<XElement> points = new List<XElement>();
            for (int i = 0; i < PointInfoList.Count(); i++)
            {
                
     
                List<XElement> NotesList = new List<XElement>();
                for (int j = 0; j < PointInfoList[i].notes.Count();j++ )
                {
                    XElement note = new XElement("note",PointInfoList[i].notes[j].noteDescription);
                    note.Add(new XAttribute("dateNoteMade",PointInfoList[i].notes[j].dateNoteMade));
                    note.Add(new XAttribute("IDnumber",PointInfoList[i].notes[j].IDNumber));
                    note.Add(new XAttribute("notedBy",PointInfoList[i].notes[j].notedBy));
                    note.Add(new XAttribute("noteID",PointInfoList[i].notes[j].noteID));
                    NotesList.Add(note);
                }
                XElement Notes = new XElement("notes", NotesList);
                XElement point = new XElement("point", Notes);
                point.Add(new XAttribute("pointDescription",PointInfoList[i].pointDescription));
                point.Add(new XAttribute("pointID", PointInfoList[i].pointNumber));
                point.Add(new XAttribute("priority",PointInfoList[i].priority));
                point.Add(new XAttribute("solution",PointInfoList[i].solution));
                point.Add(new XAttribute("state",PointInfoList[i].state));
                point.Add(new XAttribute("type",PointInfoList[i].type));
                point.Add(new XAttribute("lastUpdatedDate",PointInfoList[i].updatedDate));
                point.Add(new XAttribute("createdDate",PointInfoList[i].createdDate));
                points.Add(point);
            }
            XDocument document = new XDocument(new XElement("points", points));
            return document;
        }
        private List<PointInfo> getExsportInfo(List<PointSummary> pSummary)
        {
            List<PointInfo> PointInfoList = new List<PointInfo>();
            foreach (PointSummary p in pSummary)
            {
                PointInfoList.Add(InfoGetter.GetPointInfo(p.pointNumber, p.pointNumber.Substring(0, 3)));
            }
            return PointInfoList;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}