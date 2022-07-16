
namespace API_Tester_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonGET = new System.Windows.Forms.RadioButton();
            this.radioButtonPUT = new System.Windows.Forms.RadioButton();
            this.radioButtonPOST = new System.Windows.Forms.RadioButton();
            this.radioButtonPATCH = new System.Windows.Forms.RadioButton();
            this.radioButtonDELETE = new System.Windows.Forms.RadioButton();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCode = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClearBody = new System.Windows.Forms.Button();
            this.buttonClearContent = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxWrapContent = new System.Windows.Forms.CheckBox();
            this.checkBoxWrapBody = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentBody = new System.Windows.Forms.CheckBox();
            this.checkBoxIndentContent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.textBoxURL.ForeColor = System.Drawing.Color.White;
            this.textBoxURL.Location = new System.Drawing.Point(32, 69);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(500, 33);
            this.textBoxURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Query method";
            // 
            // radioButtonGET
            // 
            this.radioButtonGET.AutoSize = true;
            this.radioButtonGET.Checked = true;
            this.radioButtonGET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonGET.Location = new System.Drawing.Point(32, 171);
            this.radioButtonGET.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonGET.Name = "radioButtonGET";
            this.radioButtonGET.Size = new System.Drawing.Size(62, 29);
            this.radioButtonGET.TabIndex = 3;
            this.radioButtonGET.TabStop = true;
            this.radioButtonGET.Text = "GET";
            this.radioButtonGET.UseVisualStyleBackColor = true;
            // 
            // radioButtonPUT
            // 
            this.radioButtonPUT.AutoSize = true;
            this.radioButtonPUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPUT.Location = new System.Drawing.Point(32, 200);
            this.radioButtonPUT.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonPUT.Name = "radioButtonPUT";
            this.radioButtonPUT.Size = new System.Drawing.Size(63, 29);
            this.radioButtonPUT.TabIndex = 4;
            this.radioButtonPUT.Text = "PUT";
            this.radioButtonPUT.UseVisualStyleBackColor = true;
            // 
            // radioButtonPOST
            // 
            this.radioButtonPOST.AutoSize = true;
            this.radioButtonPOST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPOST.Location = new System.Drawing.Point(94, 171);
            this.radioButtonPOST.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonPOST.Name = "radioButtonPOST";
            this.radioButtonPOST.Size = new System.Drawing.Size(74, 29);
            this.radioButtonPOST.TabIndex = 5;
            this.radioButtonPOST.Text = "POST";
            this.radioButtonPOST.UseVisualStyleBackColor = true;
            // 
            // radioButtonPATCH
            // 
            this.radioButtonPATCH.AutoSize = true;
            this.radioButtonPATCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPATCH.Location = new System.Drawing.Point(32, 229);
            this.radioButtonPATCH.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.radioButtonPATCH.Name = "radioButtonPATCH";
            this.radioButtonPATCH.Size = new System.Drawing.Size(84, 29);
            this.radioButtonPATCH.TabIndex = 6;
            this.radioButtonPATCH.Text = "PATCH";
            this.radioButtonPATCH.UseVisualStyleBackColor = true;
            // 
            // radioButtonDELETE
            // 
            this.radioButtonDELETE.AutoSize = true;
            this.radioButtonDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDELETE.Location = new System.Drawing.Point(94, 200);
            this.radioButtonDELETE.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonDELETE.Name = "radioButtonDELETE";
            this.radioButtonDELETE.Size = new System.Drawing.Size(91, 29);
            this.radioButtonDELETE.TabIndex = 7;
            this.radioButtonDELETE.Text = "DELETE";
            this.radioButtonDELETE.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.richTextBoxBody.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(194)))), ((int)(((byte)(101)))));
            this.richTextBoxBody.Location = new System.Drawing.Point(32, 327);
            this.richTextBoxBody.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(500, 259);
            this.richTextBoxBody.TabIndex = 8;
            this.richTextBoxBody.Text = "";
            this.richTextBoxBody.WordWrap = false;
            this.richTextBoxBody.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxBody_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Query body (JSON)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(652, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "HTTP response code";
            // 
            // buttonCode
            // 
            this.buttonCode.AutoSize = true;
            this.buttonCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonCode.Enabled = false;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCode.Location = new System.Drawing.Point(657, 69);
            this.buttonCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(41, 35);
            this.buttonCode.TabIndex = 11;
            this.buttonCode.Text = "—";
            this.buttonCode.UseVisualStyleBackColor = false;
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.richTextBoxContent.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(194)))), ((int)(((byte)(101)))));
            this.richTextBoxContent.Location = new System.Drawing.Point(657, 173);
            this.richTextBoxContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.ReadOnly = true;
            this.richTextBoxContent.Size = new System.Drawing.Size(500, 413);
            this.richTextBoxContent.TabIndex = 12;
            this.richTextBoxContent.Text = "";
            this.richTextBoxContent.WordWrap = false;
            this.richTextBoxContent.TextChanged += new System.EventHandler(this.richTextBoxContent_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(652, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Response content (JSON)";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(247)))));
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Location = new System.Drawing.Point(32, 659);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 50);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClearBody
            // 
            this.buttonClearBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.buttonClearBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearBody.Location = new System.Drawing.Point(437, 659);
            this.buttonClearBody.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearBody.Name = "buttonClearBody";
            this.buttonClearBody.Size = new System.Drawing.Size(100, 50);
            this.buttonClearBody.TabIndex = 16;
            this.buttonClearBody.Text = "Clear";
            this.buttonClearBody.UseVisualStyleBackColor = false;
            this.buttonClearBody.Click += new System.EventHandler(this.buttonClearBody_Click);
            // 
            // buttonClearContent
            // 
            this.buttonClearContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.buttonClearContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearContent.Location = new System.Drawing.Point(1057, 659);
            this.buttonClearContent.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearContent.Name = "buttonClearContent";
            this.buttonClearContent.Size = new System.Drawing.Size(100, 50);
            this.buttonClearContent.TabIndex = 18;
            this.buttonClearContent.Text = "Clear";
            this.buttonClearContent.UseVisualStyleBackColor = false;
            this.buttonClearContent.Click += new System.EventHandler(this.buttonClearContent_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(247)))));
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Location = new System.Drawing.Point(657, 659);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 50);
            this.buttonCopy.TabIndex = 17;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxWrapContent
            // 
            this.checkBoxWrapContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWrapContent.AutoSize = true;
            this.checkBoxWrapContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWrapContent.Location = new System.Drawing.Point(657, 598);
            this.checkBoxWrapContent.Margin = new System.Windows.Forms.Padding(0, 0, 12, 32);
            this.checkBoxWrapContent.Name = "checkBoxWrapContent";
            this.checkBoxWrapContent.Size = new System.Drawing.Size(163, 29);
            this.checkBoxWrapContent.TabIndex = 19;
            this.checkBoxWrapContent.Text = "Auto word wrap";
            this.checkBoxWrapContent.UseVisualStyleBackColor = true;
            this.checkBoxWrapContent.CheckedChanged += new System.EventHandler(this.checkBoxWarpContent_CheckedChanged);
            // 
            // checkBoxWrapBody
            // 
            this.checkBoxWrapBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWrapBody.AutoSize = true;
            this.checkBoxWrapBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWrapBody.Location = new System.Drawing.Point(32, 598);
            this.checkBoxWrapBody.Margin = new System.Windows.Forms.Padding(0, 0, 12, 32);
            this.checkBoxWrapBody.Name = "checkBoxWrapBody";
            this.checkBoxWrapBody.Size = new System.Drawing.Size(163, 29);
            this.checkBoxWrapBody.TabIndex = 20;
            this.checkBoxWrapBody.Text = "Auto word wrap";
            this.checkBoxWrapBody.UseVisualStyleBackColor = true;
            this.checkBoxWrapBody.CheckedChanged += new System.EventHandler(this.checkBoxWrapBody_CheckedChanged);
            // 
            // checkBoxIndentBody
            // 
            this.checkBoxIndentBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIndentBody.AutoSize = true;
            this.checkBoxIndentBody.Checked = true;
            this.checkBoxIndentBody.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIndentBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIndentBody.Location = new System.Drawing.Point(207, 598);
            this.checkBoxIndentBody.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.checkBoxIndentBody.Name = "checkBoxIndentBody";
            this.checkBoxIndentBody.Size = new System.Drawing.Size(127, 29);
            this.checkBoxIndentBody.TabIndex = 21;
            this.checkBoxIndentBody.Text = "Auto indent";
            this.checkBoxIndentBody.UseVisualStyleBackColor = true;
            this.checkBoxIndentBody.CheckedChanged += new System.EventHandler(this.checkBoxIndentBody_CheckedChanged);
            // 
            // checkBoxIndentContent
            // 
            this.checkBoxIndentContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIndentContent.AutoSize = true;
            this.checkBoxIndentContent.Checked = true;
            this.checkBoxIndentContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIndentContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIndentContent.Location = new System.Drawing.Point(832, 598);
            this.checkBoxIndentContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 32);
            this.checkBoxIndentContent.Name = "checkBoxIndentContent";
            this.checkBoxIndentContent.Size = new System.Drawing.Size(127, 29);
            this.checkBoxIndentContent.TabIndex = 22;
            this.checkBoxIndentContent.Text = "Auto indent";
            this.checkBoxIndentContent.UseVisualStyleBackColor = true;
            this.checkBoxIndentContent.CheckedChanged += new System.EventHandler(this.checkBoxIndentContent_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1189, 741);
            this.Controls.Add(this.checkBoxIndentContent);
            this.Controls.Add(this.checkBoxIndentBody);
            this.Controls.Add(this.checkBoxWrapBody);
            this.Controls.Add(this.checkBoxWrapContent);
            this.Controls.Add(this.buttonClearContent);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonClearBody);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxBody);
            this.Controls.Add(this.radioButtonDELETE);
            this.Controls.Add(this.radioButtonPATCH);
            this.Controls.Add(this.radioButtonPOST);
            this.Controls.Add(this.radioButtonPUT);
            this.Controls.Add(this.radioButtonGET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1205, 780);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(32);
            this.Text = "(1.1.2.0) API Tester Tool — Testing JSON to JSON API — by Thibault BUSTOS (TheRak" +
    "e66)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonGET;
        private System.Windows.Forms.RadioButton radioButtonPUT;
        private System.Windows.Forms.RadioButton radioButtonPOST;
        private System.Windows.Forms.RadioButton radioButtonPATCH;
        private System.Windows.Forms.RadioButton radioButtonDELETE;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClearBody;
        private System.Windows.Forms.Button buttonClearContent;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxWrapContent;
        private System.Windows.Forms.CheckBox checkBoxWrapBody;
        private System.Windows.Forms.CheckBox checkBoxIndentBody;
        private System.Windows.Forms.CheckBox checkBoxIndentContent;
    }
}

