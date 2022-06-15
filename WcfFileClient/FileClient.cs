﻿using BBS;
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

    public class FileClient:IDisposable
    {

        //private EndpointAddress address_http = new EndpointAddress("http://20.227.136.125:9210/FileService");
        //private EndpointAddress address_tcp = new EndpointAddress("net.tcp://20.227.136.125:9210/FileService");
        private EndpointAddress address_http = new EndpointAddress("http://172.20.105.36:9210/FileService");
        private EndpointAddress address_tcp = new EndpointAddress("net.tcp://172.20.105.36:9220/FileService");


        private ChannelFactory<IFileService> MyFactory { get; set; }
        private IFileService MyChannel { get; set; }

        public FileClient(MyBindinEnum myBindin)
        {
            if (myBindin == MyBindinEnum.Http)
            {
                BasicHttpBinding binding = GetHttpBinding();
                MyFactory = new ChannelFactory<IFileService>(binding, address_http);
            }
            else if (myBindin == MyBindinEnum.NetTcp)
            {
                NetTcpBinding binding = GetNetTcpBinding();
                MyFactory = new ChannelFactory<IFileService>(binding, address_tcp);
            }
            MyChannel = MyFactory.CreateChannel();
        }
        public CheckFileResponse SeverCheckFile(string fileName)
        {
            return MyChannel.CheckFile(fileName);
        }

        public void UploadFile(FileData uploadFile)
        {
            try
            {
                MyChannel.UploadFile(uploadFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
   

        public FileData DownloadFile(DownloadRequest request)
        {
            try
            {
                return MyChannel.DownloadFile(request);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private BasicHttpBinding GetHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            binding.TransferMode = TransferMode.Streamed;
            //binding.MessageEncoding = WSMessageEncoding.Mtom;
            binding.Security.Mode = BasicHttpSecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;

            binding.OpenTimeout = TimeSpan.FromMinutes(5);
            binding.CloseTimeout = TimeSpan.FromMinutes(5);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(15);
            binding.SendTimeout = TimeSpan.FromMinutes(15);

            return binding;
        }
        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding binding = new NetTcpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.Security.Mode =  SecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;

            binding.SendTimeout = new TimeSpan(0, 15, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 15, 0);
            binding.OpenTimeout = new TimeSpan(0, 1, 0);
            binding.CloseTimeout = new TimeSpan(0, 1, 0);

            return binding;
        }

        public void Dispose()
        {
            ((IClientChannel)MyChannel).Close();
            MyFactory.Close();
        }
    }
}
