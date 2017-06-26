using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPSYS
{
    public partial class Form1 : Form
    {
        public class Process
        {
            public string processName { get; set; }
            public int arrivalTime { get; set; }
            public int burstTime { get; set; }
            public int startTime { get; set; }
            public int endTime { get; set; }
            public int priorityLevel { get; set; }
            public int remainingTime { get; set; }
            public int TAT { set; get; }
            public int WT { set; get; }

            public List<int> multiple_end = new List<int>();

            public Process(string processName, int arrivalTime, int burstTime) {
                this.processName = processName;
                this.arrivalTime = arrivalTime;
                this.burstTime = burstTime;
                this.remainingTime = burstTime;
            }

            public Process(string processName, int arrivalTime, int burstTime, int priorityLevel) {
                this.processName = processName;
                this.arrivalTime = arrivalTime;
                this.burstTime = burstTime;
                this.remainingTime = burstTime;
                this.priorityLevel = priorityLevel;
            }

            public void addEnd(int end) {
                this.multiple_end.Add(end);
            }

            public List<int> getEnd() {
                return this.multiple_end;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scheduling_type.SelectedIndex = 0;

        }

        //first come first serve non-preemptive
        private string fcfsnp() {
            string return_val = "";
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));
            var result = processes.OrderBy(Process => Process.arrivalTime).ToList();
            int current_time = 0;
            foreach (Process p in result)
            {
                p.startTime = current_time;

                for (int i = 0; i < p.burstTime; i++)
                {
                    if (current_time == 0)
                    {
                        return_val += String.Format("?{0}={1}", current_time, p.processName);
                    }
                    else {
                        return_val += String.Format("&{0}={1}", current_time, p.processName);
                    }
                    Console.Write("[{0}]", p.processName);   
                    current_time++;
                }
                p.endTime = current_time;

                p.TAT = p.endTime - p.arrivalTime;
                p.WT = p.startTime - p.arrivalTime;

                textBox1.AppendText(String.Format("Process #{0} TAT: {1}" + Environment.NewLine, p.processName, p.TAT));
                textBox1.AppendText(String.Format("Process #{0} WT: {1}" + Environment.NewLine, p.processName, p.WT));
            }
            return return_val;
        }

        //first come first serve pre-emptive
        private string fcfsp() {
            string return_val = "";
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));

            foreach (Process p in processes) total_burst += p.burstTime;
            int current_time = 0;
            for (int i = 0; i < total_burst; i++)
            {
                if (processes.Count >= 0)
                {
                    var result = processes.SingleOrDefault(Process => Process.arrivalTime == i);
                    
                    if (result != null)
                    {
                        result.startTime = current_time;
                        for (int j = 0; j < result.burstTime; j++)
                        {
                            if (current_time == 0)
                            {
                                return_val += String.Format("?{0}={1}", current_time, result.processName);
                            }
                            else {
                                return_val += String.Format("&{0}={1}", current_time, result.processName);
                            }
                            Console.Write("[{0}]", result.processName);
                            current_time++;
                        }
                        result.endTime = current_time;
                        result.TAT = result.endTime - result.arrivalTime;
                        result.WT = result.startTime - result.arrivalTime;

                        textBox1.AppendText(String.Format("Process #{0} TAT: {1}" + Environment.NewLine, result.processName, result.TAT));
                        textBox1.AppendText(String.Format("Process #{0} WT: {1}" + Environment.NewLine, result.processName, result.WT));
                    }
                }
            }
            return return_val;
        }

        //shortest job next non-preemptive
        private string sjnnp()
        {
            string return_val = "";
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));
            var result = processes.OrderBy(Process => Process.burstTime).ToList();
            int current_time = 0;
            foreach (Process p in result) {
                p.startTime = current_time;
                for (int i = 0; i < p.burstTime; i++) {
                    if (current_time == 0)
                    {
                        return_val += String.Format("?{0}={1}", current_time, p.processName);
                    }
                    else {
                        return_val += String.Format("&{0}={1}", current_time, p.processName);
                    }
                    Console.Write("[{0}]",p.processName);
                    current_time++;
                }
                p.endTime = current_time;

                p.TAT = p.endTime - p.arrivalTime;
                p.WT = p.startTime - p.arrivalTime;

                textBox1.AppendText(String.Format("Process #{0} TAT: {1}" + Environment.NewLine, p.processName, p.TAT));
                textBox1.AppendText(String.Format("Process #{0} WT: {1}" + Environment.NewLine, p.processName, p.WT));
            }
            return return_val;
        }
        //shortest job next preemptive
        private string sjnp() {
            string return_val = "";
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));

            foreach (Process p in processes) total_burst += p.burstTime;
            int current_time = 0;
            for (int i=0;i<total_burst;i++) {
                if (processes.Count >= 0){
                    var result = processes.SingleOrDefault(Process => Process.arrivalTime == i);
                    if (result != null) {
                        result.startTime = current_time;
                        for (int j = 0; j < result.burstTime; j++){
                            if (current_time == 0)
                            {
                                return_val += String.Format("?{0}={1}", current_time, result.processName);
                            }
                            else {
                                return_val += String.Format("&{0}={1}", current_time, result.processName);
                            }
                            Console.Write("[{0}]", result.processName);
                            current_time++;
                        }
                        result.endTime = current_time;
                        result.TAT = result.endTime - result.arrivalTime;
                        result.WT = result.startTime - result.arrivalTime;

                        textBox1.AppendText(String.Format("Process #{0} TAT: {1}" + Environment.NewLine, result.processName, result.TAT));
                        textBox1.AppendText(String.Format("Process #{0} WT: {1}" + Environment.NewLine, result.processName, result.WT));
                    }
                }
            }
            return return_val;
        }
        //shortest remaining time
        private string srt() {
            string return_val = "";
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));

            foreach (Process p in processes) total_burst += p.burstTime;
            Console.WriteLine(total_burst);

            int total = 0;
            Boolean hasStarted = false;
            Random r = new Random();
            for (int i=0; i<total_burst; i++) {
                if (processes.Count > 0) {
                    var result = processes.Where(Process => Process.arrivalTime <= i).ToList();
                    var orderedResult = result.OrderBy(Process => Process.remainingTime).ToList();
                    var firstResult = orderedResult.FirstOrDefault();
                    if (firstResult != null) {
                        if (firstResult.remainingTime == 0){
                            processes.Remove(firstResult);
                        }
                        else {
                            if (firstResult.remainingTime == 1) {
                                firstResult.multiple_end.Add(i);
                            } else if (firstResult.remainingTime == firstResult.burstTime) {
                                firstResult.startTime = i;
                            }
                            if (hasStarted)
                            {
                                return_val += String.Format("&{0}={1}", r.Next(1, 9999), firstResult.processName);
                            }
                            else {
                                return_val += String.Format("?{0}={1}", r.Next(1, 9999), firstResult.processName);
                                hasStarted = true;
                            }
                            
                            
                            Console.Write("[{0}]", firstResult.processName);
                            firstResult.remainingTime--;
                            total++;
                        }
                    }
                }
                if (i == total_burst-1) {
                    if (total < total_burst) {
                        i -= total_burst - total;
                    }
                }
            }
            return return_val;
        }

        //Priority based scheduling non-preemptive
        private string psnp() {
            string return_val = "";
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text), int.Parse(p0_p.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text), int.Parse(p1_p.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text), int.Parse(p2_p.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text), int.Parse(p3_p.Text)));

            List<Process> temp_process = new List<Process>();
            foreach (Process p in processes) total_burst += p.burstTime;
            Boolean hasStarted = false;
            Random r = new Random();
            int current_time = 0;
            for (int i = 0; i < total_burst; i++){
                if (processes.Count >= 0){
                    var result = processes
                        .Where(Process => Process.arrivalTime <= i)
                        .OrderBy(Process => Process.priorityLevel)
                        .ToList();
                    var firstResult = result.FirstOrDefault();
                    if (firstResult != null) {
                        firstResult.startTime = i;
                        for (int j = 0; j < firstResult.burstTime; j++){
                            if (hasStarted)
                            {
                                return_val += String.Format("&{0}={1}", r.Next(1, 9999), firstResult.processName);
                            }
                            else {
                                return_val += String.Format("?{0}={1}", r.Next(1, 9999), firstResult.processName);
                                hasStarted = true;
                            }
                            Console.Write("[{0}]", firstResult.processName);
                        }
                        firstResult.endTime = i;
                        firstResult.TAT = firstResult.endTime - firstResult.arrivalTime;
                        firstResult.WT = firstResult.startTime - firstResult.arrivalTime;
                        textBox1.AppendText(String.Format("Process #{0} TAT: {1}" + Environment.NewLine, firstResult.processName, firstResult.TAT));
                        textBox1.AppendText(String.Format("Process #{0} WT: {1}" + Environment.NewLine, firstResult.processName, firstResult.WT));
                        temp_process.Add(firstResult);
                        processes.Remove(firstResult);
                    }
                }
            }
            return return_val;
        }

        //priority based scheduling pre-emptive
        public string psp() {
            string return_val = "";
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text), int.Parse(p0_p.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text), int.Parse(p1_p.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text), int.Parse(p2_p.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text), int.Parse(p3_p.Text)));

            foreach (Process p in processes) total_burst += p.burstTime;
            Console.WriteLine(total_burst);
            Boolean hasStarted = false;
            Random r = new Random();
            int total = 0;
            for (int i = 0; i < total_burst; i++){
                if (processes.Count > 0){
                    var result = processes.Where(Process => Process.arrivalTime <= i).ToList();
                    var orderedResult = result.OrderBy(Process => Process.priorityLevel).ToList();
                    var firstResult = orderedResult.FirstOrDefault();
                    if (firstResult != null){
                        if (firstResult.remainingTime == 0){
                            processes.Remove(firstResult);
                        }else {
                            if (hasStarted)
                            {
                                return_val += String.Format("&{0}={1}", r.Next(1, 9999), firstResult.processName);
                            }
                            else {
                                return_val += String.Format("?{0}={1}", r.Next(1, 9999), firstResult.processName);
                                hasStarted = true;
                            }
                            Console.Write("[{0}]", firstResult.processName);
                            firstResult.remainingTime--;
                            total++;
                        }
                    }
                }
                if (i == total_burst - 1){
                    if (total < total_burst){
                        i -= total_burst - total;
                    }
                }
            }
            return return_val;
        }

        //round robin scheduling
        private string rr() {
            string return_val = "";
            int total_burst = 0;
            int quantum = int.Parse(p0_p.Text);
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", int.Parse(p0_at.Text), int.Parse(p0_bt.Text)));
            processes.Add(new Process("1", int.Parse(p1_at.Text), int.Parse(p1_bt.Text)));
            processes.Add(new Process("2", int.Parse(p2_at.Text), int.Parse(p2_bt.Text)));
            processes.Add(new Process("3", int.Parse(p3_at.Text), int.Parse(p3_bt.Text)));
            foreach (Process p in processes) total_burst += p.burstTime;
            var sortedProcess = processes.OrderBy(Process => Process.arrivalTime).ToList();
            Boolean hasStarted = false;
            Random r = new Random();
            while (sortedProcess.Count > 0) {
                var current_process = sortedProcess.First();
                if (current_process.remainingTime == 0) {
                    sortedProcess.Remove(current_process);
                } else {
                    int total_deducted = 0;
                    for (int i = 0; i < quantum; i++) {
                        if (current_process.remainingTime > 0) {
                            total_deducted++;
                            current_process.remainingTime--;
                            if (hasStarted)
                            {
                                return_val += String.Format("&{0}={1}", r.Next(1, 9999), current_process.processName);
                            }
                            else {
                                return_val += String.Format("?{0}={1}", r.Next(1, 9999), current_process.processName);
                                hasStarted = true;
                            }
                            Console.Write("[{0}]", current_process.processName);
                        }
                    }
                    sortedProcess.Remove(current_process);
                    if (current_process.remainingTime > 0) {
                        sortedProcess.Add(new Process(
                            current_process.processName, 
                            current_process.arrivalTime, 
                            current_process.burstTime - total_deducted
                            ));
                    }
                }
            }
            return return_val;
        }

        private void scheduling_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (scheduling_type.SelectedIndex == 5 || scheduling_type.SelectedIndex == 6)
            {
                label5.Visible = true;
                p0_p.Visible = true;
                p1_p.Visible = true;
                p2_p.Visible = true;
                p3_p.Visible = true;
                label5.Text = "Priority";
            }else if (scheduling_type.SelectedIndex == 7)
            {
                label5.Text = "Quantum";
                label5.Visible = true;
                p0_p.Visible = true;
                p1_p.Visible = false;
                p2_p.Visible = false;
                p3_p.Visible = false;
            }else {
                label5.Visible = false;
                p0_p.Visible = false;
                p1_p.Visible = false;
                p2_p.Visible = false;
                p3_p.Visible = false;
            }
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            processBtn.Enabled = true;
            textBox1.Text = "";
            string base_url = "http://localhost/opsys_final/process/tables/index.php";
            switch (scheduling_type.SelectedIndex) {
                case 0:
                    webBrowser1.Navigate(base_url + fcfsnp());
                    break;
                case 1:
                    webBrowser1.Navigate(base_url + fcfsp());
                    break;
                case 2:
                    webBrowser1.Navigate(base_url + sjnnp());
                    break;
                case 3:
                    webBrowser1.Navigate(base_url + sjnp());
                    break;
                case 4:
                    webBrowser1.Navigate(base_url + srt());
                    break;
                case 5:
                    webBrowser1.Navigate(base_url + psnp());
                    break;
                case 6:
                    webBrowser1.Navigate(base_url + psp());
                    break;
                case 7:
                    webBrowser1.Navigate(base_url + rr());
                    break;
            }
        }
    }
}
