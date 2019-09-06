


using System.Collections.Generic;

namespace Service.Models.Base
{
    public class ModelState
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
