using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EmailServices
{
    class SystemSupportMail:MasterEmailServer
    {
        public SystemSupportMail()
        {
            senderEmail = "antoniotinh1998@gmail.com";
            password = "Tinh0123asd";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeStmpClient();
        }
    }
}
