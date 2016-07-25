using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NewApp.Models;


namespace NewApp.Models
{
    public class DataBase
    {
        public static List<Data> UsersData()
        {
            List<Data> data = new List<Data>();
            var data1 = new Data();
            data1.UserStatus = "Active";
            data1.FirstName = "Taban";
            data1.LastName = "Cosmos";
            data1.Email = "cosmos@changepoint.com";

            var data2 = new Data();
            data2.UserStatus = "InActive";
            data2.FirstName = "Chris";
            data2.LastName = "Bobo";
            data2.Email = "Bobo@changepoint.com";

            var data3 = new Data();
            data3.UserStatus = "Active";
            data3.FirstName = "Greg";
            data3.LastName = "NoLastName";
            data3.Email = "NoLastName@changepoint.com";

            var data4 = new Data();
            data4.UserStatus = "InActive";
            data4.FirstName = "David";
            data4.LastName = "Peterson";
            data4.Email = "Peterson@changepoint.com";
            var data5 = new Data();
            data5.UserStatus = "Active";
            data5.FirstName = "David";
            data5.LastName = "Jackson";
            data5.Email = "Jackson@changepoint.com";
            var data6 = new Data();
            data6.UserStatus = "Active";
            data6.FirstName = "Kape";
            data6.LastName = "Cosmos";
            data6.Email = "kcosmos@changepoint.com";
            var data7 = new Data();
            data7.UserStatus = "InActive";
            data7.FirstName = "Sam";
            data7.LastName = "Peter";
            data7.Email = "Peter@changepoint.com";
            var data8 = new Data();
            data8.UserStatus = "InActive";
            data8.FirstName = "Davidson";
            data8.LastName = "Petron";
            data8.Email = "Peteron@changepoint.com";
            var data9 = new Data();
            data9.UserStatus = "Active";
            data9.FirstName = "Xingo";
            data9.LastName = "kimli";
            data9.Email = "kimli@changepoint.com";
            var data10 = new Data();
            data10.UserStatus = "Active";
            data10.FirstName = "Michael";
            data10.LastName = "Githinji";
            data10.Email = "Peterson@changepoint.com";
            var data11 = new Data();
            data11.UserStatus = "Active";
            data11.FirstName = "Latio";
            data11.LastName = "Cosmos";
            data11.Email = "lcosmos@changepoint.com";
            var data12 = new Data();
            data12.UserStatus = "InActive";
            data12.FirstName = "David";
            data12.LastName = "Peterson";
            data12.Email = "Peterson@changepoint.com";
            var data13 = new Data();
            data13.UserStatus = "Active";
            data13.FirstName = "Taban";
            data13.LastName = "Cosmos";
            data13.Email = "cosmos@changepoint.com";
            var data14 = new Data();
            data14.UserStatus = "InActive";
            data14.FirstName = "Chris";
            data14.LastName = "Bobo";
            data14.Email = "Bobo@changepoint.com";
            var data15 = new Data();
            data15.UserStatus = "Active";
            data15.FirstName = "Greg";
            data15.LastName = "NoLastName";
            data15.Email = "NoLastName@changepoint.com";
            var data16 = new Data();
            data16.UserStatus = "InActive";
            data16.FirstName = "David";
            data16.LastName = "Peterson";
            data16.Email = "Peterson@changepoint.com";
            var data17 = new Data();
            data17.UserStatus = "InActive";
            data17.FirstName = "David";
            data17.LastName = "Peterson";
            data17.Email = "Peterson@changepoint.com";
            var data18 = new Data();
            data18.UserStatus = "InActive";
            data18.FirstName = "David";
            data18.LastName = "Peterson";
            data18.Email = "Peterson@changepoint.com";
            var data19 = new Data();
            data19.UserStatus = "InActive";
            data19.FirstName = "David";
            data19.LastName = "Peterson";
            data19.Email = "Peterson@changepoint.com";
            var data20 = new Data();
            data20.UserStatus = "InActive";
            data20.FirstName = "David";
            data20.LastName = "Peterson";
            data20.Email = "Peterson@changepoint.com";
            var data21 = new Data();
            data21.UserStatus = "InActive";
            data21.FirstName = "David";
            data21.LastName = "Peterson";
            data21.Email = "Peterson@changepoint.com";
            var data22 = new Data();
            data22.UserStatus = "InActive";
            data22.FirstName = "David";
            data22.LastName = "Peterson";
            data22.Email = "Peterson@changepoint.com";
            var data23 = new Data();
            data23.UserStatus = "InActive";
            data23.FirstName = "David";
            data23.LastName = "Peterson";
            data23.Email = "Peterson@changepoint.com";
            var data24 = new Data();
            data24.UserStatus = "InActive";
            data24.FirstName = "David";
            data24.LastName = "Peterson";
            data24.Email = "Peterson@changepoint.com";

            //Add data to list and send it back to the vew
            data.Add(data1);
            data.Add(data2);
            data.Add(data3);
            data.Add(data4);
            data.Add(data5);
            data.Add(data6);
            data.Add(data7);
            data.Add(data8);
            data.Add(data9);
            data.Add(data10);
            data.Add(data11);
            data.Add(data12);
            data.Add(data13);
            data.Add(data14);
            data.Add(data15);
            data.Add(data16);
            data.Add(data17);
            data.Add(data18);
            data.Add(data19);
            data.Add(data20);
            data.Add(data21);
            data.Add(data22);
            data.Add(data23);
            data.Add(data24);
            return data;


        }

    }
}
