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
using System.Runtime.InteropServices;


namespace ResinaSoft_WinForm
{
    public partial class Form1 : Form
    {
        private bool btn_add_address_clicked;
        private bool btn_add_person_clicked;
        private int pnl_add_person_height;
        private Person _selected_person;
        private PersonAddresses _selected_personAddress;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_add_person_clicked = false;
            btn_add_address_clicked = true;
            btn_add_address.PerformClick();
            pnl_label.Controls.Add(selectLabel());
            update_table();
        }
        public Label selectLabel()
        {
            Label lbl = new Label();
            lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            lbl.CausesValidation = false;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Location = new System.Drawing.Point(0, 0);
            lbl.Name = "label4";
            lbl.Size = new System.Drawing.Size(200, 100);
            lbl.TabIndex = 5;
            lbl.Text = "Select Person";
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return lbl;
        }
        private void update_table()
        {
            pnl_card_table.Controls.Clear();
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                List<Person> list_ctx = ctx.Person.ToList();
                cmb_gender.DataSource = new List<string> { "Cinsiyet Seçin", "Erkek", "Kadın" };
                cmb_gender_info.DataSource = new List<string> { "Cinsiyet Seçin", "Erkek", "Kadın" };
                pnl_info.Visible = false;
                for (int i = list_ctx.Count - 1; i >= 0; i--)
                {
                    Card_person card = new Card_person(list_ctx[i]);
                    card.btn_card.Click += (s, ev) => pnl_info_fill(card.person);
                    pnl_card_table.Controls.Add(card.get_panel());
                }
            }
        }
        public void address_info_fill(PersonAddresses pAddress)
        {
            _selected_personAddress = pAddress;
            btn_edit_address.PerformClick();
            txt_address.Text = pAddress.Address;
            txt_address_city.Text = pAddress.CityId.ToString();
            txt_address_name.Text = pAddress.Name;
            txt_address_type.Text = pAddress.AddressType;
        }
        public void pnl_info_fill(Person person)
        {
            address_txt_clear();
            btn_add_address.PerformClick();
            pnl_address_table.Controls.Clear();
            _selected_person = person;
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                List<PersonAddresses> addresses = ctx.PersonAddresses.Where(pAddress => pAddress.PersonId == _selected_person.Id).ToList();
                if (addresses != null)
                {
                    for (int i = addresses.Count-1; i >=0 ; i--)
                    {
                        Card_address cAddress = new Card_address(addresses[i]);
                        cAddress.btn_card.Click += (s, ev) => address_info_fill(cAddress.personAdress);
                        pnl_address_table.Controls.Add(cAddress.get_panel());
                    }
                }
                else
                {
                    address_txt_clear();
                }

                txt_name_info.Text = person.Name;
                txt_lastname_info.Text = person.LastName;
                cmb_gender_info.Text = person.Gender;
                dateTimePicker_birthdate_info.Text = person.BirthDate.ToString();
                pnl_info.Visible = true;
                this.Refresh();
            }
        }

        public void address_txt_clear()
        {
            txt_address.Clear();
            txt_address_city.Clear();
            txt_address_name.Clear();
            txt_address_type.Clear();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = new Person();
                p.Name = txt_name.Text;
                p.LastName = txt_lastname.Text;
                p.BirthDate = dateTimePicker_birthdate.Value.Date;
                p.Gender = cmb_gender.SelectedItem.ToString();
                ctx.Person.Add(p);
                ctx.SaveChanges();
                update_table();
            }
        }

        private void pnl_add_person_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            float width = (float)4.0;
            Pen pen = new Pen(Color.FromArgb(75, 126, 184), width);
            pen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(pen, 2, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 2, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
            e.Graphics.DrawLine(pen, panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_address_save_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                if (btn_add_address_clicked)
                {
                    Person p = ctx.Person.SingleOrDefault(person => person.Id == _selected_person.Id);
                    PersonAddresses pAddres = new PersonAddresses();
                    pAddres.Name = txt_address_name.Text;
                    pAddres.AddressType = txt_address_type.Text;
                    pAddres.CityId = Convert.ToInt32(txt_address_city.Text);
                    pAddres.Address = txt_address.Text;
                    pAddres.PersonId = _selected_person.Id;
                    pAddres.Person = p;
                    ctx.PersonAddresses.Add(pAddres);
                    ctx.SaveChanges();
                    pnl_info_fill(_selected_person);
                }
                else
                {
                    PersonAddresses p = (from x in ctx.PersonAddresses
                                         where x.Id == _selected_personAddress.Id
                                         select x).First();
                    p.Name = txt_address_name.Text;
                    p.AddressType = txt_address_type.Text;
                    p.CityId = Convert.ToInt32(txt_address_city.Text);
                    p.Address = txt_address.Text;

                }
                ctx.SaveChanges();
                pnl_info_fill(_selected_person);
            }
        }

        private void btn_person_save_changes_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = (from x in ctx.Person
                              where x.Id == _selected_person.Id
                              select x).First();
                p.Name = txt_name_info.Text;
                p.LastName = txt_lastname_info.Text;
                p.Gender = cmb_gender_info.SelectedItem.ToString();
                p.BirthDate = dateTimePicker_birthdate.Value.Date;
                ctx.SaveChanges();
                pnl_info_fill(_selected_person);
                update_table();
            }
        }
        private void btn_add_address_Click(object sender, EventArgs e)
        {
            btn_address_delete.Visible = false;
            btn_add_address_clicked = true;
            address_txt_clear();
            btn_address_delete.FlatAppearance.BorderSize = 4;
            btn_edit_address.FlatAppearance.BorderSize = 2;
        }

        private void btn_edit_address_Click(object sender, EventArgs e)
        {
            btn_address_delete.Visible = true;
            btn_add_address_clicked = false;
            btn_address_delete.FlatAppearance.BorderSize = 2;
            btn_edit_address.FlatAppearance.BorderSize = 4;
        }

        private void btn_address_delete_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                PersonAddresses p = (from x in ctx.PersonAddresses
                                     where x.Id == _selected_personAddress.Id
                                     select x).First();
                ctx.PersonAddresses.Remove(p);
                ctx.SaveChanges();
                pnl_info_fill(_selected_person);
                address_txt_clear();
            }
        }

        private void btn_person_delete_Click(object sender, EventArgs e)
        {
            using (ResinaSoftDBContainer ctx = new ResinaSoftDBContainer())
            {
                Person p = (from x in ctx.Person
                            where x.Id == _selected_person.Id
                                     select x).First();
                ctx.Person.Remove(p);
                ctx.SaveChanges();
                _selected_person = null;
                pnl_info.Visible = false;
                address_txt_clear();
                update_table();
            };
        }

        private void btn_task_form_Click(object sender, EventArgs e)
        {
            TaskForm t = new TaskForm(_selected_person);

            t.ShowDialog();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
