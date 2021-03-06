﻿namespace Asam.Ppc.Mvc4.Models
{
    using System.Collections.Generic;

    public class FinderResults<TModel>
    {
        public int TotalCount { get; set; }
        public IEnumerable<TModel> Data { get; set; }
    }
}