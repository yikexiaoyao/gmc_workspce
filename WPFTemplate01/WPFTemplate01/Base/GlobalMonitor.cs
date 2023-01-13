using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate01.Models;
using WPFTemplate01.Service;
using Amazon.AWSSupport.Model;

namespace WPFTemplate01.Base
{
    public class GlobalMonitor
    {
        public static ObservableCollection<DeviceModel> DeviceList { get; set; } = new ObservableCollection<DeviceModel>();

        private static bool isRunning = true;
        private static Task mainTask = null;

        //任务开始
        public static void Start()
        {
            mainTask = Task.Run(async () =>
            {
                // 获取设备信息
                //DeviceList.Add(new DeviceModel { Name = "#1 Master device info" });
                //DeviceList.Add(new DeviceModel { Name = "#2 Master device info" });
                //DeviceList.Add(new DeviceModel { Name = "#3 Master device info" });
                //DeviceList.Add(new DeviceModel { Name = "#4 Master device info" });

                DeviceService deviceService = new DeviceService();
                var list = deviceService.GetDevices();
                if (list != null)
                    foreach (var item in list)
                    {
                        DeviceList.Add(item);
                    }
                //DeviceList = new ObservableCollection<DeviceModel>(list);

                while (isRunning)
                {
                    await Task.Delay(100);

                    foreach (var item in DeviceList)
                    {
                        if (item.CommType == 2 && item.S7 != null)// S7通信
                        {
                            //创建S7对象
                            Zhaoxi.Communication.Siemens.S7Net s7Net = new Zhaoxi.Communication.Siemens.S7Net(item.S7.IP, item.S7.Port, (byte)item.S7.Rock, (byte)item.S7.Slot);

                            List<string> addrList = item.MonitorValueList.Select(v => v.Address).ToList();
                            var result = s7Net.Read<ushort>(addrList);
                            if (result.IsSuccessed)
                            {
                                for (int i = 0; i < item.MonitorValueList.Count; i++)
                                {
                                    item.MonitorValueList[i].Value = result.Datas[i];
                                }
                            }

                            //连接关闭
                            s7Net.Close();
                        }
                    }
                }
            });
        }

        //任务结束
        public static void Stop()
        {
            isRunning = false;
            mainTask.ConfigureAwait(true);
        }
    }
}