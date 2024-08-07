﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox;

namespace OnlineStoreManagementSystem
{
    public class Admin
    {
        #region Fields

        private string _email;
		private string _pass;

        #endregion

        #region Constructors

        public Admin(string email, string pass)
        {
            Email = email;
            Pass = pass;
        }

        #endregion

        #region Properties

        public string Email
		{
			get { return _email; }
			private set { _email = value; }
		}
        private string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        #endregion

        #region Methods

        public bool Login(List<Admin> admins)
        {
            Console.Write("Email : ");
            string email = Console.ReadLine();

            // Verify if the email does not exists in the list
            if ((!admins.Any(a => a.Email == email)))
            {
                Tool.ShowErrorMessage("Email not registered");
                Login(admins);
            }

            Console.Write("Pass : ");
            string pass = Console.ReadLine();

            foreach (Admin admin in admins)
            {
                if(admin.Email == email)
                {
                    if(Pass == admin.Pass)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion
    }
}
