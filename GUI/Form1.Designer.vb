﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Door_Open_Label = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MFC_1_Read_Flow = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ActWattsTxt = New System.Windows.Forms.TextBox()
        Me.RF_Label = New System.Windows.Forms.Label()
        Me.RflWattsTxt = New System.Windows.Forms.TextBox()
        Me.Watts_Label = New System.Windows.Forms.Label()
        Me.PHTempTxt = New System.Windows.Forms.TextBox()
        Me.C_Label = New System.Windows.Forms.Label()
        Me.PH_Temp_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCascadeRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.EnableServiceMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetCTLToPLSimModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MBScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StageTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailedLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineerModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControllerStatusLEDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlasmaLEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MB_Tune_Label = New System.Windows.Forms.Label()
        Me.RecipeTunerTxt = New System.Windows.Forms.TextBox()
        Me.ActTunerTxt = New System.Windows.Forms.TextBox()
        Me.MB_Left_Arrow = New System.Windows.Forms.PictureBox()
        Me.MB_Right_Arrow = New System.Windows.Forms.PictureBox()
        Me.AxesXActual = New System.Windows.Forms.TextBox()
        Me.AxesYActual = New System.Windows.Forms.TextBox()
        Me.AxesZActual = New System.Windows.Forms.TextBox()
        Me.RecipeThicknessTxt = New System.Windows.Forms.TextBox()
        Me.RecipeGapTxt = New System.Windows.Forms.TextBox()
        Me.RecipeOverLapTxt = New System.Windows.Forms.TextBox()
        Me.RecipeSpeedTxt = New System.Windows.Forms.TextBox()
        Me.RecipeCyclesTxt = New System.Windows.Forms.TextBox()
        Me.NextStepTxtBox = New System.Windows.Forms.TextBox()
        Me.CurrentStepTxtBox = New System.Windows.Forms.TextBox()
        Me.MFC_4_Label = New System.Windows.Forms.Label()
        Me.MFC_3_Label = New System.Windows.Forms.Label()
        Me.MFC_2_Label = New System.Windows.Forms.Label()
        Me.MFC_1_Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Line_Label2 = New System.Windows.Forms.Label()
        Me.Line_Label3 = New System.Windows.Forms.Label()
        Me.RF_Radial = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.RunRcpBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InitAxesBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.RunScanBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.RecipeButtonPins = New Guna.UI2.WinForms.Guna2Button()
        Me.Line_Label4 = New System.Windows.Forms.Label()
        Me.ActiveRecipeName = New System.Windows.Forms.TextBox()
        Me.RF_Reflected_Label = New System.Windows.Forms.Label()
        Me.RF_Reflected_Radial = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.Watts2_Label = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.HomeAxesBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Com_Port_Label = New System.Windows.Forms.Label()
        Me.Start_Stop_Toggle = New System.Windows.Forms.CheckBox()
        Me.com_portBox = New System.Windows.Forms.ComboBox()
        Me.RecipeWattsTxt = New System.Windows.Forms.TextBox()
        Me.MFC_1_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.Temp_Radial = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.ProgressBar2 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.ProgressBar3 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Loaded_Progress_4_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_4_50 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Loaded_Progress_3_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_3_50 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Loaded_Progress_2_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_2_50 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Loaded_Progress_1_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_1_50 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MFC_2_Read_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_2_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_3_Read_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_3_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_4_Read_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_4_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.Loaded_Progress_2 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Loaded_Progress_1 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.AC_CODE = New System.Windows.Forms.Label()
        Me.RecipeCyclesTxt_OPER = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Vacbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PinsSquare = New System.Windows.Forms.Label()
        Me.Set_MFC_1_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Set_MFC_3_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Set_MFC_2_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Set_MFC_4_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.SetRecipeWattsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetRecipeTunerBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Loaded_Progress_3 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.SetTwoSpotBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetDiameterBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetThicknessBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetOverlapBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetGapBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetCyclesBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetSpeedBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.MB_Pos_Bar = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.Loaded_Progress_4 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LabelLock = New System.Windows.Forms.Label()
        Me.RecipeXMaxTxt = New System.Windows.Forms.TextBox()
        Me.RecipeXMinTxt = New System.Windows.Forms.TextBox()
        Me.RecipeYMaxTxt = New System.Windows.Forms.TextBox()
        Me.RecipeYMinTxt = New System.Windows.Forms.TextBox()
        Me.SetXMaxBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetYMaxBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetYMinBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SetXMinBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.ClearAbortbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Loaded_Progress_3_25 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_4_25 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_3_75 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_4_75 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_2_25 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_1_25 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_1_75 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_2_75 = New System.Windows.Forms.Label()
        Me.ChuckVacSquare = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.AutoVacSquare = New System.Windows.Forms.Label()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.DateTimeLabel1 = New System.Windows.Forms.Label()
        Me.EngLabel = New System.Windows.Forms.Label()
        Me.N2Purgelabel = New System.Windows.Forms.Label()
        Me.N2Purgebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PurgeOnLabel = New System.Windows.Forms.Label()
        Me.N2PurgeSquare = New System.Windows.Forms.Label()
        Me.BatchLoggingBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.BatchIDTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LaserSenseSquare = New System.Windows.Forms.Label()
        Me.ControllerLabel = New System.Windows.Forms.Label()
        Me.contollerONSquare = New System.Windows.Forms.Label()
        Me.CTLStatusLabel = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox7 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox8 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox9 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox10 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox11 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox12 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox13 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox14 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox15 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox16 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.AutoManBtn = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.auto_tune_label = New System.Windows.Forms.Label()
        Me.LEDTrackBar = New Guna.UI2.WinForms.Guna2TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_6_75 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_6_25 = New System.Windows.Forms.Label()
        Me.Set_MFC_6_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Set_MFC_5_Recipe_Button = New Guna.UI2.WinForms.Guna2Button()
        Me.Loaded_Progress_5 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Loaded_Progress_6 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.MFC_6_Read_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_6_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Loaded_Progress_5_0 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Loaded_Progress_6_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_6_50 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_6_0 = New System.Windows.Forms.Label()
        Me.ProgressBar6 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.MFC_6_Label = New System.Windows.Forms.Label()
        Me.MFC_5_Label = New System.Windows.Forms.Label()
        Me.MFC_5_Read_Flow = New System.Windows.Forms.TextBox()
        Me.MFC_5_Recipe_Flow = New System.Windows.Forms.TextBox()
        Me.Loaded_Progress_5_75 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_5_25 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_5_100 = New System.Windows.Forms.Label()
        Me.Loaded_Progress_5_50 = New System.Windows.Forms.Label()
        Me.ProgressBar5 = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PreBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PostBox = New System.Windows.Forms.TextBox()
        Me.EllipseScanBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DemoRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MB_Left_Arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MB_Right_Arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Door_Open_Label
        '
        Me.Door_Open_Label.AutoSize = True
        Me.Door_Open_Label.BackColor = System.Drawing.Color.White
        Me.Door_Open_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Door_Open_Label.Location = New System.Drawing.Point(1511, 517)
        Me.Door_Open_Label.Name = "Door_Open_Label"
        Me.Door_Open_Label.Size = New System.Drawing.Size(153, 25)
        Me.Door_Open_Label.TabIndex = 147
        Me.Door_Open_Label.Text = "DOORS OPEN"
        Me.Door_Open_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Door_Open_Label.Visible = False
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 57600
        '
        'MFC_1_Read_Flow
        '
        Me.MFC_1_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_1_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_1_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_1_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_1_Read_Flow.Location = New System.Drawing.Point(84, 736)
        Me.MFC_1_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_1_Read_Flow.Name = "MFC_1_Read_Flow"
        Me.MFC_1_Read_Flow.ReadOnly = True
        Me.MFC_1_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_1_Read_Flow.TabIndex = 16
        Me.MFC_1_Read_Flow.Text = "0.00"
        Me.MFC_1_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_1_Read_Flow.WordWrap = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ActWattsTxt
        '
        Me.ActWattsTxt.BackColor = System.Drawing.Color.White
        Me.ActWattsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActWattsTxt.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActWattsTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ActWattsTxt.Location = New System.Drawing.Point(954, 210)
        Me.ActWattsTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.ActWattsTxt.Name = "ActWattsTxt"
        Me.ActWattsTxt.ReadOnly = True
        Me.ActWattsTxt.Size = New System.Drawing.Size(104, 56)
        Me.ActWattsTxt.TabIndex = 16
        Me.ActWattsTxt.Text = "0"
        Me.ActWattsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ActWattsTxt.WordWrap = False
        '
        'RF_Label
        '
        Me.RF_Label.AutoSize = True
        Me.RF_Label.BackColor = System.Drawing.Color.White
        Me.RF_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RF_Label.Location = New System.Drawing.Point(949, 360)
        Me.RF_Label.Name = "RF_Label"
        Me.RF_Label.Size = New System.Drawing.Size(125, 25)
        Me.RF_Label.TabIndex = 13
        Me.RF_Label.Text = "RF POWER"
        '
        'RflWattsTxt
        '
        Me.RflWattsTxt.BackColor = System.Drawing.Color.White
        Me.RflWattsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RflWattsTxt.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RflWattsTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RflWattsTxt.Location = New System.Drawing.Point(956, 461)
        Me.RflWattsTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RflWattsTxt.Name = "RflWattsTxt"
        Me.RflWattsTxt.ReadOnly = True
        Me.RflWattsTxt.Size = New System.Drawing.Size(104, 56)
        Me.RflWattsTxt.TabIndex = 16
        Me.RflWattsTxt.Text = "0"
        Me.RflWattsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RflWattsTxt.WordWrap = False
        '
        'Watts_Label
        '
        Me.Watts_Label.AutoSize = True
        Me.Watts_Label.BackColor = System.Drawing.Color.White
        Me.Watts_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watts_Label.Location = New System.Drawing.Point(982, 269)
        Me.Watts_Label.Name = "Watts_Label"
        Me.Watts_Label.Size = New System.Drawing.Size(51, 20)
        Me.Watts_Label.TabIndex = 13
        Me.Watts_Label.Text = "Watts"
        '
        'PHTempTxt
        '
        Me.PHTempTxt.BackColor = System.Drawing.Color.White
        Me.PHTempTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PHTempTxt.Font = New System.Drawing.Font("Arial", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHTempTxt.Location = New System.Drawing.Point(1185, 455)
        Me.PHTempTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.PHTempTxt.MinimumSize = New System.Drawing.Size(38, 20)
        Me.PHTempTxt.Name = "PHTempTxt"
        Me.PHTempTxt.ReadOnly = True
        Me.PHTempTxt.Size = New System.Drawing.Size(130, 44)
        Me.PHTempTxt.TabIndex = 21
        Me.PHTempTxt.Text = "???"
        Me.PHTempTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PHTempTxt.WordWrap = False
        '
        'C_Label
        '
        Me.C_Label.AutoSize = True
        Me.C_Label.BackColor = System.Drawing.Color.White
        Me.C_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_Label.Location = New System.Drawing.Point(1238, 511)
        Me.C_Label.Name = "C_Label"
        Me.C_Label.Size = New System.Drawing.Size(27, 25)
        Me.C_Label.TabIndex = 13
        Me.C_Label.Text = "C"
        '
        'PH_Temp_Label
        '
        Me.PH_Temp_Label.AutoSize = True
        Me.PH_Temp_Label.BackColor = System.Drawing.Color.White
        Me.PH_Temp_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PH_Temp_Label.Location = New System.Drawing.Point(1176, 585)
        Me.PH_Temp_Label.Name = "PH_Temp_Label"
        Me.PH_Temp_Label.Size = New System.Drawing.Size(171, 25)
        Me.PH_Temp_Label.TabIndex = 13
        Me.PH_Temp_Label.Text = "TEMPERATURE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ServiceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(2065, 48)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildRecipeToolStripMenuItem, Me.OpenCascadeRecipeToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.EnableServiceMenuToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SetDefaultToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(112, 44)
        Me.FileToolStripMenuItem.Text = "&Recipe"
        '
        'BuildRecipeToolStripMenuItem
        '
        Me.BuildRecipeToolStripMenuItem.Name = "BuildRecipeToolStripMenuItem"
        Me.BuildRecipeToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.BuildRecipeToolStripMenuItem.Text = "Build Cascade Recipe"
        Me.BuildRecipeToolStripMenuItem.Visible = False
        '
        'OpenCascadeRecipeToolStripMenuItem
        '
        Me.OpenCascadeRecipeToolStripMenuItem.Name = "OpenCascadeRecipeToolStripMenuItem"
        Me.OpenCascadeRecipeToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.OpenCascadeRecipeToolStripMenuItem.Text = "Open Cascade Recipe"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(369, 6)
        '
        'EnableServiceMenuToolStripMenuItem
        '
        Me.EnableServiceMenuToolStripMenuItem.Name = "EnableServiceMenuToolStripMenuItem"
        Me.EnableServiceMenuToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.EnableServiceMenuToolStripMenuItem.Text = "Enable Service Menu"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'SetDefaultToolStripMenuItem
        '
        Me.SetDefaultToolStripMenuItem.Enabled = False
        Me.SetDefaultToolStripMenuItem.Name = "SetDefaultToolStripMenuItem"
        Me.SetDefaultToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.SetDefaultToolStripMenuItem.Text = "Set Default"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartAllToolStripMenuItem, Me.SetCTLToPLSimModeToolStripMenuItem, Me.MBScanToolStripMenuItem, Me.StageTestToolStripMenuItem, Me.EngineerModeToolStripMenuItem, Me.OperatorModeToolStripMenuItem, Me.ControllerStatusLEDSToolStripMenuItem, Me.PlasmaLEDToolStripMenuItem, Me.DemoRecipeToolStripMenuItem})
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(118, 44)
        Me.ServiceToolStripMenuItem.Text = "Service"
        Me.ServiceToolStripMenuItem.Visible = False
        '
        'RestartAllToolStripMenuItem
        '
        Me.RestartAllToolStripMenuItem.Name = "RestartAllToolStripMenuItem"
        Me.RestartAllToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.RestartAllToolStripMenuItem.Text = "Restart All"
        Me.RestartAllToolStripMenuItem.Visible = False
        '
        'SetCTLToPLSimModeToolStripMenuItem
        '
        Me.SetCTLToPLSimModeToolStripMenuItem.Name = "SetCTLToPLSimModeToolStripMenuItem"
        Me.SetCTLToPLSimModeToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.SetCTLToPLSimModeToolStripMenuItem.Text = "Set CTL to PL Sim Mode"
        Me.SetCTLToPLSimModeToolStripMenuItem.Visible = False
        '
        'MBScanToolStripMenuItem
        '
        Me.MBScanToolStripMenuItem.Enabled = False
        Me.MBScanToolStripMenuItem.Name = "MBScanToolStripMenuItem"
        Me.MBScanToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.MBScanToolStripMenuItem.Text = "MB Scan"
        Me.MBScanToolStripMenuItem.Visible = False
        '
        'StageTestToolStripMenuItem
        '
        Me.StageTestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.DetailedLogToolStripMenuItem, Me.TestZToolStripMenuItem})
        Me.StageTestToolStripMenuItem.Name = "StageTestToolStripMenuItem"
        Me.StageTestToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.StageTestToolStripMenuItem.Text = "Stage Test"
        Me.StageTestToolStripMenuItem.Visible = False
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(320, 44)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(320, 44)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'DetailedLogToolStripMenuItem
        '
        Me.DetailedLogToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.DetailedLogToolStripMenuItem.Name = "DetailedLogToolStripMenuItem"
        Me.DetailedLogToolStripMenuItem.Size = New System.Drawing.Size(320, 44)
        Me.DetailedLogToolStripMenuItem.Text = "Detailed Log: OFF"
        '
        'TestZToolStripMenuItem
        '
        Me.TestZToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.TestZToolStripMenuItem.Name = "TestZToolStripMenuItem"
        Me.TestZToolStripMenuItem.Size = New System.Drawing.Size(320, 44)
        Me.TestZToolStripMenuItem.Text = "Test Z: OFF"
        '
        'EngineerModeToolStripMenuItem
        '
        Me.EngineerModeToolStripMenuItem.Name = "EngineerModeToolStripMenuItem"
        Me.EngineerModeToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.EngineerModeToolStripMenuItem.Text = "Engineer Mode"
        '
        'OperatorModeToolStripMenuItem
        '
        Me.OperatorModeToolStripMenuItem.Name = "OperatorModeToolStripMenuItem"
        Me.OperatorModeToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.OperatorModeToolStripMenuItem.Text = "Operator Mode"
        '
        'ControllerStatusLEDSToolStripMenuItem
        '
        Me.ControllerStatusLEDSToolStripMenuItem.Name = "ControllerStatusLEDSToolStripMenuItem"
        Me.ControllerStatusLEDSToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.ControllerStatusLEDSToolStripMenuItem.Text = "Controller Status LEDS: OFF"
        Me.ControllerStatusLEDSToolStripMenuItem.Visible = False
        '
        'PlasmaLEDToolStripMenuItem
        '
        Me.PlasmaLEDToolStripMenuItem.Name = "PlasmaLEDToolStripMenuItem"
        Me.PlasmaLEDToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.PlasmaLEDToolStripMenuItem.Text = "Plasma LED"
        '
        'MB_Tune_Label
        '
        Me.MB_Tune_Label.AutoSize = True
        Me.MB_Tune_Label.BackColor = System.Drawing.Color.White
        Me.MB_Tune_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MB_Tune_Label.Location = New System.Drawing.Point(1188, 363)
        Me.MB_Tune_Label.Name = "MB_Tune_Label"
        Me.MB_Tune_Label.Size = New System.Drawing.Size(128, 25)
        Me.MB_Tune_Label.TabIndex = 13
        Me.MB_Tune_Label.Text = "MB TUNER "
        '
        'RecipeTunerTxt
        '
        Me.RecipeTunerTxt.BackColor = System.Drawing.Color.White
        Me.RecipeTunerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeTunerTxt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeTunerTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeTunerTxt.Location = New System.Drawing.Point(1207, 289)
        Me.RecipeTunerTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeTunerTxt.Name = "RecipeTunerTxt"
        Me.RecipeTunerTxt.ReadOnly = True
        Me.RecipeTunerTxt.Size = New System.Drawing.Size(82, 28)
        Me.RecipeTunerTxt.TabIndex = 16
        Me.RecipeTunerTxt.Text = "???"
        Me.RecipeTunerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeTunerTxt.WordWrap = False
        '
        'ActTunerTxt
        '
        Me.ActTunerTxt.BackColor = System.Drawing.Color.White
        Me.ActTunerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActTunerTxt.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActTunerTxt.ForeColor = System.Drawing.Color.Black
        Me.ActTunerTxt.Location = New System.Drawing.Point(1205, 221)
        Me.ActTunerTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.ActTunerTxt.Name = "ActTunerTxt"
        Me.ActTunerTxt.ReadOnly = True
        Me.ActTunerTxt.Size = New System.Drawing.Size(91, 41)
        Me.ActTunerTxt.TabIndex = 16
        Me.ActTunerTxt.Text = "0"
        Me.ActTunerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ActTunerTxt.WordWrap = False
        '
        'MB_Left_Arrow
        '
        Me.MB_Left_Arrow.BackColor = System.Drawing.Color.White
        Me.MB_Left_Arrow.Image = CType(resources.GetObject("MB_Left_Arrow.Image"), System.Drawing.Image)
        Me.MB_Left_Arrow.InitialImage = CType(resources.GetObject("MB_Left_Arrow.InitialImage"), System.Drawing.Image)
        Me.MB_Left_Arrow.Location = New System.Drawing.Point(1145, 317)
        Me.MB_Left_Arrow.Margin = New System.Windows.Forms.Padding(2)
        Me.MB_Left_Arrow.Name = "MB_Left_Arrow"
        Me.MB_Left_Arrow.Size = New System.Drawing.Size(61, 48)
        Me.MB_Left_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MB_Left_Arrow.TabIndex = 17
        Me.MB_Left_Arrow.TabStop = False
        Me.MB_Left_Arrow.Visible = False
        '
        'MB_Right_Arrow
        '
        Me.MB_Right_Arrow.Image = CType(resources.GetObject("MB_Right_Arrow.Image"), System.Drawing.Image)
        Me.MB_Right_Arrow.InitialImage = CType(resources.GetObject("MB_Right_Arrow.InitialImage"), System.Drawing.Image)
        Me.MB_Right_Arrow.Location = New System.Drawing.Point(1293, 317)
        Me.MB_Right_Arrow.Margin = New System.Windows.Forms.Padding(2)
        Me.MB_Right_Arrow.Name = "MB_Right_Arrow"
        Me.MB_Right_Arrow.Size = New System.Drawing.Size(61, 48)
        Me.MB_Right_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MB_Right_Arrow.TabIndex = 17
        Me.MB_Right_Arrow.TabStop = False
        Me.MB_Right_Arrow.Visible = False
        '
        'AxesXActual
        '
        Me.AxesXActual.BackColor = System.Drawing.Color.White
        Me.AxesXActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AxesXActual.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxesXActual.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.AxesXActual.Location = New System.Drawing.Point(941, 885)
        Me.AxesXActual.Margin = New System.Windows.Forms.Padding(2)
        Me.AxesXActual.Name = "AxesXActual"
        Me.AxesXActual.ReadOnly = True
        Me.AxesXActual.Size = New System.Drawing.Size(104, 32)
        Me.AxesXActual.TabIndex = 25
        Me.AxesXActual.Text = "???"
        Me.AxesXActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AxesXActual.Visible = False
        Me.AxesXActual.WordWrap = False
        '
        'AxesYActual
        '
        Me.AxesYActual.BackColor = System.Drawing.Color.White
        Me.AxesYActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AxesYActual.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxesYActual.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.AxesYActual.Location = New System.Drawing.Point(1150, 885)
        Me.AxesYActual.Margin = New System.Windows.Forms.Padding(2)
        Me.AxesYActual.Name = "AxesYActual"
        Me.AxesYActual.ReadOnly = True
        Me.AxesYActual.Size = New System.Drawing.Size(107, 32)
        Me.AxesYActual.TabIndex = 25
        Me.AxesYActual.Text = "???"
        Me.AxesYActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AxesYActual.Visible = False
        Me.AxesYActual.WordWrap = False
        '
        'AxesZActual
        '
        Me.AxesZActual.BackColor = System.Drawing.Color.White
        Me.AxesZActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AxesZActual.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AxesZActual.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.AxesZActual.Location = New System.Drawing.Point(1395, 886)
        Me.AxesZActual.Margin = New System.Windows.Forms.Padding(2)
        Me.AxesZActual.Name = "AxesZActual"
        Me.AxesZActual.ReadOnly = True
        Me.AxesZActual.Size = New System.Drawing.Size(107, 32)
        Me.AxesZActual.TabIndex = 25
        Me.AxesZActual.Text = "???"
        Me.AxesZActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AxesZActual.Visible = False
        Me.AxesZActual.WordWrap = False
        '
        'RecipeThicknessTxt
        '
        Me.RecipeThicknessTxt.BackColor = System.Drawing.Color.White
        Me.RecipeThicknessTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeThicknessTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeThicknessTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeThicknessTxt.Location = New System.Drawing.Point(931, 778)
        Me.RecipeThicknessTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeThicknessTxt.Name = "RecipeThicknessTxt"
        Me.RecipeThicknessTxt.ReadOnly = True
        Me.RecipeThicknessTxt.Size = New System.Drawing.Size(66, 25)
        Me.RecipeThicknessTxt.TabIndex = 16
        Me.RecipeThicknessTxt.Text = "1"
        Me.RecipeThicknessTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeThicknessTxt.Visible = False
        Me.RecipeThicknessTxt.WordWrap = False
        '
        'RecipeGapTxt
        '
        Me.RecipeGapTxt.BackColor = System.Drawing.Color.White
        Me.RecipeGapTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeGapTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeGapTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeGapTxt.Location = New System.Drawing.Point(1068, 778)
        Me.RecipeGapTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeGapTxt.Name = "RecipeGapTxt"
        Me.RecipeGapTxt.ReadOnly = True
        Me.RecipeGapTxt.Size = New System.Drawing.Size(66, 25)
        Me.RecipeGapTxt.TabIndex = 16
        Me.RecipeGapTxt.Text = "1"
        Me.RecipeGapTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeGapTxt.Visible = False
        Me.RecipeGapTxt.WordWrap = False
        '
        'RecipeOverLapTxt
        '
        Me.RecipeOverLapTxt.BackColor = System.Drawing.Color.White
        Me.RecipeOverLapTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeOverLapTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeOverLapTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeOverLapTxt.Location = New System.Drawing.Point(1204, 779)
        Me.RecipeOverLapTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeOverLapTxt.Name = "RecipeOverLapTxt"
        Me.RecipeOverLapTxt.ReadOnly = True
        Me.RecipeOverLapTxt.Size = New System.Drawing.Size(66, 25)
        Me.RecipeOverLapTxt.TabIndex = 16
        Me.RecipeOverLapTxt.Text = "0"
        Me.RecipeOverLapTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeOverLapTxt.Visible = False
        Me.RecipeOverLapTxt.WordWrap = False
        '
        'RecipeSpeedTxt
        '
        Me.RecipeSpeedTxt.BackColor = System.Drawing.Color.White
        Me.RecipeSpeedTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeSpeedTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeSpeedTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeSpeedTxt.Location = New System.Drawing.Point(1343, 779)
        Me.RecipeSpeedTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeSpeedTxt.Name = "RecipeSpeedTxt"
        Me.RecipeSpeedTxt.ReadOnly = True
        Me.RecipeSpeedTxt.Size = New System.Drawing.Size(66, 25)
        Me.RecipeSpeedTxt.TabIndex = 16
        Me.RecipeSpeedTxt.Text = "1"
        Me.RecipeSpeedTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeSpeedTxt.Visible = False
        Me.RecipeSpeedTxt.WordWrap = False
        '
        'RecipeCyclesTxt
        '
        Me.RecipeCyclesTxt.BackColor = System.Drawing.Color.White
        Me.RecipeCyclesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeCyclesTxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeCyclesTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeCyclesTxt.Location = New System.Drawing.Point(1476, 777)
        Me.RecipeCyclesTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeCyclesTxt.Name = "RecipeCyclesTxt"
        Me.RecipeCyclesTxt.ReadOnly = True
        Me.RecipeCyclesTxt.Size = New System.Drawing.Size(66, 25)
        Me.RecipeCyclesTxt.TabIndex = 16
        Me.RecipeCyclesTxt.Text = "1"
        Me.RecipeCyclesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeCyclesTxt.Visible = False
        Me.RecipeCyclesTxt.WordWrap = False
        '
        'NextStepTxtBox
        '
        Me.NextStepTxtBox.BackColor = System.Drawing.Color.White
        Me.NextStepTxtBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextStepTxtBox.ForeColor = System.Drawing.Color.Red
        Me.NextStepTxtBox.Location = New System.Drawing.Point(917, 715)
        Me.NextStepTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NextStepTxtBox.Name = "NextStepTxtBox"
        Me.NextStepTxtBox.ReadOnly = True
        Me.NextStepTxtBox.Size = New System.Drawing.Size(625, 32)
        Me.NextStepTxtBox.TabIndex = 16
        Me.NextStepTxtBox.Text = "Initialize Stage"
        Me.NextStepTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NextStepTxtBox.Visible = False
        Me.NextStepTxtBox.WordWrap = False
        '
        'CurrentStepTxtBox
        '
        Me.CurrentStepTxtBox.BackColor = System.Drawing.Color.White
        Me.CurrentStepTxtBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStepTxtBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentStepTxtBox.Location = New System.Drawing.Point(917, 673)
        Me.CurrentStepTxtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentStepTxtBox.Name = "CurrentStepTxtBox"
        Me.CurrentStepTxtBox.ReadOnly = True
        Me.CurrentStepTxtBox.Size = New System.Drawing.Size(625, 32)
        Me.CurrentStepTxtBox.TabIndex = 16
        Me.CurrentStepTxtBox.Text = "Stage Not Initialized"
        Me.CurrentStepTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CurrentStepTxtBox.Visible = False
        Me.CurrentStepTxtBox.WordWrap = False
        '
        'MFC_4_Label
        '
        Me.MFC_4_Label.AutoSize = True
        Me.MFC_4_Label.BackColor = System.Drawing.Color.White
        Me.MFC_4_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_4_Label.Location = New System.Drawing.Point(479, 138)
        Me.MFC_4_Label.Name = "MFC_4_Label"
        Me.MFC_4_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_4_Label.TabIndex = 13
        Me.MFC_4_Label.Text = "MFC#4"
        '
        'MFC_3_Label
        '
        Me.MFC_3_Label.AutoSize = True
        Me.MFC_3_Label.BackColor = System.Drawing.Color.White
        Me.MFC_3_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_3_Label.Location = New System.Drawing.Point(340, 138)
        Me.MFC_3_Label.Name = "MFC_3_Label"
        Me.MFC_3_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_3_Label.TabIndex = 13
        Me.MFC_3_Label.Text = "MFC#3"
        '
        'MFC_2_Label
        '
        Me.MFC_2_Label.AutoSize = True
        Me.MFC_2_Label.BackColor = System.Drawing.Color.White
        Me.MFC_2_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_2_Label.Location = New System.Drawing.Point(197, 138)
        Me.MFC_2_Label.Name = "MFC_2_Label"
        Me.MFC_2_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_2_Label.TabIndex = 13
        Me.MFC_2_Label.Text = "MFC#2"
        '
        'MFC_1_Label
        '
        Me.MFC_1_Label.AutoSize = True
        Me.MFC_1_Label.BackColor = System.Drawing.Color.White
        Me.MFC_1_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_1_Label.Location = New System.Drawing.Point(66, 138)
        Me.MFC_1_Label.Name = "MFC_1_Label"
        Me.MFC_1_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_1_Label.TabIndex = 13
        Me.MFC_1_Label.Text = "MFC#1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(897, 629)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Stage Status / Information "
        Me.Label4.Visible = False
        '
        'Line_Label2
        '
        Me.Line_Label2.AutoSize = True
        Me.Line_Label2.BackColor = System.Drawing.Color.White
        Me.Line_Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Line_Label2.Location = New System.Drawing.Point(1376, 112)
        Me.Line_Label2.MaximumSize = New System.Drawing.Size(1020, 2)
        Me.Line_Label2.MinimumSize = New System.Drawing.Size(2, 505)
        Me.Line_Label2.Name = "Line_Label2"
        Me.Line_Label2.Size = New System.Drawing.Size(2, 505)
        Me.Line_Label2.TabIndex = 57
        Me.Line_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Line_Label2.Visible = False
        '
        'Line_Label3
        '
        Me.Line_Label3.AutoSize = True
        Me.Line_Label3.BackColor = System.Drawing.Color.White
        Me.Line_Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Line_Label3.Location = New System.Drawing.Point(882, 111)
        Me.Line_Label3.MaximumSize = New System.Drawing.Size(1020, 2)
        Me.Line_Label3.MinimumSize = New System.Drawing.Size(2, 1000)
        Me.Line_Label3.Name = "Line_Label3"
        Me.Line_Label3.Size = New System.Drawing.Size(2, 1000)
        Me.Line_Label3.TabIndex = 58
        Me.Line_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RF_Radial
        '
        Me.RF_Radial.ArrowThickness = 8
        Me.RF_Radial.ArrowVisible = False
        Me.RF_Radial.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.RF_Radial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.RF_Radial.Location = New System.Drawing.Point(893, 136)
        Me.RF_Radial.MinimumSize = New System.Drawing.Size(30, 30)
        Me.RF_Radial.Name = "RF_Radial"
        Me.RF_Radial.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RF_Radial.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RF_Radial.ProgressThickness = 35
        Me.RF_Radial.ShowPercentage = False
        Me.RF_Radial.Size = New System.Drawing.Size(224, 224)
        Me.RF_Radial.TabIndex = 59
        '
        'RunRcpBtn
        '
        Me.RunRcpBtn.AutoRoundedCorners = True
        Me.RunRcpBtn.BackColor = System.Drawing.Color.Transparent
        Me.RunRcpBtn.BorderRadius = 48
        Me.RunRcpBtn.CheckedState.Parent = Me.RunRcpBtn
        Me.RunRcpBtn.CustomImages.Parent = Me.RunRcpBtn
        Me.RunRcpBtn.Enabled = False
        Me.RunRcpBtn.FillColor = System.Drawing.Color.LightSlateGray
        Me.RunRcpBtn.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunRcpBtn.ForeColor = System.Drawing.Color.White
        Me.RunRcpBtn.HoverState.Parent = Me.RunRcpBtn
        Me.RunRcpBtn.Location = New System.Drawing.Point(276, 831)
        Me.RunRcpBtn.Name = "RunRcpBtn"
        Me.RunRcpBtn.ShadowDecoration.BorderRadius = 0
        Me.RunRcpBtn.ShadowDecoration.Color = System.Drawing.Color.White
        Me.RunRcpBtn.ShadowDecoration.Enabled = True
        Me.RunRcpBtn.ShadowDecoration.Parent = Me.RunRcpBtn
        Me.RunRcpBtn.Size = New System.Drawing.Size(312, 99)
        Me.RunRcpBtn.TabIndex = 61
        Me.RunRcpBtn.Text = "START PLASMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Gas / Plasma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(897, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Power / Tuner / Temperature "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1384, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Stage Controls "
        Me.Label3.Visible = False
        '
        'InitAxesBtn
        '
        Me.InitAxesBtn.AutoRoundedCorners = True
        Me.InitAxesBtn.BorderRadius = 24
        Me.InitAxesBtn.CheckedState.Parent = Me.InitAxesBtn
        Me.InitAxesBtn.CustomImages.Parent = Me.InitAxesBtn
        Me.InitAxesBtn.Enabled = False
        Me.InitAxesBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.InitAxesBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitAxesBtn.ForeColor = System.Drawing.Color.White
        Me.InitAxesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.InitAxesBtn.HoverState.Parent = Me.InitAxesBtn
        Me.InitAxesBtn.Location = New System.Drawing.Point(1565, 247)
        Me.InitAxesBtn.Name = "InitAxesBtn"
        Me.InitAxesBtn.ShadowDecoration.BorderRadius = 27
        Me.InitAxesBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.InitAxesBtn.ShadowDecoration.Parent = Me.InitAxesBtn
        Me.InitAxesBtn.Size = New System.Drawing.Size(167, 50)
        Me.InitAxesBtn.TabIndex = 66
        Me.InitAxesBtn.Text = "INITIALIZE STAGE"
        Me.InitAxesBtn.Visible = False
        '
        'RunScanBtn
        '
        Me.RunScanBtn.AutoRoundedCorners = True
        Me.RunScanBtn.BorderRadius = 24
        Me.RunScanBtn.CheckedState.Parent = Me.RunScanBtn
        Me.RunScanBtn.CustomImages.Parent = Me.RunScanBtn
        Me.RunScanBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RunScanBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunScanBtn.ForeColor = System.Drawing.Color.White
        Me.RunScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RunScanBtn.HoverState.Parent = Me.RunScanBtn
        Me.RunScanBtn.Location = New System.Drawing.Point(1387, 140)
        Me.RunScanBtn.Name = "RunScanBtn"
        Me.RunScanBtn.ShadowDecoration.BorderRadius = 27
        Me.RunScanBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RunScanBtn.ShadowDecoration.Parent = Me.RunScanBtn
        Me.RunScanBtn.Size = New System.Drawing.Size(174, 50)
        Me.RunScanBtn.TabIndex = 67
        Me.RunScanBtn.Text = "RUN SCAN"
        Me.RunScanBtn.Visible = False
        '
        'RecipeButtonPins
        '
        Me.RecipeButtonPins.AutoRoundedCorners = True
        Me.RecipeButtonPins.BorderRadius = 24
        Me.RecipeButtonPins.CheckedState.Parent = Me.RecipeButtonPins
        Me.RecipeButtonPins.CustomImages.Parent = Me.RecipeButtonPins
        Me.RecipeButtonPins.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RecipeButtonPins.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeButtonPins.ForeColor = System.Drawing.Color.White
        Me.RecipeButtonPins.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RecipeButtonPins.HoverState.Parent = Me.RecipeButtonPins
        Me.RecipeButtonPins.Location = New System.Drawing.Point(1387, 193)
        Me.RecipeButtonPins.Name = "RecipeButtonPins"
        Me.RecipeButtonPins.ShadowDecoration.BorderRadius = 27
        Me.RecipeButtonPins.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.RecipeButtonPins.ShadowDecoration.Parent = Me.RecipeButtonPins
        Me.RecipeButtonPins.Size = New System.Drawing.Size(174, 50)
        Me.RecipeButtonPins.TabIndex = 69
        Me.RecipeButtonPins.Text = "  LIFT PINS"
        Me.RecipeButtonPins.Visible = False
        '
        'Line_Label4
        '
        Me.Line_Label4.AutoSize = True
        Me.Line_Label4.BackColor = System.Drawing.Color.White
        Me.Line_Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Line_Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Line_Label4.Location = New System.Drawing.Point(882, 617)
        Me.Line_Label4.MaximumSize = New System.Drawing.Size(500, 2)
        Me.Line_Label4.MinimumSize = New System.Drawing.Size(900, 2)
        Me.Line_Label4.Name = "Line_Label4"
        Me.Line_Label4.Size = New System.Drawing.Size(900, 2)
        Me.Line_Label4.TabIndex = 71
        Me.Line_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Line_Label4.Visible = False
        '
        'ActiveRecipeName
        '
        Me.ActiveRecipeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ActiveRecipeName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveRecipeName.Location = New System.Drawing.Point(65, 63)
        Me.ActiveRecipeName.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveRecipeName.MinimumSize = New System.Drawing.Size(38, 20)
        Me.ActiveRecipeName.Name = "ActiveRecipeName"
        Me.ActiveRecipeName.ReadOnly = True
        Me.ActiveRecipeName.Size = New System.Drawing.Size(422, 35)
        Me.ActiveRecipeName.TabIndex = 15
        Me.ActiveRecipeName.Text = "Active Recipe"
        Me.ActiveRecipeName.WordWrap = False
        '
        'RF_Reflected_Label
        '
        Me.RF_Reflected_Label.AutoSize = True
        Me.RF_Reflected_Label.BackColor = System.Drawing.Color.White
        Me.RF_Reflected_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RF_Reflected_Label.Location = New System.Drawing.Point(926, 585)
        Me.RF_Reflected_Label.Name = "RF_Reflected_Label"
        Me.RF_Reflected_Label.Size = New System.Drawing.Size(171, 25)
        Me.RF_Reflected_Label.TabIndex = 73
        Me.RF_Reflected_Label.Text = "RF REFLECTED"
        '
        'RF_Reflected_Radial
        '
        Me.RF_Reflected_Radial.ArrowThickness = 8
        Me.RF_Reflected_Radial.ArrowVisible = False
        Me.RF_Reflected_Radial.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.RF_Reflected_Radial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.RF_Reflected_Radial.Location = New System.Drawing.Point(896, 379)
        Me.RF_Reflected_Radial.MinimumSize = New System.Drawing.Size(30, 30)
        Me.RF_Reflected_Radial.Name = "RF_Reflected_Radial"
        Me.RF_Reflected_Radial.ProgressColor = System.Drawing.Color.Yellow
        Me.RF_Reflected_Radial.ProgressColor2 = System.Drawing.Color.Yellow
        Me.RF_Reflected_Radial.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.RF_Reflected_Radial.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.RF_Reflected_Radial.ProgressThickness = 30
        Me.RF_Reflected_Radial.ShowPercentage = False
        Me.RF_Reflected_Radial.Size = New System.Drawing.Size(224, 224)
        Me.RF_Reflected_Radial.TabIndex = 75
        '
        'Watts2_Label
        '
        Me.Watts2_Label.AutoSize = True
        Me.Watts2_Label.BackColor = System.Drawing.Color.White
        Me.Watts2_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watts2_Label.Location = New System.Drawing.Point(982, 515)
        Me.Watts2_Label.Name = "Watts2_Label"
        Me.Watts2_Label.Size = New System.Drawing.Size(51, 20)
        Me.Watts2_Label.TabIndex = 77
        Me.Watts2_Label.Text = "Watts"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.AutoRoundedCorners = True
        Me.ProgressBar4.BorderRadius = 24
        Me.ProgressBar4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar4.Location = New System.Drawing.Point(508, 175)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar4.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar4.ShadowDecoration.Parent = Me.ProgressBar4
        Me.ProgressBar4.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar4.TabIndex = 81
        Me.ProgressBar4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'HomeAxesBtn
        '
        Me.HomeAxesBtn.AutoRoundedCorners = True
        Me.HomeAxesBtn.BorderRadius = 24
        Me.HomeAxesBtn.CheckedState.Parent = Me.HomeAxesBtn
        Me.HomeAxesBtn.CustomImages.Parent = Me.HomeAxesBtn
        Me.HomeAxesBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.HomeAxesBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeAxesBtn.ForeColor = System.Drawing.Color.White
        Me.HomeAxesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.HomeAxesBtn.HoverState.Parent = Me.HomeAxesBtn
        Me.HomeAxesBtn.Location = New System.Drawing.Point(1387, 246)
        Me.HomeAxesBtn.Name = "HomeAxesBtn"
        Me.HomeAxesBtn.ShadowDecoration.BorderRadius = 27
        Me.HomeAxesBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.HomeAxesBtn.ShadowDecoration.Parent = Me.HomeAxesBtn
        Me.HomeAxesBtn.Size = New System.Drawing.Size(174, 50)
        Me.HomeAxesBtn.TabIndex = 82
        Me.HomeAxesBtn.Text = "LOAD POSITION"
        Me.HomeAxesBtn.Visible = False
        '
        'Com_Port_Label
        '
        Me.Com_Port_Label.AutoSize = True
        Me.Com_Port_Label.BackColor = System.Drawing.Color.White
        Me.Com_Port_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Com_Port_Label.Location = New System.Drawing.Point(423, 8)
        Me.Com_Port_Label.Name = "Com_Port_Label"
        Me.Com_Port_Label.Size = New System.Drawing.Size(114, 29)
        Me.Com_Port_Label.TabIndex = 13
        Me.Com_Port_Label.Text = "Com Port"
        Me.Com_Port_Label.Visible = False
        '
        'Start_Stop_Toggle
        '
        Me.Start_Stop_Toggle.Appearance = System.Windows.Forms.Appearance.Button
        Me.Start_Stop_Toggle.BackColor = System.Drawing.Color.Red
        Me.Start_Stop_Toggle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Start_Stop_Toggle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Stop_Toggle.Location = New System.Drawing.Point(674, 5)
        Me.Start_Stop_Toggle.Margin = New System.Windows.Forms.Padding(2)
        Me.Start_Stop_Toggle.Name = "Start_Stop_Toggle"
        Me.Start_Stop_Toggle.Size = New System.Drawing.Size(121, 37)
        Me.Start_Stop_Toggle.TabIndex = 14
        Me.Start_Stop_Toggle.Text = "CONNECT"
        Me.Start_Stop_Toggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Start_Stop_Toggle.UseVisualStyleBackColor = False
        Me.Start_Stop_Toggle.Visible = False
        '
        'com_portBox
        '
        Me.com_portBox.BackColor = System.Drawing.Color.White
        Me.com_portBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.com_portBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_portBox.FormattingEnabled = True
        Me.com_portBox.Location = New System.Drawing.Point(543, 5)
        Me.com_portBox.Name = "com_portBox"
        Me.com_portBox.Size = New System.Drawing.Size(126, 37)
        Me.com_portBox.TabIndex = 3
        Me.com_portBox.Visible = False
        '
        'RecipeWattsTxt
        '
        Me.RecipeWattsTxt.BackColor = System.Drawing.Color.White
        Me.RecipeWattsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeWattsTxt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeWattsTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeWattsTxt.Location = New System.Drawing.Point(971, 289)
        Me.RecipeWattsTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeWattsTxt.Name = "RecipeWattsTxt"
        Me.RecipeWattsTxt.ReadOnly = True
        Me.RecipeWattsTxt.Size = New System.Drawing.Size(71, 28)
        Me.RecipeWattsTxt.TabIndex = 16
        Me.RecipeWattsTxt.Text = "???"
        Me.RecipeWattsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeWattsTxt.WordWrap = False
        '
        'MFC_1_Recipe_Flow
        '
        Me.MFC_1_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_1_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_1_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_1_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_1_Recipe_Flow.Location = New System.Drawing.Point(84, 761)
        Me.MFC_1_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_1_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_1_Recipe_Flow.Name = "MFC_1_Recipe_Flow"
        Me.MFC_1_Recipe_Flow.ReadOnly = True
        Me.MFC_1_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_1_Recipe_Flow.TabIndex = 15
        Me.MFC_1_Recipe_Flow.Text = "???"
        Me.MFC_1_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_1_Recipe_Flow.WordWrap = False
        '
        'Temp_Radial
        '
        Me.Temp_Radial.ArrowThickness = 6
        Me.Temp_Radial.ArrowVisible = False
        Me.Temp_Radial.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.Temp_Radial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Temp_Radial.Location = New System.Drawing.Point(1138, 379)
        Me.Temp_Radial.MinimumSize = New System.Drawing.Size(30, 30)
        Me.Temp_Radial.Name = "Temp_Radial"
        Me.Temp_Radial.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.Temp_Radial.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.Temp_Radial.ShowPercentage = False
        Me.Temp_Radial.Size = New System.Drawing.Size(224, 224)
        Me.Temp_Radial.TabIndex = 83
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(485, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AutoRoundedCorners = True
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.BorderRadius = 24
        Me.ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar1.Location = New System.Drawing.Point(88, 175)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar1.ShadowDecoration.Parent = Me.ProgressBar1
        Me.ProgressBar1.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 78
        Me.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ProgressBar2
        '
        Me.ProgressBar2.AutoRoundedCorners = True
        Me.ProgressBar2.BorderRadius = 24
        Me.ProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar2.Location = New System.Drawing.Point(228, 175)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar2.ShadowDecoration.Parent = Me.ProgressBar2
        Me.ProgressBar2.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 79
        Me.ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ProgressBar3
        '
        Me.ProgressBar3.AutoRoundedCorners = True
        Me.ProgressBar3.BorderRadius = 24
        Me.ProgressBar3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar3.Location = New System.Drawing.Point(367, 175)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar3.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar3.ShadowDecoration.Parent = Me.ProgressBar3
        Me.ProgressBar3.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar3.TabIndex = 80
        Me.ProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Loaded_Progress_4_100
        '
        Me.Loaded_Progress_4_100.AutoSize = True
        Me.Loaded_Progress_4_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_4_100.Location = New System.Drawing.Point(437, 175)
        Me.Loaded_Progress_4_100.Name = "Loaded_Progress_4_100"
        Me.Loaded_Progress_4_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_4_100.TabIndex = 87
        Me.Loaded_Progress_4_100.Text = "0.000"
        '
        'Loaded_Progress_4_50
        '
        Me.Loaded_Progress_4_50.AutoSize = True
        Me.Loaded_Progress_4_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_4_50.Location = New System.Drawing.Point(438, 445)
        Me.Loaded_Progress_4_50.Name = "Loaded_Progress_4_50"
        Me.Loaded_Progress_4_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_4_50.TabIndex = 88
        Me.Loaded_Progress_4_50.Text = "0.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(426, 717)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "0 SLPM"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(345, 175)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox4.TabIndex = 94
        Me.PictureBox4.TabStop = False
        '
        'Loaded_Progress_3_100
        '
        Me.Loaded_Progress_3_100.AutoSize = True
        Me.Loaded_Progress_3_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_3_100.Location = New System.Drawing.Point(296, 175)
        Me.Loaded_Progress_3_100.Name = "Loaded_Progress_3_100"
        Me.Loaded_Progress_3_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_3_100.TabIndex = 95
        Me.Loaded_Progress_3_100.Text = "0.000"
        '
        'Loaded_Progress_3_50
        '
        Me.Loaded_Progress_3_50.AutoSize = True
        Me.Loaded_Progress_3_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_3_50.Location = New System.Drawing.Point(298, 445)
        Me.Loaded_Progress_3_50.Name = "Loaded_Progress_3_50"
        Me.Loaded_Progress_3_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_3_50.TabIndex = 96
        Me.Loaded_Progress_3_50.Text = "0.000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 717)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "0 SLPM"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(204, 175)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox5.TabIndex = 99
        Me.PictureBox5.TabStop = False
        '
        'Loaded_Progress_2_100
        '
        Me.Loaded_Progress_2_100.AutoSize = True
        Me.Loaded_Progress_2_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_2_100.Location = New System.Drawing.Point(157, 175)
        Me.Loaded_Progress_2_100.Name = "Loaded_Progress_2_100"
        Me.Loaded_Progress_2_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_2_100.TabIndex = 100
        Me.Loaded_Progress_2_100.Text = "0.000"
        '
        'Loaded_Progress_2_50
        '
        Me.Loaded_Progress_2_50.AutoSize = True
        Me.Loaded_Progress_2_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_2_50.Location = New System.Drawing.Point(157, 445)
        Me.Loaded_Progress_2_50.Name = "Loaded_Progress_2_50"
        Me.Loaded_Progress_2_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_2_50.TabIndex = 101
        Me.Loaded_Progress_2_50.Text = "0.000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(146, 717)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "0 SLPM"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(65, 175)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox6.TabIndex = 104
        Me.PictureBox6.TabStop = False
        '
        'Loaded_Progress_1_100
        '
        Me.Loaded_Progress_1_100.AutoSize = True
        Me.Loaded_Progress_1_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_1_100.Location = New System.Drawing.Point(18, 175)
        Me.Loaded_Progress_1_100.Name = "Loaded_Progress_1_100"
        Me.Loaded_Progress_1_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_1_100.TabIndex = 105
        Me.Loaded_Progress_1_100.Text = "0.000"
        '
        'Loaded_Progress_1_50
        '
        Me.Loaded_Progress_1_50.AutoSize = True
        Me.Loaded_Progress_1_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_1_50.Location = New System.Drawing.Point(18, 445)
        Me.Loaded_Progress_1_50.Name = "Loaded_Progress_1_50"
        Me.Loaded_Progress_1_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_1_50.TabIndex = 106
        Me.Loaded_Progress_1_50.Text = "0.000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 717)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "0 SLPM"
        '
        'MFC_2_Read_Flow
        '
        Me.MFC_2_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_2_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_2_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_2_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_2_Read_Flow.Location = New System.Drawing.Point(226, 736)
        Me.MFC_2_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_2_Read_Flow.Name = "MFC_2_Read_Flow"
        Me.MFC_2_Read_Flow.ReadOnly = True
        Me.MFC_2_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_2_Read_Flow.TabIndex = 116
        Me.MFC_2_Read_Flow.Text = "0.00"
        Me.MFC_2_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_2_Read_Flow.WordWrap = False
        '
        'MFC_2_Recipe_Flow
        '
        Me.MFC_2_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_2_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_2_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_2_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_2_Recipe_Flow.Location = New System.Drawing.Point(226, 761)
        Me.MFC_2_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_2_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_2_Recipe_Flow.Name = "MFC_2_Recipe_Flow"
        Me.MFC_2_Recipe_Flow.ReadOnly = True
        Me.MFC_2_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_2_Recipe_Flow.TabIndex = 115
        Me.MFC_2_Recipe_Flow.Text = "???"
        Me.MFC_2_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_2_Recipe_Flow.WordWrap = False
        '
        'MFC_3_Read_Flow
        '
        Me.MFC_3_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_3_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_3_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_3_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_3_Read_Flow.Location = New System.Drawing.Point(367, 735)
        Me.MFC_3_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_3_Read_Flow.Name = "MFC_3_Read_Flow"
        Me.MFC_3_Read_Flow.ReadOnly = True
        Me.MFC_3_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_3_Read_Flow.TabIndex = 119
        Me.MFC_3_Read_Flow.Text = "0.00"
        Me.MFC_3_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_3_Read_Flow.WordWrap = False
        '
        'MFC_3_Recipe_Flow
        '
        Me.MFC_3_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_3_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_3_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_3_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_3_Recipe_Flow.Location = New System.Drawing.Point(367, 761)
        Me.MFC_3_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_3_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_3_Recipe_Flow.Name = "MFC_3_Recipe_Flow"
        Me.MFC_3_Recipe_Flow.ReadOnly = True
        Me.MFC_3_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_3_Recipe_Flow.TabIndex = 118
        Me.MFC_3_Recipe_Flow.Text = "???"
        Me.MFC_3_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_3_Recipe_Flow.WordWrap = False
        '
        'MFC_4_Read_Flow
        '
        Me.MFC_4_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_4_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_4_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_4_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_4_Read_Flow.Location = New System.Drawing.Point(507, 736)
        Me.MFC_4_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_4_Read_Flow.Name = "MFC_4_Read_Flow"
        Me.MFC_4_Read_Flow.ReadOnly = True
        Me.MFC_4_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_4_Read_Flow.TabIndex = 122
        Me.MFC_4_Read_Flow.Text = "0.00"
        Me.MFC_4_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_4_Read_Flow.WordWrap = False
        '
        'MFC_4_Recipe_Flow
        '
        Me.MFC_4_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_4_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_4_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_4_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_4_Recipe_Flow.Location = New System.Drawing.Point(507, 761)
        Me.MFC_4_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_4_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_4_Recipe_Flow.Name = "MFC_4_Recipe_Flow"
        Me.MFC_4_Recipe_Flow.ReadOnly = True
        Me.MFC_4_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_4_Recipe_Flow.TabIndex = 121
        Me.MFC_4_Recipe_Flow.Text = "???"
        Me.MFC_4_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_4_Recipe_Flow.WordWrap = False
        '
        'Loaded_Progress_2
        '
        Me.Loaded_Progress_2.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_2.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_2.Location = New System.Drawing.Point(194, 175)
        Me.Loaded_Progress_2.Name = "Loaded_Progress_2"
        Me.Loaded_Progress_2.ShadowDecoration.Parent = Me.Loaded_Progress_2
        Me.Loaded_Progress_2.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_2.TabIndex = 125
        Me.Loaded_Progress_2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_2.UseTransparentBackground = True
        '
        'Loaded_Progress_1
        '
        Me.Loaded_Progress_1.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_1.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_1.Location = New System.Drawing.Point(55, 175)
        Me.Loaded_Progress_1.Name = "Loaded_Progress_1"
        Me.Loaded_Progress_1.ShadowDecoration.Parent = Me.Loaded_Progress_1
        Me.Loaded_Progress_1.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_1.TabIndex = 126
        Me.Loaded_Progress_1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_1.UseTransparentBackground = True
        '
        'AC_CODE
        '
        Me.AC_CODE.AutoSize = True
        Me.AC_CODE.BackColor = System.Drawing.Color.White
        Me.AC_CODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AC_CODE.Location = New System.Drawing.Point(1537, 542)
        Me.AC_CODE.Name = "AC_CODE"
        Me.AC_CODE.Size = New System.Drawing.Size(83, 25)
        Me.AC_CODE.TabIndex = 13
        Me.AC_CODE.Text = "AC_OK"
        Me.AC_CODE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AC_CODE.Visible = False
        '
        'RecipeCyclesTxt_OPER
        '
        Me.RecipeCyclesTxt_OPER.BackColor = System.Drawing.Color.White
        Me.RecipeCyclesTxt_OPER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeCyclesTxt_OPER.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeCyclesTxt_OPER.ForeColor = System.Drawing.Color.Red
        Me.RecipeCyclesTxt_OPER.Location = New System.Drawing.Point(2551, 736)
        Me.RecipeCyclesTxt_OPER.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeCyclesTxt_OPER.Name = "RecipeCyclesTxt_OPER"
        Me.RecipeCyclesTxt_OPER.ReadOnly = True
        Me.RecipeCyclesTxt_OPER.Size = New System.Drawing.Size(66, 25)
        Me.RecipeCyclesTxt_OPER.TabIndex = 137
        Me.RecipeCyclesTxt_OPER.Text = "0"
        Me.RecipeCyclesTxt_OPER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeCyclesTxt_OPER.Visible = False
        Me.RecipeCyclesTxt_OPER.WordWrap = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1372, 894)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 20)
        Me.Label22.TabIndex = 142
        Me.Label22.Text = "Z:"
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1128, 894)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 20)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Y:"
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(918, 894)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 20)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "X:"
        Me.Label24.Visible = False
        '
        'Vacbtn
        '
        Me.Vacbtn.AutoRoundedCorners = True
        Me.Vacbtn.BorderRadius = 24
        Me.Vacbtn.CheckedState.Parent = Me.Vacbtn
        Me.Vacbtn.CustomImages.Parent = Me.Vacbtn
        Me.Vacbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Vacbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vacbtn.ForeColor = System.Drawing.Color.White
        Me.Vacbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Vacbtn.HoverState.Parent = Me.Vacbtn
        Me.Vacbtn.Location = New System.Drawing.Point(1565, 195)
        Me.Vacbtn.Name = "Vacbtn"
        Me.Vacbtn.ShadowDecoration.BorderRadius = 27
        Me.Vacbtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Vacbtn.ShadowDecoration.Parent = Me.Vacbtn
        Me.Vacbtn.Size = New System.Drawing.Size(167, 50)
        Me.Vacbtn.TabIndex = 145
        Me.Vacbtn.Text = "   VACUUM"
        Me.Vacbtn.Visible = False
        '
        'PinsSquare
        '
        Me.PinsSquare.AutoSize = True
        Me.PinsSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.PinsSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PinsSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PinsSquare.Location = New System.Drawing.Point(1402, 211)
        Me.PinsSquare.Name = "PinsSquare"
        Me.PinsSquare.Size = New System.Drawing.Size(19, 18)
        Me.PinsSquare.TabIndex = 146
        Me.PinsSquare.Text = "   "
        Me.PinsSquare.Visible = False
        '
        'Set_MFC_1_Recipe_Button
        '
        Me.Set_MFC_1_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_1_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_1_Recipe_Button.CheckedState.Parent = Me.Set_MFC_1_Recipe_Button
        Me.Set_MFC_1_Recipe_Button.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Set_MFC_1_Recipe_Button.CustomImages.Parent = Me.Set_MFC_1_Recipe_Button
        Me.Set_MFC_1_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_1_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_1_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_1_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_1_Recipe_Button.HoverState.Parent = Me.Set_MFC_1_Recipe_Button
        Me.Set_MFC_1_Recipe_Button.Location = New System.Drawing.Point(19, 736)
        Me.Set_MFC_1_Recipe_Button.Name = "Set_MFC_1_Recipe_Button"
        Me.Set_MFC_1_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_1_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_1_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_1_Recipe_Button
        Me.Set_MFC_1_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_1_Recipe_Button.TabIndex = 148
        Me.Set_MFC_1_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_1_Recipe_Button.Visible = False
        '
        'Set_MFC_3_Recipe_Button
        '
        Me.Set_MFC_3_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_3_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_3_Recipe_Button.CheckedState.Parent = Me.Set_MFC_3_Recipe_Button
        Me.Set_MFC_3_Recipe_Button.CustomImages.Parent = Me.Set_MFC_3_Recipe_Button
        Me.Set_MFC_3_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_3_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_3_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_3_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_3_Recipe_Button.HoverState.Parent = Me.Set_MFC_3_Recipe_Button
        Me.Set_MFC_3_Recipe_Button.Location = New System.Drawing.Point(302, 735)
        Me.Set_MFC_3_Recipe_Button.Name = "Set_MFC_3_Recipe_Button"
        Me.Set_MFC_3_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_3_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_3_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_3_Recipe_Button
        Me.Set_MFC_3_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_3_Recipe_Button.TabIndex = 149
        Me.Set_MFC_3_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_3_Recipe_Button.Visible = False
        '
        'Set_MFC_2_Recipe_Button
        '
        Me.Set_MFC_2_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_2_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_2_Recipe_Button.CheckedState.Parent = Me.Set_MFC_2_Recipe_Button
        Me.Set_MFC_2_Recipe_Button.CustomImages.Parent = Me.Set_MFC_2_Recipe_Button
        Me.Set_MFC_2_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_2_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_2_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_2_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_2_Recipe_Button.HoverState.Parent = Me.Set_MFC_2_Recipe_Button
        Me.Set_MFC_2_Recipe_Button.Location = New System.Drawing.Point(161, 735)
        Me.Set_MFC_2_Recipe_Button.Name = "Set_MFC_2_Recipe_Button"
        Me.Set_MFC_2_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_2_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_2_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_2_Recipe_Button
        Me.Set_MFC_2_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_2_Recipe_Button.TabIndex = 150
        Me.Set_MFC_2_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_2_Recipe_Button.Visible = False
        '
        'Set_MFC_4_Recipe_Button
        '
        Me.Set_MFC_4_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_4_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_4_Recipe_Button.CheckedState.Parent = Me.Set_MFC_4_Recipe_Button
        Me.Set_MFC_4_Recipe_Button.CustomImages.Parent = Me.Set_MFC_4_Recipe_Button
        Me.Set_MFC_4_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_4_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_4_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_4_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_4_Recipe_Button.HoverState.Parent = Me.Set_MFC_4_Recipe_Button
        Me.Set_MFC_4_Recipe_Button.Location = New System.Drawing.Point(442, 735)
        Me.Set_MFC_4_Recipe_Button.Name = "Set_MFC_4_Recipe_Button"
        Me.Set_MFC_4_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_4_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_4_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_4_Recipe_Button
        Me.Set_MFC_4_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_4_Recipe_Button.TabIndex = 151
        Me.Set_MFC_4_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_4_Recipe_Button.Visible = False
        '
        'SetRecipeWattsBtn
        '
        Me.SetRecipeWattsBtn.AutoRoundedCorners = True
        Me.SetRecipeWattsBtn.BorderRadius = 18
        Me.SetRecipeWattsBtn.CheckedState.Parent = Me.SetRecipeWattsBtn
        Me.SetRecipeWattsBtn.CustomImages.Parent = Me.SetRecipeWattsBtn
        Me.SetRecipeWattsBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetRecipeWattsBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SetRecipeWattsBtn.ForeColor = System.Drawing.Color.White
        Me.SetRecipeWattsBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetRecipeWattsBtn.HoverState.Parent = Me.SetRecipeWattsBtn
        Me.SetRecipeWattsBtn.Location = New System.Drawing.Point(973, 318)
        Me.SetRecipeWattsBtn.Name = "SetRecipeWattsBtn"
        Me.SetRecipeWattsBtn.ShadowDecoration.BorderRadius = 27
        Me.SetRecipeWattsBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetRecipeWattsBtn.ShadowDecoration.Parent = Me.SetRecipeWattsBtn
        Me.SetRecipeWattsBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetRecipeWattsBtn.TabIndex = 153
        Me.SetRecipeWattsBtn.Text = "ENTER"
        Me.SetRecipeWattsBtn.Visible = False
        '
        'SetRecipeTunerBtn
        '
        Me.SetRecipeTunerBtn.AutoRoundedCorners = True
        Me.SetRecipeTunerBtn.BorderRadius = 18
        Me.SetRecipeTunerBtn.CheckedState.Parent = Me.SetRecipeTunerBtn
        Me.SetRecipeTunerBtn.CustomImages.Parent = Me.SetRecipeTunerBtn
        Me.SetRecipeTunerBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetRecipeTunerBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetRecipeTunerBtn.ForeColor = System.Drawing.Color.White
        Me.SetRecipeTunerBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetRecipeTunerBtn.HoverState.Parent = Me.SetRecipeTunerBtn
        Me.SetRecipeTunerBtn.Location = New System.Drawing.Point(1217, 318)
        Me.SetRecipeTunerBtn.Name = "SetRecipeTunerBtn"
        Me.SetRecipeTunerBtn.ShadowDecoration.BorderRadius = 27
        Me.SetRecipeTunerBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetRecipeTunerBtn.ShadowDecoration.Parent = Me.SetRecipeTunerBtn
        Me.SetRecipeTunerBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetRecipeTunerBtn.TabIndex = 154
        Me.SetRecipeTunerBtn.Text = "ENTER"
        Me.SetRecipeTunerBtn.Visible = False
        '
        'Loaded_Progress_3
        '
        Me.Loaded_Progress_3.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_3.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_3.Location = New System.Drawing.Point(335, 175)
        Me.Loaded_Progress_3.Name = "Loaded_Progress_3"
        Me.Loaded_Progress_3.ShadowDecoration.Parent = Me.Loaded_Progress_3
        Me.Loaded_Progress_3.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_3.TabIndex = 124
        Me.Loaded_Progress_3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_3.UseTransparentBackground = True
        '
        'SetTwoSpotBtn
        '
        Me.SetTwoSpotBtn.AutoRoundedCorners = True
        Me.SetTwoSpotBtn.BorderRadius = 24
        Me.SetTwoSpotBtn.CheckedState.Parent = Me.SetTwoSpotBtn
        Me.SetTwoSpotBtn.CustomImages.Parent = Me.SetTwoSpotBtn
        Me.SetTwoSpotBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetTwoSpotBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetTwoSpotBtn.ForeColor = System.Drawing.Color.White
        Me.SetTwoSpotBtn.HoverState.Parent = Me.SetTwoSpotBtn
        Me.SetTwoSpotBtn.Location = New System.Drawing.Point(1387, 299)
        Me.SetTwoSpotBtn.Name = "SetTwoSpotBtn"
        Me.SetTwoSpotBtn.ShadowDecoration.BorderRadius = 27
        Me.SetTwoSpotBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetTwoSpotBtn.ShadowDecoration.Parent = Me.SetTwoSpotBtn
        Me.SetTwoSpotBtn.Size = New System.Drawing.Size(174, 50)
        Me.SetTwoSpotBtn.TabIndex = 156
        Me.SetTwoSpotBtn.Text = "SET TWO SPOT"
        Me.SetTwoSpotBtn.Visible = False
        '
        'SetDiameterBtn
        '
        Me.SetDiameterBtn.AutoRoundedCorners = True
        Me.SetDiameterBtn.BorderRadius = 24
        Me.SetDiameterBtn.CheckedState.Parent = Me.SetDiameterBtn
        Me.SetDiameterBtn.CustomImages.Parent = Me.SetDiameterBtn
        Me.SetDiameterBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetDiameterBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetDiameterBtn.ForeColor = System.Drawing.Color.White
        Me.SetDiameterBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetDiameterBtn.HoverState.Parent = Me.SetDiameterBtn
        Me.SetDiameterBtn.Location = New System.Drawing.Point(1565, 299)
        Me.SetDiameterBtn.Name = "SetDiameterBtn"
        Me.SetDiameterBtn.ShadowDecoration.BorderRadius = 27
        Me.SetDiameterBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetDiameterBtn.ShadowDecoration.Parent = Me.SetDiameterBtn
        Me.SetDiameterBtn.Size = New System.Drawing.Size(167, 50)
        Me.SetDiameterBtn.TabIndex = 157
        Me.SetDiameterBtn.Text = "SET DIAMETER"
        Me.SetDiameterBtn.Visible = False
        '
        'SetThicknessBtn
        '
        Me.SetThicknessBtn.AutoRoundedCorners = True
        Me.SetThicknessBtn.BorderRadius = 16
        Me.SetThicknessBtn.CheckedState.Parent = Me.SetThicknessBtn
        Me.SetThicknessBtn.CustomImages.Parent = Me.SetThicknessBtn
        Me.SetThicknessBtn.Enabled = False
        Me.SetThicknessBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetThicknessBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetThicknessBtn.ForeColor = System.Drawing.Color.White
        Me.SetThicknessBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetThicknessBtn.HoverState.Parent = Me.SetThicknessBtn
        Me.SetThicknessBtn.Location = New System.Drawing.Point(913, 802)
        Me.SetThicknessBtn.Name = "SetThicknessBtn"
        Me.SetThicknessBtn.ShadowDecoration.BorderRadius = 27
        Me.SetThicknessBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetThicknessBtn.ShadowDecoration.Parent = Me.SetThicknessBtn
        Me.SetThicknessBtn.Size = New System.Drawing.Size(100, 35)
        Me.SetThicknessBtn.TabIndex = 161
        Me.SetThicknessBtn.Text = "THICKNESS"
        Me.SetThicknessBtn.Visible = False
        '
        'SetOverlapBtn
        '
        Me.SetOverlapBtn.AutoRoundedCorners = True
        Me.SetOverlapBtn.BorderRadius = 16
        Me.SetOverlapBtn.CheckedState.Parent = Me.SetOverlapBtn
        Me.SetOverlapBtn.CustomImages.Parent = Me.SetOverlapBtn
        Me.SetOverlapBtn.Enabled = False
        Me.SetOverlapBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetOverlapBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetOverlapBtn.ForeColor = System.Drawing.Color.White
        Me.SetOverlapBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetOverlapBtn.HoverState.Parent = Me.SetOverlapBtn
        Me.SetOverlapBtn.Location = New System.Drawing.Point(1186, 803)
        Me.SetOverlapBtn.Name = "SetOverlapBtn"
        Me.SetOverlapBtn.ShadowDecoration.BorderRadius = 27
        Me.SetOverlapBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetOverlapBtn.ShadowDecoration.Parent = Me.SetOverlapBtn
        Me.SetOverlapBtn.Size = New System.Drawing.Size(100, 35)
        Me.SetOverlapBtn.TabIndex = 162
        Me.SetOverlapBtn.Text = "OVERLAP"
        Me.SetOverlapBtn.Visible = False
        '
        'SetGapBtn
        '
        Me.SetGapBtn.AutoRoundedCorners = True
        Me.SetGapBtn.BorderRadius = 16
        Me.SetGapBtn.CheckedState.Parent = Me.SetGapBtn
        Me.SetGapBtn.CustomImages.Parent = Me.SetGapBtn
        Me.SetGapBtn.Enabled = False
        Me.SetGapBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetGapBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetGapBtn.ForeColor = System.Drawing.Color.White
        Me.SetGapBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetGapBtn.HoverState.Parent = Me.SetGapBtn
        Me.SetGapBtn.Location = New System.Drawing.Point(1049, 802)
        Me.SetGapBtn.Name = "SetGapBtn"
        Me.SetGapBtn.ShadowDecoration.BorderRadius = 27
        Me.SetGapBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetGapBtn.ShadowDecoration.Parent = Me.SetGapBtn
        Me.SetGapBtn.Size = New System.Drawing.Size(100, 35)
        Me.SetGapBtn.TabIndex = 163
        Me.SetGapBtn.Text = "GAP"
        Me.SetGapBtn.Visible = False
        '
        'SetCyclesBtn
        '
        Me.SetCyclesBtn.AutoRoundedCorners = True
        Me.SetCyclesBtn.BorderRadius = 16
        Me.SetCyclesBtn.CheckedState.Parent = Me.SetCyclesBtn
        Me.SetCyclesBtn.CustomImages.Parent = Me.SetCyclesBtn
        Me.SetCyclesBtn.Enabled = False
        Me.SetCyclesBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetCyclesBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetCyclesBtn.ForeColor = System.Drawing.Color.White
        Me.SetCyclesBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetCyclesBtn.HoverState.Parent = Me.SetCyclesBtn
        Me.SetCyclesBtn.Location = New System.Drawing.Point(1462, 801)
        Me.SetCyclesBtn.Name = "SetCyclesBtn"
        Me.SetCyclesBtn.ShadowDecoration.BorderRadius = 27
        Me.SetCyclesBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetCyclesBtn.ShadowDecoration.Parent = Me.SetCyclesBtn
        Me.SetCyclesBtn.Size = New System.Drawing.Size(100, 35)
        Me.SetCyclesBtn.TabIndex = 164
        Me.SetCyclesBtn.Text = "CYCLES"
        Me.SetCyclesBtn.Visible = False
        '
        'SetSpeedBtn
        '
        Me.SetSpeedBtn.AutoRoundedCorners = True
        Me.SetSpeedBtn.BorderRadius = 16
        Me.SetSpeedBtn.CheckedState.Parent = Me.SetSpeedBtn
        Me.SetSpeedBtn.CustomImages.Parent = Me.SetSpeedBtn
        Me.SetSpeedBtn.Enabled = False
        Me.SetSpeedBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetSpeedBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetSpeedBtn.ForeColor = System.Drawing.Color.White
        Me.SetSpeedBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetSpeedBtn.HoverState.Parent = Me.SetSpeedBtn
        Me.SetSpeedBtn.Location = New System.Drawing.Point(1325, 803)
        Me.SetSpeedBtn.Name = "SetSpeedBtn"
        Me.SetSpeedBtn.ShadowDecoration.BorderRadius = 27
        Me.SetSpeedBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetSpeedBtn.ShadowDecoration.Parent = Me.SetSpeedBtn
        Me.SetSpeedBtn.Size = New System.Drawing.Size(100, 35)
        Me.SetSpeedBtn.TabIndex = 165
        Me.SetSpeedBtn.Text = "SPEED"
        Me.SetSpeedBtn.Visible = False
        '
        'MB_Pos_Bar
        '
        Me.MB_Pos_Bar.ArrowThickness = 6
        Me.MB_Pos_Bar.ArrowVisible = False
        Me.MB_Pos_Bar.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.MB_Pos_Bar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.MB_Pos_Bar.Location = New System.Drawing.Point(1138, 129)
        Me.MB_Pos_Bar.MinimumSize = New System.Drawing.Size(30, 30)
        Me.MB_Pos_Bar.Name = "MB_Pos_Bar"
        Me.MB_Pos_Bar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MB_Pos_Bar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MB_Pos_Bar.Size = New System.Drawing.Size(224, 224)
        Me.MB_Pos_Bar.TabIndex = 170
        '
        'Loaded_Progress_4
        '
        Me.Loaded_Progress_4.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_4.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_4.Location = New System.Drawing.Point(475, 175)
        Me.Loaded_Progress_4.Name = "Loaded_Progress_4"
        Me.Loaded_Progress_4.ShadowDecoration.Parent = Me.Loaded_Progress_4
        Me.Loaded_Progress_4.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_4.TabIndex = 84
        Me.Loaded_Progress_4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_4.UseTransparentBackground = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1384, 520)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 20)
        Me.Label26.TabIndex = 172
        Me.Label26.Text = "Error Codes"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(1239, 269)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(23, 20)
        Me.Label30.TabIndex = 174
        Me.Label30.Text = "%"
        '
        'LabelLock
        '
        Me.LabelLock.AutoSize = True
        Me.LabelLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLock.Location = New System.Drawing.Point(1384, 379)
        Me.LabelLock.Name = "LabelLock"
        Me.LabelLock.Size = New System.Drawing.Size(77, 20)
        Me.LabelLock.TabIndex = 176
        Me.LabelLock.Text = "Controller"
        Me.LabelLock.Visible = False
        '
        'RecipeXMaxTxt
        '
        Me.RecipeXMaxTxt.BackColor = System.Drawing.Color.White
        Me.RecipeXMaxTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeXMaxTxt.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeXMaxTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeXMaxTxt.Location = New System.Drawing.Point(1641, 413)
        Me.RecipeXMaxTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeXMaxTxt.Name = "RecipeXMaxTxt"
        Me.RecipeXMaxTxt.ReadOnly = True
        Me.RecipeXMaxTxt.Size = New System.Drawing.Size(101, 32)
        Me.RecipeXMaxTxt.TabIndex = 181
        Me.RecipeXMaxTxt.Text = "0"
        Me.RecipeXMaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeXMaxTxt.Visible = False
        Me.RecipeXMaxTxt.WordWrap = False
        '
        'RecipeXMinTxt
        '
        Me.RecipeXMinTxt.BackColor = System.Drawing.Color.White
        Me.RecipeXMinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeXMinTxt.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeXMinTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeXMinTxt.Location = New System.Drawing.Point(1476, 413)
        Me.RecipeXMinTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeXMinTxt.Name = "RecipeXMinTxt"
        Me.RecipeXMinTxt.ReadOnly = True
        Me.RecipeXMinTxt.Size = New System.Drawing.Size(83, 32)
        Me.RecipeXMinTxt.TabIndex = 182
        Me.RecipeXMinTxt.Text = "0"
        Me.RecipeXMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeXMinTxt.Visible = False
        Me.RecipeXMinTxt.WordWrap = False
        '
        'RecipeYMaxTxt
        '
        Me.RecipeYMaxTxt.BackColor = System.Drawing.Color.White
        Me.RecipeYMaxTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeYMaxTxt.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeYMaxTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeYMaxTxt.Location = New System.Drawing.Point(1642, 472)
        Me.RecipeYMaxTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeYMaxTxt.Name = "RecipeYMaxTxt"
        Me.RecipeYMaxTxt.ReadOnly = True
        Me.RecipeYMaxTxt.Size = New System.Drawing.Size(101, 32)
        Me.RecipeYMaxTxt.TabIndex = 183
        Me.RecipeYMaxTxt.Text = "0"
        Me.RecipeYMaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeYMaxTxt.Visible = False
        Me.RecipeYMaxTxt.WordWrap = False
        '
        'RecipeYMinTxt
        '
        Me.RecipeYMinTxt.BackColor = System.Drawing.Color.White
        Me.RecipeYMinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RecipeYMinTxt.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipeYMinTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.RecipeYMinTxt.Location = New System.Drawing.Point(1475, 472)
        Me.RecipeYMinTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipeYMinTxt.Name = "RecipeYMinTxt"
        Me.RecipeYMinTxt.ReadOnly = True
        Me.RecipeYMinTxt.Size = New System.Drawing.Size(83, 32)
        Me.RecipeYMinTxt.TabIndex = 184
        Me.RecipeYMinTxt.Text = "0"
        Me.RecipeYMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RecipeYMinTxt.Visible = False
        Me.RecipeYMinTxt.WordWrap = False
        '
        'SetXMaxBtn
        '
        Me.SetXMaxBtn.AutoRoundedCorners = True
        Me.SetXMaxBtn.BorderRadius = 18
        Me.SetXMaxBtn.CheckedState.Parent = Me.SetXMaxBtn
        Me.SetXMaxBtn.CustomImages.Parent = Me.SetXMaxBtn
        Me.SetXMaxBtn.Enabled = False
        Me.SetXMaxBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetXMaxBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetXMaxBtn.ForeColor = System.Drawing.Color.White
        Me.SetXMaxBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetXMaxBtn.HoverState.Parent = Me.SetXMaxBtn
        Me.SetXMaxBtn.Location = New System.Drawing.Point(1561, 406)
        Me.SetXMaxBtn.Name = "SetXMaxBtn"
        Me.SetXMaxBtn.ShadowDecoration.BorderRadius = 27
        Me.SetXMaxBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetXMaxBtn.ShadowDecoration.Parent = Me.SetXMaxBtn
        Me.SetXMaxBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetXMaxBtn.TabIndex = 185
        Me.SetXMaxBtn.Text = "X2"
        Me.SetXMaxBtn.Visible = False
        '
        'SetYMaxBtn
        '
        Me.SetYMaxBtn.AutoRoundedCorners = True
        Me.SetYMaxBtn.BorderRadius = 18
        Me.SetYMaxBtn.CheckedState.Parent = Me.SetYMaxBtn
        Me.SetYMaxBtn.CustomImages.Parent = Me.SetYMaxBtn
        Me.SetYMaxBtn.Enabled = False
        Me.SetYMaxBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetYMaxBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetYMaxBtn.ForeColor = System.Drawing.Color.White
        Me.SetYMaxBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetYMaxBtn.HoverState.Parent = Me.SetYMaxBtn
        Me.SetYMaxBtn.Location = New System.Drawing.Point(1561, 466)
        Me.SetYMaxBtn.Name = "SetYMaxBtn"
        Me.SetYMaxBtn.ShadowDecoration.BorderRadius = 27
        Me.SetYMaxBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetYMaxBtn.ShadowDecoration.Parent = Me.SetYMaxBtn
        Me.SetYMaxBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetYMaxBtn.TabIndex = 186
        Me.SetYMaxBtn.Text = "Y2"
        Me.SetYMaxBtn.Visible = False
        '
        'SetYMinBtn
        '
        Me.SetYMinBtn.AutoRoundedCorners = True
        Me.SetYMinBtn.BorderRadius = 18
        Me.SetYMinBtn.CheckedState.Parent = Me.SetYMinBtn
        Me.SetYMinBtn.CustomImages.Parent = Me.SetYMinBtn
        Me.SetYMinBtn.Enabled = False
        Me.SetYMinBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetYMinBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetYMinBtn.ForeColor = System.Drawing.Color.White
        Me.SetYMinBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetYMinBtn.HoverState.Parent = Me.SetYMinBtn
        Me.SetYMinBtn.Location = New System.Drawing.Point(1408, 466)
        Me.SetYMinBtn.Name = "SetYMinBtn"
        Me.SetYMinBtn.ShadowDecoration.BorderRadius = 27
        Me.SetYMinBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetYMinBtn.ShadowDecoration.Parent = Me.SetYMinBtn
        Me.SetYMinBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetYMinBtn.TabIndex = 187
        Me.SetYMinBtn.Text = "Y1"
        Me.SetYMinBtn.Visible = False
        '
        'SetXMinBtn
        '
        Me.SetXMinBtn.AutoRoundedCorners = True
        Me.SetXMinBtn.BorderRadius = 18
        Me.SetXMinBtn.CheckedState.Parent = Me.SetXMinBtn
        Me.SetXMinBtn.CustomImages.Parent = Me.SetXMinBtn
        Me.SetXMinBtn.Enabled = False
        Me.SetXMinBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetXMinBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetXMinBtn.ForeColor = System.Drawing.Color.White
        Me.SetXMinBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SetXMinBtn.HoverState.Parent = Me.SetXMinBtn
        Me.SetXMinBtn.Location = New System.Drawing.Point(1408, 406)
        Me.SetXMinBtn.Name = "SetXMinBtn"
        Me.SetXMinBtn.ShadowDecoration.BorderRadius = 27
        Me.SetXMinBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SetXMinBtn.ShadowDecoration.Parent = Me.SetXMinBtn
        Me.SetXMinBtn.Size = New System.Drawing.Size(64, 39)
        Me.SetXMinBtn.TabIndex = 188
        Me.SetXMinBtn.Text = "X1"
        Me.SetXMinBtn.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(1046, 893)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 20)
        Me.Label29.TabIndex = 189
        Me.Label29.Text = "mm"
        Me.Label29.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1516, 893)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(35, 20)
        Me.Label33.TabIndex = 190
        Me.Label33.Text = "mm"
        Me.Label33.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(1271, 894)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(35, 20)
        Me.Label34.TabIndex = 191
        Me.Label34.Text = "mm"
        Me.Label34.Visible = False
        '
        'ClearAbortbtn
        '
        Me.ClearAbortbtn.AutoRoundedCorners = True
        Me.ClearAbortbtn.BorderRadius = 17
        Me.ClearAbortbtn.CheckedState.Parent = Me.ClearAbortbtn
        Me.ClearAbortbtn.CustomImages.Parent = Me.ClearAbortbtn
        Me.ClearAbortbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClearAbortbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAbortbtn.ForeColor = System.Drawing.Color.White
        Me.ClearAbortbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClearAbortbtn.HoverState.Parent = Me.ClearAbortbtn
        Me.ClearAbortbtn.Location = New System.Drawing.Point(1474, 570)
        Me.ClearAbortbtn.Name = "ClearAbortbtn"
        Me.ClearAbortbtn.ShadowDecoration.BorderRadius = 27
        Me.ClearAbortbtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClearAbortbtn.ShadowDecoration.Parent = Me.ClearAbortbtn
        Me.ClearAbortbtn.Size = New System.Drawing.Size(232, 37)
        Me.ClearAbortbtn.TabIndex = 192
        Me.ClearAbortbtn.Text = "ACKNOWLEDGE"
        Me.ClearAbortbtn.Visible = False
        '
        'Loaded_Progress_3_25
        '
        Me.Loaded_Progress_3_25.AutoSize = True
        Me.Loaded_Progress_3_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_3_25.Location = New System.Drawing.Point(298, 586)
        Me.Loaded_Progress_3_25.Name = "Loaded_Progress_3_25"
        Me.Loaded_Progress_3_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_3_25.TabIndex = 193
        Me.Loaded_Progress_3_25.Text = "0.000"
        '
        'Loaded_Progress_4_25
        '
        Me.Loaded_Progress_4_25.AutoSize = True
        Me.Loaded_Progress_4_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_4_25.Location = New System.Drawing.Point(438, 586)
        Me.Loaded_Progress_4_25.Name = "Loaded_Progress_4_25"
        Me.Loaded_Progress_4_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_4_25.TabIndex = 194
        Me.Loaded_Progress_4_25.Text = "0.000"
        '
        'Loaded_Progress_3_75
        '
        Me.Loaded_Progress_3_75.AutoSize = True
        Me.Loaded_Progress_3_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_3_75.Location = New System.Drawing.Point(298, 312)
        Me.Loaded_Progress_3_75.Name = "Loaded_Progress_3_75"
        Me.Loaded_Progress_3_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_3_75.TabIndex = 195
        Me.Loaded_Progress_3_75.Text = "0.000"
        '
        'Loaded_Progress_4_75
        '
        Me.Loaded_Progress_4_75.AutoSize = True
        Me.Loaded_Progress_4_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_4_75.Location = New System.Drawing.Point(438, 312)
        Me.Loaded_Progress_4_75.Name = "Loaded_Progress_4_75"
        Me.Loaded_Progress_4_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_4_75.TabIndex = 196
        Me.Loaded_Progress_4_75.Text = "0.000"
        '
        'Loaded_Progress_2_25
        '
        Me.Loaded_Progress_2_25.AutoSize = True
        Me.Loaded_Progress_2_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_2_25.Location = New System.Drawing.Point(158, 585)
        Me.Loaded_Progress_2_25.Name = "Loaded_Progress_2_25"
        Me.Loaded_Progress_2_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_2_25.TabIndex = 197
        Me.Loaded_Progress_2_25.Text = "0.000"
        '
        'Loaded_Progress_1_25
        '
        Me.Loaded_Progress_1_25.AutoSize = True
        Me.Loaded_Progress_1_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_1_25.Location = New System.Drawing.Point(18, 586)
        Me.Loaded_Progress_1_25.Name = "Loaded_Progress_1_25"
        Me.Loaded_Progress_1_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_1_25.TabIndex = 198
        Me.Loaded_Progress_1_25.Text = "0.000"
        '
        'Loaded_Progress_1_75
        '
        Me.Loaded_Progress_1_75.AutoSize = True
        Me.Loaded_Progress_1_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_1_75.Location = New System.Drawing.Point(18, 310)
        Me.Loaded_Progress_1_75.Name = "Loaded_Progress_1_75"
        Me.Loaded_Progress_1_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_1_75.TabIndex = 200
        Me.Loaded_Progress_1_75.Text = "0.000"
        '
        'Loaded_Progress_2_75
        '
        Me.Loaded_Progress_2_75.AutoSize = True
        Me.Loaded_Progress_2_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_2_75.Location = New System.Drawing.Point(157, 309)
        Me.Loaded_Progress_2_75.Name = "Loaded_Progress_2_75"
        Me.Loaded_Progress_2_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_2_75.TabIndex = 199
        Me.Loaded_Progress_2_75.Text = "0.000"
        '
        'ChuckVacSquare
        '
        Me.ChuckVacSquare.AutoSize = True
        Me.ChuckVacSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.ChuckVacSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ChuckVacSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChuckVacSquare.Location = New System.Drawing.Point(1390, 357)
        Me.ChuckVacSquare.Name = "ChuckVacSquare"
        Me.ChuckVacSquare.Size = New System.Drawing.Size(19, 18)
        Me.ChuckVacSquare.TabIndex = 205
        Me.ChuckVacSquare.Text = "   "
        Me.ChuckVacSquare.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1405, 355)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 18)
        Me.Label18.TabIndex = 206
        Me.Label18.Text = "CHUCK VAC"
        Me.Label18.Visible = False
        '
        'AutoVacSquare
        '
        Me.AutoVacSquare.AutoSize = True
        Me.AutoVacSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.AutoVacSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AutoVacSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoVacSquare.Location = New System.Drawing.Point(1580, 213)
        Me.AutoVacSquare.Name = "AutoVacSquare"
        Me.AutoVacSquare.Size = New System.Drawing.Size(19, 18)
        Me.AutoVacSquare.TabIndex = 46
        Me.AutoVacSquare.Text = "   "
        Me.AutoVacSquare.Visible = False
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel.Location = New System.Drawing.Point(1353, 8)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(0, 39)
        Me.DateTimeLabel.TabIndex = 207
        '
        'DateTimeLabel1
        '
        Me.DateTimeLabel1.AutoSize = True
        Me.DateTimeLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DateTimeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeLabel1.Location = New System.Drawing.Point(1280, 15)
        Me.DateTimeLabel1.Name = "DateTimeLabel1"
        Me.DateTimeLabel1.Size = New System.Drawing.Size(237, 16)
        Me.DateTimeLabel1.TabIndex = 208
        Me.DateTimeLabel1.Text = "02:22 Wednesday, September 24 2020"
        '
        'EngLabel
        '
        Me.EngLabel.AutoSize = True
        Me.EngLabel.BackColor = System.Drawing.Color.Silver
        Me.EngLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngLabel.ForeColor = System.Drawing.Color.White
        Me.EngLabel.Location = New System.Drawing.Point(805, 9)
        Me.EngLabel.Name = "EngLabel"
        Me.EngLabel.Size = New System.Drawing.Size(178, 30)
        Me.EngLabel.TabIndex = 213
        Me.EngLabel.Text = "ENGINEER MODE"
        Me.EngLabel.Visible = False
        '
        'N2Purgelabel
        '
        Me.N2Purgelabel.AutoSize = True
        Me.N2Purgelabel.BackColor = System.Drawing.Color.Gainsboro
        Me.N2Purgelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.N2Purgelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N2Purgelabel.Location = New System.Drawing.Point(1580, 159)
        Me.N2Purgelabel.Name = "N2Purgelabel"
        Me.N2Purgelabel.Size = New System.Drawing.Size(19, 18)
        Me.N2Purgelabel.TabIndex = 215
        Me.N2Purgelabel.Text = "   "
        Me.N2Purgelabel.Visible = False
        '
        'N2Purgebtn
        '
        Me.N2Purgebtn.AutoRoundedCorners = True
        Me.N2Purgebtn.BorderRadius = 24
        Me.N2Purgebtn.CheckedState.Parent = Me.N2Purgebtn
        Me.N2Purgebtn.CustomImages.Parent = Me.N2Purgebtn
        Me.N2Purgebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.N2Purgebtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N2Purgebtn.ForeColor = System.Drawing.Color.White
        Me.N2Purgebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.N2Purgebtn.HoverState.Parent = Me.N2Purgebtn
        Me.N2Purgebtn.Location = New System.Drawing.Point(1565, 141)
        Me.N2Purgebtn.Name = "N2Purgebtn"
        Me.N2Purgebtn.ShadowDecoration.BorderRadius = 27
        Me.N2Purgebtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.N2Purgebtn.ShadowDecoration.Parent = Me.N2Purgebtn
        Me.N2Purgebtn.Size = New System.Drawing.Size(167, 50)
        Me.N2Purgebtn.TabIndex = 214
        Me.N2Purgebtn.Text = "    N2 PURGE"
        Me.N2Purgebtn.Visible = False
        '
        'PurgeOnLabel
        '
        Me.PurgeOnLabel.AutoSize = True
        Me.PurgeOnLabel.BackColor = System.Drawing.Color.White
        Me.PurgeOnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeOnLabel.Location = New System.Drawing.Point(1528, 355)
        Me.PurgeOnLabel.Name = "PurgeOnLabel"
        Me.PurgeOnLabel.Size = New System.Drawing.Size(89, 18)
        Me.PurgeOnLabel.TabIndex = 217
        Me.PurgeOnLabel.Text = "PURGE ON"
        Me.PurgeOnLabel.Visible = False
        '
        'N2PurgeSquare
        '
        Me.N2PurgeSquare.AutoSize = True
        Me.N2PurgeSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.N2PurgeSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.N2PurgeSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N2PurgeSquare.Location = New System.Drawing.Point(1509, 357)
        Me.N2PurgeSquare.Name = "N2PurgeSquare"
        Me.N2PurgeSquare.Size = New System.Drawing.Size(19, 18)
        Me.N2PurgeSquare.TabIndex = 216
        Me.N2PurgeSquare.Text = "   "
        Me.N2PurgeSquare.Visible = False
        '
        'BatchLoggingBTN
        '
        Me.BatchLoggingBTN.AutoRoundedCorners = True
        Me.BatchLoggingBTN.BorderRadius = 18
        Me.BatchLoggingBTN.CheckedState.Parent = Me.BatchLoggingBTN
        Me.BatchLoggingBTN.CustomImages.Parent = Me.BatchLoggingBTN
        Me.BatchLoggingBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BatchLoggingBTN.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchLoggingBTN.ForeColor = System.Drawing.Color.White
        Me.BatchLoggingBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BatchLoggingBTN.HoverState.Parent = Me.BatchLoggingBTN
        Me.BatchLoggingBTN.Location = New System.Drawing.Point(661, 56)
        Me.BatchLoggingBTN.Name = "BatchLoggingBTN"
        Me.BatchLoggingBTN.ShadowDecoration.BorderRadius = 27
        Me.BatchLoggingBTN.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BatchLoggingBTN.ShadowDecoration.Parent = Me.BatchLoggingBTN
        Me.BatchLoggingBTN.Size = New System.Drawing.Size(113, 39)
        Me.BatchLoggingBTN.TabIndex = 222
        Me.BatchLoggingBTN.Text = "BATCH ID"
        Me.BatchLoggingBTN.Visible = False
        '
        'BatchIDTextBox
        '
        Me.BatchIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BatchIDTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchIDTextBox.Location = New System.Drawing.Point(791, 60)
        Me.BatchIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BatchIDTextBox.MinimumSize = New System.Drawing.Size(38, 20)
        Me.BatchIDTextBox.Name = "BatchIDTextBox"
        Me.BatchIDTextBox.ReadOnly = True
        Me.BatchIDTextBox.Size = New System.Drawing.Size(338, 29)
        Me.BatchIDTextBox.TabIndex = 221
        Me.BatchIDTextBox.Text = "Batch ID "
        Me.BatchIDTextBox.Visible = False
        Me.BatchIDTextBox.WordWrap = False
        '
        'SettingsBtn
        '
        Me.SettingsBtn.AutoRoundedCorners = True
        Me.SettingsBtn.BorderRadius = 30
        Me.SettingsBtn.CheckedState.Parent = Me.SettingsBtn
        Me.SettingsBtn.CustomImages.Parent = Me.SettingsBtn
        Me.SettingsBtn.Enabled = False
        Me.SettingsBtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SettingsBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SettingsBtn.ForeColor = System.Drawing.Color.White
        Me.SettingsBtn.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.SettingsBtn.HoverState.Parent = Me.SettingsBtn
        Me.SettingsBtn.Image = CType(resources.GetObject("SettingsBtn.Image"), System.Drawing.Image)
        Me.SettingsBtn.ImageSize = New System.Drawing.Size(50, 50)
        Me.SettingsBtn.Location = New System.Drawing.Point(611, 850)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.ShadowDecoration.BorderRadius = 27
        Me.SettingsBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SettingsBtn.ShadowDecoration.Parent = Me.SettingsBtn
        Me.SettingsBtn.Size = New System.Drawing.Size(69, 63)
        Me.SettingsBtn.TabIndex = 223
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1636, 355)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 225
        Me.Label17.Text = "LASER SENSE"
        Me.Label17.Visible = False
        '
        'LaserSenseSquare
        '
        Me.LaserSenseSquare.AutoSize = True
        Me.LaserSenseSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.LaserSenseSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaserSenseSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaserSenseSquare.Location = New System.Drawing.Point(1619, 357)
        Me.LaserSenseSquare.Name = "LaserSenseSquare"
        Me.LaserSenseSquare.Size = New System.Drawing.Size(19, 18)
        Me.LaserSenseSquare.TabIndex = 224
        Me.LaserSenseSquare.Text = "   "
        Me.LaserSenseSquare.Visible = False
        '
        'ControllerLabel
        '
        Me.ControllerLabel.AutoSize = True
        Me.ControllerLabel.BackColor = System.Drawing.Color.White
        Me.ControllerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerLabel.Location = New System.Drawing.Point(1529, 382)
        Me.ControllerLabel.Name = "ControllerLabel"
        Me.ControllerLabel.Size = New System.Drawing.Size(138, 18)
        Me.ControllerLabel.TabIndex = 229
        Me.ControllerLabel.Text = "CONTROLLER ON"
        Me.ControllerLabel.Visible = False
        '
        'contollerONSquare
        '
        Me.contollerONSquare.AutoSize = True
        Me.contollerONSquare.BackColor = System.Drawing.Color.Gainsboro
        Me.contollerONSquare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.contollerONSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contollerONSquare.Location = New System.Drawing.Point(1510, 384)
        Me.contollerONSquare.Name = "contollerONSquare"
        Me.contollerONSquare.Size = New System.Drawing.Size(19, 18)
        Me.contollerONSquare.TabIndex = 228
        Me.contollerONSquare.Text = "   "
        Me.contollerONSquare.Visible = False
        '
        'CTLStatusLabel
        '
        Me.CTLStatusLabel.AutoSize = True
        Me.CTLStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTLStatusLabel.Location = New System.Drawing.Point(1752, 116)
        Me.CTLStatusLabel.Name = "CTLStatusLabel"
        Me.CTLStatusLabel.Size = New System.Drawing.Size(89, 20)
        Me.CTLStatusLabel.TabIndex = 231
        Me.CTLStatusLabel.Text = "CTL Status"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2TextBox1.BorderRadius = 8
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(1789, 168)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox1.TabIndex = 248
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox1.WordWrap = False
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BorderRadius = 8
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(1789, 192)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.ReadOnly = True
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox2.TabIndex = 249
        Me.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox2.WordWrap = False
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.AutoRoundedCorners = True
        Me.Guna2TextBox3.BorderRadius = 8
        Me.Guna2TextBox3.BorderThickness = 2
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.HoverState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Location = New System.Drawing.Point(1789, 216)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.ReadOnly = True
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.ShadowDecoration.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox3.TabIndex = 251
        Me.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox3.WordWrap = False
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.AutoRoundedCorners = True
        Me.Guna2TextBox4.BorderRadius = 8
        Me.Guna2TextBox4.BorderThickness = 2
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.HoverState.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Location = New System.Drawing.Point(1789, 240)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.ReadOnly = True
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.ShadowDecoration.Parent = Me.Guna2TextBox4
        Me.Guna2TextBox4.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox4.TabIndex = 250
        Me.Guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox4.WordWrap = False
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.AutoRoundedCorners = True
        Me.Guna2TextBox5.BorderRadius = 8
        Me.Guna2TextBox5.BorderThickness = 2
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.Parent = Me.Guna2TextBox5
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.Parent = Me.Guna2TextBox5
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.HoverState.Parent = Me.Guna2TextBox5
        Me.Guna2TextBox5.Location = New System.Drawing.Point(1789, 264)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = ""
        Me.Guna2TextBox5.ReadOnly = True
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.ShadowDecoration.Parent = Me.Guna2TextBox5
        Me.Guna2TextBox5.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox5.TabIndex = 255
        Me.Guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox5.WordWrap = False
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.AutoRoundedCorners = True
        Me.Guna2TextBox6.BorderRadius = 8
        Me.Guna2TextBox6.BorderThickness = 2
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = ""
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.HoverState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Location = New System.Drawing.Point(1789, 288)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = ""
        Me.Guna2TextBox6.ReadOnly = True
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.ShadowDecoration.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox6.TabIndex = 254
        Me.Guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox6.WordWrap = False
        '
        'Guna2TextBox7
        '
        Me.Guna2TextBox7.AutoRoundedCorners = True
        Me.Guna2TextBox7.BorderRadius = 8
        Me.Guna2TextBox7.BorderThickness = 2
        Me.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox7.DefaultText = ""
        Me.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.Parent = Me.Guna2TextBox7
        Me.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.FocusedState.Parent = Me.Guna2TextBox7
        Me.Guna2TextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.HoverState.Parent = Me.Guna2TextBox7
        Me.Guna2TextBox7.Location = New System.Drawing.Point(1789, 311)
        Me.Guna2TextBox7.Name = "Guna2TextBox7"
        Me.Guna2TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox7.PlaceholderText = ""
        Me.Guna2TextBox7.ReadOnly = True
        Me.Guna2TextBox7.SelectedText = ""
        Me.Guna2TextBox7.ShadowDecoration.Parent = Me.Guna2TextBox7
        Me.Guna2TextBox7.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox7.TabIndex = 253
        Me.Guna2TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox7.WordWrap = False
        '
        'Guna2TextBox8
        '
        Me.Guna2TextBox8.AutoRoundedCorners = True
        Me.Guna2TextBox8.BorderRadius = 8
        Me.Guna2TextBox8.BorderThickness = 2
        Me.Guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox8.DefaultText = ""
        Me.Guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox8.FocusedState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox8.HoverState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Location = New System.Drawing.Point(1789, 335)
        Me.Guna2TextBox8.Name = "Guna2TextBox8"
        Me.Guna2TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox8.PlaceholderText = ""
        Me.Guna2TextBox8.ReadOnly = True
        Me.Guna2TextBox8.SelectedText = ""
        Me.Guna2TextBox8.ShadowDecoration.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox8.TabIndex = 252
        Me.Guna2TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox8.WordWrap = False
        '
        'Guna2TextBox9
        '
        Me.Guna2TextBox9.AutoRoundedCorners = True
        Me.Guna2TextBox9.BorderRadius = 8
        Me.Guna2TextBox9.BorderThickness = 2
        Me.Guna2TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox9.DefaultText = ""
        Me.Guna2TextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox9.DisabledState.Parent = Me.Guna2TextBox9
        Me.Guna2TextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox9.FocusedState.Parent = Me.Guna2TextBox9
        Me.Guna2TextBox9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox9.HoverState.Parent = Me.Guna2TextBox9
        Me.Guna2TextBox9.Location = New System.Drawing.Point(1789, 359)
        Me.Guna2TextBox9.Name = "Guna2TextBox9"
        Me.Guna2TextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox9.PlaceholderText = ""
        Me.Guna2TextBox9.ReadOnly = True
        Me.Guna2TextBox9.SelectedText = ""
        Me.Guna2TextBox9.ShadowDecoration.Parent = Me.Guna2TextBox9
        Me.Guna2TextBox9.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox9.TabIndex = 263
        Me.Guna2TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox9.WordWrap = False
        '
        'Guna2TextBox10
        '
        Me.Guna2TextBox10.AutoRoundedCorners = True
        Me.Guna2TextBox10.BorderRadius = 8
        Me.Guna2TextBox10.BorderThickness = 2
        Me.Guna2TextBox10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox10.DefaultText = ""
        Me.Guna2TextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox10.DisabledState.Parent = Me.Guna2TextBox10
        Me.Guna2TextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox10.FocusedState.Parent = Me.Guna2TextBox10
        Me.Guna2TextBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox10.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox10.HoverState.Parent = Me.Guna2TextBox10
        Me.Guna2TextBox10.Location = New System.Drawing.Point(1789, 383)
        Me.Guna2TextBox10.Name = "Guna2TextBox10"
        Me.Guna2TextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox10.PlaceholderText = ""
        Me.Guna2TextBox10.ReadOnly = True
        Me.Guna2TextBox10.SelectedText = ""
        Me.Guna2TextBox10.ShadowDecoration.Parent = Me.Guna2TextBox10
        Me.Guna2TextBox10.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox10.TabIndex = 262
        Me.Guna2TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox10.WordWrap = False
        '
        'Guna2TextBox11
        '
        Me.Guna2TextBox11.AutoRoundedCorners = True
        Me.Guna2TextBox11.BorderRadius = 8
        Me.Guna2TextBox11.BorderThickness = 2
        Me.Guna2TextBox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox11.DefaultText = ""
        Me.Guna2TextBox11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox11.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox11.DisabledState.Parent = Me.Guna2TextBox11
        Me.Guna2TextBox11.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox11.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox11.FocusedState.Parent = Me.Guna2TextBox11
        Me.Guna2TextBox11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox11.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox11.HoverState.Parent = Me.Guna2TextBox11
        Me.Guna2TextBox11.Location = New System.Drawing.Point(1789, 407)
        Me.Guna2TextBox11.Name = "Guna2TextBox11"
        Me.Guna2TextBox11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox11.PlaceholderText = ""
        Me.Guna2TextBox11.ReadOnly = True
        Me.Guna2TextBox11.SelectedText = ""
        Me.Guna2TextBox11.ShadowDecoration.Parent = Me.Guna2TextBox11
        Me.Guna2TextBox11.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox11.TabIndex = 261
        Me.Guna2TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox11.WordWrap = False
        '
        'Guna2TextBox12
        '
        Me.Guna2TextBox12.AutoRoundedCorners = True
        Me.Guna2TextBox12.BorderRadius = 8
        Me.Guna2TextBox12.BorderThickness = 2
        Me.Guna2TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox12.DefaultText = ""
        Me.Guna2TextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.Parent = Me.Guna2TextBox12
        Me.Guna2TextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox12.FocusedState.Parent = Me.Guna2TextBox12
        Me.Guna2TextBox12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox12.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox12.HoverState.Parent = Me.Guna2TextBox12
        Me.Guna2TextBox12.Location = New System.Drawing.Point(1789, 431)
        Me.Guna2TextBox12.Name = "Guna2TextBox12"
        Me.Guna2TextBox12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox12.PlaceholderText = ""
        Me.Guna2TextBox12.ReadOnly = True
        Me.Guna2TextBox12.SelectedText = ""
        Me.Guna2TextBox12.ShadowDecoration.Parent = Me.Guna2TextBox12
        Me.Guna2TextBox12.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox12.TabIndex = 260
        Me.Guna2TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox12.WordWrap = False
        '
        'Guna2TextBox13
        '
        Me.Guna2TextBox13.AutoRoundedCorners = True
        Me.Guna2TextBox13.BorderRadius = 8
        Me.Guna2TextBox13.BorderThickness = 2
        Me.Guna2TextBox13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox13.DefaultText = ""
        Me.Guna2TextBox13.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox13.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox13.DisabledState.Parent = Me.Guna2TextBox13
        Me.Guna2TextBox13.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox13.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox13.FocusedState.Parent = Me.Guna2TextBox13
        Me.Guna2TextBox13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox13.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox13.HoverState.Parent = Me.Guna2TextBox13
        Me.Guna2TextBox13.Location = New System.Drawing.Point(1789, 455)
        Me.Guna2TextBox13.Name = "Guna2TextBox13"
        Me.Guna2TextBox13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox13.PlaceholderText = ""
        Me.Guna2TextBox13.ReadOnly = True
        Me.Guna2TextBox13.SelectedText = ""
        Me.Guna2TextBox13.ShadowDecoration.Parent = Me.Guna2TextBox13
        Me.Guna2TextBox13.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox13.TabIndex = 259
        Me.Guna2TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox13.WordWrap = False
        '
        'Guna2TextBox14
        '
        Me.Guna2TextBox14.AutoRoundedCorners = True
        Me.Guna2TextBox14.BorderRadius = 8
        Me.Guna2TextBox14.BorderThickness = 2
        Me.Guna2TextBox14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox14.DefaultText = ""
        Me.Guna2TextBox14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox14.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox14.DisabledState.Parent = Me.Guna2TextBox14
        Me.Guna2TextBox14.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox14.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox14.FocusedState.Parent = Me.Guna2TextBox14
        Me.Guna2TextBox14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox14.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox14.HoverState.Parent = Me.Guna2TextBox14
        Me.Guna2TextBox14.Location = New System.Drawing.Point(1789, 479)
        Me.Guna2TextBox14.Name = "Guna2TextBox14"
        Me.Guna2TextBox14.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox14.PlaceholderText = ""
        Me.Guna2TextBox14.ReadOnly = True
        Me.Guna2TextBox14.SelectedText = ""
        Me.Guna2TextBox14.ShadowDecoration.Parent = Me.Guna2TextBox14
        Me.Guna2TextBox14.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox14.TabIndex = 258
        Me.Guna2TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox14.WordWrap = False
        '
        'Guna2TextBox15
        '
        Me.Guna2TextBox15.AutoRoundedCorners = True
        Me.Guna2TextBox15.BorderRadius = 8
        Me.Guna2TextBox15.BorderThickness = 2
        Me.Guna2TextBox15.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox15.DefaultText = ""
        Me.Guna2TextBox15.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox15.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox15.DisabledState.Parent = Me.Guna2TextBox15
        Me.Guna2TextBox15.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox15.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox15.FocusedState.Parent = Me.Guna2TextBox15
        Me.Guna2TextBox15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox15.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox15.HoverState.Parent = Me.Guna2TextBox15
        Me.Guna2TextBox15.Location = New System.Drawing.Point(1789, 503)
        Me.Guna2TextBox15.Name = "Guna2TextBox15"
        Me.Guna2TextBox15.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox15.PlaceholderText = ""
        Me.Guna2TextBox15.ReadOnly = True
        Me.Guna2TextBox15.SelectedText = ""
        Me.Guna2TextBox15.ShadowDecoration.Parent = Me.Guna2TextBox15
        Me.Guna2TextBox15.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox15.TabIndex = 257
        Me.Guna2TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox15.WordWrap = False
        '
        'Guna2TextBox16
        '
        Me.Guna2TextBox16.AutoRoundedCorners = True
        Me.Guna2TextBox16.BorderRadius = 8
        Me.Guna2TextBox16.BorderThickness = 2
        Me.Guna2TextBox16.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox16.DefaultText = ""
        Me.Guna2TextBox16.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox16.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox16.DisabledState.Parent = Me.Guna2TextBox16
        Me.Guna2TextBox16.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox16.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox16.FocusedState.Parent = Me.Guna2TextBox16
        Me.Guna2TextBox16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox16.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox16.HoverState.Parent = Me.Guna2TextBox16
        Me.Guna2TextBox16.Location = New System.Drawing.Point(1789, 527)
        Me.Guna2TextBox16.Name = "Guna2TextBox16"
        Me.Guna2TextBox16.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox16.PlaceholderText = ""
        Me.Guna2TextBox16.ReadOnly = True
        Me.Guna2TextBox16.SelectedText = ""
        Me.Guna2TextBox16.ShadowDecoration.Parent = Me.Guna2TextBox16
        Me.Guna2TextBox16.Size = New System.Drawing.Size(94, 18)
        Me.Guna2TextBox16.TabIndex = 256
        Me.Guna2TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2TextBox16.WordWrap = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(1545, 617)
        Me.Label21.MaximumSize = New System.Drawing.Size(700, 2)
        Me.Label21.MinimumSize = New System.Drawing.Size(150, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(700, 2)
        Me.Label21.TabIndex = 264
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoManBtn
        '
        Me.AutoManBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AutoManBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AutoManBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.AutoManBtn.CheckedState.InnerColor = System.Drawing.Color.White
        Me.AutoManBtn.CheckedState.Parent = Me.AutoManBtn
        Me.AutoManBtn.Location = New System.Drawing.Point(1220, 108)
        Me.AutoManBtn.Name = "AutoManBtn"
        Me.AutoManBtn.ShadowDecoration.Parent = Me.AutoManBtn
        Me.AutoManBtn.Size = New System.Drawing.Size(61, 25)
        Me.AutoManBtn.TabIndex = 265
        Me.AutoManBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.AutoManBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.AutoManBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.AutoManBtn.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.AutoManBtn.UncheckedState.Parent = Me.AutoManBtn
        Me.AutoManBtn.Visible = False
        '
        'auto_tune_label
        '
        Me.auto_tune_label.AutoSize = True
        Me.auto_tune_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auto_tune_label.Location = New System.Drawing.Point(1215, 88)
        Me.auto_tune_label.Name = "auto_tune_label"
        Me.auto_tune_label.Size = New System.Drawing.Size(74, 17)
        Me.auto_tune_label.TabIndex = 266
        Me.auto_tune_label.Text = "Auto Tune"
        Me.auto_tune_label.Visible = False
        '
        'LEDTrackBar
        '
        Me.LEDTrackBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTrackBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.LEDTrackBar.HoverState.Parent = Me.LEDTrackBar
        Me.LEDTrackBar.IndicateFocus = False
        Me.LEDTrackBar.Location = New System.Drawing.Point(1424, 75)
        Me.LEDTrackBar.Name = "LEDTrackBar"
        Me.LEDTrackBar.Size = New System.Drawing.Size(305, 23)
        Me.LEDTrackBar.TabIndex = 271
        Me.LEDTrackBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LEDTrackBar.Value = 0
        Me.LEDTrackBar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1472, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.TabIndex = 272
        Me.Label6.Text = "LED Brightness Control"
        Me.Label6.Visible = False
        '
        'Loaded_Progress_6_75
        '
        Me.Loaded_Progress_6_75.AutoSize = True
        Me.Loaded_Progress_6_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_6_75.Location = New System.Drawing.Point(716, 309)
        Me.Loaded_Progress_6_75.Name = "Loaded_Progress_6_75"
        Me.Loaded_Progress_6_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_6_75.TabIndex = 292
        Me.Loaded_Progress_6_75.Text = "0.000"
        '
        'Loaded_Progress_6_25
        '
        Me.Loaded_Progress_6_25.AutoSize = True
        Me.Loaded_Progress_6_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_6_25.Location = New System.Drawing.Point(717, 585)
        Me.Loaded_Progress_6_25.Name = "Loaded_Progress_6_25"
        Me.Loaded_Progress_6_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_6_25.TabIndex = 291
        Me.Loaded_Progress_6_25.Text = "0.000"
        '
        'Set_MFC_6_Recipe_Button
        '
        Me.Set_MFC_6_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_6_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_6_Recipe_Button.CheckedState.Parent = Me.Set_MFC_6_Recipe_Button
        Me.Set_MFC_6_Recipe_Button.CustomImages.Parent = Me.Set_MFC_6_Recipe_Button
        Me.Set_MFC_6_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_6_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_6_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_6_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_6_Recipe_Button.HoverState.Parent = Me.Set_MFC_6_Recipe_Button
        Me.Set_MFC_6_Recipe_Button.Location = New System.Drawing.Point(720, 735)
        Me.Set_MFC_6_Recipe_Button.Name = "Set_MFC_6_Recipe_Button"
        Me.Set_MFC_6_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_6_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_6_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_6_Recipe_Button
        Me.Set_MFC_6_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_6_Recipe_Button.TabIndex = 290
        Me.Set_MFC_6_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_6_Recipe_Button.Visible = False
        '
        'Set_MFC_5_Recipe_Button
        '
        Me.Set_MFC_5_Recipe_Button.AutoRoundedCorners = True
        Me.Set_MFC_5_Recipe_Button.BorderRadius = 18
        Me.Set_MFC_5_Recipe_Button.CheckedState.Parent = Me.Set_MFC_5_Recipe_Button
        Me.Set_MFC_5_Recipe_Button.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Set_MFC_5_Recipe_Button.CustomImages.Parent = Me.Set_MFC_5_Recipe_Button
        Me.Set_MFC_5_Recipe_Button.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_5_Recipe_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Set_MFC_5_Recipe_Button.ForeColor = System.Drawing.Color.White
        Me.Set_MFC_5_Recipe_Button.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Set_MFC_5_Recipe_Button.HoverState.Parent = Me.Set_MFC_5_Recipe_Button
        Me.Set_MFC_5_Recipe_Button.Location = New System.Drawing.Point(578, 736)
        Me.Set_MFC_5_Recipe_Button.Name = "Set_MFC_5_Recipe_Button"
        Me.Set_MFC_5_Recipe_Button.ShadowDecoration.BorderRadius = 27
        Me.Set_MFC_5_Recipe_Button.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Set_MFC_5_Recipe_Button.ShadowDecoration.Parent = Me.Set_MFC_5_Recipe_Button
        Me.Set_MFC_5_Recipe_Button.Size = New System.Drawing.Size(64, 39)
        Me.Set_MFC_5_Recipe_Button.TabIndex = 289
        Me.Set_MFC_5_Recipe_Button.Text = "ENTER"
        Me.Set_MFC_5_Recipe_Button.Visible = False
        '
        'Loaded_Progress_5
        '
        Me.Loaded_Progress_5.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_5.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_5.Location = New System.Drawing.Point(614, 175)
        Me.Loaded_Progress_5.Name = "Loaded_Progress_5"
        Me.Loaded_Progress_5.ShadowDecoration.Parent = Me.Loaded_Progress_5
        Me.Loaded_Progress_5.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_5.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_5.TabIndex = 288
        Me.Loaded_Progress_5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_5.UseTransparentBackground = True
        '
        'Loaded_Progress_6
        '
        Me.Loaded_Progress_6.BackColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_6.FillColor = System.Drawing.Color.Transparent
        Me.Loaded_Progress_6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Loaded_Progress_6.Location = New System.Drawing.Point(753, 175)
        Me.Loaded_Progress_6.Name = "Loaded_Progress_6"
        Me.Loaded_Progress_6.ShadowDecoration.Parent = Me.Loaded_Progress_6
        Me.Loaded_Progress_6.Size = New System.Drawing.Size(10, 552)
        Me.Loaded_Progress_6.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Loaded_Progress_6.TabIndex = 287
        Me.Loaded_Progress_6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Loaded_Progress_6.UseTransparentBackground = True
        '
        'MFC_6_Read_Flow
        '
        Me.MFC_6_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_6_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_6_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_6_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_6_Read_Flow.Location = New System.Drawing.Point(785, 736)
        Me.MFC_6_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_6_Read_Flow.Name = "MFC_6_Read_Flow"
        Me.MFC_6_Read_Flow.ReadOnly = True
        Me.MFC_6_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_6_Read_Flow.TabIndex = 286
        Me.MFC_6_Read_Flow.Text = "0.00"
        Me.MFC_6_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_6_Read_Flow.WordWrap = False
        '
        'MFC_6_Recipe_Flow
        '
        Me.MFC_6_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_6_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_6_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_6_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_6_Recipe_Flow.Location = New System.Drawing.Point(785, 761)
        Me.MFC_6_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_6_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_6_Recipe_Flow.Name = "MFC_6_Recipe_Flow"
        Me.MFC_6_Recipe_Flow.ReadOnly = True
        Me.MFC_6_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_6_Recipe_Flow.TabIndex = 285
        Me.MFC_6_Recipe_Flow.Text = "???"
        Me.MFC_6_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_6_Recipe_Flow.WordWrap = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(624, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox1.TabIndex = 283
        Me.PictureBox1.TabStop = False
        '
        'Loaded_Progress_5_0
        '
        Me.Loaded_Progress_5_0.AutoSize = True
        Me.Loaded_Progress_5_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_5_0.Location = New System.Drawing.Point(566, 717)
        Me.Loaded_Progress_5_0.Name = "Loaded_Progress_5_0"
        Me.Loaded_Progress_5_0.Size = New System.Drawing.Size(45, 13)
        Me.Loaded_Progress_5_0.TabIndex = 284
        Me.Loaded_Progress_5_0.Text = "0 SLPM"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(763, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 552)
        Me.PictureBox2.TabIndex = 279
        Me.PictureBox2.TabStop = False
        '
        'Loaded_Progress_6_100
        '
        Me.Loaded_Progress_6_100.AutoSize = True
        Me.Loaded_Progress_6_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_6_100.Location = New System.Drawing.Point(716, 175)
        Me.Loaded_Progress_6_100.Name = "Loaded_Progress_6_100"
        Me.Loaded_Progress_6_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_6_100.TabIndex = 280
        Me.Loaded_Progress_6_100.Text = "0.000"
        '
        'Loaded_Progress_6_50
        '
        Me.Loaded_Progress_6_50.AutoSize = True
        Me.Loaded_Progress_6_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_6_50.Location = New System.Drawing.Point(716, 445)
        Me.Loaded_Progress_6_50.Name = "Loaded_Progress_6_50"
        Me.Loaded_Progress_6_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_6_50.TabIndex = 281
        Me.Loaded_Progress_6_50.Text = "0.000"
        '
        'Loaded_Progress_6_0
        '
        Me.Loaded_Progress_6_0.AutoSize = True
        Me.Loaded_Progress_6_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_6_0.Location = New System.Drawing.Point(705, 717)
        Me.Loaded_Progress_6_0.Name = "Loaded_Progress_6_0"
        Me.Loaded_Progress_6_0.Size = New System.Drawing.Size(45, 13)
        Me.Loaded_Progress_6_0.TabIndex = 282
        Me.Loaded_Progress_6_0.Text = "0 SLPM"
        '
        'ProgressBar6
        '
        Me.ProgressBar6.AutoRoundedCorners = True
        Me.ProgressBar6.BorderRadius = 24
        Me.ProgressBar6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar6.Location = New System.Drawing.Point(787, 175)
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar6.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar6.ShadowDecoration.Parent = Me.ProgressBar6
        Me.ProgressBar6.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar6.TabIndex = 278
        Me.ProgressBar6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'MFC_6_Label
        '
        Me.MFC_6_Label.AutoSize = True
        Me.MFC_6_Label.BackColor = System.Drawing.Color.White
        Me.MFC_6_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_6_Label.Location = New System.Drawing.Point(760, 138)
        Me.MFC_6_Label.Name = "MFC_6_Label"
        Me.MFC_6_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_6_Label.TabIndex = 274
        Me.MFC_6_Label.Text = "MFC#6"
        '
        'MFC_5_Label
        '
        Me.MFC_5_Label.AutoSize = True
        Me.MFC_5_Label.BackColor = System.Drawing.Color.White
        Me.MFC_5_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_5_Label.Location = New System.Drawing.Point(620, 138)
        Me.MFC_5_Label.Name = "MFC_5_Label"
        Me.MFC_5_Label.Size = New System.Drawing.Size(91, 29)
        Me.MFC_5_Label.TabIndex = 273
        Me.MFC_5_Label.Text = "MFC#5"
        '
        'MFC_5_Read_Flow
        '
        Me.MFC_5_Read_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_5_Read_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_5_Read_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_5_Read_Flow.ForeColor = System.Drawing.Color.Red
        Me.MFC_5_Read_Flow.Location = New System.Drawing.Point(643, 736)
        Me.MFC_5_Read_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_5_Read_Flow.Name = "MFC_5_Read_Flow"
        Me.MFC_5_Read_Flow.ReadOnly = True
        Me.MFC_5_Read_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_5_Read_Flow.TabIndex = 276
        Me.MFC_5_Read_Flow.Text = "0.00"
        Me.MFC_5_Read_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_5_Read_Flow.WordWrap = False
        '
        'MFC_5_Recipe_Flow
        '
        Me.MFC_5_Recipe_Flow.BackColor = System.Drawing.Color.White
        Me.MFC_5_Recipe_Flow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MFC_5_Recipe_Flow.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MFC_5_Recipe_Flow.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.MFC_5_Recipe_Flow.Location = New System.Drawing.Point(643, 761)
        Me.MFC_5_Recipe_Flow.Margin = New System.Windows.Forms.Padding(2)
        Me.MFC_5_Recipe_Flow.MinimumSize = New System.Drawing.Size(38, 20)
        Me.MFC_5_Recipe_Flow.Name = "MFC_5_Recipe_Flow"
        Me.MFC_5_Recipe_Flow.ReadOnly = True
        Me.MFC_5_Recipe_Flow.Size = New System.Drawing.Size(59, 25)
        Me.MFC_5_Recipe_Flow.TabIndex = 275
        Me.MFC_5_Recipe_Flow.Text = "???"
        Me.MFC_5_Recipe_Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MFC_5_Recipe_Flow.WordWrap = False
        '
        'Loaded_Progress_5_75
        '
        Me.Loaded_Progress_5_75.AutoSize = True
        Me.Loaded_Progress_5_75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_5_75.Location = New System.Drawing.Point(580, 309)
        Me.Loaded_Progress_5_75.Name = "Loaded_Progress_5_75"
        Me.Loaded_Progress_5_75.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_5_75.TabIndex = 296
        Me.Loaded_Progress_5_75.Text = "0.000"
        '
        'Loaded_Progress_5_25
        '
        Me.Loaded_Progress_5_25.AutoSize = True
        Me.Loaded_Progress_5_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_5_25.Location = New System.Drawing.Point(581, 585)
        Me.Loaded_Progress_5_25.Name = "Loaded_Progress_5_25"
        Me.Loaded_Progress_5_25.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_5_25.TabIndex = 295
        Me.Loaded_Progress_5_25.Text = "0.000"
        '
        'Loaded_Progress_5_100
        '
        Me.Loaded_Progress_5_100.AutoSize = True
        Me.Loaded_Progress_5_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_5_100.Location = New System.Drawing.Point(577, 177)
        Me.Loaded_Progress_5_100.Name = "Loaded_Progress_5_100"
        Me.Loaded_Progress_5_100.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_5_100.TabIndex = 293
        Me.Loaded_Progress_5_100.Text = "0.000"
        '
        'Loaded_Progress_5_50
        '
        Me.Loaded_Progress_5_50.AutoSize = True
        Me.Loaded_Progress_5_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loaded_Progress_5_50.Location = New System.Drawing.Point(580, 445)
        Me.Loaded_Progress_5_50.Name = "Loaded_Progress_5_50"
        Me.Loaded_Progress_5_50.Size = New System.Drawing.Size(34, 13)
        Me.Loaded_Progress_5_50.TabIndex = 294
        Me.Loaded_Progress_5_50.Text = "0.000"
        '
        'ProgressBar5
        '
        Me.ProgressBar5.AutoRoundedCorners = True
        Me.ProgressBar5.BorderRadius = 24
        Me.ProgressBar5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar5.Location = New System.Drawing.Point(643, 175)
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar5.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressBar5.ShadowDecoration.Parent = Me.ProgressBar5
        Me.ProgressBar5.Size = New System.Drawing.Size(51, 552)
        Me.ProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar5.TabIndex = 297
        Me.ProgressBar5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1594, 635)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 299
        Me.Label8.Text = "Ellipseometer Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1641, 734)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 301
        Me.Label9.Text = "Pre-Measurement:"
        '
        'PreBox
        '
        Me.PreBox.BackColor = System.Drawing.Color.White
        Me.PreBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.PreBox.Location = New System.Drawing.Point(1641, 771)
        Me.PreBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PreBox.Name = "PreBox"
        Me.PreBox.ReadOnly = True
        Me.PreBox.Size = New System.Drawing.Size(165, 22)
        Me.PreBox.TabIndex = 300
        Me.PreBox.Text = "???"
        Me.PreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PreBox.WordWrap = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1634, 816)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 20)
        Me.Label11.TabIndex = 303
        Me.Label11.Text = "Post-Measurement:"
        '
        'PostBox
        '
        Me.PostBox.BackColor = System.Drawing.Color.White
        Me.PostBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PostBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.PostBox.Location = New System.Drawing.Point(1641, 845)
        Me.PostBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PostBox.Name = "PostBox"
        Me.PostBox.ReadOnly = True
        Me.PostBox.Size = New System.Drawing.Size(165, 22)
        Me.PostBox.TabIndex = 302
        Me.PostBox.Text = "???"
        Me.PostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PostBox.WordWrap = False
        '
        'EllipseScanBtn
        '
        Me.EllipseScanBtn.AutoRoundedCorners = True
        Me.EllipseScanBtn.BorderRadius = 17
        Me.EllipseScanBtn.CheckedState.Parent = Me.EllipseScanBtn
        Me.EllipseScanBtn.CustomImages.Parent = Me.EllipseScanBtn
        Me.EllipseScanBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EllipseScanBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.EllipseScanBtn.ForeColor = System.Drawing.Color.White
        Me.EllipseScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EllipseScanBtn.HoverState.Parent = Me.EllipseScanBtn
        Me.EllipseScanBtn.Location = New System.Drawing.Point(1630, 673)
        Me.EllipseScanBtn.Name = "EllipseScanBtn"
        Me.EllipseScanBtn.ShadowDecoration.BorderRadius = 27
        Me.EllipseScanBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EllipseScanBtn.ShadowDecoration.Parent = Me.EllipseScanBtn
        Me.EllipseScanBtn.Size = New System.Drawing.Size(151, 37)
        Me.EllipseScanBtn.TabIndex = 304
        Me.EllipseScanBtn.Text = "SCAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1804, 784)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 20)
        Me.Label12.TabIndex = 305
        Me.Label12.Text = "nm"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1804, 854)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 20)
        Me.Label14.TabIndex = 306
        Me.Label14.Text = "nm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(1748, 112)
        Me.Label15.MaximumSize = New System.Drawing.Size(1020, 2)
        Me.Label15.MinimumSize = New System.Drawing.Size(2, 505)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(2, 505)
        Me.Label15.TabIndex = 307
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(1586, 619)
        Me.Label5.MaximumSize = New System.Drawing.Size(1020, 2)
        Me.Label5.MinimumSize = New System.Drawing.Size(2, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(2, 505)
        Me.Label5.TabIndex = 308
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DemoRecipeToolStripMenuItem
        '
        Me.DemoRecipeToolStripMenuItem.Name = "DemoRecipeToolStripMenuItem"
        Me.DemoRecipeToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.DemoRecipeToolStripMenuItem.Text = "Constant Demo Run"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2065, 910)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.EllipseScanBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PostBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PreBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.Loaded_Progress_5_75)
        Me.Controls.Add(Me.Loaded_Progress_5_25)
        Me.Controls.Add(Me.Loaded_Progress_5_100)
        Me.Controls.Add(Me.Loaded_Progress_5_50)
        Me.Controls.Add(Me.Loaded_Progress_6_75)
        Me.Controls.Add(Me.Loaded_Progress_6_25)
        Me.Controls.Add(Me.Set_MFC_6_Recipe_Button)
        Me.Controls.Add(Me.Set_MFC_5_Recipe_Button)
        Me.Controls.Add(Me.Loaded_Progress_5)
        Me.Controls.Add(Me.Loaded_Progress_6)
        Me.Controls.Add(Me.MFC_6_Read_Flow)
        Me.Controls.Add(Me.MFC_6_Recipe_Flow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Loaded_Progress_5_0)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Loaded_Progress_6_100)
        Me.Controls.Add(Me.Loaded_Progress_6_50)
        Me.Controls.Add(Me.Loaded_Progress_6_0)
        Me.Controls.Add(Me.ProgressBar6)
        Me.Controls.Add(Me.MFC_6_Label)
        Me.Controls.Add(Me.MFC_5_Label)
        Me.Controls.Add(Me.MFC_5_Read_Flow)
        Me.Controls.Add(Me.MFC_5_Recipe_Flow)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LEDTrackBar)
        Me.Controls.Add(Me.auto_tune_label)
        Me.Controls.Add(Me.AutoManBtn)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Guna2TextBox9)
        Me.Controls.Add(Me.Guna2TextBox10)
        Me.Controls.Add(Me.Guna2TextBox11)
        Me.Controls.Add(Me.Guna2TextBox12)
        Me.Controls.Add(Me.Guna2TextBox13)
        Me.Controls.Add(Me.Guna2TextBox14)
        Me.Controls.Add(Me.Guna2TextBox15)
        Me.Controls.Add(Me.Guna2TextBox16)
        Me.Controls.Add(Me.Guna2TextBox5)
        Me.Controls.Add(Me.Guna2TextBox6)
        Me.Controls.Add(Me.Guna2TextBox7)
        Me.Controls.Add(Me.Guna2TextBox8)
        Me.Controls.Add(Me.Guna2TextBox3)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.CTLStatusLabel)
        Me.Controls.Add(Me.ControllerLabel)
        Me.Controls.Add(Me.contollerONSquare)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LaserSenseSquare)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.BatchLoggingBTN)
        Me.Controls.Add(Me.BatchIDTextBox)
        Me.Controls.Add(Me.PurgeOnLabel)
        Me.Controls.Add(Me.N2PurgeSquare)
        Me.Controls.Add(Me.N2Purgelabel)
        Me.Controls.Add(Me.N2Purgebtn)
        Me.Controls.Add(Me.EngLabel)
        Me.Controls.Add(Me.Line_Label2)
        Me.Controls.Add(Me.DateTimeLabel1)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.InitAxesBtn)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ChuckVacSquare)
        Me.Controls.Add(Me.Loaded_Progress_1_75)
        Me.Controls.Add(Me.Loaded_Progress_2_75)
        Me.Controls.Add(Me.Loaded_Progress_1_25)
        Me.Controls.Add(Me.Loaded_Progress_2_25)
        Me.Controls.Add(Me.Loaded_Progress_4_75)
        Me.Controls.Add(Me.Loaded_Progress_3_75)
        Me.Controls.Add(Me.Loaded_Progress_4_25)
        Me.Controls.Add(Me.Loaded_Progress_3_25)
        Me.Controls.Add(Me.ClearAbortbtn)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.SetXMinBtn)
        Me.Controls.Add(Me.SetXMaxBtn)
        Me.Controls.Add(Me.AutoVacSquare)
        Me.Controls.Add(Me.RecipeYMinTxt)
        Me.Controls.Add(Me.RecipeYMaxTxt)
        Me.Controls.Add(Me.RecipeXMinTxt)
        Me.Controls.Add(Me.RecipeXMaxTxt)
        Me.Controls.Add(Me.LabelLock)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.MB_Right_Arrow)
        Me.Controls.Add(Me.PH_Temp_Label)
        Me.Controls.Add(Me.Com_Port_Label)
        Me.Controls.Add(Me.com_portBox)
        Me.Controls.Add(Me.Start_Stop_Toggle)
        Me.Controls.Add(Me.SetSpeedBtn)
        Me.Controls.Add(Me.SetCyclesBtn)
        Me.Controls.Add(Me.SetGapBtn)
        Me.Controls.Add(Me.SetOverlapBtn)
        Me.Controls.Add(Me.SetThicknessBtn)
        Me.Controls.Add(Me.SetDiameterBtn)
        Me.Controls.Add(Me.SetTwoSpotBtn)
        Me.Controls.Add(Me.RecipeTunerTxt)
        Me.Controls.Add(Me.SetRecipeTunerBtn)
        Me.Controls.Add(Me.SetRecipeWattsBtn)
        Me.Controls.Add(Me.Set_MFC_4_Recipe_Button)
        Me.Controls.Add(Me.Set_MFC_2_Recipe_Button)
        Me.Controls.Add(Me.Set_MFC_3_Recipe_Button)
        Me.Controls.Add(Me.Set_MFC_1_Recipe_Button)
        Me.Controls.Add(Me.PinsSquare)
        Me.Controls.Add(Me.Vacbtn)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.RecipeCyclesTxt_OPER)
        Me.Controls.Add(Me.Loaded_Progress_1)
        Me.Controls.Add(Me.Loaded_Progress_2)
        Me.Controls.Add(Me.Loaded_Progress_3)
        Me.Controls.Add(Me.MFC_4_Read_Flow)
        Me.Controls.Add(Me.MFC_4_Recipe_Flow)
        Me.Controls.Add(Me.MFC_3_Read_Flow)
        Me.Controls.Add(Me.MFC_3_Recipe_Flow)
        Me.Controls.Add(Me.MFC_2_Read_Flow)
        Me.Controls.Add(Me.MFC_2_Recipe_Flow)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Loaded_Progress_1_100)
        Me.Controls.Add(Me.Loaded_Progress_1_50)
        Me.Controls.Add(Me.RecipeWattsTxt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Loaded_Progress_2_100)
        Me.Controls.Add(Me.Loaded_Progress_2_50)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Loaded_Progress_3_100)
        Me.Controls.Add(Me.Loaded_Progress_3_50)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Loaded_Progress_4)
        Me.Controls.Add(Me.HomeAxesBtn)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.MB_Tune_Label)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Watts2_Label)
        Me.Controls.Add(Me.RF_Reflected_Label)
        Me.Controls.Add(Me.ActiveRecipeName)
        Me.Controls.Add(Me.Line_Label4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RecipeButtonPins)
        Me.Controls.Add(Me.RunScanBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RF_Label)
        Me.Controls.Add(Me.Line_Label3)
        Me.Controls.Add(Me.MFC_4_Label)
        Me.Controls.Add(Me.MFC_3_Label)
        Me.Controls.Add(Me.MFC_2_Label)
        Me.Controls.Add(Me.MFC_1_Label)
        Me.Controls.Add(Me.AxesZActual)
        Me.Controls.Add(Me.AxesYActual)
        Me.Controls.Add(Me.AxesXActual)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MB_Left_Arrow)
        Me.Controls.Add(Me.RecipeCyclesTxt)
        Me.Controls.Add(Me.RecipeSpeedTxt)
        Me.Controls.Add(Me.RecipeOverLapTxt)
        Me.Controls.Add(Me.RecipeGapTxt)
        Me.Controls.Add(Me.NextStepTxtBox)
        Me.Controls.Add(Me.RecipeThicknessTxt)
        Me.Controls.Add(Me.RflWattsTxt)
        Me.Controls.Add(Me.MFC_1_Read_Flow)
        Me.Controls.Add(Me.C_Label)
        Me.Controls.Add(Me.Watts_Label)
        Me.Controls.Add(Me.CurrentStepTxtBox)
        Me.Controls.Add(Me.RunRcpBtn)
        Me.Controls.Add(Me.ActTunerTxt)
        Me.Controls.Add(Me.ActWattsTxt)
        Me.Controls.Add(Me.RF_Radial)
        Me.Controls.Add(Me.RF_Reflected_Radial)
        Me.Controls.Add(Me.PHTempTxt)
        Me.Controls.Add(Me.Temp_Radial)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Loaded_Progress_4_100)
        Me.Controls.Add(Me.Loaded_Progress_4_50)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MFC_1_Recipe_Flow)
        Me.Controls.Add(Me.MB_Pos_Bar)
        Me.Controls.Add(Me.SetYMaxBtn)
        Me.Controls.Add(Me.AC_CODE)
        Me.Controls.Add(Me.Door_Open_Label)
        Me.Controls.Add(Me.SetYMinBtn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OntosCLEAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MB_Left_Arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MB_Right_Arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents MFC_1_Read_Flow As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ActWattsTxt As System.Windows.Forms.TextBox
    Friend WithEvents RF_Label As System.Windows.Forms.Label
    Friend WithEvents RflWattsTxt As System.Windows.Forms.TextBox
    Friend WithEvents Watts_Label As System.Windows.Forms.Label
    Friend WithEvents PHTempTxt As System.Windows.Forms.TextBox
    Friend WithEvents C_Label As System.Windows.Forms.Label
    Friend WithEvents PH_Temp_Label As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Controller_1_Label As System.Windows.Forms.Label
    Friend WithEvents SetDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_Tune_Label As System.Windows.Forms.Label
    Friend WithEvents RecipeTunerTxt As System.Windows.Forms.TextBox
    Friend WithEvents ActTunerTxt As System.Windows.Forms.TextBox
    Friend WithEvents RestartAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableServiceMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetCTLToPLSimModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_Left_Arrow As System.Windows.Forms.PictureBox
    Friend WithEvents MB_Right_Arrow As System.Windows.Forms.PictureBox
    Friend WithEvents Abort_Label As System.Windows.Forms.Label
    Friend WithEvents AxesXActual As System.Windows.Forms.TextBox
    Friend WithEvents Actual_X_Label As System.Windows.Forms.Label
    Friend WithEvents AxesYActual As System.Windows.Forms.TextBox
    Friend WithEvents Actual_Y_Label As System.Windows.Forms.Label
    Friend WithEvents AxesZActual As System.Windows.Forms.TextBox
    Friend WithEvents Actual_Z_Label As System.Windows.Forms.Label
    Friend WithEvents X1_Label As System.Windows.Forms.Label
    Friend WithEvents X2_Label As System.Windows.Forms.Label
    Friend WithEvents Y1_Label As System.Windows.Forms.Label
    Friend WithEvents Y2_Label As System.Windows.Forms.Label
    Friend WithEvents RecipeThicknessTxt As System.Windows.Forms.TextBox
    Friend WithEvents RecipeGapTxt As System.Windows.Forms.TextBox
    Friend WithEvents RecipeOverLapTxt As System.Windows.Forms.TextBox
    Friend WithEvents RecipeSpeedTxt As System.Windows.Forms.TextBox
    Friend WithEvents RecipeCyclesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Y2_MM_Label As System.Windows.Forms.Label
    Friend WithEvents Actual_X_MM_Label As System.Windows.Forms.Label
    Friend WithEvents Actual_Y_MM_Label As System.Windows.Forms.Label
    Friend WithEvents Actual_Z_MM_Label As System.Windows.Forms.Label
    Friend WithEvents NextStepTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentStepTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents MBScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StageTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EngineerModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatorModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MFC_4_Label As Label
    Friend WithEvents MFC_3_Label As Label
    Friend WithEvents MFC_2_Label As Label
    Friend WithEvents MFC_1_Label As Label
    Friend WithEvents Line_Label2 As Label
    Friend WithEvents Line_Label3 As Label
    Friend WithEvents RunRcpBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InitAxesBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RunScanBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RecipeButtonPins As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Line_Label4 As Label
    Public WithEvents ActiveRecipeName As TextBox
    Friend WithEvents RF_Reflected_Label As Label
    Friend WithEvents RF_Reflected_Radial As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents Tuner_Label As Label
    Friend WithEvents Watts2_Label As Label
    Friend WithEvents ProgressBar4 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents HomeAxesBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Com_Port_Label As Label
    Friend WithEvents Start_Stop_Toggle As CheckBox
    Friend WithEvents com_portBox As ComboBox
    Friend WithEvents Temp_Radial As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents ProgressBar2 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents ProgressBar3 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Loaded_Progress_4_100 As Label
    Friend WithEvents Loaded_Progress_4_50 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Loaded_Progress_3_100 As Label
    Friend WithEvents Loaded_Progress_3_50 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Loaded_Progress_2_100 As Label
    Friend WithEvents Loaded_Progress_2_50 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Loaded_Progress_1_100 As Label
    Friend WithEvents Loaded_Progress_1_50 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents RecipeWattsTxt As TextBox
    Public WithEvents MFC_1_Recipe_Flow As TextBox
    Friend WithEvents MFC_2_Read_Flow As TextBox
    Public WithEvents MFC_2_Recipe_Flow As TextBox
    Friend WithEvents MFC_3_Read_Flow As TextBox
    Public WithEvents MFC_3_Recipe_Flow As TextBox
    Friend WithEvents MFC_4_Read_Flow As TextBox
    Public WithEvents MFC_4_Recipe_Flow As TextBox
    Friend WithEvents Loaded_Progress_2 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Loaded_Progress_1 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents AC_CODE As Label
    Friend WithEvents AxesXActual_OPER As TextBox
    Friend WithEvents AxesYActual_OPER As TextBox
    Friend WithEvents AxesZActual_OPER As TextBox
    Friend WithEvents RecipeCyclesTxt_OPER As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Vacbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PinsSquare As Label
    Friend WithEvents Set_MFC_1_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Set_MFC_3_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Set_MFC_2_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Set_MFC_4_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetRecipeWattsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetRecipeTunerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Loaded_Progress_3 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents SetTwoSpotBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetDiameterBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetThicknessBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetOverlapBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetSpeedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetCyclesBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MB_Pos_Bar As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents Loaded_Progress_4 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Label26 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LabelLock As Label
    Friend WithEvents RecipeXMaxTxt As TextBox
    Friend WithEvents RecipeXMinTxt As TextBox
    Friend WithEvents RecipeYMaxTxt As TextBox
    Friend WithEvents RecipeYMinTxt As TextBox
    Friend WithEvents SetXMaxBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetYMaxBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetYMinBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SetXMinBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents ClearAbortbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Loaded_Progress_3_25 As Label
    Friend WithEvents Loaded_Progress_4_25 As Label
    Friend WithEvents Loaded_Progress_3_75 As Label
    Friend WithEvents Loaded_Progress_4_75 As Label
    Friend WithEvents Loaded_Progress_2_25 As Label
    Friend WithEvents Loaded_Progress_1_25 As Label
    Friend WithEvents Loaded_Progress_1_75 As Label
    Friend WithEvents Loaded_Progress_2_75 As Label
    Friend WithEvents ChuckVacSquare As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents AutoVacSquare As Label
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents DateTimeLabel1 As Label
    Friend WithEvents EngLabel As Label
    Friend WithEvents RF_Radial As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents N2Purgelabel As Label
    Friend WithEvents N2Purgebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PurgeOnLabel As Label
    Friend WithEvents N2PurgeSquare As Label
    Friend WithEvents BatchLoggingBTN As Guna.UI2.WinForms.Guna2Button
    Public WithEvents BatchIDTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LaserSenseSquare As Label
    Friend WithEvents Door_Open_Label As Label
    Friend WithEvents BuildRecipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenCascadeRecipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ControllerLabel As Label
    Friend WithEvents contollerONSquare As Label
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailedLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTLStatusLabel As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox7 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox8 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox9 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox10 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox11 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox12 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox13 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox14 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox15 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox16 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ControllerStatusLEDSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoManBtn As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents auto_tune_label As Label
    Friend WithEvents LEDTrackBar As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Loaded_Progress_6_75 As Label
    Friend WithEvents Loaded_Progress_6_25 As Label
    Friend WithEvents Set_MFC_6_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Set_MFC_5_Recipe_Button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Loaded_Progress_5 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Loaded_Progress_6 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents MFC_6_Read_Flow As TextBox
    Public WithEvents MFC_6_Recipe_Flow As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Loaded_Progress_5_0 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Loaded_Progress_6_100 As Label
    Friend WithEvents Loaded_Progress_6_50 As Label
    Friend WithEvents Loaded_Progress_6_0 As Label
    Friend WithEvents ProgressBar6 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents MFC_6_Label As Label
    Friend WithEvents MFC_5_Label As Label
    Friend WithEvents MFC_5_Read_Flow As TextBox
    Public WithEvents MFC_5_Recipe_Flow As TextBox
    Friend WithEvents Loaded_Progress_5_75 As Label
    Friend WithEvents Loaded_Progress_5_25 As Label
    Friend WithEvents Loaded_Progress_5_100 As Label
    Friend WithEvents Loaded_Progress_5_50 As Label
    Friend WithEvents SetGapBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProgressBar5 As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents PlasmaLEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PreBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PostBox As TextBox
    Friend WithEvents EllipseScanBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DemoRecipeToolStripMenuItem As ToolStripMenuItem
End Class
