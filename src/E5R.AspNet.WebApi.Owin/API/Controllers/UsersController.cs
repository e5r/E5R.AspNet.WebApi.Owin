using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using E5R.AspNet.WebApi.Owin.API.Models;

namespace E5R.AspNet.WebApi.Owin.API.Controllers
{
    [RoutePrefix("user")]
    public class UsersController : ApiController
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, UserName = "user.1", FullName = "User 1", Email = "user.1@sample.net" },
            new User { Id = 2, UserName = "user.2", FullName = "User 2", Email = "user.2@sample.net" },
            new User { Id = 3, UserName = "user.3", FullName = "user 3", Email = "user.3@sample.net" },
        };

        private int GetNextId()
        {
            var lastUser = _users.OrderBy(orderBy => orderBy.Id).LastOrDefault();

            if (lastUser == null)
                return 1;

            return lastUser.Id + 1;
        }

        [Route, HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        [Route("{username}", Name = "GetUserByName"), HttpGet]
        public IHttpActionResult GetUserByName(string userName)
        {
            var user = _users.FirstOrDefault(where => where.UserName.ToLower() == userName.ToLower());

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [Route("{partialname}/search"), HttpGet]
        public IEnumerable<User> GetUserByPartialName(string partialName)
        {
            return _users.Where(where => where.FullName.ToLower().Contains(partialName.ToLower()));
        }

        [Route, HttpPost]
        public IHttpActionResult AddUser(User user)
        {
            var localUser = _users.SingleOrDefault(where => where.UserName == user.UserName);

            if (localUser != null)
                return Conflict();

            user.Id = GetNextId();

            _users.Add(user);

            var routeParams = new Dictionary<string, object>();
            routeParams.Add("username", user.UserName);

            return Created<User>(Url.Route("GetUserByName", routeParams), user);
        }

        [Route("{username}"), HttpPut]
        public IHttpActionResult UpdateUser(string userName, User user)
        {
            var localUser = _users.SingleOrDefault(where => where.UserName == userName);

            if (localUser == null)
                return NotFound();

            localUser.UpdateFrom(user);

            return Ok(localUser);
        }

        [Route("{username}"), HttpDelete]
        public IHttpActionResult RemoveUser(string userName)
        {
            var localUser = _users.SingleOrDefault(where => where.UserName == userName);

            if (localUser != null)
                _users.Remove(localUser);

            return Ok();
        }
    }
}