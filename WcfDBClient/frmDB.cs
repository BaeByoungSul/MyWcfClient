using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BBS;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;

namespace WcfClient
{
 
    public partial class frmDB: Form
    {
        public frmDB()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GetData DataSet, GetData List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void btn_t5_2_Click(object sender, EventArgs e)
        {
            // Create Db Command
            List<MyCommand> mycmds = new List<MyCommand>();
            MyCommand cmdMst = ITEM_MST_Command();
            MyCommand cmdDtl = ITEM_DTL_Command();
            mycmds.AddRange(new MyCommand[] { cmdMst, cmdDtl });

            try
            {
                if (cbo_t1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // 기본 binding
                MyBindinEnum bindinEnum = MyBindinEnum.Http;

                if (cbo_t1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
                else if (cbo_t1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

                DBClient _cli = new DBClient(bindinEnum);

                SvcReturnDs rtn = _cli.ExecQuery(mycmds);

                dgv_t1_2.DataSource = rtn.ReturnDs.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private MyCommand GetCmd()
        {
            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                           (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_MST_SEL");



            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("@TEST_PARA", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);

            //가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][];
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "%");
            myParaValues[0][1] = new MyParaValue("@TEST_PARA", "%");

            _cmd.ParaValues = myParaValues;
            return _cmd;
        }

        private void btn_t1_3_Click(object sender, EventArgs e)
        {
            //
            StringBuilder strQuery1 = new StringBuilder();
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST1(COL1,COL2) VALUES ('111','222' ) ");
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST21(COL1,COL2) VALUES ('112','222' ) ");
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST1(COL1,COL2) VALUES ('113','222' ) ");

            // Create Db Command
            List<MyCommand> mycmds = new List<MyCommand>();
            MyCommand cmd = new MyCommand("MST_1", "BSBAE", (int)CommandType.Text, strQuery1.ToString());

            MyCommand cmdMst = ITEM_MST_Command();
            MyCommand cmdDtl = ITEM_DTL_Command();
            mycmds.AddRange(new MyCommand[] {  cmdMst, cmdDtl });

            try
            {
                if (cbo_t1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // 기본 binding
                MyBindinEnum bindinEnum = MyBindinEnum.Http;
                
                if (cbo_t1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
                else if (cbo_t1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;
               
                DBClient _cli = new DBClient(bindinEnum);

                SvcReturnList<DBOutPut> rtn = _cli.ExecQuery<DBOutPut>(mycmds);

                dgv_t1_1.DataSource = rtn.ReturnList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private MyCommand ITEM_MST_Command()
        {

            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_MST_INS");

            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("@TEST_ID", (int)SqlDbType.BigInt, (int)ParameterDirection.Output);

            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][]; // 한세트 정의
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "배병술");
            myParaValues[0][1] = new MyParaValue("@TEST_ID", "");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }
        private MyCommand ITEM_DTL_Command()
        {
            MyCommand _cmd = new MyCommand("DTL", "AZURE_DB",
                            (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_DTL_INS");


            _cmd.Parameters = new MyPara[3];

            _cmd.Parameters[0] = new MyPara("@TEST_ID", (int)SqlDbType.BigInt, (int)ParameterDirection.Input,
                "MST", "@TEST_ID");
            _cmd.Parameters[1] = new MyPara("@TEST_DTL_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[2] = new MyPara("@AMOUNT", (int)SqlDbType.Decimal, (int)ParameterDirection.Input);



            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[3][]; // 3세트 정의

            myParaValues[0] = new MyParaValue[3]; // 첫번째 셋트
            myParaValues[0][0] = new MyParaValue("@TEST_ID", null);
            myParaValues[0][1] = new MyParaValue("@TEST_DTL_NM", "놀부1");
            myParaValues[0][2] = new MyParaValue("@AMOUNT", "123.5");

            myParaValues[1] = new MyParaValue[3]; // 두번째 셋트
            myParaValues[1][0] = new MyParaValue("@TEST_ID", null);
            myParaValues[1][1] = new MyParaValue("@TEST_DTL_NM", "놀부2");
            myParaValues[1][2] = new MyParaValue("@AMOUNT", "222.5");

            myParaValues[2] = new MyParaValue[3]; // 세번째 셋트
            myParaValues[2][0] = new MyParaValue("@TEST_ID", null);
            myParaValues[2][1] = new MyParaValue("@TEST_DTL_NM", "흥부");
            myParaValues[2][2] = new MyParaValue("@AMOUNT", "333.5");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }

        private void btn_t1_1_Click(object sender, EventArgs e)
        {

            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo_t1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo_t1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);

           

            SvcReturnList<TestItemMst,TestItemDtl>  rtn = _cli.GetDataList<TestItemMst, TestItemDtl>(GetCmd());

            dgv_t1_1.DataSource = null;
            dgv_t1_2.DataSource = null;

            if (rtn.ReturnCD=="OK")
            {
                dgv_t1_1.DataSource = rtn.ReturnList1;
                dgv_t1_2.DataSource = rtn.ReturnList2;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo_t1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo_t1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);
            SvcReturnDs rtn = _cli.GetDataSet(GetCmd());

            dgv_t1_1.DataSource = null;
            dgv_t1_2.DataSource = null;

            if (rtn.ReturnCD == "OK")
            {
                dgv_t1_1.DataSource = rtn.ReturnDs.Tables[0];
                dgv_t1_2.DataSource = rtn.ReturnDs.Tables[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCommand cmd = GetCmd_T2_1();

            SvcReturn rtn =  TestSelect(cmd);
            
            Console.WriteLine(rtn.ReturnStr);

            StringReader theReader = new StringReader(rtn.ReturnStr);
            DataSet ds = new DataSet();
            ds.ReadXml(theReader, XmlReadMode.ReadSchema);

            dgv_t2_1.DataSource = ds.Tables[0];   

        }

        private MyCommand GetCmd_T2_1()
        {
            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                                       (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_MST_SEL");



            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("@TEST_PARA", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);

            //가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][];
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "%");
            myParaValues[0][1] = new MyParaValue("@TEST_PARA", "%");

            _cmd.ParaValues = myParaValues;
            return _cmd;
        }
        private MyCommand GetCmd_T2_2()
        {
            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                           (int)CommandType.Text, "SELECT TEST_ID, TEST_MST_NM, CREATION_DATE FROM TEST_MST");



            //_cmd.Parameters = new MyPara[2];
            //_cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            //_cmd.Parameters[1] = new MyPara("@TEST_PARA", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);

            ////가변배열 초기화
            //MyParaValue[][] myParaValues = new MyParaValue[1][];
            //myParaValues[0] = new MyParaValue[2];

            //myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "%");
            //myParaValues[0][1] = new MyParaValue("@TEST_PARA", "%");

            //_cmd.ParaValues = myParaValues;
            return _cmd;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MyCommand _cmd = new MyCommand("MST", "CSMT",
            //               (int)CommandType.Text, "SELECT * FROM PM_BAD_CODE");

            MyCommand _cmd = GetOraCmd_T2_1();

            SvcReturn rtn = TestSelect2(_cmd);
            //SvcReturn rtn = TestSelect(_cmd);

            Console.WriteLine(rtn.ReturnStr);

            StringReader theReader = new StringReader(rtn.ReturnStr);
            DataSet ds = new DataSet();
            ds.ReadXml(theReader, XmlReadMode.ReadSchema);

            dgv_t2_1.DataSource = ds.Tables[0];
            dgv_t2_2.DataSource = ds.Tables[1];


        }
        private MyCommand GetOraCmd_T2_1()
        {
            MyCommand _cmd = new MyCommand("MST", "AWS_ORA_DB",
                                     (int)CommandType.Text, "SELECT sysdate from dual");

            
            return _cmd;

        }
        private MyCommand GetOraCmd_T2_2()
        {
            MyCommand _cmd = new MyCommand("MST", "AWS_ORA_DB",
                                     (int)CommandType.StoredProcedure, "USP_ZBBS_PKG.Test_Query1");

            _cmd.Parameters = new MyPara[3];
            _cmd.Parameters[0] = new MyPara("VIEW_CUSOR1", (int)OracleDbType.RefCursor, (int)ParameterDirection.Output);
            _cmd.Parameters[1] = new MyPara("VIEW_CUSOR2", (int)OracleDbType.RefCursor, (int)ParameterDirection.Output);
            _cmd.Parameters[2] = new MyPara("P_BAD_TYPE", (int)OracleDbType.Varchar2, (int)ParameterDirection.Input);

            //가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][]; // 한 셋트
            myParaValues[0] = new MyParaValue[3];     // 첫번째 세트

            myParaValues[0][0] = new MyParaValue("VIEW_CUSOR1", null);
            myParaValues[0][1] = new MyParaValue("VIEW_CUSOR2", null);
            myParaValues[0][2] = new MyParaValue("P_BAD_TYPE", "6");

            _cmd.ParaValues = myParaValues;

            return _cmd;

        }
        private const string sOkMsg1 = "Completed successfully";

        public SvcReturn TestSelect(MyCommand mycmd)
        {
            try
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[mycmd.ConnectionName];
                if (settings == null)
                {
                    return new SvcReturn
                    {
                        ReturnCD = "FAIL",
                        ReturnMsg = "There is no Connection Name",
                        ReturnStr = String.Empty
                    };
                }

                IDbConnection dbconnection = null;
                IDbCommand dbCommand = null;
                
                // DB Connection 
                if (settings.ProviderName.Equals("System.Data.SqlClient"))  
                    dbconnection = new SqlConnection(settings.ConnectionString);
                else if (settings.ProviderName.Equals("Oracle.ManagedDataAccess.Client")) 
                    dbconnection = new OracleConnection(settings.ConnectionString);
                else if (settings.ProviderName.Equals("MySql.Data.MySqlClient")) 
                    dbconnection = new MySqlConnection(settings.ConnectionString);


                // DB Command
                dbconnection.Open();
                dbCommand = dbconnection.CreateCommand();
                dbCommand.Connection = dbconnection;
                dbCommand.CommandType = (CommandType)mycmd.CommandType;
                dbCommand.CommandText = mycmd.CommandText;

                //
                IDbDataParameter myPara = null;
                // Add Parameter: ?? null 인 경우 처리
                foreach (MyPara para in mycmd.Parameters ?? Enumerable.Empty<MyPara>())
                {
                    if (string.IsNullOrEmpty(para.ParameterName)) break;
                    if (string.IsNullOrWhiteSpace(para.ParameterName)) break;

                    if (settings.ProviderName.Equals("System.Data.SqlClient"))
                        myPara = new SqlParameter(para.ParameterName, (SqlDbType)para.DbDataType);
                    else if (settings.ProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                        myPara = new OracleParameter(para.ParameterName, (OracleDbType)para.DbDataType);
                    else if (settings.ProviderName.Equals("MySql.Data.MySqlClient"))
                        myPara = new MySqlParameter(para.ParameterName,(MySqlDbType)para.DbDataType);

                    myPara.Direction = (ParameterDirection)Convert.ToInt32(para.Direction);
                    dbCommand.Parameters.Add(myPara);
                }

                // Parameter 값 셋팅
                foreach (MyParaValue[] paraVal in mycmd.ParaValues ?? Enumerable.Empty<MyParaValue[]>())
                {
                    foreach (MyParaValue item in paraVal)
                    {
                        if (string.IsNullOrEmpty(item.ParameterName)) break;
                        if (string.IsNullOrWhiteSpace(item.ParameterName)) break;

                        // 파라미터가  input,  InputOutput일 경우 값을 저장
                        MyPara firstPara = mycmd.Parameters.FirstOrDefault(x => x.ParameterName == item.ParameterName);
                        if (firstPara.Direction == (int)ParameterDirection.Input ||
                            firstPara.Direction == (int)ParameterDirection.InputOutput)
                        {
                            // Parameter값
                            if (settings.ProviderName.Equals("System.Data.SqlClient"))
                                ((SqlCommand)dbCommand).Parameters[item.ParameterName].Value = item.ParaValue;
                            else if (settings.ProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                                ((OracleCommand)dbCommand).Parameters[item.ParameterName].Value = item.ParaValue;
                            else if (settings.ProviderName.Equals("MySql.Data.MySqlClient"))
                                ((MySqlCommand)dbCommand).Parameters[item.ParameterName].Value = item.ParaValue;
                        }
                   
                     
                    }
                    break;// 조회는 commmand 별로 한번 실행
                }
                
                // DB Command exec 
                IDataAdapter dbAdapter = null;

                if (settings.ProviderName.Equals("System.Data.SqlClient")) 
                    dbAdapter = new SqlDataAdapter((SqlCommand)dbCommand);
                else if (settings.ProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                    dbAdapter = new OracleDataAdapter((OracleCommand)dbCommand); 
                else if (settings.ProviderName.Equals("MySql.Data.MySqlClient"))
                    dbAdapter = new MySqlDataAdapter((MySqlCommand)dbCommand); 


                DataSet ds = new DataSet("Result_Ds");
                dbAdapter.Fill(ds);

                // 쿼리 데이터셋 to Xml string  
                System.IO.StringWriter writer = new System.IO.StringWriter();
                ds.WriteXml(writer, XmlWriteMode.WriteSchema);

                SvcReturn data = new SvcReturn();

                data.ReturnCD = "OK";
                data.ReturnMsg = sOkMsg1;
                data.ReturnStr = writer.ToString();

                return data;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }


        public SvcReturn TestSelect2(MyCommand mycmd)
        {
            try
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[mycmd.ConnectionName];
                if (settings == null)
                {
                    return new SvcReturn
                    {
                        ReturnCD = "FAIL",
                        ReturnMsg = "There is no Connection Name",
                        ReturnStr = String.Empty
                    };
                }

                IDbConnection dbconnection = null;
                IDbCommand dbCommand = null;
                IDataAdapter dbAdapter = null;

                // DB Connection 
                dbconnection = SetConnection(mycmd, settings);
                dbconnection.Open();

                // DB Command
                dbCommand = dbconnection.CreateCommand();
                dbCommand.Connection = dbconnection;
                dbCommand.CommandType = (CommandType)mycmd.CommandType;
                dbCommand.CommandText = mycmd.CommandText;

                // DB Parameter
                // SetParameter(dbCommand, mycmd, settings.ProviderName);
                IDbDataParameter dbDataParameter = null;
                for (int i = 0; i < mycmd.Parameters.Count(); i++)
                {
                    dbDataParameter = CreateParameter(mycmd.Parameters[i], settings.ProviderName);

                    dbCommand.Parameters.Add(dbDataParameter);

                }

                // Set Parameter Value
                for (int i = 0; i < dbCommand.Parameters.Count; i++)
                {
                    if (((IDbDataParameter)dbCommand.Parameters[i]).Direction == ParameterDirection.InputOutput)
                        continue;
                    if (((IDbDataParameter)dbCommand.Parameters[i]).Direction == ParameterDirection.Output)
                        continue;

                    // 조회는 한번의 첫 번째 파라미터 셋트만 실행
                    ((IDbDataParameter)dbCommand.Parameters[i]).Value = mycmd.ParaValues[0][i].ParaValue;
                }


                // DB Adapter
                dbAdapter = SetDbAdapter(dbCommand, settings.ProviderName);

                // DB Command exec 
                DataSet ds = new DataSet("Result_Ds");
                dbAdapter.Fill(ds);

                // 쿼리 데이터셋 to Xml string  
                System.IO.StringWriter writer = new System.IO.StringWriter();
                ds.WriteXml(writer, XmlWriteMode.WriteSchema);

                SvcReturn data = new SvcReturn();

                data.ReturnCD = "OK";
                data.ReturnMsg = sOkMsg1;
                data.ReturnStr = writer.ToString();

                return data;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }
        private IDbConnection SetConnection(MyCommand cmd, ConnectionStringSettings settings)
        {
            IDbConnection dbConn = null;
            if (settings.ProviderName.Equals("System.Data.SqlClient"))
                dbConn = new SqlConnection(settings.ConnectionString);
            else if (settings.ProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                dbConn = new OracleConnection(settings.ConnectionString);
            else if (settings.ProviderName.Equals("MySql.Data.MySqlClient"))
                dbConn = new MySqlConnection(settings.ConnectionString);

            return dbConn;
        }
        private IDbDataParameter CreateParameter(MyPara myPara, string sProviderName)
        {
            IDbDataParameter dbDataParameter = null;

            if (string.IsNullOrEmpty(myPara.ParameterName)) return null;
            if (string.IsNullOrWhiteSpace(myPara.ParameterName)) return null;

            if (sProviderName.Equals("System.Data.SqlClient"))
                dbDataParameter = new SqlParameter(myPara.ParameterName, (SqlDbType)myPara.DbDataType);
            else if (sProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                dbDataParameter = new OracleParameter(myPara.ParameterName, (OracleDbType)myPara.DbDataType);
            else if (sProviderName.Equals("MySql.Data.MySqlClient"))
                dbDataParameter = new MySqlParameter(myPara.ParameterName, (MySqlDbType)myPara.DbDataType);

            dbDataParameter.Direction = (ParameterDirection)Convert.ToInt32(myPara.Direction);

            return dbDataParameter;

        }
        private IDbDataAdapter SetDbAdapter(IDbCommand dbcmd, string sProviderName)
        {
            IDbDataAdapter dbAdapter = null;

            if (sProviderName.Equals("System.Data.SqlClient"))
                dbAdapter = new SqlDataAdapter((SqlCommand)dbcmd);
            else if (sProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                dbAdapter = new OracleDataAdapter((OracleCommand)dbcmd);
            else if (sProviderName.Equals("MySql.Data.MySqlClient"))
                dbAdapter = new MySqlDataAdapter((MySqlCommand)dbcmd);

            return dbAdapter;
        }

        private void SetParameter(IDbCommand dbcmd, MyCommand mycmd, string sProviderName)
        {
            IDbDataParameter dbDataParameter = null;

            // Add Parameter: ?? null 인 경우 처리
            foreach (MyPara para in mycmd.Parameters ?? Enumerable.Empty<MyPara>())
            {
                if (string.IsNullOrEmpty(para.ParameterName)) break;
                if (string.IsNullOrWhiteSpace(para.ParameterName)) break;

                if (sProviderName.Equals("System.Data.SqlClient"))
                    dbDataParameter = new SqlParameter(para.ParameterName, (SqlDbType)para.DbDataType);
                else if (sProviderName.Equals("Oracle.ManagedDataAccess.Client"))
                    dbDataParameter = new OracleParameter(para.ParameterName, (OracleDbType)para.DbDataType);
                else if (sProviderName.Equals("MySql.Data.MySqlClient"))
                    dbDataParameter = new MySqlParameter(para.ParameterName, (MySqlDbType)para.DbDataType);

                dbDataParameter.Direction = (ParameterDirection)Convert.ToInt32(para.Direction);
                dbcmd.Parameters.Add(dbDataParameter);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = "User ID=ADMIN;Password=Asdfqwer1234!@#$;" +
                    "Data Source=nakdongdb_medium;Connection Timeout=130;";

                OracleConfiguration.TnsAdmin = @"D:\Prog_Git\03.WCF\WcfClient\WcfDBClient\bin\Debug";
                OracleConfiguration.WalletLocation    = OracleConfiguration.TnsAdmin;
                OracleConfiguration.TraceFileLocation = OracleConfiguration.TnsAdmin;
                OracleConfiguration.TraceLevel = 7;


                OracleConnection con = new OracleConnection(conString);
                OracleCommand cmd = con.CreateCommand();
                con.Open();

                cmd.CommandText = "select sysdate from dual;";
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString());
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo_t1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo_t1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);
            SvcReturnDs rtn = _cli.GetDataSet(GetOraCmd_T2_1());

            dgv_t2_1.DataSource = null;
            

            if (rtn.ReturnCD == "OK")
            {
                dgv_t2_1.DataSource = rtn.ReturnDs.Tables[0];
                

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgv_t1_1.DataSource  = null;
            dgv_t1_2.DataSource = null;
            //BasicHttpBinding myBinding = new BasicHttpBinding();

            //EndpointAddress myEndpoint = new EndpointAddress("http://172.20.105.36:9110/DBService");

            //ChannelFactory<IDBService> myChannelFactory = new ChannelFactory<IDBService>(myBinding, myEndpoint);

            //// Create a channel.
            //IDBService _cli = myChannelFactory.CreateChannel();
            //SvcReturn result = _cli.GetDataSetXml(GetCmd());
            //Console.WriteLine(result.ReturnStr);
            //((IClientChannel)_cli).Close();
        }
    }

    public class DynamicXml : DynamicObject
    {
        XElement _root;
        private DynamicXml(XElement root)
        {
            _root = root;
        }

        public static DynamicXml Parse(string xmlString)
        {
            return new DynamicXml(XDocument.Parse(xmlString).Root);
        }

        public static DynamicXml Load(string filename)
        {
            return new DynamicXml(XDocument.Load(filename).Root);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;

            var att = _root.Attribute(binder.Name);
            if (att != null)
            {
                result = att.Value;
                return true;
            }

            var nodes = _root.Elements(binder.Name);
            if (nodes.Count() > 1)
            {
                result = nodes.Select(n => n.HasElements ? (object)new DynamicXml(n) : n.Value).ToList();
                return true;
            }

            var node = _root.Element(binder.Name);
            if (node != null)
            {
                result = node.HasElements || node.HasAttributes ? (object)new DynamicXml(node) : node.Value;
                return true;
            }

            return true;
        }
    }
}
