

using System.Reflection.Metadata;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        private int Id;
        private string EmpName;
        private decimal salary;
        #endregion

        // Encapsulation => Seprate data definition [Attributes]
        // from its use [Getter Setter] - [Property] 

        #region Applying Encapsulation [Getter Setter]
        // a. Private attributes
        // b. two functions getters and setters

        // getter

        //public string GetName()
        //{
        //    return EmpName;
        //}

        //public int GetId()
        //{
        //    return Id;
        //}

        //// setter

        //public void SetName(string? name)
        //{
            
        //    EmpName = name?.Length > 5 ? name.Substring(0, 5) : name;
        //}

        //public void SetId(int id)
        //{
        //    Id = id;
        //}
        #endregion

        #region 2. Apply Encapsulation proprety 

        // 2.1 Full property
        // 2.2 Automatic property
        // 2.3 Indexer

        
        public decimal Salary
        {
            get { return salary;}
            private set { salary = value < 5000 ? 5000 : value ;}
        }

        // 2.1 Full property [attribute - property]

        //private int age

        //{ get { return age; } 
        //  set { age = value; }
        //}

        // 2.2 Automatic property [attribute - property]
        public int Age { get; set; } // Property
        // compiler will generate hidden private attribute [backing field]

        private string test;

        public string Test
        {
            get { return test; }
            set { test = value; }
        }
        // full proprety => PropFull + tab + tab

        // 2.2 Automatic propert => Prop + tab + tab
        #endregion

        // private decimal deduction ;

        public decimal Deducation // read only property // derived attribute
        {
            get { return salary * 0.2M; }
            // set {  deduction  = value; }
        }


        #region Constructors
        public Employee(int id, string name, decimal salary, int Age)
        {
            Id = id;
            EmpName = name;
            this.salary = salary;
            this.Age = Age;
        }
        #endregion

        #region Methods
        public override string? ToString()
        {
            return $"Id = {Id}\nName = {EmpName}\n Salary = {salary:c}\n Age = {Age}";
        } 
        #endregion
    }
}
