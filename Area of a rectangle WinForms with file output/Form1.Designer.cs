
namespace Area_of_a_rectangle_WinForms__2_
{
    partial class Area_of_a_Rectangle_Calculator
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
            this.btn_help = new System.Windows.Forms.Button();
            this.txtbox_width = new System.Windows.Forms.TextBox();
            this.txtbox_height = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.listbox_predefined_units = new System.Windows.Forms.ListBox();
            this.radbtn_predefined_unit = new System.Windows.Forms.RadioButton();
            this.radbtn_custom_unit = new System.Windows.Forms.RadioButton();
            this.txtbox_custom_unit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_error_output = new System.Windows.Forms.Label();
            this.lbl_area_output = new System.Windows.Forms.Label();
            this.chkbox_write_to_file = new System.Windows.Forms.CheckBox();
            this.txtbox_path = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.txtbox_file_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(104, 376);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // txtbox_width
            // 
            this.txtbox_width.Location = new System.Drawing.Point(148, 38);
            this.txtbox_width.Name = "txtbox_width";
            this.txtbox_width.Size = new System.Drawing.Size(75, 20);
            this.txtbox_width.TabIndex = 2;
            this.txtbox_width.TextChanged += new System.EventHandler(this.txtbox_width_TextChanged);
            // 
            // txtbox_height
            // 
            this.txtbox_height.Location = new System.Drawing.Point(148, 76);
            this.txtbox_height.Name = "txtbox_height";
            this.txtbox_height.Size = new System.Drawing.Size(75, 20);
            this.txtbox_height.TabIndex = 3;
            this.txtbox_height.TextChanged += new System.EventHandler(this.txtbox_height_TextChanged);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(87, 41);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(38, 13);
            this.lbl_width.TabIndex = 4;
            this.lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(87, 79);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(41, 13);
            this.lbl_height.TabIndex = 5;
            this.lbl_height.Text = "Height:";
            // 
            // listbox_predefined_units
            // 
            this.listbox_predefined_units.FormattingEnabled = true;
            this.listbox_predefined_units.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km",
            "inch",
            "foot",
            "yard",
            "mile"});
            this.listbox_predefined_units.Location = new System.Drawing.Point(148, 115);
            this.listbox_predefined_units.Name = "listbox_predefined_units";
            this.listbox_predefined_units.Size = new System.Drawing.Size(75, 108);
            this.listbox_predefined_units.TabIndex = 8;
            // 
            // radbtn_predefined_unit
            // 
            this.radbtn_predefined_unit.AutoSize = true;
            this.radbtn_predefined_unit.Checked = true;
            this.radbtn_predefined_unit.Location = new System.Drawing.Point(44, 115);
            this.radbtn_predefined_unit.Name = "radbtn_predefined_unit";
            this.radbtn_predefined_unit.Size = new System.Drawing.Size(98, 17);
            this.radbtn_predefined_unit.TabIndex = 9;
            this.radbtn_predefined_unit.TabStop = true;
            this.radbtn_predefined_unit.Text = "Predefined Unit";
            this.radbtn_predefined_unit.UseVisualStyleBackColor = true;
            this.radbtn_predefined_unit.CheckedChanged += new System.EventHandler(this.radbtn_predefined_unit_CheckedChanged);
            // 
            // radbtn_custom_unit
            // 
            this.radbtn_custom_unit.AutoSize = true;
            this.radbtn_custom_unit.Location = new System.Drawing.Point(60, 240);
            this.radbtn_custom_unit.Name = "radbtn_custom_unit";
            this.radbtn_custom_unit.Size = new System.Drawing.Size(82, 17);
            this.radbtn_custom_unit.TabIndex = 10;
            this.radbtn_custom_unit.Text = "Custom Unit";
            this.radbtn_custom_unit.UseVisualStyleBackColor = true;
            this.radbtn_custom_unit.CheckedChanged += new System.EventHandler(this.radbtn_custom_unit_CheckedChanged);
            // 
            // txtbox_custom_unit
            // 
            this.txtbox_custom_unit.Location = new System.Drawing.Point(148, 239);
            this.txtbox_custom_unit.Name = "txtbox_custom_unit";
            this.txtbox_custom_unit.Size = new System.Drawing.Size(75, 20);
            this.txtbox_custom_unit.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "²";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(148, 275);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 13;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(107, 316);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(32, 13);
            this.lbl_area.TabIndex = 15;
            this.lbl_area.Text = "Area:";
            // 
            // lbl_error_output
            // 
            this.lbl_error_output.AutoSize = true;
            this.lbl_error_output.Location = new System.Drawing.Point(141, 345);
            this.lbl_error_output.Name = "lbl_error_output";
            this.lbl_error_output.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_output.TabIndex = 16;
            // 
            // lbl_area_output
            // 
            this.lbl_area_output.AutoSize = true;
            this.lbl_area_output.Location = new System.Drawing.Point(145, 316);
            this.lbl_area_output.Name = "lbl_area_output";
            this.lbl_area_output.Size = new System.Drawing.Size(0, 13);
            this.lbl_area_output.TabIndex = 17;
            // 
            // chkbox_write_to_file
            // 
            this.chkbox_write_to_file.AutoSize = true;
            this.chkbox_write_to_file.Location = new System.Drawing.Point(267, 40);
            this.chkbox_write_to_file.Name = "chkbox_write_to_file";
            this.chkbox_write_to_file.Size = new System.Drawing.Size(127, 17);
            this.chkbox_write_to_file.TabIndex = 18;
            this.chkbox_write_to_file.Text = "Write output to a file?";
            this.chkbox_write_to_file.UseVisualStyleBackColor = true;
            this.chkbox_write_to_file.CheckedChanged += new System.EventHandler(this.chkbox_write_to_file_CheckedChanged);
            // 
            // txtbox_path
            // 
            this.txtbox_path.Enabled = false;
            this.txtbox_path.Location = new System.Drawing.Point(267, 111);
            this.txtbox_path.Name = "txtbox_path";
            this.txtbox_path.Size = new System.Drawing.Size(250, 20);
            this.txtbox_path.TabIndex = 19;
            // 
            // lbl_path
            // 
            this.lbl_path.Location = new System.Drawing.Point(264, 76);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(256, 33);
            this.lbl_path.TabIndex = 20;
            this.lbl_path.Text = "Please input the path you want to write to excluding the file name:";
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(264, 147);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(256, 13);
            this.lbl_file_name.TabIndex = 21;
            this.lbl_file_name.Text = "Please input the name of the file you want to write to:";
            // 
            // txtbox_file_name
            // 
            this.txtbox_file_name.Enabled = false;
            this.txtbox_file_name.Location = new System.Drawing.Point(267, 163);
            this.txtbox_file_name.Name = "txtbox_file_name";
            this.txtbox_file_name.Size = new System.Drawing.Size(250, 20);
            this.txtbox_file_name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(267, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Please note that the output will replace the contents of the file, rather than ad" +
    "ding to it.";
            // 
            // Area_of_a_Rectangle_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(529, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_file_name);
            this.Controls.Add(this.lbl_file_name);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.txtbox_path);
            this.Controls.Add(this.chkbox_write_to_file);
            this.Controls.Add(this.lbl_area_output);
            this.Controls.Add(this.lbl_error_output);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_custom_unit);
            this.Controls.Add(this.radbtn_custom_unit);
            this.Controls.Add(this.radbtn_predefined_unit);
            this.Controls.Add(this.listbox_predefined_units);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.txtbox_height);
            this.Controls.Add(this.txtbox_width);
            this.Controls.Add(this.btn_help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Area_of_a_Rectangle_Calculator";
            this.Text = "Area of a Rectangle Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TextBox txtbox_width;
        private System.Windows.Forms.TextBox txtbox_height;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.ListBox listbox_predefined_units;
        private System.Windows.Forms.RadioButton radbtn_predefined_unit;
        private System.Windows.Forms.RadioButton radbtn_custom_unit;
        private System.Windows.Forms.TextBox txtbox_custom_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_error_output;
        private System.Windows.Forms.Label lbl_area_output;
        private System.Windows.Forms.CheckBox chkbox_write_to_file;
        private System.Windows.Forms.TextBox txtbox_path;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.TextBox txtbox_file_name;
        private System.Windows.Forms.Label label2;
    }
}

