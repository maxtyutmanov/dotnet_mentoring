using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocService.Core
{
    public class NewFileAddedEventArgs : EventArgs
    {
        public DocInfo AddedDoc { get; private set; }

        public NewFileAddedEventArgs(DocInfo addedDoc)
        {
            Contract.Requires(addedDoc != null);

            this.AddedDoc = addedDoc;
        }
    }
}
