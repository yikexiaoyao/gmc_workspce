using gmc_v_2_0.Base;

namespace gmc_v_2_0.Models
{
    public class CommonModel : NotifyBase
    {
        private string _recipeDataName;

        public string RecipeDataName
        {
            get { return _recipeDataName; }
            set
            {
                _recipeDataName = value;
                this.NotifyChanged();
            }
        }

        private int _recipeDataNum;

        public int RecipeDataNum
        {
            get { return _recipeDataNum; }
            set
            {
                _recipeDataNum = value;
                this.NotifyChanged();
            }
        }
    }
}