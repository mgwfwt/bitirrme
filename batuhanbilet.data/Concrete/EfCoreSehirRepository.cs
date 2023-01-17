using batuhanbilet.data.Abstract;
using batuhanbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace batuhanbilet.data.Concrete
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, BiletContext>, ISehirRepository
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
