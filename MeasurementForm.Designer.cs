namespace Lab02.App
{
    partial class MeasurementForm
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
            cmbPoint = new ComboBox();
            label2 = new Label();
            cmbInstrument = new ComboBox();
            label3 = new Label();
            cmbParticipant = new ComboBox();
            label4 = new Label();
            dtpMeasuredAt = new DateTimePicker();
            label5 = new Label();
            txtParameter = new TextBox();
            label6 = new Label();
            numValue = new NumericUpDown();
            label7 = new Label();
            txtUnit = new TextBox();
            chkHasDepth = new CheckBox();
            numDepth = new NumericUpDown();
            chkIsControl = new CheckBox();
            label8 = new Label();
            cmbStatus = new ComboBox();
            chkRelocated = new CheckBox();
            label9 = new Label();
            numActualLatitude = new NumericUpDown();
            label10 = new Label();
            numActualLongitude = new NumericUpDown();
            label11 = new Label();
            txtRelocationReason = new TextBox();
            label12 = new Label();
            txtNote = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numActualLatitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numActualLongitude).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(38, 70, 83);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Точка:";
            // 
            // cmbPoint
            // 
            cmbPoint.DisplayMember = "Code";
            cmbPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPoint.FormattingEnabled = true;
            cmbPoint.Location = new Point(200, 20);
            cmbPoint.Name = "cmbPoint";
            cmbPoint.Size = new Size(280, 28);
            cmbPoint.TabIndex = 1;
            cmbPoint.ValueMember = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(38, 70, 83);
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Прилад:";
            // 
            // cmbInstrument
            // 
            cmbInstrument.DisplayMember = "Name";
            cmbInstrument.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInstrument.FormattingEnabled = true;
            cmbInstrument.Location = new Point(200, 55);
            cmbInstrument.Name = "cmbInstrument";
            cmbInstrument.Size = new Size(280, 28);
            cmbInstrument.TabIndex = 3;
            cmbInstrument.ValueMember = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(38, 70, 83);
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Учасник:";
            // 
            // cmbParticipant
            // 
            cmbParticipant.DisplayMember = "FullName";
            cmbParticipant.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParticipant.FormattingEnabled = true;
            cmbParticipant.Location = new Point(200, 90);
            cmbParticipant.Name = "cmbParticipant";
            cmbParticipant.Size = new Size(280, 28);
            cmbParticipant.TabIndex = 5;
            cmbParticipant.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(38, 70, 83);
            label4.Location = new Point(20, 125);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Дата і час:";
            // 
            // dtpMeasuredAt
            // 
            dtpMeasuredAt.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpMeasuredAt.Format = DateTimePickerFormat.Custom;
            dtpMeasuredAt.Location = new Point(200, 125);
            dtpMeasuredAt.Name = "dtpMeasuredAt";
            dtpMeasuredAt.Size = new Size(280, 27);
            dtpMeasuredAt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(38, 70, 83);
            label5.Location = new Point(20, 160);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 8;
            label5.Text = "Параметр:";
            // 
            // txtParameter
            // 
            txtParameter.Location = new Point(200, 160);
            txtParameter.MaxLength = 50;
            txtParameter.Name = "txtParameter";
            txtParameter.Size = new Size(280, 27);
            txtParameter.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(38, 70, 83);
            label6.Location = new Point(20, 195);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "Значення:";
            // 
            // numValue
            // 
            numValue.DecimalPlaces = 3;
            numValue.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numValue.Location = new Point(200, 195);
            numValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValue.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numValue.Name = "numValue";
            numValue.Size = new Size(280, 27);
            numValue.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(38, 70, 83);
            label7.Location = new Point(20, 230);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 12;
            label7.Text = "Одиниця виміру:";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(200, 230);
            txtUnit.MaxLength = 20;
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(280, 27);
            txtUnit.TabIndex = 13;
            // 
            // chkHasDepth
            // 
            chkHasDepth.AutoSize = true;
            chkHasDepth.ForeColor = Color.FromArgb(38, 70, 83);
            chkHasDepth.Location = new Point(20, 265);
            chkHasDepth.Name = "chkHasDepth";
            chkHasDepth.Size = new Size(111, 24);
            chkHasDepth.TabIndex = 14;
            chkHasDepth.Text = "Глибина, м:";
            chkHasDepth.UseVisualStyleBackColor = true;
            chkHasDepth.CheckedChanged += chkHasDepth_CheckedChanged;
            // 
            // numDepth
            // 
            numDepth.DecimalPlaces = 2;
            numDepth.Enabled = false;
            numDepth.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numDepth.Location = new Point(200, 265);
            numDepth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDepth.Name = "numDepth";
            numDepth.Size = new Size(150, 27);
            numDepth.TabIndex = 15;
            // 
            // chkIsControl
            // 
            chkIsControl.AutoSize = true;
            chkIsControl.ForeColor = Color.FromArgb(38, 70, 83);
            chkIsControl.Location = new Point(200, 300);
            chkIsControl.Name = "chkIsControl";
            chkIsControl.Size = new Size(169, 24);
            chkIsControl.TabIndex = 16;
            chkIsControl.Text = "Контрольний дубль";
            chkIsControl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(38, 70, 83);
            label8.Location = new Point(20, 335);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 17;
            label8.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(200, 335);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(280, 28);
            cmbStatus.TabIndex = 18;
            // 
            // chkRelocated
            // 
            chkRelocated.AutoSize = true;
            chkRelocated.ForeColor = Color.FromArgb(38, 70, 83);
            chkRelocated.Location = new Point(20, 370);
            chkRelocated.Name = "chkRelocated";
            chkRelocated.Size = new Size(246, 24);
            chkRelocated.TabIndex = 19;
            chkRelocated.Text = "Датчик тимчасово перенесено";
            chkRelocated.UseVisualStyleBackColor = true;
            chkRelocated.CheckedChanged += chkRelocated_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(38, 70, 83);
            label9.Location = new Point(20, 405);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 20;
            label9.Text = "Фактична широта:";
            // 
            // numActualLatitude
            // 
            numActualLatitude.DecimalPlaces = 6;
            numActualLatitude.Enabled = false;
            numActualLatitude.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numActualLatitude.Location = new Point(200, 405);
            numActualLatitude.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            numActualLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            numActualLatitude.Name = "numActualLatitude";
            numActualLatitude.Size = new Size(280, 27);
            numActualLatitude.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(38, 70, 83);
            label10.Location = new Point(20, 440);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 22;
            label10.Text = "Фактична довгота:";
            // 
            // numActualLongitude
            // 
            numActualLongitude.DecimalPlaces = 6;
            numActualLongitude.Enabled = false;
            numActualLongitude.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            numActualLongitude.Location = new Point(200, 440);
            numActualLongitude.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numActualLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            numActualLongitude.Name = "numActualLongitude";
            numActualLongitude.Size = new Size(280, 27);
            numActualLongitude.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(38, 70, 83);
            label11.Location = new Point(20, 475);
            label11.Name = "label11";
            label11.Size = new Size(171, 20);
            label11.TabIndex = 24;
            label11.Text = "Причина перенесення:";
            // 
            // txtRelocationReason
            // 
            txtRelocationReason.Enabled = false;
            txtRelocationReason.Location = new Point(200, 475);
            txtRelocationReason.MaxLength = 200;
            txtRelocationReason.Name = "txtRelocationReason";
            txtRelocationReason.Size = new Size(280, 27);
            txtRelocationReason.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(38, 70, 83);
            label12.Location = new Point(20, 510);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 26;
            label12.Text = "Примітка:";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(200, 510);
            txtNote.MaxLength = 500;
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(280, 60);
            txtNote.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 593);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(305, 593);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // MeasurementForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 240);
            CancelButton = btnCancel;
            ClientSize = new Size(512, 651);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(label12);
            Controls.Add(txtRelocationReason);
            Controls.Add(label11);
            Controls.Add(numActualLongitude);
            Controls.Add(label10);
            Controls.Add(numActualLatitude);
            Controls.Add(label9);
            Controls.Add(chkRelocated);
            Controls.Add(cmbStatus);
            Controls.Add(label8);
            Controls.Add(chkIsControl);
            Controls.Add(numDepth);
            Controls.Add(chkHasDepth);
            Controls.Add(txtUnit);
            Controls.Add(label7);
            Controls.Add(numValue);
            Controls.Add(label6);
            Controls.Add(txtParameter);
            Controls.Add(label5);
            Controls.Add(dtpMeasuredAt);
            Controls.Add(label4);
            Controls.Add(cmbParticipant);
            Controls.Add(label3);
            Controls.Add(cmbInstrument);
            Controls.Add(label2);
            Controls.Add(cmbPoint);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MeasurementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вимір";
            Load += MeasurementForm_Load;
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numActualLatitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)numActualLongitude).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPoint;
        private Label label2;
        private ComboBox cmbInstrument;
        private Label label3;
        private ComboBox cmbParticipant;
        private Label label4;
        private DateTimePicker dtpMeasuredAt;
        private Label label5;
        private TextBox txtParameter;
        private Label label6;
        private NumericUpDown numValue;
        private Label label7;
        private TextBox txtUnit;
        private CheckBox chkHasDepth;
        private NumericUpDown numDepth;
        private CheckBox chkIsControl;
        private Label label8;
        private ComboBox cmbStatus;
        private CheckBox chkRelocated;
        private Label label9;
        private NumericUpDown numActualLatitude;
        private Label label10;
        private NumericUpDown numActualLongitude;
        private Label label11;
        private TextBox txtRelocationReason;
        private Label label12;
        private TextBox txtNote;
        private Button btnSave;
        private Button btnCancel;
    }
}

