namespace Heap_Sort
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHeap = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCreat = new System.Windows.Forms.Button();
            this.txtSorted = new System.Windows.Forms.RichTextBox();
            this.txtOriginated = new System.Windows.Forms.RichTextBox();
            this.lblOriginated = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblHand = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnHand = new System.Windows.Forms.Button();
            this.txtRnd = new System.Windows.Forms.TextBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.RichTextBox();
            this.form = new System.Windows.Forms.Form();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnHeap);
            this.splitContainer1.Panel1.Controls.Add(this.btnEnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnPause);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSorted);
            this.splitContainer1.Panel2.Controls.Add(this.txtOriginated);
            this.splitContainer1.Panel2.Controls.Add(this.lblOriginated);
            this.splitContainer1.Panel2.Controls.Add(this.lblSorted);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.lblHand);
            this.splitContainer1.Panel2.Controls.Add(this.btnAuto);
            this.splitContainer1.Panel2.Controls.Add(this.btnHand);
            this.splitContainer1.Panel2.Controls.Add(this.txtRnd);
            this.splitContainer1.Panel2.Controls.Add(this.lblAuto);
            this.splitContainer1.Panel2.Controls.Add(this.txtNum);
            this.splitContainer1.Size = new System.Drawing.Size(1474, 1129);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHeap
            // 
            this.btnHeap.Enabled = false;
            this.btnHeap.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHeap.Location = new System.Drawing.Point(52, 259);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(165, 70);
            this.btnHeap.TabIndex = 4;
            this.btnHeap.Text = "创建堆";
            this.btnHeap.UseVisualStyleBackColor = true;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnd.Location = new System.Drawing.Point(52, 695);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(165, 70);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "结束排序";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.Location = new System.Drawing.Point(52, 548);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(165, 70);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停/继续";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(52, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始排序";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCreat
            // 
            this.btnCreat.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreat.Location = new System.Drawing.Point(52, 132);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(165, 70);
            this.btnCreat.TabIndex = 0;
            this.btnCreat.Text = "创建数据";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // txtSorted
            // 
            this.txtSorted.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorted.Location = new System.Drawing.Point(17, 488);
            this.txtSorted.Name = "txtSorted";
            this.txtSorted.ReadOnly = true;
            this.txtSorted.Size = new System.Drawing.Size(1066, 372);
            this.txtSorted.TabIndex = 12;
            this.txtSorted.Text = "";
            this.txtSorted.Visible = false;
            // 
            // txtOriginated
            // 
            this.txtOriginated.EnableAutoDragDrop = true;
            this.txtOriginated.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginated.Location = new System.Drawing.Point(17, 81);
            this.txtOriginated.Name = "txtOriginated";
            this.txtOriginated.ReadOnly = true;
            this.txtOriginated.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOriginated.Size = new System.Drawing.Size(1066, 333);
            this.txtOriginated.TabIndex = 11;
            this.txtOriginated.Text = "";
            this.txtOriginated.Visible = false;
            // 
            // lblOriginated
            // 
            this.lblOriginated.AutoSize = true;
            this.lblOriginated.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginated.Location = new System.Drawing.Point(10, 27);
            this.lblOriginated.Name = "lblOriginated";
            this.lblOriginated.Size = new System.Drawing.Size(359, 37);
            this.lblOriginated.TabIndex = 10;
            this.lblOriginated.Text = "排序前的序列如下：";
            this.lblOriginated.Visible = false;
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSorted.Location = new System.Drawing.Point(3, 433);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(359, 37);
            this.lblSorted.TabIndex = 9;
            this.lblSorted.Text = "排好序的序列如下：";
            this.lblSorted.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(746, 647);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 75);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(231, 647);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 75);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHand.Location = new System.Drawing.Point(65, 211);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(466, 41);
            this.lblHand.TabIndex = 3;
            this.lblHand.Text = "请在下列文本框中输入新数据：";
            this.lblHand.Visible = false;
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(729, 400);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(186, 70);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "随机创建";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Visible = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnHand
            // 
            this.btnHand.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHand.Location = new System.Drawing.Point(217, 400);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(186, 70);
            this.btnHand.TabIndex = 0;
            this.btnHand.Text = "手动创建";
            this.btnHand.UseVisualStyleBackColor = true;
            this.btnHand.Visible = false;
            this.btnHand.Click += new System.EventHandler(this.btnHand_Click);
            // 
            // txtRnd
            // 
            this.txtRnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRnd.Location = new System.Drawing.Point(217, 420);
            this.txtRnd.Name = "txtRnd";
            this.txtRnd.Size = new System.Drawing.Size(737, 50);
            this.txtRnd.TabIndex = 7;
            this.txtRnd.Visible = false;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(210, 356);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(744, 41);
            this.lblAuto.TabIndex = 6;
            this.lblAuto.Text = "请输入随机生成的数据个数(输入？表示随机生成)：";
            this.lblAuto.Visible = false;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(72, 255);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(984, 327);
            this.txtNum.TabIndex = 2;
            this.txtNum.Text = "";
            this.txtNum.Visible = false;
            // 
            // form
            // 
            this.form.ClientSize = new System.Drawing.Size(1100, 600);
            this.form.Location = new System.Drawing.Point(600, 600);
            this.form.Name = "form";
            this.form.Visible = false;
            this.form.Paint += Form_Paint;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1129);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Heap&&Sort";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnHand;
        private System.Windows.Forms.TextBox txtRnd;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.RichTextBox txtNum;
        private System.Windows.Forms.Form form;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.RichTextBox txtSorted;
        private System.Windows.Forms.RichTextBox txtOriginated;
        private System.Windows.Forms.Label lblOriginated;
    }
}

