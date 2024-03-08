﻿using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetailDTO> GetOrderDetailByOrderId(int orderId) => OrderDetailDAO.GetOrderDetailByOrderId(orderId);
    }
}
