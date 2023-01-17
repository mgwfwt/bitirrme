﻿using batuhanbilet.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace batuhanbilet.data.Abstract
{
    public interface IBiletRepository:IRepository<Bilet>
    {
        int GetCountByKoltuk(int guzergahId);
        List<int> GetKoltuk(int guzergahId);
        Bilet GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
    }
}
