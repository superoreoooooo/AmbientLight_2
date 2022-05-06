using System.IO.Ports;

namespace AmbientLight_2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        int brightness = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void cbb_serial_Click(object sender, EventArgs e)
        {
            cbb_serial.Items.Clear();
            foreach(var item in SerialPort.GetPortNames())
            {
                cbb_serial.Items.Add(item);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (cbb_serial.Text == "") return;
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                else
                {
                    serialPort.PortName = cbb_serial.SelectedItem.ToString();
                    serialPort.BaudRate = 9600;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Parity = Parity.None;
                    serialPort.Open();
                }
            } catch
            {
                MessageBox.Show("연결오류", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_connect.Text = serialPort.IsOpen ? "연결해제" : "연결하기";
            cbb_serial.Enabled = !serialPort.IsOpen;
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            serialPort.Write("1");
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            serialPort.Write("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            serialPort.Write("2");
        }
    }
}