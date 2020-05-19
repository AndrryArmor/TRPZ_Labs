﻿using OrderingGoods.BusinessLayer.DomainModels;
using System.Collections.Generic;

namespace OrderingGoods.BusinessLayer.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        void SaveOrders(IEnumerable<Order> orders);
    }
}