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

        public double getDoubledValue(double _value)
        {
            throw new NotImplementedException();
        }

        public double geteilt(double _a, double _b)
        {
            if (_b != 0)
            {
                return _a / _b;
            }
            else
            {
                throw new Exception("Teiler darf nicht null sein");
            }
        }

        public double mal(double _a, double _b)
        {
            return _a * _b;
        }

        public double minus(double _a, double _b)
        {
                return _a - _b;
        }

        public double plus(double _a, double _b)
        {
            return _a + _b;
        }
    }
}
