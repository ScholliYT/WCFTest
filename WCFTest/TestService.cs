﻿using System;

namespace WCFTest
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "TestService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class TestService : ITestService
    {
        public double geteilt(double _a, double _b)
        {
            if (Math.Abs(_b) > 0)
                return _a / _b;
            throw new Exception("Teiler darf nicht null sein");
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