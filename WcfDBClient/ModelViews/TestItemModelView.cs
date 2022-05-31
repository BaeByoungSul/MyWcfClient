using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BBS

{
    public class TestItemModelView
    {
        private DBClient MyDBClient { get; set; }
        public TestItemModelView( MyBindinEnum myBindinEnum)
        {
            MyDBClient = new DBClient (myBindinEnum);
        }
        public List<TestItemMst> GetDataList(MyCommand mycmd)
        {
            try
            {
                SvcReturn resRtn = MyDBClient.GetDataSetXml(mycmd);

                var doc = XDocument.Parse(resRtn.ReturnStr);
                List<TestItemMst> lstReturn = new List<TestItemMst>();

                lstReturn = (from r in doc.Root.Elements("Table")
                             select new TestItemMst()
                             {
                                 TEST_ID = Convert.ToInt32(r.Element("TEST_ID").Value),
                                 TEST_MST_NM = r.Element("TEST_MST_NM").Value,
                                 CREATION_DATE = Convert.ToDateTime(r.Element("CREATION_DATE").Value)

                             }).ToList();
                return lstReturn;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet GetDataDs(MyCommand mycmd)

        {
            try
            {
                SvcReturn resRtn = MyDBClient.GetDataSetXml(mycmd);

                StringReader theReader = new StringReader(resRtn.ReturnStr);
                DataSet ds = new DataSet();
                ds.ReadXml(theReader, XmlReadMode.ReadSchema);
                return ds;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<DBOutPut> ExecCommand(List<MyCommand> lstMyCmd)
        {
            try
            {
                SvcReturn resRtn = MyDBClient.ExecNonQuery(lstMyCmd.ToArray());

                var doc = XDocument.Parse(resRtn.ReturnStr);
                List<DBOutPut> lstOutPut = new List<DBOutPut>();

                lstOutPut = (from r in doc.Root.Elements("output")
                             select new DBOutPut()
                             {
                                 Rowseq = Convert.ToInt32(r.Element("rowseq").Value),
                                 CommandName = r.Element("CommandName").Value,
                                 ParameterName = r.Element("ParameterName").Value,
                                 OutValue = r.Element("OutValue").Value,

                             }).ToList();
                return lstOutPut;

                //ExecReturn execReturn = new ExecReturn()
                //{
                //    ReturnCD = resRtn.ReturnCD,
                //    ReturnMsg = resRtn.ReturnMsg,
                //    ReturnOutPut = lstReturn
                //};
                //return execReturn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
