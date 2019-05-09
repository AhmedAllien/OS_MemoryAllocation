namespace MemoryAllocation
{
    partial class Form1
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
            this.total_memory_size_tb = new System.Windows.Forms.TextBox();
            this.total_memory_size_btn = new System.Windows.Forms.Button();
            this.total_memory_size_label = new System.Windows.Forms.Label();
            this.holes_sec = new System.Windows.Forms.Label();
            this.hole_address_tb = new System.Windows.Forms.TextBox();
            this.hole_address_label = new System.Windows.Forms.Label();
            this.hole_btn = new System.Windows.Forms.Button();
            this.hole_size_tb = new System.Windows.Forms.TextBox();
            this.hole_size_label = new System.Windows.Forms.Label();
            this.size_of_sigment_label = new System.Windows.Forms.Label();
            this.size_of_sigment_tb = new System.Windows.Forms.TextBox();
            this.process_btn = new System.Windows.Forms.Button();
            this.number_of_segments_label = new System.Windows.Forms.Label();
            this.number_of_segments_tb = new System.Windows.Forms.TextBox();
            this.processes_sec = new System.Windows.Forms.Label();
            this.name_of_segment_label = new System.Windows.Forms.Label();
            this.name_of_segment_tb = new System.Windows.Forms.TextBox();
            this.number_of_segments_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.best_fit_rb = new System.Windows.Forms.RadioButton();
            this.first_fit_rb = new System.Windows.Forms.RadioButton();
            this.finish_holes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ram1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_table = new System.Windows.Forms.Button();
            this.ram.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ram1.SuspendLayout();
            this.SuspendLayout();
            // 
            // total_memory_size_tb
            // 
            this.total_memory_size_tb.Location = new System.Drawing.Point(12, 37);
            this.total_memory_size_tb.Name = "total_memory_size_tb";
            this.total_memory_size_tb.Size = new System.Drawing.Size(100, 20);
            this.total_memory_size_tb.TabIndex = 0;
            // 
            // total_memory_size_btn
            // 
            this.total_memory_size_btn.Location = new System.Drawing.Point(137, 37);
            this.total_memory_size_btn.Name = "total_memory_size_btn";
            this.total_memory_size_btn.Size = new System.Drawing.Size(75, 20);
            this.total_memory_size_btn.TabIndex = 1;
            this.total_memory_size_btn.Text = "Enter";
            this.total_memory_size_btn.UseVisualStyleBackColor = true;
            this.total_memory_size_btn.Click += new System.EventHandler(this.total_memory_size_btn_Click);
            // 
            // total_memory_size_label
            // 
            this.total_memory_size_label.AutoSize = true;
            this.total_memory_size_label.Location = new System.Drawing.Point(9, 21);
            this.total_memory_size_label.Name = "total_memory_size_label";
            this.total_memory_size_label.Size = new System.Drawing.Size(94, 13);
            this.total_memory_size_label.TabIndex = 2;
            this.total_memory_size_label.Text = "Total Memory Size";
            // 
            // holes_sec
            // 
            this.holes_sec.AutoSize = true;
            this.holes_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holes_sec.Location = new System.Drawing.Point(8, 77);
            this.holes_sec.Name = "holes_sec";
            this.holes_sec.Size = new System.Drawing.Size(55, 20);
            this.holes_sec.TabIndex = 3;
            this.holes_sec.Text = "Holes";
            // 
            // hole_address_tb
            // 
            this.hole_address_tb.Location = new System.Drawing.Point(12, 126);
            this.hole_address_tb.Name = "hole_address_tb";
            this.hole_address_tb.Size = new System.Drawing.Size(100, 20);
            this.hole_address_tb.TabIndex = 4;
            // 
            // hole_address_label
            // 
            this.hole_address_label.AutoSize = true;
            this.hole_address_label.Location = new System.Drawing.Point(9, 110);
            this.hole_address_label.Name = "hole_address_label";
            this.hole_address_label.Size = new System.Drawing.Size(69, 13);
            this.hole_address_label.TabIndex = 5;
            this.hole_address_label.Text = "Hole address";
            // 
            // hole_btn
            // 
            this.hole_btn.Location = new System.Drawing.Point(12, 191);
            this.hole_btn.Name = "hole_btn";
            this.hole_btn.Size = new System.Drawing.Size(75, 23);
            this.hole_btn.TabIndex = 6;
            this.hole_btn.Text = "Enter";
            this.hole_btn.UseVisualStyleBackColor = true;
            this.hole_btn.Click += new System.EventHandler(this.hole_btn_Click);
            // 
            // hole_size_tb
            // 
            this.hole_size_tb.Location = new System.Drawing.Point(12, 165);
            this.hole_size_tb.Name = "hole_size_tb";
            this.hole_size_tb.Size = new System.Drawing.Size(100, 20);
            this.hole_size_tb.TabIndex = 7;
            // 
            // hole_size_label
            // 
            this.hole_size_label.AutoSize = true;
            this.hole_size_label.Location = new System.Drawing.Point(12, 149);
            this.hole_size_label.Name = "hole_size_label";
            this.hole_size_label.Size = new System.Drawing.Size(50, 13);
            this.hole_size_label.TabIndex = 8;
            this.hole_size_label.Text = "Hole size";
            // 
            // size_of_sigment_label
            // 
            this.size_of_sigment_label.AutoSize = true;
            this.size_of_sigment_label.Location = new System.Drawing.Point(9, 344);
            this.size_of_sigment_label.Name = "size_of_sigment_label";
            this.size_of_sigment_label.Size = new System.Drawing.Size(82, 13);
            this.size_of_sigment_label.TabIndex = 15;
            this.size_of_sigment_label.Text = "Size of segment";
            // 
            // size_of_sigment_tb
            // 
            this.size_of_sigment_tb.Enabled = false;
            this.size_of_sigment_tb.Location = new System.Drawing.Point(12, 360);
            this.size_of_sigment_tb.Name = "size_of_sigment_tb";
            this.size_of_sigment_tb.Size = new System.Drawing.Size(100, 20);
            this.size_of_sigment_tb.TabIndex = 14;
            // 
            // process_btn
            // 
            this.process_btn.Enabled = false;
            this.process_btn.Location = new System.Drawing.Point(12, 386);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(101, 23);
            this.process_btn.TabIndex = 13;
            this.process_btn.Text = "Enter the segment";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // number_of_segments_label
            // 
            this.number_of_segments_label.AutoSize = true;
            this.number_of_segments_label.Location = new System.Drawing.Point(9, 266);
            this.number_of_segments_label.Name = "number_of_segments_label";
            this.number_of_segments_label.Size = new System.Drawing.Size(104, 13);
            this.number_of_segments_label.TabIndex = 12;
            this.number_of_segments_label.Text = "Number of segments";
            // 
            // number_of_segments_tb
            // 
            this.number_of_segments_tb.Location = new System.Drawing.Point(12, 282);
            this.number_of_segments_tb.Name = "number_of_segments_tb";
            this.number_of_segments_tb.Size = new System.Drawing.Size(100, 20);
            this.number_of_segments_tb.TabIndex = 11;
            // 
            // processes_sec
            // 
            this.processes_sec.AutoSize = true;
            this.processes_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_sec.Location = new System.Drawing.Point(12, 233);
            this.processes_sec.Name = "processes_sec";
            this.processes_sec.Size = new System.Drawing.Size(92, 20);
            this.processes_sec.TabIndex = 10;
            this.processes_sec.Text = "Processes";
            // 
            // name_of_segment_label
            // 
            this.name_of_segment_label.AutoSize = true;
            this.name_of_segment_label.Location = new System.Drawing.Point(9, 305);
            this.name_of_segment_label.Name = "name_of_segment_label";
            this.name_of_segment_label.Size = new System.Drawing.Size(90, 13);
            this.name_of_segment_label.TabIndex = 17;
            this.name_of_segment_label.Text = "Name of segment";
            // 
            // name_of_segment_tb
            // 
            this.name_of_segment_tb.Enabled = false;
            this.name_of_segment_tb.Location = new System.Drawing.Point(12, 321);
            this.name_of_segment_tb.Name = "name_of_segment_tb";
            this.name_of_segment_tb.Size = new System.Drawing.Size(100, 20);
            this.name_of_segment_tb.TabIndex = 16;
            // 
            // number_of_segments_btn
            // 
            this.number_of_segments_btn.Location = new System.Drawing.Point(137, 281);
            this.number_of_segments_btn.Name = "number_of_segments_btn";
            this.number_of_segments_btn.Size = new System.Drawing.Size(75, 20);
            this.number_of_segments_btn.TabIndex = 18;
            this.number_of_segments_btn.Text = "Enter";
            this.number_of_segments_btn.UseVisualStyleBackColor = true;
            this.number_of_segments_btn.Click += new System.EventHandler(this.number_of_segments_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "allocate 1 process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ram.ColumnCount = 2;
            this.ram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ram.Controls.Add(this.label6, 1, 0);
            this.ram.Controls.Add(this.label5, 0, 0);
            this.ram.Location = new System.Drawing.Point(547, 110);
            this.ram.Name = "ram";
            this.ram.RowCount = 1;
            this.ram.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ram.Size = new System.Drawing.Size(200, 29);
            this.ram.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.best_fit_rb);
            this.groupBox1.Controls.Add(this.first_fit_rb);
            this.groupBox1.Location = new System.Drawing.Point(137, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // best_fit_rb
            // 
            this.best_fit_rb.AutoSize = true;
            this.best_fit_rb.Location = new System.Drawing.Point(126, 23);
            this.best_fit_rb.Name = "best_fit_rb";
            this.best_fit_rb.Size = new System.Drawing.Size(60, 17);
            this.best_fit_rb.TabIndex = 1;
            this.best_fit_rb.TabStop = true;
            this.best_fit_rb.Text = "Best Fit";
            this.best_fit_rb.UseVisualStyleBackColor = true;
            // 
            // first_fit_rb
            // 
            this.first_fit_rb.AutoSize = true;
            this.first_fit_rb.Location = new System.Drawing.Point(7, 23);
            this.first_fit_rb.Name = "first_fit_rb";
            this.first_fit_rb.Size = new System.Drawing.Size(58, 17);
            this.first_fit_rb.TabIndex = 0;
            this.first_fit_rb.TabStop = true;
            this.first_fit_rb.Text = "First Fit";
            this.first_fit_rb.UseVisualStyleBackColor = true;
            // 
            // finish_holes
            // 
            this.finish_holes.Location = new System.Drawing.Point(100, 191);
            this.finish_holes.Name = "finish_holes";
            this.finish_holes.Size = new System.Drawing.Size(75, 23);
            this.finish_holes.TabIndex = 29;
            this.finish_holes.Text = "Finish";
            this.finish_holes.UseVisualStyleBackColor = true;
            this.finish_holes.Click += new System.EventHandler(this.finish_holes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // ram1
            // 
            this.ram1.AutoSize = true;
            this.ram1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ram1.ColumnCount = 2;
            this.ram1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ram1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ram1.Controls.Add(this.label4, 1, 0);
            this.ram1.Controls.Add(this.label7, 0, 0);
            this.ram1.Location = new System.Drawing.Point(289, 94);
            this.ram1.Name = "ram1";
            this.ram1.RowCount = 1;
            this.ram1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ram1.Size = new System.Drawing.Size(200, 29);
            this.ram1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Process";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // delete_table
            // 
            this.delete_table.Location = new System.Drawing.Point(348, 37);
            this.delete_table.Name = "delete_table";
            this.delete_table.Size = new System.Drawing.Size(75, 23);
            this.delete_table.TabIndex = 32;
            this.delete_table.Text = "delete_table";
            this.delete_table.UseVisualStyleBackColor = true;
            this.delete_table.Click += new System.EventHandler(this.delete_table_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_table);
            this.Controls.Add(this.ram1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finish_holes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number_of_segments_btn);
            this.Controls.Add(this.name_of_segment_label);
            this.Controls.Add(this.name_of_segment_tb);
            this.Controls.Add(this.size_of_sigment_label);
            this.Controls.Add(this.size_of_sigment_tb);
            this.Controls.Add(this.process_btn);
            this.Controls.Add(this.number_of_segments_label);
            this.Controls.Add(this.number_of_segments_tb);
            this.Controls.Add(this.processes_sec);
            this.Controls.Add(this.hole_size_label);
            this.Controls.Add(this.hole_size_tb);
            this.Controls.Add(this.hole_btn);
            this.Controls.Add(this.hole_address_label);
            this.Controls.Add(this.hole_address_tb);
            this.Controls.Add(this.holes_sec);
            this.Controls.Add(this.total_memory_size_label);
            this.Controls.Add(this.total_memory_size_btn);
            this.Controls.Add(this.total_memory_size_tb);
            this.Name = "Form1";
            this.Text = "Memory Allocation";
            this.ram.ResumeLayout(false);
            this.ram.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ram1.ResumeLayout(false);
            this.ram1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox total_memory_size_tb;
        private System.Windows.Forms.Button total_memory_size_btn;
        private System.Windows.Forms.Label total_memory_size_label;
        private System.Windows.Forms.Label holes_sec;
        private System.Windows.Forms.TextBox hole_address_tb;
        private System.Windows.Forms.Label hole_address_label;
        private System.Windows.Forms.Button hole_btn;
        private System.Windows.Forms.TextBox hole_size_tb;
        private System.Windows.Forms.Label hole_size_label;
        protected internal System.Windows.Forms.Label size_of_sigment_label;
        protected internal System.Windows.Forms.TextBox size_of_sigment_tb;
        protected internal System.Windows.Forms.Button process_btn;
        protected internal System.Windows.Forms.Label number_of_segments_label;
        protected internal System.Windows.Forms.TextBox number_of_segments_tb;
        protected internal System.Windows.Forms.Label processes_sec;
        protected internal System.Windows.Forms.Label name_of_segment_label;
        protected internal System.Windows.Forms.TextBox name_of_segment_tb;
        private System.Windows.Forms.Button number_of_segments_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel ram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton best_fit_rb;
        private System.Windows.Forms.RadioButton first_fit_rb;
        private System.Windows.Forms.Button finish_holes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel ram1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_table;
    }
}

