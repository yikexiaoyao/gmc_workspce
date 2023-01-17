using gmc_v_2_0.Base;

namespace gmc_v_2_0.Models
{
    public class RecipeModel : NotifyBase
    {
        private int _stepNum;

        private string _stepTime;

        private int _waferRotatiorVal;

        private int _waferRotatiorAcc;

        private string _rinseArmDisp;

        private string _rinseArmSpeed;

        private string _rinseArmStartPos;

        private string _rinseArmEndPos;

        private int _rinseArmScan;

        private string _devArmDisp;

        private string _devArmTime;

        private string _devArmSpeed;

        private string _devArmStartPos;

        private string _devArmEndPos;

        private int _devArmScan;

        private string _autoDamp;

        private string _n2Dry;

        private string _waitType;

        public RecipeModel(int stepNum, string stepTime, int waferRotatiorVal, int waferRotatiorAcc,
            string rinseArmDisp, string rinseArmSpeed, string rinseArmStartPos, string rinseArmEndPos, int rinseArmScan,
            string devArmDisp, string devArmTime, string devArmSpeed, string devArmStartPos, string devArmEndPos,
            int devArmScan, string autoDamp, string n2Dry, string waitType)
        {
            _stepNum = stepNum;
            _stepTime = stepTime;
            _waferRotatiorVal = waferRotatiorVal;
            _waferRotatiorAcc = waferRotatiorAcc;
            _rinseArmDisp = rinseArmDisp;
            _rinseArmSpeed = rinseArmSpeed;
            _rinseArmStartPos = rinseArmStartPos;
            _rinseArmEndPos = rinseArmEndPos;
            _rinseArmScan = rinseArmScan;
            _devArmDisp = devArmDisp;
            _devArmTime = devArmTime;
            _devArmSpeed = devArmSpeed;
            _devArmStartPos = devArmStartPos;
            _devArmEndPos = devArmEndPos;
            _devArmScan = devArmScan;
            _autoDamp = autoDamp;
            _n2Dry = n2Dry;
            _waitType = waitType;
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