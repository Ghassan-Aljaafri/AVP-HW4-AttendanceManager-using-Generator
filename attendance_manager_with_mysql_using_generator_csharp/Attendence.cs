using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_manager_with_mysql_using_generator_csharp
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void attendance_managementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendance_managementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teacher_attendanceDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.teacher_attendanceDataSet.courses);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.teacher_attendanceDataSet.rooms);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.teacher_attendanceDataSet.teachers);
            // TODO: This line of code loads data into the 'teacher_attendanceDataSet.attendance_management' table. You can move, or remove it, as needed.
            this.attendance_managementTableAdapter.Fill(this.teacher_attendanceDataSet.attendance_management);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string date = dateDTP.Text;
            string start = startTP.Text;
            string leave = leaveTP.Text;
            int teacher = Convert.ToInt32(teacherCombo.SelectedValue);
            int course = Convert.ToInt32(courseCombo.SelectedValue);
            int room = Convert.ToInt32(roomCombo.SelectedValue);
            string comment = commentNameTextBox.Text;
            attendance_managementTableAdapter.Insert(date, start,leave, teacher, room, course, comment);
            this.attendance_managementTableAdapter.Fill(this.teacher_attendanceDataSet.attendance_management);
        }

        private void ShowTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.Show();
            this.teachersTableAdapter.Fill(this.teacher_attendanceDataSet.teachers);
        }

        private void ShowRoom_Click(object sender, EventArgs e)
        {
            RoomForm room = new RoomForm();
            room.Show();
            this.roomsTableAdapter.Fill(this.teacher_attendanceDataSet.rooms);

        }

        private void ShowCourse_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.Show();
            this.coursesTableAdapter.Fill(this.teacher_attendanceDataSet.courses);
        }

        private void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
