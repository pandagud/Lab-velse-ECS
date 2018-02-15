namespace ECS.Legacy
{
    public class ECS
    {
        public int _threshold { get; set; }
        private readonly ITemp _tempSensor;
        private readonly IHeater _heater;

        public ECS(int thr,ITemp temp, IHeater heater)
        {
            SetThreshold(thr);
            _heater = heater;
            _tempSensor = temp;

        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
