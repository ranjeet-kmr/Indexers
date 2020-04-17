using System;

namespace Indexers
{
    class Employee
    {
        public int EId;
        public double Salary;
        public string EName, Job, DName, Location;
        public Employee(int EId, double Salary, string Job, string DName,string Location, string EName)
        {
            this.DName = DName;
            this.EId = EId;
            this.EName = EName;
            this.Job = Job;
            this.Location = Location;
            this.Salary = Salary;

        }
        
        public object this[int index] 
        {
            get
            {
                if (index == 1)
                    return EName;
                else if (index == 0)
                    return EId;
                else if (index == 2)
                    return Salary;
                else if (index == 3)
                    return Job;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return DName;
                return null;

            }
            set
            {
                if (index == 1)
                    EName =(string) value;
                else if (index == 0)
                    EId =(int) value;
                else if (index == 2)
                    Salary = (double)value;
                else if (index == 3)
                    Job= (string)value;
                else if (index == 4)
                     Location=(string)value;
                else if (index == 5)
                     DName=(string)value;
               
            }
        }
    
    }
}
