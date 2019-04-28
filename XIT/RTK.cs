using System;
using System.Windows.Forms;
using XIT.Message;
using XIT.RTKMessage;

namespace XIT
{
    public partial class RTK: Form
    {
        private DataGridViewTextBoxColumn GPStime;          //时间
        private DataGridViewTextBoxColumn Latitude;         //纬度
        private DataGridViewTextBoxColumn Longitude;        //经度
        private DataGridViewTextBoxColumn MsgStatus;        //解状态 0：无效解；1：单点定位解；2：伪距差分；4：固定解；5：浮动解；
        private DataGridViewTextBoxColumn PlanetNum;        //卫星数
        private DataGridViewTextBoxColumn DiffCorDelay;     //差分校正时延（秒）
        private DataGridViewTextBoxColumn Yaw;              //方位角(0~360)
        private DataGridView dataGridView1;
        private System.ComponentModel.IContainer components;
        private DataGridView dataGridView_RTK;

        public RTK()
        {
            InitializeComponent();
            timerRTK.Start();
        }

        private void RTKDataShow(object sender, EventArgs e)
        {
            dataGridView_RTK.Rows[0].Cells["GPStime"].Value     = GPGGA.GetInstance().UTCtime;
            dataGridView_RTK.Rows[0].Cells["Latitude"].Value    = GPGGA.GetInstance().Latitude;
            dataGridView_RTK.Rows[0].Cells["Longitude"].Value   = GPGGA.GetInstance().Longitude;
            dataGridView_RTK.Rows[0].Cells["MsgStatus"].Value  = GPGGA.GetInstance().MsgStatus;
            dataGridView_RTK.Rows[0].Cells["PlanetNum"].Value   = GPGGA.GetInstance().PlanetNum;
            dataGridView_RTK.Rows[0].Cells["DiffCorDelay"].Value = GPGGA.GetInstance().DiffCorDelay;
            dataGridView_RTK.Rows[0].Cells["Yaw"].Value          = HEADINGA.GetInstance().Yaw;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_RTK = new System.Windows.Forms.DataGridView();
            this.GPStime        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgStatus      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanetNum      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffCorDelay   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaw            = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timerRTK = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RTK
            // 
            this.dataGridView_RTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GPStime,
            this.Latitude,
            this.Longitude,
            this.MsgStatus,
            this.PlanetNum,
            this.DiffCorDelay,
            this.Yaw});
            this.dataGridView_RTK.Location = new System.Drawing.Point(12, 1);
            this.dataGridView_RTK.Name = "dataGridView_RTK";
            this.dataGridView_RTK.RowTemplate.Height = 23;
            this.dataGridView_RTK.Size = new System.Drawing.Size(833, 430);
            this.dataGridView_RTK.TabIndex = 0;
            // 
            // GPStime
            // 
            this.GPStime.HeaderText = "GPStime";
            this.GPStime.Name = "GPStime";
            this.GPStime.ReadOnly = true;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            // 
            // MsgStatus
            // 
            this.MsgStatus.HeaderText = "MsgStatus";
            this.MsgStatus.Name = "MsgStatus";
            // 
            // PlanetNum
            // 
            this.PlanetNum.HeaderText = "PlanetNum";
            this.PlanetNum.Name = "PlanetNum";
            // 
            // DiffCorDelay
            // 
            this.DiffCorDelay.HeaderText = "DiffCorDelay";
            this.DiffCorDelay.Name = "DiffCorDelay";
            // 
            // Yaw
            // 
            this.Yaw.HeaderText = "Yaw";
            this.Yaw.Name = "Yaw";

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 1;
            // 
            // timerRTK
            // 
            this.timerRTK.Interval = 200;
            this.timerRTK.Tick += new System.EventHandler(this.RTKDataShow);
            // 
            // RTK
            // 
            this.ClientSize = new System.Drawing.Size(857, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView_RTK);
            this.Name = "RTK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        // 
        // TimerRTK
        // 
        private System.Windows.Forms.Timer timerRTK;
    }
}
