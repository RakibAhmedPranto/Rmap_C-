namespace RMapNavigator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.tbZip);
            this.splitContainer1.Panel1.Controls.Add(this.lblZip);
            this.splitContainer1.Panel1.Controls.Add(this.tbState);
            this.splitContainer1.Panel1.Controls.Add(this.lblState);
            this.splitContainer1.Panel1.Controls.Add(this.tbCity);
            this.splitContainer1.Panel1.Controls.Add(this.lblCity);
            this.splitContainer1.Panel1.Controls.Add(this.tbStreet);
            this.splitContainer1.Panel1.Controls.Add(this.lblStreet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(83, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 42);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(83, 284);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(160, 20);
            this.tbZip.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(10, 285);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(67, 16);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "ZipCode";
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(83, 217);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(160, 20);
            this.tbState.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(28, 217);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 16);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(83, 155);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(160, 20);
            this.tbCity.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(28, 155);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(83, 94);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(160, 20);
            this.tbStreet.TabIndex = 1;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(28, 94);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(49, 16);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(530, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "RMapNavigator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

