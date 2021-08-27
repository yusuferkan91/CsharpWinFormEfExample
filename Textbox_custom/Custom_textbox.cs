using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbox_custom
{
    public partial class Custom_textbox : TextBox
    {
        private Color _bottomBorderColor = Color.FromArgb(75, 126, 184);
        private Color _onFocusColor = Color.FromArgb(75, 126, 184);
        public Custom_textbox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _bottomBorderColor
            });
            InitializeComponent();
        }
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }
        public Color BottomBorderColor
        {
            get { return _bottomBorderColor; }
            set
            {
                _bottomBorderColor = value;
                Controls[0].BackColor = _bottomBorderColor;
            }
        }

        public Color BottomBorderOnFocusColor
        {
            get { return _onFocusColor; }
            set { _onFocusColor = value; }
        }

        private void Custom_textbox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _onFocusColor;
        }

        private void Custom_textbox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomBorderColor;
        }
    }
}
