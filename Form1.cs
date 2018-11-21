using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Heap_Sort
{
    public partial class Form1 : Form
    {
        //窗体的初始化
        public Form1()
        {
            H.Add(0);
            InitializeComponent();
        }

        static List<double> H = new List<double>();     //存放数据的堆序列
        static int shownum;                             //堆显示的元素个数
        static bool Pause = false;                      //程序暂停的标志
        static bool End = false;                        //程序结束的标志
        Thread thread;                                  //画图的线程

        //画图的窗体显示
        private void FormShow()
        {
            ///建立新的窗体
            {
                form = new System.Windows.Forms.Form();
                this.form.ClientSize = new System.Drawing.Size(1100, 600);
                this.form.Location = new System.Drawing.Point(600, 600);
                this.form.Name = "form";
                this.form.Visible = false;
                this.form.Paint += Form_Paint;
            }
            form.Show();                                //显示新创建的窗体
        }

        //堆排序，调用Heap类的相关函数，完成相应的功能
        private void Sort()
        {
            FormShow();
            Heap.HeapInit(H);                          //初始化堆
            shownum = H.Count;
            form.Refresh();                            //刷新堆的图形化显示
            Thread.Sleep(2000);
            ShowSortedList sl = new ShowSortedList(ShowSorted);
            for (int i = H.Count - 1; i > 0; --i)       //对数据进行堆排序
            {
                Heap.HeapSort(H, i);
                this.txtSorted.Invoke(sl, i, H.Count);
                if (!End)
                {
                    shownum = i;
                    form.Refresh();
                    Thread.Sleep(2000);
                }
            }
            End = true;
            this.txtSorted.Invoke(sl, 0, H.Count);
            form.Dispose();
            setButtonEn sbe = new setButtonEn(set);
            this.btnPause.Invoke(sbe);
        }

        //委托函数，在子窗体画图的线程中对主窗体中的控件进行操作
        private delegate void setButtonEn();

        //对按钮的可用性进行设置，提高程序的容错能力
        private void set()
        {
            this.btnPause.Enabled = false;
            this.btnEnd.Enabled = false;
            this.btnHeap.Enabled = true;
        }

        //委托函数，在画图的线程中在主窗体中显示已排序的元素
        private delegate void ShowSortedList(int s, int e);

        //显示已排序的数据
        private void ShowSorted(int s,int e)
        {
            string str = ShowList(s, e);
            txtSorted.Text = str;
        }

        //开始排序，相应用户点击开始排序按钮的函数，对输入数据进行排序
        private void btnStart_Click(object sender, EventArgs e)
        {
            Pause = false;End = false;
            btnStart.Enabled = false;
            btnHeap.Enabled = false;
            btnPause.Enabled = true;
            btnEnd.Enabled = true;
            thread = new Thread(() => Sort());
            thread.Start();
        }

        //创建数据，响应用户点击创建数据按钮的函数，显示输入界面，由用户或随机创建新的数据
        private void btnCreat_Click(object sender, EventArgs e)
        {
            this.btnHand.Visible = true;
            this.btnAuto.Visible = true;
            this.lblOriginated.Visible = false;
            this.lblSorted.Visible = false;
            this.txtOriginated.Visible = false;
            this.txtSorted.Visible = false;
            if (thread != null && thread.IsAlive)
            {
                End = true;
            }
            setButtonEnabled(false);
        }

        //创建初始堆，响应用户点击创建初始堆按钮的函数，根据原始数据完成堆的初始化
        private void btnHeap_Click(object sender, EventArgs e)
        {
            FormShow();
            if(!End) Heap.HeapInit(H);
            shownum = H.Count;
            form.Refresh();
        }

        //窗体绘图事件
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            PaintH.PaintHeap(e.Graphics, H, shownum);
        }

        //暂停排序，通过线程函数暂停当前的堆排序
        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause = !Pause;
            if (Pause) thread.Suspend();
            else thread.Resume();
        }

        //结束排序
        private void btnEnd_Click(object sender, EventArgs e)
        {
            End = true;
            ThreadState state = thread.ThreadState;
            if (state == ThreadState.Suspended) thread.Resume();
        }

        //手动创建数据
        private void btnHand_Click(object sender, EventArgs e)
        {
            this.lblHand.Visible = true;
            this.txtNum.Visible = true;
            this.txtNum.Text = "";
            this.btnOK.Visible = true;
            this.btnCancel.Visible = true;
            this.btnHand.Visible = false;
            this.btnAuto.Visible = false;
        }

        //随机生成数据
        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.lblAuto.Visible = true;
            this.txtRnd.Visible = true;
            this.txtRnd.Text = "";
            this.btnOK.Visible = true;
            this.btnCancel.Visible = true;
            this.btnHand.Visible = false;
            this.btnAuto.Visible = false;
        }

        //生成数据时进行取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            setComponent();
        }

        //生成数据时进行确认
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNum.Visible)
            {
                string s = txtNum.Text;
                H = Create_Num.CreateNumByHand(s);
            }
            else
            {
                string s = txtRnd.Text;
                H = Create_Num.CreateNumByRnd(s);
            }
            if (H.Count == 0)
            {
                MessageBox.Show("请输入数据！");
            }
            else
            {
                setComponent();
                lblOriginated.Visible = true;
                txtOriginated.Visible = true;
                lblSorted.Visible = true;
                txtSorted.Visible = true;
                string str = ShowList(0, H.Count);
                txtOriginated.Text = str;
                txtSorted.Text = "";
            }
        }

        private void setComponent()
        {
            this.btnOK.Visible = false;
            this.btnCancel.Visible = false;
            this.lblHand.Visible = this.lblAuto.Visible = false;
            this.txtNum.Visible = this.txtRnd.Visible = false;
            setButtonEnabled(true);
        }

        private void setButtonEnabled(bool flag)
        {
            this.btnCreat.Enabled = flag;
            this.btnHeap.Enabled = flag;
            this.btnStart.Enabled = flag;
            this.btnPause.Enabled = false;
            this.btnEnd.Enabled = false;
        }

        //显示列表List的s到e的所有数据，用于显示原始数据和已排好序的数据
        private string ShowList(int s,int e)
        {
            string str = "";
            int count = 0;
            for(int i = s;i< e; i++)
            {
                str += H[i].ToString() + "  ";
                count++;
                if (count % 7 == 0) str += "\n";
            }
            return str;
        }
    }
}
