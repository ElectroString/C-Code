/*
 * Cam Davies
 * 11/20/2024
 * Student Class File
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    internal class student
    {
        public String firstName {  get; set; }
        public String lastName {  get; set; }
        public int SIN {  get; set; }
        public String Email {  get; set; }
        public int highSchoolGrade {  get; set; }
        public int admissionTestScore {  get; set; }
        public String campusLocation {  get; set; }
        public String ProgramName {  get; set; }

        private student()
        {

        }

        public student(string firstName, string lastName, int sIN, string email, int highSchoolGrade, int admissionTestScore, string campusLocation, string programName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SIN = sIN;
            this.Email = email;
            this.highSchoolGrade = highSchoolGrade;
            this.admissionTestScore = admissionTestScore;
            this.campusLocation = campusLocation;
            this.ProgramName = programName;
        }
    }

}
