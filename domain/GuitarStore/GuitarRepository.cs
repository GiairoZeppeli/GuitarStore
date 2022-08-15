using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarStore
{
    public interface IGuitarRepository
    {
        Guitar[] GetAllByIsbn(string isbn);

        Guitar[] GetAllByTitle(string titlePart);
    }
}
