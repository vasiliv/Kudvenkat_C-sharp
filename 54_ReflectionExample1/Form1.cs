using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; // Reflection library

namespace _54_ReflectionExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedType = txtBoxSearch.Text;
            Type T = Type.GetType(searchedType);

            lstBoxMethods.Items.Clear();
            MethodInfo[] methodInfos = new MethodInfo[] { };
            foreach (var methodInfo in methodInfos)
            {
                lstBoxMethods.Items.Add (methodInfo.ReturnType.Name + " " + methodInfo.Name);
            }

        }
    }
}
