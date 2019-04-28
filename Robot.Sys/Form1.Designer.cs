namespace Robot.Sys
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Rob = new System.Windows.Forms.Panel();
            this.label_Rob = new System.Windows.Forms.Label();
            this.dataGridView_Rob = new System.Windows.Forms.DataGridView();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label_log = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_Init = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rob)).BeginInit();
            this.panel_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Rob
            // 
            this.panel_Rob.Location = new System.Drawing.Point(24, 24);
            this.panel_Rob.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Rob.Name = "panel_Rob";
            this.panel_Rob.Size = new System.Drawing.Size(881, 38);
            this.panel_Rob.TabIndex = 0;
            // 
            // label_Rob
            // 
            this.label_Rob.AutoSize = true;
            this.label_Rob.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Rob.Location = new System.Drawing.Point(20, 20);
            this.label_Rob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Rob.Name = "label_Rob";
            this.label_Rob.Size = new System.Drawing.Size(85, 19);
            this.label_Rob.TabIndex = 0;
            this.label_Rob.Text = "设备列表";
            // 
            // dataGridView_Rob
            // 
            this.dataGridView_Rob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rob.Location = new System.Drawing.Point(24, 42);
            this.dataGridView_Rob.Name = "dataGridView_Rob";
            this.dataGridView_Rob.RowTemplate.Height = 23;
            this.dataGridView_Rob.Size = new System.Drawing.Size(881, 333);
            this.dataGridView_Rob.TabIndex = 1;
            // 
            // panel_log
            // 
            this.panel_log.Controls.Add(this.label_log);
            this.panel_log.Location = new System.Drawing.Point(24, 372);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(881, 32);
            this.panel_log.TabIndex = 2;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_log.Location = new System.Drawing.Point(6, 4);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(85, 19);
            this.label_log.TabIndex = 0;
            this.label_log.Text = "系统日志";
            // 
            // textBox_log
            // 
            this.textBox_log.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_log.Location = new System.Drawing.Point(24, 398);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(881, 290);
            this.textBox_log.TabIndex = 3;
            // 
            // button_Init
            // 
            this.button_Init.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Init.Location = new System.Drawing.Point(911, 24);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(86, 38);
            this.button_Init.TabIndex = 4;
            this.button_Init.Text = "初始化";
            this.button_Init.UseVisualStyleBackColor = true;
            this.button_Init.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Start.Location = new System.Drawing.Point(911, 79);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(86, 38);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "开启";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.btnSysStart_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Stop.Location = new System.Drawing.Point(911, 134);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(86, 38);
            this.button_Stop.TabIndex = 6;
            this.button_Stop.Text = "关闭";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.btnSysClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.label_Rob);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.dataGridView_Rob);
            this.Controls.Add(this.panel_Rob);
            this.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "机器人调度系统";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rob)).EndInit();
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Rob;
        private System.Windows.Forms.Label label_Rob;
        private System.Windows.Forms.DataGridView dataGridView_Rob;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
    }
}

