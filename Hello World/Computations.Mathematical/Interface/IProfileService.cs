using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical.Interface
{
    public interface IProfileService
    {
        string GetBirthdate(int day, int month, int year);
        string GetBirthplace(string barangay, string town, string province);
    }
}
