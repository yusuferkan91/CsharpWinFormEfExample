using ResinaSoft_WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResinaSoftDBContainer ctx = new ResinaSoftDBContainer();
            List<ResinaSoft_WinForm.Task> list_ctx = ctx.Task.ToList();
            for (int i = list_ctx.Count - 1; i >= 0; i--)
            {
                Card_task card = new Card_task(list_ctx[i]);
                //card.btn_task_card.Click += (s, ev) => pnl_info_fill(card.task);
                pnl_card_table.Controls.Add(card.get_panel());
            }
        }

        //private void pnl_info_fill(ResinaSoft_WinForm.Task task)
        //{
        //    task_info_clear();
        //    pnl_card_table.Controls.Clear();
        //    //_selected_person = person;
        //    ResinaSoftDBContainer ctx = new ResinaSoftDBContainer();

        //    List<PersonAddresses> addresses = ctx.PersonAddresses.Where(pAddress => pAddress.PersonId == _selected_person.Id).ToList();
        //    if (addresses != null)
        //    {
        //        for (int i = addresses.Count - 1; i >= 0; i--)
        //        {
        //            Card_address cAddress = new Card_address(addresses[i]);
        //            cAddress.btn_card.Click += (s, ev) => address_info_fill(cAddress.personAdress);
        //            pnl_address_table.Controls.Add(cAddress.get_panel());
        //        }
        //    }
        //    else
        //    {
        //        address_txt_clear();
        //    }

        //    txt_name_info.Text = person.Name;
        //    txt_lastname_info.Text = person.LastName;
        //    cmb_gender_info.Text = person.Gender;
        //    dateTimePicker_birthdate_info.Text = person.BirthDate.ToString();
        //    pnl_info.Visible = true;
        //    this.Refresh();
        //}

        private void task_info_clear()
        {
            throw new NotImplementedException();
        }

        private void btn_new_task_save_Click(object sender, EventArgs e)
        {
            ResinaSoftDBContainer ctx = new ResinaSoftDBContainer();
            ResinaSoft_WinForm.Task t = new ResinaSoft_WinForm.Task();
            t.Name = txt_new_task_name.Text;
            t.Deadline = dtp_new_task_deadline.Value.Date;
            t.Description = txt_new_task_description.Text;
            ctx.Task.Add(t);
            ctx.SaveChanges();
            update_table();

        }

        private void update_table()
        {
            pnl_card_table.Controls.Clear();
            ResinaSoftDBContainer ctx = new ResinaSoftDBContainer();
            //dataGridView1.DataSource = ctx.PersonAddresses.ToList();
            List<ResinaSoft_WinForm.Task> list_ctx = ctx.Task.ToList();
            cmb_status.DataSource = new List<string> { "Cinsiyet Seçin", "Erkek", "Kadın" };
            //cmb_gender_info.DataSource = new List<string> { "Cinsiyet Seçin", "Erkek", "Kadın" };
            //pnl_info.Visible = false;
            for (int i = list_ctx.Count - 1; i >= 0; i--)
            {
                Card_task card = new Card_task(list_ctx[i]);
                //card.btn_card.Click += (s, ev) => pnl_info_fill(card.person);
                pnl_card_table.Controls.Add(card.get_panel());
            }
        }
    }
}
