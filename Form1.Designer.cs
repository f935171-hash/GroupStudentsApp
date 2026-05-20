namespace GroupStudentsApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle dateCellStyle = new DataGridViewCellStyle();
        toolStrip1 = new ToolStrip();
        addToolStripButton = new ToolStripButton();
        studentsTable = new DataGridView();
        columnId = new DataGridViewTextBoxColumn();
        columnFirstName = new DataGridViewTextBoxColumn();
        columnLastName = new DataGridViewTextBoxColumn();
        columnDateOfBirth = new DataGridViewTextBoxColumn();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)studentsTable).BeginInit();
        SuspendLayout();

        toolStrip1.ImageScalingSize = new Size(20, 20);
        toolStrip1.Items.AddRange(new ToolStripItem[] { addToolStripButton });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(850, 27);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";

        addToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        addToolStripButton.Name = "addToolStripButton";
        addToolStripButton.Size = new Size(76, 24);
        addToolStripButton.Text = "Додати";
        addToolStripButton.ToolTipText = "Додати студента";
        addToolStripButton.Click += addToolStripButton_Click;

        studentsTable.AllowUserToAddRows = false;
        studentsTable.AllowUserToDeleteRows = false;
        studentsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        studentsTable.AutoGenerateColumns = false;
        studentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        studentsTable.Columns.AddRange(new DataGridViewColumn[] { columnId, columnFirstName, columnLastName, columnDateOfBirth });
        studentsTable.Location = new Point(12, 38);
        studentsTable.Name = "studentsTable";
        studentsTable.ReadOnly = true;
        studentsTable.RowHeadersWidth = 45;
        studentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        studentsTable.Size = new Size(826, 400);
        studentsTable.TabIndex = 1;

        columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        columnId.DataPropertyName = "Id";
        columnId.HeaderText = "ІД";
        columnId.Name = "columnId";
        columnId.ReadOnly = true;
        columnId.Width = 80;

        columnFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        columnFirstName.DataPropertyName = "FirstName";
        columnFirstName.HeaderText = "Ім'я";
        columnFirstName.MinimumWidth = 200;
        columnFirstName.Name = "columnFirstName";
        columnFirstName.ReadOnly = true;
        columnFirstName.Width = 200;

        columnLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        columnLastName.DataPropertyName = "LastName";
        columnLastName.HeaderText = "Прізвище";
        columnLastName.Name = "columnLastName";
        columnLastName.ReadOnly = true;

        dateCellStyle.Format = "dd.MM.yyyy";
        columnDateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        columnDateOfBirth.DataPropertyName = "DateOfBirth";
        columnDateOfBirth.DefaultCellStyle = dateCellStyle;
        columnDateOfBirth.HeaderText = "Дата народження";
        columnDateOfBirth.Name = "columnDateOfBirth";
        columnDateOfBirth.ReadOnly = true;
        columnDateOfBirth.Width = 150;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(850, 450);
        Controls.Add(studentsTable);
        Controls.Add(toolStrip1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Студенти ІТ-32";
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)studentsTable).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStrip1;
    private ToolStripButton addToolStripButton;
    private DataGridView studentsTable;
    private DataGridViewTextBoxColumn columnId;
    private DataGridViewTextBoxColumn columnFirstName;
    private DataGridViewTextBoxColumn columnLastName;
    private DataGridViewTextBoxColumn columnDateOfBirth;
}
