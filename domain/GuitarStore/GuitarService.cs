using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarStore
{
 
    public class GuitarService
    {
        private readonly IGuitarRepository guitarRepository;

        public GuitarService(IGuitarRepository guitarRepository)
        {
            this.guitarRepository = guitarRepository;  
        }

        public Guitar[] GetAllByQuery(string query)
        {
            if (Guitar.IsIsbn(query))
                return guitarRepository.GetAllByIsbn(query);

            return guitarRepository.GetAllByTitle(query);
        }
    }
}
