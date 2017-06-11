namespace Calendar
{
    partial class Calendar
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_caption = new System.Windows.Forms.Panel();
            this.label_year = new System.Windows.Forms.Label();
            this.label_caption = new System.Windows.Forms.Label();
            this.panel_day = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_caption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel_caption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_day, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel_caption
            // 
            this.panel_caption.Controls.Add(this.label_year);
            this.panel_caption.Controls.Add(this.label_caption);
            resources.ApplyResources(this.panel_caption, "panel_caption");
            this.panel_caption.Name = "panel_caption";
            // 
            // label_year
            // 
            resources.ApplyResources(this.label_year, "label_year");
            this.label_year.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_year.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_year.Name = "label_year";
            // 
            // label_caption
            // 
            this.label_caption.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.label_caption, "label_caption");
            this.label_caption.Name = "label_caption";
            // 
            // panel_day
            // 
            resources.ApplyResources(this.panel_day, "panel_day");
            this.panel_day.Name = "panel_day";
            // 
            // Calendar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calendar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_caption.ResumeLayout(false);
            this.panel_caption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_caption;
        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Panel panel_day;
        private System.Windows.Forms.Label label_year;
    }
}
