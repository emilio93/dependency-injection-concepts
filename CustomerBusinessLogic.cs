namespace DependencyInjection
{
    class CustomerBusinessLogic
    {
        private ICustomerDataAccess _customerDataAccess;
        public CustomerBusinessLogic()
        {
            _customerDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _customerDataAccess.GetCustomerName(id);
        }
    }
}
