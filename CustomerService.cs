namespace DependencyInjection
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic();
            ((IDataAccessDependency)_customerBusinessLogic).SetDependency(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetCustomerName(id);
        }
    }
}
