namespace Hello_World
{
	partial class m_frmHelloWorld
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
			this.m_lblGreeting = new System.Windows.Forms.Label();
			this.m_tbGreeting = new System.Windows.Forms.TextBox();
			this.m_btnSayHelloWorld = new System.Windows.Forms.Button();
			this.m_btnClearGreeting = new System.Windows.Forms.Button();
			this.m_tbOneToGreet = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_lblGreeting
			// 
			this.m_lblGreeting.AutoSize = true;
			this.m_lblGreeting.Location = new System.Drawing.Point(37, 50);
			this.m_lblGreeting.Name = "m_lblGreeting";
			this.m_lblGreeting.Size = new System.Drawing.Size(47, 13);
			this.m_lblGreeting.TabIndex = 0;
			this.m_lblGreeting.Text = "Greeting";
			// 
			// m_tbGreeting
			// 
			this.m_tbGreeting.Location = new System.Drawing.Point(90, 47);
			this.m_tbGreeting.Name = "m_tbGreeting";
			this.m_tbGreeting.ReadOnly = true;
			this.m_tbGreeting.Size = new System.Drawing.Size(160, 20);
			this.m_tbGreeting.TabIndex = 1;
			// 
			// m_btnSayHelloWorld
			// 
			this.m_btnSayHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnSayHelloWorld.Location = new System.Drawing.Point(51, 97);
			this.m_btnSayHelloWorld.Name = "m_btnSayHelloWorld";
			this.m_btnSayHelloWorld.Size = new System.Drawing.Size(199, 40);
			this.m_btnSayHelloWorld.TabIndex = 2;
			this.m_btnSayHelloWorld.Text = "Say \"Hello, World!\"";
			this.m_btnSayHelloWorld.UseVisualStyleBackColor = true;
			this.m_btnSayHelloWorld.Click += new System.EventHandler(this.m_btnSayHelloWorld_Click);
			// 
			// m_btnClearGreeting
			// 
			this.m_btnClearGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnClearGreeting.Location = new System.Drawing.Point(51, 144);
			this.m_btnClearGreeting.Name = "m_btnClearGreeting";
			this.m_btnClearGreeting.Size = new System.Drawing.Size(199, 41);
			this.m_btnClearGreeting.TabIndex = 3;
			this.m_btnClearGreeting.Text = "Clear Greeting";
			this.m_btnClearGreeting.UseVisualStyleBackColor = true;
			this.m_btnClearGreeting.Click += new System.EventHandler(this.m_btnClearGreeting_Click);
			// 
			// m_tbOneToGreet
			// 
			this.m_tbOneToGreet.Location = new System.Drawing.Point(126, 210);
			this.m_tbOneToGreet.Name = "m_tbOneToGreet";
			this.m_tbOneToGreet.Size = new System.Drawing.Size(124, 20);
			this.m_tbOneToGreet.TabIndex = 4;
			this.m_tbOneToGreet.TextChanged += new System.EventHandler(this.m_tbOneToGreet_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "One To Greet";
			// 
			// m_frmHelloWorld
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbOneToGreet);
			this.Controls.Add(this.m_btnClearGreeting);
			this.Controls.Add(this.m_btnSayHelloWorld);
			this.Controls.Add(this.m_tbGreeting);
			this.Controls.Add(this.m_lblGreeting);
			this.Name = "m_frmHelloWorld";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hello, World!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label m_lblGreeting;
		private System.Windows.Forms.TextBox m_tbGreeting;
		private System.Windows.Forms.Button m_btnSayHelloWorld;
		private System.Windows.Forms.Button m_btnClearGreeting;
		private System.Windows.Forms.TextBox m_tbOneToGreet;
		private System.Windows.Forms.Label label1;
	}
}

