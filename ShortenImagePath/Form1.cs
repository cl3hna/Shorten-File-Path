using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortenImagePath
{
	public partial class Form1 : Form
	{
		private int PathLength { get; set; }

		public Form1()
		{
			InitializeComponent();
		}

		private void btnFilePath_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult dr = fbd.ShowDialog();

				if (dr == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					string[] files = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);

					this.tbxFileLocation.Text = fbd.SelectedPath;
					this.txtFilesFound.Text = files.Count().ToString();
					this.btnProcessFile.Enabled = true;
					this.lblWarning.Visible = true;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int counter = 1;

			if (!String.IsNullOrEmpty(tbtPathLength.Text))
			{
				PathLength = Convert.ToInt32(this.tbtPathLength.Text);

				string name = "", substring = "", completePath = ""; ;
				string[] files = Directory.GetFiles(this.tbxFileLocation.Text, "*", SearchOption.AllDirectories);
				foreach (var item in files)
				{
					name = Path.GetFileNameWithoutExtension(item);
					if (name.Length > PathLength)
					{
						substring = name.Substring(0, PathLength);
						completePath = item.Replace(name, substring);

						File.Move(item, completePath);

						this.tbtOutput.Text += Renaming(counter);
						counter++;
					}
					else
					{
						this.tbtOutput.Text += Warning(counter);
						counter++;
					}
				}
			}
			else
			{
				MessageBox.Show("Please specify max file length");
			}
		}

		private string Renaming(int counter)
		{
			StringBuilder sb = new StringBuilder();
			//sb.Append($"File {counter} from {this.txtFilesFound.Text}");
			//sb.Append("/n");
			//sb.Append($"Changed from {oldName} to {newName}");
			sb.Append($"File {counter}  from {this.txtFilesFound.Text}");
			sb.Append(Environment.NewLine);

			return sb.ToString();
		}
		private string Warning(int counter)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"File {counter}  from {this.txtFilesFound.Text} - no change!");
			sb.Append(Environment.NewLine);

			return sb.ToString();
		}
	}
}
