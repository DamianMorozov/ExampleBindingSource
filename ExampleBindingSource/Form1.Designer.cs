namespace ExampleBindingSource
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
			this.components = new System.ComponentModel.Container();
			this.buttonRemoveItem = new System.Windows.Forms.Button();
			this.comboBoxCity = new System.Windows.Forms.ComboBox();
			this.labelRegion = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.buttonCreateNewDataSource = new System.Windows.Forms.Button();
			this.textBoxRegion = new System.Windows.Forms.TextBox();
			this.bindingSourceState = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRemoveItem
			// 
			this.buttonRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveItem.Location = new System.Drawing.Point(10, 110);
			this.buttonRemoveItem.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRemoveItem.Name = "buttonRemoveItem";
			this.buttonRemoveItem.Size = new System.Drawing.Size(260, 28);
			this.buttonRemoveItem.TabIndex = 0;
			this.buttonRemoveItem.Text = "Remove";
			this.buttonRemoveItem.UseVisualStyleBackColor = true;
			this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
			// 
			// comboBoxCity
			// 
			this.comboBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCity.FormattingEnabled = true;
			this.comboBoxCity.Location = new System.Drawing.Point(80, 77);
			this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxCity.Name = "comboBoxCity";
			this.comboBoxCity.Size = new System.Drawing.Size(190, 24);
			this.comboBoxCity.TabIndex = 2;
			// 
			// labelRegion
			// 
			this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRegion.Location = new System.Drawing.Point(10, 50);
			this.labelRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegion.Name = "labelRegion";
			this.labelRegion.Size = new System.Drawing.Size(60, 16);
			this.labelRegion.TabIndex = 3;
			this.labelRegion.Text = "Region";
			this.labelRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCity
			// 
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCity.Location = new System.Drawing.Point(10, 80);
			this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(60, 16);
			this.labelCity.TabIndex = 4;
			this.labelCity.Text = "City";
			this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonCreateNewDataSource
			// 
			this.buttonCreateNewDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateNewDataSource.Location = new System.Drawing.Point(10, 10);
			this.buttonCreateNewDataSource.Margin = new System.Windows.Forms.Padding(4);
			this.buttonCreateNewDataSource.Name = "buttonCreateNewDataSource";
			this.buttonCreateNewDataSource.Size = new System.Drawing.Size(260, 28);
			this.buttonCreateNewDataSource.TabIndex = 5;
			this.buttonCreateNewDataSource.Text = "Create new DataSource";
			this.buttonCreateNewDataSource.UseVisualStyleBackColor = true;
			this.buttonCreateNewDataSource.Click += new System.EventHandler(this.buttonCreateNewDataSource_Click);
			// 
			// textBoxRegion
			// 
			this.textBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRegion.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxRegion.Location = new System.Drawing.Point(80, 45);
			this.textBoxRegion.Name = "textBoxRegion";
			this.textBoxRegion.ReadOnly = true;
			this.textBoxRegion.Size = new System.Drawing.Size(190, 22);
			this.textBoxRegion.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 146);
			this.Controls.Add(this.textBoxRegion);
			this.Controls.Add(this.buttonCreateNewDataSource);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelRegion);
			this.Controls.Add(this.comboBoxCity);
			this.Controls.Add(this.buttonRemoveItem);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Example of BindingSource";
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceState)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonRemoveItem;
		private System.Windows.Forms.ComboBox comboBoxCity;
		private System.Windows.Forms.Label labelRegion;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Button buttonCreateNewDataSource;
		private System.Windows.Forms.TextBox textBoxRegion;
		private System.Windows.Forms.BindingSource bindingSourceState;
	}
}

