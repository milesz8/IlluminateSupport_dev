using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlluminateSupport_dev
{
    public partial class filter : Form
    {
        PointViewerForm form;

        public filter(PointViewerForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void closeFilterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFilterButton_Click(object sender, EventArgs e)
        {
            PointInfoGetter getInfo = new PointInfoGetter();
            int typeSum = TypeFilter();
            int stateSum = StateFilter();
            int prioritySum = PriorityFilter();
            var list = getInfo.GetFilteredList(typeSum, stateSum, prioritySum);
            form.PrintPointList(list);
            form.showResetButton();
            this.Close();
        }

        public int TypeFilter()
        {
            int typeSum = 0;

            if (bugCheckBox.Checked)// Return changed sqlCommand?
                typeSum += 1;
            if (enhancementCheckBox.Checked)
                typeSum += 2;
            if (usabilityCheckBox.Checked)
                typeSum += 4;
            if (environmentCheckBox.Checked)
                typeSum += 8;
            if (installationCheckBox.Checked)
                typeSum += 16;
            if (questionCheckBox.Checked)
                typeSum += 32;
            if (informationCheckBox.Checked)
                typeSum += 64;

            return typeSum;
        }

        public int StateFilter()
        {
            int stateSum = 0;

            if (newCheckBox.Checked)
                stateSum += 1;
            if (openCheckBox.Checked)
                stateSum += 2;
            if (closedCheckBox.Checked)
                stateSum += 4;
            if (pendingDeploymentCheckBox.Checked)
                stateSum += 8;
            if (pendingEngineeringCheckBox.Checked)
                stateSum += 16;

            return stateSum;
        }

        public int PriorityFilter()
        {
            int prioritySum = 0;

            if (lowCheckBox.Checked)
                prioritySum += 1;
            if (mediumCheckBox.Checked)
                prioritySum += 2;
            if (highCheckBox.Checked)
                prioritySum += 4;
            if (urgentCheckBox.Checked)
                prioritySum += 8;
            
            return prioritySum;
        }
    }
}
