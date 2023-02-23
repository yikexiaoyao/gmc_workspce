using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using gmc_v_2_0.Base;
using gmc_v_2_0.Models;
using gmc_v_2_0.Service;
using gmc_v_2_0.Views;

namespace gmc_v_2_0.ViewModels
{
    public class RecipeViewModel : NotifyBase
    {
        private RecipeService service = new RecipeService();
        private SqlDataAdapter adapter { get; set; }

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

        // 新建配方
        private CommandBase _newCommand;

        public CommandBase NewCommand
        {
            get
            {
                if (_newCommand == null)
                {
                    _newCommand = new CommandBase();
                    _newCommand.DoExecute = new Action<object>(obj =>
                    {
                        // RecipeEditWindow rew = new RecipeEditWindow();
                        // rew.ShowDialog();
                    });
                }

                return _newCommand;
            }
        }

        // 编辑配方
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
                        // 是否选择
                        if (Application.Current.Properties["selectedRecipeDataItem"] != null)
                        {
                            RecipeEditWindow rew =
                                new RecipeEditWindow(
                                    Application.Current.Properties["selectedRecipeDataItem"] as RecipeModel);
                            rew.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please Select");
                        }
                    });
                }

                return _editCommand;
            }
        }

        // 删除配方
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
                        var changedRecipeModel = (RecipeModel) (obj as RecipeEditWindow).RecipeData.DataContext;
                        var unChangedRecipeModel = (RecipeModel) Application.Current.Properties["UnChangedRecipeModel"];
                        bool isEqual =
                            changedRecipeModel.StepNum == unChangedRecipeModel.StepNum ||
                            changedRecipeModel.StepTime == unChangedRecipeModel.StepTime ||
                            changedRecipeModel.WaferRotatiorVal == unChangedRecipeModel.WaferRotatiorVal ||
                            changedRecipeModel.WaferRotatiorAcc == unChangedRecipeModel.WaferRotatiorAcc ||
                            changedRecipeModel.RinseArmDisp == unChangedRecipeModel.RinseArmDisp ||
                            changedRecipeModel.RinseArmSpeed == unChangedRecipeModel.RinseArmSpeed ||
                            changedRecipeModel.RinseArmStartPos == unChangedRecipeModel.RinseArmStartPos ||
                            changedRecipeModel.RinseArmEndPos == unChangedRecipeModel.RinseArmEndPos ||
                            changedRecipeModel.RinseArmScan == unChangedRecipeModel.RinseArmScan ||
                            changedRecipeModel.DevArmDisp == unChangedRecipeModel.DevArmDisp ||
                            changedRecipeModel.DevArmTime == unChangedRecipeModel.DevArmTime ||
                            changedRecipeModel.DevArmSpeed == unChangedRecipeModel.DevArmSpeed ||
                            changedRecipeModel.DevArmStartPos == unChangedRecipeModel.DevArmStartPos ||
                            changedRecipeModel.DevArmEndPos == unChangedRecipeModel.DevArmEndPos ||
                            changedRecipeModel.DevArmScan == unChangedRecipeModel.DevArmScan ||
                            changedRecipeModel.AutoDamp == unChangedRecipeModel.AutoDamp ||
                            changedRecipeModel.N2Dry == unChangedRecipeModel.N2Dry ||
                            changedRecipeModel.WaitType == unChangedRecipeModel.WaitType;
                        service.UpdateRecipeData(changedRecipeModel,
                            Application.Current.Properties["RecipeName"].ToString());
                        // 关闭窗口
                        (obj as Window).DialogResult = false;
                    });
                }

                return _saveCommand;
            }
        }

        // 删除配方数据
        private CommandBase _deleteDataCommand;

        public CommandBase DeleteDataCommand
        {
            get
            {
                if (_deleteDataCommand == null)
                {
                    _deleteDataCommand = new CommandBase();
                    _deleteDataCommand.DoExecute = new Action<object>(obj =>
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

        private CommandBase _searchCommand;

        public CommandBase SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new CommandBase();
                    _searchCommand.DoExecute = new Action<object>(obj =>
                    {
                        if (true)
                        {
                            // 提示
                            MessageBox.Show("Search Completed");
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                    });
                }

                return _searchCommand;
            }
        }
    }
}