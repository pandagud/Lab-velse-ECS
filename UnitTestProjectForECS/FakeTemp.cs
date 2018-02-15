using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectForECS
{
    public class FakeTemp:FakeITemp
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
