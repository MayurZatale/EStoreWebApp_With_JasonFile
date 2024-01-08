using EStoreWebApp.Entities;
using EStoreWebApp.Repositories;
namespace EStoreWebApp.Services;

public class EmployeeService:IEmployeeService{
   string fileName=@"C:\Users\Admin\Desktop\Class Work\C#\Day7\Day7Lab\EStoreWebApp\employees.json";
    public List<Employee> GetAll(){
       List<Employee> employees=new List<Employee>();
       /*employees.Add(new Employee{Id=1, Name="Shivam"});
       employees.Add(new Employee{Id=2, Name="Chirag"});
       employees.Add(new Employee{Id=1, Name="Manisha"});
       employees.Add(new Employee{Id=1, Name="shailesh"});*/
       RepositoryManager mgr=new RepositoryManager();
      //  string fileName=@"C:\Users\dac\Desktop\Mayur & Sunny\Class Work\C#\Day7\CollectionSolution\EStoreWebApp\employees.json";
       employees=mgr.DeSerialize(fileName);
       return employees;
    }
    public Employee GetById(int id){
      List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      //  string fileName=@"C:\Users\dac\Desktop\Mayur & Sunny\Class Work\C#\Day7\CollectionSolution\EStoreWebApp\employees.json";
      employees=mgr.DeSerialize(fileName);
      Employee emp=employees.Find(emp=>emp.Id==id);
      return emp;
    }
    public void Insert(Employee emp){
      List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      employees=mgr.DeSerialize(fileName);
      employees.Add(emp);
      mgr.Serialize(employees,fileName);

    }
     public void Update(Employee emp){}
     public void Delete(int id){

     }

}