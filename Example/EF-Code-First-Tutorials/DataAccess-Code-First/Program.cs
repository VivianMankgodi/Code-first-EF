using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {

            //here we will use Context Class to add Student to a database
            using (var ctx =  new SchoolContext())
            {
                //here we use a class(table) that we want to insert into and for now we will specify the name of the usesr 
                var stud = new Student { StudentName = "New student"};

                //here we are adding the student to the databas by selecting the class(Table) that we want to save the student and because we have given the student's name that is why inside the Add() we have specified the stud varaible that we wnat to save
                ctx.Studentds.Add(stud);

                //this save the the changes in the database
                ctx.SaveChanges();

            }
        }
    }
}
