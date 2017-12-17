namespace MobilReklame
{
    public class CustomerIVM : ItemViewModelBase<Customer, int>
    {
        public CustomerIVM(Customer obj) : base(obj)
        {

        }
        
        public string CustomerName { get => Obj.CustomerName; set => Obj.CustomerName = value; }
        public string PhoneNumber { get => Obj.PhoneNumber; set => Obj.PhoneNumber = value; }
        public string CvrNumber { get => Obj.CvrNumber; set => Obj.CvrNumber = value; }
        public string Email { get => Obj.Email; set => Obj.Email = value; }
        public int CustomerNumber { get => Obj.Key; set => Obj.Key = value; } //no setter!?
        public int Key { get => CustomerNumber; }
    }
}
