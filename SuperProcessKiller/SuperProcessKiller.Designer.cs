namespace SuperProcessKiller
{
    partial class SuperProcessKiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperProcessKiller));
            this.b_kill = new System.Windows.Forms.Button();
            this.tb_process = new System.Windows.Forms.TextBox();
            this.b_killsafe = new System.Windows.Forms.Button();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.rt_log = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_processes = new System.Windows.Forms.ListView();
            this.b_refresh = new System.Windows.Forms.Button();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.lbl_sort = new System.Windows.Forms.Label();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_kill
            // 
            this.b_kill.Location = new System.Drawing.Point(12, 61);
            this.b_kill.Name = "b_kill";
            this.b_kill.Size = new System.Drawing.Size(122, 23);
            this.b_kill.TabIndex = 0;
            this.b_kill.Text = "Kill";
            this.b_kill.UseVisualStyleBackColor = true;
            this.b_kill.Click += new System.EventHandler(this.b_kill_Click);
            // 
            // tb_process
            // 
            this.tb_process.Location = new System.Drawing.Point(12, 35);
            this.tb_process.Name = "tb_process";
            this.tb_process.Size = new System.Drawing.Size(281, 20);
            this.tb_process.TabIndex = 1;
            // 
            // b_killsafe
            // 
            this.b_killsafe.Location = new System.Drawing.Point(168, 61);
            this.b_killsafe.Name = "b_killsafe";
            this.b_killsafe.Size = new System.Drawing.Size(122, 23);
            this.b_killsafe.TabIndex = 2;
            this.b_killsafe.Text = "Kill (Safe)";
            this.b_killsafe.UseVisualStyleBackColor = true;
            this.b_killsafe.Click += new System.EventHandler(this.b_killsafe_Click);
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Location = new System.Drawing.Point(12, 14);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(210, 13);
            this.lbl_instructions.TabIndex = 3;
            this.lbl_instructions.Text = "Enter process name or choose from the list:";
            // 
            // rt_log
            // 
            this.rt_log.BackColor = System.Drawing.SystemColors.Info;
            this.rt_log.Location = new System.Drawing.Point(12, 90);
            this.rt_log.Name = "rt_log";
            this.rt_log.ReadOnly = true;
            this.rt_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_log.Size = new System.Drawing.Size(278, 316);
            this.rt_log.TabIndex = 4;
            this.rt_log.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // lv_processes
            // 
            this.lv_processes.AutoArrange = false;
            this.lv_processes.FullRowSelect = true;
            this.lv_processes.GridLines = true;
            this.lv_processes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_processes.Location = new System.Drawing.Point(296, 35);
            this.lv_processes.MultiSelect = false;
            this.lv_processes.Name = "lv_processes";
            this.lv_processes.Size = new System.Drawing.Size(364, 371);
            this.lv_processes.TabIndex = 10;
            this.lv_processes.UseCompatibleStateImageBehavior = false;
            this.lv_processes.View = System.Windows.Forms.View.Details;
            this.lv_processes.SelectedIndexChanged += new System.EventHandler(this.lv_processes_SelectedIndexChanged);
            // 
            // b_refresh
            // 
            this.b_refresh.Location = new System.Drawing.Point(601, 11);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(59, 21);
            this.b_refresh.TabIndex = 12;
            this.b_refresh.Text = "Refresh";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // cb_sort
            // 
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Items.AddRange(new object[] {
            "Name (Desc)",
            "Name (Asc)",
            "Total Processes (Desc)",
            "Total Processes (Asc)",
            "Total Memory (Desc)",
            "Total Memory (Asc)"});
            this.cb_sort.Location = new System.Drawing.Point(474, 11);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(121, 21);
            this.cb_sort.TabIndex = 13;
            this.cb_sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // lbl_sort
            // 
            this.lbl_sort.AutoSize = true;
            this.lbl_sort.Location = new System.Drawing.Point(436, 14);
            this.lbl_sort.Name = "lbl_sort";
            this.lbl_sort.Size = new System.Drawing.Size(32, 13);
            this.lbl_sort.TabIndex = 14;
            this.lbl_sort.Text = "Sort: ";
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Location = new System.Drawing.Point(566, 409);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(97, 13);
            this.lbl_footer.TabIndex = 15;
            this.lbl_footer.Text = " 2017 - superclo.se";
            // 
            // SuperProcessKiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 431);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.lbl_sort);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.lv_processes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rt_log);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.b_killsafe);
            this.Controls.Add(this.tb_process);
            this.Controls.Add(this.b_kill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuperProcessKiller";
            this.Text = "Super Process Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_kill;
        private System.Windows.Forms.TextBox tb_process;
        private System.Windows.Forms.Button b_killsafe;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.RichTextBox rt_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_processes;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.Label lbl_sort;
        private System.Windows.Forms.Label lbl_footer;
    }
}

