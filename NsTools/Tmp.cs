/*
 
      public List<string> OperatorMObjReturnsMany(string strWmi, string property)
        {
           _objSearch  = new ManagementObjectSearcher(new ObjectQuery(strWmi));
            ManagementObjectCollection queryCollection = _objSearch.Get();
            foreach (var qwe in queryCollection)
            {
                PropertyData data1 = qwe.Properties[property];
                string[] T = (string[])data1.Value;
                foreach (string item in T)
                {
                    _listReturn.Add(item);
                }
                break;
            }
            return _listReturn;
        }

}


Email email = new Email(
    "ns1.a3msites.com.br",
    587,
    "contato@nostopti.com",
    "@no@stop@ti@",
    "contato@nostopti.com",
    "tv@nostopti.com", "Was sent at " +
    DateTime.Now.ToString(),
    "CORPO DA MSG", 
    @"C:\Users\Marcus\Desktop\screen.zip");
email.Sending();
*/



