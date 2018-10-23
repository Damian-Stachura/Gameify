using AutoMapper;
using Gameify.Data;
using Gameify.Dtos;
using Gameify.ViewModels;
using Gamey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Gameify.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GamesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ViewResult Index()
        {
            var games = _context.Game
                .Include(g => g.Genre)
                .Include(g => g.PegiAge)
                .Include(g => g.PegiContent)
                .ToList();

            return View(games);
        }

        public ViewResult New()
        {
            var genres = _context.Genre.ToList();
            var pegiAges = _context.PegiAge.ToList();
            var pegiContents = _context.PegiContent.ToList();

            var viewModel = new GameFormViewModel()
            {
                Genres = genres,
                PegiAges = pegiAges,
                PegiContents = pegiContents
            };

            return View("GameForm", viewModel);
        }

        public IActionResult Save(GameDto gameDto)
        {
           
            var game = _mapper.Map<GameDto, Game>(gameDto);

            _context.Add(game);
            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

    }
}