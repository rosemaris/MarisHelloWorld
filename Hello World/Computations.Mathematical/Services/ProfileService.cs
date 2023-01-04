using Computations.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical
{
    public class ProfileService : IProfileService
    {
        public string GetBirthdate(int day, int month, int year)
        {
            string monthname;
            switch (month)
            {
                case 1: monthname = "January";
                    break;  
                case 2: monthname = "Febrary";
                    break ;
                case 3: monthname = "March";
                    break;
                case 4: monthname = "April";
                    break;
                case 5: monthname = "May";
                    break;
                case 6: monthname = "June";
                    break;
                case 7: monthname = "July";
                    break;
                case 8: monthname = "August";
                    break;
                case 9: monthname = "September";
                    break;
                case 10: monthname = "October";
                    break;
                case 11: monthname = "November";
                    break;
                case 12: monthname = "December";
                    break;
                default: monthname = "";
                    break;
            }
            return monthname + " "+ day + ", " + year;
        }

        public string GetBirthplace(string barangay, string town, string province)
        {
            var birthplace = (barangay + ", " + town + ", " + province);
            return birthplace;
        }
            }
    }
