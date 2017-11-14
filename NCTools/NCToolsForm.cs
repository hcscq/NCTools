using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCDataMatch;
using NCDataUpdate;
using System.Net;
using System.Net.Sockets;
namespace NCTools
{
    public partial class NCToolsForm : Form
    {
        private NCDataMatchForm DataMatchForm=null;
        private ETLUpdateTaxRateForm UpdateTaxRateForm=null;
        private Socket serverSocket;
        public NCToolsForm()
        {
            InitializeComponent();
            
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top|AnchorStyles.Bottom;
            btn_dataMatch.Anchor=  AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            btn_updateTaxRate.Anchor= AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right ; 

        }

        private void btn_dataMatch_Click(object sender, EventArgs e)
        {
            if (DataMatchForm == null || DataMatchForm.IsDisposed)
            {
                DataMatchForm = new NCDataMatchForm("DATA SOURCE=172.16.1.108:1521/NCDATA;PERSIST SECURITY INFO=True;USER ID=NC65;PASSWORD=NC65");
                DataMatchForm.Show();
            }
            else DataMatchForm.Focus();
        }

        private void btn_updateTaxRate_Click(object sender, EventArgs e)
        {
            if (UpdateTaxRateForm == null|| UpdateTaxRateForm.IsDisposed)
            {
                UpdateTaxRateForm =new ETLUpdateTaxRateForm("DATA SOURCE=172.16.1.109:1521/orcl;PASSWORD=di;PERSIST SECURITY INFO=True;POOLING=False;USER ID=DI");
                UpdateTaxRateForm.Show();
            }
            else UpdateTaxRateForm.Focus();
        }
        private void GetConnectionString(string key="",string ipAddr="",string port="")
        {
            //IPEndPoint serverInfo = new IPEndPoint(IPAddress.Parse(ipAddr), int.Parse(port));
            Socket serverSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            SocketAsyncEventArgs socketAsyncEventArgs=new SocketAsyncEventArgs();
            socketAsyncEventArgs.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAddr), int.Parse(port));
            socketAsyncEventArgs.Completed += SocketAsyncEventArgs_Completed;

            serverSocket.ConnectAsync(socketAsyncEventArgs);
            


        }

        private void SocketAsyncEventArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
