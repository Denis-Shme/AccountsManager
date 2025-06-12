using System.Diagnostics.CodeAnalysis;
using AccountsManager.Core;
using AccountsManager.Models;

namespace AccountManager.Core.Test
{
    public class ServiceTest
    {
        
        public void AddAccountTest()
        {
            var service = new Service();
            var result = service.AddAccount(new Account()
                {
                    LastName = "Shmelkov",
                    FirstName = "Denis",
                    Login = "admin",
                    Password = "123"
                });
            //Accert.Equal(result, true);
            Console. Assert.True(result);
            
        }
    }
}