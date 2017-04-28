using AutoMapper;
using bys.training.database.Entities;
using bys.training.teamWings.Dto;
using bys.training.teamWings.Models;
using bys.training.teamWings.sqlDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bys.training.teamWings.Controllers
{
    public class HomeController : Controller
    {
        private IWingsDal _wingsDal;
        public HomeController()
        {
            
        }


        public HomeController(IWingsDal wingsDal)
        {
            this._wingsDal = wingsDal;
        }

        public ActionResult Index()
        {
            List<MemberInfo> members = new List<MemberInfo>();

            var users = _wingsDal.FindUserInfo();

            foreach (var item in users)
            {
                MemberInfo member = new MemberInfo()
                {
                    MemberId = item.UserId,
                    MemberName = item.UserName,
                    HeadImg = item.HeadImg,
                    DetailLink = item.DetailLink,
                };
                members.Add(member);
            }
            return View(members);
        }

        public ActionResult Member(int MemberId)
        {
          
            var memberDeatils = _wingsDal.FindUserDeatil(MemberId);
            MemberDetail member = new MemberDetail()
            {
                DeatilId = MemberId,
                MemberName = memberDeatils.UserName,
                Age = memberDeatils.Age,
                Sex = memberDeatils.Sex,
                Hobby = memberDeatils.Hobby,
                Specialty = memberDeatils.Specialty,
                FullImg = memberDeatils.FullImg,
                RelatedImg = memberDeatils.RelatedImg
            };
           
            return View(member);
        }


    }
}