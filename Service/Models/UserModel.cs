using Service.Models.Base;
using Service.Utilities;
using System.Collections.Generic;


namespace Service.Models
{
    public class UserModel : BaseModel
    {
        public UserModel() : base()
        {
            CRN = Generators.GenerateCRN();
            if (Id <= 0)
            {
                ActivationToken = Generators.GenerateActivationCode();
            }
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string CRN { get; }
        public string ActivationToken { get; }
        public bool IsActive { get; set; }       

        
        public override ModelState Validate()
        {
            var model_state = new ModelState();
            model_state.Errors = new List<string>();


            if (string.IsNullOrEmpty(Username))
            {
                model_state.IsValid = false;
                model_state.Errors.Add("Username is required");
            }

            if (string.IsNullOrEmpty(Email))
            {
                model_state.IsValid = true;
                model_state.Errors.Add("Email is required");

            }
            if (string.IsNullOrEmpty(Password))
            {
                model_state.IsValid = true;
                model_state.Errors.Add("Password is required");

            }
            if (string.IsNullOrEmpty(CRN))
            {
                model_state.IsValid = true;
                model_state.Errors.Add("CRN is required");
            }


            if (string.IsNullOrEmpty(Phone))
            {
                model_state.IsValid = true;
                model_state.Errors.Add("Phone is required");
            }


            if (model_state.Errors.Count > 0)
            {
                model_state.IsValid = false;
            }
            else
            {
                model_state.IsValid = true;
            }
            return model_state;
        }
    }
}
