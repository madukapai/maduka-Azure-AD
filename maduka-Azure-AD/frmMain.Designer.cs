namespace maduka_Azure_AD
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenant = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblSecret = new System.Windows.Forms.Label();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.btnGetAADUsers = new System.Windows.Forms.Button();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.btnGetManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenant
            // 
            this.lblTenant.AutoSize = true;
            this.lblTenant.Location = new System.Drawing.Point(29, 15);
            this.lblTenant.Name = "lblTenant";
            this.lblTenant.Size = new System.Drawing.Size(72, 24);
            this.lblTenant.TabIndex = 0;
            this.lblTenant.Text = "Tenant";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(12, 57);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(89, 24);
            this.lblClientId.TabIndex = 1;
            this.lblClientId.Text = "Client Id";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(34, 99);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(67, 24);
            this.lblSecret.TabIndex = 2;
            this.lblSecret.Text = "Secret";
            // 
            // txtTenant
            // 
            this.txtTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenant.Location = new System.Drawing.Point(107, 12);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(811, 36);
            this.txtTenant.TabIndex = 3;
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(107, 54);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(811, 36);
            this.txtClientId.TabIndex = 3;
            // 
            // txtSecret
            // 
            this.txtSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecret.Location = new System.Drawing.Point(107, 96);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(811, 36);
            this.txtSecret.TabIndex = 3;
            // 
            // btnGetAADUsers
            // 
            this.btnGetAADUsers.Location = new System.Drawing.Point(107, 138);
            this.btnGetAADUsers.Name = "btnGetAADUsers";
            this.btnGetAADUsers.Size = new System.Drawing.Size(185, 36);
            this.btnGetAADUsers.TabIndex = 4;
            this.btnGetAADUsers.Text = "Get AAD Users";
            this.btnGetAADUsers.UseVisualStyleBackColor = true;
            this.btnGetAADUsers.Click += new System.EventHandler(this.btnGetAADUsers_Click);
            // 
            // gvUsers
            // 
            this.gvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(107, 180);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.RowTemplate.Height = 38;
            this.gvUsers.Size = new System.Drawing.Size(811, 454);
            this.gvUsers.TabIndex = 5;
            // 
            // btnGetManager
            // 
            this.btnGetManager.Location = new System.Drawing.Point(298, 138);
            this.btnGetManager.Name = "btnGetManager";
            this.btnGetManager.Size = new System.Drawing.Size(225, 36);
            this.btnGetManager.TabIndex = 6;
            this.btnGetManager.Text = "Get Users Manager";
            this.btnGetManager.UseVisualStyleBackColor = true;
            this.btnGetManager.Click += new System.EventHandler(this.btnGetManager_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 646);
            this.Controls.Add(this.btnGetManager);
            this.Controls.Add(this.gvUsers);
            this.Controls.Add(this.btnGetAADUsers);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtTenant);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.lblTenant);
            this.Name = "frmMain";
            this.Text = "Azure AD Users Info";
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenant;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Button btnGetAADUsers;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Button btnGetManager;
    }
}

