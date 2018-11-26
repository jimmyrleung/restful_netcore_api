using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulCoreAPI.Services
{
    // Parse Origin to Destiny
    public interface IParser<O, D>
    {
        D Parse(O origin);
        IList<D> ParseList(IList<O> origin);
    }
}
