/*
 * Cam Davies
 * 11/20/2024
 * Campus Class File
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    internal class campus
    {
        public string location;
        public int HSGradeReq{get; set;}
        public int admissionTSReq { get; set;}
        public int regFees { get; set;}
        
        public List<programs> programs { get; set;}

        private campus()
        {
        }

        public campus(String location,int hSGradeReq, int admissionTSReq, int regFees, List<programs> programs)
        {
            this.location = location;
            this.HSGradeReq = hSGradeReq;
            this.admissionTSReq = admissionTSReq;
            this.regFees = regFees;
            this.programs = programs;
        }
    }
}
