﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_try_project2
{
    internal class Department
    {
        int deptId;
        string deptName;
        public void SetDeptId(int _deptId)
        {
            deptId = _deptId;
        }
        public void SetDeptName(string _deptName)
        {
            deptName = _deptName;
        }
        public int GetDeptId() { return deptId; }
        public string GetDeptName() { return deptName; }
    }
}