// <copyright file="Aunthenticator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Banking_Application
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class to authenticate the users.
    /// </summary>
    public class Aunthenticator
    {
        private string userID;
        private string password;

        /// <summary>
        /// Dictionary which contains the user ID and their passwords.
        /// </summary>
        private Dictionary<string, string> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="Aunthenticator"/> class.
        /// </summary>
        /// <param name="userId">User Id to be authenticated.</param>
        /// <param name="password">Password entered.</param>
        public Aunthenticator(string userId, string password)
        {
            this.userID = userId;
            this.password = password;
            this.users = new Dictionary<string, string> { };
            this.PopulateDictionary();
        }

        /// <summary>
        /// Authenticates the user by checking in the database.
        /// </summary>
        /// <returns>True if Authenticated else false.</returns>
        public bool Authenticate()
        {
            if (this.users.ContainsKey(this.userID))
            {
                string pass = this.users[this.userID];
                if (string.Equals(this.password, pass))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Populates the User Dictionary.
        /// </summary>
        private void PopulateDictionary()
        {
            // Reading all the lines from the file.
            string[] lines = File.ReadAllLines("Users.txt");

            // Extracting the UserID and the passwords from each line.
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                string userID = words[0];
                string password = words[1];
                this.users[userID] = password;
            }
        }
    }
}
