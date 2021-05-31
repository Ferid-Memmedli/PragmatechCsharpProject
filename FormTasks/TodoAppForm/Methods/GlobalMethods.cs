using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoAppForm.Methods
{
    public static class GlobalMethods
    {
        /// <summary>
        /// Hal Hazirki Tarixi Gorsetmeq
        /// </summary>
        /// <param name="dataTime"></param>
        /// <param name="dateTime_Tick"></param>
        public static void GetDateTime(Timer dataTime, EventHandler dateTime_Tick)
        {
            dataTime.Interval = 1;
            dataTime.Tick += dateTime_Tick;
            dataTime.Start();
        }
        /// <summary>
        /// Buttonlari Gorsetmek ve ya Gizli Etmeq
        /// </summary>
        /// <param name="control"></param>
        /// <param name="trueOrFalse"></param>
        public static void OperationBtnEnabled(Control control,bool trueOrFalse)
        {
            foreach (var item in control.Controls)
            {
                if (item is Button btn)
                    btn.Enabled = trueOrFalse;
            }
        }
        /// <summary>
        /// TextBox ve CheckBox-lari Sifirlama
        /// </summary>
        /// <param name="control"></param>
        public static void Clear(Control control)
        {
            foreach (var item in control.Controls)
            {
                if (item is TextBox textBox)
                    textBox.Text = string.Empty;
                if (item is CheckBox checkBox)
                    checkBox.Checked = false;                                
            }
        }
        public static bool TextBoxIsNullOrEmpty(Control control)
        {
            bool result = false;
            foreach (var item in control.Controls)
            {
                if (item is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        result =  true;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
