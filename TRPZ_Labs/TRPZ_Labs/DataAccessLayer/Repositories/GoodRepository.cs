﻿using Microsoft.EntityFrameworkCore;
using OrderingGoods.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;

namespace OrderingGoods.DataAccessLayer.Repository
{
    public class GoodRepository : Repository<GoodEntity>, IGoodRepository
    {
        public GoodRepository(OrderingGoodsContext appContext) : base(appContext) { }
    }
}