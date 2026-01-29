using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupProjectServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClassesDataContext db = new DataClassesDataContext();
        public List<Product> getDOTW()
        {
            var Prods = new List<Product>();
            var Prod = (from p in db.Products
                        where p.ProdStatus.Equals("DoTW")
                        select p).DefaultIfEmpty();

            foreach (Product p in Prod)
            {
                var DoTWProd = new Product
                {
                    ProdId = p.ProdId,
                    ProdName = p.ProdName,
                    ProdCategory = p.ProdCategory,
                    ProdPrice = p.ProdPrice,
                    ProdDiscountPrice = p.ProdDiscountPrice,
                    ProdImg = p.ProdImg
                };

                Prods.Add(DoTWProd);
            }

            return Prods;
        }

        public SysUser Login(string username, string password)
        {
            var sysuser = (from s in db.SysUsers
                           where s.Username.Equals(username) &&
                           s.Password.Equals(password)
                           select s).FirstOrDefault();

            if (sysuser != null)
            {
                var tempUser = new SysUser
                {
                    Id = sysuser.Id,
                    Username = sysuser.Username,
                    UserType = sysuser.UserType,
                };
                return tempUser;
            }
            else
            {
                return null;
            }
        }

        public int UserReg(SysUser su)
        {
            var sysUser = (from s in db.SysUsers
                           where s.Username.Equals(su.Username) &&
                           s.Password.Equals(su.Password)
                           select s).FirstOrDefault();

            if (sysUser == null)
            {
                var u = new SysUser();
                if (su.Dateofbirth == null)
                {
                    var newUser = new SysUser
                    {
                        Username = su.Username,
                        Email = su.Email,
                        Phone = su.Phone,
                        Password = su.Password,
                        RegDate = su.RegDate,
                        UserType = su.UserType
                    };
                    u = newUser;
                }
                else
                {
                    var newUser = new SysUser
                    {
                        Username = su.Username,
                        Email = su.Email,
                        Phone = su.Phone,
                        Dateofbirth = su.Dateofbirth,
                        Password = su.Password,
                        RegDate = su.RegDate,
                        UserType = su.UserType
                    };
                    u = newUser;
                }

                db.SysUsers.InsertOnSubmit(u);
                try
                {
                    db.SubmitChanges();
                    //success
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    //error
                    return -1;
                }
            }
            else
            {
                //user exists
                return 0;
            }
        }

        public List<Product> getProducts()
        {
            var Prods = new List<Product>();

            var Prod = (from p in db.Products
                        where p.ProdQuantity > 0
                        select p).DefaultIfEmpty();

            foreach (Product p in Prod)
            {
                var AllProds = new Product
                {
                    ProdId = p.ProdId,
                    ProdName = p.ProdName,
                    ProdCategory = p.ProdCategory,
                    ProdPrice = p.ProdPrice,
                    ProdDiscountPrice = p.ProdDiscountPrice,
                    ProdImg = p.ProdImg
                };

                Prods.Add(AllProds);
            }

            return Prods;
        }
    }
}
