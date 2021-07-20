namespace DependencyInjection
{
    class CustomerBusinessLogic
    {
        private ICustomerDataAccess _dataAccess;
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
