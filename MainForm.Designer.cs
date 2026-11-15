namespace Lab02.App
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvMeasurements = new DataGridView();
            panel1 = new Panel();
            lblMeasurementsMode = new Label();
            btnShowSuspicious = new Button();
            btnMeasurementDelete = new Button();
            btnMeasurementEdit = new Button();
            btnMeasurementAdd = new Button();
            btnMeasurementsRefresh = new Button();
            tabPage2 = new TabPage();
            dgvPoints = new DataGridView();
            panel2 = new Panel();
            btnPointDelete = new Button();
            btnPointEdit = new Button();
            btnPointAdd = new Button();
            btnPointsRefresh = new Button();
            tabPage3 = new TabPage();
            dgvInstruments = new DataGridView();
            panel3 = new Panel();
            btnInstrumentDelete = new Button();
            btnInstrumentEdit = new Button();
            btnInstrumentAdd = new Button();
            btnInstrumentsRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoints).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInstruments).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1182, 653);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(250, 247, 240);
            tabPage1.Controls.Add(dgvMeasurements);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1174, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Виміри";
            // 
            // dgvMeasurements
            // 
            dgvMeasurements.AllowUserToAddRows = false;
            dgvMeasurements.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 238, 226);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMeasurements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMeasurements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMeasurements.BackgroundColor = Color.FromArgb(250, 247, 240);
            dgvMeasurements.BorderStyle = BorderStyle.None;
            dgvMeasurements.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMeasurements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMeasurements.ColumnHeadersHeight = 36;
            dgvMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMeasurements.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMeasurements.Dock = DockStyle.Fill;
            dgvMeasurements.EnableHeadersVisualStyles = false;
            dgvMeasurements.GridColor = Color.FromArgb(226, 220, 205);
            dgvMeasurements.Location = new Point(3, 53);
            dgvMeasurements.MultiSelect = false;
            dgvMeasurements.Name = "dgvMeasurements";
            dgvMeasurements.ReadOnly = true;
            dgvMeasurements.RowHeadersVisible = false;
            dgvMeasurements.RowHeadersWidth = 51;
            dgvMeasurements.RowTemplate.Height = 28;
            dgvMeasurements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeasurements.Size = new Size(1168, 564);
            dgvMeasurements.TabIndex = 1;
            dgvMeasurements.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 70, 83);
            panel1.Controls.Add(lblMeasurementsMode);
            panel1.Controls.Add(btnShowSuspicious);
            panel1.Controls.Add(btnMeasurementDelete);
            panel1.Controls.Add(btnMeasurementEdit);
            panel1.Controls.Add(btnMeasurementAdd);
            panel1.Controls.Add(btnMeasurementsRefresh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 50);
            panel1.TabIndex = 0;
            // 
            // lblMeasurementsMode
            // 
            lblMeasurementsMode.AutoSize = true;
            lblMeasurementsMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMeasurementsMode.ForeColor = Color.FromArgb(233, 196, 106);
            lblMeasurementsMode.Location = new Point(576, 14);
            lblMeasurementsMode.Name = "lblMeasurementsMode";
            lblMeasurementsMode.Size = new Size(161, 20);
            lblMeasurementsMode.TabIndex = 5;
            lblMeasurementsMode.Text = "Показано: усі виміри";
            // 
            // btnShowSuspicious
            // 
            btnShowSuspicious.Location = new Point(406, 10);
            btnShowSuspicious.Name = "btnShowSuspicious";
            btnShowSuspicious.Size = new Size(150, 29);
            btnShowSuspicious.TabIndex = 4;
            btnShowSuspicious.Text = "Підозрілі виміри";
            btnShowSuspicious.UseVisualStyleBackColor = true;
            btnShowSuspicious.Click += btnShowSuspicious_Click;
            // 
            // btnMeasurementDelete
            // 
            btnMeasurementDelete.Location = new Point(306, 10);
            btnMeasurementDelete.Name = "btnMeasurementDelete";
            btnMeasurementDelete.Size = new Size(94, 29);
            btnMeasurementDelete.TabIndex = 3;
            btnMeasurementDelete.Text = "Видалити";
            btnMeasurementDelete.UseVisualStyleBackColor = true;
            btnMeasurementDelete.Click += btnMeasurementDelete_Click;
            // 
            // btnMeasurementEdit
            // 
            btnMeasurementEdit.Location = new Point(206, 10);
            btnMeasurementEdit.Name = "btnMeasurementEdit";
            btnMeasurementEdit.Size = new Size(94, 29);
            btnMeasurementEdit.TabIndex = 2;
            btnMeasurementEdit.Text = "Редагувати";
            btnMeasurementEdit.UseVisualStyleBackColor = true;
            btnMeasurementEdit.Click += btnMeasurementEdit_Click;
            // 
            // btnMeasurementAdd
            // 
            btnMeasurementAdd.Location = new Point(106, 10);
            btnMeasurementAdd.Name = "btnMeasurementAdd";
            btnMeasurementAdd.Size = new Size(94, 29);
            btnMeasurementAdd.TabIndex = 1;
            btnMeasurementAdd.Text = "Додати";
            btnMeasurementAdd.UseVisualStyleBackColor = true;
            btnMeasurementAdd.Click += btnMeasurementAdd_Click;
            // 
            // btnMeasurementsRefresh
            // 
            btnMeasurementsRefresh.Location = new Point(6, 10);
            btnMeasurementsRefresh.Name = "btnMeasurementsRefresh";
            btnMeasurementsRefresh.Size = new Size(94, 29);
            btnMeasurementsRefresh.TabIndex = 0;
            btnMeasurementsRefresh.Text = "Оновити";
            btnMeasurementsRefresh.UseVisualStyleBackColor = true;
            btnMeasurementsRefresh.Click += btnMeasurementsRefresh_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(250, 247, 240);
            tabPage2.Controls.Add(dgvPoints);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1174, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Точки спостереження";
            // 
            // dgvPoints
            // 
            dgvPoints.AllowUserToAddRows = false;
            dgvPoints.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 238, 226);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvPoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPoints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPoints.BackgroundColor = Color.FromArgb(250, 247, 240);
            dgvPoints.BorderStyle = BorderStyle.None;
            dgvPoints.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPoints.ColumnHeadersHeight = 36;
            dgvPoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPoints.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPoints.Dock = DockStyle.Fill;
            dgvPoints.EnableHeadersVisualStyles = false;
            dgvPoints.GridColor = Color.FromArgb(226, 220, 205);
            dgvPoints.Location = new Point(3, 53);
            dgvPoints.MultiSelect = false;
            dgvPoints.Name = "dgvPoints";
            dgvPoints.ReadOnly = true;
            dgvPoints.RowHeadersVisible = false;
            dgvPoints.RowHeadersWidth = 51;
            dgvPoints.RowTemplate.Height = 28;
            dgvPoints.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoints.Size = new Size(1168, 564);
            dgvPoints.TabIndex = 1;
            dgvPoints.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 70, 83);
            panel2.Controls.Add(btnPointDelete);
            panel2.Controls.Add(btnPointEdit);
            panel2.Controls.Add(btnPointAdd);
            panel2.Controls.Add(btnPointsRefresh);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1168, 50);
            panel2.TabIndex = 0;
            // 
            // btnPointDelete
            // 
            btnPointDelete.Location = new Point(306, 10);
            btnPointDelete.Name = "btnPointDelete";
            btnPointDelete.Size = new Size(94, 29);
            btnPointDelete.TabIndex = 3;
            btnPointDelete.Text = "Видалити";
            btnPointDelete.UseVisualStyleBackColor = true;
            btnPointDelete.Click += btnPointDelete_Click;
            // 
            // btnPointEdit
            // 
            btnPointEdit.Location = new Point(206, 10);
            btnPointEdit.Name = "btnPointEdit";
            btnPointEdit.Size = new Size(94, 29);
            btnPointEdit.TabIndex = 2;
            btnPointEdit.Text = "Редагувати";
            btnPointEdit.UseVisualStyleBackColor = true;
            btnPointEdit.Click += btnPointEdit_Click;
            // 
            // btnPointAdd
            // 
            btnPointAdd.Location = new Point(106, 10);
            btnPointAdd.Name = "btnPointAdd";
            btnPointAdd.Size = new Size(94, 29);
            btnPointAdd.TabIndex = 1;
            btnPointAdd.Text = "Додати";
            btnPointAdd.UseVisualStyleBackColor = true;
            btnPointAdd.Click += btnPointAdd_Click;
            // 
            // btnPointsRefresh
            // 
            btnPointsRefresh.Location = new Point(6, 10);
            btnPointsRefresh.Name = "btnPointsRefresh";
            btnPointsRefresh.Size = new Size(94, 29);
            btnPointsRefresh.TabIndex = 0;
            btnPointsRefresh.Text = "Оновити";
            btnPointsRefresh.UseVisualStyleBackColor = true;
            btnPointsRefresh.Click += btnPointsRefresh_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(250, 247, 240);
            tabPage3.Controls.Add(dgvInstruments);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1174, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Прилади";
            // 
            // dgvInstruments
            // 
            dgvInstruments.AllowUserToAddRows = false;
            dgvInstruments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(243, 238, 226);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dgvInstruments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvInstruments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInstruments.BackgroundColor = Color.FromArgb(250, 247, 240);
            dgvInstruments.BorderStyle = BorderStyle.None;
            dgvInstruments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(38, 70, 83);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvInstruments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvInstruments.ColumnHeadersHeight = 36;
            dgvInstruments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(42, 157, 143);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvInstruments.DefaultCellStyle = dataGridViewCellStyle9;
            dgvInstruments.Dock = DockStyle.Fill;
            dgvInstruments.EnableHeadersVisualStyles = false;
            dgvInstruments.GridColor = Color.FromArgb(226, 220, 205);
            dgvInstruments.Location = new Point(3, 53);
            dgvInstruments.MultiSelect = false;
            dgvInstruments.Name = "dgvInstruments";
            dgvInstruments.ReadOnly = true;
            dgvInstruments.RowHeadersVisible = false;
            dgvInstruments.RowHeadersWidth = 51;
            dgvInstruments.RowTemplate.Height = 28;
            dgvInstruments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstruments.Size = new Size(1168, 564);
            dgvInstruments.TabIndex = 1;
            dgvInstruments.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 70, 83);
            panel3.Controls.Add(btnInstrumentDelete);
            panel3.Controls.Add(btnInstrumentEdit);
            panel3.Controls.Add(btnInstrumentAdd);
            panel3.Controls.Add(btnInstrumentsRefresh);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1168, 50);
            panel3.TabIndex = 0;
            // 
            // btnInstrumentDelete
            // 
            btnInstrumentDelete.Location = new Point(306, 10);
            btnInstrumentDelete.Name = "btnInstrumentDelete";
            btnInstrumentDelete.Size = new Size(94, 29);
            btnInstrumentDelete.TabIndex = 3;
            btnInstrumentDelete.Text = "Видалити";
            btnInstrumentDelete.UseVisualStyleBackColor = true;
            btnInstrumentDelete.Click += btnInstrumentDelete_Click;
            // 
            // btnInstrumentEdit
            // 
            btnInstrumentEdit.Location = new Point(206, 10);
            btnInstrumentEdit.Name = "btnInstrumentEdit";
            btnInstrumentEdit.Size = new Size(94, 29);
            btnInstrumentEdit.TabIndex = 2;
            btnInstrumentEdit.Text = "Редагувати";
            btnInstrumentEdit.UseVisualStyleBackColor = true;
            btnInstrumentEdit.Click += btnInstrumentEdit_Click;
            // 
            // btnInstrumentAdd
            // 
            btnInstrumentAdd.Location = new Point(106, 10);
            btnInstrumentAdd.Name = "btnInstrumentAdd";
            btnInstrumentAdd.Size = new Size(94, 29);
            btnInstrumentAdd.TabIndex = 1;
            btnInstrumentAdd.Text = "Додати";
            btnInstrumentAdd.UseVisualStyleBackColor = true;
            btnInstrumentAdd.Click += btnInstrumentAdd_Click;
            // 
            // btnInstrumentsRefresh
            // 
            btnInstrumentsRefresh.Location = new Point(6, 10);
            btnInstrumentsRefresh.Name = "btnInstrumentsRefresh";
            btnInstrumentsRefresh.Size = new Size(94, 29);
            btnInstrumentsRefresh.TabIndex = 0;
            btnInstrumentsRefresh.Text = "Оновити";
            btnInstrumentsRefresh.UseVisualStyleBackColor = true;
            btnInstrumentsRefresh.Click += btnInstrumentsRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 240);
            ClientSize = new Size(1182, 653);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Екологічна станція";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPoints).EndInit();
            panel2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInstruments).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Button btnMeasurementsRefresh;
        private Button btnMeasurementAdd;
        private Button btnMeasurementEdit;
        private Button btnMeasurementDelete;
        private Button btnShowSuspicious;
        private Label lblMeasurementsMode;
        private DataGridView dgvMeasurements;
        private TabPage tabPage2;
        private Panel panel2;
        private Button btnPointsRefresh;
        private Button btnPointAdd;
        private Button btnPointEdit;
        private Button btnPointDelete;
        private DataGridView dgvPoints;
        private TabPage tabPage3;
        private Panel panel3;
        private Button btnInstrumentsRefresh;
        private Button btnInstrumentAdd;
        private Button btnInstrumentEdit;
        private Button btnInstrumentDelete;
        private DataGridView dgvInstruments;
    }
}

