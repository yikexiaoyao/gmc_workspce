using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate01.Models;

/**
 * Dashboard数据
 */

namespace WPFTemplate01.ViewModels
{
    public class DashboardViewModel
    {
        public List<LabelModel> RunLabels { get; set; } = new List<LabelModel>();
        public List<LabelModel> BaseLabels { get; set; } = new List<LabelModel>();

        // 如果需要进行集合子项数量的改变，
        public ObservableCollection<DashboardLogModel> Logs { get; set; } = new ObservableCollection<DashboardLogModel>();

        public DashboardViewModel()
        {
            // 添加运行状态 从数据位获取所有需要显示的信息，进行数据获取，最后添加到集合，显示在界面
            RunLabels.Add(new LabelModel { Text = "当前状态", Value = "运行" });
            RunLabels.Add(new LabelModel { Text = "周运行时长", Value = "80h" });
            RunLabels.Add(new LabelModel { Text = "周关机时长", Value = "50h" });
            RunLabels.Add(new LabelModel { Text = "周待机时长", Value = "50h" });
            RunLabels.Add(new LabelModel { Text = "周故障时长", Value = "2h" });
            RunLabels.Add(new LabelModel { Text = "健康状态", Value = "良好" });

            // 添加基本信息
            BaseLabels.Add(new LabelModel { Text = "最大工作范围", Value = "1.44m" });
            BaseLabels.Add(new LabelModel { Text = "有效载荷", Value = "20kg" });
            BaseLabels.Add(new LabelModel { Text = "有效轴数", Value = "6J" });
            BaseLabels.Add(new LabelModel { Text = "重复定位精确度", Value = "0.001cm" });
            BaseLabels.Add(new LabelModel { Text = "额定功率", Value = "2500w" });
            BaseLabels.Add(new LabelModel { Text = "承重能力", Value = "5kg" });
            BaseLabels.Add(new LabelModel { Text = "J6轴最大速度", Value = "2.1m/s" });
            BaseLabels.Add(new LabelModel { Text = "电源电压", Value = "200-600v" });
            BaseLabels.Add(new LabelModel { Text = "净重", Value = "225kg" });

            // 运行日志
            for (int i = 0; i < 10; i++)
            {
                Logs.Add(new DashboardLogModel
                {
                    Number = (i + 1).ToString("00"),
                    DataType = "DataType",
                    RecordTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    DeviceName = "测试设备-01",
                    Value = "90",
                    Status = "紧急"
                });
            }
        }
    }
}