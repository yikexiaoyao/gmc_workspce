using gmc_v_2_0.Base;

namespace gmc_v_2_0.Models
{
    public class RecipeModel : NotifyBase
    {
        public int _recipeId;

        public string _recipeName;

        public int _stepNum;

        public string _stepTime;

        public int _waferRotatiorVal;

        public int _waferRotatiorAcc;

        public string _rinseArmDisp;

        public string _rinseArmSpeed;

        public string _rinseArmStartPos;

        public string _rinseArmEndPos;

        public int _rinseArmScan;

        public string _devArmDisp;

        public string _devArmTime;

        public string _devArmSpeed;

        public string _devArmStartPos;

        public string _devArmEndPos;

        public int _devArmScan;

        public string _autoDamp;

        public string _n2Dry;

        public string _waitType;

        public int RecipeId
        {
            get { return _recipeId; }
            set
            {
                _recipeId = value;
                this.NotifyChanged();
            }
        }

        public string RecipeName
        {
            get { return _recipeName; }
            set
            {
                _recipeName = value;
                this.NotifyChanged();
            }
        }

        public int StepNum
        {
            get { return _stepNum; }
            set
            {
                _stepNum = value;
                this.NotifyChanged();
            }
        }

        public string StepTime
        {
            get { return _stepTime; }
            set
            {
                _stepTime = value;
                this.NotifyChanged();
            }
        }

        public int WaferRotatiorVal
        {
            get { return _waferRotatiorVal; }
            set
            {
                _waferRotatiorVal = value;
                this.NotifyChanged();
            }
        }

        public int WaferRotatiorAcc
        {
            get { return _waferRotatiorAcc; }
            set
            {
                _waferRotatiorAcc = value;
                this.NotifyChanged();
            }
        }

        public string RinseArmDisp
        {
            get { return _rinseArmDisp; }
            set
            {
                _rinseArmDisp = value;
                this.NotifyChanged();
            }
        }

        public string RinseArmSpeed
        {
            get { return _rinseArmSpeed; }
            set
            {
                _rinseArmSpeed = value;
                this.NotifyChanged();
            }
        }

        public string RinseArmStartPos
        {
            get { return _rinseArmStartPos; }
            set
            {
                _rinseArmStartPos = value;
                this.NotifyChanged();
            }
        }

        public string RinseArmEndPos
        {
            get { return _rinseArmEndPos; }
            set
            {
                _rinseArmEndPos = value;
                this.NotifyChanged();
            }
        }

        public int RinseArmScan
        {
            get { return _rinseArmScan; }
            set
            {
                _rinseArmScan = value;
                this.NotifyChanged();
            }
        }

        public string DevArmDisp
        {
            get { return _devArmDisp; }
            set
            {
                _devArmDisp = value;
                this.NotifyChanged();
            }
        }

        public string DevArmTime
        {
            get { return _devArmTime; }
            set
            {
                _devArmTime = value;
                this.NotifyChanged();
            }
        }

        public string DevArmSpeed
        {
            get { return _devArmSpeed; }
            set
            {
                _devArmSpeed = value;
                this.NotifyChanged();
            }
        }

        public string DevArmStartPos
        {
            get { return _devArmStartPos; }
            set
            {
                _devArmStartPos = value;
                this.NotifyChanged();
            }
        }

        public string DevArmEndPos
        {
            get { return _devArmEndPos; }
            set
            {
                _devArmEndPos = value;
                this.NotifyChanged();
            }
        }

        public int DevArmScan
        {
            get { return _devArmScan; }
            set
            {
                _devArmScan = value;
                this.NotifyChanged();
            }
        }

        public string AutoDamp
        {
            get { return _autoDamp; }
            set
            {
                _autoDamp = value;
                this.NotifyChanged();
            }
        }

        public string N2Dry
        {
            get { return _n2Dry; }
            set
            {
                _n2Dry = value;
                this.NotifyChanged();
            }
        }

        public string WaitType
        {
            get { return _waitType; }
            set
            {
                _waitType = value;
                this.NotifyChanged();
            }
        }
    }
}