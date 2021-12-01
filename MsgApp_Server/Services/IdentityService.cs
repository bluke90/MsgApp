using MsgApp_Server.Data;
using MsgApp_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgApp_Server.Services
{
    public static class IdentityService
    {
        public static string GenerateNewToken()
        {
            var tokens_list = new List<Client>();
            var _context = new DataContext();
            tokens_list = _context.Clients.ToList();
            
            // Generate ID token for new user
            var new_token = false;
            // Determine if Token is unique, if so return token, if not generate new random token
            while (!new_token) {
                var token = GetNewRandomNumber();
                for(int i = 0; i < tokens_list.Count; i++) {
                    if (token == tokens_list[i].ContactToken) {
                        break;
                    }
                    if(i == tokens_list.Count - 1) { return token; }
                }

            }
            throw new Exception("Unable to Generate New Token...");

        }

        private static string GetNewRandomNumber()
        {
            var rand = new Random();
            var token = rand.Next(1000, 99999);
            return token.ToString();
        }

        public static void GetToken()
        {
            // Get ID Token of user
        }

        public static void AddToken()
        {
            // Add ID Token of user

        }



    }
}
