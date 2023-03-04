using System;
using System.Collections.ObjectModel;
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
                        if (obj is RecipeUnitView view)
                        {
                            rnw.CompleteAction = () =>
                            {
                                // 显示配方名称
                                view.RecipeName.ItemsSource = service.GetRecipeName();
                                GlobalVariable.ReloadListAction(); //刷新右侧列表
                            };
                        }

                        rnw.ShowDialog();
                    });
                }

                return _newCommand;
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
                        var numList = service.GetRecipeName();
                        var isExistRecipe = numList.Any(n => n == GlobalVariable.NewRecipeName);
                        // 配方是否已存在
                        if (isExistRecipe == false)
                        {
                            service.CreateRecipe();
                            if (obj is RecipeNewWindow window)
                            {
                                window.DialogResult = false;
                                window.CompleteAction?.Invoke();
                            }
                        }
                        else
                        {
                            MessageBoxWindow.Show("Recipe already exist!", null);
                        }
                    });
                }

                return _createRecipeCommand;
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
                            MessageBoxWindow.Show("Please Select", null);
                        }
                    });
                }

                return _editCommand;
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
                            MessageBoxWindow.Show("No data needs to be saved", null);
                        }
                        else if (changedRecipeModel.StepNum == 0)
                        {
                            MessageBoxWindow.Show("Step Num can not be \"0\"", null);
                        }
                        else
                        {
                            service.UpdateRecipeData(changedRecipeModel,
                                GlobalVariable.SelectedRecipeName, changedRecipeModel.StepNum);
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                            GlobalVariable.ReloadListAction(); //刷新右侧列表
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
                        MessageBoxWindow.Show("Are you sure?", (s, e) =>
                        {
                            if (e.Result.IsYes)
                            {
                                service.DeleteRecipeData(GlobalVariable.SelectedRecipeName, deletedRecipeModel.StepNum);
                                // 关闭窗口
                                (obj as Window).DialogResult = false;
                                GlobalVariable.ReloadListAction(); //刷新右侧列表
                            }
                        });
                    });
                }

                return _deleteDataCommand;
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
                            MessageBoxWindow.Show("Step Num can not be \"0\"", null);
                        }
                        else
                        {
                            service.AddRecipeData(addedRecipeModel, GlobalVariable.SelectedRecipeName);
                            // 关闭窗口
                            (obj as Window).DialogResult = false;
                            GlobalVariable.ReloadListAction(); //刷新右侧列表
                        }
                    });
                }

                return _saveAddCommand;
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
                        MessageBoxWindow.Show("Are you sure?", (s, e) =>
                        {
                            if (e.Result.IsYes)
                            {
                                service.DeleteRecipe(GlobalVariable.SelectedRecipeName);
                                if (obj is RecipeUnitView view)
                                {
                                    // 显示配方名称
                                    service = null;
                                    service = new RecipeService();
                                    view.RecipeName.ItemsSource = service.GetRecipeName();
                                    view.RecipeName.SelectedIndex = 0;
                                    string recipeName = service.GetRecipeName()[0];
                                    view.RecipeData.ItemsSource = service.GetRecipeData(recipeName);
                                    GlobalVariable.SelectedRecipeDataItem = null;
                                    GlobalVariable.ReloadListAction(); //刷新右侧列表
                                }
                            }
                        });
                    });
                }

                return _deleteRecipeCommand;
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
                        if (obj is RecipeUnitView view)
                        {
                            string str = view.SearchContent.Text;
                            if (!string.IsNullOrWhiteSpace(str))
                            {
                                view.RecipeName.ItemsSource =
                                    new ObservableCollection<string>(service.SearchRecipeName(str));
                            }
                            else
                            {
                                view.RecipeName.ItemsSource = new ObservableCollection<string>(service.GetRecipeName());
                                GlobalVariable.ReloadListAction(); //刷新右侧列表
                            }
                        }
                    });
                }

                return _searchCommand;
            }
        }
    }
}