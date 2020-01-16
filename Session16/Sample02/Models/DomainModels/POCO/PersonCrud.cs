using Sample02.Models.DomainModels.DTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sample02.Models.DomainModels.POCO
{
   public class PersonCrud
    {
        #region [- ctor -]
        public PersonCrud()
        {

        }
        #endregion

        public string ErrorMessage { get;private set; }
        

        #region [- Tasks -]

        #region [- SelectAll() -]
        public List<DTO.EF.Person5> SelectAll()
        {
            using (var context = new DTO.EF.Test5Entities())
            {
                try
                {
                    var q = context.Person5.ToList();
                    return q;
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }
                
            }
        }
        #endregion

        #region [- Insert(string fName, string lName,string telNumber,string mobileNumber,string address,string email) -]
        public void Insert(string fName, string lName,string telNumber,string mobileNumber,string address,string email)
        {
            using (var context = new DTO.EF.Test5Entities())
            {
                try
                {
                    var person = new DTO.EF.Person5();
                    person.FName = fName;
                    person.LName = lName;
                    person.TelNumber = telNumber;
                    person.MobileNumber = mobileNumber;
                    person.Addresss = address;
                    person.Email = email;
                    context.Person5.Add(person);
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }

            }
        }

        #endregion

        #region [-  Remove(Person5 person) -]
        public void Remove(int id)
        {
            using (var context = new DTO.EF.Test5Entities())
            {
                try
                {
                    var person = (from x in context.Person5
                                  where x.Id == id
                                  select x).First();
                    context.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }

            }
        }
        #endregion

        #region [-  Update(int id) -]
        public void Update(int id)
        {
            using (var context = new DTO.EF.Test5Entities())
            {
                try
                {
                    var person = (from x in context.Person5
                                  where x.Id == id
                                  select x).First();
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                   
                    throw;
                 
                }
                finally
                {
                    context.Dispose();
                }

            }
        }
        #endregion

        #region [-  Update(Person5 person) -]
        public void Update(Person5 person)
        {
            using (var context = new DTO.EF.Test5Entities())
            {
                try
                {
                    context.Entry(person).State = EntityState.Modified;
                    context.SaveChanges();

                }
                catch (Exception ex)
                {

                    throw;

                }
                finally
                {
                    context.Dispose();
                }

            }
        }
        #endregion

        #endregion
    }
}
