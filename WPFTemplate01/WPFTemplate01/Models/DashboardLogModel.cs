using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTemplate01.Base;

/**
 * 设备运行日志信息
 */

namespace WPFTemplate01.Models
{
    public class DashboardLogModel
    {
        //序号
        public string Number { get; set; }

        //数据类型
        public string DataType { get; set; }

        //记录时间
        public string RecordTime { get; set; }

        //设备名称
        public string DeviceName { get; set; }

        //数值
        public string Value { get; set; }

        //状态
        public string Status { get; set; }

        //详情
        private CommandBase _detailCommand;

        public CommandBase DetailCommand
        {
            get
            {
                if (_detailCommand == null)
                {
                    _detailCommand = new CommandBase();
                    _detailCommand.DoExecute = new Action<object>(ShowDetail);
                }

                return _detailCommand;
            }
        }

        // 详情点击委托方法
        private void ShowDetail(object obj)
        {
            MessageBox.Show(this.Number);
        }
    }
}