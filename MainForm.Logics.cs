using System.Windows.Forms;

namespace OurTiger.EITitorExtOfOurTiger
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// https://floern.com/;;/umlautproblem/
        /// Unicode-Format UTF-8: ä ö  ü ß
        /// but interpreted as ISO 8859-1:  Ã¤ Ã¶ Ã¼ ÃŸ
        /// </summary>
        private static string Correct(string source)
        {
            return source.
                Replace("ÃŸ", "ß").
                Replace("Ã„", "Ä").
                Replace("Ã¤", "ä").
                Replace("Ã–", "Ö").
                Replace("Ã¶", "ö").
                Replace("Ãœ", "Ü").
                Replace("Ã¼", "ü").
                Replace("Ã©", "é").
                Replace("Ã¡", "á").
                Replace("†", "").
                Replace("‡", "").
                Replace("Â", "");
        }
    }
}
