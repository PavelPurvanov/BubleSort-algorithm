using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace exercise__
{
    public partial class Form1 : Form
    {
        string myString;
        List<int> myList;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_1_17621736_SIT\stringFile.txt", Encoding.UTF8))
            {
                myString = streamReader.ReadToEnd();
            }

            label1.Text = myString;
        }

        public void generate()
        {
            int counter = 0;
            Stopwatch MyTimer = new Stopwatch();

            MyTimer.Start();

            myList = myString.Split(' ').Select(Int32.Parse).ToList();

           foreach (int var in myList)
            {
                counter++;
                textBox4.Text += System.Environment.NewLine + var.ToString();
            }

            textBox1.Text = MyTimer.Elapsed.ToString();
            textBox5.Text = counter.ToString();
            MyTimer.Stop();

            int firstWord = myString.Split(' ').Select(Int32.Parse).First();
            int lastWord = myString.Split(' ').Select(Int32.Parse).Last();
            if (myList.First() == firstWord && myList.Last() == lastWord)
            {
                MessageBox.Show("Първото и последно число се съдържат в колекцията !" + " Първо число: " + myList.First() + " Последно число: " + myList.Last(),"MsgBox" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Първото и последно число не се съдържат в колекцията !", "MsgBox", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void sort() { 
            
            int temp = 0;

            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();

            for (int write = 0; write < myList.Count; write++)
            {
                for (int sort = 0; sort < myList.Count - 1; sort++)
                {
                    if (myList[sort] > myList[sort + 1])
                    {
                        temp = myList[sort + 1];
                        myList[sort + 1] = myList[sort];
                        myList[sort] = temp;
                    }
                }
            }

            MyTimer.Stop();
            textBox2.Text = MyTimer.Elapsed.ToString();

            foreach (int var in myList)
            {
                textBox6.Text += System.Environment.NewLine + var.ToString();
            }
        }

        public void count() {

            Stopwatch MyTimer = new Stopwatch();

            MyTimer.Start();

            var groups = myList.GroupBy(v => v);
            foreach (var group in groups)
            {      
                var index = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = group.Key;
                dataGridView1.Rows[index].Cells[1].Value = group.Count();       
            }
            textBox3.Text = MyTimer.Elapsed.ToString();        

            MyTimer.Stop();
        }

        private void button1_scan_Click(object sender, EventArgs e)
        {
            try
            {
                generate();
            }
            catch (Exception ex)
            {
                msgBox(ex);
            }
        }

        private void button2_sort_Click(object sender, EventArgs e)
        {
             try
                {
                    sort();
                }
                catch (Exception ex)
                {
                    msgBox(ex);
                }
        }

        private void button3_result_Click(object sender, EventArgs e)
        {
            try
            {
                count();
            }
            catch (Exception ex)
            {
                msgBox(ex);
            }
        }

        private void msgBox(Exception ex)
        {
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
            var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

            dialog.Text = "Error Box";
            dialogType.GetProperty("Details").SetValue(dialog, ex.ToString(), null);
            dialogType.GetProperty("Message").SetValue(dialog, "An exception has been thrown !", null);

            var result = dialog.ShowDialog();
        }
    }
}
