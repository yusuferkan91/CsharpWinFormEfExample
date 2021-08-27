using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ResinaSoft_WinForm
{
    public partial class TaskForm : Form
    {
        private Person _base_person;
        private Person this_person;
        private Task _select_task;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public TaskForm(Person person)
        {
            _base_person = person;
            this_person = person;
            InitializeComponent();
            cmb_person.SelectedItem = null;
            cmb_person.SelectedText = "Select Person";

            using (var ctx = new ResinaSoftDBContainer())
            {
                List<Task> allTask = ctx.Task.ToList();
                for (int i = allTask.Count - 1; i >= 0; i--)
                {
                    Card_task card = new Card_task(allTask[i]);
                    card.btn_task_card.Click += (s, ev) => pnl_info_fill(card.task);
                    pnl_all_task.Controls.Add(card.get_panel());
                }
            }
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            update_table();
            //lbl_person_info.Text = $"{_base_person.Name} {_base_person.LastName}";
            cmb_status.DataSource = new List<string> { "Select Status", "Started", "Completed", "Rejected", "Cancelled" };
            using (var ctx = new ResinaSoftDBContainer())
            {
                var person_list = ctx.Person.Select(x => new {
                Display = x.Name + " " + x.LastName,
                Value = x.Id
                }).ToList();

                cmb_all_person.DisplayMember = "Display";
                cmb_all_person.ValueMember = "Value";
                
                cmb_all_person.DataSource = person_list;
                cmb_all_person.SelectedValue = this_person.Id;

            }

        }

        private void update_table()
        {
            using (var ctx = new ResinaSoftDBContainer())
            {
                List<Task> list_ctx = (from pTask in ctx.PersonTask
                                        join t in ctx.Task
                                        on pTask.TaskID equals t.Id
                                        where pTask.PersonID == _base_person.Id
                                        select pTask.Task).ToList<Task>();


                pnl_card_table.Controls.Clear();
                var person_list = ctx.Person.Select(x => new {
                    Display = x.Name + " " + x.LastName,
                    Value = x.Id
                }).ToList();

                cmb_person.DisplayMember = "Display";
                cmb_person.ValueMember = "Value";
                cmb_person.DataSource = person_list;
                for (int i = list_ctx.Count - 1; i >= 0; i--)
                {
                    Card_task card = new Card_task(list_ctx[i]);
                    card.btn_task_card.Click += (s, ev) => pnl_info_fill(card.task);
                    pnl_card_table.Controls.Add(card.get_panel());
                }
            }

        }

        private void pnl_info_fill(Task task)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                _select_task = task;
                List<Person> list_ctx = (from pTask in ctx.PersonTask
                                       join p in ctx.Person
                                       on pTask.PersonID equals p.Id
                                       where pTask.TaskID == _select_task.Id
                                       select pTask.Person).ToList<Person>();
                var person_list = list_ctx.Select(x => new {
                    Display = x.Name + " " + x.LastName,
                    Value = x.Id
                }).ToList();
                lstBox_persons.DisplayMember = "Display";
                lstBox_persons.ValueMember = "Value";
                lstBox_persons.DataSource = person_list;
                lbl_task_name.Text = task.Name;
                txt_description.Text = task.Description;
                dtp_deadline.Value = task.Deadline;
                this.Refresh();
                ctx.Dispose();
            }
        }

        private void btn_new_task_save_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Task t = new Task();
            
                t.Name = txt_new_task_name.Text;
                t.Deadline = dtp_new_task_deadline.Value.Date;
                t.Description = txt_new_task_description.Text;
                ctx.Task.Add(t);
                ctx.SaveChanges();
                update_table();
            }
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {

                var list_ctx = (from pTask in ctx.PersonTask
                                join t in ctx.Task
                                on pTask.TaskID equals t.Id
                                where pTask.PersonID == _base_person.Id
                                where pTask.TaskID == _select_task.Id
                                select new {
                                    p_task = pTask,
                                    task = t
                                }).First();
                list_ctx.p_task.TaskStatus = cmb_status.SelectedItem.ToString();
                list_ctx.task.Description = txt_description.Text;
                list_ctx.task.Deadline = dtp_deadline.Value.Date;
                _select_task = list_ctx.task;

                ctx.SaveChanges();
                pnl_info_fill(_select_task);
                update_table();
            }
        }

        private void btn_person_add_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = ctx.Person.SingleOrDefault(person => person.Id == (int)cmb_person.SelectedValue);
                Task t = ctx.Task.SingleOrDefault(task => task.Id == _select_task.Id);
                PersonTask pT = new PersonTask { Person = p, Task = t };
                t.PersonTask.Add(pT);
                ctx.SaveChanges();
                pnl_info_fill(_select_task);
                update_table();
            }
        }

        private void btn_delete_person_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = ctx.Person.SingleOrDefault(person => person.Id == (int)lstBox_persons.SelectedValue);
                Task t = ctx.Task.SingleOrDefault(task => task.Id == _select_task.Id);
                PersonTask pT = ctx.PersonTask.SingleOrDefault(person => person.PersonID == (int)lstBox_persons.SelectedValue);
                t.PersonTask.Remove(pT);
                ctx.SaveChanges();
                pnl_info_fill(_select_task);
                update_table();
            }
        }

        private void btn_remove_task_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Task t = ctx.Task.SingleOrDefault(task => task.Id == _select_task.Id);
                List<PersonTask> pt = ctx.PersonTask.Where(x => x.TaskID == t.Id).ToList();
                ctx.Task.Remove(t);
                foreach (PersonTask item in pt)
                {
                    ctx.PersonTask.Remove(item);
                }
                
                ctx.SaveChanges();
                update_table();
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_all_person_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = ctx.Person.SingleOrDefault(x => x.Id == (int)cmb_all_person.SelectedValue);
                _base_person = p;
                update_table();
            }
        }
    }
}
