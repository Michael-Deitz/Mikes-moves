using Microsoft.AspNetCore.Mvc;
using MikesMoves.Models;
using MikesMoves.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MikesMoves.Models.DTOs;

namespace MikesMoves.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TrailerController : ControllerBase
{
    private MikesMovesDbContext _dbContext;

    public TrailerController(MikesMovesDbContext context)
    {
        _dbContext = context;
    }
}