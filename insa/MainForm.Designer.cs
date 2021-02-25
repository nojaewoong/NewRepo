namespace insa
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("사원코드");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("부서코드");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("그룹코드");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("코드관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("인사기본사항");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("인사변동사항");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("가족사항");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("학력사항");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("수상경력");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("경력사항");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("자격면허");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("외국어");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("인사기록조회(통합)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("인사관리", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("인사변동대장관리");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("인사변동등록");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("인사변동조회");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("인사변동관리", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("업무평가항목 및 기준 관리");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("업무평가진행 관리");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("업무평가대상자 관리");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("업무평가 등록(온라인)");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("업무평가 진행현황");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("업무평가 결과 조회");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("업무평가", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("재직증명서");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("경력증명서");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("영문증명서");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("제증명서 발급대장 조회");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("제증명서발급", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("부서별 인원현황(현재/시점)");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("직급별 인원현황(현재/시점)");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("기간별 재직인원 추이");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("년도별 입사인원 추이");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("년도별 사직인원 추이");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("현황 및 통계", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.26433F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.73566F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.993197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.00681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1340, 697);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(207, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1130, 636);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 640);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragOver);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            this.tabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseMove);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.treeView1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 58);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(198, 636);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드11";
            treeNode1.Text = "사원코드";
            treeNode2.Name = "노드12";
            treeNode2.Text = "부서코드";
            treeNode3.Name = "노드13";
            treeNode3.Text = "그룹코드";
            treeNode4.Name = "노드10";
            treeNode4.Text = "코드관리";
            treeNode5.Name = "노드3";
            treeNode5.Text = "인사기본사항";
            treeNode6.Name = "노드15";
            treeNode6.Text = "인사변동사항";
            treeNode7.Name = "노드3";
            treeNode7.Text = "가족사항";
            treeNode8.Name = "노드7";
            treeNode8.Text = "학력사항";
            treeNode9.Name = "노드9";
            treeNode9.Text = "수상경력";
            treeNode10.Name = "노드17";
            treeNode10.Text = "경력사항";
            treeNode11.Name = "노드8";
            treeNode11.Text = "자격면허";
            treeNode12.Name = "노드18";
            treeNode12.Text = "외국어";
            treeNode13.Name = "노드19";
            treeNode13.Text = "인사기록조회(통합)";
            treeNode14.Name = "노드0";
            treeNode14.Text = "인사관리";
            treeNode15.Name = "노드15";
            treeNode15.Text = "인사변동대장관리";
            treeNode16.Name = "노드16";
            treeNode16.Text = "인사변동등록";
            treeNode17.Name = "노드17";
            treeNode17.Text = "인사변동조회";
            treeNode18.Name = "노드1";
            treeNode18.Text = "인사변동관리";
            treeNode19.Name = "노드19";
            treeNode19.Text = "업무평가항목 및 기준 관리";
            treeNode20.Name = "노드20";
            treeNode20.Text = "업무평가진행 관리";
            treeNode21.Name = "노드21";
            treeNode21.Text = "업무평가대상자 관리";
            treeNode22.Name = "노드22";
            treeNode22.Text = "업무평가 등록(온라인)";
            treeNode23.Name = "노드23";
            treeNode23.Text = "업무평가 진행현황";
            treeNode24.Name = "노드24";
            treeNode24.Text = "업무평가 결과 조회";
            treeNode25.Name = "노드2";
            treeNode25.Text = "업무평가";
            treeNode26.Name = "노드25";
            treeNode26.Text = "재직증명서";
            treeNode27.Name = "노드26";
            treeNode27.Text = "경력증명서";
            treeNode28.Name = "노드27";
            treeNode28.Text = "영문증명서";
            treeNode29.Name = "노드28";
            treeNode29.Text = "제증명서 발급대장 조회";
            treeNode30.Name = "노드3";
            treeNode30.Text = "제증명서발급";
            treeNode31.Name = "노드29";
            treeNode31.Text = "부서별 인원현황(현재/시점)";
            treeNode32.Name = "노드30";
            treeNode32.Text = "직급별 인원현황(현재/시점)";
            treeNode33.Name = "노드31";
            treeNode33.Text = "기간별 재직인원 추이";
            treeNode34.Name = "노드32";
            treeNode34.Text = "년도별 입사인원 추이";
            treeNode35.Name = "노드33";
            treeNode35.Text = "년도별 사직인원 추이";
            treeNode36.Name = "노드14";
            treeNode36.Text = "현황 및 통계";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode14,
            treeNode18,
            treeNode25,
            treeNode30,
            treeNode36});
            this.treeView1.Size = new System.Drawing.Size(195, 637);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.iconButton12);
            this.panel3.Controls.Add(this.iconButton11);
            this.panel3.Controls.Add(this.iconButton10);
            this.panel3.Controls.Add(this.iconButton9);
            this.panel3.Controls.Add(this.iconButton7);
            this.panel3.Controls.Add(this.iconButton8);
            this.panel3.Location = new System.Drawing.Point(207, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 49);
            this.panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(738, 8);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(65, 34);
            this.iconButton1.TabIndex = 33;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton12.FlatAppearance.BorderSize = 0;
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton12.IconColor = System.Drawing.Color.Black;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 32;
            this.iconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.Location = new System.Drawing.Point(1074, 8);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton12.Size = new System.Drawing.Size(65, 34);
            this.iconButton12.TabIndex = 32;
            this.iconButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton12.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton11.IconColor = System.Drawing.Color.Black;
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 32;
            this.iconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton11.Location = new System.Drawing.Point(1014, 8);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton11.Size = new System.Drawing.Size(65, 34);
            this.iconButton11.TabIndex = 31;
            this.iconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton11.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton10.IconColor = System.Drawing.Color.Black;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 32;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(949, 5);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton10.Size = new System.Drawing.Size(65, 34);
            this.iconButton10.TabIndex = 30;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Highlighter;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 32;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(906, 3);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton9.Size = new System.Drawing.Size(53, 34);
            this.iconButton9.TabIndex = 29;
            this.iconButton9.Text = "+";
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(863, 6);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton7.Size = new System.Drawing.Size(55, 34);
            this.iconButton7.TabIndex = 28;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 32;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(809, 8);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton8.Size = new System.Drawing.Size(65, 34);
            this.iconButton8.TabIndex = 27;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

