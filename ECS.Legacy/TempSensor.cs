namespace ECS.Legacy
{
    internal class TempSensor:ITemp
    {
        public int GetTemp()
        {
            return 25;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}