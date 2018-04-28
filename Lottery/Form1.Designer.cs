namespace Lottery
{
    partial class FormPrize
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrize));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInitPool = new System.Windows.Forms.Button();
            this.btnCheckRepeat = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmbPrize = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoftUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_RunFun);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::Lottery.Properties.Resources.cj;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(565, 576);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInitPool
            // 
            this.btnInitPool.BackColor = System.Drawing.Color.Transparent;
            this.btnInitPool.BackgroundImage = global::Lottery.Properties.Resources.csh;
            this.btnInitPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInitPool.FlatAppearance.BorderSize = 0;
            this.btnInitPool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInitPool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInitPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitPool.Location = new System.Drawing.Point(354, 576);
            this.btnInitPool.Name = "btnInitPool";
            this.btnInitPool.Size = new System.Drawing.Size(75, 30);
            this.btnInitPool.TabIndex = 0;
            this.btnInitPool.UseVisualStyleBackColor = false;
            this.btnInitPool.Click += new System.EventHandler(this.btnInitPool_Click);
            // 
            // btnCheckRepeat
            // 
            this.btnCheckRepeat.BackgroundImage = global::Lottery.Properties.Resources.cmyz;
            this.btnCheckRepeat.FlatAppearance.BorderSize = 0;
            this.btnCheckRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheckRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheckRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckRepeat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCheckRepeat.Location = new System.Drawing.Point(462, 576);
            this.btnCheckRepeat.Name = "btnCheckRepeat";
            this.btnCheckRepeat.Size = new System.Drawing.Size(70, 30);
            this.btnCheckRepeat.TabIndex = 1;
            this.btnCheckRepeat.UseVisualStyleBackColor = true;
            this.btnCheckRepeat.Click += new System.EventHandler(this.btnCheckRepeat_Click);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl5.Location = new System.Drawing.Point(327, 329);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(235, 20);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "张小刚";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(327, 401);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(235, 20);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "守卫pureworld的石狮子";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4.Location = new System.Drawing.Point(327, 365);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(235, 20);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "李世民";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.Location = new System.Drawing.Point(327, 437);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(235, 20);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "李振国";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(327, 473);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(235, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "王晓宇";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPrize
            // 
            this.cmbPrize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrize.Font = new System.Drawing.Font("宋体", 9F);
            this.cmbPrize.FormattingEnabled = true;
            this.cmbPrize.ItemHeight = 12;
            this.cmbPrize.Items.AddRange(new object[] {
            "特等奖",
            "一等奖",
            "二等奖",
            "三等奖",
            "四等奖",
            "五等奖",
            "纪念奖"});
            this.cmbPrize.Location = new System.Drawing.Point(196, 580);
            this.cmbPrize.Name = "cmbPrize";
            this.cmbPrize.Size = new System.Drawing.Size(125, 20);
            this.cmbPrize.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Lottery.Properties.Resources.Menubg;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDoc,
            this.toolStripMenuItemSoftUpdate,
            this.toolStripMenuItemAuthor});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemHelp.Text = "帮助";
            // 
            // toolStripMenuItemDoc
            // 
            this.toolStripMenuItemDoc.Name = "toolStripMenuItemDoc";
            this.toolStripMenuItemDoc.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemDoc.Text = "使用说明";
            this.toolStripMenuItemDoc.Click += new System.EventHandler(this.toolStripMenuItemDoc_Click);
            // 
            // toolStripMenuItemSoftUpdate
            // 
            this.toolStripMenuItemSoftUpdate.Name = "toolStripMenuItemSoftUpdate";
            this.toolStripMenuItemSoftUpdate.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSoftUpdate.Text = "检查更新";
            this.toolStripMenuItemSoftUpdate.Click += new System.EventHandler(this.toolStripMenuItemSoftUpdate_Click);
            // 
            // toolStripMenuItemAuthor
            // 
            this.toolStripMenuItemAuthor.Name = "toolStripMenuItemAuthor";
            this.toolStripMenuItemAuthor.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemAuthor.Text = "联系作者";
            this.toolStripMenuItemAuthor.Click += new System.EventHandler(this.toolStripMenuItemAuthor_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(87, 73);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(750, 50);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "恭喜 守卫pureworld的石狮子 获得一等奖！";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // lblWait
            // 
            this.lblWait.BackColor = System.Drawing.Color.Transparent;
            this.lblWait.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWait.ForeColor = System.Drawing.Color.Black;
            this.lblWait.Location = new System.Drawing.Point(67, 23);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(750, 50);
            this.lblWait.TabIndex = 0;
            this.lblWait.Text = "正在抽奖，请稍后";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Lottery.Properties.Resources.tz;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(668, 576);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormPrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Lottery.Properties.Resources._0;
            this.ClientSize = new System.Drawing.Size(879, 611);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.cmbPrize);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCheckRepeat);
            this.Controls.Add(this.btnInitPool);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(895, 650);
            this.MinimumSize = new System.Drawing.Size(895, 650);
            this.Name = "FormPrize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "女流见面会抽奖程序";
            this.Load += new System.EventHandler(this.FormPrize_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnInitPool;
        private System.Windows.Forms.Button btnCheckRepeat;
        private System.Windows.Forms.ComboBox cmbPrize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDoc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoftUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAuthor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWait;
    }
}

