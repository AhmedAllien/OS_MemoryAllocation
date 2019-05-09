using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    public partial class Form1 : Form
    {
        LinkedList<hole> holes = new LinkedList<hole>();
        LinkedList<hole> holes_sorted_by_address = new LinkedList<hole>();
        LinkedList<hole> old_processes= new LinkedList<hole>();
        LinkedList<Process> processes = new LinkedList<Process>();
        LinkedList<hole> memory = new LinkedList<hole>();




        int current_process_no_segments = 0;
        int segments_enterd = 0;

        public Form1()
        {
            InitializeComponent();
        }


        /* private void GenerateTable(int columnCount, int rowCount)
         {
             //Clear out the existing controls, we are generating a new table layout
             tableLayoutPanel1.Controls.Clear();

             //Clear out the existing row and column styles
             tableLayoutPanel1.ColumnStyles.Clear();
             tableLayoutPanel1.RowStyles.Clear();

             //Now we will generate the table, setting up the row and column counts first
             tableLayoutPanel1.ColumnCount = columnCount;
             tableLayoutPanel1.RowCount = rowCount;

             for (int x = 0; x < columnCount; x++)
             {
                 //First add a column
                 tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                 for (int y = 0; y < rowCount; y++)
                 {
                     //Next, add a row.  Only do this when once, when creating the first column
                     if (x == 0)
                     {
                         tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                     }

                     //Create the control, in this case we will add a button
                     Label cmd = new Label();
                     cmd.Text = "ahmed";         //Finally, add the control to the correct location in the table
                     tableLayoutPanel1.Controls.Add(cmd, x, y);
                 }
             }
         }
         */


       private void delete(TableLayoutPanel t)
        {
            int x = t.RowCount - 1;
            for (int i = x; i > 0; i--)
            {

                t.Controls.Remove(t.GetControlFromPosition(0,i));
               t.Controls.Remove(t.GetControlFromPosition(1, i));

               t.RowCount--;
            }

        




        }

        private void label_Click(object sender, EventArgs e)
        {
          string message = "are you sure you want to delete all segments of this process?";
        string caption = "";
		MessageBoxButtons buttons = MessageBoxButtons.YesNo;
		DialogResult result;

		// Displays the MessageBox.
		result = MessageBox.Show(message, caption, buttons);
		if (result == System.Windows.Forms.DialogResult.Yes)
		{
                  Label clickedLabel = sender as Label;
                  hole p = new hole();
                foreach(hole h in memory)
                  {

                      if (h.Owner.Name + h.Name == clickedLabel.Text)
                          p = h;


                  }
           

                 deallocate(p, clickedLabel);

            }
            
        }

        private void draw(hole h,TableLayoutPanel t)
        {
            if (h.Size > 0 && h.Address>-1)
            {
                Label l = new Label();
                RowStyle temp = t.RowStyles[t.RowCount - 1];
                t.RowCount++;
                t.RowStyles.Add(new RowStyle(temp.SizeType, 50));
                t.Controls.Add(l, 1, t.RowCount - 1);
                l.Text = h.Owner.Name + h.Name;
                if(h.Owner.Name!=""||h.Name.Contains("old process"))
                l.Click += new EventHandler(this.label_Click);
                if (h.Address == 0)
                    t.Controls.Add(new Label() { Text = h.Address + "\n" + (h.Address + h.Size) }, 0, t.RowCount - 1);
                else
                    t.Controls.Add(new Label() { Text = "\n" + (h.Address + h.Size) }, 0, t.RowCount - 1);

                /* tableLayoutPanel1.RowCount++;
                 tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                 tableLayoutPanel1.Controls.Add(new Label() { Text = h.Name }, 1, tableLayoutPanel1.RowCount - 1);
                 tableLayoutPanel1.Controls.Add(new Label() { Text = h.Address + "\n" + (h.Address + h.Size) }, 0, tableLayoutPanel1.RowCount - 1);
                 */
            }
        }

        private void memory_init()
        {
            int i = 0;
            IEnumerable<hole> query = holes.OrderBy(h => h.Address);
            hole[] holes_sorted = new hole[holes.Count];
            foreach (hole h in query)
            {
                holes_sorted[i] = h;
                holes_sorted_by_address.AddLast(h);

                i++;
            }



            for (int j = 0; j < holes.Count; j++)
            {
                if (j == 0)
                {

                    if (holes_sorted[j].Address > 0)
                    {

                        hole temp = new hole();
                        temp.Address = 0;
                        temp.Size = holes_sorted[j].Address;
                        temp.Name = "old process" + old_processes.Count;
                        old_processes.AddLast(temp);
                    }
                    if (holes.Count == 1)
                    {

                        if (holes_sorted[j].Address + holes_sorted[j].Size < globals.total_memory_size)
                        {
                            hole temp1 = new hole();
                            temp1.Address = holes_sorted[j].Address + holes_sorted[j].Size;
                            temp1.Size = globals.total_memory_size - temp1.Address;
                            temp1.Name = "old process" + old_processes.Count;
                            old_processes.AddLast(temp1);
                        }

                    }

                }
                else if (holes_sorted[j].Address > holes_sorted[j - 1].Address + holes_sorted[j - 1].Size)
                {

                    hole temp = new hole();
                    temp.Address = holes_sorted[j - 1].Address + holes_sorted[j - 1].Size;
                    temp.Size = holes_sorted[j].Address - temp.Address;
                    temp.Name = "old process" + old_processes.Count;
                    old_processes.AddLast(temp);
                    if (j == holes.Count - 1)
                    {

                        if (holes_sorted[j].Address + holes_sorted[j].Size < globals.total_memory_size)
                        {
                            hole temp1 = new hole();
                            temp1.Address = holes_sorted[j].Address + holes_sorted[j].Size;
                            temp1.Size = globals.total_memory_size - temp1.Address;
                            temp1.Name = "old process" + old_processes.Count;
                            old_processes.AddLast(temp1);
                        }

                    }



                }
                else if (j == holes.Count - 1)
                {
                    if (holes_sorted[j].Address + holes_sorted[j].Size < globals.total_memory_size)
                    {
                        hole temp1 = new hole();
                        temp1.Address = holes_sorted[j].Address + holes_sorted[j].Size;
                        temp1.Size = globals.total_memory_size - temp1.Address;
                        temp1.Name = "old process" + old_processes.Count;
                        old_processes.AddLast(temp1);
                    }



                }


            }

            //*******************************************************************************

            IEnumerable<hole> query2 = holes_sorted_by_address.Concat(old_processes);
            IEnumerable<hole> query1 = query2.OrderBy(h => h.Address);

            //********************************************************************************
            foreach (hole h in query1)
            {
                memory.AddLast(h);

            }

            foreach (hole h in memory)
            {

                //GenerateTable(2, 1);

                draw(h, ram);



            }

        }

        private void deallocate(hole s,Label l)
        {

            if (s.Name.Contains("old process"))
            {

                s.Name = "hole" + holes.Count;
                holes.AddLast(s);
                holes_sorted_by_address.Clear();

                IEnumerable<hole> query = holes.OrderBy(h => h.Address);

                foreach (hole h in query)
                {
                   
                    holes_sorted_by_address.AddLast(h);

                  
                }
                l.Text = s.Name;
              

            }
            else if(s.Owner.Name != "")
            {
                
                Process process_to_remove = s.Owner;
               

                foreach (hole segment in process_to_remove.segments)
                {
                    segment.Name = "hole" + holes.Count;
                    segment.Hole_Occupied = "";
                    segment.Owner = new Process();
                    holes.AddLast(segment);
                    holes_sorted_by_address.Clear();

                    IEnumerable<hole> query1 = holes.OrderBy(h => h.Address);

                    foreach (hole h in query1)
                    {

                        holes_sorted_by_address.AddLast(h);


                    }
                    l.Text = segment.Name;
                }

                delete(ram1);
                IEnumerable<hole> query = memory.OrderBy(h => h.Address);
                foreach (hole h in query)
                {


                    draw(h, ram1);



                }



            }





        }

        private void total_memory_size_btn_Click(object sender, EventArgs e)
        {
         
            if (double.TryParse(total_memory_size_tb.Text, out double temp))
            {
                globals.total_memory_size = Convert.ToDouble(total_memory_size_tb.Text);
                total_memory_size_tb.Text = "";
                total_memory_size_tb.Enabled = false;
            }
            else
            {
                total_memory_size_tb.Text = "";
                MessageBox.Show("Input must be a number!!!!!!!!");
            }
           
        }

        private void hole_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            hole h = new hole();
            label3.Text = "";
            if (Int64.TryParse(hole_address_tb.Text, out Int64 temp))
            {
                if (holes.Count > 0)
                {
                    foreach (hole x in holes)
                    {
                        if(temp>=x.Address && temp < x.Address+x.Size)
                        {
                            hole_address_tb.Text = "";
                            hole_size_tb.Text = "";
                            MessageBox.Show("Invalid hole 1!!!!!!!!");
                            return;
                        }
                       
                    }
                }

                h.Address = temp;
                hole_address_tb.Text = "";
               
            }
            else
            {
                hole_address_tb.Text = "";
                hole_size_tb.Text = "";
                MessageBox.Show("Invalid hole 2!!!!!!!!");
                return;
            }

            if (double.TryParse(hole_size_tb.Text, out double temp1))
            {
                if (holes.Count > 0)
                {
                    foreach (hole x in holes)
                    {
                        if (temp+temp1 > x.Address && temp + temp1 < x.Address+x.Size)
                        {
                            hole_address_tb.Text = "";
                            hole_size_tb.Text = "";
                            MessageBox.Show("Invalid hole 3!!!!!!!!");
                            return;
                        }

                    }
                }

                h.Size = temp1;
                hole_size_tb.Text = "";

            }
            else
            {
                hole_address_tb.Text = "";
                hole_size_tb.Text = "";
                MessageBox.Show("Invalid hole 4!!!!!!!!");
               
            }

            if (h.Address == -1||h.Size==-1)
            {
                hole_address_tb.Text = "";
                hole_size_tb.Text = "";
                MessageBox.Show("Invalid hole 5!!!!!!!!");
            }
            else
            {
                holes.AddLast(h);
            }


            foreach(hole x in holes)
            {
               
                x.Name="hole"+i;
                label3.Text+= x.Name+"  "+x.Address+"  "+x.Size+"\n";
                i++;

            }


        }

        private void number_of_segments_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(number_of_segments_tb.Text, out int temp))
            {
                if(temp>0)
                current_process_no_segments = temp;
                else
                {
                    MessageBox.Show("no of segments must be at least 1!!!!!!!!");
                    return;
                }
            
            name_of_segment_tb.Enabled = true;
            size_of_sigment_tb.Enabled = true;
            process_btn.Enabled = true;
            Process p = new Process();
            p.Name = "p" + processes.Count;
            processes.AddLast(p);

            number_of_segments_tb.Text = "";
            number_of_segments_tb.Enabled = false;
            number_of_segments_btn.Enabled = false;
            hole_address_tb.Enabled = false;
            hole_size_tb.Enabled = false;
            hole_btn.Enabled = false;
            }
            else
            {
                MessageBox.Show("number of segments must be an integer!!!!!!!!");
                number_of_segments_tb.Text = "";
                return;
            }


        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            hole s=new hole();
            if (name_of_segment_tb.Text != "" || size_of_sigment_tb.Text != "")
            {
                s.Name = name_of_segment_tb.Text;
                if (double.TryParse(size_of_sigment_tb.Text, out double temp1))
                    s.Size = temp1;
                else
                {
                    MessageBox.Show("Invalid segment size!!!!!!!!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("enter all the info!!");
            }

            
            s.Owner = processes.Last.Value;
            processes.Last.Value.segments.AddLast(s);

            segments_enterd++;

            if(segments_enterd==current_process_no_segments)
            {

                name_of_segment_tb.Enabled =false;
                size_of_sigment_tb.Enabled = false;
                process_btn.Enabled = false;

                segments_enterd = 0;
                number_of_segments_tb.Enabled = true;
                number_of_segments_btn.Enabled = true;




            }

            name_of_segment_tb.Text = "";
            size_of_sigment_tb.Text = "";

             label1.Text = "";
            foreach (Process P in processes)
            {
                 label1.Text += P.Name+"\n";
                foreach (hole h in P.segments)
                {

                     label1.Text += h.Name +" "+ h.Size + "\n";
                }


            }

        }


        private void first_fit()
        {
            hole[] temp_holes = new hole[holes_sorted_by_address.Count];
            LinkedList<hole> temp_memory = new LinkedList<hole>();


            int i = 0;

            foreach (hole h in holes_sorted_by_address)
            {


                temp_holes[i] = h;
                i++;


            }

            foreach (Process p in processes)
            {
                if (p.Allocated == false)
                {

                    foreach (hole s in p.segments)
                    {


                        foreach (hole h in temp_holes)
                        {
                            if (h.Size >= s.Size)
                            {
                                s.Address = h.Address;
                                h.Address += s.Size;
                                h.Size -= s.Size;
                                s.Hole_Occupied = h.Name;


                                break;
                            }




                        }

                        if (s.Address == -1)
                        {
                            p.Fit = false;
                            foreach (hole segment in p.segments)
                            {
                                if (segment.Hole_Occupied == "")
                                    break;
                                foreach (hole h in temp_holes)
                                {

                                    if (segment.Hole_Occupied == h.Name)
                                    {
                                        h.Address -= segment.Size;
                                        h.Size += segment.Size;
                                        s.Address = -1;
                                        s.Hole_Occupied = "";


                                        break;

                                    }

                                }




                            }


                            break;

                        }


                    }



                }

            }




            foreach (hole h in temp_holes)
            {

                temp_memory.AddLast(h);
            }
            foreach (Process p in processes)
            {
                if (p.Fit == true && p.Allocated==false)
                {

                    foreach (hole s in p.segments)
                    {

                        memory.AddLast(s);

                        p.Allocated = true;

                    }


                }

            }

            IEnumerable<hole> query = memory.OrderBy(h => h.Address);

            foreach (hole h in query)
            {


                draw(h, ram1);



            }



        }





        private void best_fit()
        {
            hole[] temp_holes = new hole[holes_sorted_by_address.Count];
            LinkedList<hole> temp_memory = new LinkedList<hole>();
            IEnumerable<hole> query1 = holes_sorted_by_address.OrderBy(h => h.Size);

            int i = 0;

            foreach (hole h in query1)
            {


                temp_holes[i] = h;
                i++;


            }

            foreach (Process p in processes)
            {
                if (p.Allocated == false)
                {

                    foreach (hole s in p.segments)
                    {


                        foreach (hole h in temp_holes)
                        {
                            if (h.Size >= s.Size)
                            {
                                s.Address = h.Address;
                                h.Address += s.Size;
                                h.Size -= s.Size;
                                s.Hole_Occupied = h.Name;


                                break;
                            }




                        }

                        if (s.Address == -1)
                        {
                            p.Fit = false;
                            foreach (hole segment in p.segments)
                            {
                                if (segment.Hole_Occupied == "")
                                    break;
                                foreach (hole h in temp_holes)
                                {

                                    if (segment.Hole_Occupied == h.Name)
                                    {
                                        h.Address -= segment.Size;
                                        h.Size += segment.Size;
                                        s.Address = -1;
                                        s.Hole_Occupied = "";


                                        break;

                                    }

                                }




                            }


                            break;

                        }


                    }



                }

            }




            foreach (hole h in temp_holes)
            {

                temp_memory.AddLast(h);
            }
            foreach (Process p in processes)
            {
                if (p.Fit == true && p.Allocated == false)
                {

                    foreach (hole s in p.segments)
                    {

                        memory.AddLast(s);

                        p.Allocated = true;

                    }


                }

            }

            IEnumerable<hole> query = memory.OrderBy(h => h.Address);

            foreach (hole h in query)
            {


                draw(h, ram1);



            }



        }


        private void button1_Click(object sender, EventArgs e)
        {


            

            
            if (first_fit_rb.Checked)
            {
                delete(ram1);


                first_fit();


            }

            if (best_fit_rb.Checked)
            {
                delete(ram1);


                best_fit();


            }


            name_of_segment_tb.Enabled = false;
            size_of_sigment_tb.Enabled = false;
           
            hole_address_tb.Enabled = false;
            hole_size_tb.Enabled = false;
            hole_btn.Enabled = false;

        }

        



        

        private void delete_table_Click(object sender, EventArgs e)
        {
            delete(ram1);
        }

        private void finish_holes_Click(object sender, EventArgs e)
        {
            memory_init();
        }
    }
}
