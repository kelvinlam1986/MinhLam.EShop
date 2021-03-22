﻿using MinhLam.EShop.Data.Enums;
using System.Collections.Generic;

namespace MinhLam.EShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowHomePage { get; set; }
        public int? ParentId { get; set; }
        public StatusEnum Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
