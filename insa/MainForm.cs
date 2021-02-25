using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace insa
{

    public partial class MainForm : Form
    {

        private Point _imageLocation = new Point(18, 5);

        private Point _imgHitArea = new Point(15, 3);

        Image CloseImage;
        Type t = null;
        public Form frm = null;
        public sawoncode frm1 = new sawoncode(); //사원코드


        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //   new login().ShowDialog(); // 폼 2 먼저 연결
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseClick += tabControl1_MouseClick;
            CloseImage = Properties.Resources.close;
            this.tabControl1.Padding = new Point(10, 3);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // treeview node 클릭시 tabpage 폼 호출

            string str = (e.Node.ToString()).Substring(10);

            switch (str)
            {
                case "사원코드": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        sawoncode form = new sawoncode();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "부서코드": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        groupcode form = new groupcode();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str); // tabpage 새로 불러옴
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "그룹코드": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        groupcode form = new groupcode();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;

                case "인사기본사항": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form3 form = new Form3();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "가족사항": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form5 form = new Form5();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "학력사항": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form6 form = new Form6();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "수상경력": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form7 form = new Form7();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "경력사항": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form8 form = new Form8();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "자격면허": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form9 form = new Form9();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "외국어": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        Form10 form = new Form10();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "인사기록조회(통합)": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        insaserch form = new insaserch();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
                case "인사변동사항": //탭이 겹치면 그 탭을 열고 겹치는 탭이 없으면 새로운 탭 생성
                    if (!Commons.DICT_REMOVE_INDEX.ContainsKey(str))
                    {
                        njwsub001 form = new njwsub001();
                        //form.FormCloseEvent += DeleteTabpage;
                        form.TopLevel = false;
                        tabControl1.TabPages.Add(str);
                        tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
                        tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

                        Commons.DICT_REMOVE_INDEX.Add(str, tabControl1.SelectedIndex); //Dictionary로 화면텍스트와 탭번호 저장
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                    else
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[Commons.DICT_REMOVE_INDEX[str]];
                    }
                    break;
            }
        }
        private void swapTabPages(TabControl tc, TabPage src, TabPage dst)
        {
            int index_src = tc.TabPages.IndexOf(src);
            int index_dst = tc.TabPages.IndexOf(dst);
            tc.TabPages[index_dst] = src;
            tc.TabPages[index_src] = dst;
            tc.Refresh();
        }
        private int getHoverTabIndex(TabControl tc)
        {
            for (int i = 0; i < tc.TabPages.Count; i++)
            {
                if (tc.GetTabRect(i).Contains(tc.PointToClient(Cursor.Position)))
                    return i;
            }

            return -1;
        }
        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            //tabpage 닫기 버튼
            try
            {
                Console.WriteLine(sender);
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(3, 3);
                string title = this.tabControl1.TabPages[e.Index].Text;
                Font f = this.Font;
                Brush titleBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString(title, f, titleBrush, new PointF(r.X, r.Y));
                if (tabControl1.SelectedIndex >= 1)
                {
                    e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }

            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message.ToString());
            }


        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // 마우스 클릭시 tabpage닫기
            TabControl rc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(rc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(rc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 10;
            r.Height = 10;

            if (tabControl1.SelectedIndex >= 1)
            {

                if (r.Contains(p))
                {
                    TabPage tabp = (TabPage)rc.TabPages[rc.SelectedIndex];
                    Commons.DICT_REMOVE_INDEX.Remove(tabControl1.SelectedTab.Text);
                    rc.TabPages.Remove(tabp);
                }
            }
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 버튼을 누르고 탭움직일때
            TabControl tc = (TabControl)sender;
            if ((e.Button != MouseButtons.Left) || (tc.Tag == null)) return;
            TabPage clickedTab = (TabPage)tc.Tag;
            int clicked_index = tc.TabPages.IndexOf(clickedTab);

            // 드레그엔드롭 시작부분
            tc.DoDragDrop(clickedTab, DragDropEffects.All);
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭탭 저장
            TabControl tc = (TabControl)sender;
            int hover_index = this.getHoverTabIndex(tc);
            if (hover_index >= 0) { tc.Tag = tc.TabPages[hover_index]; }
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            // 저장된 탭 지우기
            TabControl tc = (TabControl)sender;
            tc.Tag = null;
        }

        private void tabControl1_DragOver(object sender, DragEventArgs e)
        {
            TabControl tc = (TabControl)sender;

            // 탭이동
            if (e.Data.GetData(typeof(TabPage)) == null) return;
            TabPage dragTab = (TabPage)e.Data.GetData(typeof(TabPage));
            int dragTab_index = tc.TabPages.IndexOf(dragTab);

            // 마우스로 탭 이동
            int hoverTab_index = this.getHoverTabIndex(tc);
            if (hoverTab_index < 0) { e.Effect = DragDropEffects.None; return; }
            TabPage hoverTab = tc.TabPages[hoverTab_index];
            e.Effect = DragDropEffects.Move;

            // 드레그 시작
            if (dragTab == hoverTab) return;

            // dragTab 및 hoverTab 교체-전환 방지
            Rectangle dragTabRect = tc.GetTabRect(dragTab_index);
            Rectangle hoverTabRect = tc.GetTabRect(hoverTab_index);

            if (dragTabRect.Width < hoverTabRect.Width)
            {
                Point tcLocation = tc.PointToScreen(tc.Location);

                if (dragTab_index < hoverTab_index)
                {
                    if ((e.X - tcLocation.X) > ((hoverTabRect.X + hoverTabRect.Width) - dragTabRect.Width))
                        this.swapTabPages(tc, dragTab, hoverTab);
                }
                else if (dragTab_index > hoverTab_index)
                {
                    if ((e.X - tcLocation.X) < (hoverTabRect.X + dragTabRect.Width))
                        this.swapTabPages(tc, dragTab, hoverTab);
                }
            }
            else this.swapTabPages(tc, dragTab, hoverTab);

            //텝 새위치 지정
            tc.SelectedIndex = tc.TabPages.IndexOf(dragTab);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            
            // 오른쪽 클릭시 
            if (e.Button.Equals(MouseButtons.Right)) return;
            {
                // 선택지정된 노드를 마우스 textbox 에 집어 넣음
                TreeNode node_here = treeView1.GetNodeAt(e.X, e.Y);
                treeView1.SelectedNode = node_here;
                //노드가 있는지 판단
                if (node_here == null) return;
                {
                    treeView1.SelectedNode = treeView1.Tag.Equals();
                }
            }
            

        }
    }

    public class Commons
    {
        public static Dictionary<string, int> DICT_REMOVE_INDEX = new Dictionary<string, int>();
    }
}
