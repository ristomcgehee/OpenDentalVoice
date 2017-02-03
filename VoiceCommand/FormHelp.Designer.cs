namespace VoiceCommand {
	partial class FormHelp {
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
			this.labelCommandList = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Here is a list of commands you can say:";
			// 
			// labelCommandList
			// 
			this.labelCommandList.AutoSize = true;
			this.labelCommandList.Location = new System.Drawing.Point(12, 6);
			this.labelCommandList.Name = "labelCommandList";
			this.labelCommandList.Size = new System.Drawing.Size(62, 13);
			this.labelCommandList.TabIndex = 1;
			this.labelCommandList.Text = "-Commands";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.labelCommandList);
			this.panel1.Location = new System.Drawing.Point(15, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(276, 266);
			this.panel1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = " Voice Command Plug-In";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(37, 32);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 13);
			this.labelVersion.TabIndex = 4;
			this.labelVersion.Text = "Version:";
			// 
			// FormHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 354);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "FormHelp";
			this.Text = "Voice Command Help";
			this.Load += new System.EventHandler(this.FormHelp_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCommandList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelVersion;
	}
}