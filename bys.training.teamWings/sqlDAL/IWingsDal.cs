using bys.training.teamWings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bys.training.teamWings.sqlDAL
{
    public interface IWingsDal
    {
        IEnumerable<UserInfoDto> FindUserInfo();
        UserDeatilDto FindUserDeatil(int userID);
        UserInfoDto FindUserInfoById(int userID);
    }
}