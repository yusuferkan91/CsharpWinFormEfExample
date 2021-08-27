namespace Task_Management
{
    partial class TaskForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_new_task_save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_new_task_deadline = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_new_task_name = new Textbox_custom.Custom_textbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_new_task_description = new Textbox_custom.Custom_textbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_task_info = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_remove_task = new System.Windows.Forms.Button();
            this.btn_save_changes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_description = new Textbox_custom.Custom_textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_deadline = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_delete_person = new System.Windows.Forms.Button();
            this.lst_person = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_person_add = new System.Windows.Forms.Button();
            this.cmb_person = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_task_name = new System.Windows.Forms.Label();
            this.pnl_task = new System.Windows.Forms.Panel();
            this.pnl_card_table = new System.Windows.Forms.Panel();
            this.pnl_card = new System.Windows.Forms.Panel();
            this.btn_task_card = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_person_info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_task_info.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnl_task.SuspendLayout();
            this.pnl_card_table.SuspendLayout();
            this.pnl_card.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(687, 566);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pnl_task);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 525);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.pnl_task_info);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(248, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 525);
            this.panel5.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_new_task_save);
            this.panel12.Controls.Add(this.tableLayoutPanel2);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 310);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(429, 215);
            this.panel12.TabIndex = 1;
            // 
            // btn_new_task_save
            // 
            this.btn_new_task_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_task_save.FlatAppearance.BorderSize = 2;
            this.btn_new_task_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_task_save.Location = new System.Drawing.Point(0, 161);
            this.btn_new_task_save.Name = "btn_new_task_save";
            this.btn_new_task_save.Size = new System.Drawing.Size(429, 54);
            this.btn_new_task_save.TabIndex = 3;
            this.btn_new_task_save.Text = "Save";
            this.btn_new_task_save.UseVisualStyleBackColor = true;
            this.btn_new_task_save.Click += new System.EventHandler(this.btn_new_task_save_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.dtp_new_task_deadline, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_new_task_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_new_task_description, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 140);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dtp_new_task_deadline
            // 
            this.dtp_new_task_deadline.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.dtp_new_task_deadline.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.dtp_new_task_deadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_new_task_deadline.Location = new System.Drawing.Point(131, 38);
            this.dtp_new_task_deadline.Name = "dtp_new_task_deadline";
            this.dtp_new_task_deadline.Size = new System.Drawing.Size(295, 27);
            this.dtp_new_task_deadline.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.label10.Location = new System.Drawing.Point(23, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_new_task_name
            // 
            this.txt_new_task_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_task_name.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_new_task_name.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_new_task_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_new_task_name.Location = new System.Drawing.Point(131, 3);
            this.txt_new_task_name.Name = "txt_new_task_name";
            this.txt_new_task_name.Size = new System.Drawing.Size(295, 29);
            this.txt_new_task_name.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.label11.Location = new System.Drawing.Point(13, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 70);
            this.label11.TabIndex = 5;
            this.label11.Text = "Description";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_new_task_description
            // 
            this.txt_new_task_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_task_description.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_new_task_description.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_new_task_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_new_task_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.txt_new_task_description.Location = new System.Drawing.Point(131, 73);
            this.txt_new_task_description.Multiline = true;
            this.txt_new_task_description.Name = "txt_new_task_description";
            this.txt_new_task_description.Size = new System.Drawing.Size(295, 64);
            this.txt_new_task_description.TabIndex = 3;
            this.txt_new_task_description.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deadline";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(429, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "New Task";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_task_info
            // 
            this.pnl_task_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.pnl_task_info.Controls.Add(this.panel13);
            this.pnl_task_info.Controls.Add(this.tableLayoutPanel1);
            this.pnl_task_info.Controls.Add(this.lbl_task_name);
            this.pnl_task_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_task_info.Location = new System.Drawing.Point(0, 0);
            this.pnl_task_info.Name = "pnl_task_info";
            this.pnl_task_info.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_task_info.Size = new System.Drawing.Size(429, 301);
            this.pnl_task_info.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.btn_remove_task);
            this.panel13.Controls.Add(this.btn_save_changes);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 256);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(429, 40);
            this.panel13.TabIndex = 2;
            // 
            // btn_remove_task
            // 
            this.btn_remove_task.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_remove_task.FlatAppearance.BorderSize = 2;
            this.btn_remove_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_task.Location = new System.Drawing.Point(0, 0);
            this.btn_remove_task.Name = "btn_remove_task";
            this.btn_remove_task.Size = new System.Drawing.Size(208, 40);
            this.btn_remove_task.TabIndex = 3;
            this.btn_remove_task.Text = "Remove Task";
            this.btn_remove_task.UseVisualStyleBackColor = true;
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save_changes.FlatAppearance.BorderSize = 2;
            this.btn_save_changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_changes.Location = new System.Drawing.Point(220, 0);
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.Size = new System.Drawing.Size(209, 40);
            this.btn_save_changes.TabIndex = 2;
            this.btn_save_changes.Text = "Save Changes";
            this.btn_save_changes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 232);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_description);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(208, 110);
            this.panel8.TabIndex = 0;
            // 
            // txt_description
            // 
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_description.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_description.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.txt_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.txt_description.Location = new System.Drawing.Point(0, 25);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(208, 85);
            this.txt_description.TabIndex = 2;
            this.txt_description.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmb_status);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.dtp_deadline);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(217, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(209, 110);
            this.panel9.TabIndex = 1;
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(0, 81);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(209, 29);
            this.cmb_status.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status";
            // 
            // dtp_deadline
            // 
            this.dtp_deadline.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.dtp_deadline.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.dtp_deadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_deadline.Location = new System.Drawing.Point(0, 25);
            this.dtp_deadline.Name = "dtp_deadline";
            this.dtp_deadline.Size = new System.Drawing.Size(209, 27);
            this.dtp_deadline.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Deadline";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_delete_person);
            this.panel10.Controls.Add(this.lst_person);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 119);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(208, 110);
            this.panel10.TabIndex = 2;
            // 
            // btn_delete_person
            // 
            this.btn_delete_person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete_person.FlatAppearance.BorderSize = 2;
            this.btn_delete_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_person.Location = new System.Drawing.Point(120, 25);
            this.btn_delete_person.Name = "btn_delete_person";
            this.btn_delete_person.Size = new System.Drawing.Size(88, 85);
            this.btn_delete_person.TabIndex = 3;
            this.btn_delete_person.Text = "Delete";
            this.btn_delete_person.UseVisualStyleBackColor = true;
            // 
            // lst_person
            // 
            this.lst_person.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_person.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.lst_person.FormattingEnabled = true;
            this.lst_person.ItemHeight = 21;
            this.lst_person.Location = new System.Drawing.Point(0, 25);
            this.lst_person.Name = "lst_person";
            this.lst_person.Size = new System.Drawing.Size(120, 85);
            this.lst_person.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Persons";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_person_add);
            this.panel11.Controls.Add(this.cmb_person);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(217, 119);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(209, 110);
            this.panel11.TabIndex = 3;
            // 
            // btn_person_add
            // 
            this.btn_person_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_person_add.FlatAppearance.BorderSize = 2;
            this.btn_person_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_person_add.Location = new System.Drawing.Point(0, 60);
            this.btn_person_add.Name = "btn_person_add";
            this.btn_person_add.Size = new System.Drawing.Size(209, 50);
            this.btn_person_add.TabIndex = 15;
            this.btn_person_add.Text = "Add";
            this.btn_person_add.UseVisualStyleBackColor = true;
            // 
            // cmb_person
            // 
            this.cmb_person.BackColor = System.Drawing.Color.White;
            this.cmb_person.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_person.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.cmb_person.FormattingEnabled = true;
            this.cmb_person.Location = new System.Drawing.Point(0, 25);
            this.cmb_person.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_person.Name = "cmb_person";
            this.cmb_person.Size = new System.Drawing.Size(209, 29);
            this.cmb_person.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Add Person";
            // 
            // lbl_task_name
            // 
            this.lbl_task_name.BackColor = System.Drawing.Color.White;
            this.lbl_task_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_task_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_task_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_task_name.Name = "lbl_task_name";
            this.lbl_task_name.Size = new System.Drawing.Size(429, 21);
            this.lbl_task_name.TabIndex = 0;
            this.lbl_task_name.Text = "Task Name";
            this.lbl_task_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_task
            // 
            this.pnl_task.Controls.Add(this.pnl_card_table);
            this.pnl_task.Controls.Add(this.panel6);
            this.pnl_task.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_task.Location = new System.Drawing.Point(0, 0);
            this.pnl_task.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_task.Name = "pnl_task";
            this.pnl_task.Size = new System.Drawing.Size(248, 525);
            this.pnl_task.TabIndex = 0;
            // 
            // pnl_card_table
            // 
            this.pnl_card_table.Controls.Add(this.pnl_card);
            this.pnl_card_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_card_table.Location = new System.Drawing.Point(0, 46);
            this.pnl_card_table.Name = "pnl_card_table";
            this.pnl_card_table.Size = new System.Drawing.Size(248, 479);
            this.pnl_card_table.TabIndex = 3;
            // 
            // pnl_card
            // 
            this.pnl_card.Controls.Add(this.btn_task_card);
            this.pnl_card.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_card.Location = new System.Drawing.Point(0, 0);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_card.Size = new System.Drawing.Size(248, 65);
            this.pnl_card.TabIndex = 2;
            // 
            // btn_task_card
            // 
            this.btn_task_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_task_card.FlatAppearance.BorderSize = 2;
            this.btn_task_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_task_card.Location = new System.Drawing.Point(0, 5);
            this.btn_task_card.Name = "btn_task_card";
            this.btn_task_card.Size = new System.Drawing.Size(248, 55);
            this.btn_task_card.TabIndex = 1;
            this.btn_task_card.Text = "task1";
            this.btn_task_card.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.panel6.Controls.Add(this.lbl_person_info);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel6.Size = new System.Drawing.Size(248, 46);
            this.panel6.TabIndex = 0;
            // 
            // lbl_person_info
            // 
            this.lbl_person_info.BackColor = System.Drawing.Color.White;
            this.lbl_person_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_person_info.Location = new System.Drawing.Point(0, 0);
            this.lbl_person_info.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_person_info.Name = "lbl_person_info";
            this.lbl_person_info.Size = new System.Drawing.Size(248, 41);
            this.lbl_person_info.TabIndex = 0;
            this.lbl_person_info.Text = "Name LastName";
            this.lbl_person_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 31);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Management";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(644, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 566);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaskForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_task_info.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnl_task.ResumeLayout(false);
            this.pnl_card_table.ResumeLayout(false);
            this.pnl_card.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_task;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_person_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_task_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_task_name;
        private System.Windows.Forms.Panel pnl_card;
        private System.Windows.Forms.Button btn_task_card;
        private System.Windows.Forms.Panel panel8;
        private Textbox_custom.Custom_textbox txt_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_deadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_delete_person;
        private System.Windows.Forms.ListBox lst_person;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_person_add;
        private System.Windows.Forms.ComboBox cmb_person;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_new_task_save;
        private System.Windows.Forms.Label label11;
        private Textbox_custom.Custom_textbox txt_new_task_description;
        private Textbox_custom.Custom_textbox txt_new_task_name;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_remove_task;
        private System.Windows.Forms.Button btn_save_changes;
        private System.Windows.Forms.DateTimePicker dtp_new_task_deadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_card_table;
    }
}

