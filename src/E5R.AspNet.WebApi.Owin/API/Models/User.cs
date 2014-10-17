namespace E5R.AspNet.WebApi.Owin.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public void UpdateFrom(User user)
        {
            UserName = user.UserName;
            FullName = user.FullName;
            Email = user.Email;
        }
    }
}