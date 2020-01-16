using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample02.Models.ViewModels
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new DomainModels.POCO.PersonCrud();
        }
        #endregion

        #region [- props -]
        public Models.DomainModels.POCO.PersonCrud Ref_PersonCrud { get; set; }

        public Models.DomainModels.DTO.EF.Person5 Person  { get;private set; }
        #endregion

        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_PersonCrud.SelectAll();
        }
        #endregion

        #region [- Save(string fName, string lName) -]
        public void Save(string fName, string lName, string telNumber, string mobileNumber, string address, string email)
        {
            Ref_PersonCrud.Insert(fName, lName,telNumber,mobileNumber,address,email);
        }
        #endregion

        #region [-  Delete(int id, string fName, string lName, string telNumber, string mobileNumber, string address, string email) -]
        public void Delete(int id)
        {
            Ref_PersonCrud.Remove(id);
        }
        #endregion

        #region [- Edit(int id) -]
        public void Edit(int id)
        {
            Ref_PersonCrud.Update(id);
        }
        #endregion

        #region [- Edit(int id, string fName, string lName,string telNumber,string mobileNumber,string address,string email) -]
        public void Edit(int id, string fName, string lName, string telNumber, string mobileNumber, string address, string email)
        {
            Person = new DomainModels.DTO.EF.Person5
            {
                Id = id,
                FName = fName,
                LName = lName,
                TelNumber=telNumber,
                MobileNumber=mobileNumber,
                Addresss=address,
                Email=email
            };
            Ref_PersonCrud.Update(Person);
        }
        #endregion



    }
}
