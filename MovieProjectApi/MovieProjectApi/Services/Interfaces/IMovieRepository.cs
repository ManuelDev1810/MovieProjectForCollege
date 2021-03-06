﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieProjectApi.Models;

namespace MovieProjectApi.Services.Interfaces
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        IEnumerable<Movie> GetAllWithComments();
        Task<Movie> GetByIDWithComments(string id);
    }
}
