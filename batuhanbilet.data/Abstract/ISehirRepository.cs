using batuhanbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace batuhanbilet.data.Abstract
{
    public interface ISehirRepository:IRepository<Sehir>
    {
        string sehirad();
    }
}
