using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Tester_Tool
{
    public partial class Form1 : Form
    {
        private readonly Color gray = Color.FromArgb(105, 113, 121);
        private readonly Color green = Color.FromArgb(27, 163, 69);
        private readonly Color yellow = Color.FromArgb(254, 192, 1);
        private readonly Color red = Color.FromArgb(222, 62, 68);
        private readonly Color blue = Color.FromArgb(1, 162, 185);
        private readonly Color purple = Color.FromArgb(119, 6, 78);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClearBody_Click(object sender, EventArgs e)
        {
            this.textBoxURL.Text = "";
            this.radioButtonGET.Checked = true;
            this.richTextBoxBody.Text = "";
        }

        private void buttonClearContent_Click(object sender, EventArgs e)
        {
            this.buttonCode.Text = "—";
            this.buttonCode.BackColor = this.gray;
            this.richTextBoxContent.Text = "";
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBoxContent.Text);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.textBoxURL.Text == "")
            {
                MessageBox.Show("Please, enter an URL address !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.richTextBoxBody.Text != "")
            {
                if (this.radioButtonGET.Checked)
                {
                    MessageBox.Show("You cannot send query body with GET method !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        JsonConvert.DeserializeObject(this.richTextBoxBody.Text);
                    }
                    catch
                    {
                        this.invalidBody();
                        return;
                    }
                }
            }


            this.buttonSend.Enabled = false;
            this.buttonClearBody.Enabled = false;
            this.buttonCopy.Enabled = false;
            this.buttonClearContent.Enabled = false;


            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.textBoxURL.Text);
                httpWebRequest.ContentType = "application/json; charset=utf-8";

                if (this.radioButtonGET.Checked) httpWebRequest.Method = "GET";
                else if (this.radioButtonPOST.Checked) httpWebRequest.Method = "POST";
                else if (this.radioButtonPUT.Checked) httpWebRequest.Method = "PUT";
                else if (this.radioButtonPATCH.Checked) httpWebRequest.Method = "PATCH";
                else if (this.radioButtonDELETE.Checked) httpWebRequest.Method = "DELETE";

                if (!this.radioButtonGET.Checked)
                {
                    using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(this.richTextBoxBody.Text);
                    }
                }

                HttpWebResponse httpResponse;
                try
                {
                    httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                }
                catch (WebException ex)
                {
                    httpResponse = ex.Response as HttpWebResponse;
                }

                string code = Convert.ToString((int)httpResponse.StatusCode);
                char rank = code.ToCharArray()[0];
                this.buttonCode.Text = code + " — " + httpResponse.StatusCode;
                switch (rank)
                {
                    case '1':
                        this.buttonCode.BackColor = this.blue;
                        break;
                    case '2':
                        this.buttonCode.BackColor = this.green;
                        break;
                    case '3':
                        this.buttonCode.BackColor = this.yellow;
                        break;
                    case '4':
                        this.buttonCode.BackColor = this.red;
                        break;
                    case '5':
                        this.buttonCode.BackColor = this.purple;
                        break;
                }

                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string result = streamReader.ReadToEnd();
                    this.richTextBoxContent.Text = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred !\r\nMessage : \"" + ex.Message + "\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.buttonSend.Enabled = true;
            this.buttonClearBody.Enabled = true;
            this.buttonCopy.Enabled = true;
            this.buttonClearContent.Enabled = true;
        }

        private void checkBoxWrapBody_CheckedChanged(object sender, EventArgs e)
        {
            this.richTextBoxBody.WordWrap = this.checkBoxWrapBody.Checked;
        }

        private void checkBoxWarpContent_CheckedChanged(object sender, EventArgs e)
        {
            this.richTextBoxContent.WordWrap = this.checkBoxWrapContent.Checked;
        }

        private void checkBoxIndentBody_CheckedChanged(object sender, EventArgs e)
        {
            this.indentBody();
        }

        private void checkBoxIndentContent_CheckedChanged(object sender, EventArgs e)
        {
            this.indentContent();
        }

        private void richTextBoxBody_Validating(object sender, CancelEventArgs e)
        {
            this.indentBody();
        }

        private void richTextBoxContent_TextChanged(object sender, EventArgs e)
        {
            this.indentContent();
        }

        private void indentBody()
        {
            if (this.richTextBoxBody.Text != "")
            {
                try
                {
                    this.richTextBoxBody.Text = JsonConvert.SerializeObject(
                        JsonConvert.DeserializeObject(this.richTextBoxBody.Text),
                        this.checkBoxIndentBody.Checked ? Formatting.Indented : Formatting.None);
                }
                catch
                {
                    this.invalidBody();
                }
            }
        }

        private void indentContent()
        {
            if (this.richTextBoxContent.Text != "")
            {
                try
                {
                    this.richTextBoxContent.Text = JsonConvert.SerializeObject(
                        JsonConvert.DeserializeObject(this.richTextBoxContent.Text),
                        this.checkBoxIndentContent.Checked ? Formatting.Indented : Formatting.None);
                }
                catch 
                {
                    this.invalidContent();
                }
            }
        }

        private void invalidBody()
        {
            MessageBox.Show("The query body is not valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void invalidContent()
        {
            MessageBox.Show("The response content is not valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
