namespace WindowsFormsApp1.Forms
{
    partial class SubjectForm
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
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.numUnits = new System.Windows.Forms.NumericUpDown();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInputs
            // 
            this.pnlInputs.Controls.Add(this.btnClear);
            this.pnlInputs.Controls.Add(this.btnDelete);
            this.pnlInputs.Controls.Add(this.btnUpdate);
            this.pnlInputs.Controls.Add(this.btnAdd);
            this.pnlInputs.Controls.Add(this.txtProgram);
            this.pnlInputs.Controls.Add(this.lblProgram);
            this.pnlInputs.Controls.Add(this.numUnits);
            this.pnlInputs.Controls.Add(this.lblUnits);
            this.pnlInputs.Controls.Add(this.txtTitle);
            this.pnlInputs.Controls.Add(this.lblTitle);
            this.pnlInputs.Controls.Add(this.txtCode);
            this.pnlInputs.Controls.Add(this.lblCode);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInputs.Location = new System.Drawing.Point(0, 0);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(330, 450);
            this.pnlInputs.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(141, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(141, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(129, 195);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(161, 22);
            this.txtProgram.TabIndex = 7;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(12, 193);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(76, 23);
            this.lblProgram.TabIndex = 6;
            this.lblProgram.Text = "Program";
            // 
            // numUnits
            // 
            this.numUnits.Location = new System.Drawing.Point(129, 142);
            this.numUnits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(120, 22);
            this.numUnits.TabIndex = 5;
            this.numUnits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(12, 139);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(49, 23);
            this.lblUnits.TabIndex = 4;
            this.lblUnits.Text = "Units";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(129, 86);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(129, 38);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(111, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Subject Code";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvSubjects);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(330, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(436, 450);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjects.Location = new System.Drawing.Point(0, 0);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(436, 450);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlInputs);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.NumericUpDown numUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}