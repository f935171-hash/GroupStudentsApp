using System.ComponentModel;
using System.Drawing;

namespace GroupStudentsApp;

public partial class Form1 : Form
{
    private BindingList<Student> students;

    public Form1()
    {
        InitializeComponent();
        addToolStripButton.Image = CreateAddIcon();
        LoadStudents();
        studentsTable.DataSource = students;
    }

    private void LoadStudents()
    {
        students = new BindingList<Student>
        {
            new Student { Id = 1, FirstName = "Максим", LastName = "Белощук", DateOfBirth = new DateTime(2005, 1, 10) },
            new Student { Id = 2, FirstName = "Віталій", LastName = "Бондарчук", DateOfBirth = new DateTime(2005, 2, 12) },
            new Student { Id = 3, FirstName = "Олександр", LastName = "Вартосюк", DateOfBirth = new DateTime(2005, 3, 14) },
            new Student { Id = 4, FirstName = "Олександр", LastName = "Данилюк", DateOfBirth = new DateTime(2005, 4, 16) },
            new Student { Id = 5, FirstName = "Віктор", LastName = "Дейнека", DateOfBirth = new DateTime(2005, 5, 18) },
            new Student { Id = 6, FirstName = "Артем", LastName = "Зайнєр", DateOfBirth = new DateTime(2005, 6, 20) },
            new Student { Id = 7, FirstName = "Андрій", LastName = "Іванюк", DateOfBirth = new DateTime(2005, 7, 22) },
            new Student { Id = 8, FirstName = "Андрій", LastName = "Колбасюк", DateOfBirth = new DateTime(2005, 8, 24) },
            new Student { Id = 9, FirstName = "Михайло", LastName = "Кошмак", DateOfBirth = new DateTime(2005, 9, 26) },
            new Student { Id = 10, FirstName = "Святослав", LastName = "Крисюк", DateOfBirth = new DateTime(2005, 10, 28) },
            new Student { Id = 11, FirstName = "Дмитро", LastName = "Крупич", DateOfBirth = new DateTime(2005, 11, 2) },
            new Student { Id = 12, FirstName = "Владислав", LastName = "Мгалоблішвілі", DateOfBirth = new DateTime(2005, 12, 4) },
            new Student { Id = 13, FirstName = "Ярослав", LastName = "Мороченець", DateOfBirth = new DateTime(2004, 1, 6) },
            new Student { Id = 14, FirstName = "Вадим", LastName = "Мошкун", DateOfBirth = new DateTime(2004, 2, 8) },
            new Student { Id = 15, FirstName = "Марія", LastName = "Овдійчук", DateOfBirth = new DateTime(2004, 3, 10) },
            new Student { Id = 16, FirstName = "Олег", LastName = "Павлюк", DateOfBirth = new DateTime(2004, 4, 12) },
            new Student { Id = 17, FirstName = "Богдан", LastName = "Панасюк", DateOfBirth = new DateTime(2004, 5, 14) },
            new Student { Id = 18, FirstName = "Віталій", LastName = "Поліщук", DateOfBirth = new DateTime(2004, 6, 16) },
            new Student { Id = 19, FirstName = "Вадим", LastName = "Поліщук", DateOfBirth = new DateTime(2004, 7, 18) },
            new Student { Id = 20, FirstName = "Руслан", LastName = "Романюк", DateOfBirth = new DateTime(2004, 8, 20) },
            new Student { Id = 21, FirstName = "Дмитро", LastName = "Сачук", DateOfBirth = new DateTime(2004, 9, 22) },
            new Student { Id = 22, FirstName = "Олександр", LastName = "Скаковський", DateOfBirth = new DateTime(2004, 10, 24) },
            new Student { Id = 23, FirstName = "Дмитро", LastName = "Стеблюк", DateOfBirth = new DateTime(2004, 11, 26) },
            new Student { Id = 24, FirstName = "Олександра", LastName = "Стернійчук", DateOfBirth = new DateTime(2004, 12, 28) },
            new Student { Id = 25, FirstName = "Андрій", LastName = "Строїнський", DateOfBirth = new DateTime(2005, 1, 30) },
            new Student { Id = 26, FirstName = "Вадим", LastName = "Терентій", DateOfBirth = new DateTime(2005, 2, 3) },
            new Student { Id = 27, FirstName = "Олександр", LastName = "Ткач", DateOfBirth = new DateTime(2005, 3, 5) },
            new Student { Id = 28, FirstName = "Юрій", LastName = "Царук", DateOfBirth = new DateTime(2005, 4, 7) },
            new Student { Id = 29, FirstName = "Юрій", LastName = "Шевчук", DateOfBirth = new DateTime(2005, 5, 9) }
        };
    }

    private void addToolStripButton_Click(object sender, EventArgs e)
    {
        AddStudentForm form = new AddStudentForm();

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            Student student = form.SavedValue;
            student.Id = GetNextId();
            students.Add(student);
        }
    }

    private int GetNextId()
    {
        if (students.Count == 0)
        {
            return 1;
        }

        return students.Max(student => student.Id) + 1;
    }

    private Bitmap CreateAddIcon()
    {
        Bitmap image = new Bitmap(16, 16);

        using (Graphics graphics = Graphics.FromImage(image))
        using (Pen pen = new Pen(Color.Green, 3))
        {
            graphics.Clear(Color.Transparent);
            graphics.DrawLine(pen, 8, 3, 8, 13);
            graphics.DrawLine(pen, 3, 8, 13, 8);
        }

        return image;
    }
}
