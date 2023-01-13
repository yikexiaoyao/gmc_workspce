using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/**
 * 命令
 */

namespace WPFTemplate01.Base
{
    public class CommandBase : ICommand
    {
        //触发事件
        public event EventHandler CanExecuteChanged;

        //是否可用
        public bool CanExecute(object parameter)
        {
            return true;
        }

        //执行
        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }

        //委托执行
        public Action<object> DoExecute { get; set; }
    }
}