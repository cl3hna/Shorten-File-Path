namespace ShortenImagePath
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.tbxFileLocation = new System.Windows.Forms.TextBox();
			this.btnFilePath = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilesFound = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbtPathLength = new System.Windows.Forms.TextBox();
			this.btnProcessFile = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbtOutput = new System.Windows.Forms.RichTextBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "File Location:";
			// 
			// tbxFileLocation
			// 
			this.tbxFileLocation.Location = new System.Drawing.Point(122, 43);
			this.tbxFileLocation.Name = "tbxFileLocation";
			this.tbxFileLocation.Size = new System.Drawing.Size(282, 20);
			this.tbxFileLocation.TabIndex = 1;
			// 
			// btnFilePath
			// 
			this.btnFilePath.Location = new System.Drawing.Point(282, 69);
			this.btnFilePath.Name = "btnFilePath";
			this.btnFilePath.Size = new System.Drawing.Size(122, 23);
			this.btnFilePath.TabIndex = 2;
			this.btnFilePath.Text = "File location";
			this.btnFilePath.UseVisualStyleBackColor = true;
			this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Files found:";
			// 
			// txtFilesFound
			// 
			this.txtFilesFound.Enabled = false;
			this.txtFilesFound.Location = new System.Drawing.Point(122, 138);
			this.txtFilesFound.Name = "txtFilesFound";
			this.txtFilesFound.Size = new System.Drawing.Size(282, 20);
			this.txtFilesFound.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Path length:";
			// 
			// tbtPathLength
			// 
			this.tbtPathLength.Location = new System.Drawing.Point(122, 172);
			this.tbtPathLength.Name = "tbtPathLength";
			this.tbtPathLength.Size = new System.Drawing.Size(154, 20);
			this.tbtPathLength.TabIndex = 6;
			// 
			// btnProcessFile
			// 
			this.btnProcessFile.Enabled = false;
			this.btnProcessFile.Location = new System.Drawing.Point(282, 169);
			this.btnProcessFile.Name = "btnProcessFile";
			this.btnProcessFile.Size = new System.Drawing.Size(122, 23);
			this.btnProcessFile.TabIndex = 7;
			this.btnProcessFile.Text = "Process files";
			this.btnProcessFile.UseVisualStyleBackColor = true;
			this.btnProcessFile.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Output:";
			// 
			// tbtOutput
			// 
			this.tbtOutput.Location = new System.Drawing.Point(122, 230);
			this.tbtOutput.Name = "tbtOutput";
			this.tbtOutput.Size = new System.Drawing.Size(282, 108);
			this.tbtOutput.TabIndex = 9;
			this.tbtOutput.Text = "";
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWarning.ForeColor = System.Drawing.Color.Green;
			this.lblWarning.Location = new System.Drawing.Point(98, 109);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(306, 13);
			this.lblWarning.TabIndex = 10;
			this.lblWarning.Text = "Please specify path length below and click button: Process files";
			this.lblWarning.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 381);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.tbtOutput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnProcessFile);
			this.Controls.Add(this.tbtPathLength);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFilesFound);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFilePath);
			this.Controls.Add(this.tbxFileLocation);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shorten Image Path";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxFileLocation;
		private System.Windows.Forms.Button btnFilePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilesFound;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbtPathLength;
		private System.Windows.Forms.Button btnProcessFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox tbtOutput;
		private System.Windows.Forms.Label lblWarning;
	}
}

