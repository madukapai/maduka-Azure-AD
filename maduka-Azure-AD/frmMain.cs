using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureAD;
using AzureAD.Models;

namespace maduka_Azure_AD
{
    public partial class frmMain : Form
    {
        User.Result objResult;
        AzureADUtility objAAD;

        public frmMain()
        {
            InitializeComponent();
            objAAD = new AzureADUtility(txtTenant.Text, txtClientId.Text, txtSecret.Text);
        }

        private void btnGetAADUsers_Click(object sender, EventArgs e)
        {
            objResult = objAAD.GetUsers();
            gvUsers.DataSource = objResult.value;
        }

        private void btnGetManager_Click(object sender, EventArgs e)
        {
            // 取出該帳號的ObjectId, 並透過GraphAPI取得主管的資訊
            for (int i = 0; i < objResult.value.Length; i++)
            {
                string strObjectId = objResult.value[i].objectId.ToString();

                // 呼叫GraphAPI，取得主管的資訊
                User.Manager objManager = objAAD.GetManager(strObjectId);

                if (objManager != null)
                {
                    // 取代回傳的Url，並取出主管的ObjectId
                    string strManagerObjectId = objManager.url.Replace("https://graph.windows.net/" + txtTenant.Text + "/directoryObjects/", "");
                    strManagerObjectId = strManagerObjectId.Replace("/Microsoft.DirectoryServices.User", "");

                    // 找出主管的資料
                    User.Value objUser = objResult.value.FirstOrDefault(x => x.objectId == strManagerObjectId);

                    // 重新放入欄位
                    objResult.value[i].ManagerUri = objManager.url;
                    objResult.value[i].ManagerObjectId = strManagerObjectId;
                    objResult.value[i].Manager = objUser.displayName;
                }
            }

            gvUsers.DataSource = objResult.value;
        }
    }
}