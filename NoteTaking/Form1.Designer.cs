﻿namespace NoteTaking
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtTitle = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bttNew = new System.Windows.Forms.Button();
			this.bttDel = new System.Windows.Forms.Button();
			this.bttSave = new System.Windows.Forms.Button();
			this.bttRead = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Message";
			// 
			// TxtTitle
			// 
			this.TxtTitle.Location = new System.Drawing.Point(71, 33);
			this.TxtTitle.Name = "TxtTitle";
			this.TxtTitle.Size = new System.Drawing.Size(240, 23);
			this.TxtTitle.TabIndex = 2;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(23, 121);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(472, 287);
			this.txtMessage.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(553, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(225, 275);
			this.dataGridView1.TabIndex = 4;
			// 
			// bttNew
			// 
			this.bttNew.Location = new System.Drawing.Point(338, 33);
			this.bttNew.Name = "bttNew";
			this.bttNew.Size = new System.Drawing.Size(68, 24);
			this.bttNew.TabIndex = 5;
			this.bttNew.Text = "New";
			this.bttNew.UseVisualStyleBackColor = true;
			// 
			// bttDel
			// 
			this.bttDel.Location = new System.Drawing.Point(710, 314);
			this.bttDel.Name = "bttDel";
			this.bttDel.Size = new System.Drawing.Size(68, 24);
			this.bttDel.TabIndex = 6;
			this.bttDel.Text = "Delete";
			this.bttDel.UseVisualStyleBackColor = true;
			// 
			// bttSave
			// 
			this.bttSave.Location = new System.Drawing.Point(501, 384);
			this.bttSave.Name = "bttSave";
			this.bttSave.Size = new System.Drawing.Size(68, 24);
			this.bttSave.TabIndex = 7;
			this.bttSave.Text = "Save";
			this.bttSave.UseVisualStyleBackColor = true;
			// 
			// bttRead
			// 
			this.bttRead.Location = new System.Drawing.Point(553, 314);
			this.bttRead.Name = "bttRead";
			this.bttRead.Size = new System.Drawing.Size(68, 24);
			this.bttRead.TabIndex = 8;
			this.bttRead.Text = "Read";
			this.bttRead.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bttRead);
			this.Controls.Add(this.bttSave);
			this.Controls.Add(this.bttDel);
			this.Controls.Add(this.bttNew);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.TxtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox TxtTitle;
		private TextBox txtMessage;
		private DataGridView dataGridView1;
		private Button bttNew;
		private Button bttDel;
		private Button bttSave;
		private Button bttRead;
	}
}