﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace DAL_LanChat
{
    public class dbConnection
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source = PC; Initial Catalog = QLSV; Integrated Security = True");
    }
}