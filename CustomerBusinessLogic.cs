namespace DependencyInjection
{
    class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            return DataAccess.GetCustomerName(id);
        }

        public ICustomerDataAccess DataAccess { 
            get;
            set;
        }
    }
}
