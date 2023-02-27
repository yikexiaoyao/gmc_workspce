using gmc_v_2_0.Models;

namespace gmc_v_2_0.Base
{
    public static class GlobalVariable
    {
        public static RecipeModel UnChangedRecipeModel { get; set; }
        public static string SelectedRecipeName { get; set; }
        public static int RecipeDataNum { get; set; }
        public static RecipeModel SelectedRecipeDataItem { get; set; }
    }
}