namespace GroupStudentsApp;

partial class AddStudentForm
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
        firstNameLabel = new Label();
        lastNameLabel = new Label();
        dateOfBirthLabel = new Label();
        firstNameTextBox = new TextBox();
        lastNameTextBox = new TextBox();
        dateOfBirthPicker = new DateTimePicker();
        saveButton = new Button();
        cancelButton = new Button();
        SuspendLayout();

        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(20, 23);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(32, 15);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "Ім'я";

        firstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        firstNameTextBox.Location = new Point(140, 20);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new Size(250, 23);
        firstNameTextBox.TabIndex = 1;

        lastNameLabel.AutoSize = true;
        lastNameLabel.Location = new Point(20, 62);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(59, 15);
        lastNameLabel.TabIndex = 2;
        lastNameLabel.Text = "Прізвище";

        lastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lastNameTextBox.Location = new Point(140, 59);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new Size(250, 23);
        lastNameTextBox.TabIndex = 3;

        dateOfBirthLabel.AutoSize = true;
        dateOfBirthLabel.Location = new Point(20, 101);
        dateOfBirthLabel.Name = "dateOfBirthLabel";
        dateOfBirthLabel.Size = new Size(103, 15);
        dateOfBirthLabel.TabIndex = 4;
        dateOfBirthLabel.Text = "Дата народження";

        dateOfBirthPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dateOfBirthPicker.Format = DateTimePickerFormat.Short;
        dateOfBirthPicker.Location = new Point(140, 98);
        dateOfBirthPicker.Name = "dateOfBirthPicker";
        dateOfBirthPicker.Size = new Size(250, 23);
        dateOfBirthPicker.TabIndex = 5;

        saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        saveButton.Location = new Point(214, 155);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(85, 30);
        saveButton.TabIndex = 6;
        saveButton.Text = "Зберегти";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;

        cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cancelButton.Location = new Point(305, 155);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(85, 30);
        cancelButton.TabIndex = 7;
        cancelButton.Text = "Скасувати";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;

        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(410, 205);
        Controls.Add(cancelButton);
        Controls.Add(saveButton);
        Controls.Add(dateOfBirthPicker);
        Controls.Add(dateOfBirthLabel);
        Controls.Add(lastNameTextBox);
        Controls.Add(lastNameLabel);
        Controls.Add(firstNameTextBox);
        Controls.Add(firstNameLabel);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MaximumSize = new Size(1200, 244);
        MinimizeBox = false;
        MinimumSize = new Size(410, 244);
        Name = "AddStudentForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Зареєструвати студента";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label firstNameLabel;
    private Label lastNameLabel;
    private Label dateOfBirthLabel;
    private TextBox firstNameTextBox;
    private TextBox lastNameTextBox;
    private DateTimePicker dateOfBirthPicker;
    private Button saveButton;
    private Button cancelButton;
}
