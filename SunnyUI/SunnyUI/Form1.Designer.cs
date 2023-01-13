namespace SunnyUI
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
            this.cbxCOMPort = new Sunny.UI.UIComboBox();
            this.cbxBaudRate = new Sunny.UI.UIComboBox();
            this.cbxStopBits = new Sunny.UI.UIComboBox();
            this.cbxParity = new Sunny.UI.UIComboBox();
            this.cbxDataBits = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.rbnChar = new Sunny.UI.UIRadioButton();
            this.rbnHex = new Sunny.UI.UIRadioButton();
            this.btnCheckCom = new Sunny.UI.UIButton();
            this.btnOpenCom = new Sunny.UI.UIButton();
            this.groupBox1 = new Sunny.UI.UIGroupBox();
            this.groupBox2 = new Sunny.UI.UIGroupBox();
            this.tbxRecvData = new Sunny.UI.UITextBox();
            this.btnClearData = new Sunny.UI.UIButton();
            this.btnSendData = new Sunny.UI.UIButton();
            this.groupBox3 = new Sunny.UI.UIGroupBox();
            this.tbxSendData = new Sunny.UI.UITextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.DataSource = null;
            this.cbxCOMPort.FillColor = System.Drawing.Color.White;
            this.cbxCOMPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCOMPort.Location = new System.Drawing.Point(97, 37);
            this.cbxCOMPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCOMPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxCOMPort.Size = new System.Drawing.Size(171, 29);
            this.cbxCOMPort.TabIndex = 14;
            this.cbxCOMPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxCOMPort.Watermark = "";
            this.cbxCOMPort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DataSource = null;
            this.cbxBaudRate.FillColor = System.Drawing.Color.White;
            this.cbxBaudRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxBaudRate.Location = new System.Drawing.Point(97, 70);
            this.cbxBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxBaudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxBaudRate.Size = new System.Drawing.Size(171, 29);
            this.cbxBaudRate.TabIndex = 15;
            this.cbxBaudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxBaudRate.Watermark = "";
            this.cbxBaudRate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.DataSource = null;
            this.cbxStopBits.FillColor = System.Drawing.Color.White;
            this.cbxStopBits.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStopBits.Location = new System.Drawing.Point(97, 105);
            this.cbxStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStopBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxStopBits.Size = new System.Drawing.Size(171, 29);
            this.cbxStopBits.TabIndex = 16;
            this.cbxStopBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxStopBits.Watermark = "";
            this.cbxStopBits.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxParity
            // 
            this.cbxParity.DataSource = null;
            this.cbxParity.FillColor = System.Drawing.Color.White;
            this.cbxParity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxParity.Location = new System.Drawing.Point(409, 37);
            this.cbxParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxParity.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxParity.Size = new System.Drawing.Size(171, 29);
            this.cbxParity.TabIndex = 17;
            this.cbxParity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxParity.Watermark = "";
            this.cbxParity.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.DataSource = null;
            this.cbxDataBits.FillColor = System.Drawing.Color.White;
            this.cbxDataBits.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxDataBits.Location = new System.Drawing.Point(409, 70);
            this.cbxDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDataBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxDataBits.Size = new System.Drawing.Size(171, 29);
            this.cbxDataBits.TabIndex = 18;
            this.cbxDataBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxDataBits.Watermark = "";
            this.cbxDataBits.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(10, 39);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(80, 23);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "串口号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(10, 71);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(79, 23);
            this.uiLabel2.TabIndex = 20;
            this.uiLabel2.Text = "波特率：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(10, 107);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(76, 23);
            this.uiLabel3.TabIndex = 21;
            this.uiLabel3.Text = "停止位：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(312, 39);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(90, 23);
            this.uiLabel4.TabIndex = 22;
            this.uiLabel4.Text = "奇偶校验：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(312, 71);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(75, 23);
            this.uiLabel5.TabIndex = 23;
            this.uiLabel5.Text = "数据位：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rbnChar
            // 
            this.rbnChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnChar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnChar.Location = new System.Drawing.Point(316, 105);
            this.rbnChar.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbnChar.Size = new System.Drawing.Size(95, 29);
            this.rbnChar.TabIndex = 3;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rbnHex
            // 
            this.rbnHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnHex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnHex.Location = new System.Drawing.Point(449, 105);
            this.rbnHex.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbnHex.Size = new System.Drawing.Size(92, 29);
            this.rbnHex.TabIndex = 24;
            this.rbnHex.Text = "HEX显示";
            this.rbnHex.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCom.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckCom.Location = new System.Drawing.Point(619, 37);
            this.btnCheckCom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(89, 29);
            this.btnCheckCom.TabIndex = 25;
            this.btnCheckCom.Text = "检测串口";
            this.btnCheckCom.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckCom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCheckCom.Click += new System.EventHandler(this.btnCheckCom_Click);
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCom.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCom.Location = new System.Drawing.Point(619, 72);
            this.btnOpenCom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(89, 27);
            this.btnOpenCom.TabIndex = 26;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenCom);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.btnCheckCom);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.rbnHex);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.rbnChar);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.uiLabel5);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(27, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(743, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "串口设置";
            this.groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxRecvData);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(27, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox2.Size = new System.Drawing.Size(743, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "接收数据";
            this.groupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRecvData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxRecvData.Location = new System.Drawing.Point(14, 36);
            this.tbxRecvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxRecvData.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ShowText = false;
            this.tbxRecvData.Size = new System.Drawing.Size(714, 69);
            this.tbxRecvData.TabIndex = 0;
            this.tbxRecvData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxRecvData.Watermark = "";
            this.tbxRecvData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnClearData
            // 
            this.btnClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearData.Location = new System.Drawing.Point(619, 35);
            this.btnClearData.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(89, 27);
            this.btnClearData.TabIndex = 27;
            this.btnClearData.Text = "清空数据";
            this.btnClearData.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendData.Location = new System.Drawing.Point(619, 82);
            this.btnSendData.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(89, 27);
            this.btnSendData.TabIndex = 28;
            this.btnSendData.Text = "发送数据";
            this.btnSendData.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(27, 308);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox3.Size = new System.Drawing.Size(743, 128);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.Text = "发送数据";
            this.groupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tbxSendData
            // 
            this.tbxSendData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSendData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSendData.Location = new System.Drawing.Point(14, 36);
            this.tbxSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSendData.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.ShowText = false;
            this.tbxSendData.Size = new System.Drawing.Size(566, 73);
            this.tbxSendData.TabIndex = 29;
            this.tbxSendData.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbxSendData.Watermark = "";
            this.tbxSendData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试助手V2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboBox cbxCOMPort;
        private Sunny.UI.UIComboBox cbxStopBits;
        private Sunny.UI.UIComboBox cbxBaudRate;
        private Sunny.UI.UIRadioButton rbnHex;
        private Sunny.UI.UIRadioButton rbnChar;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbxDataBits;
        private Sunny.UI.UIComboBox cbxParity;
        private Sunny.UI.UIButton btnCheckCom;
        private Sunny.UI.UIButton btnOpenCom;
        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIGroupBox groupBox2;
        private Sunny.UI.UITextBox tbxRecvData;
        private Sunny.UI.UIButton btnClearData;
        private Sunny.UI.UIButton btnSendData;
        private Sunny.UI.UIGroupBox groupBox3;
        private Sunny.UI.UITextBox tbxSendData;
    }
}

