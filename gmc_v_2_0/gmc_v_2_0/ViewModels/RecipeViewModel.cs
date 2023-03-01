using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
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
        private RecipeService service = new RecipeService();
        private CommonBase commonBase = new CommonBase();

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

        // 生成默认配方数据
        private CommandBase _createRecipeCommand;

        public CommandBase CreateRecipeCommand
        {
            get
            {
                if (_createRecipeCommand == null)
                {
                    _createRecipeCommand = new CommandBase();
                    _createRecipeCommand.DoExecute = new Action<object>(obj =>
                    {
                        GlobalVariable.NewRecipeName = (obj as RecipeNewWindow).NewRecipeName.Text;
                        service.CreateRecipeCommand();
                        (obj as Window).DialogResult = false;
                    });
                }

                return _createRecipeCommand;
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
                        RecipeNewWindow rnw = new RecipeNewWindow();
                        rnw.ShowDialog();
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
        private CommandBase _deleteRecipeCommand;

        public CommandBase DeleteRecipeCommand
        {
            get
            {
                if (_deleteRecipeCommand == null)
                {
                    _deleteRecipeCommand = new CommandBase();
                    _deleteRecipeCommand.DoExecute = new Action<object>(obj =>
                    {
                        service.DeleteRecipe(GlobalVariable.SelectedRecipeName);
                    });
                }

                return _deleteRecipeCommand;
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
                        RecipeAddWindow raw = new RecipeAddWindow();
                        raw.ShowDialog();
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
                            service.AddRecipeData(addedRecipeModel, GlobalVariable.SelectedRecipeName);
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
                        bool isEqual = commonBase.IsEqual(changedRecipeModel, unChangedRecipeModel);
                        if (isEqual)
                        {
                            MessageBox.Show("No data needs to be saved");
                        }
                        /*else if (changedRecipeModel.StepNum == 0)
                        {
                            MessageBox.Show("Step Num can not be \"0\"");
                        }*/
                        else
                        {
                            service.UpdateRecipeData(changedRecipeModel,
                                GlobalVariable.SelectedRecipeName, changedRecipeModel.StepNum);
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
                        var deletedRecipeModel = (RecipeModel) (obj as RecipeEditWindow).RecipeData.DataContext;
                        service.DeleteRecipeData(GlobalVariable.SelectedRecipeName, deletedRecipeModel.StepNum);
                        // 关闭窗口
                        (obj as Window).DialogResult = false;
                    });
                }

                return _deleteDataCommand;
            }
        }

        // 配方查询
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
                        string str = (obj as RecipeUnitView).SearchContent.Text;
                        RecipeUnitView ruv = new RecipeUnitView();
                        if (str != "" && str != null && str.Length > 0)
                        {
                            ruv.RecipeName.ItemsSource = service.SearchRecipeName(str);
                        }

                        ruv.RecipeName.ItemsSource = service.GetRecipeName();
                    });
                }

                return _searchCommand;
            }
        }
    }
}