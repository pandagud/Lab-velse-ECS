using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectForECS
{
    class FakeECS
    {
        public int _threshold { get; set; }
        private readonly FakeITemp _tempSensor;
        private readonly FakeIHeater _heater;

        public FakeECS(int thr, FakeITemp temp, FakeIHeater heater)
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
