using DevExpress.XtraEditors;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace iTools
{
    public class iProc
    {
        #region Image
        public static byte[] ImageCrypte(PictureBox img)
        {
            byte[] imgArray = null;
            if (!(img.Image == null))
            {
                MemoryStream stream = new MemoryStream();
                img.Image.Save(stream, ImageFormat.Jpeg);
                imgArray = stream.ToArray();
                stream.Close();
            }
            return imgArray;
        }
        #endregion Image
        #region Text
        public static void Clear(params GroupControl[] gcs)
        {
            foreach (var item in gcs)
            {
                foreach (var grpBox in item.Controls)
                {
                    TextEdit txt = grpBox as TextEdit;
                    if (!(txt == null))
                    {
                        txt.Text = string.Empty;
                    }
                }
            }
        }
        public static string UppercaseFirst(string s)
        {
            char[] array = s.ToCharArray();
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
                for (int i = 1; i < array.Length; i++)
                {
                    if (char.IsUpper(array[i]))
                    {
                        array[i] = char.ToLower(array[i]);
                    }
                }
            }
            return new string(array);
        }
        #endregion Text
        #region msgBox
        public static DialogResult msgBox(string msg)
        {
            return XtraMessageBox.Show(msg);
        }
        public static DialogResult msgBox(string msg, string title)
        {
            return XtraMessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
        public static DialogResult msgBox(string msg, string title, MessageBoxButtons button)
        {
            return XtraMessageBox.Show(msg, title, button);
        }
        public static DialogResult msgBox(string msg, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(msg, title, button, icon);
        }
        #endregion msgBox
    }
}