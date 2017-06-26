using System;
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
            psp();
        }

        private void sjnnp()
        {
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", 0, 5));
            processes.Add(new Process("1", 0, 2));
            processes.Add(new Process("2", 0, 3));
            processes.Add(new Process("3", 0, 4));
            var result = processes.OrderBy(Process => Process.burstTime).ToList();
            foreach (Process p in result) {
                for (int i = 0; i < p.burstTime; i++) {
                    Console.Write("[{0}]",p.processName);
                }
            }
        }

        private void sjnp() {
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", 0, 5));
            processes.Add(new Process("1", 1, 2));
            processes.Add(new Process("2", 2, 3));
            processes.Add(new Process("3", 3, 4));

            foreach (Process p in processes) total_burst += p.burstTime;

            for (int i=0;i<total_burst;i++) {
                if (processes.Count >= 0){
                    var result = processes.SingleOrDefault(Process => Process.arrivalTime == i);
                    if (result != null) {
                        for (int j = 0; j < result.burstTime; j++){
                            Console.Write("[{0}]", result.processName);
                        }
                        processes.Remove(result);
                    }
                }
            }

        }

        private void srtnp() {

            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("A", 0, 6));
            processes.Add(new Process("B", 1, 3));
            processes.Add(new Process("C", 2, 1));
            processes.Add(new Process("D", 3, 4));

            foreach (Process p in processes) total_burst += p.burstTime;
            Console.WriteLine(total_burst);

            int total = 0;
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
                                //end time
                            } else if (firstResult.remainingTime == firstResult.burstTime) {
                                //started
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
        }

        private void psnp() {
            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("0", 0, 5, 2));
            processes.Add(new Process("1", 0, 2, 1));
            processes.Add(new Process("2", 0, 3, 3));
            processes.Add(new Process("3", 0, 4, 4));

            foreach (Process p in processes) total_burst += p.burstTime;

            for (int i = 0; i < total_burst; i++){
                if (processes.Count >= 0){
                    var result = processes
                        .Where(Process => Process.arrivalTime <= i)
                        .OrderBy(Process => Process.priorityLevel)
                        .ToList();
                    var firstResult = result.FirstOrDefault();
                    if (firstResult != null) {
                        for (int j = 0; j < firstResult.burstTime; j++){
                            Console.Write("[{0}]", firstResult.processName);
                        }
                        processes.Remove(firstResult);
                    }
                }
            }
        }

        public void psp() {

            int total_burst = 0;
            List<Process> processes = new List<Process>();
            processes.Add(new Process("A", 0, 6, 1));
            processes.Add(new Process("B", 3, 3, 0));
            processes.Add(new Process("C", 2, 1, 2));
            processes.Add(new Process("D", 1, 4, 3));

            foreach (Process p in processes) total_burst += p.burstTime;
            Console.WriteLine(total_burst);

            int total = 0;
            for (int i = 0; i < total_burst; i++)
            {
                if (processes.Count > 0)
                {
                    var result = processes.Where(Process => Process.arrivalTime <= i).ToList();
                    var orderedResult = result.OrderBy(Process => Process.priorityLevel).ToList();
                    var firstResult = orderedResult.FirstOrDefault();
                    if (firstResult != null)
                    {
                        if (firstResult.remainingTime == 0)
                        {
                            processes.Remove(firstResult);
                        }
                        else {
                            if (firstResult.remainingTime == 1)
                            {
                                //end time
                            }
                            else if (firstResult.remainingTime == firstResult.burstTime)
                            {
                                //started
                            }
                            Console.Write("[{0}]", firstResult.processName);
                            firstResult.remainingTime--;
                            total++;
                        }
                    }
                }
                if (i == total_burst - 1)
                {
                    if (total < total_burst)
                    {
                        i -= total_burst - total;
                    }
                }
            }
        }

    }
}
