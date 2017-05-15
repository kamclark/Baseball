using System;
using System.Windows.Forms;

public class frmMain : Form
{
	private Button btnClose;
	private Label lblResultFlavor;
	private Label lblSwingResultCommentary;
	private Label label2;
	private Label label3;
	private Label label4;
	private Label label5;
	private Label label6;
	private Label label7;
	private Label label8;
	private TextBox txtplateAppearances;
	private TextBox txtOuts;
	private TextBox txtSingles;
	private TextBox txtTriples;
	private TextBox txtWalks;
	private TextBox txtHomeruns;
	private TextBox txtDoubles;
	private Label label9;
	private Label label10;
	private Label label11;
	private TextBox txtHits;
	private TextBox txtSLG;
	private TextBox txtBA;
	private Label label12;
	private TextBox txtTotalBases;
	private TextBox txtOPS;
	private Label label13;
	private TextBox txtOBP;
	private Label label15;
	private TextBox txtHBP;
	private TextBox txtStrikeouts;
	private Label label18;
	private Label label19;
	private Label label1;
	private TextBox txtBatterFirstName;
	private Label label14;
	private TextBox txtSkillPoints;
	private TextBox txtBatterNickname;
	private Label label16;
	private TextBox txtBatterLastName;
	private TextBox txtPowerRating;
	private Label label17;
	private TextBox txtContactRating;
	private Label label20;
	private TextBox txtEyeRating;
	private Label label21;
	private TextBox txtSpeedRating;
	private Label label22;
	private Button btnContactIncrease;
	private Button btnContactDecrease;
	private Button btnPowerIncrease;
	private Button btnPowerDecrease;
	private Button btnEyeIncrease;
	private Button btnEyeDecrease;
	private Button btnSpeedIncrease;
	private Button btnSpeedDecrease;
	private Label label23;
	private Label label24;
	private Label label25;
	private Label label26;
	private TextBox txtContactCost;
	private TextBox txtPowerCost;
	private TextBox txtEyeCost;
	private TextBox txtSpeedCost;
	private MenuStrip menuStrip1;
	private ToolStripMenuItem fileToolStripMenuItem;
	private ToolStripMenuItem helpToolStripMenuItem;
	private ToolStripMenuItem aboutToolStripMenuItem;
	private ToolStripMenuItem closeToolStripMenuItem;
	private Button btnSwing;
	#region Windows Code
	private void InitializeComponent()
	{
			this.btnSwing = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblResultFlavor = new System.Windows.Forms.Label();
			this.lblSwingResultCommentary = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtplateAppearances = new System.Windows.Forms.TextBox();
			this.txtOuts = new System.Windows.Forms.TextBox();
			this.txtSingles = new System.Windows.Forms.TextBox();
			this.txtTriples = new System.Windows.Forms.TextBox();
			this.txtWalks = new System.Windows.Forms.TextBox();
			this.txtHomeruns = new System.Windows.Forms.TextBox();
			this.txtDoubles = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtHits = new System.Windows.Forms.TextBox();
			this.txtSLG = new System.Windows.Forms.TextBox();
			this.txtBA = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTotalBases = new System.Windows.Forms.TextBox();
			this.txtOPS = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtOBP = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtHBP = new System.Windows.Forms.TextBox();
			this.txtStrikeouts = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBatterFirstName = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtSkillPoints = new System.Windows.Forms.TextBox();
			this.txtBatterNickname = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtBatterLastName = new System.Windows.Forms.TextBox();
			this.txtPowerRating = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtContactRating = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtEyeRating = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtSpeedRating = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.btnContactIncrease = new System.Windows.Forms.Button();
			this.btnContactDecrease = new System.Windows.Forms.Button();
			this.btnPowerIncrease = new System.Windows.Forms.Button();
			this.btnPowerDecrease = new System.Windows.Forms.Button();
			this.btnEyeIncrease = new System.Windows.Forms.Button();
			this.btnEyeDecrease = new System.Windows.Forms.Button();
			this.btnSpeedIncrease = new System.Windows.Forms.Button();
			this.btnSpeedDecrease = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txtContactCost = new System.Windows.Forms.TextBox();
			this.txtPowerCost = new System.Windows.Forms.TextBox();
			this.txtEyeCost = new System.Windows.Forms.TextBox();
			this.txtSpeedCost = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSwing
			// 
			this.btnSwing.Location = new System.Drawing.Point(135, 248);
			this.btnSwing.Name = "btnSwing";
			this.btnSwing.Size = new System.Drawing.Size(159, 23);
			this.btnSwing.TabIndex = 0;
			this.btnSwing.Text = "&Swing";
			this.btnSwing.UseVisualStyleBackColor = true;
			this.btnSwing.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(308, 248);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(159, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblResultFlavor
			// 
			this.lblResultFlavor.AutoSize = true;
			this.lblResultFlavor.Location = new System.Drawing.Point(7, 33);
			this.lblResultFlavor.Name = "lblResultFlavor";
			this.lblResultFlavor.Size = new System.Drawing.Size(50, 13);
			this.lblResultFlavor.TabIndex = 2;
			this.lblResultFlavor.Text = "Play Ball!";
			// 
			// lblSwingResultCommentary
			// 
			this.lblSwingResultCommentary.AutoSize = true;
			this.lblSwingResultCommentary.Location = new System.Drawing.Point(7, 50);
			this.lblSwingResultCommentary.Name = "lblSwingResultCommentary";
			this.lblSwingResultCommentary.Size = new System.Drawing.Size(46, 13);
			this.lblSwingResultCommentary.TabIndex = 3;
			this.lblSwingResultCommentary.Text = "Result...";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "PA:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Singles:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Doubles:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Triples:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Walks:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Homeruns:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Outs:";
			// 
			// txtplateAppearances
			// 
			this.txtplateAppearances.BackColor = System.Drawing.SystemColors.Window;
			this.txtplateAppearances.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtplateAppearances.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtplateAppearances.Location = new System.Drawing.Point(76, 70);
			this.txtplateAppearances.Name = "txtplateAppearances";
			this.txtplateAppearances.ReadOnly = true;
			this.txtplateAppearances.Size = new System.Drawing.Size(37, 13);
			this.txtplateAppearances.TabIndex = 11;
			this.txtplateAppearances.Text = "0";
			// 
			// txtOuts
			// 
			this.txtOuts.BackColor = System.Drawing.SystemColors.Window;
			this.txtOuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOuts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOuts.Location = new System.Drawing.Point(76, 89);
			this.txtOuts.Name = "txtOuts";
			this.txtOuts.ReadOnly = true;
			this.txtOuts.Size = new System.Drawing.Size(37, 13);
			this.txtOuts.TabIndex = 12;
			this.txtOuts.Text = "0";
			// 
			// txtSingles
			// 
			this.txtSingles.BackColor = System.Drawing.SystemColors.Window;
			this.txtSingles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSingles.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSingles.Location = new System.Drawing.Point(76, 154);
			this.txtSingles.Name = "txtSingles";
			this.txtSingles.ReadOnly = true;
			this.txtSingles.Size = new System.Drawing.Size(37, 13);
			this.txtSingles.TabIndex = 14;
			// 
			// txtTriples
			// 
			this.txtTriples.BackColor = System.Drawing.SystemColors.Window;
			this.txtTriples.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTriples.Location = new System.Drawing.Point(76, 192);
			this.txtTriples.Name = "txtTriples";
			this.txtTriples.ReadOnly = true;
			this.txtTriples.Size = new System.Drawing.Size(37, 13);
			this.txtTriples.TabIndex = 15;
			// 
			// txtWalks
			// 
			this.txtWalks.BackColor = System.Drawing.SystemColors.Window;
			this.txtWalks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtWalks.Location = new System.Drawing.Point(76, 108);
			this.txtWalks.Name = "txtWalks";
			this.txtWalks.ReadOnly = true;
			this.txtWalks.Size = new System.Drawing.Size(37, 13);
			this.txtWalks.TabIndex = 16;
			this.txtWalks.Text = "0";
			// 
			// txtHomeruns
			// 
			this.txtHomeruns.BackColor = System.Drawing.SystemColors.Window;
			this.txtHomeruns.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHomeruns.Location = new System.Drawing.Point(76, 211);
			this.txtHomeruns.Name = "txtHomeruns";
			this.txtHomeruns.ReadOnly = true;
			this.txtHomeruns.Size = new System.Drawing.Size(37, 13);
			this.txtHomeruns.TabIndex = 17;
			// 
			// txtDoubles
			// 
			this.txtDoubles.BackColor = System.Drawing.SystemColors.Window;
			this.txtDoubles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDoubles.Location = new System.Drawing.Point(76, 173);
			this.txtDoubles.Name = "txtDoubles";
			this.txtDoubles.ReadOnly = true;
			this.txtDoubles.Size = new System.Drawing.Size(37, 13);
			this.txtDoubles.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 229);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Hits:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(131, 153);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "BA:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(131, 191);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "SLG:";
			// 
			// txtHits
			// 
			this.txtHits.BackColor = System.Drawing.SystemColors.Window;
			this.txtHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHits.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHits.Location = new System.Drawing.Point(76, 230);
			this.txtHits.Name = "txtHits";
			this.txtHits.ReadOnly = true;
			this.txtHits.Size = new System.Drawing.Size(37, 13);
			this.txtHits.TabIndex = 22;
			// 
			// txtSLG
			// 
			this.txtSLG.BackColor = System.Drawing.SystemColors.Window;
			this.txtSLG.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSLG.Location = new System.Drawing.Point(170, 191);
			this.txtSLG.Name = "txtSLG";
			this.txtSLG.ReadOnly = true;
			this.txtSLG.Size = new System.Drawing.Size(37, 13);
			this.txtSLG.TabIndex = 23;
			// 
			// txtBA
			// 
			this.txtBA.BackColor = System.Drawing.SystemColors.Window;
			this.txtBA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBA.Location = new System.Drawing.Point(170, 154);
			this.txtBA.Name = "txtBA";
			this.txtBA.ReadOnly = true;
			this.txtBA.Size = new System.Drawing.Size(37, 13);
			this.txtBA.TabIndex = 24;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(131, 69);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "TB:";
			// 
			// txtTotalBases
			// 
			this.txtTotalBases.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalBases.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotalBases.Location = new System.Drawing.Point(170, 70);
			this.txtTotalBases.Name = "txtTotalBases";
			this.txtTotalBases.ReadOnly = true;
			this.txtTotalBases.Size = new System.Drawing.Size(37, 13);
			this.txtTotalBases.TabIndex = 26;
			// 
			// txtOPS
			// 
			this.txtOPS.BackColor = System.Drawing.SystemColors.Window;
			this.txtOPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOPS.Location = new System.Drawing.Point(170, 210);
			this.txtOPS.Name = "txtOPS";
			this.txtOPS.ReadOnly = true;
			this.txtOPS.Size = new System.Drawing.Size(37, 13);
			this.txtOPS.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(131, 210);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "OPS:";
			// 
			// txtOBP
			// 
			this.txtOBP.BackColor = System.Drawing.SystemColors.Window;
			this.txtOBP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOBP.Location = new System.Drawing.Point(170, 173);
			this.txtOBP.Name = "txtOBP";
			this.txtOBP.ReadOnly = true;
			this.txtOBP.Size = new System.Drawing.Size(37, 13);
			this.txtOBP.TabIndex = 32;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(131, 172);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 13);
			this.label15.TabIndex = 31;
			this.label15.Text = "OBP:";
			// 
			// txtHBP
			// 
			this.txtHBP.BackColor = System.Drawing.SystemColors.Window;
			this.txtHBP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHBP.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHBP.Location = new System.Drawing.Point(170, 89);
			this.txtHBP.Name = "txtHBP";
			this.txtHBP.ReadOnly = true;
			this.txtHBP.Size = new System.Drawing.Size(37, 13);
			this.txtHBP.TabIndex = 39;
			// 
			// txtStrikeouts
			// 
			this.txtStrikeouts.BackColor = System.Drawing.SystemColors.Window;
			this.txtStrikeouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtStrikeouts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtStrikeouts.Location = new System.Drawing.Point(76, 127);
			this.txtStrikeouts.Name = "txtStrikeouts";
			this.txtStrikeouts.ReadOnly = true;
			this.txtStrikeouts.Size = new System.Drawing.Size(37, 13);
			this.txtStrikeouts.TabIndex = 37;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(131, 88);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(32, 13);
			this.label18.TabIndex = 35;
			this.label18.Text = "HBP:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(7, 126);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(54, 13);
			this.label19.TabIndex = 34;
			this.label19.Text = "Strikeouts";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 40;
			this.label1.Text = "Name";
			// 
			// txtBatterFirstName
			// 
			this.txtBatterFirstName.Location = new System.Drawing.Point(219, 85);
			this.txtBatterFirstName.Name = "txtBatterFirstName";
			this.txtBatterFirstName.Size = new System.Drawing.Size(62, 20);
			this.txtBatterFirstName.TabIndex = 41;
			this.txtBatterFirstName.Text = "Kam";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(361, 67);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(61, 13);
			this.label14.TabIndex = 42;
			this.label14.Text = "Skill Points:";
			// 
			// txtSkillPoints
			// 
			this.txtSkillPoints.BackColor = System.Drawing.SystemColors.Window;
			this.txtSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSkillPoints.Location = new System.Drawing.Point(424, 65);
			this.txtSkillPoints.Name = "txtSkillPoints";
			this.txtSkillPoints.ReadOnly = true;
			this.txtSkillPoints.Size = new System.Drawing.Size(46, 20);
			this.txtSkillPoints.TabIndex = 43;
			this.txtSkillPoints.Text = "0";
			// 
			// txtBatterNickname
			// 
			this.txtBatterNickname.Location = new System.Drawing.Point(219, 123);
			this.txtBatterNickname.Name = "txtBatterNickname";
			this.txtBatterNickname.Size = new System.Drawing.Size(107, 20);
			this.txtBatterNickname.TabIndex = 45;
			this.txtBatterNickname.Text = "The Bat";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(219, 108);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(55, 13);
			this.label16.TabIndex = 44;
			this.label16.Text = "Nickname";
			// 
			// txtBatterLastName
			// 
			this.txtBatterLastName.Location = new System.Drawing.Point(287, 85);
			this.txtBatterLastName.Name = "txtBatterLastName";
			this.txtBatterLastName.Size = new System.Drawing.Size(62, 20);
			this.txtBatterLastName.TabIndex = 46;
			this.txtBatterLastName.Text = "Clark";
			// 
			// txtPowerRating
			// 
			this.txtPowerRating.BackColor = System.Drawing.SystemColors.Window;
			this.txtPowerRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPowerRating.Location = new System.Drawing.Point(424, 120);
			this.txtPowerRating.Name = "txtPowerRating";
			this.txtPowerRating.ReadOnly = true;
			this.txtPowerRating.Size = new System.Drawing.Size(46, 20);
			this.txtPowerRating.TabIndex = 48;
			this.txtPowerRating.Text = "0";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(361, 93);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(44, 13);
			this.label17.TabIndex = 47;
			this.label17.Text = "Contact";
			// 
			// txtContactRating
			// 
			this.txtContactRating.BackColor = System.Drawing.SystemColors.Window;
			this.txtContactRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContactRating.Location = new System.Drawing.Point(424, 91);
			this.txtContactRating.Name = "txtContactRating";
			this.txtContactRating.ReadOnly = true;
			this.txtContactRating.Size = new System.Drawing.Size(46, 20);
			this.txtContactRating.TabIndex = 50;
			this.txtContactRating.Text = "0";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(361, 122);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(37, 13);
			this.label20.TabIndex = 49;
			this.label20.Text = "Power";
			// 
			// txtEyeRating
			// 
			this.txtEyeRating.BackColor = System.Drawing.SystemColors.Window;
			this.txtEyeRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEyeRating.Location = new System.Drawing.Point(424, 150);
			this.txtEyeRating.Name = "txtEyeRating";
			this.txtEyeRating.ReadOnly = true;
			this.txtEyeRating.Size = new System.Drawing.Size(46, 20);
			this.txtEyeRating.TabIndex = 52;
			this.txtEyeRating.Text = "0";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(361, 183);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 13);
			this.label21.TabIndex = 51;
			this.label21.Text = "Speed";
			// 
			// txtSpeedRating
			// 
			this.txtSpeedRating.BackColor = System.Drawing.SystemColors.Window;
			this.txtSpeedRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSpeedRating.Location = new System.Drawing.Point(424, 180);
			this.txtSpeedRating.Name = "txtSpeedRating";
			this.txtSpeedRating.ReadOnly = true;
			this.txtSpeedRating.Size = new System.Drawing.Size(46, 20);
			this.txtSpeedRating.TabIndex = 54;
			this.txtSpeedRating.Text = "0";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(361, 154);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(25, 13);
			this.label22.TabIndex = 53;
			this.label22.Text = "Eye";
			// 
			// btnContactIncrease
			// 
			this.btnContactIncrease.Location = new System.Drawing.Point(475, 88);
			this.btnContactIncrease.Name = "btnContactIncrease";
			this.btnContactIncrease.Size = new System.Drawing.Size(19, 23);
			this.btnContactIncrease.TabIndex = 58;
			this.btnContactIncrease.Text = "+";
			this.btnContactIncrease.UseVisualStyleBackColor = true;
			this.btnContactIncrease.Click += new System.EventHandler(this.btnContactIncrease_Click);
			// 
			// btnContactDecrease
			// 
			this.btnContactDecrease.Location = new System.Drawing.Point(505, 88);
			this.btnContactDecrease.Name = "btnContactDecrease";
			this.btnContactDecrease.Size = new System.Drawing.Size(19, 23);
			this.btnContactDecrease.TabIndex = 57;
			this.btnContactDecrease.Text = "-";
			this.btnContactDecrease.UseVisualStyleBackColor = true;
			// 
			// btnPowerIncrease
			// 
			this.btnPowerIncrease.Location = new System.Drawing.Point(475, 117);
			this.btnPowerIncrease.Name = "btnPowerIncrease";
			this.btnPowerIncrease.Size = new System.Drawing.Size(19, 23);
			this.btnPowerIncrease.TabIndex = 60;
			this.btnPowerIncrease.Text = "+";
			this.btnPowerIncrease.UseVisualStyleBackColor = true;
			this.btnPowerIncrease.Click += new System.EventHandler(this.btnPowerIncrease_Click);
			// 
			// btnPowerDecrease
			// 
			this.btnPowerDecrease.Location = new System.Drawing.Point(505, 117);
			this.btnPowerDecrease.Name = "btnPowerDecrease";
			this.btnPowerDecrease.Size = new System.Drawing.Size(19, 23);
			this.btnPowerDecrease.TabIndex = 59;
			this.btnPowerDecrease.Text = "-";
			this.btnPowerDecrease.UseVisualStyleBackColor = true;
			// 
			// btnEyeIncrease
			// 
			this.btnEyeIncrease.Location = new System.Drawing.Point(475, 148);
			this.btnEyeIncrease.Name = "btnEyeIncrease";
			this.btnEyeIncrease.Size = new System.Drawing.Size(19, 23);
			this.btnEyeIncrease.TabIndex = 62;
			this.btnEyeIncrease.Text = "+";
			this.btnEyeIncrease.UseVisualStyleBackColor = true;
			this.btnEyeIncrease.Click += new System.EventHandler(this.btnEyeIncrease_Click);
			// 
			// btnEyeDecrease
			// 
			this.btnEyeDecrease.Location = new System.Drawing.Point(505, 148);
			this.btnEyeDecrease.Name = "btnEyeDecrease";
			this.btnEyeDecrease.Size = new System.Drawing.Size(19, 23);
			this.btnEyeDecrease.TabIndex = 61;
			this.btnEyeDecrease.Text = "-";
			this.btnEyeDecrease.UseVisualStyleBackColor = true;
			// 
			// btnSpeedIncrease
			// 
			this.btnSpeedIncrease.Location = new System.Drawing.Point(475, 178);
			this.btnSpeedIncrease.Name = "btnSpeedIncrease";
			this.btnSpeedIncrease.Size = new System.Drawing.Size(19, 23);
			this.btnSpeedIncrease.TabIndex = 64;
			this.btnSpeedIncrease.Text = "+";
			this.btnSpeedIncrease.UseVisualStyleBackColor = true;
			this.btnSpeedIncrease.Click += new System.EventHandler(this.btnSpeedIncrease_Click);
			// 
			// btnSpeedDecrease
			// 
			this.btnSpeedDecrease.Location = new System.Drawing.Point(505, 178);
			this.btnSpeedDecrease.Name = "btnSpeedDecrease";
			this.btnSpeedDecrease.Size = new System.Drawing.Size(19, 23);
			this.btnSpeedDecrease.TabIndex = 63;
			this.btnSpeedDecrease.Text = "-";
			this.btnSpeedDecrease.UseVisualStyleBackColor = true;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(530, 154);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(31, 13);
			this.label23.TabIndex = 68;
			this.label23.Text = "Cost ";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(530, 183);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(31, 13);
			this.label24.TabIndex = 67;
			this.label24.Text = "Cost ";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(530, 122);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(31, 13);
			this.label25.TabIndex = 66;
			this.label25.Text = "Cost ";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(530, 93);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(31, 13);
			this.label26.TabIndex = 65;
			this.label26.Text = "Cost ";
			// 
			// txtContactCost
			// 
			this.txtContactCost.Location = new System.Drawing.Point(560, 91);
			this.txtContactCost.Name = "txtContactCost";
			this.txtContactCost.Size = new System.Drawing.Size(29, 20);
			this.txtContactCost.TabIndex = 69;
			this.txtContactCost.Text = "10";
			// 
			// txtPowerCost
			// 
			this.txtPowerCost.Location = new System.Drawing.Point(560, 119);
			this.txtPowerCost.Name = "txtPowerCost";
			this.txtPowerCost.Size = new System.Drawing.Size(29, 20);
			this.txtPowerCost.TabIndex = 70;
			this.txtPowerCost.Text = "10";
			// 
			// txtEyeCost
			// 
			this.txtEyeCost.Location = new System.Drawing.Point(560, 151);
			this.txtEyeCost.Name = "txtEyeCost";
			this.txtEyeCost.Size = new System.Drawing.Size(29, 20);
			this.txtEyeCost.TabIndex = 71;
			this.txtEyeCost.Text = "10";
			// 
			// txtSpeedCost
			// 
			this.txtSpeedCost.Location = new System.Drawing.Point(560, 181);
			this.txtSpeedCost.Name = "txtSpeedCost";
			this.txtSpeedCost.Size = new System.Drawing.Size(29, 20);
			this.txtSpeedCost.TabIndex = 72;
			this.txtSpeedCost.Text = "10";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(595, 24);
			this.menuStrip1.TabIndex = 73;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.ClientSize = new System.Drawing.Size(595, 278);
			this.Controls.Add(this.txtSpeedCost);
			this.Controls.Add(this.txtEyeCost);
			this.Controls.Add(this.txtPowerCost);
			this.Controls.Add(this.txtContactCost);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.btnSpeedIncrease);
			this.Controls.Add(this.btnSpeedDecrease);
			this.Controls.Add(this.btnEyeIncrease);
			this.Controls.Add(this.btnEyeDecrease);
			this.Controls.Add(this.btnPowerIncrease);
			this.Controls.Add(this.btnPowerDecrease);
			this.Controls.Add(this.btnContactIncrease);
			this.Controls.Add(this.btnContactDecrease);
			this.Controls.Add(this.txtSpeedRating);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.txtEyeRating);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.txtContactRating);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.txtPowerRating);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtBatterLastName);
			this.Controls.Add(this.txtBatterNickname);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txtSkillPoints);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtBatterFirstName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtHBP);
			this.Controls.Add(this.txtStrikeouts);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.txtOBP);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtOPS);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtTotalBases);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtBA);
			this.Controls.Add(this.txtSLG);
			this.Controls.Add(this.txtHits);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDoubles);
			this.Controls.Add(this.txtHomeruns);
			this.Controls.Add(this.txtWalks);
			this.Controls.Add(this.txtTriples);
			this.Controls.Add(this.txtSingles);
			this.Controls.Add(this.txtOuts);
			this.Controls.Add(this.txtplateAppearances);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSwingResultCommentary);
			this.Controls.Add(this.lblResultFlavor);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSwing);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Play Ball!";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

	}
	#endregion
	public frmMain()
	{
		//=========== Program Initialize Step ============

		InitializeComponent();
	}
	[STAThread]
	public static void Main()
	{
		frmMain main = new frmMain();
		Application.Run(main);
	}


	clsBatterRatings newBatter = new clsBatterRatings();
	/*public int DetectHitStreak()
	{
	   
	}*/

	// declare statistcal variables
	int atBats;
	int plateAppearances = 0;
	int singles;
	int doubles;
	int triples;
	int homeruns;
	int walks;
	int outs;
	int totalBases;
	int hits;
	int strikeouts;
	int hitByPitch;
	decimal SLGPercentage;
	decimal onBasePercentage;
	decimal battingAverage;
	decimal OPSPercentage;


	// declare batter ratings
	const int HIDDEN_RATING = 50;  // 

	//  declare variable to return random result of at bat
	string swingResult;

	// declare counters for flavor text stats
	int hitStreakCounter = 0;
	int lastFiveAB = 0;
	int lastTenAB = 0;

	static Random randomFlavorNumber = new Random();

	bool milestoneComing = false;
	bool milestoneHere = false;

	string batterName;


	/**
	* Purpose: Get advanced stats based on at bat results.
	* 
	* Parameter list:  
	*      
	* Return value:
	*      
	**/
	private int GetStats()
	{
		atBats = plateAppearances - walks;
		hits = homeruns + singles + doubles + triples;
		totalBases = (homeruns * 4) + (triples * 3) + (doubles * 2) + singles;
		SLGPercentage = (decimal)totalBases / (decimal)plateAppearances;
		onBasePercentage = (decimal)(hits + walks + hitByPitch) / (decimal)(plateAppearances);
		if (atBats > 0)
		{
			battingAverage = (decimal)hits / (decimal)atBats; // avoid division by zero from first PA walk
		}
		else
		{
			battingAverage = 0;
		}
		OPSPercentage = onBasePercentage + SLGPercentage;
		return 0;

	}

	/**
	* Purpose: update labels and text boxes with statistic variables
	* 
	* Parameter list:  
	*      
	* Return value:
	*      
	**/
	private int DisplayStats()
	{
		lblSwingResultCommentary.Text = swingResult;
		txtplateAppearances.Text = plateAppearances.ToString();
		txtWalks.Text = walks.ToString();
		txtOuts.Text = outs.ToString();
		txtSingles.Text = singles.ToString();
		txtDoubles.Text = doubles.ToString();
		txtTriples.Text = triples.ToString();
		txtHomeruns.Text = homeruns.ToString();
		txtHits.Text = hits.ToString();
		txtTotalBases.Text = totalBases.ToString();
		txtBA.Text = battingAverage.ToString("#.000"); //append string to only show first three decimal places.
		txtOBP.Text = onBasePercentage.ToString("#.000");
		txtSLG.Text = SLGPercentage.ToString("#.000");
		txtOPS.Text = OPSPercentage.ToString("#.000");
		txtHBP.Text = hitByPitch.ToString();
		txtStrikeouts.Text = strikeouts.ToString();
		txtSkillPoints.Text = newBatter.SkillPoints.ToString();
		txtContactRating.Text = newBatter.ContactRating.ToString();
		txtPowerRating.Text = newBatter.PowerRating.ToString();
		txtEyeRating.Text = newBatter.EyeRating.ToString();
		txtSpeedRating.Text = newBatter.SpeedRating.ToString();

		return 0;
	}


	/**
	* Purpose: change flavor text based on approaching and reached stat milestones
	* 
	* Parameter list:  
	*      
	* Return value:
	*      
	**/
   /* private int CheckMilestones()
	{
		bool milestoneWatch = true;
		// Check for pertinent milestones
		if ((homeruns == 9 || homeruns == 49 || homeruns == 99 || homeruns == 249) && milestoneWatch == true)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is only one homerun away from number " 
				+ (homeruns + 1) + "! Wow!";
			return 1;
		}

		if (homeruns == 10 || homeruns == 50 || homeruns == 100 || homeruns == 250)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text ="Welp, there it goes! Homerun #" + (homeruns) + " for " 
				+ txtBatterNickname.Text + "!";
			milestoneWatch = false;
			return 1;
		}

		else if (hits == 4 || hits == 249 || hits == 499 || hits == 749)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is only one hit away from number " + (hits + 1) + "!";
			milestoneWatch = true;
			return 1;
		}

		else if (hits == 5 || hits == 250 || hits == 500 || hits == 750)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = "Remarkable. That's " + (hits) + " hits for " + batterName + ".";
			milestoneWatch = false;
			return 1;
		}

		else if (strikeouts == 9 || strikeouts == 99 || strikeouts == 224)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is on the cusp of strikeout number " 
				+ (strikeouts + 1) + "! Yikes...";
			milestoneWatch = true;
			return 1;
		}

		else if (strikeouts == 10 || strikeouts == 100 || strikeouts == 225)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = "Oh brother! That's " + (strikeouts) + " career strikeouts for "
				+ batterName +"...";
			milestoneWatch = true;
			return 1;
		}

		else
		{
			milestoneWatch = false;
			GenerateFlavorText();
			return 0;
		}  
	}*/

	private int GenerateFlavorText()
	{
		lblResultFlavor.Text = "";
		//****************************FLAVOR TEXT********************************
		// check for 3 or more hits in a row 


		if ((hitStreakCounter >= 3))
		{
			lblResultFlavor.Text = txtBatterFirstName.Text + " has hit safely in his last "
				+ hitStreakCounter.ToString() + " at bats!";
		}

		// check for proximity to statistical milestones
		else if (hits == 3 || hits == 8 || hits == 499 || hits == 749)
		{
			milestoneComing = true;
		}

		else if ((hits == 4 || hits == 9 || hits == 499 || hits == 749) && milestoneComing == true && milestoneHere == false)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is only one hit away from number " + (hits + 1) + "!";
			milestoneComing = false;
			milestoneHere = true;
		}

		else if ((hits == 5 || hits == 10 || hits == 500 || hits == 750) && milestoneComing == false && milestoneHere == true)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = "Remarkable. That's " + (hits) + " hits for " + batterName + ".";
			milestoneComing = false;
			milestoneHere = false;
		}
		
		else if (homeruns == 8 || homeruns == 48 || homeruns == 98 || homeruns == 248)
		{
			milestoneComing = true;
		}

		else if ((homeruns == 9 || homeruns == 49 || homeruns == 99 || homeruns == 249) && milestoneComing == true && milestoneHere == false)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is only one homerun away from number " 
				+ (homeruns + 1) + "! Wow!";
			milestoneComing = false;
			milestoneHere = true;
		}

		else if ((homeruns == 10 || homeruns == 50 || homeruns == 100 || homeruns == 250) && milestoneComing == false && milestoneHere == true)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text ="Welp, there it goes! Homerun #" + (homeruns) + " for \"" 
				+ txtBatterNickname.Text + "\"!";
			milestoneComing = false;
			milestoneHere = false;
		}
		
		else if (strikeouts == 8 || strikeouts == 98 || strikeouts == 223)
		{
			milestoneComing = true;
		}

		else if ((strikeouts == 9 || strikeouts == 99 || strikeouts == 224) && milestoneComing == true && milestoneHere == false)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = batterName + " is on the cusp of strikeout number " 
				+ (strikeouts + 1) + "! Yikes...";
			milestoneComing = false;
			milestoneHere = true;
		}

		else if ((strikeouts == 10 || strikeouts == 100 || strikeouts == 225) && milestoneComing == false && milestoneHere == true)
		{
			string batterName = txtBatterFirstName.Text.ToString();
			lblResultFlavor.Text = "Oh brother! That's " + (strikeouts) + " career strikeouts for "
				+ batterName +"...";
			milestoneComing = false;
			milestoneHere = false;
		}

		else if ((battingAverage >= .280M && plateAppearances > 25))
		{
			lblResultFlavor.Text = txtBatterFirstName.Text + " is hitting a scorching "
				+ battingAverage.ToString("#.000") + " overall!";
		}

		else if ((battingAverage <= .210M && plateAppearances > 25))
		{
			lblResultFlavor.Text = txtBatterFirstName.Text + " is hitting a torrid " 
				+ battingAverage.ToString("#.000") + " overall!";
		}

		else if ((milestoneComing == true))
		{
			lblResultFlavor.Text = "";
		}
		return 1;
	}

	private void btnStart_Click(object sender, EventArgs e)
	{
		lblResultFlavor.Text = "";
		batterName = txtBatterFirstName.Text + " " + txtBatterLastName.Text;
		this.txtBatterFirstName.ReadOnly = true;
		this.txtBatterLastName.ReadOnly = true;
		txtContactRating.Text = (newBatter.ContactRating + HIDDEN_RATING).ToString(); // mask true rating by adding 50
		txtPowerRating.Text = (newBatter.PowerRating + HIDDEN_RATING).ToString();
		txtSpeedRating.Text = (newBatter.SpeedRating + HIDDEN_RATING).ToString();
		txtEyeRating.Text = (newBatter.EyeRating + HIDDEN_RATING).ToString();
		int flavorTxtNumber = randomFlavorNumber.Next(0, 3);


		if (plateAppearances >= 7999) // game ends after 8000 plate appearances
		{
			this.btnSwing.Enabled = false;
		}

		switch (newBatter.Swing()) // determines at bat result based on random number bounds
		{
			case 1:
				plateAppearances++;
				singles++;
				hitStreakCounter++;
				// determine random flavor text
				if (flavorTxtNumber == 0)
				{
					swingResult = "That's a sharply grounded single down the first base line for " + batterName + ".";
				}

				else if (flavorTxtNumber == 1)
				{
					swingResult = String.Format("{0} hits a slow roller towards 3rd and squeezes out an infield single.",
					batterName);
				}

				else if (flavorTxtNumber == 2)
				{
					swingResult = "That's a tough single for " + batterName + ".";
				}

				else if (flavorTxtNumber == 3)
				{
					swingResult = "That's a hot single for " + batterName + ".";
				}

				else
				{
					swingResult = "That's a single for " + batterName + ".";
				}

				GetStats();
				DisplayStats();
				GenerateFlavorText();

				if (newBatter.SkillPoints >= newBatter.UpgradeCost)
				{
					btnContactIncrease.Enabled = true;
					btnPowerIncrease.Enabled = true;
					btnEyeIncrease.Enabled = true;
					btnSpeedIncrease.Enabled = true;
				}
				break;

			case 2:
				plateAppearances++;
				doubles++;
				hitStreakCounter++;
				swingResult = "That's a double for " + batterName + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();

				if (newBatter.SkillPoints >= newBatter.UpgradeCost)
				{
					btnContactIncrease.Enabled = true;
					btnPowerIncrease.Enabled = true;
					btnEyeIncrease.Enabled = true;
					btnSpeedIncrease.Enabled = true;
				}
				break;

			case 3:
				plateAppearances++;
				triples++;
				hitStreakCounter++;
				swingResult = "That's a triple for " + txtBatterFirstName.Text + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();

				if (newBatter.SkillPoints >= newBatter.UpgradeCost)
				{
					btnContactIncrease.Enabled = true;
					btnPowerIncrease.Enabled = true;
					btnEyeIncrease.Enabled = true;
					btnSpeedIncrease.Enabled = true;
				}
				break;

			case 4:
				plateAppearances++;
				homeruns++;
				hitStreakCounter++;
				swingResult = "That's a homerun from " + txtBatterFirstName.Text + " \"" + txtBatterNickname.Text + "\" " + txtBatterLastName.Text + "!";
				GetStats();
				DisplayStats();
				GenerateFlavorText();

				if (newBatter.SkillPoints >= newBatter.UpgradeCost)
				{
					btnContactIncrease.Enabled = true;
					btnPowerIncrease.Enabled = true;
					btnEyeIncrease.Enabled = true;
					btnSpeedIncrease.Enabled = true;
				}
				break;

			case 5:
				plateAppearances++;
				walks++;
				swingResult = "That's a walk for " + batterName + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();

				if (newBatter.SkillPoints >= newBatter.UpgradeCost)
				{
					btnContactIncrease.Enabled = true;
					btnPowerIncrease.Enabled = true;
					btnEyeIncrease.Enabled = true;
					btnSpeedIncrease.Enabled = true;
				}
				break;

			case 6:
				plateAppearances++;
				outs++;
				strikeouts++;
				hitStreakCounter = 0;
				swingResult = "That's a strikeout for " + batterName + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();
				break;

			case 7:
				plateAppearances++;
				outs++;
				hitStreakCounter = 0;
				swingResult = "That's an out for " + batterName + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();
				break;

			case 8:
				plateAppearances++;
				hitByPitch++;
				swingResult = "That's a hit by pitch. " + "Take your base " + txtBatterFirstName.Text  + ".";
				GetStats();
				DisplayStats();
				GenerateFlavorText();
				break;

			default:
				lblResultFlavor.Text = "WHAT HAPPENED";
				break;
		}

		// --------------- change text color based on batting average --------------------
		if (battingAverage >= .280M)
		{
			this.txtBA.ForeColor = System.Drawing.Color.Green;
		}

		else if (battingAverage >= .210M && battingAverage < .280M)
		{
			this.txtBA.ForeColor = System.Drawing.Color.Orange;
		}

		else if (battingAverage < .210M)
		{
			this.txtBA.ForeColor = System.Drawing.Color.Red;
		}
	}

	//=========== Program Termination Step ============

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}


	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//frmAbout frm = new frmAbout();
		//frm.ShowDialog();

	}

	private void closeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnContactIncrease_Click(object sender, EventArgs e)
	{
		if (newBatter.skillPoints >= newBatter.contactRatingCost)
		{
			newBatter.skillPoints = newBatter.skillPoints - newBatter.contactRatingCost;
			newBatter.contactRating = newBatter.contactRating + 1;
			DisplayStats();
		}
	}

	private void btnPowerIncrease_Click(object sender, EventArgs e)
	{
		if (newBatter.skillPoints >= newBatter.powerRatingCost)
		{
			newBatter.skillPoints = newBatter.skillPoints - newBatter.powerRatingCost;
			newBatter.powerRating = newBatter.powerRating + 1;
			DisplayStats();
		}
	}

	private void btnEyeIncrease_Click(object sender, EventArgs e)
	{
		if (newBatter.skillPoints >= newBatter.eyeRatingCost)
		{
			newBatter.skillPoints = newBatter.skillPoints - newBatter.eyeRatingCost;
			newBatter.eyeRating = newBatter.eyeRating + 1;
			DisplayStats();
		}
	}

	private void btnSpeedIncrease_Click(object sender, EventArgs e)
	{
		if (newBatter.skillPoints >= newBatter.speedRatingCost)
		{
			newBatter.skillPoints = newBatter.skillPoints - newBatter.speedRatingCost;
			newBatter.speedRating = newBatter.speedRating + 1;
			DisplayStats();
		}
	}
}