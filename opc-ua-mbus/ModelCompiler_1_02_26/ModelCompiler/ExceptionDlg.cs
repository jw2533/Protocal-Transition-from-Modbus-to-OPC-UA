/* ========================================================================
 * Copyright (c) 2005-2011 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Opc.Ua.ModelCompiler
{
    public partial class ExceptionDlg : Form
    {
        public ExceptionDlg()
        {
            InitializeComponent();
        }

        public ExceptionDlg(Exception e)
        {
            InitializeComponent();

            StringBuilder buffer = new StringBuilder();

            buffer.Append("<html><body style='margin:0'>");
            buffer.Append("<font style='font:9pt/12pt verdana; color:black'>");

            while (e != null)
            {
                string message = e.Message;
                message = message.Replace("<", "&lt;");
                message = message.Replace(">", "&gt;");
                message = message.Replace("\r\n", "<br>");

                buffer.AppendFormat("<font color='red'><b>{0}</b></font><br>", message);
                buffer.AppendFormat("{0}<p>", e.StackTrace);

                e = e.InnerException;
            }

            buffer.Append("</font>");
            buffer.Append("</body></html>");

            ExceptionBrowser.DocumentText = buffer.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
