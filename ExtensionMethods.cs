using System.Linq;
using System.Windows.Forms;

namespace lab3_2
{
    public static class ExtensionMethods
    {
        public static void Hide<T>(this Panel panel) where T : Control
        {
            foreach (Control control in panel.Controls)
            {
                if (control is T t)
                {
                    t.Hide();
                }
            }
        }

        public static void ClearTextBoxes(this Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                {
                    c.ClearTextBoxes();
                }

                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        public static object[] ToObjectArray(this object obj) => obj.GetType().GetProperties().Select(p => p.GetValue(obj)).ToArray();
    }
}
