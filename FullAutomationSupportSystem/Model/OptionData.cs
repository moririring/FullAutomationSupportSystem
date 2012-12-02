using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace FullAutomationSupportSystem
{
    [DataContract]
    public class OptionData
    {
        private static OptionData singleton = new OptionData();
        private OptionData()
        {
            Code = Encoding.UTF8;
        }
        public static OptionData GetInstance()
        {
            return singleton;
        }
        [DataMember]
        public Encoding Code { set; get; }

    }
}
