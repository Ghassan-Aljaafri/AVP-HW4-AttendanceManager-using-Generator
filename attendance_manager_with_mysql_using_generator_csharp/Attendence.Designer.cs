
using attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters;

namespace attendance_manager_with_mysql_using_generator_csharp
{
    partial class Attendence
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.teacher_attendanceDataSet = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSet();
            this.attendance_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_managementTableAdapter = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.attendance_managementTableAdapter();
            this.tableAdapterManager = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.TableAdapterManager();
            this.attendance_managementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.attendance_managementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendanceDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTP = new System.Windows.Forms.DateTimePicker();
            this.startTP = new System.Windows.Forms.DateTimePicker();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.courseTableBtn = new System.Windows.Forms.Button();
            this.roomTableBtn = new System.Windows.Forms.Button();
            this.teacherTableBtn = new System.Windows.Forms.Button();
            this.courseCombo = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherCombo = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherattendanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.leaveTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.attendancemanagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.teachersTableAdapter();
            this.teacherattendanceDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.roomsTableAdapter();
            this.coursesTableAdapter = new attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.coursesTableAdapter();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingNavigator)).BeginInit();
            this.attendance_managementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancemanagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_attendanceDataSet
            // 
            this.teacher_attendanceDataSet.DataSetName = "teacher_attendanceDataSet";
            this.teacher_attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendance_managementBindingSource
            // 
            this.attendance_managementBindingSource.DataMember = "attendance_management";
            this.attendance_managementBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // attendance_managementTableAdapter
            // 
            this.attendance_managementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendance_managementTableAdapter = this.attendance_managementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = attendance_manager_with_mysql_using_generator_csharp.teacher_attendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attendance_managementBindingNavigator
            // 
            this.attendance_managementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendance_managementBindingNavigator.BindingSource = this.attendance_managementBindingSource;
            this.attendance_managementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendance_managementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendance_managementBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.attendance_managementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.attendance_managementBindingNavigatorSaveItem});
            this.attendance_managementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendance_managementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendance_managementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendance_managementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendance_managementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendance_managementBindingNavigator.Name = "attendance_managementBindingNavigator";
            this.attendance_managementBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.attendance_managementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendance_managementBindingNavigator.Size = new System.Drawing.Size(825, 31);
            this.attendance_managementBindingNavigator.TabIndex = 0;
            this.attendance_managementBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // attendance_managementBindingNavigatorSaveItem
            // 
            this.attendance_managementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendance_managementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendance_managementBindingNavigatorSaveItem.Image")));
            this.attendance_managementBindingNavigatorSaveItem.Name = "attendance_managementBindingNavigatorSaveItem";
            this.attendance_managementBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.attendance_managementBindingNavigatorSaveItem.Text = "Save Data";
            this.attendance_managementBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendance_managementBindingNavigatorSaveItem_Click);
            // 
            // attendanceDGV
            // 
            this.attendanceDGV.AutoGenerateColumns = false;
            this.attendanceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.leavetimeDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.attendanceDGV.DataSource = this.attendance_managementBindingSource;
            this.attendanceDGV.Location = new System.Drawing.Point(10, 146);
            this.attendanceDGV.Name = "attendanceDGV";
            this.attendanceDGV.RowHeadersWidth = 62;
            this.attendanceDGV.Size = new System.Drawing.Size(782, 220);
            this.attendanceDGV.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // leavetimeDataGridViewTextBoxColumn
            // 
            this.leavetimeDataGridViewTextBoxColumn.DataPropertyName = "leave_time";
            this.leavetimeDataGridViewTextBoxColumn.HeaderText = "leave_time";
            this.leavetimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leavetimeDataGridViewTextBoxColumn.Name = "leavetimeDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // leaveTP
            // 
            this.leaveTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.leaveTP.Location = new System.Drawing.Point(635, 37);
            this.leaveTP.Name = "leaveTP";
            this.leaveTP.Size = new System.Drawing.Size(157, 23);
            this.leaveTP.TabIndex = 38;
            // 
            // startTP
            // 
            this.startTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTP.Location = new System.Drawing.Point(371, 37);
            this.startTP.Name = "startTP";
            this.startTP.Size = new System.Drawing.Size(157, 23);
            this.startTP.TabIndex = 37;
            // 
            // dateDTP
            // 
            this.dateDTP.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTP.Location = new System.Drawing.Point(113, 39);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(157, 23);
            this.dateDTP.TabIndex = 36;
            // 
            // courseTableBtn
            // 
            this.courseTableBtn.Location = new System.Drawing.Point(635, 91);
            this.courseTableBtn.Name = "courseTableBtn";
            this.courseTableBtn.Size = new System.Drawing.Size(157, 23);
            this.courseTableBtn.TabIndex = 35;
            this.courseTableBtn.Text = "Courses Table";
            this.courseTableBtn.UseVisualStyleBackColor = true;
            this.courseTableBtn.Click += new System.EventHandler(this.ShowCourse_Click);
            // 
            // roomTableBtn
            // 
            this.roomTableBtn.Location = new System.Drawing.Point(371, 91);
            this.roomTableBtn.Name = "roomTableBtn";
            this.roomTableBtn.Size = new System.Drawing.Size(157, 23);
            this.roomTableBtn.TabIndex = 34;
            this.roomTableBtn.Text = "Rooms Table";
            this.roomTableBtn.UseVisualStyleBackColor = true;
            this.roomTableBtn.Click += new System.EventHandler(this.ShowRoom_Click);
            // 
            // teacherTableBtn
            // 
            this.teacherTableBtn.Location = new System.Drawing.Point(113, 95);
            this.teacherTableBtn.Name = "teacherTableBtn";
            this.teacherTableBtn.Size = new System.Drawing.Size(157, 23);
            this.teacherTableBtn.TabIndex = 33;
            this.teacherTableBtn.Text = "Teachers Table";
            this.teacherTableBtn.UseVisualStyleBackColor = true;
            this.teacherTableBtn.Click += new System.EventHandler(this.ShowTeacher_Click);
            // 
            // courseCombo
            // 
            this.courseCombo.DataSource = this.coursesBindingSource;
            this.courseCombo.DisplayMember = "name";
            this.courseCombo.FormattingEnabled = true;
            this.courseCombo.Location = new System.Drawing.Point(635, 64);
            this.courseCombo.Name = "courseCombo";
            this.courseCombo.Size = new System.Drawing.Size(157, 21);
            this.courseCombo.TabIndex = 32;
            this.courseCombo.ValueMember = "id";
            this.courseCombo.SelectedIndexChanged += new System.EventHandler(this.Courses_SelectedIndexChanged);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // roomCombo
            // 
            this.roomCombo.DataSource = this.roomsBindingSource;
            this.roomCombo.DisplayMember = "name";
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(371, 64);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(157, 21);
            this.roomCombo.TabIndex = 31;
            this.roomCombo.ValueMember = "id";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // teacherCombo
            // 
            this.teacherCombo.DataSource = this.teachersBindingSource;
            this.teacherCombo.DisplayMember = "name";
            this.teacherCombo.FormattingEnabled = true;
            this.teacherCombo.Location = new System.Drawing.Point(113, 68);
            this.teacherCombo.Name = "teacherCombo";
            this.teacherCombo.Size = new System.Drawing.Size(157, 21);
            this.teacherCombo.TabIndex = 30;
            this.teacherCombo.ValueMember = "id";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.teacherattendanceDataSetBindingSource;
            // 
            // teacherattendanceDataSetBindingSource
            // 
            this.teacherattendanceDataSetBindingSource.DataSource = this.teacher_attendanceDataSet;
            this.teacherattendanceDataSetBindingSource.Position = 0;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(544, 68);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(85, 16);
            this.courseNameLabel.TabIndex = 29;
            this.courseNameLabel.Text = "Course Name";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.Location = new System.Drawing.Point(287, 69);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(78, 16);
            this.roomNameLabel.TabIndex = 28;
            this.roomNameLabel.Text = "Room Name";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(15, 73);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(92, 16);
            this.teacherNameLabel.TabIndex = 27;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // leaveTimeLabel
            // 
            this.leaveTimeLabel.AutoSize = true;
            this.leaveTimeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTimeLabel.Location = new System.Drawing.Point(544, 39);
            this.leaveTimeLabel.Name = "leaveTimeLabel";
            this.leaveTimeLabel.Size = new System.Drawing.Size(74, 16);
            this.leaveTimeLabel.TabIndex = 26;
            this.leaveTimeLabel.Text = "Leave Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(287, 39);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(69, 16);
            this.startTimeLabel.TabIndex = 25;
            this.startTimeLabel.Text = "Start Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(13, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 16);
            this.dateLabel.TabIndex = 24;
            this.dateLabel.Text = "Date";
            // 
            // attendancemanagementBindingSource
            // 
            this.attendancemanagementBindingSource.DataMember = "attendance_management";
            this.attendancemanagementBindingSource.DataSource = this.teacherattendanceDataSetBindingSource;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherattendanceDataSetBindingSource1
            // 
            this.teacherattendanceDataSetBindingSource1.DataSource = this.teacher_attendanceDataSet;
            this.teacherattendanceDataSetBindingSource1.Position = 0;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.Location = new System.Drawing.Point(15, 121);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(63, 16);
            this.commentLabel.TabIndex = 39;
            this.commentLabel.Text = "Comment";
            // 
            // commentNameTextBox
            // 
            this.commentNameTextBox.Location = new System.Drawing.Point(113, 120);
            this.commentNameTextBox.Name = "commentNameTextBox";
            this.commentNameTextBox.Size = new System.Drawing.Size(679, 20);
            this.commentNameTextBox.TabIndex = 40;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 489);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentNameTextBox);
            this.Controls.Add(this.leaveTP);
            this.Controls.Add(this.startTP);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.courseTableBtn);
            this.Controls.Add(this.roomTableBtn);
            this.Controls.Add(this.teacherTableBtn);
            this.Controls.Add(this.courseCombo);
            this.Controls.Add(this.roomCombo);
            this.Controls.Add(this.teacherCombo);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.leaveTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.attendanceDGV);
            this.Controls.Add(this.attendance_managementBindingNavigator);
            this.Name = "Attendence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingNavigator)).EndInit();
            this.attendance_managementBindingNavigator.ResumeLayout(false);
            this.attendance_managementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancemanagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private teacher_attendanceDataSet teacher_attendanceDataSet;
        private System.Windows.Forms.BindingSource attendance_managementBindingSource;
        private teacher_attendanceDataSetTableAdapters.attendance_managementTableAdapter attendance_managementTableAdapter;
        private teacher_attendanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendance_managementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton attendance_managementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendanceDGV;
        private System.Windows.Forms.DateTimePicker leaveTP;
        private System.Windows.Forms.DateTimePicker startTP;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button courseTableBtn;
        private System.Windows.Forms.Button roomTableBtn;
        private System.Windows.Forms.Button teacherTableBtn;
        private System.Windows.Forms.ComboBox courseCombo;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.ComboBox teacherCombo;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label leaveTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.BindingSource teacherattendanceDataSetBindingSource;
        private System.Windows.Forms.BindingSource attendancemanagementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private teacher_attendanceDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teacherattendanceDataSetBindingSource1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private teacher_attendanceDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private teacher_attendanceDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentNameTextBox;
    }
}

