using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    /// <summary>
    /// storage all student, teacher and group data in the static collections
    /// </summary>
    public static class UniversityPeopleStorage
    {
        private static List<Teacher> myStaticTeacherList=new List<Teacher>();
        private static List<Student> myStaticStudentList = new List<Student>();
        private static List<Group> myStaticGroupList = new List<Group>();
        /// <summary>
        /// add teacher to the static collection
        /// </summary>
        /// <param name="_newTeacher"></param>
        public static void AddTeacher(Teacher _newTeacher)
        {
            myStaticTeacherList.Add(_newTeacher);
        }
        /// <summary>
        /// return all teachers
        /// </summary>
        /// <returns>array Teacher []</returns>
        public static Teacher [] GetTeacherList()
        {
            return myStaticTeacherList.ToArray();
        }
        /// <summary>
        /// add student to the static collection
        /// </summary>
        /// <param name="_newStudent"></param>
        public static void AddStudent(Student _newStudent)
        {
            myStaticStudentList.Add(_newStudent);
        }
        /// <summary>
        /// return all students
        /// </summary>
        /// <returns>array Student []</returns>
        public static Student[] GetStudentList()
        {
            return myStaticStudentList.ToArray();
        }
        public static void AddGroup(Group _newGroup)
        {
            myStaticGroupList.Add(_newGroup);
        }
        public static Group[] GetGroupList()
        {// а зачем перегонять тут в массив? что мешает дальше юзать колекцию? 
            return myStaticGroupList.ToArray();
        }

    }
}
