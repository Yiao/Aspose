using Aspose.Finance.Xbrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Aspose
{
    internal class Reader
    {
        public Reader() { }
        public static XbrlInstance Load(string xbrlSourceFile)
        {
            XbrlDocument document = new XbrlDocument(xbrlSourceFile);
            XbrlInstanceCollection xbrlInstances = document.XbrlInstances;
            return xbrlInstances[0];
        }
    }
}
