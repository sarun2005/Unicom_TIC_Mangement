using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.Controller;
using Unicom_TIC.Model;

namespace Unicom_TIC.Views.StaffView
{
    public partial class Staff_Marks : UserControl
    {
        private readonly MarksController _controller = new MarksController();

        public Staff_Marks()
        {
            InitializeComponent();
        }

        private void Staff_Marks_Load(object sender, EventArgs e)
        {
            LoadMarks();
        }

        public void LoadMarks()
        {
            var data = _controller.ViewMarks(Role.Staff);
            StaffMarksView.AutoGenerateColumns = true;
            StaffMarksView.DataSource = data;

        }
    }
}
