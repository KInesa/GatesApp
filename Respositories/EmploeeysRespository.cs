using GatesApp.Models;

namespace GatesApp.Respositories
{
    public class EmploeeysRespository
    {
        private List<Employee> employees = new List<Employee>();

        public void EmployeeRepository()
        {
            employees.Add(new Employee(1, "Lukas", 1));
            employees.Add(new Employee(2, "Jonas", 1));
            employees.Add(new Employee(3, "Dovile", 2));
            employees.Add(new Employee(4, "Antanas", 2));
            employees.Add(new Employee(5, "Romas", 3));
            employees.Add(new Employee(6, "Tomas", 3));
            employees.Add(new Employee(7, "Asta", 4));
            employees.Add(new Employee(8, "Angele", 4));
            employees.Add(new Employee(9, "Juozas", 2));
            employees.Add(new Employee(10, "Mantas", 1));
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        } 
        public Employee GetEmployee(int employeeId)
        {
            var currentEmployee = employees.FirstOrDefault(x => x.EmployeeId == employeeId);

            return currentEmployee;
        }
    }
}
