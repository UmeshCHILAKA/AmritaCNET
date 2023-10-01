namespace Q2
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHouseName = new System.Windows.Forms.Label();
            this.txtHouseName = new System.Windows.Forms.TextBox();
            this.lblMNum = new System.Windows.Forms.Label();
            this.txtMNum = new System.Windows.Forms.TextBox();
            this.lblHNum = new System.Windows.Forms.Label();
            this.txtHnum = new System.Windows.Forms.TextBox();
            this.lblLocality = new System.Windows.Forms.Label();
            this.txtLocality = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPO = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblHouseName
            // 
            this.lblHouseName.AutoSize = true;
            this.lblHouseName.Location = new System.Drawing.Point(37, 50);
            this.lblHouseName.Name = "lblHouseName";
            this.lblHouseName.Size = new System.Drawing.Size(84, 16);
            this.lblHouseName.TabIndex = 0;
            this.lblHouseName.Text = "House name";
            // 
            // txtHouseName
            // 
            this.txtHouseName.Location = new System.Drawing.Point(160, 47);
            this.txtHouseName.Name = "txtHouseName";
            this.txtHouseName.Size = new System.Drawing.Size(100, 22);
            this.txtHouseName.TabIndex = 1;
            // 
            // lblMNum
            // 
            this.lblMNum.AutoSize = true;
            this.lblMNum.Location = new System.Drawing.Point(37, 78);
            this.lblMNum.Name = "lblMNum";
            this.lblMNum.Size = new System.Drawing.Size(96, 16);
            this.lblMNum.TabIndex = 0;
            this.lblMNum.Text = "Mobile number";
            // 
            // txtMNum
            // 
            this.txtMNum.Location = new System.Drawing.Point(160, 75);
            this.txtMNum.Name = "txtMNum";
            this.txtMNum.Size = new System.Drawing.Size(100, 22);
            this.txtMNum.TabIndex = 2;
            // 
            // lblHNum
            // 
            this.lblHNum.AutoSize = true;
            this.lblHNum.Location = new System.Drawing.Point(37, 106);
            this.lblHNum.Name = "lblHNum";
            this.lblHNum.Size = new System.Drawing.Size(95, 16);
            this.lblHNum.TabIndex = 0;
            this.lblHNum.Text = "House number";
            // 
            // txtHnum
            // 
            this.txtHnum.Location = new System.Drawing.Point(160, 103);
            this.txtHnum.Name = "txtHnum";
            this.txtHnum.Size = new System.Drawing.Size(100, 22);
            this.txtHnum.TabIndex = 3;
            // 
            // lblLocality
            // 
            this.lblLocality.AutoSize = true;
            this.lblLocality.Location = new System.Drawing.Point(37, 134);
            this.lblLocality.Name = "lblLocality";
            this.lblLocality.Size = new System.Drawing.Size(53, 16);
            this.lblLocality.TabIndex = 0;
            this.lblLocality.Text = "Locality";
            // 
            // txtLocality
            // 
            this.txtLocality.Location = new System.Drawing.Point(160, 131);
            this.txtLocality.Name = "txtLocality";
            this.txtLocality.Size = new System.Drawing.Size(100, 22);
            this.txtLocality.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(37, 162);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(160, 159);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 5;
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Location = new System.Drawing.Point(37, 190);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(69, 16);
            this.lblPO.TabIndex = 0;
            this.lblPO.Text = "Post office";
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(160, 187);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(100, 22);
            this.txtPO.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(112, 241);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 293);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLocality);
            this.Controls.Add(this.txtHnum);
            this.Controls.Add(this.txtMNum);
            this.Controls.Add(this.txtHouseName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPO);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLocality);
            this.Controls.Add(this.lblHNum);
            this.Controls.Add(this.lblMNum);
            this.Controls.Add(this.lblHouseName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHouseName;
        private System.Windows.Forms.TextBox txtHouseName;
        private System.Windows.Forms.Label lblMNum;
        private System.Windows.Forms.TextBox txtMNum;
        private System.Windows.Forms.Label lblHNum;
        private System.Windows.Forms.TextBox txtHnum;
        private System.Windows.Forms.Label lblLocality;
        private System.Windows.Forms.TextBox txtLocality;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

