namespace SporSalonuOtomasyonu
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.btnCustomerAdd = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnCustomerUpdate = new System.Windows.Forms.Button();
			this.dgvEnrollees = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvCustomerExpired = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCustomerDelete = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvEnrollees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerExpired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCustomerDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCustomerAdd
			// 
			this.btnCustomerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.Image")));
			this.btnCustomerAdd.Location = new System.Drawing.Point(12, 32);
			this.btnCustomerAdd.Name = "btnCustomerAdd";
			this.btnCustomerAdd.Size = new System.Drawing.Size(118, 122);
			this.btnCustomerAdd.TabIndex = 0;
			this.btnCustomerAdd.UseVisualStyleBackColor = true;
			this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click_1);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(12, 196);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 122);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btnCustomerDelete_Click);
			// 
			// btnCustomerUpdate
			// 
			this.btnCustomerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerUpdate.Image")));
			this.btnCustomerUpdate.Location = new System.Drawing.Point(12, 369);
			this.btnCustomerUpdate.Name = "btnCustomerUpdate";
			this.btnCustomerUpdate.Size = new System.Drawing.Size(118, 122);
			this.btnCustomerUpdate.TabIndex = 2;
			this.btnCustomerUpdate.UseVisualStyleBackColor = true;
			this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
			// 
			// dgvEnrollees
			// 
			this.dgvEnrollees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEnrollees.Location = new System.Drawing.Point(253, 32);
			this.dgvEnrollees.Name = "dgvEnrollees";
			this.dgvEnrollees.Size = new System.Drawing.Size(535, 122);
			this.dgvEnrollees.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(694, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kayıtlı Kişiler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(676, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Süresi Bitenler";
			// 
			// dgvCustomerExpired
			// 
			this.dgvCustomerExpired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerExpired.Location = new System.Drawing.Point(253, 196);
			this.dgvCustomerExpired.Name = "dgvCustomerExpired";
			this.dgvCustomerExpired.Size = new System.Drawing.Size(535, 122);
			this.dgvCustomerExpired.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(710, 346);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ödemeler";
			// 
			// btnCustomerDelete
			// 
			this.btnCustomerDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.btnCustomerDelete.Location = new System.Drawing.Point(253, 369);
			this.btnCustomerDelete.Name = "btnCustomerDelete";
			this.btnCustomerDelete.Size = new System.Drawing.Size(535, 122);
			this.btnCustomerDelete.TabIndex = 8;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.btnCustomerDelete);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvCustomerExpired);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvEnrollees);
			this.Controls.Add(this.btnCustomerUpdate);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnCustomerAdd);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Menu";
			this.Text = "Menü";
			this.Load += new System.EventHandler(this.Menu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEnrollees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerExpired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCustomerDelete)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCustomerAdd;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnCustomerUpdate;
		private System.Windows.Forms.DataGridView dgvEnrollees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvCustomerExpired;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView btnCustomerDelete;
	}
}