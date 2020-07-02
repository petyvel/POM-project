using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Models;
using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Factories
{
   
        public static class RegistrationFormFactory
        {
            public static RegistrationFormModel Create()
            {
                return new RegistrationFormModel
                {
                    Title = "Mr.", 
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    Email = "Ivan.Petroff@yahoo.com",
                    Password = "123456",
                    AddressLineFirstName ="Ivan",
                    AddressLineLastName="Petrov",
                    Address="Kamaro, str.24",
                    City="New York",
                    State="New York",
                    ZipCode="34527",
                    MobilePhone = "123456789043",
                    AlternativeEmail="genesys@gmail.com",

                };
            }
        }
}
