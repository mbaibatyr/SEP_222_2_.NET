using MyDocument.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocument.Abstract
{
    internal interface IDocumentsOut<T> where T : class
    {
        IEnumerable<T> getDocumentsOut(DateTime dtBegin, DateTime dtEnd);
        Status DocumentsOutAdd(T document);
    }
}
