using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;

namespace FullAutomationSupportSystem
{
    [DataContract]
    public class OptionData
    {
        private static OptionData singleton = new OptionData();
        private OptionData()
        {
            Code = "UTF-8";
        }
        public static OptionData GetInstance()
        {
            return singleton;
        }
        public void XmlReader(XmlReader reader)
        {
            if (reader.Name == "Code")
            {
                reader.Read();
                Code = reader.Value;
            }
        }
        [DataMember]
        public string Code { set; get; }

    }
}
