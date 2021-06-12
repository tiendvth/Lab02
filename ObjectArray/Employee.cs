namespace ObjectArray
{
    public class Employee
    {
        private int empID;

        public Employee(int empId)
        {
            this.empID = empId;
        }

        public override string ToString()
        {
            return empID.ToString();
        }
    }
}