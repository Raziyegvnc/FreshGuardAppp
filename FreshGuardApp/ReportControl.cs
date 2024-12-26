using FreshGuardApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshGuardApp
{
    public partial class ReportControl : UserControl
    {
        private int UID;
        public ReportControl(int a)
        {
            UID = a;
            InitializeComponent();
            LoadReports();
        }
        
        public void LoadReports()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            object recommendations = dbHelper.GetRecommendations(UID);
            dgvReport.DataSource = recommendations;

        }
    }
}
