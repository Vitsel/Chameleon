﻿
namespace AuthClient.tollgate.home.main.dialog
{
    partial class SidebarHistory
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.img_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 15);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 12);
            this.label.TabIndex = 4;
            this.label.Text = "인증 내역";
            // 
            // img_icon
            // 
            this.img_icon.Image = global::AuthClient.Properties.Resources.mainSideHistoryOn;
            this.img_icon.Location = new System.Drawing.Point(20, 15);
            this.img_icon.Margin = new System.Windows.Forms.Padding(0);
            this.img_icon.Name = "img_icon";
            this.img_icon.Size = new System.Drawing.Size(14, 12);
            this.img_icon.TabIndex = 3;
            this.img_icon.TabStop = false;
            // 
            // SidebarHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::AuthClient.Properties.Resources.mainSideBg;
            this.Controls.Add(this.label);
            this.Controls.Add(this.img_icon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SidebarHistory";
            this.Size = new System.Drawing.Size(182, 42);
            ((System.ComponentModel.ISupportInitialize)(this.img_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox img_icon;
    }
}
