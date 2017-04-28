using AutoMapper;
using bys.training.database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bys.training.teamWings.Dto
{
    public class Configuration
    {
        public static void MapHelper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<UserProfile>();
             
            });
        }

    }
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserInfo, UserInfoDto>();
                cfg.CreateMap<UserDeatil, UserDeatilDto>();
            });
        }
    }
}