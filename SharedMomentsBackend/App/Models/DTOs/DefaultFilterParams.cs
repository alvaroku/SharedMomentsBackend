﻿namespace SharedMomentsBackend.App.Models.DTOs
{
    public class DefaultFilterParams:PaginateParams
    {
        public string Search { get; set; }
        public bool? Status { get; set; }
    }
    public class FilterUserParams: DefaultFilterParams
    {
        public Guid OwnerId { get; set; }
    }
}
