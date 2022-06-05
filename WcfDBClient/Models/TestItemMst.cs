using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BBS
{
    /// <summary>
    /// 검사항목 Class
    /// </summary>
    
    [XmlType(TypeName = "Table")]
    public class TestItemMst
    {
        public int TEST_ID { get; set; }
        public string TEST_MST_NM { get; set; }
        public DateTime CREATION_DATE { get; set; }

    }

    [XmlType(TypeName ="Table1")]
    public class TestItemDtl
    {
        public int TEST_ID { get; set; }
        public string TEST_DTL_NM { get; set; }

        public decimal AMOUNT { get; set; }
        public DateTime CREATION_DATE { get; set; }

    }
}
