using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BBS
{
    public enum MyBindinEnum
    {
        Http,
        NetTcp
    }

    public class DBClient:IDisposable
    {
        private EndpointAddress address_http = new EndpointAddress("http://20.227.136.125:9110/DBService");
        private EndpointAddress address_tcp = new EndpointAddress("net.tcp://20.227.136.125:9120/DBService");
        private ChannelFactory<IDBService> MyFactory { get; set; }
        private IDBService MyChannel { get; set; }

        public DBClient(MyBindinEnum myBindin)
        {
            if (myBindin == MyBindinEnum.Http)
            {
                BasicHttpBinding binding = GetHttpBinding();
                MyFactory = new ChannelFactory<IDBService>(binding, address_http);
            }
            else if (myBindin == MyBindinEnum.NetTcp)
            {
                NetTcpBinding binding = GetNetTcpBinding();
                MyFactory = new ChannelFactory<IDBService>(binding, address_tcp);
            }
            MyChannel = MyFactory.CreateChannel();
        }
        
       
        private BasicHttpBinding GetHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.MessageEncoding = WSMessageEncoding.Mtom;
            binding.Security.Mode = BasicHttpSecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;

            binding.SendTimeout = new TimeSpan(0, 15, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 15, 0);
            binding.OpenTimeout = new TimeSpan(0, 1, 0);
            binding.CloseTimeout = new TimeSpan(0, 1, 0);

            binding.ReaderQuotas.MaxStringContentLength = 2147483647;

            return binding;
        }
        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding binding = new NetTcpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.Security.Mode = SecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;

            binding.SendTimeout = new TimeSpan(0, 15, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 15, 0);
            binding.OpenTimeout = new TimeSpan(0, 1, 0);
            binding.CloseTimeout = new TimeSpan(0, 1, 0);
            
            binding.ReaderQuotas.MaxStringContentLength = 2147483647;
            return binding;
        }

        public void Dispose()
        {
            ((IClientChannel)MyChannel).Close();
            MyFactory.Close();
        }

        public SvcReturn ExecNonQuery(MyCommand[] cmds)
        {
            return MyChannel.ExecNonQuery(cmds);
        }

        public SvcReturn GetDataSetXml(MyCommand cmd)
        {
            return MyChannel.GetDataSetXml(cmd);
        }
    }
}
