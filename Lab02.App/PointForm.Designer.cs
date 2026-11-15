namespace Lab02.App
{
    partial class PointForm
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
            label1 = new Label();
            cmbLocation = new ComboBox();
            label2 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            cmbPurpose = new ComboBox();
            label4 = new Label();
            numPlannedLatitude = new NumericUpDown();
            label5 = new Label();
            numPlannedLongitude = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numPlannedLatitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlannedLongitude).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(38, 70, 83);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Місцевість:";
            // 
            // cmbLocation
            // 
            cmbLocation.DisplayMember = "Name";
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(160, 20);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(250, 28);
            cmbLocation.TabIndex = 1;
            cmbLocation.ValueMember = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(38, 70, 83);
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Код точки:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(160, 55);
            txtCode.MaxLength = 20;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(250, 27);
            txtCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(38, 70, 83);
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "Призначення:";
            // 
            // cmbPurpose
            // 
            cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Location = new Point(160, 90);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(250, 28);
            cmbPurpose.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(38, 70, 83);
            label4.Location = new Point(20, 125);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 6;
            label4.Text = "Планова широта:";
            // 
            // numPlannedLatitude
            // 
            numPlannedLatitude.DecimalPlaces = 6;
            numPlannedLatitude.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numPlannedLatitude.Location = new Point(160, 125);
            numPlannedLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            numPlannedLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            numPlannedLatitude.Name = "numPlannedLatitude";
            numPlannedLatitude.Size = new Size(250, 27);
            numPlannedLatitude.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(38, 70, 83);
            label5.Location = new Point(20, 160);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 8;
            label5.Text = "Планова довгота:";
            // 
            // numPlannedLongitude
            // 
            numPlannedLongitude.DecimalPlaces = 6;
            numPlannedLongitude.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numPlannedLongitude.Location = new Point(160, 160);
            numPlannedLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numPlannedLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            numPlannedLongitude.Name = "numPlannedLongitude";
            numPlannedLongitude.Size = new Size(250, 27);
            numPlannedLongitude.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(265, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PointForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 240);
            CancelButton = btnCancel;
            ClientSize = new Size(442, 268);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numPlannedLongitude);
            Controls.Add(label5);
            Controls.Add(numPlannedLatitude);
            Controls.Add(label4);
            Controls.Add(cmbPurpose);
            Controls.Add(label3);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(cmbLocation);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PointForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Точка спостереження";
            Load += PointForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPlannedLatitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlannedLongitude).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLocation;
        private Label label2;
        private TextBox txtCode;
        private Label label3;
        private ComboBox cmbPurpose;
        private Label label4;
        private NumericUpDown numPlannedLatitude;
        private Label label5;
        private NumericUpDown numPlannedLongitude;
        private Button btnSave;
        private Button btnCancel;
    }
}

