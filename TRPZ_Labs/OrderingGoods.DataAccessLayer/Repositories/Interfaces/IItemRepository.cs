﻿using OrderingGoods.DataAccessLayer.Entities;
using System.Collections.Generic;

namespace OrderingGoods.DataAccessLayer.Repository
{
    public interface IItemRepository : IRepository<ItemEntity, int>
    {

    }
}