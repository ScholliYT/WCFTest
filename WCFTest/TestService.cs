using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTest
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "TestService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class TestService : ITestService
    {
        public int getDoubledValue(int _value)
        {
            return _value*2;
        }

        public void test()
            {
}           }
    }
}
