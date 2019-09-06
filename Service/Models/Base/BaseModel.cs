using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models.Base
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            if(Id>0)
            {
                updated_at = DateTime.Now;
            }
            else
            {
                created_at = DateTime.Now;
                updated_at = DateTime.Now;
            }
        }
        public long Id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public abstract ModelState Validate();
    }
}
