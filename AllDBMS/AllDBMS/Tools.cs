using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllDBMS
{
    internal class Tools
    {
        public static void ClearData(Panel form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    c.Invoke((MethodInvoker)delegate { ((TextBox)c).Clear(); });
                }
            }
        }

        public static int GetNumberOnly(string strinput)
        {
            try
            {
                string stroutput = "";
                if (Regex.IsMatch(strinput, "^[a-zA-Z]+$") || Regex.IsMatch(strinput, "^[\u0621-\u064A0-9 ]+$") || Regex.IsMatch(strinput, "^\\s+$") || Regex.IsMatch(strinput, "^[a-zA-Z\u0621-\u064A0-9]+$"))
                {
                    stroutput = "0";
                }
                foreach (char c in strinput)
                {
                    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        stroutput += c;
                    }
                }
                if (strinput.Trim() == "") stroutput = "0";
                return Convert.ToInt32(stroutput);
            }
            catch(Exception ex)
            {
                ex = new Exception();
                return 0;
            }
        }

        /// <summary>
        /// هذه الداله تنشىء شاشه صغيره لادخال اسم المستخدم او الباسورد
        /// </summary>
        /// <param name="title"> هذا عنوان الشاشه</param>
        /// <param name="text"> اسم المستخدم</param>
        /// <param name="isPassword"> Append by True or False For Passwaord Char
        /// when set for true user input will appearear *** 
        /// </param>
        /// <returns></returns>
        public static string InputBox(string title, string text, bool isPassword = false)
        {
            Form frm = new Form();
            Label lblText = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.Text = title;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Font = new Font("Arial", 14, FontStyle.Bold);
           // frm.RightToLeft = RightToLeft.Yes;
           // frm.RightToLeftLayout = true;
            frm.BackColor = Color.White;
            frm.Size = new Size(400, 190);
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);

            lblText.Text = text;
            lblText.AutoSize = true;
            lblText.Location = new Point(10, 10);

            txt.Location = new Point(10, lblText.Height + 20);
            txt.Width = frm.Width - 40;
            if (isPassword) txt.PasswordChar = '*';

            btnOK.Text = "OK";
            btnOK.Location = new Point(10, 10 + lblText.Height + 20 + txt.Height + 20);
            btnOK.Width += 30;
            btnOK.Height += 10;
            btnOK.Cursor = Cursors.Hand;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Text = "Cancel";
            btnClose.Location = new Point(10 + btnOK.Width + 20, btnOK.Top);
            btnClose.Width = btnOK.Width;
            btnClose.Height = btnOK.Height;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.BackColor = btnOK.BackColor;
            btnClose.ForeColor = btnOK.ForeColor;

            frm.Controls.Add(lblText);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);

            btnClose.Click += delegate { frm.Close(); };

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            txt.KeyDown += delegate (object myobject, KeyEventArgs Mye)
            {
                if (Mye.KeyData == Keys.Enter) btnOK.PerformClick();
            };

            frm.ShowDialog();
            return strText;
        }
        public static void MsgBox(string strMessage)
        {
            MessageBox.Show(strMessage);
        }
        /// <summary>
        /// هذه الداله ترجع ترو او فوولس طبقا للراجع من نتيجه النافذه
        /// </summary>
        /// <param name="strMessage"></param>
        /// <returns></returns>
        public static bool MsgBoxYesNo(string strMessage)
        {
            DialogResult dr = MessageBox.Show(strMessage, "Message Information", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) return true;
            else return false;
        }
    }
}
