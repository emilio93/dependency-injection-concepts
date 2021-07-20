namespace DependencyInjection
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.ProcessCustomerData(id);
        }
    }
}
