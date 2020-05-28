﻿using AutoMapper;
using OrderingGoods.Models;
using OrderingGoods.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingGoods.BusinessLayer
{
    public class AutoMapperConfig : Profile
    {        
        public AutoMapperConfig()
        {
            CreateMap<GoodEntity, Good>().ReverseMap();
            CreateMap<ShopEntity, Shop>().ReverseMap();
            CreateMap<ItemEntity, Item>().ReverseMap();
            CreateMap<OrderEntity, Order>().ReverseMap();
        }
    }
}