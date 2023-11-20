using Aspose.Finance.Xbrl;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Aspose
{
    internal class Convertor
    {
        public static void To(string sourceXbrl, string target, SaveFormat format)
        {
            XbrlDocument xbrlDocument = new XbrlDocument(sourceXbrl);
            SaveOptions saveOptions = new SaveOptions();
            saveOptions.SaveFormat = format;
            xbrlDocument.Save(target, saveOptions);
        }
    }
    
}
