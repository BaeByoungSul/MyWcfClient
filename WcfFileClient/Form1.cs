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
 
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "All files (*.*)|All files (*.*)|*.dll|*.*";
//                openFileDialog.Filter = "dll files (*.dll)|*.dll|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                //openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    txt_t1_1.Text = filePath;

                }
            }
        }

        /// <summary>
        /// Upload
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
                FileData uploadFileData = new FileData();
                
                // file 명, Length
                FileInfo sfi = new FileInfo(txt_t1_1.Text.Trim());
                uploadFileData.FileName = sfi.Name;
                //uploadFileData.FileLength = sfi.Length;

                FileClient _cli; //= new FileClient();
                if (cbo_t1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }
               
                using (var sourceStream = File.OpenRead(sfi.FullName))
                {
                    CustomStream customStream = new CustomStream(sourceStream, sfi.Length);
                    customStream.ProgressChanged += CustomStream_ProgressChanged; ;

                    uploadFileData.Stream = customStream;
                    _cli.UploadFile(uploadFileData);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            //try
            //{
            //    //BasicHttpBinding binding = new BasicHttpBinding();
            //    NetTcpBinding binding = new NetTcpBinding();

            //    binding.TransferMode = TransferMode.Streamed;
            //    //binding.MessageEncoding = WSMessageEncoding.Mtom;
            //    binding.Security.Mode = SecurityMode.None;

            //    binding.MaxReceivedMessageSize = 2147483647;

            //    binding.SendTimeout = new TimeSpan(0, 15, 0);
            //    binding.ReceiveTimeout = new TimeSpan(0, 15, 0);
            //    binding.OpenTimeout = new TimeSpan(0, 1, 0);
            //    binding.CloseTimeout = new TimeSpan(0, 1, 0);




            //    EndpointAddress address = new EndpointAddress("net.tcp://20.227.136.125:9140/FileService");
            //    //EndpointAddress address = new EndpointAddress("http://20.227.136.125:7890/");
                
                
            //    ChannelFactory<IFileService> factory =
            //        new ChannelFactory<IFileService>(binding, address);

            //    IFileService channel = factory.CreateChannel();

            //    FileData uploadFileData = new FileData();
                
            //    FileInfo sfi = new FileInfo(txt_t1_1.Text);

            //    using (var sourceStream = File.OpenRead(sfi.FullName))
            //    {
            //        CustomStream customStream = new CustomStream(sourceStream, sfi.Length);
            //        customStream.ProgressChanged += CustomStream_ProgressChanged; ;

            //        uploadFileData.FileName = sfi.Name;
            //        uploadFileData.Stream = customStream;

            //        channel.UploadFile(uploadFileData);

            //    }

            //    //var sourceStream = File.OpenRead(sfi.FullName);


            //    ((IClientChannel)channel).Close();
            //    factory.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
                
            //}
            
        }

        private void CustomStream_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;

            this.progBar_t1.Value = (int)value;

        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            string targetFilePath = Path.Combine(@"d:\", txtFileName_t1.Text);

            try
            {
                
                if (cbo_t1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // file 명, Length

                FileClient _cli; //= new FileClient();
                if (cbo_t1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                using (FileData filedata = _cli.DownloadFile(new DownloadRequest { FileName = txtFileName_t1.Text }))
                {
                    CustomStream customStream = new CustomStream(filedata.Stream, filedata.FileLength);
                    customStream.ProgressChanged += Download_ProgressChanged1;

                    // file이 있어면 삭제
                    if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

                    // Target filestream 생성
                    FileStream targetStream = File.Create(targetFilePath);
                    customStream.CopyTo(targetStream);

                    targetStream.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            //           try
            //           {
            //               string targetFilePath = Path.Combine(@"d:\", txtFileName_t1.Text);

            ////               BasicHttpBinding binding = new BasicHttpBinding();

            //               NetTcpBinding binding = new NetTcpBinding();
            //               binding.TransferMode = TransferMode.Streamed;
            //               // binding.MessageEncoding = WSMessageEncoding.Mtom;

            //               binding.Security.Mode = SecurityMode.None;

            //               binding.MaxBufferSize = 65536;
            //               binding.MaxBufferPoolSize = 524288;
            //               binding.MaxReceivedMessageSize = 2147483647;





            //               //EndpointAddress address = new EndpointAddress("http://20.227.136.125:7890/");
            //               EndpointAddress address = new EndpointAddress("net.tcp://20.227.136.125:9140/FileService");

            //               ChannelFactory<IFileService> factory =
            //                   new ChannelFactory<IFileService>(binding, address);

            //               IFileService channel = factory.CreateChannel();

            //               using(FileData filedata = channel.DownloadFile( new DownloadRequest { FileName= txtFileName_t1.Text }))
            //               {
            //                   CustomStream customStream = new CustomStream(filedata.Stream, filedata.FileLength);
            //                   customStream.ProgressChanged += Download_ProgressChanged1;


            //                   // file이 있어면 삭제
            //                   if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

            //                   // Target filestream 생성
            //                   FileStream targetStream = File.Create(targetFilePath);
            //                   customStream.CopyTo(targetStream);

            //                   targetStream.Close();
            //               }
            //               //Stream stream=  channel.DownloadFile(txtFileName.Text);

            //               //CustomStream customStream = new CustomStream(stream, stream.Length);
            //               //customStream.ProgressChanged += Download_ProgressChanged1;

            //               //string targetFilePath = Path.Combine(@"d:\", txtFileName.Text);
            //               //FileStream targetStream = File.Create(targetFilePath);

            //               //customStream.CopyTo(targetStream);
            //               //targetStream.Close();


            //               ((IClientChannel)channel).Close();
            //               factory.Close();
            //           }
            //           catch (Exception ex)
            //           {
            //               Console.WriteLine(ex.Message);

            //           }
        }

        private void Download_ProgressChanged1(object sender, ProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;

            this.progBar_t1.Value = (int)value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
