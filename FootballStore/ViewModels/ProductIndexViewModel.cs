﻿using FootballStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace FootballStore.ViewModels
{
    public class ProductIndexViewModel
    {
        public IPagedList<Product> Products { get; set; }

        // public IQueryable<Product> Products { get; set; }

        public string Search { get; set; }

        public IEnumerable<CategoryWithCount> CatsWithCount { get; set; }
        public IEnumerable<BrandWithCount> BrandsWithCount { get; set; }

        public string Category { get; set; }
        public string Brand { get; set; }

        public string SortBy { get; set; }

        public Dictionary<string, string> Sorts { get; set; }

        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
        public IEnumerable<SelectListItem> BrandFilterItems
        {
            get
            {
                var allBrands = BrandsWithCount.Select(bc => new SelectListItem
                {
                    Value = bc.BrandName,
                    Text = bc.BrandNameWithCount
                });
                return allBrands;
            }
        }

        public class CategoryWithCount
        {
            public int ProductCount { get; set; }
            public string CategoryName { get; set; }
            public string CatNameWithCount
            {
                get
                {
                    return CategoryName + " (" + ProductCount.ToString() + ")";
                }
            }
        }
        public class BrandWithCount
        {
            public int ProductCount { get; set; }
            public string BrandName { get; set; }
            public string BrandNameWithCount
            {
                get
                {
                    return BrandName + " (" + ProductCount.ToString() + ")";
                }
            }
        }
    }
}