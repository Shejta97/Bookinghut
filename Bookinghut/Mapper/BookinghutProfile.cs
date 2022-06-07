using AutoMapper;
using Bookinghut.Database;
using Bookinghut.Model;
using Bookinghut.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookinghut.Mapper
{
    public class BookinghutProfile : Profile
    {
        public BookinghutProfile()
        {
            CreateMap<Event, MEvent>();
            CreateMap<Event, EventUpsertRequestdto>().ReverseMap();

            CreateMap<User, MUser>();
            CreateMap<User, UserUpsertRequestdto>().ReverseMap();
        }
    }
}
