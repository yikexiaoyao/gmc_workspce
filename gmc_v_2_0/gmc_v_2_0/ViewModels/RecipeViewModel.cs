using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using gmc_v_2_0.Base;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;
using gmc_v_2_0.Service;
using gmc_v_2_0.Views;

namespace gmc_v_2_0.ViewModels
{
    public class RecipeViewModel : NotifyBase
    {
        // 编辑配方数据
        private CommandBase _editCommand;

        public CommandBase EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new CommandBase();
                    _editCommand.DoExecute = new Action<object>(obj =>
                    {
                        RecipeEditWindow rew = new RecipeEditWindow();
                        rew.ShowDialog();
                    });
                }

                return _editCommand;
            }
        }

        //关闭窗口
        private CommandBase _closeCommand;

        public CommandBase CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new CommandBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {
                        //设置窗口对象返回值为false关闭窗口
                        (obj as Window).DialogResult = false;
                    });
                }

                return _closeCommand;
            }
        }

        RecipeService service = new RecipeService();

        // 保存配方数据
        private CommandBase _saveCommand;

        public CommandBase SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new CommandBase();
                    _saveCommand.DoExecute = new Action<object>(obj =>
                    {
                        service.UpdateRecipeData(Application.Current.Properties["RecipeName"].ToString());
                        // 如果配方数据更新成功
                        if (true)
                        {
                            // 提示
                            MessageBox.Show("Save Successfully");
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                        }
                        else
                        {
                            MessageBox.Show("Save Failed");
                        }
                    });
                }

                return _saveCommand;
            }
        }

        // 增加配方数据
        private CommandBase _addCommand;

        public CommandBase AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new CommandBase();
                    _addCommand.DoExecute = new Action<object>(obj =>
                    {
                        // 如果配方数据添加成功
                        if (true)
                        {
                            // 提示
                            MessageBox.Show("Add Successfully");
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                        }
                        else
                        {
                            MessageBox.Show("Add Failed");
                        }
                    });
                }

                return _addCommand;
            }
        }

        // 删除配方数据
        private CommandBase _deleteCommand;

        public CommandBase DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new CommandBase();
                    _deleteCommand.DoExecute = new Action<object>(obj =>
                    {
                        if (true)
                        {
                            // 提示
                            MessageBox.Show("Delete Successfully");
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                    });
                }

                return _deleteCommand;
            }
        }
    }
}