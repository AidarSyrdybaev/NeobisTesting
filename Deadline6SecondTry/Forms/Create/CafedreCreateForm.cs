using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline6SecondTry.Forms.Create
{
    public partial class CafedreCreateForm : Form
    {
        private JsonDatabaseContext _jsonDatabaseContext;

        public CafedreCreateForm(JsonDatabaseContext jsonDatabaseContext)
        {
            _jsonDatabaseContext = jsonDatabaseContext;
            InitializeComponent();
        }

        private void CafedreCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void CafedreCreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
