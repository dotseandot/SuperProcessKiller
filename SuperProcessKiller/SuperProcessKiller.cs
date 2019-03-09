using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SuperProcessKiller
{
    public partial class SuperProcessKiller : Form
    {
#region Global Variables
        int total; //total processes killed
        string name; //name of process
        private List<ProcessDetail> processes = new List<ProcessDetail>();
        private Config config = new Config();
#endregion

#region Form Load
        public SuperProcessKiller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
            cb_sort.SelectedIndex = 4;
        }
#endregion

#region Event Handling
        //When 'Kill' button is clicked...
        private void b_kill_Click(object sender, EventArgs e)
        {
            //Kill application
            total = Killer.Kill(name, false);

            //Write to Log Window
            WriteLog();
            LoadList();
        }

        //When 'Kill (Safe)' button is clicked...
        private void b_killsafe_Click(object sender, EventArgs e)
        {
            //Kill application
            total = Killer.Kill(name, true);

            //Write to Log Window
            WriteLog();
            LoadList();
        }

        //When the user selects a process from the list
        private void lv_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_processes.SelectedItems.Count == 0)
                return;

            name = lv_processes.SelectedItems[0].SubItems[0].Text;
            tb_process.Text = lv_processes.SelectedItems[0].SubItems[0].Text;
        }

        //When 'Refresh' is clicked
        private void b_refresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        //When the user selects a sort option from the drop down list
        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_sort.SelectedItem.ToString())
            {
                case "Name (Desc)":
                    config.SortColumn = "Name";
                    config.SortOrder = "desc";
                    LoadList();
                    break;
                case "Name (Asc)":
                    config.SortColumn = "Name";
                    config.SortOrder = "asc";
                    LoadList();
                    break;
                case "Total Processes (Desc)":
                    config.SortColumn = "ProcessTotal";
                    config.SortOrder = "desc";
                    LoadList();
                    break;
                case "Total Processes (Asc)":
                    config.SortColumn = "ProcessTotal";
                    config.SortOrder = "asc";
                    LoadList();
                    break;
                case "Total Memory (Desc)":
                    config.SortColumn = "MemoryTotal";
                    config.SortOrder = "desc";
                    LoadList();
                    break;
                case "Total Memory (Asc)":
                    config.SortColumn = "MemoryTotal";
                    config.SortOrder = "asc";
                    LoadList();
                    break;
            }
        }
#endregion

#region Functionality

        /// <summary>
        /// Checks if the process provided in the parameter exists
        /// </summary>
        /// <param name="nameCheck">The name of a process</param>
        /// <returns></returns>
        private int CheckProcess(string nameCheck)
        {
            //Pause to allow delete to take place
            Thread.Sleep(250);

            //Declare and initialise local variable
            int totalCheck = 0;

            //Loop through processes for a given name to check if any appear
            foreach (var process in Process.GetProcessesByName(nameCheck))
            {

                totalCheck++;
            }

            //If the total is found to be higher than 0, send back the total found and return 0
            if (totalCheck > 0)
            {
                total = totalCheck;
                return 0;

            }
            else
                return 1;

        }

        /// <summary>
        /// Writes success or failure message to the log section
        /// </summary>
        private void WriteLog()
        {
            //declare local variables
            string log;
            int ProcessSucceed = 0;

            //If Total was 0 break out
            if (total == 0)
            {
                log = $"{name} was not found.";
                rt_log.AppendText(log);
                rt_log.AppendText(Environment.NewLine);
                return;
            }

            //call CheckProcess method to see if processes were all killed
            ProcessSucceed = CheckProcess(name);

            //if 1 is returned - success
            if (ProcessSucceed == 1)
                log = $"{total} instances of {name} have been killed";
            else
                log = $"{name} was not successfully killed. {total} instances remain.";

            //appent textbox with log message and start new line
            rt_log.AppendText(log);
            rt_log.AppendText(Environment.NewLine);

        }
        /// <summary>
        /// 1. Gets a list of all system processes currently running
        /// 2. Sorts them into an order as specified in the global Config object
        /// 3. Presents the list to the UI
        /// </summary>
        private void LoadList()
        {
            processes = new List<ProcessDetail>();

            //1. Get processes
            foreach (var process in Process.GetProcesses())
            {
                string pName = process.ProcessName;

                if (processes.Find(x => x.ProcessName == pName) == null)
                {
                    //Add first instance of a process to the list
                    processes.Add(new ProcessDetail { ProcessName = process.ProcessName, ProcessTotal = 1, MemoryTotal = (process.PagedMemorySize64 / 1000) });
                }
                else
                {
                    //Add all further instances of the process to the totals
                    var proc = processes.Find(x => x.ProcessName == pName);
                    proc.ProcessTotal++;
                    proc.MemoryTotal = proc.MemoryTotal + (process.PagedMemorySize64 / 1000);
                }
            }

            //2. Sort the list according to global Config object
            switch (config.SortColumn)
            {
                case "Name":
                    switch (config.SortOrder)
                    {
                        case "desc":
                            processes = processes.OrderByDescending(x => x.ProcessName).ToList();
                            break;
                        case "asc":
                            processes = processes.OrderBy(x => x.ProcessName).ToList();
                            break;
                    }
                    break;
                case "ProcessTotal":
                    switch (config.SortOrder)
                    {
                        case "desc":
                            processes = processes.OrderByDescending(x => x.ProcessTotal).ToList();
                            break;
                        case "asc":
                            processes = processes.OrderBy(x => x.ProcessTotal).ToList();
                            break;
                    }
                    break;
                case "MemoryTotal":
                    switch (config.SortOrder)
                    {
                        case "desc":
                            processes = processes.OrderByDescending(x => x.MemoryTotal).ToList();
                            break;
                        case "asc":
                            processes = processes.OrderBy(x => x.MemoryTotal).ToList();
                            break;
                    }
                    break;
            }

            //3. Present the list to the UI

            //Create columns and set width
            lv_processes.Columns.Clear();
            lv_processes.Columns.Add("Name");
            lv_processes.Columns.Add("Total Processes");
            lv_processes.Columns.Add("Total Memory");

            lv_processes.Columns[0].Width = 150;
            lv_processes.Columns[1].Width = 90;
            lv_processes.Columns[2].Width = 100;
            lv_processes.Width = 365;

            //Clear existing items and add each item to the ListView
            lv_processes.Items.Clear();
            var count = 0;
            foreach (var item in processes)
            {

                var process = new ListViewItem(new[] { processes[count].ProcessName, processes[count].ProcessTotal.ToString(), processes[count].MemoryTotal.ToString("N", new CultureInfo("en")).Replace(".00", " KB") });
                lv_processes.Items.Add(process);
                count++;
            }

        }
#endregion
    }


}
