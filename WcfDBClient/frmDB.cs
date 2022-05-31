using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBS;

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
            try
            {
                if (cbo_t1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                MyBindinEnum bindinEnum;
                //DBClient  _cli; //= new FileClient();
                if (cbo_t1.Text.Equals("Http"))
                {
                    bindinEnum = MyBindinEnum.Http;
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    bindinEnum = MyBindinEnum.NetTcp;
                }

                TestItemModelView modelView = new TestItemModelView(bindinEnum);
                List<TestItemMst> rtnList=  modelView.GetDataList(GetCmd());
                dgv_t1_1.DataSource = rtnList;

                //DataSet ds = modelView.GetTestItemMst(GetCmd());
                //dgv_t1_1.DataSource = ds.Tables[0];
                //txt_t1_1.Text = ds.Tables[0].ToString();
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

                MyBindinEnum bindinEnum;
                //DBClient  _cli; //= new FileClient();
                if (cbo_t1.Text.Equals("Http"))
                {
                    bindinEnum = MyBindinEnum.Http;
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    bindinEnum = MyBindinEnum.NetTcp;
                }

                TestItemModelView modelView = new TestItemModelView(bindinEnum);
                List<DBOutPut> rtnOutPut = modelView.ExecCommand(mycmds);
                dgv_t1_1.DataSource = rtnOutPut;

                //DataSet ds = modelView.GetTestItemMst(GetCmd());
                //dgv_t1_1.DataSource = ds.Tables[0];
                //txt_t1_1.Text = ds.Tables[0].ToString();
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


    }
}
