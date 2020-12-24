namespace SimpleMessenger
{
    partial class Messenger
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_ChatLog = new System.Windows.Forms.TextBox();
            this.TextBox_SendMessage = new System.Windows.Forms.TextBox();
            this.Label_ChooseClient = new System.Windows.Forms.Label();
            this.Radio_A = new System.Windows.Forms.RadioButton();
            this.Radio_B = new System.Windows.Forms.RadioButton();
            this.Button_Connection = new System.Windows.Forms.Button();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Label_Success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_ChatLog
            // 
            this.TextBox_ChatLog.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_ChatLog.Location = new System.Drawing.Point(12, 92);
            this.TextBox_ChatLog.Multiline = true;
            this.TextBox_ChatLog.Name = "TextBox_ChatLog";
            this.TextBox_ChatLog.ReadOnly = true;
            this.TextBox_ChatLog.Size = new System.Drawing.Size(869, 324);
            this.TextBox_ChatLog.TabIndex = 0;
            // 
            // TextBox_SendMessage
            // 
            this.TextBox_SendMessage.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_SendMessage.Location = new System.Drawing.Point(12, 422);
            this.TextBox_SendMessage.Multiline = true;
            this.TextBox_SendMessage.Name = "TextBox_SendMessage";
            this.TextBox_SendMessage.Size = new System.Drawing.Size(735, 59);
            this.TextBox_SendMessage.TabIndex = 1;
            // 
            // Label_ChooseClient
            // 
            this.Label_ChooseClient.AutoSize = true;
            this.Label_ChooseClient.Font = new System.Drawing.Font("D2Coding", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ChooseClient.Location = new System.Drawing.Point(423, 38);
            this.Label_ChooseClient.Name = "Label_ChooseClient";
            this.Label_ChooseClient.Size = new System.Drawing.Size(280, 22);
            this.Label_ChooseClient.TabIndex = 2;
            this.Label_ChooseClient.Text = "접속할 클라이언트를 선택하세요";
            // 
            // Radio_A
            // 
            this.Radio_A.AutoSize = true;
            this.Radio_A.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Radio_A.Location = new System.Drawing.Point(709, 21);
            this.Radio_A.Name = "Radio_A";
            this.Radio_A.Size = new System.Drawing.Size(38, 23);
            this.Radio_A.TabIndex = 3;
            this.Radio_A.TabStop = true;
            this.Radio_A.Text = "A";
            this.Radio_A.UseVisualStyleBackColor = true;
            // 
            // Radio_B
            // 
            this.Radio_B.AutoSize = true;
            this.Radio_B.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Radio_B.Location = new System.Drawing.Point(709, 50);
            this.Radio_B.Name = "Radio_B";
            this.Radio_B.Size = new System.Drawing.Size(38, 23);
            this.Radio_B.TabIndex = 4;
            this.Radio_B.TabStop = true;
            this.Radio_B.Text = "B";
            this.Radio_B.UseVisualStyleBackColor = true;
            // 
            // Button_Connection
            // 
            this.Button_Connection.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Connection.Location = new System.Drawing.Point(753, 21);
            this.Button_Connection.Name = "Button_Connection";
            this.Button_Connection.Size = new System.Drawing.Size(128, 52);
            this.Button_Connection.TabIndex = 5;
            this.Button_Connection.Text = "접속";
            this.Button_Connection.UseVisualStyleBackColor = true;
            this.Button_Connection.Click += new System.EventHandler(this.Button_Connection_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Send.Location = new System.Drawing.Point(771, 422);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(110, 60);
            this.Button_Send.TabIndex = 6;
            this.Button_Send.Text = "전송";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Label_Success
            // 
            this.Label_Success.AutoSize = true;
            this.Label_Success.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Success.Location = new System.Drawing.Point(327, 36);
            this.Label_Success.Name = "Label_Success";
            this.Label_Success.Size = new System.Drawing.Size(100, 23);
            this.Label_Success.TabIndex = 7;
            this.Label_Success.Text = "접속 성공";
            this.Label_Success.Visible = false;
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 494);
            this.Controls.Add(this.Label_Success);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Button_Connection);
            this.Controls.Add(this.Radio_B);
            this.Controls.Add(this.Radio_A);
            this.Controls.Add(this.Label_ChooseClient);
            this.Controls.Add(this.TextBox_SendMessage);
            this.Controls.Add(this.TextBox_ChatLog);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Messenger";
            this.Text = "Simple Messenger";
            this.Load += new System.EventHandler(this.Messenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ChatLog;
        private System.Windows.Forms.TextBox TextBox_SendMessage;
        private System.Windows.Forms.Label Label_ChooseClient;
        private System.Windows.Forms.RadioButton Radio_A;
        private System.Windows.Forms.RadioButton Radio_B;
        private System.Windows.Forms.Button Button_Connection;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Label Label_Success;
    }
}

