using AutoMapper;
using bys.training.database;
using bys.training.database.Entities;
using bys.training.teamWings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bys.training.teamWings.sqlDAL
{
    public class WingsDal:IWingsDal
    {
        public WingsContext Context { get; private set; }

        public WingsDal()
        {
            this.Context = new WingsContext();
        }

        public IEnumerable<UserInfoDto> FindUserInfo()
        {
            return Mapper.DynamicMap<List<UserInfo>, List<UserInfoDto>>(this.Context.UserInfos.ToList());
        }
        public UserDeatilDto FindUserDeatil(int userID)
        {
            return AutoMapper.Mapper.DynamicMap<UserDeatil, UserDeatilDto>(this.Context.UserInfos.First(r => r.UserId == userID).UserDeatil);
        }

        public UserInfoDto FindUserInfoById(int userID)
        {
            return AutoMapper.Mapper.DynamicMap<UserInfo, UserInfoDto>(this.Context.UserInfos.First(r => r.UserId == userID));
        }
    }
}