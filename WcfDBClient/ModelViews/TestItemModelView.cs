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
                SvcReturnList<TestItemMst> rtn = MyDBClient.GetDataList<TestItemMst>(mycmd);
                
                return rtn.ReturnList;


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
                SvcReturnDs resRtn = MyDBClient.GetDataSet(mycmd);
                return resRtn.ReturnDs;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public SvcReturnList<DBOutPut> ExecCommand(List<MyCommand> lstMyCmd)
        {
            try
            {
                SvcReturnList<DBOutPut> resRtn = MyDBClient.ExecCommand<DBOutPut>(lstMyCmd);

                return resRtn;
                //return execReturn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
    }
}
