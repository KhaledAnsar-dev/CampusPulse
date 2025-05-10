using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskEtu.Additional
{
    public  class clsStructs
    {
        public enum enOpperation
        {
            Add,
            Update
        }


        public struct stGroup
        {
            public int? _GroupID;
            public int _YearNumber;
            public int _GroupNumber;
            public bool _MarkedForDelete;
        }

        public struct stCohort
        {
            public int? _CohortID;
            public int _YearNumber;
            public int _GroupNumber;
            public int _CohortNumber;
            public bool? _MarkedForDelete;
        }

        public struct stCourse
        {
            public int? _CourseID;
            public string _CourseName;
            public int _YearNumber;
            public int _CreditHours;
        }

        public struct stPerson
        {
            public int? _PersonID;
            public string _Name;
            public string _Gender;
            public DateTime _DateOfBirth;
            public string _Email;
            public string _Phone;
        }

        //_Name  _Gender  _DateOfBirth   _Email  _Phone    Salary   UserName  Password

        public struct stMentor
        {
            public stPerson Person;
            public int? MentorID;
            public float Salary;
        }

        public struct stStudent
        {
            public int? _YearNumber;
            public stPerson Person;
            public int? StudentID;
        }

        public struct stTeaching
        {
            public int? _TeachingID;
            public string _YearNumber;
            public string _CourseName;
            public int _MentorID;
            public string _MentorName;
            public bool? _MarkedForDelete;

        }
        public struct stMentorDetails
        {
            public int MentorID;
            public string MentorName;
        }

        public struct stSession
        {
            public int? _SessionID;
            public int _YearNumber;
            public int _GroupNumber;
            public int _CohortNumber;
            public string _CourseName;  
            public int _MentorID;
            public string _MentorName; 
            public bool? _MarkedForDelete;
        }

        public struct stEnrollment
        {
            public int? _EnrollmentID;
            public int _YearNumber;
            public int _GroupNumber;
            public int _CohortNumber;
            public string _CourseName;
            public int _MentorID;
            public string _MentorName;
            public int _StudentID;
            public string _StudentName;
            public string _ExamGrade;
            public bool? _MarkedForDelete;
        }

        public struct stStudentDetails
        {
            public int StudentID;
            public string StudentName;
        }


        public struct stEmployee
        {
            public stPerson Person;
            public int? EmployeeID;
            public float Salary;
            public string UserName;
            public string Password;
        }


        public struct stResult
        {
            public int? _ResultID;
            public int _YearNumber;
            public int _StudentID;
            public string _StudentName;
            public string _TotalGrade;
            public string _Pass;
            public bool? _MarkedForDelete;
        }

    }
}
