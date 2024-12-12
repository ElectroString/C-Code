/*
 * Cam Davies
 * 11/20/2024
 * Program Class File
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    internal class programs
    {
        public String programName {  get; set; }
        public int programFees { get; set; }
        public int programDuration {  get; set; }

        private programs()
        {
            
        }
        public programs(string programName, int programFees, int programDuration)
        {
            this.programName = programName;
            this.programFees = programFees;
            this.programDuration = programDuration;
        }
    }
}
