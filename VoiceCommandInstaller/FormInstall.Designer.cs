namespace VoiceCommandInstaller {
	partial class FormInstall {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.textDir = new System.Windows.Forms.TextBox();
			this.butBrowse = new System.Windows.Forms.Button();
			this.butInstall = new System.Windows.Forms.Button();
			this.butCancel = new System.Windows.Forms.Button();
			this.checkCreateProgLink = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Open Dental Installation Directory";
			// 
			// textDir
			// 
			this.textDir.Location = new System.Drawing.Point(38, 35);
			this.textDir.Name = "textDir";
			this.textDir.Size = new System.Drawing.Size(265, 20);
			this.textDir.TabIndex = 1;
			// 
			// butBrowse
			// 
			this.butBrowse.Location = new System.Drawing.Point(309, 33);
			this.butBrowse.Name = "butBrowse";
			this.butBrowse.Size = new System.Drawing.Size(75, 23);
			this.butBrowse.TabIndex = 2;
			this.butBrowse.Text = "Browse";
			this.butBrowse.UseVisualStyleBackColor = true;
			this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
			// 
			// butInstall
			// 
			this.butInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butInstall.Location = new System.Drawing.Point(257, 108);
			this.butInstall.Name = "butInstall";
			this.butInstall.Size = new System.Drawing.Size(75, 23);
			this.butInstall.TabIndex = 3;
			this.butInstall.Text = "Install";
			this.butInstall.UseVisualStyleBackColor = true;
			this.butInstall.Click += new System.EventHandler(this.butInstall_Click);
			// 
			// butCancel
			// 
			this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butCancel.Location = new System.Drawing.Point(338, 108);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(75, 23);
			this.butCancel.TabIndex = 4;
			this.butCancel.Text = "Cancel";
			this.butCancel.UseVisualStyleBackColor = true;
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
			// 
			// checkCreateProgLink
			// 
			this.checkCreateProgLink.Checked = true;
			this.checkCreateProgLink.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkCreateProgLink.Location = new System.Drawing.Point(63, 64);
			this.checkCreateProgLink.Name = "checkCreateProgLink";
			this.checkCreateProgLink.Size = new System.Drawing.Size(283, 33);
			this.checkCreateProgLink.TabIndex = 5;
			this.checkCreateProgLink.Text = "Create Program Link. This will not overwrite an existing Program Link.";
			this.checkCreateProgLink.UseVisualStyleBackColor = true;
			// 
			// FormInstall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 140);
			this.Controls.Add(this.checkCreateProgLink);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.butInstall);
			this.Controls.Add(this.butBrowse);
			this.Controls.Add(this.textDir);
			this.Controls.Add(this.label1);
			this.Name = "FormInstall";
			this.Text = "Voice Command Installation";
			this.Load += new System.EventHandler(this.FormInstall_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textDir;
		private System.Windows.Forms.Button butBrowse;
		private System.Windows.Forms.Button butInstall;
		private System.Windows.Forms.Button butCancel;
		private System.Windows.Forms.CheckBox checkCreateProgLink;
	}
}

