using Aspose.Finance.Xbrl.Validator;
using Aspose.Finance.Xbrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Aspose
{
    internal class Validation
    {
        public Validation() { }
        public static List<ValidationError> Xbrl(String sourceXbrl)
        {
            XbrlDocument document = new XbrlDocument(sourceXbrl);
            XbrlInstanceCollection xbrlInstances = document.XbrlInstances;
            XbrlInstance xbrlInstance = xbrlInstances[0];

            xbrlInstance.Validate();

            List<ValidationError> validationErrors = new List<ValidationError>();
            if (xbrlInstance.ValidationErrors.Count > 0)
            {
                validationErrors = xbrlInstance.ValidationErrors;
                validationErrors.ForEach(valisationError => Console.WriteLine(valisationError.Message));
            }

            Console.WriteLine("ValidateXbrlInstance executed successfully.");
            return validationErrors;
        }
    }
}
