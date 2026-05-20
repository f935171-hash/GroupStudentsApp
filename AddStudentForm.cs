namespace GroupStudentsApp;

public partial class AddStudentForm : Form
{
    public Student SavedValue { get; private set; }

    public AddStudentForm()
    {
        InitializeComponent();
        firstNameTextBox.Select();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        SavedValue = new Student
        {
            FirstName = firstNameTextBox.Text.Trim(),
            LastName = lastNameTextBox.Text.Trim(),
            DateOfBirth = dateOfBirthPicker.Value.Date
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
