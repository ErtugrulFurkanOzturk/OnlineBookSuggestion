using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booksuggestion.API.Data;
using Booksuggestion.API.Dtos;
using Booksuggestion.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booksuggestion.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Books")]
    
    public class BooksController : Controller
    {
        private  IAppRepository _appRepository;
        
        private  IMapper _mapper;
        public BooksController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetBooks()
        {
            var books = _appRepository.GetBooks();
            var booksToReturn = _mapper.Map<List<BookForListDto>>(books);
            return Ok(booksToReturn);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Book book)
        {
            _appRepository.Add(book);
            _appRepository.SaveAll();
            return Ok(book);
        }
        [HttpGet]
        [Route("detail")]
        public ActionResult GetBooksById(int id)
        {
            var book = _appRepository.GetBookByID(id);
            var bookToReturn = _mapper.Map<List<BookForDetailDto>>(book);
            return Ok(bookToReturn);
        }
    }
}
