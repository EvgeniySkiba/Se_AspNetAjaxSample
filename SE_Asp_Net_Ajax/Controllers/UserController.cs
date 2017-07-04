using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using SE_Asp_Net_Ajax.Data;
using SE_Asp_Net_Ajax.Data.Abstract;
using SE_Asp_Net_Ajax.Data.Concrete;
using SE_Asp_Net_Ajax.Models;
using SE_Asp_Net_Ajax.Utils;
using SE_Asp_Net_Ajax.ViewModel;

namespace SE_Asp_Net_Ajax.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository noterepository;

        private List<User> usersList;

        public UserController()
        {
            usersList = UserUtils.usersList;
            noterepository = new UserRepository(new UserContext());
        }

        [HttpPost]
        public JsonResult list()
        {
            var res = noterepository.GetUsers();
            string users = JsonConvert.SerializeObject(res);
            return Json(users, JsonRequestBehavior.AllowGet);
        }


        public async Task<ActionResult> listAsynk()
        {
            var usersList = noterepository.GetUsers();

            string users = JsonConvert.SerializeObject(usersList);
            return Json(users, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public async Task<ActionResult> listAllAsynk()
        {
            System.Diagnostics.Debug.WriteLine("UserController");

            var task = Task.Run(() => noterepository.GetUsersAsync());
            var result = await task;

            string users = JsonConvert.SerializeObject(result);
            return Json(users, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult list(int page, int itemsPerPage)
        {

            List<User> users = usersList.Skip(itemsPerPage * (page - 1)).Take(itemsPerPage)
                .ToList();

            int totalCount = users.Count();//return the number of pages
            UserViewModel userModel = new UserViewModel() { CurrentPage = page, users = users, TotalCount = totalCount };

            string jsonString = JsonConvert.SerializeObject(userModel, Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });

            return Json(jsonString, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(int id, string email, string gender, string name, string midleName, string lastName, string firstName)
        {
            UserUtils.AddUser(id, email, gender, name, midleName, lastName, firstName);
            return Json("User Details was created");
        }


        /// <summary>  
        /// Update the user details  
        /// </summary>  
        /// <param name="usersJson">users list in JSON Format</param>  
        /// <returns></returns>  
        [HttpPost]
        public JsonResult UpdateUsersDetail(string usersJson)
        {
            if (String.IsNullOrEmpty(usersJson))
                return Json("Incorect params");

            var js = new JavaScriptSerializer();
            var user = js.Deserialize<User>(usersJson);
            if (user == null)
                return Json("Error");

            UserUtils.AddUser(user);

            return Json("User Details are created");
        }

        [HttpPost]
        public JsonResult AddEmployee(User user)
        {
            try
            {
                UserUtils.AddUser(user);
                return Json("Records added Successfully.");
            }
            catch
            {
                return Json("Records not added,");
            }
        }

        public JsonResult GetbyID(int id)
        {
            var user = usersList.Find(x => x.Id.Equals(id));
            return Json(user, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetJsonStringById(int id)
        {
            var user = usersList.Find(x => x.Id.Equals(id));
            var jsonUser = JsonConvert.SerializeObject(user);
            return Json(jsonUser, JsonRequestBehavior.AllowGet);
        }

        /// <summary>  
        /// Override the Json Result with Max integer JSON lenght  
        /// </summary>  
        /// <param name="data">Data</param>  
        /// <param name="contentType">Content Type</param>  
        /// <param name="contentEncoding">Content Encoding</param>  
        /// <param name="behavior">Behavior</param>  
        /// <returns>As JsonResult</returns>  
        protected override JsonResult Json(object data, string contentType,
            Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior,
                MaxJsonLength = Int32.MaxValue
            };
        }
    }
}