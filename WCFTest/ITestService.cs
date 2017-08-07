using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTest
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ITestService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        double getDoubledValue(double _value);

        [OperationContract]
        double plus(double _a, double _b);

        [OperationContract]
        double minus(double _a, double _b);

        [OperationContract]
        double mal(double _a, double _b);

        [OperationContract]
        double geteilt(double _a, double _b);


    }

}
