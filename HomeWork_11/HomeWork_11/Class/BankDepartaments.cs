using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11.Class
{
    class BankDepartaments
    {
    public List<NameDeparts> nameDeparts = new List<NameDeparts>(); 

    }
}

class NameDeparts
{
    public string Name { get; set; }

    public NameDeparts(string name)
    {
        Name = name;
    }


}
