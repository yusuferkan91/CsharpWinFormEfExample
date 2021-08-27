using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    class Card_task
    {
        private ResinaSoft_WinForm.Task _task = null;
        private string btn_name;
        Panel pnl_card = new Panel();
        public Button btn_task_card = new Button();
        public Card_task(ResinaSoft_WinForm.Task person)
        {
            _task = person;
            btn_name = $"{_task.Id.ToString()} - { _task.Name}";
        }

        public Panel get_panel()
        {
            this.btn_task_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_task_card.FlatAppearance.BorderSize = 2;
            this.btn_task_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_task_card.Location = new System.Drawing.Point(0, 5);
            this.btn_task_card.Name = "btn_task_card";
            this.btn_task_card.Size = new System.Drawing.Size(248, 55);
            this.btn_task_card.TabIndex = 1;
            this.btn_task_card.Text = "task1";
            this.btn_task_card.UseVisualStyleBackColor = true;
            //this.btn_card.Click += Btn_card_Click;

            this.pnl_card.Controls.Add(this.btn_task_card);
            this.pnl_card.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_card.Location = new System.Drawing.Point(0, 46);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_card.Size = new System.Drawing.Size(248, 65);
            this.pnl_card.TabIndex = 2;
            return this.pnl_card;
        }

        //private void Btn_card_Click(object sender, EventArgs e)
        //{
        //    Form1.set_person(_person);
        //}

        public ResinaSoft_WinForm.Task task
        {
            get { return _task; }
            set { _task = value; }
        }
    }
}
