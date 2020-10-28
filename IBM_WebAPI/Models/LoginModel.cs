using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UnitOfWork;

namespace IBM_WebAPI.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Sex")]
        [Required]
        public string Sex { get; set; }

        [Display(Name = "Contact Number")]
        [Required]
        public int ContactNumber { get; set; }


        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public int StatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public static async Task CreateAccount(LoginModel items, GenericUnitOfWork _unitOfWork)
        {
            var createUser = _unitOfWork.GetRepoInstance<User>();
            var createAccount = _unitOfWork.GetRepoInstance<Account>();
            var users = new User()
            {
                Firstname = items.Firstname,
                LastName = items.LastName,
                Sex = items.Sex,
                ContactNumber = items.ContactNumber,
                Address = items.Address,
                CreatedDate = DateTime.Now
            };
            createUser.Add(users);

            var accounts = new Account()
            {
                Username = items.Username,
                Password = items.Password,
                StatusId = (int)Status.Active,
                CreatedDate = DateTime.Now
            };
            createAccount.Add(accounts);

            await _unitOfWork.SaveChanges();
        }
    }
}