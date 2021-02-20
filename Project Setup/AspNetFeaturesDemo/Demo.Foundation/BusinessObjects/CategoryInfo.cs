using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.BusinessObjects
{
    public class CategoryInfo
    {
        public string Name { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}
