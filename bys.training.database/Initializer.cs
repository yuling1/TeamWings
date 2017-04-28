using bys.training.database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bys.training.database
{
    public class Initializer : CreateDatabaseIfNotExists<WingsContext>

    {
        public Initializer()
        {
        }
        WingsContext db = new WingsContext();
        protected override void Seed(WingsContext context)
        {
            try
            {
                UserInfo user = new UserInfo()
                {
                    UserId = 1,
                    UserName = "商崇瑞",
                    UserDeatil = new UserDeatil
                    {
                        DeatilId = 1,
                        UserName = "商崇瑞",
                        Age = 25,
                        Sex = "男",
                        Hobby = "产品设计",
                        Specialty = "产品设计",
                        FullImg = "/Content/img/member1_per.png",
                        RelatedImg = "/Content/img/sheji.jpg"
                    },
                    HeadImg = "/Content/img/member1.png",
                    DetailLink = "../Home/Member?memberID=1"
                };
                UserInfo member2 = new UserInfo()
                {
                    UserId = 2,
                    UserName = "程良贵",
                    UserDeatil = new UserDeatil
                    {
                        DeatilId = 2,
                        UserName = "程良贵",
                        Age = 23,
                        Sex = "男",
                        Hobby = "后台",
                        Specialty = "后台",
                        FullImg = "/Content/img/member2_per.png",
                        RelatedImg = "/Content/img/shujuku.jpg"

                    },
                    HeadImg = "/Content/img/member2.png",
                    DetailLink = "../Home/Member?memberID=2"
                };
                UserInfo member3 = new UserInfo()
                {
                    UserId = 3,
                    UserName = "焦玉灵",
                    UserDeatil = new UserDeatil
                    {
                        DeatilId = 3,
                        UserName = "焦玉灵",
                        Age = 23,
                        Sex = "女",
                        Hobby = "前端",
                        Specialty = "前端",
                        FullImg = "/Content/img/member3_per.png",
                        RelatedImg = "/Content/img/qianduan.jpg"
                    },
                    HeadImg = "/Content/img/member3.png",
                    DetailLink = "../Home/Member?memberID=3"
                };

                db.UserInfos.Add(user);
                db.UserInfos.Add(member2);
                db.UserInfos.Add(member3);
                db.SaveChanges();
                base.Seed(context);
            }
            catch (Exception)
            {


            }
        }

    }
}
