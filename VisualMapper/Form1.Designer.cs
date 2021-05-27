using System.Windows.Forms;

namespace VisualMapper {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.infoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTerrain = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbEmpire = new System.Windows.Forms.TextBox();
            this.tbKingdom = new System.Windows.Forms.TextBox();
            this.tbDuchy = new System.Windows.Forms.TextBox();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCulture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbReligion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHolding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.selectionCountLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCmb = new System.Windows.Forms.ToolStripComboBox();
            this.toolValueCmb = new System.Windows.Forms.ToolStripComboBox();
            this.cmbToolView = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dataTabPage.SuspendLayout();
            this.infoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Save";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Load Table";
            this.menuItem3.Click += new System.EventHandler(this.loadSpreadsheet_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Load Image";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9});
            this.menuItem6.Text = "Edit";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "Extract Colours";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem10});
            this.menuItem7.Text = "View";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Select Next Unnamed";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "Check for error provinces";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1279, 480);
            this.splitContainer1.SplitterDistance = 879;
            this.splitContainer1.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // dataTabPage
            // 
            this.dataTabPage.Controls.Add(this.infoTableLayout);
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataTabPage.Size = new System.Drawing.Size(388, 422);
            this.dataTabPage.TabIndex = 0;
            this.dataTabPage.Text = "Data";
            this.dataTabPage.UseVisualStyleBackColor = true;
            // 
            // infoTableLayout
            // 
            this.infoTableLayout.ColumnCount = 4;
            this.infoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.infoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.infoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.infoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.infoTableLayout.Controls.Add(this.label7, 0, 6);
            this.infoTableLayout.Controls.Add(this.label6, 0, 5);
            this.infoTableLayout.Controls.Add(this.label3, 0, 2);
            this.infoTableLayout.Controls.Add(this.cmbTerrain, 1, 6);
            this.infoTableLayout.Controls.Add(this.cmbType, 1, 5);
            this.infoTableLayout.Controls.Add(this.tbEmpire, 1, 4);
            this.infoTableLayout.Controls.Add(this.tbKingdom, 1, 3);
            this.infoTableLayout.Controls.Add(this.tbDuchy, 1, 2);
            this.infoTableLayout.Controls.Add(this.tbCounty, 1, 1);
            this.infoTableLayout.Controls.Add(this.label2, 0, 1);
            this.infoTableLayout.Controls.Add(this.label4, 0, 3);
            this.infoTableLayout.Controls.Add(this.label5, 0, 4);
            this.infoTableLayout.Controls.Add(this.label9, 0, 9);
            this.infoTableLayout.Controls.Add(this.tbCulture, 1, 9);
            this.infoTableLayout.Controls.Add(this.label8, 0, 8);
            this.infoTableLayout.Controls.Add(this.tbReligion, 1, 8);
            this.infoTableLayout.Controls.Add(this.label10, 0, 7);
            this.infoTableLayout.Controls.Add(this.cmbHolding, 1, 7);
            this.infoTableLayout.Controls.Add(this.label1, 0, 0);
            this.infoTableLayout.Controls.Add(this.tbName, 1, 0);
            this.infoTableLayout.Controls.Add(this.btnClear, 2, 10);
            this.infoTableLayout.Controls.Add(this.selectionCountLabel, 1, 10);
            this.infoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTableLayout.Location = new System.Drawing.Point(3, 3);
            this.infoTableLayout.Name = "infoTableLayout";
            this.infoTableLayout.RowCount = 11;
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoTableLayout.Size = new System.Drawing.Size(382, 416);
            this.infoTableLayout.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Terrain";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Duchy";
            // 
            // cmbTerrain
            // 
            this.cmbTerrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerrain.FormattingEnabled = true;
            this.cmbTerrain.Location = new System.Drawing.Point(86, 123);
            this.cmbTerrain.Name = "cmbTerrain";
            this.cmbTerrain.Size = new System.Drawing.Size(76, 32);
            this.cmbTerrain.TabIndex = 13;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(86, 103);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(76, 32);
            this.cmbType.TabIndex = 12;
            // 
            // tbEmpire
            // 
            this.tbEmpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpire.Location = new System.Drawing.Point(86, 83);
            this.tbEmpire.Name = "tbEmpire";
            this.tbEmpire.Size = new System.Drawing.Size(76, 29);
            this.tbEmpire.TabIndex = 10;
            // 
            // tbKingdom
            // 
            this.tbKingdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKingdom.Location = new System.Drawing.Point(86, 63);
            this.tbKingdom.Name = "tbKingdom";
            this.tbKingdom.Size = new System.Drawing.Size(76, 29);
            this.tbKingdom.TabIndex = 9;
            // 
            // tbDuchy
            // 
            this.tbDuchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuchy.Location = new System.Drawing.Point(86, 43);
            this.tbDuchy.MaximumSize = new System.Drawing.Size(300, 29);
            this.tbDuchy.Name = "tbDuchy";
            this.tbDuchy.Size = new System.Drawing.Size(76, 29);
            this.tbDuchy.TabIndex = 8;
            // 
            // tbCounty
            // 
            this.tbCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCounty.Location = new System.Drawing.Point(86, 23);
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(76, 29);
            this.tbCounty.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "County";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kingdom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Empire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Culture";
            // 
            // tbCulture
            // 
            this.tbCulture.Location = new System.Drawing.Point(86, 183);
            this.tbCulture.Name = "tbCulture";
            this.tbCulture.Size = new System.Drawing.Size(76, 29);
            this.tbCulture.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Religion";
            // 
            // tbReligion
            // 
            this.tbReligion.Location = new System.Drawing.Point(86, 163);
            this.tbReligion.Name = "tbReligion";
            this.tbReligion.Size = new System.Drawing.Size(76, 29);
            this.tbReligion.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Holding";
            // 
            // cmbHolding
            // 
            this.cmbHolding.FormattingEnabled = true;
            this.cmbHolding.Location = new System.Drawing.Point(86, 143);
            this.cmbHolding.Name = "cmbHolding";
            this.cmbHolding.Size = new System.Drawing.Size(14, 32);
            this.cmbHolding.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(86, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 29);
            this.tbName.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 23);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // selectionCountLabel
            // 
            this.selectionCountLabel.AutoSize = true;
            this.selectionCountLabel.Location = new System.Drawing.Point(86, 200);
            this.selectionCountLabel.Name = "selectionCountLabel";
            this.selectionCountLabel.Size = new System.Drawing.Size(20, 24);
            this.selectionCountLabel.TabIndex = 57;
            this.selectionCountLabel.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1279, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolCmb
            // 
            this.toolCmb.Name = "toolCmb";
            this.toolCmb.Size = new System.Drawing.Size(121, 23);
            // 
            // toolValueCmb
            // 
            this.toolValueCmb.Name = "toolValueCmb";
            this.toolValueCmb.Size = new System.Drawing.Size(121, 23);
            // 
            // cmbToolView
            // 
            this.cmbToolView.Location = new System.Drawing.Point(0, 0);
            this.cmbToolView.Name = "cmbToolView";
            this.cmbToolView.Size = new System.Drawing.Size(121, 21);
            this.cmbToolView.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 143);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.dataTabPage.ResumeLayout(false);
            this.infoTableLayout.ResumeLayout(false);
            this.infoTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private MenuItem menuItem8;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private ColorDialog colorDialog1;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolCmb;
        public ToolStripComboBox toolValueCmb;
        private TabControl tabControl1;
        private TabPage dataTabPage;
        private TableLayoutPanel infoTableLayout;
        private Label label7;
        private Label label6;
        private Label label3;
        private ComboBox cmbTerrain;
        private ComboBox cmbType;
        private TextBox tbEmpire;
        private TextBox tbKingdom;
        private TextBox tbDuchy;
        private TextBox tbCounty;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label9;
        private TextBox tbCulture;
        private Label label8;
        private TextBox tbReligion;
        private Label label10;
        private ComboBox cmbHolding;
        private Label label1;
        private TextBox tbName;
        private Button btnClear;
        private Label selectionCountLabel;
        private Button button2;
        private RichTextBox richTextBox1;
        private ComboBox cmbToolView;
    }
}

