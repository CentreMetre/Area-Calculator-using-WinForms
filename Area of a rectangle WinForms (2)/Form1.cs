using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_a_rectangle_WinForms__2_
{
    public partial class Area_of_a_Rectangle_Calculator : Form
    {
        public Area_of_a_Rectangle_Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listbox_predefined_units.Enabled = false;
            txtbox_custom_unit.Enabled = false;
            //btn_calculate.Enabled = false;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //adds a label, telling the use how to use the app
            Label lbl_help = new Label();
            lbl_help.Text = "Input the width of the rectangle in the first box and the height of the rectangle in the second box. You can also define you own unit if you wish, but you can also chose from a premade one.";
            lbl_help.Location = new Point(12, 408);
            lbl_help.Size = new Size(259, 52);
            lbl_help.TextAlign = ContentAlignment.TopCenter;
            //lbl_help.Font = new Font("Microsoft Sans Serif", 8);
            //lbl_help.Font = new System.Drawing.Font(lbl_help.Font.Name, ); //Changes the size of the font
            this.Controls.Add(lbl_help);

            //resizes the win form to fit hte help label
            this.Size = new Size(299, 516);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //getting units
            string units = "placeholder";
            if (radbtn_custom_unit.Checked == true)
            {
                units = txtbox_custom_unit.Text;
            }
            else if (radbtn_predefined_unit.Checked == true)
            {
                units = Convert.ToString(listbox_predefined_units.SelectedItem);
            }
            else
            {
                lbl_error_output.Text = "Units not changed";
            }

            //calculating area
            double area_calculated = double.Parse(txtbox_width.Text) * double.Parse(txtbox_height.Text);
            string area_calculated_string = Convert.ToString(area_calculated);

            //concateniating units to area
            string area_with_units = area_calculated_string + units + "²";

            //
            lbl_area_output.Text = Convert.ToString(area_with_units);
        }

        private void radbtn_predefined_unit_CheckedChanged(object sender, EventArgs e)
        {
            //PREDEFINED UNITS RADBUTTON
            listbox_predefined_units.Enabled = true;
            txtbox_custom_unit.Enabled = false;

        }

        private void radbtn_custom_unit_CheckedChanged(object sender, EventArgs e)
        {
            //CUSTOM UNITS RADBUTTON
            listbox_predefined_units.Enabled = false;
            txtbox_custom_unit.Enabled = true;
        }
    }
}
