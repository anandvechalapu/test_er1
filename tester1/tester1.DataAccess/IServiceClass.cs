using tester1.DTO

namespace tester1.Service
{
  public class ServiceClass
  {
     public void PerformOperation(string name,int age,DTO.Customer customerDetails)
     {
       // code goes here
     }
  }
}

using tester1.DTO;

namespace tester1.Service
{
    public interface IServiceClass
    {
        void PerformOperation(string name, int age, Customer customerDetails);
    }
}