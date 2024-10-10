using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPatterns.Порождающие.Singleton
{
    public sealed class MyForm: Form
    {
        private static MyForm _instance;
        private MyForm() { }

        public static MyForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MyForm();
                _instance.Width = 200;
                _instance.Height = 200;
                _instance.Show();
            }

            return _instance;
        }

        public void SetWidth(int width)
        {
            _instance.Width = width;    

            
        }
    }
}
