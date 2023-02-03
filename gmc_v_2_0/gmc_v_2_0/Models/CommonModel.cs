using gmc_v_2_0.Base;

namespace gmc_v_2_0.Models
{
    public class CommonModel : NotifyBase
    {
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