namespace Lab02.App
{
    partial class InstrumentForm
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
            txtName = new TextBox();
            label2 = new Label();
            cmbType = new ComboBox();
            label3 = new Label();
            txtSerialNumber = new TextBox();
            label4 = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(38, 70, 83);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 20);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(38, 70, 83);
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Тип:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(160, 55);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 28);
            cmbType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(38, 70, 83);
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 4;
            label3.Text = "Серійний номер:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(160, 90);
            txtSerialNumber.MaxLength = 50;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(250, 27);
            txtSerialNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(38, 70, 83);
            label4.Location = new Point(20, 125);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(160, 125);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 28);
            cmbStatus.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 175);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(265, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // InstrumentForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 240);
            CancelButton = btnCancel;
            ClientSize = new Size(442, 233);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(label4);
            Controls.Add(txtSerialNumber);
            Controls.Add(label3);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InstrumentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Прилад";
            Load += InstrumentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private TextBox txtSerialNumber;
        private Label label4;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}


