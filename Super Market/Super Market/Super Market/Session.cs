using System;
using System.Collections.Generic;
using System.Text;
namespace Super_Market
{
    public  static class Session
    {
        private static int employeeID;
        private static String employeeName;
        private static String title;
        private static String sex;
        private static String username;
        private static String session;
        /*
        public Session()
        {
            employeeID = 0;
            employeeName = "";
            this.title = "";
            this.sex = "";
            this.username = "";

        }
        public Session(int employeeid, String employeeName, String title, String sex, String username)
        {
            this.employeeID = employeeid;
            this.title = title;
            this.sex = sex;
            this.username = username;
        }
         * */
        public static void set(int employeeid, String employeename, String Title, String Sex, String userName)
        {
            employeeID = employeeid;
            employeeName = employeename;
            title = Title;
            sex = Sex;
            username = userName;

        }
         
        public static int _EmployeeId
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public static String _EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public static String _Title
        {
            get { return title; }
            set { title = value; }
        }
        public static String _Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public static String _Username {
            get { return username; }
            set { username = value; }
        }
        public static String _Session
        {
            get {
                return session;
            }
            set { session = username; }
        }
         
    }
}
