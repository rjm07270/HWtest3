using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;

namespace HWtest3
{
    internal class ListAllHardwareForm : Form
    {
        private List<HardwareComponent> hardwareComponents;

        public ListAllHardwareForm()
        {
            InitializeComponent();
            hardwareComponents = GetHardwareInformation();
            PopulateHardwareInformation();
        }

        private void InitializeComponent()
        {
            this.ClientSize = new Size(600, 800);
            this.Name = "ListAllHardwareForm";
            this.Text = "Hardware Information";
            this.BackColor = Color.Gray;
            this.AutoScroll = true;
        }

        private void PopulateHardwareInformation()
        {
            int verticalPosition = 10;
            float mainLabelFontSize = 12f; // Size for main hardware component labels
            float regularFontSize = 10f; // Size for other labels

            foreach (var component in hardwareComponents)
            {
                Label labelComponent = CreateLabel(component.Name, ref verticalPosition, mainLabelFontSize);
                this.Controls.Add(labelComponent);

                foreach (var sensor in component.Sensors)
                {
                    Label labelSensor = CreateLabel($" - {sensor.Name}: {sensor.Value}", ref verticalPosition, regularFontSize);
                    this.Controls.Add(labelSensor);
                }
            }
        }

        private Label CreateLabel(string text, ref int verticalPosition, float fontSize)
        {
            Label label = new Label
            {
                Text = text,
                Location = new Point(10, verticalPosition),
                Size = new Size(580, 23),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", fontSize)
            };

            verticalPosition += 25 + (int)(fontSize * 0.5); // Increment position for the next label
            return label;
        }

        private List<HardwareComponent> GetHardwareInformation()
        {
            var visitor = new UpdateVisitor();
            var computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true
            };

            computer.Open();
            computer.Accept(visitor); // Using the visitor pattern to update all hardware

            var hardwareList = new List<HardwareComponent>();

            foreach (IHardware hardware in computer.Hardware)
            {
                var hardwareComponent = new HardwareComponent
                {
                    Name = hardware.Name,
                    Sensors = new List<Sensor>()
                };

                AddSensors(hardwareComponent, hardware);

                foreach (IHardware subHardware in hardware.SubHardware)
                {
                    AddSensors(hardwareComponent, subHardware);
                }

                hardwareList.Add(hardwareComponent);
            }

            computer.Close();
            return hardwareList;
        }

        private void AddSensors(HardwareComponent hardwareComponent, IHardware hardware)
        {
            foreach (ISensor sensor in hardware.Sensors)
            {
                hardwareComponent.Sensors.Add(new Sensor
                {
                    Name = sensor.Name,
                    Value = sensor.Value.HasValue ? sensor.Value.Value.ToString("0.0") + " " + GetUnitOfMeasurement(sensor.SensorType) : "N/A"
                });
            }
        }

        private string GetUnitOfMeasurement(SensorType sensorType)
        {
            switch (sensorType)
            {
                case SensorType.Voltage:
                    return "V";
                case SensorType.Clock:
                    return "MHz";
                case SensorType.Temperature:
                    return "°C";
                case SensorType.Load:
                    return "%";
                case SensorType.Fan:
                    return "RPM";
                case SensorType.Flow:
                    return "L/h";
                case SensorType.Control:
                    return "%";
                case SensorType.Level:
                    return "%";
                case SensorType.Factor:
                    return "";
                case SensorType.Power:
                    return "W";
                case SensorType.Data:
                    return "GB";
                case SensorType.SmallData:
                    return "MB";
                // Add other cases for different sensor types if necessary
                default:
                    return "";
            }
        }

        public class HardwareComponent
        {
            public string Name { get; set; }
            public List<Sensor> Sensors { get; set; } = new List<Sensor>();
        }

        public class Sensor
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }

            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }

            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
    }
}
