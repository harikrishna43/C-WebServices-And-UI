﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Model;
using Newtonsoft.Json;
using WcfService1.Data;
using System.Web.Script.Serialization;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private GeneralDbContext db = new GeneralDbContext();
        public  string GetUser(int? Id,out bool result)
        {
            var jsonSerialiser = new JavaScriptSerializer();
            result = true;
            return jsonSerialiser.Serialize(db.DBUser.ToList());
        }

        //public async string GetUser(int? Id, out bool result)
        //{
        //    var jsonSerialiser = new JavaScriptSerializer();
        //    result = true;
        //    return jsonSerialiser.Serialize(db.DBUser.ToList());
        //}
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool InsertUserData(User user, out string result)
        {
            throw new NotImplementedException();
        }
    }
}
