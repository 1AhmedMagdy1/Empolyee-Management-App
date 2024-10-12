using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileor
{
    public class employee
    { 
        internal string id, salary, fname, lname, gender, address, tel, position, department, manager;
        public employee(string _id, string _fname, string _lname, string _gender, string _address, string _tel, string _position, string _department, string _manager, string _salary)
        {
                id = _id;
                fname = _fname;
                lname = _lname;
                gender = _gender;
                address = _address;
                tel = _tel;
                position = _position;
                department = _department;
                manager = _manager;
                salary = _salary;
            }
        }
    }

