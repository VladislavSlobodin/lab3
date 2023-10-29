using System.Windows.Forms;

namespace lab3_2
{
    public static class ErrorBox
    {
        public static void Show(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
