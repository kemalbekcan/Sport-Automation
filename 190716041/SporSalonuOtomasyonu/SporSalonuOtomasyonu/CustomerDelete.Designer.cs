namespace SporSalonuOtomasyonu
{
	partial class CustomerDelete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDelete));
			this.dgvCustomerDelete = new System.Windows.Forms.DataGridView();
			this.btnCustomerDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDelete)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCustomerDelete
			// 
			this.dgvCustomerDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerDelete.Location = new System.Drawing.Point(12, 12);
			this.dgvCustomerDelete.Name = "dgvCustomerDelete";
			this.dgvCustomerDelete.Size = new System.Drawing.Size(776, 277);
			this.dgvCustomerDelete.TabIndex = 1;
			this.dgvCustomerDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDelete_CellClick);
			// 
			// btnCustomerDelete
			// 
			this.btnCustomerDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDelete.Image")));
			this.btnCustomerDelete.Location = new System.Drawing.Point(342, 340);
			this.btnCustomerDelete.Name = "btnCustomerDelete";
			this.btnCustomerDelete.Size = new System.Drawing.Size(56, 50);
			this.btnCustomerDelete.TabIndex = 2;
			this.btnCustomerDelete.UseVisualStyleBackColor = true;
			this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
			// 
			// CustomerDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCustomerDelete);
			this.Controls.Add(this.dgvCustomerDelete);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CustomerDelete";
			this.Text = "Müşteri Sil";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerDelete_FormClosing);
			this.Load += new System.EventHandler(this.CustomerDelete_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDelete)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvCustomerDelete;
		private System.Windows.Forms.Button btnCustomerDelete;
	}
}