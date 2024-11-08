using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;
using System.Runtime.InteropServices;
using HWtest3.Properties;
using GetCoreTempInfoNET;
using System.Management;
using System.IO;
using System.Diagnostics;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using static HWtest3.Form1;
using Microsoft.VisualBasic.Devices;

namespace HWtest3
{
    public delegate void UpdateComboBoxDelegate(string item);

    public partial class Form1 : Form
    {
        public Point mouselocation;

        static LibreHardwareMonitor.Hardware.Computer computer = new LibreHardwareMonitor.Hardware.Computer()
        {
            IsCpuEnabled = true, // Enable CPU
            IsGpuEnabled = true, // Enable GPU
            IsMemoryEnabled = true // Enable Memory
        };
        private List<GPUdata> gpus = new List<GPUdata>();
        static ManagementObjectSearcher wmiObject =
            new ManagementObjectSearcher("select * from Win32_OperatingSystem");
        static string CPUname = "";
        static GPUdata GPU1 = new GPUdata();
        static GPUdata CPU1 = new GPUdata();
        int CPUload;
        int CPUtemp;
        double RAMused = 0.0;
        double RAMtotal = 0.0;
        bool isFahrenheit;
        private bool gpusLoaded = false;
        bool ComboBoxset = false;

        public Form1()
        {
            InitializeComponent();
            

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            loadValues();
        }
        private void Tempchange_Click(object sender, EventArgs e)
        {
            if (this.isFahrenheit)
            {
                this.isFahrenheit = false;
                Tempchange.Text = "Fahrenheit";
                Settings.Default.Fahrenheit = false;
            }
            else
            {
                this.isFahrenheit = true;
                Tempchange.Text = "Celsius";
                Settings.Default.Fahrenheit = true;
            }
            Settings.Default.Save();
        }
        protected override void OnPaintBackground(PaintEventArgs p)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.OnPaintBackground(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isFahrenheit = GetSettings();
            if (isFahrenheit)
            {
                Tempchange.Text = "Celsius";

            }
            else
            {
                Tempchange.Text = "Fahrenheit";

            }

        }
        public bool GetSettings()
        {
            return Settings.Default.Fahrenheit;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();*/
        }
        // DLL imports
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
            //  mouseloaction = new Point(-e.X, -e.Y);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(Handle, 0x112, 0xf012, 0);
            //  mouseloaction = new Point(-e.X, -e.Y);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //  MoveMouse(e);
        }

        //annoying on click stuff that needs to be removed 
        private void Gpu1ProgressBar_Click(object sender, EventArgs e)
        {

        }
        private void Gpu2ProgressBar_Click(object sender, EventArgs e)
        {

        }
        private void VRAMbar1_Click(object sender, EventArgs e)
        {

        }
        //Temp 
        private int ConvertTemperature(int temperatureCelsius)
        {
            return isFahrenheit ? (int)(temperatureCelsius * 1.8 + 32) : temperatureCelsius;
        }
        private string TemperatureUnitLabel()
        {
            return isFahrenheit ? "°F" : "°C";
        }

        //Get Hardware data 
        private void loadValues()
        {
            
            getMemorydata();
            getCPUData();
            getGPUData();
            UpdateHardwareMetricsToGUI();
            //ShowAllHardwareData();
        }

        
        private CPUData cpuData; // Define a field to store the CPU data object
        private void getCPUData()
        {
            computer.Open();
            float totalLoad = 0f;
            List<float> temperatures = new List<float>();
            string cpuName = "";
            float cpuFrequency = 0f;

            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.Cpu)
                {
                    cpuName = hardwareItem.Name;
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            totalLoad = sensor.Value.HasValue ? sensor.Value.Value : 0f;
                        }
                        else if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                        {
                            temperatures.Add(sensor.Value.Value);
                        }
                        else if (sensor.SensorType == SensorType.Clock && sensor.Value.HasValue)
                        {
                            cpuFrequency = sensor.Value.Value / 1000.0f; // Convert MHz to GHz
                            break;
                        }
                    }
                }
            }

            int averageTemperature = temperatures.Count > 0 ? (int)temperatures.Average() : 0;

            // Create a new CPUData object with the gathered information
            cpuData = new CPUData(cpuName, (int)totalLoad, averageTemperature, cpuFrequency);

            computer.Close();
           
        }
        private void ShowCpuDataMessageBox()
        {
            if (cpuData != null) // Ensure cpuData is not null
            {
                string message = $"CPU Name: {cpuData.Name}\n" +
                                 $"CPU Total Load: {cpuData.TotalLoad}%\n" +
                                 $"Average CPU Temperature: {cpuData.AverageTemperature}°C\n" +
                                 $"CPU Frequency: {cpuData.Frequency:0.0} GHz";
                MessageBox.Show(message, "CPU Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CPU data is not available. Please ensure 'getCPUData()' was called successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //GPU data
        public class GPUData
        {
            public string Name { get; set; }
            public int TotalLoad { get; set; }
            public int AverageTemperature { get; set; }
            public float Frequency { get; set; } // GHz
            public int TotalMemory { get; set; } // GB
            public float UsedMemory { get; set; } // GB, rounded to two decimal places

            public GPUData(string name, int totalLoad, int averageTemperature, float frequency, int totalMemory, float usedMemory)
            {
                Name = name;
                TotalLoad = totalLoad;
                AverageTemperature = averageTemperature;
                Frequency = frequency;
                TotalMemory = totalMemory;
                UsedMemory = usedMemory;
            }
        }
        private List<GPUData> gpuDatas = new List<GPUData>(); // List to store data of each GPU
        private void getGPUData()
        {
            computer.Open();
            gpuDatas.Clear(); // Clear existing GPU data

            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAmd || hardwareItem.Name.Contains("Intel"))
                {
                    hardwareItem.Update();
                    string gpuName = hardwareItem.Name;
                    int totalLoad = 0;
                    int averageTemperature = 0;
                    float frequency = 0f;
                    int totalMemory = 0;
                    float usedMemory = 0f;
                    List<float> temperatures = new List<float>();

                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("gpu core"))
                        {
                            totalLoad = (int)(sensor.Value ?? 0);
                        }
                        else if (sensor.SensorType == SensorType.Temperature)
                        {
                            temperatures.Add(sensor.Value ?? 0);
                        }
                        else if (sensor.SensorType == SensorType.Clock && sensor.Name.ToLower().Contains("gpu core"))
                        {
                            frequency = (sensor.Value ?? 0) / 1000.0f; // Convert MHz to GHz
                        }
                        else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("memory total"))
                        {
                            totalMemory = (int)Math.Round((sensor.Value ?? 0) / 1024); // Convert MB to GB
                        }
                        else if (sensor.SensorType == SensorType.SmallData && sensor.Name.ToLower().Contains("memory used"))
                        {
                            usedMemory = (float)Math.Round((sensor.Value ?? 0) / 1024, 2); // Convert MB to GB, rounding to two decimal places
                        }
                    }

                    if (temperatures.Count > 0)
                    {
                        averageTemperature = (int)temperatures.Average();
                    }

                    // Create a new GPUData object for each GPU and add it to the list
                    gpuDatas.Add(new GPUData(gpuName, totalLoad, averageTemperature, frequency, totalMemory, usedMemory));
                }
            }

            // Sort GPUs putting integrated GPUs (with totalMemory == 0) at the bottom of the list
            gpuDatas = gpuDatas.OrderBy(gpu => gpu.TotalMemory == 0).ToList();

            computer.Close();
            // Populate comboBox1 with GPU names, ensuring it's only done once
            if (!ComboBoxset && gpuDatas.Any())
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        PopulateComboBox();
                    });
                }
                else
                {
                    PopulateComboBox();
                }

                void PopulateComboBox()
                {
                    comboBox1.Items.Clear();
                    foreach (var gpu in gpuDatas)
                    {
                        comboBox1.Items.Add(gpu.Name);
                    }
                    if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0; // Select the first GPU by default
                    ComboBoxset = true; // Prevent future population
                }
            }
        }


        private void ShowGPUDataMessageBox()
        {
            foreach (var gpuData in gpuDatas)
            {
                string message = $"GPU Name: {gpuData.Name}\n" +
                                 $"GPU Core Load: {gpuData.TotalLoad}%\n" +
                                 $"Average GPU Temperature: {gpuData.AverageTemperature}°C\n" +
                                 $"GPU Core Frequency: {gpuData.Frequency:0.0} GHz\n" +
                                 $"Total Video Memory: {gpuData.TotalMemory} GB\n" +
                                 $"Used Video Memory: {gpuData.UsedMemory} GB";
                MessageBox.Show(message, "GPU Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Memory data
        private MemoryData memData;
        public class MemoryData
        {
            public double TotalMemoryGB { get; set; }
            public double UsedMemoryGB { get; set; }

            public MemoryData(double totalMemoryGB, double usedMemoryGB)
            {
                TotalMemoryGB = totalMemoryGB;
                UsedMemoryGB = usedMemoryGB;
            }
        }
        private void getMemorydata()
        {
            ComputerInfo ci = new ComputerInfo();
            ulong totalPhysicalMemoryBytes = ci.TotalPhysicalMemory;
            ulong availablePhysicalMemoryBytes = ci.AvailablePhysicalMemory;

            // Round total memory to the nearest whole number for gigabytes
            double totalMemoryGB = Math.Round((double)totalPhysicalMemoryBytes / (1024 * 1024 * 1024));
            // Keep the available memory rounded to two decimal places
            double availableMemoryGB = Math.Round((double)availablePhysicalMemoryBytes / (1024 * 1024 * 1024), 2);
            // Calculate used memory based on the above, rounding to two decimal places
            double usedMemoryGB = Math.Round(totalMemoryGB - availableMemoryGB, 2);

            // Update the memData object
            memData = new MemoryData(totalMemoryGB, usedMemoryGB);

            // Displaying the information as needed
           // MessageBox.Show($"Total Memory: {totalMemoryGB} GB\nUsed Memory: {usedMemoryGB} GB", "Memory Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Write to GUI
        private void UpdateHardwareMetricsToGUI()
        {
            // Update CPU Metrics
            if (cpuData != null)
            {
                cpuTempBar.Maximum = 101; // Example maximum value for temperature
                CPUnamebar.Text = cpuData.Name;
                cpuNumTemp.Text = ConvertTemperature(cpuData.AverageTemperature).ToString() + TemperatureUnitLabel();
                CPUusage.Text = cpuData.TotalLoad.ToString() + "%";
                CpuProgressBar.Value = Math.Min(CpuProgressBar.Maximum, cpuData.TotalLoad);
                CPUSpeed.Text = cpuData.Frequency.ToString("0.0") + " GHz";

                if (cpuData.AverageTemperature >= cpuTempBar.Maximum)
                {
                    cpuTempBar.Value = cpuTempBar.Maximum - 1;
                    MessageBox.Show("Your CPU is overheating", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cpuTempBar.Value = cpuData.AverageTemperature;
                }
            }

            // Update GPU Metrics
            if (comboBox1.SelectedIndex >= 0 && gpuDatas.Count > comboBox1.SelectedIndex)
            {
                var selectedGPUData = gpuDatas[comboBox1.SelectedIndex];

                // Check if GPU memory data is missing, indicating possibly an integrated GPU
                if (selectedGPUData.TotalMemory == 0 && selectedGPUData.UsedMemory == 0)
                {
                    // Hide GPU related UI elements because it's likely an integrated GPU
                    Gpu1ProgressBar.Visible = false;
                    gpu1NumTemp.Visible = false;
                    Gpu2ProgressBar.Visible = false;
                    label11.Visible = false; // Assuming this is a GPU label
                    GPU1RealTimeUsage.Visible = false;
                    VRAMbar1.Visible = false;
                    label22.Visible = false; // Assuming this is related to GPU memory usage
                    GPUSpeed.Visible = false;
                    label5.Visible = false;
                    label20.Visible = false;
                    label2.Visible = false;
                    label4.Visible = false;
                }
                else
                {
                    // Show and update GPU related UI elements for discrete GPUs
                    Gpu1ProgressBar.Visible = true;
                    gpu1NumTemp.Visible = true;
                    Gpu2ProgressBar.Visible = true;
                    label11.Visible = true; // Assuming this is a GPU label
                    GPU1RealTimeUsage.Visible = true;
                    VRAMbar1.Visible = true;
                    label22.Visible = true; // Assuming this is related to GPU memory usage
                    GPUSpeed.Visible = true;
                    label5.Visible = true;
                    label20.Visible = true;
                    label2.Visible = true;
                    label4.Visible = true;

                    // Update GPU metrics as previously
                    label11.Text = selectedGPUData.Name;
                    gpu1NumTemp.Text = ConvertTemperature(selectedGPUData.AverageTemperature).ToString() + TemperatureUnitLabel();

                    Gpu1ProgressBar.Value = selectedGPUData.AverageTemperature;
                    Gpu2ProgressBar.Value = selectedGPUData.TotalLoad;
                    GPU1RealTimeUsage.Text = selectedGPUData.TotalLoad.ToString() + "%";
                    double vramUsagePercentage = Math.Round((double)selectedGPUData.UsedMemory / selectedGPUData.TotalMemory * 100);
                    VRAMbar1.Value = (int)vramUsagePercentage;
                    VRAMbar1.CustomText = $"{selectedGPUData.UsedMemory:N2}/{selectedGPUData.TotalMemory:N2} GB";
                    label22.Text = $"{(int)vramUsagePercentage}%";
                    GPUSpeed.Text = selectedGPUData.Frequency.ToString("0.0") + " GHz";
                }
            }
            else
            {
                // If no GPU is selected or available, hide all GPU related UI elements
                Gpu1ProgressBar.Visible = false;
                gpu1NumTemp.Visible = false;
                Gpu2ProgressBar.Visible = false;
                label11.Visible = false;
                GPU1RealTimeUsage.Visible = false;
                VRAMbar1.Visible = false;
                label22.Visible = false;
                GPUSpeed.Visible = false;
                label5.Visible = false;
                label20.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
            }

            // Update RAM Metrics
            if (memData != null)
            {
                double ramUsagePercentage = Math.Round(memData.UsedMemoryGB / memData.TotalMemoryGB * 100);
                RAMusage.Text = ramUsagePercentage.ToString() + "%";
                RAMProgressBar1.CustomText = $"{memData.UsedMemoryGB:N2}/{memData.TotalMemoryGB:N2} GB";
                RAMProgressBar1.Value = Math.Min(100, (int)ramUsagePercentage);
            }
        }


        private void ShowAllHardwareData()
        {
            StringBuilder message = new StringBuilder();

            // CPU Data
            if (cpuData != null)
            {
                message.AppendLine("CPU Data:");
                message.AppendLine($"Name: {cpuData.Name}");
                message.AppendLine($"Total Load: {cpuData.TotalLoad}%");
                message.AppendLine($"Average Temperature: {cpuData.AverageTemperature}°C");
                message.AppendLine($"Frequency: {cpuData.Frequency:0.0} GHz");
                message.AppendLine();
            }

            // GPU Data
            if (gpuDatas.Any())
            {
                message.AppendLine("GPU Data:");
                foreach (var gpuData in gpuDatas)
                {
                    message.AppendLine($"Name: {gpuData.Name}");
                    message.AppendLine($"Core Load: {gpuData.TotalLoad}%");
                    message.AppendLine($"Average Temperature: {gpuData.AverageTemperature}°C");
                    message.AppendLine($"Core Frequency: {gpuData.Frequency:0.0} GHz");
                    message.AppendLine($"Total Video Memory: {gpuData.TotalMemory} GB");
                    message.AppendLine($"Used Video Memory: {gpuData.UsedMemory} GB");
                    message.AppendLine();
                }
            }

            // Memory Data
            if (memData != null)
            {
                message.AppendLine("Memory Data:");
                message.AppendLine($"Total Memory: {memData.TotalMemoryGB} GB");
                message.AppendLine($"Used Memory: {memData.UsedMemoryGB} GB");
            }

            MessageBox.Show(message.ToString(), "System Hardware Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Assuming timer1 is the System.Windows.Forms.Timer you're referring to

            using (ListAllHardwareForm listAllHardwareForm = new ListAllHardwareForm())
            {
                listAllHardwareForm.ShowDialog(); // This makes the form modal.
            }

            timer1.Start(); // Resume the timer after closing the modal form
        }
    }
    //CPU data
    public class CPUData
    {
        public string Name { get; set; }
        public int TotalLoad { get; set; }
        public int AverageTemperature { get; set; }
        public float Frequency { get; set; } // GHz

        public CPUData(string name, int totalLoad, int averageTemperature, float frequency)
        {
            Name = name;
            TotalLoad = totalLoad;
            AverageTemperature = averageTemperature;
            Frequency = frequency;
        }
    }
}
