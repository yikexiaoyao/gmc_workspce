using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using gmc_v_2_0.Base;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;
using gmc_v_2_0.Service;
using gmc_v_2_0.Views;

namespace gmc_v_2_0.ViewModels
{
    public class RecipeViewModel : NotifyBase
    {
        private RecipeService service = new RecipeService();
        private SqlServerAccess sqlServerAccess = new SqlServerAccess();

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
                        if (GlobalVariable.SelectedRecipeDataItem != null)
                        {
                            RecipeEditWindow rew = new RecipeEditWindow(GlobalVariable.SelectedRecipeDataItem);
                            // 获取修改之前的配方参数
                            GlobalVariable.UnChangedRecipeModel = GlobalVariable.SelectedRecipeDataItem.Clone();
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
                            RecipeAddWindow raw = new RecipeAddWindow();
                            raw.ShowDialog();
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

        // 保存增加的配方数据
        private CommandBase _saveAddCommand;

        public CommandBase SaveAddCommand
        {
            get
            {
                if (_saveAddCommand == null)
                {
                    _saveAddCommand = new CommandBase();
                    _saveAddCommand.DoExecute = new Action<object>(obj =>
                    {
                        var addedRecipeModel = (RecipeModel) (obj as RecipeAddWindow).RecipeData.DataContext;
                        if (addedRecipeModel.StepNum == 0)
                        {
                            MessageBox.Show("Step Num can not be \"0\"");
                        }
                        else
                        {
                            service.AddRecipeData(addedRecipeModel,GlobalVariable.SelectedRecipeName);
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                        }
                    });
                }

                return _saveAddCommand;
            }
        }

        // 保存修改后的配方数据
        private CommandBase _saveEditCommand;

        public CommandBase SaveEditCommand
        {
            get
            {
                if (_saveEditCommand == null)
                {
                    _saveEditCommand = new CommandBase();
                    _saveEditCommand.DoExecute = new Action<object>(obj =>
                    {
                        var changedRecipeModel = (RecipeModel) (obj as RecipeEditWindow).RecipeData.DataContext;
                        var unChangedRecipeModel = GlobalVariable.UnChangedRecipeModel;
                        bool isEqual =
                            changedRecipeModel.StepNum.ToString() == unChangedRecipeModel.StepNum.ToString() &&
                            changedRecipeModel.StepTime.ToString() == unChangedRecipeModel.StepTime.ToString() &&
                            changedRecipeModel.WaferRotatiorVal.ToString() ==
                            unChangedRecipeModel.WaferRotatiorVal.ToString() &&
                            changedRecipeModel.WaferRotatiorAcc.ToString() ==
                            unChangedRecipeModel.WaferRotatiorAcc.ToString() &&
                            changedRecipeModel.RinseArmDisp.ToString() ==
                            unChangedRecipeModel.RinseArmDisp.ToString() &&
                            changedRecipeModel.RinseArmSpeed.ToString() ==
                            unChangedRecipeModel.RinseArmSpeed.ToString() &&
                            changedRecipeModel.RinseArmStartPos.ToString() ==
                            unChangedRecipeModel.RinseArmStartPos.ToString() &&
                            changedRecipeModel.RinseArmEndPos.ToString() ==
                            unChangedRecipeModel.RinseArmEndPos.ToString() &&
                            changedRecipeModel.RinseArmScan.ToString() ==
                            unChangedRecipeModel.RinseArmScan.ToString() &&
                            changedRecipeModel.DevArmDisp.ToString() == unChangedRecipeModel.DevArmDisp.ToString() &&
                            changedRecipeModel.DevArmTime.ToString() == unChangedRecipeModel.DevArmTime.ToString() &&
                            changedRecipeModel.DevArmSpeed.ToString() == unChangedRecipeModel.DevArmSpeed.ToString() &&
                            changedRecipeModel.DevArmStartPos.ToString() ==
                            unChangedRecipeModel.DevArmStartPos.ToString() &&
                            changedRecipeModel.DevArmEndPos.ToString() ==
                            unChangedRecipeModel.DevArmEndPos.ToString() &&
                            changedRecipeModel.DevArmScan.ToString() == unChangedRecipeModel.DevArmScan.ToString() &&
                            changedRecipeModel.AutoDamp.ToString() == unChangedRecipeModel.AutoDamp.ToString() &&
                            changedRecipeModel.N2Dry.ToString() == unChangedRecipeModel.N2Dry.ToString() &&
                            changedRecipeModel.WaitType.ToString() == unChangedRecipeModel.WaitType.ToString();
                        if (isEqual)
                        {
                            MessageBox.Show("No data needs to be saved");
                        }
                        else if (changedRecipeModel.StepNum == 0)
                        {
                            MessageBox.Show("Step Num can not be \"0\"");
                        }
                        else
                        {
                            service.UpdateRecipeData(changedRecipeModel,
                                GlobalVariable.SelectedRecipeName);
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                        }
                    });
                }

                return _saveEditCommand;
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