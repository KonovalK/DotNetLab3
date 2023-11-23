using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProccessManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Process[] processList;

        private void GetProcesses()
        {
            processList = Process.GetProcesses();
            ProcessesDataGridView.RowCount = processList.Count();
            for(int i =0; i<ProcessesDataGridView.RowCount; i++)
            {
                double memory = processList[i].PagedMemorySize64 / 1048576.0;
                ProcessesDataGridView.Rows[i].HeaderCell.Value = i.ToString();
                ProcessesDataGridView[0, i].Value = processList[i].ProcessName;
                ProcessesDataGridView[1,i].Value = $"{memory:F2}";
                ProcessesDataGridView[3, i].Value = GetPriority(processList[i]);
                ProcessesDataGridView[4, i].Value = processList[i].Threads.Count;
            }
        }

        private string GetPriority(Process process)
        {
            Dictionary<int, string> prior = new Dictionary<int, string>()
            {
                {0, "0"},
                {4, "Idle"},
                {5, "Idle"},
                {6, "Idle"},
                {7, "Idle"},
                {8, "Normal"},
                {9, "Normal"},
                {10, "Normal"},
                {11, "Normal"},
                {12, "Normal"},
                {13, "High"},
                {24, "RealTime"}
            };
            string str = process.BasePriority.ToString();
            return prior[Int32.Parse(str)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private int RowProcNumber;
        private int ProcNumber;
        private void ProcessesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                ContextMenuStrip myMenu = new ContextMenuStrip();
                RowProcNumber = ProcessesDataGridView.HitTest(e.X, e.Y).RowIndex;
                string StrProcId = ProcessesDataGridView.Rows[RowProcNumber].HeaderCell.Value.ToString();
                ProcNumber = int.Parse(StrProcId);
                ProcessesDataGridView.ClearSelection();
                ProcessesDataGridView.Rows[RowProcNumber].Selected = true;


                if (ProcNumber >= 0)
                {
                    myMenu.Items.Add("Зняти").Name = "Зняти";
                    myMenu.Items.Add("Пріорітет Idle").Name = "Пріорітет Idle";
                    myMenu.Items.Add("Пріорітет Normal").Name = "Пріорітет Normal";
                    myMenu.Items.Add("Пріорітет High").Name = "Пріорітет High";

                }

                myMenu.Show(ProcessesDataGridView, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
            }
        }

        private void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Name.ToString())
            {
                case "Зняти":
                    MessageBox.Show(e.ClickedItem.Name.ToString());
                    MessageBox.Show(ProcNumber.ToString());
                    MessageBox.Show(processList[ProcNumber].ProcessName.ToString());
                    processList[ProcNumber].Kill();
                    GetProcesses();
                    break;

                case "Пріорітет Idle":
                    processList[ProcNumber].PriorityClass = ProcessPriorityClass.Idle;
                    GetProcesses();
                    break;

                case "Пріорітет Normal":
                    processList[ProcNumber].PriorityClass = ProcessPriorityClass.Normal;
                    GetProcesses();
                    break;
                case "Пріорітет High":
                    processList[ProcNumber].PriorityClass = ProcessPriorityClass.High;
                    GetProcesses();
                    break;
            }
        }

        private void StartCalcBtn_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void StartWordBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE");

        }

        private void StartExcelBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\WebStorm\WebStorm 2022.3\bin\webstorm64.exe");
        }

        private void StartPowerPointBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\Hearthstone\Hearthstone.exe");
        }

        private void StartAccessBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Overwatch\Overwatch Launcher.exe");

        }
    }
}
