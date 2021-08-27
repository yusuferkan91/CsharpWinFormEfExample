using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResinaSoft_WinForm
{
    class Card_address
    {
        private PersonAddresses _personAddress = null;
        private string btn_name;
        Panel pnl_card = new Panel();
        public Button btn_card = new Button();
        public Card_address(PersonAddresses personAddress)
        {
            _personAddress = personAddress;
            btn_name = $"{_personAddress.Id.ToString()} - { _personAddress.Name} { _personAddress.Address}";
        }

        public Panel get_panel()
        {
            this.btn_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_card.FlatAppearance.BorderSize = 2;
            this.btn_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_card.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(126)))), ((int)(((byte)(184))))); this.btn_card.Location = new System.Drawing.Point(5, 5);
            this.btn_card.Margin = new System.Windows.Forms.Padding(0);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(241, 49);
            this.btn_card.TabIndex = 2;
            this.btn_card.Text = btn_name;
            this.btn_card.UseVisualStyleBackColor = true;

            this.pnl_card.Controls.Add(this.btn_card);
            this.pnl_card.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_card.Location = new System.Drawing.Point(5, 5);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_card.Size = new System.Drawing.Size(251, 59);
            this.pnl_card.TabIndex = 3;
            return this.pnl_card;
        }

        public PersonAddresses personAdress
        {
            get { return _personAddress; }
            set { _personAddress = value; }
        }
    }
}
