namespace Practice1
{
    partial class Form1
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
            this.lbl_show = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(20, 22);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(45, 15);
            this.lbl_show.TabIndex = 0;
            this.lbl_show.Text = "label1";
            this.lbl_show.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 68);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(198, 134);
            this.txt.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(239, 89);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(126, 103);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Send";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 269);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl_show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn_show;
    }
}

