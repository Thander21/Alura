using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controller;

[ApiController]
[Route("api/[controller]")]
public class FilmeApiController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    public void AdicionaFilme(Filme filme)
    {
        filmes.Add(filme);
    }
}