namespace TechnicalTask.Dtos.EmployeeDtos
{
    public class GetEmployeeDto
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DOB { set; get; }
        public string Gender { set; get; }
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string City { set; get; }
        public string Postal { set; get; }
        public string Country { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }
        public bool Active { set; get; }
    }
}
