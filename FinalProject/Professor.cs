using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class Professor
    {
        public string pID;
        public string pName;
        public string pEducation;
        public string pCourseCode;
        public string pDay;
        public string pTime;



        public Professor()
        {

        }
        public Professor(string id, string name, string education, string CourseCode, string day, string time)
        {
            pID = id;
            pName = name;
            pEducation = education;
            pCourseCode = CourseCode;
            pDay = day;
            pTime = time;
        }
        
    }
}