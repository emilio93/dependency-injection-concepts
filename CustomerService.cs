namespace DependencyInjection
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic();
            _customerBusinessLogic.DataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetCustomerName(id);
        }
    }
}
