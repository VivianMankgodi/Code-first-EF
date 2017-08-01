using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVT.SchoolLibrary.BusinessLayer.Models;
using DVT.SchoolLibrary.DataAccessLayer.Repositories;
using System.Security.Cryptography;

namespace DVT.School.PresentationLayer
{
    class Accessing
    {
        //public void InsertLearner(string Firsnname, string Lastname, string Passwordhash, string Email, string Phonenumber, int Genderid, int UserTypeid, bool Isapproved)
        //{
        //    LearnerRepo repo = new LearnerRepo();
        //    Learner l = new Learner(Firsnname,  Lastname,  Passwordhash,  Email,  Phonenumber,  Genderid,  UserTypeid,  Isapproved);
        //    repo.Inserting(l);
        //   // repo.add(l);
        //   repo.savechange();
        //}



        //here we insert into learner table
        public void NewLearner()
        {
            LearnerRepo repoL = new LearnerRepo();
          //  Learner learner = new Learner();
            //Console.Write("Enter First Name: ");
            //string firstname = Console.ReadLine();

            var learner = new Learner
            {
                LearnerId = 1,
                FirstName = "Vivian",
                LastName = "Tebeila",
                PasswordHash = "123456",
                ConfirmPasswordHash = "123456",
                Email = "123h@gmail.com",
                ConfirmEmail ="123h@gmail.com",
                PhoneNumber = "074563",
                GenderId = 1,
                UserTypeId = 2,
                IsApproved = false
              

            };
            SHA256 hash = new SHA256Cng();
            byte[] hashvalue = hash.ComputeHash(Encoding.UTF8.GetBytes(learner.PasswordHash));
          learner.PasswordHash = System.Text.Encoding.Default.GetString(hashvalue);
            repoL.Inserting(learner  );
            repoL.SaveChange();

        }
    }
}
