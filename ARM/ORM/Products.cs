using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ARM.ORM
{
    class Products
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }  

        public override string ToString()
        {
            return $"{Name} {Price}";
        }

        public Products()
        {

        }

        public Products(SqlDataReader reader)
        {
            Id = reader.GetGuid("Id");
            Name = reader.GetString("Name");
            Price = reader.GetDouble("Price");
        }

    }
}
