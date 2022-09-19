Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO
Imports System.String


Public Class MainWindow

    Public Shared SelectedWaferSize As Integer = 0 'Public to be shared between OTTForm and DiameterEntryDialog

    'Public to be shared between OTTForm and SettingsDialog
    Public Shared b_toggleHeater As Boolean = False ' This is the flag for toggle heater
    Public Shared b_heaterActive As Boolean = False
    Public Shared st_HasHeatSave As String = 0 'For saving the HEATER on/off state
    'Batch ID Logging
    Public Shared b_togglebatchIDLogging As Boolean = False ' This is the flag for batch ID logging
    Public Shared b_batchActive As Boolean = False   
    'Auto Scan
    Public Shared b_toggleAutoScan As Boolean = true   
    Public Shared b_autoScanActive As Boolean = True   
    Public Shared st_AutoScanSave As String = 1 'For saving the AUTO SCAN state   
    '
    Public Shared b_HasCollision As Boolean = False 'the tool has a Collision System on 
    

    '    Serial Port Stuff
    Dim CR As String = Chr(13)
    Dim LF As String = Chr(10)
    Dim ar_myPort As Array
    Dim st_LastCMD As String ' for debug
    Dim st_RCV As String
    Dim st_Was As String

    Dim WaferDiameter As Integer = 0
    'Recipe file management stuff
    Dim st_RecipePath As String = "C:\OTT_PLUS\Recipes\" 'Recipe Path without filename
    Dim st_RecipePathFileName As String 'Recipe filename with path information
    Dim st_RecipeFileName As String = "none_entered" 'Recipe filename for display
    Dim st_RecipeString As String 'Recipe file contents as continuous string
    Dim st_RecipeLines As String() 'st_RecipeString partitioned into array of parameter lines
    Dim st_RecipeParamStrArray As String() 'RecipeLine partitioned into Parameter and Value segments
    Dim st_RecipeParamName As String 'Parameter name part of a  RecipeLine
    Dim st_RecipeParamValue As String 'Value part of a RecipeLine
    Dim b_RecipeOpened As Boolean = False 'has a recipe been opened?

    'Configuration file management stuff
    Dim ExeConfigPath As String = "C:\OTT_PLUS\ExeConfig\" 'Configuration path without filename
    Dim ExeConfigPathFileName As String 'Config filename with path information
    Dim ExeConfigFileName As String = "default" 'Config filename for display
    Dim ExeConfigString As String 'Config file contents as continuous string
    Dim ExeConfigLines As String() 'ConfigString partitioned into array of parameter lines
    Dim ExeConfigParamStrArray As String() 'ConfigLine partitioned into Parameter and Value segments
    Dim ExeConfigParamName As String 'Parameter name part of a  ConfigLine
    Dim ExeConfigParamValue As String 'Value part of a ConfigLine
    Dim ExeConfigOpened As Boolean = False 'has a Config been opened?
    Structure EXE_CONFIG
        Dim MFC_LABEL_1 As String
        Dim MFC_LABEL_2 As String
        Dim MFC_LABEL_3 As String
        Dim MFC_LABEL_4 As String
        Dim KNOWN_COM_PORT As String 'stores the last known com port       
    End Structure
    Dim Exe_Cfg As EXE_CONFIG

    Dim st_LogFilePath As String = "C:\OTT_PLUS\Logs\"
    Dim st_LogPathFileName As String
    Dim st_LogFileName As String = "Log"
    Dim st_LogLine As String
    Dim LogLineOut As StreamWriter
    Dim st_TimeStamp As System.String
    Dim b_LogOpen As Boolean = False

    Dim b_Step_MB_SM_Left As Boolean = False
    Dim b_Step_MB_SM_Right As Boolean = False
    Dim b_SetDefaultRecipe As Boolean = False

    'Comm port stuff
    Dim b_CommPortSelected As Boolean = False
    Dim b_foundKnownComPort As Boolean = False
    Dim b_ShutDownComms As Boolean = False
    Dim st_KnownComPort As String
    Dim b_Start_Stop_ON_OFF As Boolean
    '    Dim NO_RS485 As Boolean = True
    Dim b_ErrorStateActive As Boolean = False

    'PCB Parameter Storage
    Structure PARAMETERS

        Dim db_X_Max_Pos As Double
        Dim db_Y_Max_Pos As Double
        Dim db_Z_Head_Pos As Double

        Dim db_X_Max_Speed As Double
        Dim db_Y_Max_Speed As Double
        Dim db_Z_Max_Speed As Double

        Dim db_X_Home_Pos As Double
        Dim db_Y_Home_Pos As Double
        Dim db_Z_Home_Pos As Double

    End Structure
    Dim Param As PARAMETERS

    'MFC management
    Dim NumMFC As Integer = 0
    Structure MFController
        Dim ActualFlow As Integer
        Dim db_ActualFlow As Double
        Dim db_RecipeFlow As Double
        Dim db_LoadedFlow As Double
        Dim db_Range As Double
        Dim b_MFCLoadRecipeFlow As Boolean
    End Structure
    Dim MFC(4) As MFController
    'Collision Laser Management
    Structure CLASERSM
        Dim State As Integer
    End Structure
    Dim CLaser As CLASERSM

    Const CLSM_IDLE = 0 
    Const CLSM_TRIPPED = 1 'Laser COLLISION DETECTED
    Const CLSM_ACTIVATE = 2 'Turn Laser Sense ON
    Const CLSM_DEACTIVATE = 3 'Turn Laser Sense OFF
    'Light Tower Management
    Structure LIGHTSM
        Dim State As Integer
    End Structure
    Dim LightTwr As LIGHTSM

    Const LTSM_IDLE = 0
    Const LTSM_ERROR = 1 'Red light
    Const LTSM_READY = 2 'Amber light
    Const LTSM_ACTIVE = 3 'Green light

    'RF Power Management
    Structure PWR
        Dim RecipeSetPoint As Integer
        Dim LoadedSetPoint As Integer
        Dim ActualPForward As Integer
        Dim ActualPReflected As Integer
        Dim b_LoadRecipePower As Boolean
    End Structure
    Dim RF As PWR
    'Axis Status Info
    Structure ASTAT
        Dim LEDStates As Integer

        Dim b_DoorsOpen As Boolean 'This checks the 3-Axis PCB during GetAxesStatus() to check an LED state for doors open
        Dim b_LEDJoyBtnOn As Boolean 'is the joystick button depressed?
        Dim b_XYZSameState As Boolean 'all three axes Same state?
        Dim b_LEDVacOn As Boolean 'is 3-AXIS PCB Valve 3 (Vacuum) On?
        Dim b_LEDN2PurgeOn As Boolean 'is N2 Substrate Purge On?
        'Dim b_CollisionActive As Boolean 'has the laser sensor collision system been triggered?

        Dim XState As Integer
        Dim XError As Integer
        Dim db_XPos As Double
        Dim YState As Integer
        Dim YError As Integer
        Dim db_YPos As Double
        Dim ZState As Integer
        Dim ZError As Integer
        Dim db_ZPos As Double
    End Structure
    Dim AxesStatus As ASTAT
    Dim st_AxesStatusRsp = "" 'Axes Status Response string holder

    'Axis state machine states, maintained in the 3-Axis PCB
    Const ASM_PRE_INIT = 0 'axis not yet initialized
    Const ASM_INIT_START = 1 'Initialize (transition state)
    Const ASM_INIT_WALK_OFF = 2 'on NEG LIMIT, Walk off it
    Const ASM_SET_LIM_OFFSET = 3 'move to limit offset
    Const ASM_INIT_WAIT_END = 4 'Waiting for Init to complete
    Const ASM_ENTER_IDLE = 5 'Transition to IDLE state (turn off JOY, LEDs, etc)
    '------- post init ---------
    Const ASM_IDLE = &H10 'axis idle (initialized but not moving)
    Const ASM_ABS_START = &H11 'Absolute move start (transition state)
    Const ASM_ABS_WAIT = &H12 'Waiting for Abs move to complete
    Const ASM_REL_START = &H13 'Relative move start (transition state)
    Const ASM_REL_WAIT = &H14 'Waiting for Rel move to complete
    Const ASM_JOY_ON = &H15 'Joy Stick Enabled

    'Axis error codes, maintained in the 3-Axis PCB
    Const AER_NO_ERROR = 0 'everything is peachy
    Const AER_MOV_POS_LIM = 1 'command to move on pos limit
    Const AER_MOV_NEG_LIM = 2 'command to move on neg limit
    Const AER_MOVE_ON_MOVE = 3 'command to move while moving
    Const AER_CHG_SPEED_ON_MOVE = 4 'tried to change speed while moving
    Const AER_CHG_MODE_ON_MOVE = 5 'tried to change mode while moving
    Const AER_STOP_ON_MOVE = 6 'Stopped while moving
    Const AER_JOY_MOVE = 7 'tried to enable JOYs while moving

    Structure INITAXESSTATEMACHINE
        Dim State As Integer
    End Structure
    Dim SMInitAxes As INITAXESSTATEMACHINE
    Const IASM_IDLE = 0
    Const IASM_START_UP = 1
    Const IASM_WAIT_FOR_DONE = 2
    Const IASM_INITIALIZED = 3

    Structure HOMEAXESSTATEMACHINE
        Dim State As Integer
    End Structure
    Dim SMHomeAxes As HOMEAXESSTATEMACHINE
    Const HASM_IDLE = 0
    Const HASM_START = 1
    Const HASM_WAIT_PARK_Z = 2
    Const HASM_HOME_XY = 3
    Const HASM_WAIT_HOME_XY = 4
    Const HASM_HOME_Z = 5
    Const HASM_WAIT_HOME_Z = 6
    Const HASM_SHUT_DOWN = 7
    
    Structure TWOSPOTSTATEMACHINE
        Dim State As Integer

        Dim ExternalNewState As Integer 'set this first
        Dim b_ExternalStateChange As Boolean 'then make this true

        Dim db_FirstXPos As Double
        Dim db_FirstYPos As Double
        Dim db_SecondXPos As Double
        Dim db_SecondYPos As Double
    End Structure
    Dim SMTwoSpot As TWOSPOTSTATEMACHINE

    Const TSSM_IDLE = 0
    Const TSSM_START_UP = 1 'start joy stick session
    Const TSSM_GET_FIRST = 2 'get first X & Y pair
    Const TSSM_WAIT_JOY_BTN_OFF = 3 'wait for the operator to release the joy button
    Const TSSM_GET_SECOND = 4 'get second X & Y pair
    Const TSSM_CLOSE_DOWN = 5 'end joystick session


    Structure SCANSTATEMACHINE
        Dim State As Integer
        Dim SubState As Integer

        Dim ExternalNewState As Integer 'set this first
        Dim b_ExternalStateChange As Boolean 'then make this true

        Dim db_XMinPos As Double
        Dim db_XMaxPos As Double
        Dim db_YMinPos As Double
        Dim db_YMaxPos As Double

        Dim db_ZParkPos As Double
        Dim db_ZScanPos As Double

        Dim db_RowXWidth As Double
        Dim db_ColYLen As Double
        Dim db_StartXPosition As Double
        Dim db_StartYPosition As Double
        Dim db_EndYPosition As Double
        Dim db_ScanYSpeed As Double

        Dim NumXRows As Integer
        Dim ThisXRow As Integer
        Dim NumCycles As Integer
        Dim ThisCycleNum As Integer

    End Structure
    Dim SMScan As SCANSTATEMACHINE

    Const SCSM_IDLE = 0
    Const SCSM_START_UP = 1
    Const SCSM_SCAN = 2
    Const SCSM_RECYCLE = 3
    Const SCSM_SHUT_DOWN = 4

    Const SCSM_SUB_IDLE = 0
    Const SCSM_SUB_PARK_Z = 1
    Const SCSM_SUB_GO_XY_START = 2
    Const SCSM_SUB_GO_Z_SCAN_POS = 3
    Const SCSM_SUB_SCAN_COL = 4
    Structure COLLISIONPASSSTATEMACHINE
        Dim State As Integer

    End Structure
    Dim SMCollisionPass As COLLISIONPASSSTATEMACHINE

    Const CPSM_IDLE = 0
    Const CPSM_START_UP = 1
    Const CPSM_GET_Z_DOWN = 2
    Const CPSM_GET_Z_UP = 3
    Const CPSM_SCAN_Y = 4
    Const CPSM_SHUT_DOWN = 5

    'Tuner position management
    Structure TUNER_POS
        Dim LoadedSetPoint As Integer
        Dim db_LoadedSetPointPct As Double
        Dim db_ActualPos As Double
        Dim db_ActualPosPct As Double
        Dim b_LoadTunerPos As Boolean
    End Structure
    Dim TUNER As TUNER_POS

    'for number string validation
    Dim st_EmptyChars As String = ""
    Dim st_DoubleChars As String = "-.0123456789"
    Dim st_IntChars As String = "0123456789"
    Dim st_HexChars As String = "0123456789ABCDEF"

    Dim st_MBRightSpeed As String = "$11010032%" '$110dxxxx%  d=1,0 xxxx = num steps; resp[!110dxxxx#] when move STARTED
    Dim st_MBLeftSpeed As String = "$11000032%" '$110dxxxx%  d=1,0 xxxx = num steps; resp[!110dxxxx#] when move STARTED
    Dim b_MB_Big_Step_Active As Boolean = True

    Dim StatusBits As Integer = 0  'holds results of Status poll
    Dim StatusBitsWas As Integer = 0 'memory for N-1 poll of Status
    Dim HeaterPower As Integer = 0 'holds current heater power setting

    Dim MAXRF_PF_WATTS As Integer 'maximum rated RF watts output => OTTS higher cause 40mm
    Dim b_ENG_mode As Boolean = False 'Determines how the Form loads OPERATOR or ENG mode
    'Dim b_StageControlButton As Boolean = False 'Displays the Stage Controls in Operator Mode

    Dim b_AutoModeOn As Boolean

    Dim b_Owned As Boolean 'the tool is paid for    
    Dim b_N2PurgeRecipe As Boolean 'For turning Recipe Purge on/off during Stage movements
    Dim b_N2PurgeON As Boolean 'For setting the substrate purge on/Off
    Dim st_HasPurgeSave As String = 0 'For saving the substrate purge state
    Dim b_HasPins As Boolean 'For setting the Pins as exposed or buried 
    Dim b_HasHeat As Boolean 'For setting the Heater On/Off
    Dim b_HasVac As Boolean = False 'For setting the chuck vacuum on/Off
    Dim b_plasmaActive As Boolean = False 'For determining when Plasma is ACTIVE    
    Dim b_CollisionPassed As Boolean = False 'the tool has performed a collision test with NO collision.
    Dim b_PlannedAutoStart As Boolean = False 'This is strictly for Auto Start PLasma, to prevent RUN SCAN from starting plasma.
    

    Dim b_LightTowerError As Boolean = False 'Flag for light tower (might not need)
    Dim b_toggleDoorsOpen As Boolean = False 'Just for flashing the doors open 

    Dim GlobalmyStatusBits As Integer 'This is used for light tower management

    Dim b_ClearAbort As Boolean = False ' This is the flag for Abort Button flash
    Dim b_toggleClearAbort As Boolean = False ' This is for making the Clear Abort button flash
    
    
    Dim b_ToggleAutoMode As Boolean = False
    Dim b_RunRecipeOn As Boolean = False 'the Light tower will check this value
    Dim b_ToggleRunRecipe As Boolean = False
    Dim b_RunRcpBtnColor As Boolean = False
    Dim b_LoadRcpBtnColor As Boolean = False
    Dim b_HasHeater As Boolean = False
    
    
    Dim b_CreateRecipe As Boolean = False

    'Collections to allow indexing into certain controls
    Dim RecipeValues As New Collection
    Dim EnterButtons As New Collection
    Dim StageButtons As New Collection
    Dim StageEnterButtons As New Collection
    Dim MFCProgressValue As New Collection
    Dim MFCActualFlow As New Collection
    Dim MFCRecipeFlow As New Collection
    Dim MFCLoadedFlow As New Collection
    Dim MFCRange As New Collection
    Dim MFCTextButton As New Collection

    ' State Machine Cases
    Const IDLE = 0
    Const STARTUP = 1
    Const POLLING = 2
    Const SHUTDOWN = 3
    Const MB_SCAN_RESET = 4
    Const MB_SCAN_START = 5
    Const MB_SCAN_START_WAIT = 6
    Const MB_SCAN = 7
    Const SM_POLL_PERIOD = 10 '10ths of a second defining POLLING state polling period
    Const SM_POLL_CINDERELLA = 86400 '(86400) 24 hour period to check and make sure the tool is paid 
    'Const MAXRF_PF_WATTS = 200 'maximum rated RF watts output => OTTS higher cause 40mm
    Const MAXRF_PR_WATTS = 33  'maximum rated RF watts reflected
    Const SERIAL_RESPONSE_TIMEOUT = 1000 'timeout waiting for control pcb response (milliseconds)

    ' Controller Error Codes
    Const AC_OK = &H0
    Const AC_NO_N2 = &H1
    Const AC_NO_HEARTBEAT = &H2
    Const AC_NO_GAS_1 = &H3
    Const AC_NO_GAS_2 = &H4
    Const AC_NO_GAS_3 = &H5
    Const AC_NO_GAS_4 = &H6
    Const AC_BAD_HELIUM = &H7
    Const AC_ESTOP = &H8
    Const AC_NO_RS485 = &H9
    Const AC_PWR_FWD_LOW = &HA
    Const AC_OVER_TEMP = &HB

    Dim SM_State As Integer = IDLE
    Dim SM_PollCounter As Integer = 0
    Dim SM_CinderellaCounter As Integer = 0
    Dim st_CTLPCBStatus As String = "" 'memorizes last status response string
    Dim CTLResetTimeOut As Integer = 0     '100millisec granular time-out timer value
    Dim AUXResetTimeOut As Integer = 0     '100millisec granular time-out timer value

    'Coord System Info
    Structure COORD_SYS
        Dim db_Xp_2_Base As Double 'offset X PH relative to Base
        Dim db_Yp_2_Base As Double 'offset Y PH relative to Base
        Dim db_Zp_2_Base As Double 'offset Z PH relative to Base
        Dim db_Xs_2_PH As Double   'offset X Spot relative to PH
        Dim db_Ys_2_PH As Double   'offset Y Spot relative to PH

        Dim db_LoadPos_X_Base As Double 'Load Position X relative to Base
        Dim db_LoadPos_Y_Base As Double 'Load Position Y relative to Base
        Dim db_LoadPos_Z_Base As Double 'Load Position Z relative to Base

        Dim db_PlasmaHeadSlitLength As Double 'Plasma head slit length
        Dim db_PlasmaHeadSlitWidth As Double 'Plasma head slit width
        Dim db_ChuckToPlasmaHeadSafetyGap As Double 'Distance between Plasma Head & Chuck when Z at max height
        Dim db_ZPinsBuriedPos As Double 'Distance in Z from reset-0 to bury the lift pins
        Dim db_ZPinsExposedPos As Double 'Distance in Z from reset-0 to expose the lift pins

    End Structure
    Dim CoordParam As COORD_SYS

    '------------------------- Load the form
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim ar_myPort As String()
        Dim responseLen As Integer

        DateTimeLabel1.text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")

        'Make sure we check the Configuration for a known Port
        GetExeCfg()  ' get the exe config parameters

        'Calls to the system for a list of ports
        ar_myPort = IO.Ports.SerialPort.GetPortNames()

        'If you recognise the com Port from what is stored in EXE_CONFIG, set a flag that we found it
        For i = 0 To UBound(ar_myPort)
            If ar_myPort(i) = st_KnownComPort Then b_foundKnownComPort = True
        Next

        'If you found a recognised port, connect to it NOW.
        If b_foundKnownComPort = True Then
            'Start up the serial port
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.BaudRate = "57600"
            SerialPort1.PortName = st_KnownComPort
            SerialPort1.ReadTimeout = SERIAL_RESPONSE_TIMEOUT            'serial port timeout default is 500
            SerialPort1.Open()

            'Ensure the Comms button is set because we AUTO CONNECTED
            b_Start_Stop_ON_OFF = True 'This is true so that if we click the button, it will shut down comms
            Start_Stop_Toggle.BackColor = Color.Green
            Start_Stop_Toggle.Text = "CONNECTED"
            RunRcpBtn.Visible = True
            If b_ENG_mode Then
                AutoManBtn.Visible = True
            End If

            'Reset the controller PCB and give it time to do so
            WriteCommand("$A9%", 4)  'SOFT_RESET   $A9%; resp[!A9#]; causes Aux PCB Soft Reset
            ResponseLen = ReadResponse(0)
            AUXResetTimeOut = 2500 / Timer1.Interval  'interval in milliseconds, so get close to 2.5 second wait


            'Reset the controller PCB and give it time to do so
            WriteCommand("$90%", 4)  'SOFT_RESET   $90% ; resp[!90#] Resets CTL PCB
            responseLen = ReadResponse(0)
            CTLResetTimeOut = 2500 / Timer1.Interval  'interval in milliseconds, so get close to 2.5 second wait

            SM_State = STARTUP
            'start up the log file
            OpenLogFile()

            'Set the Dropdown to have the known port 
            com_portBox.Items.Add(st_KnownComPort)
            com_portBox.Text = st_KnownComPort
        Else
            'set-up the comm port drop-box 
            com_portBox.Items.AddRange(ar_myPort)
            com_portBox.Visible = True
            Com_Port_Label.Visible = True
        End If

        'friend the collections with existing display objects to enable array indexing
        MFCActualFlow.Add(MFC_1_Read_Flow)
        MFCActualFlow.Add(MFC_2_Read_Flow)
        MFCActualFlow.Add(MFC_3_Read_Flow)
        MFCActualFlow.Add(MFC_4_Read_Flow)

        MFCRecipeFlow.Add(MFC_1_Recipe_Flow)
        MFCRecipeFlow.Add(MFC_2_Recipe_Flow)
        MFCRecipeFlow.Add(MFC_3_Recipe_Flow)
        MFCRecipeFlow.Add(MFC_4_Recipe_Flow)

        MFCLoadedFlow.Add(MFC_1_Loaded_Flow)
        MFCLoadedFlow.Add(MFC_2_Loaded_Flow)
        MFCLoadedFlow.Add(MFC_3_Loaded_Flow)
        MFCLoadedFlow.Add(MFC_4_Loaded_Flow)

        MFCRange.Add(MFC_1_Read_Range)
        MFCRange.Add(MFC_2_Read_Range)
        MFCRange.Add(MFC_3_Read_Range)
        MFCRange.Add(MFC_4_Read_Range)

        MFCTextButton.Add(Set_MFC_1_Recipe_Button)
        MFCTextButton.Add(Set_MFC_2_Recipe_Button)
        MFCTextButton.Add(Set_MFC_3_Recipe_Button)
        MFCTextButton.Add(Set_MFC_4_Recipe_Button)

        MFCProgressValue.Add(ProgressBar1)
        MFCProgressValue.Add(ProgressBar2)
        MFCProgressValue.Add(ProgressBar3)
        MFCProgressValue.Add(ProgressBar4)
        MFCProgressValue.Add(Loaded_Progress_1)
        MFCProgressValue.Add(Loaded_Progress_2)
        MFCProgressValue.Add(Loaded_Progress_3)
        MFCProgressValue.Add(Loaded_Progress_4)

        StageButtons.Add(Vacbtn)
        StageButtons.Add(RecipeButtonPins)
        StageButtons.Add(InitAxesBtn)
        StageButtons.Add(HomeAxesBtn)
        StageButtons.Add(SetTwoSpotBtn)
        StageButtons.Add(SetDiameterBtn)
        StageButtons.Add(RunScanBtn)
        'StageButtons.Add(AutoScanbtn)

        EnterButtons.Add(Set_MFC_1_Recipe_Button)
        EnterButtons.Add(Set_MFC_2_Recipe_Button)
        EnterButtons.Add(Set_MFC_3_Recipe_Button)
        EnterButtons.Add(Set_MFC_4_Recipe_Button)
        EnterButtons.Add(SetRecipeWattsBtn)
        EnterButtons.Add(SetRecipeTunerBtn)

        StageEnterButtons.Add(SetThicknessBtn)
        StageEnterButtons.Add(SetGapBtn)
        StageEnterButtons.Add(SetOverlapBtn)
        StageEnterButtons.Add(SetSpeedBtn)
        StageEnterButtons.Add(SetCyclesBtn)
        StageEnterButtons.Add(SetXMinBtn)
        StageEnterButtons.Add(SetXMaxBtn)
        StageEnterButtons.Add(SetYMinBtn)
        StageEnterButtons.Add(SetYMaxBtn)

        RecipeValues.Add(MFC_1_Recipe_Flow)
        RecipeValues.Add(MFC_2_Recipe_Flow)
        RecipeValues.Add(MFC_3_Recipe_Flow)
        RecipeValues.Add(MFC_4_Recipe_Flow)
        RecipeValues.Add(RecipeWattsTxt)
        RecipeValues.Add(RecipeTunerTxt)
        RecipeValues.Add(RecipeThicknessTxt)
        RecipeValues.Add(RecipeGapTxt)
        RecipeValues.Add(RecipeOverLapTxt)
        RecipeValues.Add(RecipeSpeedTxt)
        RecipeValues.Add(RecipeCyclesTxt)
        RecipeValues.Add(RecipeXMinTxt)
        RecipeValues.Add(RecipeXMaxTxt)
        RecipeValues.Add(RecipeYMinTxt)
        RecipeValues.Add(RecipeYMaxTxt)
    End Sub
    '------------------------ comm port selection makes the Start-Stop toggle button visible
    Private Sub com_portBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles com_portBox.SelectionChangeCommitted
        'We don't want COMMS to show up if a blank value is selected
        If com_portBox.Text <> "" And b_foundKnownComPort = False Then Start_Stop_Toggle.Visible = True
    End Sub
    Private Sub Start_Stop_CheckedChanged(sender As Object, e As EventArgs) Handles Start_Stop_Toggle.Click
        Dim ResponseLen As Integer

        b_Start_Stop_ON_OFF = Not b_Start_Stop_ON_OFF 'keeps track of what the button is doing.

        If b_Start_Stop_ON_OFF Then
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.BaudRate = "57600"
            SerialPort1.PortName = com_portBox.Text
            SerialPort1.ReadTimeout = SERIAL_RESPONSE_TIMEOUT            'serial port timeout default is 500
            SerialPort1.Open()

            Start_Stop_Toggle.BackColor = Color.Green
            Start_Stop_Toggle.Text = "CONNECTED"
            RunRcpBtn.Visible = True
            If b_ENG_mode Then
                AutoManBtn.Visible = True
            End If

            'Reset the controller PCB and give it time to do so
            WriteCommand("$A9%", 4)  'SOFT_RESET   $A9%; resp[!A9#]; causes Aux PCB Soft Reset
            ResponseLen = ReadResponse(0)
            AUXResetTimeOut = 2500 / Timer1.Interval  'interval in milliseconds, so get close to 2.5 second wait

            'Reset the controller PCB and give it time to do so
            WriteCommand("$90%", 4)  'SOFT_RESET   $90% ; resp[!90#] Resets CTL PCB
            ResponseLen = ReadResponse(0)
            CTLResetTimeOut = 2500 / Timer1.Interval  'interval in milliseconds, so get close to 2.5 second wait

            SM_State = STARTUP
            'start up the log file
            OpenLogFile()

        Else
            Start_Stop_Toggle.BackColor = Color.Red
            Start_Stop_Toggle.Text = "CONNECT"

            b_ShutDownComms = True
        End If


    End Sub
    Private Sub WriteCommand(CMD_Str As String, CMD_Len As Integer)
        Dim Index As Integer

        If SerialPort1.IsOpen Then 'if the connection is closed, dont run the code
            st_LastCMD = CMD_Str    'for debug, esp when have read timeout
            SerialPort1.DiscardInBuffer() 'clear receive buffer
            If (CMD_Len > 90) Then CMD_Len = 90 'don't overrun CTLer input buffers
            For Index = 0 To (CMD_Len - 1) 'one char at a time
                'Threading.Thread.Sleep(2) '<<EMMETT.. do we need this?
                SerialPort1.Write(CMD_Str, Index, 1)
            Next
        Else
            b_ErrorStateActive = True
        End If

        If b_ErrorStateActive = True Then
            Timer1.Enabled = False 'gotta shut off main while user processes message
            MsgBox("Error: The port has been closed: Exit")
            If b_LogOpen = True Then
                LogLineOut.Close()
            End If
            Me.Close()
            Application.Exit()
            End
        End If


    End Sub
    Private Function ReadChar() As Integer
        Dim ReturnValue As Integer = 0

        If b_ErrorStateActive = False Then
            Try
                ReturnValue = SerialPort1.ReadByte
            Catch ex As TimeoutException
                b_ErrorStateActive = True
            Finally
                'If SerialPort1 IsNot Nothing Then SerialPort1.Close()
            End Try
        End If
        If b_ErrorStateActive = True Then
            Timer1.Enabled = False 'gotta shut off main while user processes message            
            MsgBox("Error: Read timeout on command " + st_LastCMD + "  Exit")

            If b_LogOpen = True Then
                LogLineOut.Close()
            End If
            Me.Close()
            Application.Exit()
            End
        End If
        Return ReturnValue
    End Function

    Private Function ReadResponse(b_LogIt As Boolean) As Integer
        Dim ResponseVal As Integer = 0
        Dim ResponseLen As Integer = 0

        st_RCV = "" 'reset st_RCV as null string
        While ResponseVal <> Asc("#") ' all this so I can see the # terminator
            ResponseVal = ReadChar()
            If (ResponseVal > 31) And (ResponseVal < 127) Then 'only process ascii chars
                ResponseLen += 1
                st_RCV &= Chr(ResponseVal)
                If ResponseLen > 100 Then Exit While 'protect against loss of "#"
            End If
        End While
        If b_LogIt = True Then
            WriteLogLine(st_RCV)
        End If
        Return ResponseLen
    End Function
    Private Sub Main_Loop_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ResponseLen As Integer

        Static b_Main_Running As Boolean
        If b_Main_Running Then Exit Sub 'skip this tick if Main_Loop still running
        b_Main_Running = True

        ResponseLen = 0
        If b_ShutDownComms Then
            WriteCommand("$90%", 4) 'SOFT_RESET  $90% ; resp[!90#] Resets CTL PCB
            ResponseLen = ReadResponse(0)
            SerialPort1.Close() 'close the port
            b_ShutDownComms = False
            SM_State = SHUTDOWN
        End If

        StateMachine()         'enter the state machine

        b_Main_Running = False 'jump on next Timer1.Tick
    End Sub

    Private Sub MFC_1_Text_In_Button_Click(sender As Object, e As EventArgs) Handles Set_MFC_1_Recipe_Button.Click
        Dim StrVar As String
        Dim DoubVal As Double

        'st_Was = MFCRecipeFlow(1).Text
        StrVar = InputBox("Format xx.yy (max value: " & MFC(1).db_Range & ")", "MFC_1 Enter Flow Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar) 'Convert the string value to a floating point
            If DoubVal > MFC(1).db_Range Or DoubVal < 0 Then Return
            Loaded_Progress_1.Value = CInt(DoubVal * 100)
            MFCRecipeFlow(1).Text = DoubVal.ToString("F")
            MFC(1).b_MFCLoadRecipeFlow = True
        Else
            Return
        End If

    End Sub
    Private Sub MFC_2_Text_In_Button_Click(sender As Object, e As EventArgs) Handles Set_MFC_2_Recipe_Button.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format xx.yy (max value: " & MFC(2).db_Range & ")", "MFC_2 Enter Flow Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar) 'Convert the string value to a floating point
            If DoubVal > MFC(2).db_Range Or DoubVal < 0 Then Return
            Loaded_Progress_2.Value = CInt(DoubVal * 100)
            MFCRecipeFlow(2).Text = DoubVal.ToString("F")
            MFC(2).b_MFCLoadRecipeFlow = True
        Else
            Return
        End If

    End Sub
    Private Sub MFC_3_Text_In_Button_Click(sender As Object, e As EventArgs) Handles Set_MFC_3_Recipe_Button.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format 0.xxx (max value: " & MFC(3).db_Range & ")", "MFC_3 Enter Flow Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 5 Then Return
            DoubVal = Convert.ToDouble(StrVar) 'Convert the string value to a floating point
            If DoubVal > MFC(3).db_Range Or DoubVal < 0 Then Return
            Loaded_Progress_3.Value = CInt(DoubVal * 100)
            MFCRecipeFlow(3).Text = DoubVal.ToString("F3")
            MFC(3).b_MFCLoadRecipeFlow = True
        Else
            Return
        End If

    End Sub
    Private Sub MFC_4_Text_In_Button_Click(sender As Object, e As EventArgs) Handles Set_MFC_4_Recipe_Button.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format 0.xxx (max value: " & MFC(4).db_Range & ")", "MFC_4 Enter Flow Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 5 Then Return
            DoubVal = Convert.ToDouble(StrVar) 'Convert the string value to a floating point
            If DoubVal > MFC(4).db_Range Or DoubVal < 0 Then Return
            Loaded_Progress_4.Value = CInt(DoubVal * 100)
            MFCRecipeFlow(4).Text = DoubVal.ToString("F3")
            MFC(4).b_MFCLoadRecipeFlow = True
        Else
            Return
        End If

    End Sub
    Private Sub SetRecipeWattsBtn_Click(sender As Object, e As EventArgs) Handles SetRecipeWattsBtn.Click
        Dim StrVar As String
        Dim IntVal As Integer

        StrVar = InputBox("Format xxx (max value: " & MAXRF_PF_WATTS & ")", "RF Power Enter Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 3 Then Return
            IntVal = Convert.ToInt32(StrVar)
            If IntVal > MAXRF_PF_WATTS Or IntVal < 0 Then Return
            RecipeWattsTxt.Text = IntVal
            RF.b_LoadRecipePower = True
        Else
            Return
        End If

    End Sub
    Private Sub SetRecipeTunerBtn_Click(sender As Object, e As EventArgs) Handles SetRecipeTunerBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format xxx (max value: 100)", "Tuner Position Enter Percentage Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > 100 Or DoubVal < 0 Then Return
            RecipeTunerTxt.Text = DoubVal.ToString("F")
            TUNER.b_LoadTunerPos = True
        Else
            Return
        End If

    End Sub
    Private Sub SetThicknessBtn_Click(sender As Object, e As EventArgs) Handles SetThicknessBtn.Click
        Dim StrVar, st_ThicSubtractGap As String
        Dim DoubVal, db_ThicSubtractGap As Double

        'This is helpful for determining how much spacing is available under the Plasma head
        st_ThicSubtractGap = CoordParam.db_Zp_2_Base.ToString("F") - RecipeGapTxt.Text
        db_ThicSubtractGap = Convert.ToDouble(st_ThicSubtractGap)

        StrVar = InputBox("Format xx.yyy (max value: " & st_ThicSubtractGap & ")", "Substrate Thickness Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > db_ThicSubtractGap Or DoubVal < 0 Then Return
            RecipeThicknessTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If
    End Sub
    Private Sub RecipeGapTxt_TextChanged(sender As Object, e As EventArgs) Handles SetGapBtn.Click
        Dim StrVar, st_GapSubtractThic As String
        Dim DoubVal, db_GapSubtractThic As Double

        'This is helpful for determining how much spacing is available under the Plasma head
        st_GapSubtractThic = CoordParam.db_Zp_2_Base.ToString("F") - RecipeThicknessTxt.Text
        db_GapSubtractThic = Convert.ToDouble(st_GapSubtractThic)

        StrVar = InputBox("Format xx.yy (min Value: 0.5) (max value: " & st_GapSubtractThic & ")", "Plasma Z Gap Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 5 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > db_GapSubtractThic Or DoubVal < 0.5 Then Return

            RecipeGapTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If

    End Sub
    Private Sub RecipeOverLapTxt_TextChanged(sender As Object, e As EventArgs) Handles SetOverlapBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format xx.yy (max value: " & CoordParam.db_PlasmaHeadSlitLength & ")", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 5 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > CoordParam.db_PlasmaHeadSlitLength Or DoubVal < -CoordParam.db_PlasmaHeadSlitLength Then Return
            RecipeOverLapTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If

    End Sub
    Private Sub RecipeSpeedTxt_TextChanged(sender As Object, e As EventArgs) Handles SetSpeedBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double

        StrVar = InputBox("Format xx.yy (max value: " & Param.db_Y_Max_Speed & ")", "Scan Speed Enter mm/sec Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 5 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > Param.db_Y_Max_Speed Or DoubVal <= 0 Then Return
            RecipeSpeedTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If

    End Sub
    Private Sub RecipeCyclesTxt_TextChanged(sender As Object, e As EventArgs) Handles SetCyclesBtn.Click
        Dim StrVar As String
        Dim IntVal As Integer

        StrVar = InputBox("Format xxx (max value: 100)", "Scan Cycles Enter Integer Value", "")
        If b_IsStringValid(StrVar, st_IntChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 3 Then Return
            IntVal = Convert.ToInt32(StrVar)
            If IntVal > 100 Or IntVal <= 0 Then Return
            RecipeCyclesTxt.Text = IntVal
        Else
            Return
        End If

    End Sub
    Private Sub RecipeXMinTxt_TextChanged(sender As Object, e As EventArgs) Handles SetXMinBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double ' CoordParam.db_Xp_2Base is half the total stage size for X

        StrVar = InputBox("Format +/- xxx.yy (max value: " & CoordParam.db_Xp_2_Base & ")", "Scan Box X MIN Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > CoordParam.db_Xp_2_Base Or DoubVal < -CoordParam.db_Xp_2_Base Then Return
            RecipeXMinTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If

    End Sub
    Private Sub RecipeXMaxTxt_TextChanged(sender As Object, e As EventArgs) Handles SetXMaxBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double ' CoordParam.db_Xp_2_Base is half the total stage size for X

        StrVar = InputBox("Format +/- xxx.yy (max value: " & CoordParam.db_Xp_2_Base & ")", "Scan Box X MAX Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > CoordParam.db_Xp_2_Base Or DoubVal < -CoordParam.db_Xp_2_Base Then Return
            RecipeXMaxTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If
    End Sub
    Private Sub RecipeYMinTxt_TextChanged(sender As Object, e As EventArgs) Handles SetYMinBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double ' CoordParam.db_Yp_2_Base is half the total stage size for X

        StrVar = InputBox("Format +/- xxx.yy (max value: " & CoordParam.db_Yp_2_Base & ")", "Scan Box Y MIN Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > CoordParam.db_Yp_2_Base Or DoubVal < -CoordParam.db_Yp_2_Base Then Return
            RecipeYMinTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If
    End Sub
    Private Sub RecipeYMaxTxt_TextChanged(sender As Object, e As EventArgs) Handles SetYMaxBtn.Click
        Dim StrVar As String
        Dim DoubVal As Double ' CoordParam.db_Yp_2_Base is half the total stage size for X

        StrVar = InputBox("Format +/- xxx.yy (max value: " & CoordParam.db_Yp_2_Base & ")", "Scan Box Y MAX Enter mm Value", "")
        If b_IsStringValid(StrVar, st_DoubleChars, "Invalid Entry") Then
            If StrVar = "" Or StrVar.Length > 6 Then Return
            DoubVal = Convert.ToDouble(StrVar)
            If DoubVal > CoordParam.db_Yp_2_Base Or DoubVal < -CoordParam.db_Yp_2_Base Then Return
            RecipeYMaxTxt.Text = DoubVal.ToString("F")
        Else
            Return
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Reset the Auxiliary PCB before exit
        WriteCommand("$A9%", 4)  'SOFT_RESET   $A9%; resp[!A9#]; causes Aux PCB Soft Reset
        ReadResponse(0)
        
        'Reset the controller PCB before exit
        WriteCommand("$90%", 4)  'SOFT_RESET   $90% ; resp[!90#] Resets CTL PCB and AUX PCB
        ReadResponse(0)

        SerialPort1.Close()
        Me.Close()
        Application.Exit()

    End Sub
    Private Sub AutoManBtn_Click(sender As Object, e As EventArgs) Handles AutoManBtn.Click, AUTO_MODE.Click
        b_ToggleAutoMode = True
    End Sub
    Private Sub RunRcpBtn_Click(sender As Object, e As EventArgs) Handles RunRcpBtn.Click
        If b_HasCollision = True and b_autoScanActive and b_plasmaActive = False Then
            b_PlannedAutoStart = True 'this will make sure we dont accidently start plasma when just clicking RUN SCAN button
            if SMScan.State = SCSM_IDLE then
                SMScan.ExternalNewState = SCSM_START_UP
                SMScan.b_ExternalStateChange = True  'Start Collision test while auto scan is ON
            End If 
        Else 
            b_ToggleRunRecipe = True
        End If
        
    End Sub
   
   
    Private Sub StateMachine()

        Select Case SM_State
            Case STARTUP
                If CTLResetTimeOut > 0 Then
                    CTLResetTimeOut -= 1
                ElseIf AUXResetTimeOut > 0 then 
                    AUXResetTimeOut -= 1
                Else
                    WriteLogLine("Main State Machine Start Up")
                    RunStartUp()
                    SM_State = POLLING
                    UpdateStatus(0)
                End If

            Case POLLING
                RunCheckInput() 'checks for operator input

                'Check whether we need to go full pumpkin
                If b_Owned = False Then
                    SM_CinderellaCounter += 1 'increment until Pumpkin check
                    If SM_CinderellaCounter >= SM_POLL_CINDERELLA Then
                        CinderellaCode() '60 minutes till we turn into a pumpkin (unless you have your glass slippers).
                        SM_CinderellaCounter = 0
                    End If
                End If

                SM_PollCounter += 1 'increment every main tick loop (100 msec period)
                If SM_PollCounter >= SM_POLL_PERIOD Then
                    SM_PollCounter = 0
                    RunPolling() 'poll the main PCB

                    RunInitAxesSM() 'run the Initialize Axes state machine
                    RunTwoSpotSM() 'run the Two Spot state machine                                   
                    RunScanSM() 'run the Scan state machine
                    RunCollisionPassSM()
                    CollisionLaser() 'run the Collision Laser System state machine
                    RunHomeAxesSM() 'run Home Axes state machine
                    SetLightTower() 'run the Light Tower state machine
                    UpdateStatus(StatusBits)
                End If

            Case SHUTDOWN
                WriteLogLine("Main State Machine Shut Down")
                RunShutDown()
                SM_State = IDLE
                UpdateStatus(0)

            Case IDLE

            Case Else

        End Select

    End Sub
    Private Sub RunStartUp()
        Dim Index As Integer
        Dim StrVar As String
        Dim IntVar As Integer
        Dim DblVar As Double
        Dim ResponseLen As Integer
        Dim CMDIndex() As String = {"0", "01%", "02%", "03%", "04%"}

        If GetBoughtorNot() = False Then CinderellaCode()
                
        PL_SIM_NOTICE.Visible = False 'just in case

        'How many MFCs?
        WriteCommand("$2A002%", 7) 'GET Number of MFCs (1-4) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7, 1)
            b_IsStringANumber(StrVar, st_IntChars, "$2A%")
            NumMFC = CInt(StrVar)
            WriteLogLine("Number of MFCs: " & StrVar)
        Else
            If (NumMFC = 0) Then
                If b_ErrorStateActive = False Then
                    b_ErrorStateActive = True
                    MsgBox("Error: Control PCB Configuration Missing => Exit")
                    'Restart the App after operator ack
                    Application.Exit()
                End If
            End If
        End If

        'Get Set Temp
        'WriteCommand("$CF%", 4) '$CF% resp [!CFtt.t#] where tt.t Is the target temperature
        'ResponseLen = ReadResponse(0)
        'CurrentStepTxtBox.Text = st_RCV.Substring(3,4)
        
        'This is for Batch Logging systems only
        WriteCommand("$2A011%", 7) 'GET BatchIDLogging $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7,1)
            If StrVar = "1" Then b_batchActive = True
            If b_batchActive = True Then
                BatchIDTextBox.Visible = True
                BatchLoggingBTN.Visible = True
                Form4.BatchChkBox.Checked = True
                b_togglebatchIDLogging = True 'this is the flag to set Batch ID on/off 
            end if
        End If

        WriteCommand("$2A606%", 7) 'GET RECIPE MB Start Position () $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7, 4)
            b_IsStringANumber(StrVar, st_IntChars, "$2A%")
            TUNER.LoadedSetPoint = Convert.ToInt32(StrVar, 10) 'integer approximation to %            
            StrVar = st_RCV.Substring(7, 7)
            TUNER.db_LoadedSetPointPct = Convert.ToDouble(StrVar)
            LoadedTunerTxt.Text = TUNER.db_LoadedSetPointPct.ToString("F") '2 decimal points
            RecipeTunerTxt.Text = TUNER.db_LoadedSetPointPct.ToString("F")
            'WriteLogLine("Initial Tuner SetPoint: " & LoadedTunerTxt.Text)
        End If    
        WriteCommand("$2A605%", 7) 'GET RECIPE RF PWR Setpoint (Watts) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value        
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7, 4)
            b_IsStringANumber(StrVar, st_IntChars, "$2A%")
            RF.LoadedSetPoint = Convert.ToInt32(StrVar, 10)
            LoadedWattsTxt.Text = CStr(RF.LoadedSetPoint)
            RecipeWattsTxt.Text = CStr(RF.LoadedSetPoint) 'this is for the New GUI to view Loaded values
        End If
        WriteCommand("$2A604%", 7) 'GET RECIPE MFC4 Flow (SLPM) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            MFC(4).db_LoadedFlow = CDbl(st_RCV.Substring(7, ResponseLen - 8))            
            MFCLoadedFlow(4).Text = MFC(4).db_LoadedFlow.ToString("F3")
            MFCRecipeFlow(4).Text = MFC(4).db_LoadedFlow.ToString("F3") 'this is for the New GUI to view Loaded values        
        End If
        WriteCommand("$2A603%", 7) 'GET RECIPE MFC3 Flow (SLPM) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            MFC(3).db_LoadedFlow = CDbl(st_RCV.Substring(7, ResponseLen - 8))            
            MFCLoadedFlow(3).Text = MFC(3).db_LoadedFlow.ToString("F3")
            MFCRecipeFlow(3).Text = MFC(3).db_LoadedFlow.ToString("F3") 'this is for the New GUI to view Loaded values        
        End If
        WriteCommand("$2A602%", 7) 'GET RECIPE MFC2 Flow (SLPM) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            MFC(2).db_LoadedFlow = CDbl(st_RCV.Substring(7, ResponseLen - 8))            
            MFCLoadedFlow(2).Text = MFC(2).db_LoadedFlow.ToString("F")
            MFCRecipeFlow(2).Text = MFC(2).db_LoadedFlow.ToString("F")      
        End If
        WriteCommand("$2A601%", 7) 'GET RECIPE MFC1 Flow (SLPM) $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            MFC(1).db_LoadedFlow = CDbl(st_RCV.Substring(7, ResponseLen - 8))            
            MFCLoadedFlow(1).Text = MFC(1).db_LoadedFlow.ToString("F")
            MFCRecipeFlow(1).Text = MFC(1).db_LoadedFlow.ToString("F")  
        End If
        
        For Index = 1 To NumMFC
            WriteCommand("$85" & CMDIndex(Index), 6) 'GET_MFC_RANGE $850m% 1<=m<=4; resp[!850xxx.yy#]
            ResponseLen = ReadResponse(0)
            If ResponseLen > 6 Then
                StrVar = st_RCV.Substring(5, ResponseLen - 6)
                If (IsNumeric(StrVar) = True) Then
                    DblVar = CDbl(StrVar)
                    'If (DblVar > MFCRangeMAX) And (Index > 2) Then DblVar = MFCRangeMAX
                    MFC(Index).db_Range = DblVar
                    MFCRange(Index).Text = MFC(Index).db_Range.ToString("F")
                Else
                    MFCRange(Index).Text = "NO RS485"
                End If
            End If          
        Next        

        WriteCommand("$2A705%", 7)  'Get Max RF power forward  $2Axxx% xxxx = any length index number =>resp [!2Axxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            MAXRF_PF_WATTS = Convert.ToInt32(StrVar)
        End If

        WriteCommand("$89%", 4)  'GET_AUTO_MAN   $89%; resp [!890p#] p=1 AutoMode, p=0 ManualMode
        ResponseLen = ReadResponse(0)
        If ResponseLen > 3 Then
            StrVar = st_RCV.Substring(3, 2)
            b_IsStringANumber(StrVar, st_HexChars, "$89%")
            IntVar = Convert.ToInt32(StrVar, 16)
            b_AutoModeOn = False
            If IntVar > 0 Then b_AutoModeOn = True
        End If

        'turn off Exec Recipe
        WriteCommand("$8700%", 6) 'SET_EXEC_RECIPE  $870p% p=1 Execute Recipe, p=0 RF off, Recipe off
        ResponseLen = ReadResponse(0)
        b_RunRecipeOn = False       

        'enable service menu
        EnableServiceMenuToolStripMenuItem.Enabled = True


        'Ask the Aux PCB for MAX & MIN values              
        WriteCommand("$DA107%", 7) 'GET_X_MAX_SPEED  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(1)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA107%")
            Param.db_X_Max_Speed = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA207%", 7) 'GET_Y_MAX_SPEED  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(1)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA207%")
            Param.db_Y_Max_Speed = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA307%", 7) 'GET_Z_MAX_SPEED  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(1)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7) '<<<EMMETT USE TRIM HERE
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA307%")
            Param.db_Z_Max_Speed = Convert.ToDouble(StrVar)
        End If

        'get Coordinate system info from 3-Axis PCB
        WriteCommand("$DA510%", 7) 'GET db_Xp_2Base  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_Xp_2_Base = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA520%", 7) 'GET db_Yp_2Base  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_Yp_2_Base = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA530%", 7) 'GET db_Zp_2Base  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_Zp_2_Base = Convert.ToDouble(StrVar)
            Param.db_Z_Head_Pos = Convert.ToDouble(StrVar) 'Used for running scan, need to know where the head is. 
        End If
        WriteCommand("$DA511%", 7) 'GET db_Xs_2_PH  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_Xs_2_PH = Convert.ToDouble(StrVar)
        End If
       WriteCommand("$DA521%", 7) 'GET db_Ys_2_PH  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_Ys_2_PH = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA540%", 7) 'GET Plasma Head Slit Length (mm)  $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_PlasmaHeadSlitLength = Convert.ToDouble(StrVar)
        End If       
        WriteCommand("$DA541%", 7) 'GET Plasma Head Slit Width (mm) $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_PlasmaHeadSlitWidth = Convert.ToDouble(StrVar)
        End If        
        WriteCommand("$DA542%", 7) 'GET Chuck to Plasma Head safety gap (mm) $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_ChuckToPlasmaHeadSafetyGap = Convert.ToDouble(StrVar)
        End If        
        WriteCommand("$DA543%", 7) 'GET Z Pins Buried Pos (mm) $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_ZPinsBuriedPos = Convert.ToDouble(StrVar)
        End If
        WriteCommand("$DA544%", 7) 'GET Z Pins Exposed Pos (mm) $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            CoordParam.db_ZPinsExposedPos = Convert.ToDouble(StrVar)
        End If     
        'Get the Home Position Parameters
        WriteCommand("$DA512%", 7) 'GET db_LoadPos_X_Base $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            Param.db_X_Home_Pos = Convert.ToDouble(StrVar)
        End If
         WriteCommand("$DA522%", 7) 'GET db_LoadPos_Y_Base $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            Param.db_Y_Home_Pos = Convert.ToDouble(StrVar)
        End If
         WriteCommand("$DA532%", 7) 'GET db_LoadPos_Z_Base $DAxxxx% xxxx = index number =>resp [!DAxxxx;vv..vv#] vv..vv = value
        ResponseLen = ReadResponse(0)
        If ResponseLen > 7 Then
            StrVar = st_RCV.Substring(7)
            StrVar = StrVar.Trim(New Char() {"#"c}) 'remove the last char
            b_IsStringANumber(StrVar, st_DoubleChars, "$DA%")
            Param.db_Z_Home_Pos = Convert.ToDouble(StrVar)
        End If

        InitAxesBtn.Enabled = True
        SettingsBtn.Enabled = True
        FileToolStripMenuItem.Enabled = True
        CodeToolStripMenuItem.Enabled = True
        'Initialize sub-StateMachines        
        SMTwoSpot.State = TSSM_IDLE
        SMInitAxes.State = IASM_IDLE
        SMScan.State = SCSM_IDLE
        SMScan.SubState = SCSM_SUB_IDLE
        SMScan.b_ExternalStateChange = False
        SMHomeAxes.State = HASM_IDLE
        SMTwoSpot.State = TSSM_IDLE
        SMTwoSpot.b_ExternalStateChange = False

        Operator_Mode()
    End Sub
    Private Sub GetAxesStatus() 'update the AxesStatus data structure
        Dim ResponseLen As Integer
        Dim StrVar As String
        Dim Index As Integer
        Dim SubStr As String
        Dim b_StatusChanged As Boolean = False
        Dim LogStr As String

        ResponseLen = 0

        While ResponseLen < 30
            WriteCommand("$C0%", 4) 'GET_STATUS $C0%; resp[!C0nn;nn;X state;X error;X pos;Y state;Y error; Y pos;Z state;Z error; Z pos#]
            ResponseLen = ReadResponse(0)
            If ResponseLen < 30 Then WriteLogLine("Bad Response = " & st_RCV)
        End While

        If st_AxesStatusRsp <> st_RCV Then 'only write log lines when status has changed
            b_StatusChanged = True
        End If
        st_AxesStatusRsp = st_RCV ' for next time
        'First byte 
        StrVar = st_RCV.Substring(3)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.LEDStates = Convert.ToInt32(SubStr, 16)
        AxesStatus.LEDStates = AxesStatus.LEDStates << 8
        LogStr = "LED: " & SubStr
        'Second Byte
        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.LEDStates += Convert.ToInt32(SubStr, 16)
        LogStr &= SubStr

        'Check the 3-Axis LED states to determine if: doors are open, Joystick button is depressed, Valve 2 is open (Substrate Purge).
        AxesStatus.b_DoorsOpen = b_IsBitSet(AxesStatus.LEDStates, 6) '//VBWord bit 6 (STOP LED)
        AxesStatus.b_LEDJoyBtnOn = b_IsBitSet(AxesStatus.LEDStates, 14) '//VBWord bit 14 (NO LED) 
        AxesStatus.b_LEDVacOn = b_IsBitSet(AxesStatus.LEDStates, 12) 'LED_VALVE_3
        AxesStatus.b_LEDN2PurgeOn = b_IsBitSet(AxesStatus.LEDStates, 11) 'LED_VALVE_2
        'if CLaser.State = CLSM_ACTIVATE then AxesStatus.b_CollisionActive = b_IsBitSet(AxesStatus.LEDStates, 8) 'EXT_IN_2
        'This LED will let us know when Valve 2 is open, which will tell us SUbstrate Purge is active. 
        'AxesStatus.b_LEDN2PurgeOn = b_IsBitSet(AxesStatus.LEDStates, 3) '//VBWord bit 3 (Valve 2)

        If AxesStatus.b_LEDVacOn = True Then
            ChuckVacSquare.BackColor = Color.Lime
        Else
            ChuckVacSquare.BackColor = Color.Gainsboro
        End If
        If AxesStatus.b_LEDN2PurgeOn = True Then
            N2PurgeSquare.BackColor = Color.Cyan
        Else
            N2PurgeSquare.BackColor = Color.Gainsboro
        End If

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.XState = Convert.ToInt32(SubStr, 16)
        LogStr &= " XSt: " & SubStr

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.XError = Convert.ToInt32(SubStr, 16)

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.db_XPos = Convert.ToDouble(SubStr)
        LogStr &= " XPos: " & SubStr

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.YState = Convert.ToInt32(SubStr, 16)
        LogStr &= " YSt: " & SubStr

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.YError = Convert.ToInt32(SubStr, 16)

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.db_YPos = Convert.ToDouble(SubStr)
        LogStr &= " YPos: " & SubStr

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.ZState = Convert.ToInt32(SubStr, 16)
        LogStr &= " ZSt: " & SubStr

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf(";")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.ZError = Convert.ToInt32(SubStr, 16)

        StrVar = StrVar.Substring(Index + 1)
        Index = StrVar.IndexOf("#")
        SubStr = StrVar.Substring(0, Index)
        AxesStatus.db_ZPos = Convert.ToDouble(SubStr)
        LogStr &= " ZPos: " & SubStr

        If (AxesStatus.XState = AxesStatus.YState) And (AxesStatus.XState = AxesStatus.ZState) Then
            AxesStatus.b_XYZSameState = True
        Else
            AxesStatus.b_XYZSameState = False
        End If
                
        If b_StatusChanged = True Then
            WriteLogLine(LogStr)
        End If
    End Sub

    Private Sub RunShutDown()

        MFCTextButton(1).Visible = False
        MFCTextButton(2).Visible = False
        MFCTextButton(3).Visible = False
        MFCTextButton(4).Visible = False
        SetRecipeWattsBtn.Visible = False
        RunRcpBtn.Visible = False
        AutoManBtn.Visible = False
        PL_SIM_NOTICE.Visible = False
        SetRecipeTunerBtn.Visible = False

        'SetHeaterButton.Visible = False
        
        CloseLogFile() 'done logging
    End Sub

    Private Sub RunPolling() 'Poll the Control and Axis PCBs for status (every 1 second)
        Dim Index As Integer
        Dim IntVal As Integer
        Dim DoubVal As Double
        Dim StrVar As String
        Dim ResponseLen As Integer
        Dim db_TempProgressBarValue As Double
        Dim DoubValLeft, DoubValRight As Double
        Dim IntValLeft, IntValRight As Integer
        Dim ar_CTL_ParamVals As Array
        Dim b_StatusChanged As Boolean = False

        'Get Controller Status
        WriteCommand("$91%", 4) 'GET_STATUS    $91% ; resp[!91LLRR#] LL = left LEDS, RR = right LEDS
        ResponseLen = ReadResponse(0)
        If ResponseLen < 50 Then Return 'EMMETT.. this happens sometimes FIX IT!


        st_RCV = st_RCV.Substring(3) 'lop off the first three chars
        If st_CTLPCBStatus <> st_RCV Then 'only write log line if status has changed
            b_StatusChanged = True
        End If
        st_CTLPCBStatus = st_RCV 'for next time
        ar_CTL_ParamVals = st_RCV.Split(New Char() {";"c})

        StrVar = ar_CTL_ParamVals(0)
        b_IsStringANumber(StrVar, st_HexChars, "CTL Status Bits") 'restarts if = False
        StatusBits = Convert.ToInt32(StrVar, 16)
        UpdateStatus(StatusBits) 'parse status bits to boolean

        StrVar = ar_CTL_ParamVals(1) 'MB Motor Position (to update slider bar)
        b_IsStringANumber(StrVar, st_DoubleChars, "MB Motor Pos")
        MB_Pos_Bar.Value = CInt(StrVar)
        DoubVal = CDbl(StrVar) 'Convert the string value to a floating point
        TUNER.db_ActualPos = DoubVal
        TUNER.db_ActualPosPct = DoubVal

        If (b_AutoModeOn = False) Or (b_RunRecipeOn = False) Then 'watch for end limits when in manual MB Motor control
            If TUNER.db_ActualPosPct > 98 Then
                MB_Right_Arrow.Visible = False
            ElseIf TUNER.db_ActualPosPct < 2 Then
                MB_Left_Arrow.Visible = False
            Else
                ' MB_Right_Arrow.Visible = True
                'MB_Left_Arrow.Visible = True
            End If
        End If
        ActTunerTxt.Text = TUNER.db_ActualPosPct.ToString("F") '2 decimal points
        'MB_Pos_Bar.Value = CStr(ActTunerTxt.Text)

        StrVar = ar_CTL_ParamVals(2) 'RF Power Forward A/D
        b_IsStringANumber(StrVar, st_IntChars, "RF Pwr Fwd")
        RF.ActualPForward = Convert.ToInt32(StrVar, 10)
        If b_RunRecipeOn = True Then
            ActWattsTxt.Text = CStr(RF.ActualPForward)
            RF_Radial.Value = RF.ActualPForward / 2 'For Operator Mode Radial (divide by 2 since max watts is 200 and radial max is 100)
        Else
            ActWattsTxt.Text = "0"
            RF_Radial.Value = 0
        End If
        StrVar = ar_CTL_ParamVals(3) 'RF Power reflected A/D
        b_IsStringANumber(StrVar, st_IntChars, "RF Pwr Ref")
        RF.ActualPReflected = Convert.ToInt32(StrVar, 10)
        If b_RunRecipeOn = True Then
            RflWattsTxt.Text = CStr(RF.ActualPReflected)
            RF_Reflected_Radial.Value = RF.ActualPReflected * 3.3  'For Operator Mode Radial (multiply by 3.3 since reflected max is 30 and dial max is 100)
        Else
            RflWattsTxt.Text = "0"
            RF_Reflected_Radial.Value = 0
        End If

        StrVar = ar_CTL_ParamVals(4) 'Plasma Status
        b_IsStringANumber(StrVar, st_HexChars, "Plasma Status") 'restarts if = False
        IntVal = Convert.ToInt32(StrVar, 16)
        'watch for CTL PCB changes in ExecRecipe status
        If ((b_RunRecipeOn = False) And (IntVal > 0)) Then 'have inconsistent condition
            b_RunRecipeOn = True
        End If
        If ((b_RunRecipeOn = True) And (IntVal = 0)) Then 'have inconsistent condition
            b_RunRecipeOn = False
        End If

        'Get MFC FLows
        For Index = 1 To NumMFC
            StrVar = ar_CTL_ParamVals(Index + 4) 'MFC Flow
            b_IsStringANumber(StrVar, st_DoubleChars, "MFC Flow")
            MFC(Index).db_ActualFlow = CDbl(StrVar) 'Convert the string value to a floating point
            'Fill Operator Progress Bars as well
            'Convert the string value to a floating point
            If Index = 3 Or Index = 4 Then
                MFCActualFlow(Index).Text = MFC(Index).db_ActualFlow.ToString("F3") '2 decimal points
                db_TempProgressBarValue = CDbl(StrVar) * 100 'this is to resolve progress bar 3 and 4 from being truncated during Cint.
                MFC(Index).ActualFlow = CInt(db_TempProgressBarValue)
            Else 'This is for MFC 1 & 2 
                MFCActualFlow(Index).Text = MFC(Index).db_ActualFlow.ToString("F") '2 decimal points
                MFC(Index).ActualFlow = CInt(StrVar)
            End If
            MFCProgressValue(Index).value = MFC(Index).ActualFlow
        Next 'For Index = 1 To NumMFC


        'Get Plasma Head Temperature
        WriteCommand("$C5%", 4)  'GET_TEMP  $C5%: resp[!C5xx.xx#]; xx.xx = head temp degrees C base 10
        ResponseLen = ReadResponse(0)
        If ResponseLen > 3 Then
            StrVar = st_RCV.Substring(3, 4)
            If b_IsStringANumber(StrVar, st_DoubleChars, st_EmptyChars) = True Then 'st_EmptyChars
                DoubVal = Convert.ToDouble(StrVar)
                IntVal = Math.Ceiling(DoubVal)
                StrVar = IntVal.ToString()
                Temp_Radial.Value = IntVal 'Set the Temperature Radial for Operator
                PHTempTxt.Text = StrVar 'Display the val in deg C
                If Temp_Radial.Value < 50 Then
                    Temp_Radial.ProgressColor = Color.DodgerBlue
                    Temp_Radial.ProgressColor2 = Color.DodgerBlue
                ElseIf Temp_Radial.Value < 60 Then
                    Temp_Radial.ProgressColor = Color.Yellow
                    Temp_Radial.ProgressColor2 = Color.Yellow
                Else
                    Temp_Radial.ProgressColor = Color.Red
                    Temp_Radial.ProgressColor2 = Color.Red
                End If

            Else
                PHTempTxt.Text = "???" 'allow for disconnected or bad temperature probe
            End If
        End If

        'Check Abort flag and if active, flash Abort Clear button
        If b_ClearAbort Then
            RunRcpBtn.Enabled = False
            If b_toggleClearAbort = True Then
                ClearAbortbtn.FillColor = Color.Black
            Else
                ClearAbortbtn.FillColor = Color.FromArgb(201, 42, 38)
            End If
            b_toggleClearAbort = Not b_toggleClearAbort
        End If

        'Get Doors Open status 
        If AxesStatus.b_DoorsOpen = True Then 'Toggle the Doors open label to Accentuate doors open
            'Disable the stage buttons
            If InitAxesBtn.Enabled = True Then 'Disable the butons once, not every Poll period
                For Each element In StageButtons
                    element.enabled = False
                Next
            End If

            'display label for Doors Open and make it flash
            Door_Open_Label.Visible = True
            If b_toggleDoorsOpen = True Then
                Door_Open_Label.ForeColor = Color.Red
            Else
                Door_Open_Label.ForeColor = Color.Black
            End If
            b_toggleDoorsOpen = Not b_toggleDoorsOpen
        Else
            If Door_Open_Label.Visible = True Then 'Enable the butons once, not every Poll period
                Door_Open_Label.Visible = False
                For Each element In StageButtons
                    element.enabled = True
                Next
            End If

        End If

        'Plasma running or not
        If b_RunRecipeOn = True Then 'Toggle the Button Color to Accentuate Recipe Running
            RunRcpBtn.Text = "TURN PLASMA OFF"
            If b_RunRcpBtnColor = True Then
                RunRcpBtn.FillColor = Color.DarkGray
            Else
                RunRcpBtn.FillColor = Color.LightSteelBlue
            End If
            b_RunRcpBtnColor = Not b_RunRcpBtnColor
            If b_ENG_mode = False And RunScanBtn.Enabled = False And AxesStatus.b_DoorsOpen = False Then 'Enable the Run Scan button for operators while plasma is on
                RunScanBtn.Enabled = True
            End If
        Else
            RunRcpBtn.FillColor = Color.BlueViolet
            RunRcpBtn.Text = "START PLASMA"
            
        End If

        If b_togglebatchIDLogging = True Then 'Settings button
            b_togglebatchIDLogging = False 

            If b_batchActive = True Then
                WriteCommand("$28011;1%", 9) ' $28xxx;vv..vv%, xxxx = any length index number, vv..vv = value; =>resp [!28xxxx;vv..vv#]            
                ReadResponse(0)
                BatchIDTextBox.Visible = True 'show the batch designs
                BatchLoggingBTN.Visible = True
                WriteLogLine("Batch ID logging toggled ON")
            Else 
                WriteCommand("$28011;0%", 9) ' $28xxx;vv..vv%, xxxx = any length index number, vv..vv = value; =>resp [!28xxxx;vv..vv#]
                ReadResponse(0)
                BatchIDTextBox.Visible = False 'hide the batch designs
                BatchLoggingBTN.Visible = False
                WriteLogLine("Batch ID logging toggled OFF")
            End If 
        End If


        'This controls the AUTO START SCAN setting 
        If b_plasmaActive = True And b_autoScanActive = True and b_toggleAutoScan = True then
            If SMScan.State = SCSM_IDLE Then 'IDLE, so must want me to start up
                'Are my axis initialized
                If AxesStatus.XState >= ASM_IDLE AND AxesStatus.YState >= ASM_IDLE AND AxesStatus.ZState >= ASM_IDLE And RunScanBtn.Visible = true Then
                    SMScan.ExternalNewState = SCSM_START_UP
                    SMScan.b_ExternalStateChange = True
                End If
            End If
            b_toggleAutoScan = False
        End If

        'Get Axes Status
        GetAxesStatus() 'Update AxesStatus Data Structure
        'Manage Axes Status Message
        If AxesStatus.b_XYZSameState = True And AxesStatus.XState < ASM_IDLE Then
            CurrentStepTxtBox.Text = "Stage Not Initialized"
        End If


        'Manage Actual Position Windows
        If AxesStatus.XState >= ASM_IDLE Then
            DoubVal = db_C_XPos_RefB_2_RefPH(AxesStatus.db_XPos)
            AxesXActual.Text = DoubVal.ToString("F") '2 decimal point
        Else
            AxesXActual.Text = "???"
        End If
        If AxesStatus.YState >= ASM_IDLE Then
            DoubVal = db_C_YPos_RefB_2_RefPH(AxesStatus.db_YPos)
            AxesYActual.Text = DoubVal.ToString("F") '2 decimal point
        Else
            AxesYActual.Text = "???"
        End If
        If AxesStatus.ZState >= ASM_IDLE Then
            DoubVal = db_C_ZPos_RefB_2_RefPH(AxesStatus.db_ZPos)
            AxesZActual.Text = DoubVal.ToString("F") '2 decimal point
        Else
            AxesZActual.Text = "???"
        End If

        If (b_StatusChanged = True) And (b_RunRecipeOn = True) Then
            WriteLogLine("Tuner: " & ActTunerTxt.Text & " Temp: " & PHTempTxt.Text _
                & " MFC1: " & MFCActualFlow(1).Text & " MFC2: " & MFCActualFlow(2).Text & " MFC3: " & MFCActualFlow(3).Text & " MFC4: " & MFCActualFlow(4).Text _
                & " Pfwd: " & ActWattsTxt.Text & " Pref: " & RflWattsTxt.Text)
        End If

    End Sub

    Private Sub RunCheckInput()
        Dim Index As Integer
        Dim IntVar As Integer
        Dim StrVar As String
        Dim FltVar As Double
        Dim ResponseLen As Integer
        Dim CMDIndex() As String = {"0", "01", "02", "03", "04"}

        If (b_Step_MB_SM_Left = True) Then
            WriteCommand(st_MBLeftSpeed, Len(st_MBLeftSpeed))
            ResponseLen = ReadResponse(0)
            b_Step_MB_SM_Left = False '
        End If

        If (b_Step_MB_SM_Right = True) Then
            WriteCommand(st_MBRightSpeed, Len(st_MBRightSpeed))
            ResponseLen = ReadResponse(0)
            b_Step_MB_SM_Right = False
        End If

        For Index = 1 To 4 'check to see if new Recipe Flows are Entered
            If MFC(Index).b_MFCLoadRecipeFlow = True Then
                FltVar = CDbl(MFCRecipeFlow(Index).Text) 'convert the contents of the text-box to float
                If FltVar < 0.0 Then                           'Or FltVar > MFC(Index).db_Range Then
                    MFCRecipeFlow(Index).ForeColor = Color.Red
                Else
                    'MFCRecipeFlow(Index).ForeColor = Color.Black
                    StrVar = "$41" & CMDIndex(Index) & MFCRecipeFlow(Index).Text & "%"
                    WriteCommand(StrVar, Len(StrVar))  'SET_RCP_MFC_FLOW   $410mxxx.yy% 1<=m<=4, xxx.yy = flow rate; resp[!410mxxx.yy#]
                    ResponseLen = ReadResponse(0)
                    If ResponseLen > 6 Then 'use transmitted value rather than parse the response
                        MFC(Index).db_LoadedFlow = FltVar
                        MFCLoadedFlow(Index).Text = FltVar.ToString("F")
                    End If
                End If
                MFC(Index).b_MFCLoadRecipeFlow = False
            End If
        Next

        If RF.b_LoadRecipePower = True Then
            StrVar = RecipeWattsTxt.Text 'get the entered base 10 text
            IntVar = Convert.ToInt32(StrVar) 'convert to integer
            If IntVar > MAXRF_PF_WATTS Then
                IntVar = MAXRF_PF_WATTS 'range check
                RecipeWattsTxt.ForeColor = Color.Red
            End If
            StrVar = DecIntToDecStr(IntVar, 4)
            StrVar = "$42" & StrVar & "%" 'SET_RCP_RF_WATTS  $42xxxx% xxxx = Watts; resp[!42xxxx#]
            WriteCommand(StrVar, 8)
            ResponseLen = ReadResponse(0)
            If ResponseLen > 4 Then
                StrVar = st_RCV.Substring(3, 4)
                b_IsStringANumber(StrVar, st_IntChars, "$42%") 'restarts if = False
                RF.LoadedSetPoint = Convert.ToInt32(StrVar, 10)
                LoadedWattsTxt.Text = CStr(RF.LoadedSetPoint)
            End If
            RF.b_LoadRecipePower = False
        End If

        If TUNER.b_LoadTunerPos = True Then
            StrVar = RecipeTunerTxt.Text 'get the entered percentage
            'TUNER.LoadedSetPoint = Convert.ToInt32(StrVar) 'convert to % integer
            StrVar = "$43" & StrVar & "%"     'SET_RCP_MS_POS  $43xxxx$ xxxx = Base10 MB Motor Pos; resp[!43xxxx#]
            WriteCommand(StrVar, Len(StrVar))
            ResponseLen = ReadResponse(0)
            If ResponseLen > 4 Then
                StrVar = st_RCV.Substring(3, 4)
                b_IsStringANumber(StrVar, st_DoubleChars, "$43%") 'restarts if = False
                TUNER.db_LoadedSetPointPct = Convert.ToDouble(StrVar) ' int to %
                LoadedTunerTxt.Text = TUNER.db_LoadedSetPointPct.ToString("F")
                'StrVar = st_RCV.Substring(3, 2)
                'TUNER.LoadedSetPoint = Convert.ToInt32(StrVar, 10)
            End If
            TUNER.b_LoadTunerPos = False
        End If

        If b_ToggleAutoMode = True Then
            b_AutoModeOn = Not b_AutoModeOn
            If b_AutoModeOn Then
                WriteCommand("$8601%", 6) 'SET_AUTO_MAN 0x86 //$860p% p=1 AutoMode, p=0 ManualMode
                MB_Right_Arrow.Visible = False
                MB_Left_Arrow.Visible = False
            Else
                WriteCommand("$8600%", 6)
                MB_Right_Arrow.Visible = True
                MB_Left_Arrow.Visible = True
            End If
            ResponseLen = ReadResponse(0)
            b_ToggleAutoMode = False
        End If
        
        If b_ToggleRunRecipe = True Then
            b_RunRecipeOn = Not b_RunRecipeOn
                    
            If b_RunRecipeOn = True Then                  
                WriteCommand("$8701%", 6) 'SET_EXEC_RECIPE  $870p% p=1 Execute Recipe, p=0 RF off, Recipe off
                'This resets the flag for AUTO SCAN 
                If b_autoScanActive = True Then b_toggleAutoScan = True                                           '
            Else
                WriteCommand("$8700%", 6)
            End If
            ResponseLen = ReadResponse(0)
            b_ToggleRunRecipe = False 'always turn flag off
        End If

        If b_SetDefaultRecipe = True Then
            WriteCommand("$44%", 4) 'SET_DEF_RECIPE $44%; resp [!44#]
            ReadResponse(0) 'clear the response buffer
            b_SetDefaultRecipe = False
        End If
                
        If b_toggleHeater = True Then 'heater button is pushed           
            b_toggleHeater = False
            
            If b_heaterActive Then
                WriteCommand("$CE35.0%", 8) '$CEtt.t% resp [!CEtt.t#] where tt.t is target temp in 'C. t=0 is off
                ReadResponse(0)
                HeatLabel.BackColor = Color.Lime
                WriteLogLine("Preheat Plasma Recipe ON")
            Else
                WriteCommand("$CE00.0%", 8) '$CEtt.t% resp [!CEtt.t#] where tt.t is target temp in 'C. t=0 is off
                ReadResponse(0)
                HeatLabel.BackColor = Color.Gainsboro
                WriteLogLine("Preheat Plasma Recipe OFF")
            End If           

        End If

        

    End Sub

    Private Function DecIntToHexStr(DecInt As Integer, NumChar As Integer)
        Dim HexStr As String

        HexStr = Convert.ToString(DecInt, 16) 'convert to hex string
        While Len(HexStr) < NumChar 'size the string to be NumChar chars long
            HexStr = "0" & HexStr
        End While
        HexStr = HexStr.ToUpper 'gotta be upper case A - F

        Return HexStr
    End Function
    Private Function DecIntToDecStr(DecInt As Integer, NumChar As Integer)
        Dim DecStr As String

        DecStr = Convert.ToString(DecInt, 10) 'convert to Base10 string
        While Len(DecStr) < NumChar 'size the string to be NumChar chars long
            DecStr = "0" & DecStr
        End While

        Return DecStr
    End Function
    'UPdateStatus bit patterns =>
    'LED_GAS_1       0 //VBWord bit 8    &H0100
    'LED_GAS_2       1 //VBWord bit 9    &H0200
    'LED_GAS_3       2 //VBWord bit 10   &H0400
    'LED_GAS_4       3 //VBWord bit 11   &H0800
    'LED_VLV_5       4 //VBWord bit 12   &H1000 - R12 (not used here)
    'LED_TUNING      5 //VBWord bit 13   &H2000 - R12 (not used here)
    'LED_ESTOP_ON    6 //VBWord bit 14   &H4000
    'LED_RF_EN       7 //VBWord bit 15   &H8000

    'LED_PL_ON       8  //VBWord bit 0   &H0001
    'LED_RS485       9  //VBWord bit 1   &H0002 (not used here)
    'LED_AUTO        10 //VBWord bit 2   &H0004
    'LED_EXEC_RCP    11 //VBWord bit 3   &H0008
    'LED_USB_CONN    12 //VBWord bit 4   &H0010 (not used here)
    'LED_CMD_ACTIVE  13 //VBWord bit 5   &H0020 (not used here)
    'LED_HE_SIG      14 //VBWord bit 6   &H0040- R12 (not used here)
    'LED_ABORT       15 //VBWord bit 7   &H0080

    Private Sub UpdateStatus(myStatusBits As Integer)
        GlobalmyStatusBits = myStatusBits
        If myStatusBits <> StatusBitsWas Then ' have a change, log it
            WriteLogLine("Status Bits Change from " & st_BinInt2String(StatusBitsWas) & " to " & st_BinInt2String(myStatusBits))
            StatusBitsWas = myStatusBits 'for next time
        End If
        If (myStatusBits And &H4000) > 0 Then 'ESTOP!
            MsgBox("Fatal Error: Plasma System ESTOP => Exit")
            'Exit the App after operator ack
            Application.Exit()
        End If
        If (myStatusBits And &H4) > 0 Then
            AUTO_MODE.BackColor = Color.Lime
        Else
            AUTO_MODE.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H8) > 0 Then
            EXECUTE_RECIPE.BackColor = Color.Lime
        Else
            EXECUTE_RECIPE.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H80) > 0 Then
            PROCESS_ABORT.BackColor = Color.Red
            PublishAbortCode() 'ABORT detected, see if can display Abort Code
        Else
            PROCESS_ABORT.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H100) > 0 Then
            GAS_1.BackColor = Color.Lime
        Else
            GAS_1.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H200) > 0 Then
            GAS_2.BackColor = Color.Lime
        Else
            GAS_2.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H400) > 0 Then
            GAS_3.BackColor = Color.Lime
        Else
            GAS_3.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H800) > 0 Then
            GAS_4.BackColor = Color.Lime
        Else
            GAS_4.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H8000) > 0 Then
            RF_ENABLED.BackColor = Color.Lime
        Else
            RF_ENABLED.BackColor = Color.Gainsboro
        End If
        If (myStatusBits And &H1) > 0 Then
            PLASMA_ON.BackColor = Color.BlueViolet 'cause that is the actual color of plasma
            if b_plasmaActive = False Then b_plasmaActive = true
        Else
            PLASMA_ON.BackColor = Color.Gainsboro
            if b_plasmaActive = true Then b_plasmaActive = False
        End If
    End Sub

    Private Sub PublishAbortCode()
        Dim ResponseLen As Integer
        Dim StrVar As String
        Dim ErrorCode As Integer

        WriteCommand("$8B%", 4) 'GETSET_ABORT_CODE  $8B%; resp [!8Bcccc#] cccc = Base10 Abort Code
        ResponseLen = ReadResponse(0)
        If ResponseLen > 3 Then 'it got the command OK
            StrVar = st_RCV.Substring(3, 4)
            b_IsStringANumber(StrVar, st_IntChars, "$8B%") 'restarts if = False
            ErrorCode = Convert.ToInt32(StrVar, 10)

            Select Case ErrorCode
                Case AC_OK
                    'AC_CODE.Visible = False
                Case AC_NO_N2
                    AC_CODE.Text = "NO PURGE N2"
                    WriteLogLine("NO PURGE N2")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_HEARTBEAT
                    AC_CODE.Text = "NO HEARTBEAT"
                    WriteLogLine("NO HEARTBEAT")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_GAS_1
                    AC_CODE.Text = "MFC_1 Low Flow"
                    WriteLogLine("MFC_1 Low Flow")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_GAS_2
                    AC_CODE.Text = "MFC_2 Low Flow"
                    WriteLogLine("MFC_2 Low Flow")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_GAS_3
                    AC_CODE.Text = "MFC_3 Low Flow"
                    WriteLogLine("MFC_3 Low Flow")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_GAS_4
                    AC_CODE.Text = "MFC_4 Low Flow"
                    WriteLogLine("MFC_4 Low Flow")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_BAD_HELIUM
                    AC_CODE.Text = "BAD HELIUM"
                    WriteLogLine("BAD HELIUM")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_ESTOP
                    AC_CODE.Text = "ESTOP ACTIVE"
                    WriteLogLine("ESTOP ACTIVE")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_NO_RS485
                    AC_CODE.Text = "MFC Comms Down"
                    WriteLogLine("MFC Comms Down")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_PWR_FWD_LOW
                    AC_CODE.Text = "Power Fwd Low"
                    WriteLogLine("Power Fwd Low")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case AC_OVER_TEMP
                    AC_CODE.Text = "Head Too Hot"
                    WriteLogLine("Head Too Hot")
                    b_ClearAbort = True
                    AC_CODE.Visible = True
                    ClearAbortbtn.Visible = True
                Case Else

            End Select
        Else
            ClearAbortbtn.Visible = False
        End If
    End Sub
    Private Sub OpenLogFile()
        st_TimeStamp = System.DateTime.Now.ToString("yyyy-MM-dd")
        st_LogPathFileName = st_LogFilePath + st_LogFileName + st_TimeStamp + ".log"
        LogLineOut = New StreamWriter(st_LogPathFileName, 1) 'open with append rights
        LogLineOut.AutoFlush = True 'constantly flush to the file so can tail the log file
        b_LogOpen = True
    End Sub
    Private Sub WriteLogLine(st_Line As String)
        st_TimeStamp = System.DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss.fff | ")
        If b_LogOpen Then
            LogLineOut.WriteLine(st_TimeStamp + st_Line)  'Log File Line
        End If

    End Sub
    Private Sub CloseLogFile()
        b_LogOpen = False
        LogLineOut.Close()
    End Sub
    Private Sub GetExeCfg()

        ExeConfigPathFileName = ExeConfigPath + ExeConfigFileName + ".cfg"
        ' Open the file using a stream reader.
        Using sr As New StreamReader(ExeConfigPathFileName)
            ExeConfigString = sr.ReadToEnd()
            sr.Close()
        End Using
        ExeConfigLines = ExeConfigString.Split(New Char() {"<"c})
        'Read and parse each parameter of the Config string
        For Ctr As Integer = 1 To ExeConfigLines.Length - 1
            ExeConfigParamStrArray = ExeConfigLines(Ctr).Split(New Char() {">"c})
            ExeConfigParamName = ExeConfigParamStrArray(0).Trim()
            ExeConfigParamValue = ExeConfigParamStrArray(1).Trim()
            Select Case ExeConfigParamName 'load up the Config values
                Case "MFC_LABEL_1"
                    Exe_Cfg.MFC_LABEL_1 = ExeConfigParamValue
                    MFC_1_Label.Text = Exe_Cfg.MFC_LABEL_1
                Case "MFC_LABEL_2"
                    Exe_Cfg.MFC_LABEL_2 = ExeConfigParamValue
                    MFC_2_Label.Text = Exe_Cfg.MFC_LABEL_2
                Case "MFC_LABEL_3"
                    Exe_Cfg.MFC_LABEL_3 = ExeConfigParamValue
                    MFC_3_Label.Text = Exe_Cfg.MFC_LABEL_3
                Case "MFC_LABEL_4"
                    Exe_Cfg.MFC_LABEL_4 = ExeConfigParamValue
                    MFC_4_Label.Text = Exe_Cfg.MFC_LABEL_4
                Case "KNOWN_COM_PORT"
                    Exe_Cfg.KNOWN_COM_PORT = ExeConfigParamValue
                    st_KnownComPort = Exe_Cfg.KNOWN_COM_PORT                
                Case Else
            End Select

        Next

    End Sub
    'Private Sub WriteExeConfig()
    '    Dim st_ConfigurationString As String

    '    ExeConfigPathFileName = ExeConfigPath + ExeConfigFileName + ".cfg"
    '    ' Open the file using a stream reader.
    '    Using sr As New StreamReader(ExeConfigPathFileName)
    '        ExeConfigString = sr.ReadToEnd()
    '        sr.Close()
    '    End Using
    '    ExeConfigLines = ExeConfigString.Split(New Char() {"<"c})
    '    'Read and parse each parameter of the Config string
    '    For Ctr As Integer = 1 To ExeConfigLines.Length - 1
    '        ExeConfigParamStrArray = ExeConfigLines(Ctr).Split(New Char() {">"c})
    '        ExeConfigParamName = ExeConfigParamStrArray(0).Trim()
    '        ExeConfigParamValue = ExeConfigParamStrArray(1).Trim()
    '        Select Case ExeConfigParamName 'load up the Config values
    '            Case "KNOWN_COM_PORT"
    '                Exe_Cfg.KNOWN_COM_PORT = ExeConfigParamValue
    '            Case Else
    '        End Select
    '    Next

    '    ExeConfigPathFileName = ExeConfigPath + ExeConfigFileName + ".cfg"
    '    'build the Configuration from current data
    '    st_ConfigurationString = "<KNOWN_COM_PORT>" + com_portBox.Text

    '    ' Open the file using a stream reader.
    '    Using ExeConfigOut As New StreamWriter(ExeConfigPathFileName)
    '        ExeConfigOut.Write(st_ConfigurationString)
    '        ExeConfigOut.Close()
    '    End Using

    'End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        MFC(1).b_MFCLoadRecipeFlow = True 'signal main loop to load the new flow
        MFC(2).b_MFCLoadRecipeFlow = True
        MFC(3).b_MFCLoadRecipeFlow = True
        MFC(4).b_MFCLoadRecipeFlow = True
        RF.b_LoadRecipePower = True 'signal main loop to load the new RF Power
        TUNER.b_LoadTunerPos = True 'signal main loop to load the new Tuner Start Position
    End Sub
    Private Sub ClearAbortbutton_Click(sender As Object, e As EventArgs) Handles ClearAbortbtn.Click
        'Simply clears error code text
        AC_CODE.Text = ""
        AC_CODE.Visible = False
        ClearAbortbtn.Visible = False
        b_ClearAbort = False
        RunRcpBtn.Enabled = True 're-enable the Start Plasma button
        
        if CLaser.State = CLSM_TRIPPED Then 
            RunScanBtn.Text = "RUN SCAN"
            CLaser.State = CLSM_DEACTIVATE
            WriteCommand("$B800%", 6) 
            ReadResponse(0)
            WriteCommand("$B801%", 6) 
            ReadResponse(0)
            WriteCommand("$B802%", 6) 
            ReadResponse(0)
            SMHomeAxes.State = HASM_START
        End If
                
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Displays an OpenFileDialog so the user can select a Recipe.
        Dim intVal As Integer
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = st_RecipePath 'hard coded st_RecipePath as initialized at startup above
        openFileDialog1.Filter = "Recipe|*.rcp"
        openFileDialog1.Title = "Select a Recipe File"

        ' Show the Dialog.
        ' If the user clicked OK in the dialog and 
        ' a .rcp file was selected, open it.
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            st_RecipeFileName = openFileDialog1.SafeFileName
            st_RecipeFileName = st_RecipeFileName.Substring(0, st_RecipeFileName.Length - 4) 'strip off '.rcp'
            ActiveRecipeName.Text = st_RecipeFileName
            st_RecipePathFileName = openFileDialog1.FileName
            ' Open the file using a stream reader.
            Using sr As New StreamReader(st_RecipePathFileName)
                st_RecipeString = sr.ReadToEnd()
                sr.Close()
            End Using

            WriteLogLine("Loaded " + st_RecipeFileName + " : " + st_RecipeString.Replace(vbCr, "").Replace(vbLf, "")) 'Log this recipe entry

            st_RecipeLines = st_RecipeString.Split(New Char() {"<"c})
            'Read and parse each parameter of the recipe string
            For Ctr As Integer = 1 To st_RecipeLines.Length - 1
                st_RecipeParamStrArray = st_RecipeLines(Ctr).Split(New Char() {">"c})
                st_RecipeParamName = st_RecipeParamStrArray(0).Trim()
                st_RecipeParamValue = st_RecipeParamStrArray(1).Trim()

                Select Case st_RecipeParamName 'load up the recipe values
                    Case "MFC1"
                        MFC_1_Recipe_Flow.Text = st_RecipeParamValue
                    Case "MFC2"
                        MFC_2_Recipe_Flow.Text = st_RecipeParamValue
                    Case "MFC3"
                        MFC_3_Recipe_Flow.Text = st_RecipeParamValue
                    Case "MFC4"
                        MFC_4_Recipe_Flow.Text = st_RecipeParamValue
                    Case "PWR"
                        RecipeWattsTxt.Text = st_RecipeParamValue
                    Case "TUNER"
                        RecipeTunerTxt.Text = st_RecipeParamValue
                    Case "THICKNESS"
                        RecipeThicknessTxt.Text = st_RecipeParamValue
                    Case "GAP"
                        RecipeGapTxt.Text = st_RecipeParamValue
                    Case "OVERLAP"
                        RecipeOverLapTxt.Text = st_RecipeParamValue
                    Case "SPEED"
                        RecipeSpeedTxt.Text = st_RecipeParamValue
                    Case "CYCLES"
                        RecipeCyclesTxt.Text = st_RecipeParamValue
                    Case "XMIN"
                        RecipeXMinTxt.Text = st_RecipeParamValue
                    Case "YMIN"
                        RecipeYMinTxt.Text = st_RecipeParamValue
                    Case "XMAX"
                        RecipeXMaxTxt.Text = st_RecipeParamValue
                    Case "YMAX"
                        RecipeYMaxTxt.Text = st_RecipeParamValue
                    Case "PURGE"
                        intVal = CInt(st_RecipeParamValue)
                        If intVal > 0 Then
                            st_HasPurgeSave = "1"
                            b_N2PurgeRecipe = True
                            N2Purgelabel.BackColor = Color.Lime
                        Else
                            st_HasPurgeSave = "0"
                            b_N2PurgeRecipe = False
                            N2Purgelabel.BackColor = Color.Gainsboro
                        End If                    
                    Case "AUTOSCAN"
                        st_AutoScanSave = st_RecipeParamValue
                        If st_AutoScanSave = "1" Then
                            b_autoScanActive = True
                            Form4.AutoScanChkBox.Checked = true
                            b_toggleAutoScan = true
                        Else
                            b_autoScanActive = false
                            Form4.AutoScanChkBox.Checked = False
                        End If
                    Case "HEATER"
                        st_HasHeatSave = st_RecipeParamValue
                        If st_HasHeatSave = "1" Then
                            b_heaterActive = True
                            b_toggleHeater = True
                            Form4.PreheatChkBox.Checked = true
                        Else
                            Form4.PreheatChkBox.Checked = False
                        End If
                    Case Else

                End Select
            Next
            b_RecipeOpened = True 'We have a recipe


            'We want to act like we pushed the Green Arrow for loading to the controller because we are in Operator Mode.
            MFC(1).b_MFCLoadRecipeFlow = True 'signal main loop to load the new flow
            MFC(2).b_MFCLoadRecipeFlow = True
            MFC(3).b_MFCLoadRecipeFlow = True
            MFC(4).b_MFCLoadRecipeFlow = True
            RF.b_LoadRecipePower = True 'signal main loop to load the new RF Power
            TUNER.b_LoadTunerPos = True 'signal main loop to load the new Tuner Start Position
            'Also need to adjust the progress bars to display the recipe setpoint
            Loaded_Progress_1.Value = CInt(MFC_1_Recipe_Flow.Text * 100) 'This value is coming from a double, multiple by 100 to get a integer that will be appropriate.
            Loaded_Progress_2.Value = CInt(MFC_2_Recipe_Flow.Text * 100)
            Loaded_Progress_3.Value = CInt(MFC_3_Recipe_Flow.Text * 100)
            Loaded_Progress_4.Value = CInt(MFC_4_Recipe_Flow.Text * 100)
            'Enable the Plasma button since we HAVE A RECIPE NOW
            If b_ENG_mode = True Then
                SaveToolStripMenuItem.Enabled = True 'Enable 'Save'
            Else
                RunRcpBtn.Enabled = True
                RunRcpBtn.FillColor = Color.BlueViolet
            End If
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            SerialPort1.Close()
            Me.Close()
            Application.Exit()
            End
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        st_RecipePathFileName = st_RecipePath + st_RecipeFileName + ".rcp"
        'build the Recipe from current data
        st_RecipeString = "<MFC1>" + MFC_1_Recipe_Flow.Text + vbCrLf + "<MFC2>" + MFC_2_Recipe_Flow.Text + vbCrLf +
                       "<MFC3>" + MFC_3_Recipe_Flow.Text + vbCrLf + "<MFC4>" + MFC_4_Recipe_Flow.Text + vbCrLf +
                       "<PWR>" + RecipeWattsTxt.Text + vbCrLf + "<TUNER>" + RecipeTunerTxt.Text + vbCrLf +
                       "<THICKNESS>" + RecipeThicknessTxt.Text + vbCrLf + "<GAP>" + RecipeGapTxt.Text + vbCrLf +
                       "<OVERLAP>" + RecipeOverLapTxt.Text + vbCrLf + "<SPEED>" + RecipeSpeedTxt.Text + vbCrLf +
                       "<CYCLES>" + RecipeCyclesTxt.Text + vbCrLf + "<XMIN>" + RecipeXMinTxt.Text + vbCrLf +
                       "<YMIN>" + RecipeYMinTxt.Text + vbCrLf + "<XMAX>" + RecipeXMaxTxt.Text + vbCrLf +
                       "<YMAX>" + RecipeYMaxTxt.Text + vbCrLf + "<PURGE>" + st_HasPurgeSave + vbCrLf +
                       "<AUTOSCAN>" + st_AutoScanSave + vbCrLf + "<HEATER>" + st_HasHeatSave + vbCrLf

        Using RecipeOut As New StreamWriter(st_RecipePathFileName)
            RecipeOut.Write(st_RecipeString)
            RecipeOut.Close()
        End Using

        WriteLogLine("Saved " + st_RecipeFileName + " : " + st_RecipeString.Replace(vbCr, "").Replace(vbLf, "")) 'Log this recipe entry

    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        st_RecipeFileName = InputBox("No extension", "Enter Recipe Name", st_RecipeFileName)
        ActiveRecipeName.Text = st_RecipeFileName
        st_RecipePathFileName = st_RecipePath + st_RecipeFileName + ".rcp"
        'build the Recipe from current data
        st_RecipeString = "<MFC1>" + MFC_1_Recipe_Flow.Text + vbCrLf + "<MFC2>" + MFC_2_Recipe_Flow.Text + vbCrLf +
                       "<MFC3>" + MFC_3_Recipe_Flow.Text + vbCrLf + "<MFC4>" + MFC_4_Recipe_Flow.Text + vbCrLf +
                       "<PWR>" + RecipeWattsTxt.Text + vbCrLf + "<TUNER>" + RecipeTunerTxt.Text + vbCrLf +
                       "<THICKNESS>" + RecipeThicknessTxt.Text + vbCrLf + "<GAP>" + RecipeGapTxt.Text + vbCrLf +
                       "<OVERLAP>" + RecipeOverLapTxt.Text + vbCrLf + "<SPEED>" + RecipeSpeedTxt.Text + vbCrLf +
                       "<CYCLES>" + RecipeCyclesTxt.Text + vbCrLf + "<XMIN>" + RecipeXMinTxt.Text + vbCrLf +
                       "<YMIN>" + RecipeYMinTxt.Text + vbCrLf + "<XMAX>" + RecipeXMaxTxt.Text + vbCrLf +
                       "<YMAX>" + RecipeYMaxTxt.Text + vbCrLf + "<PURGE>" + st_HasPurgeSave + vbCrLf + 
                       "<AUTOSCAN>" + st_AutoScanSave + vbCrLf + "<HEATER>" + st_HasHeatSave + vbCrLf

        Using RecipeOut As New StreamWriter(st_RecipePathFileName)
            RecipeOut.Write(st_RecipeString)
            RecipeOut.Close()
        End Using
        SaveToolStripMenuItem.Enabled = True 'Enable 'Save'
        WriteLogLine("Saved As" + st_RecipeFileName + " : " + st_RecipeString.Replace(vbCr, "").Replace(vbLf, "")) 'Log this recipe entry

    End Sub
    Private Sub SetDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDefaultToolStripMenuItem.Click
        b_SetDefaultRecipe = True
    End Sub
    Private Sub RestartAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartAllToolStripMenuItem.Click
        WriteCommand("$90%", 4)         'SOFT_RESET  $90% ; resp[!90#]
        Application.Restart()
    End Sub
    Private Sub EnableServiceMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableServiceMenuToolStripMenuItem.Click
        If ServiceToolStripMenuItem.Visible = False Then
            ServiceToolStripMenuItem.Visible = True
            EnableServiceMenuToolStripMenuItem.Text = "Disable Service Menu"
        Else
            ServiceToolStripMenuItem.Visible = False
            EnableServiceMenuToolStripMenuItem.Text = "Enable Service Menu"
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub SetCTLToPLSimModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCTLToPLSimModeToolStripMenuItem.Click
        Dim StrVar As String
        Dim ResponseLen As Integer

        StrVar = "$1901%"     '$190b% b=1 Plasma Simulation on
        WriteCommand(StrVar, Len(StrVar))
        ResponseLen = ReadResponse(0)
        PL_SIM_NOTICE.Visible = True
        WriteLogLine("Plasma Simulation Mode ON")

    End Sub
    
    Private Sub EngineerModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineerModeToolStripMenuItem.Click
        Dim StrVar As String
        Dim st_password As String = "9820"

        StrVar = InputBox("Enter the Password:", "Password", "")  
        If StrVar.Length > 4 Or StrVar.Length = 0 Then Return  
        if StrVar = st_Password Then
            Engineer_Mode() 'loads the Engineer Interface
            WriteLogLine("Engineer Mode enabled")
        End If
        
    End Sub
    Private Sub OperatorModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperatorModeToolStripMenuItem.Click
        Operator_Mode() 'loads the Operator Interface
        WriteLogLine("Operator Mode enabled")
    End Sub
    Private Sub MB_Left_Arrow_Click(sender As Object, e As EventArgs) Handles MB_Left_Arrow.Click
        b_Step_MB_SM_Left = True
    End Sub

    Private Sub MB_Right_Arrow_Click(sender As Object, e As EventArgs) Handles MB_Right_Arrow.Click
        b_Step_MB_SM_Right = True
    End Sub
    Private Sub MB_Big_Step_Button_Click(sender As Object, e As EventArgs) Handles MB_Big_Step_Button.Click
        st_MBRightSpeed = "$11010002%" '$110dxxxx%  d=1,0 xxxx = num steps; resp[!110dxxxx#] when move STARTED
        st_MBLeftSpeed = "$11000002%"
        MB_Small_Step_Button.Visible = True
        MB_Big_Step_Button.Visible = False
        b_MB_Big_Step_Active = False
    End Sub
    Private Sub MB_Small_Step_Button_Click(sender As Object, e As EventArgs) Handles MB_Small_Step_Button.Click
        st_MBRightSpeed = "$11010050%" '$110dxxxx%  d=1,0 xxxx = Base10 num steps; resp[!110dxxxx#] when move STARTED
        st_MBLeftSpeed = "$11000050%"
        MB_Small_Step_Button.Visible = False
        MB_Big_Step_Button.Visible = True
        b_MB_Big_Step_Active = True
    End Sub
  
    Private Sub Launch_SMTwoSpot(sender As Object, e As EventArgs) Handles SetTwoSpotBtn.Click
        If SMTwoSpot.State = TSSM_IDLE Then 'IDLE, so must want me to start up
            SMTwoSpot.State = TSSM_START_UP
        Else
            SMTwoSpot.State = TSSM_CLOSE_DOWN
        End If
    End Sub

    Private Sub Launch_SMScan(sender As Object, e As EventArgs) Handles RunScanBtn.Click        
        If SMScan.State = SCSM_IDLE Then 'IDLE, so must want me to start up
            SMScan.ExternalNewState = SCSM_START_UP
            SMScan.b_ExternalStateChange = True
        Else 'not IDLE, so must want me to shut down
            SMScan.ExternalNewState = SCSM_SHUT_DOWN
            SMScan.b_ExternalStateChange = True
        End If
    End Sub
    
    Private Sub InitAxesBtn_Click(sender As Object, e As EventArgs) Handles InitAxesBtn.Click
        SMInitAxes.State = IASM_START_UP
    End Sub

    Private Sub HomeAxesBtn_Click(sender As Object, e As EventArgs) Handles HomeAxesBtn.Click
        If SMHomeAxes.State = HASM_IDLE Then 'IDLE, so must want me to start up
            SMHomeAxes.State = HASM_START
        Else
            SMHomeAxes.State = HASM_SHUT_DOWN
        End If
    End Sub
   
    Private Function b_IsBitSet(TestInt As Integer, BitPos As Integer) As Boolean
        Dim BitMask As Integer

        BitMask = 1 << BitPos
        Return (TestInt And BitMask) > 0

    End Function

    Private Sub Launch_SMDiameter(sender As Object, e As EventArgs) Handles SetDiameterBtn.Click
        Dim bp As Integer

        DiameterEntryDialog.ShowDialog()

        If MainWindow.SelectedWaferSize > 0 Then 'value selected, not cancelled
            Call RunDiameter()
        End If

    End Sub

    Private Sub Launch_Settings(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        'All recipe settings, except for Batchlogging which is set on the tool.
        Form4.ShowDialog()       
    End Sub

    Function b_IsStringValid(st_Number As String, st_OKChars As String, st_Cmd As String) As Boolean
        Dim b_StrOK As Boolean = True 'optimistic

        For Each c As Char In st_Number 'any bad char in st_Number sets b_StrOK = False
            If (st_OKChars.IndexOf(c) = -1) Then b_StrOK = False
        Next
        If b_StrOK = True Then
            Return True
        Else
            Return False 'bad response, but no restart required
        End If
    End Function
    Function b_IsStringANumber(st_Number As String, st_OKChars As String, st_Cmd As String) As Boolean
        Dim b_FirstChar As Boolean = True 'first char can't be '.' so watch for it
        Dim b_StrOK As Boolean = True 'optimistic

        For Each c As Char In st_Number 'any bad char in st_Number sets b_StrOK = False
            If (st_OKChars.IndexOf(c) = -1) Then b_StrOK = False
            If b_FirstChar Then
                If (c = ".") Then b_StrOK = False 'this happened once
                b_FirstChar = False
            End If
        Next
        If b_StrOK = True Then Return True 'all done, all ok

        '------------------- If got this far then Exception Handling -------------
        If String.IsNullOrEmpty(st_Cmd) = False Then 'caller passed command string, so abort with message
            st_OKChars = "Comms error: " & st_Cmd & " returns " & st_Number & " => Exit"
            WriteLogLine(st_OKChars)
            MsgBox(st_OKChars)
            Application.Exit() 'Close the App after operator ack
        End If
        Return False 'bad response, but no restart required
    End Function

    Function st_BinInt2String(Bits16 As Integer) As String
        Dim st_Rtn As String    'Function FixString(st_Number As String, st_OKChars As String, st_Cmd As String)
        '    Dim b_StrOK As Boolean = True

        '    For Each c As Char In st_Number 'any bad char in st_Number sets b_StrOK = False
        '        'if this does not find OK characters, it will set b_StrOK to false 
        '        If (st_OKChars.IndexOf(c) = -1) Then b_StrOK = False
        '    Next
        '    Return st_Number
        'End Function
        Bits16 = Bits16 Or &H10000 'force Bit 16 high
        st_Rtn = Convert.ToString(Bits16, 2) 'now st_Rtn has 17 chars
        Return st_Rtn.Substring(1) 'return all to the right of the forced string
    End Function
    'Functions for calculating RunTwoSpotSM() that are used specifically with the laser to chuck locations
    'Function db_Xs_2_PH(db_C_Xs_2_PH As Double) As Double
    '    Return CoordParam.db_Xs_2_PH - db_C_Xs_2_PH
    'End Function
    'CoordParam.db_Ys_2_PH is the spot laser, so when the 3 axis board takes a reading, it accomodates the 10mm difference 
    Function db_Ys_2_PH(db_C_Ys_2_PH As Double) As Double
        Return CoordParam.db_Ys_2_PH - db_C_Ys_2_PH
    End Function
    'Coordinate translation functions
    'translate BASE X,Y,Z to the display-able PH X,Y,Z (for display)
    Function db_C_XPos_RefB_2_RefPH(db_C_XPos_RefB As Double) As Double
        Return CoordParam.db_Xp_2_Base - db_C_XPos_RefB
    End Function
    Function db_C_YPos_RefB_2_RefPH(db_C_YPos_RefB As Double) As Double
        Return CoordParam.db_Yp_2_Base - db_C_YPos_RefB
    End Function
    Function db_C_ZPos_RefB_2_RefPH(db_C_ZPos_RefB As Double) As Double
        Return db_C_ZPos_RefB - CoordParam.db_Zp_2_Base
    End Function
    'translate displayed PH X,Y,Z to the Base PH X,Y,Z (for motor moves)
    Function db_C_XPos_RefPH_2_RefB(db_C_XPos_RefPH As Double) As Double
        Return CoordParam.db_Xp_2_Base - db_C_XPos_RefPH
    End Function
    Function db_C_YPos_RefPH_2_RefB(db_C_YPos_RefPH As Double) As Double
        Return CoordParam.db_Yp_2_Base - db_C_YPos_RefPH
    End Function
    Function db_C_ZPos_RefPH_2_RefB(db_C_ZPos_RefPH As Double) As Double
        Return CoordParam.db_Zp_2_Base + db_C_ZPos_RefPH
    End Function

    Private Sub MBScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MBScanToolStripMenuItem.Click
        SM_State = MB_SCAN_RESET
    End Sub

    Private Sub RecipeButtonPins_Click(sender As Object, e As EventArgs) Handles RecipeButtonPins.Click
        Dim st_StrCmd As String

        b_HasPins = Not b_HasPins

        If b_HasPins Then
            st_StrCmd = "$B602" & CoordParam.db_ZPinsExposedPos.ToString("F") & "%"
            WriteCommand(st_StrCmd, st_StrCmd.Length)
            ReadResponse(0)
            PinsSquare.BackColor = Color.Lime
        Else
            st_StrCmd = "$B602" & CoordParam.db_ZPinsBuriedPos.ToString("F") & "%"
            WriteCommand(st_StrCmd, st_StrCmd.Length)
            ReadResponse(0)
            PinsSquare.BackColor = Color.Gainsboro
        End If

    End Sub
    Private Sub VacButton_Click(sender As Object, e As EventArgs) Handles Vacbtn.Click

        b_HasVac = Not b_HasVac

        If b_HasVac Then
            WriteCommand("$C801%", 6) 'SET_VALVE_3 $C80n% resp[!C80n#] n = 0, 1 (off, on)
            ReadResponse(0)
            WriteLogLine("Vac On")
            AutoVacSquare.BackColor = Color.Lime
        Else
            WriteCommand("$C800%", 6) 'SET_VALVE_3 $C80n% resp[!C80n#] n = 0, 1 (off, on)
            ReadResponse(0)
            WriteLogLine("Vac Off")
            AutoVacSquare.BackColor = Color.Gainsboro
        End If

    End Sub
    Private Sub RecipeButtonPurge_Click(sender As Object, e As EventArgs) Handles N2Purgebtn.Click, N2Purgelabel.Click
        b_N2PurgeON = Not b_N2PurgeON

        If b_N2PurgeON Then
            st_HasPurgeSave = "1"
            b_N2PurgeRecipe = True
            N2Purgelabel.BackColor = Color.Lime
        Else
            st_HasPurgeSave = "0"
            b_N2PurgeRecipe = False
            N2Purgelabel.BackColor = Color.Gainsboro
        End If
    End Sub
    Private Sub BatchLoggingBTN_Click(sender As Object, e As EventArgs) Handles BatchLoggingBTN.Click
        Dim StrVar As String

        StrVar = InputBox("Enter the Batch ID #", "Batch ID #", "")        
            If StrVar = "" Or StrVar.Length > 45 Then Return            
            WriteLogLine("----------------------------BATCH ID # ---------------------------------")
            WriteLogLine("Logging Batch ID #: " & StrVar)
            BatchIDTextBox.Text = StrVar
       
    End Sub    
  
    Private Sub CodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem.Click
        AuthorizeCode(1)
    End Sub
    Function GetBoughtorNot() As Boolean
        Dim responseLen As Integer
        Dim st_bought As String

        'Uncomment out for CINDERELLACODE - Also need to adjust the days/dates in authorize.
        WriteCommand("$22007F%", 8) 'GET_PARAM_VAL
        responseLen = ReadResponse(0)
        st_bought = st_RCV.Substring(7, 1)
        If st_bought = "1" Then
            CodeToolStripMenuItem.Visible = False
            b_Owned = True
            Return True
        Else
            Return False
        End If
    End Function
    Function GetExt1() As Boolean 'Extension yes/no
        Dim responseLen As Integer
        Dim st_extension1 As String

        WriteCommand("$22007E%", 8) 'GET_PARAM_VAL
        responseLen = ReadResponse(0)
        st_extension1 = st_RCV.Substring(7, 1)
        If st_extension1 = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Function GetExt2() As Boolean 'Extension yes/no
        Dim responseLen As Integer
        Dim st_extension2 As String

        WriteCommand("$22007D%", 8) 'GET_PARAM_VAL
        responseLen = ReadResponse(0)
        st_extension2 = st_RCV.Substring(7, 1)
        If st_extension2 = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub AuthorizeCode(EnterCodeOrTimerUp as Integer)
        Dim StrVar As String
        Dim responseLen As Integer
        Dim CodeB As String
        Dim CodeE1 As String
        Dim CodeE2 As String
        Dim b_Authorized As Boolean
        Dim dt_Today As DateTime = DateTime.Now
        Dim st_Today As String = dt_Today.ToString("ddMMyyyy")

        'SM_State = SHUTDOWN 'Shut'r down!

        WriteCommand("$23007F%", 8) 'GET_PARAM_DESC
        responseLen = ReadResponse(0)
        CodeB = st_RCV.Substring(8, 10)
        WriteCommand("$23007E%", 8)
        responseLen = ReadResponse(0)
        CodeE1 = st_RCV.Substring(8, 10)
        WriteCommand("$23007D%", 8)
        responseLen = ReadResponse(0)
        CodeE2 = st_RCV.Substring(8, 10)

        'gather pumpkins 
        If EnterCodeOrTimerUp = 1 Then '1 is Enter Code was selected, as opposed to time expiring
            StrVar = InputBox("ENTER CODE" & vbCrLf & vbCrLf & "CONTACT SERVICE@SET-NA.COM FOR CODE", "ENTER CODE", "")
        Else 
            StrVar = InputBox("TEMPORARY CODE HAS EXPIRED" & vbCrLf & vbCrLf & "PLEASE CONTACT SERVICE@SET-NA.COM FOR PAYMENT AND CODE", "TERM EXPIRATION", "")
        End If
        

            Select Case StrVar
                Case CodeB
                        WriteCommand("$20007F1%", 9) 'SET_PARAM_DESC
                        responseLen = ReadResponse(0)
                        MsgBox("Congratulations! Payment has been authorized. Please restart the software")
                Case CodeE1
                        WriteCommand("$20007E1%", 9)
                        responseLen = ReadResponse(0)
                        WriteCommand("$21007E;0000000000%", 19) 'Need a new password 
                        responseLen = ReadResponse(0)
                        StrVar = "$21007B" & st_Today & "%"
                        WriteCommand(StrVar, StrVar.Length)
                        responseLen = ReadResponse(0)
                    MsgBox("Temporary Code Extension authorized. Please restart the software to configure")
                Case CodeE2
                        WriteCommand("$20007D1%", 9)
                        responseLen = ReadResponse(0)
                        WriteCommand("$21007D;0000000000%", 19)
                        responseLen = ReadResponse(0)
                        StrVar = "$21007A" & st_Today & "%"
                        WriteCommand(StrVar, StrVar.Length)
                        responseLen = ReadResponse(0)
                    MsgBox("Temporary Code Extension authorized. Please restart the software to configure")
                Case Else
                    MsgBox("Incorrect Code")
                   
        End Select

        If EnterCodeOrTimerUp = 1 Then
            'do nothing
        Else 
            b_ShutDownComms = True
            Me.Close()
            Application.Exit()
        End If
        

    End Sub
    Function GetToolDate(ToolDate As Integer) As String
        Dim responseLen As Integer
        Dim strVar As String
        Dim dt_shipDate As DateTime
        Dim dt_ExtensionDate As DateTime

        Select Case ToolDate
            Case 1  'Ship date 

                WriteCommand("$23007C%", 8)
                responseLen = ReadResponse(0)
                strVar = st_RCV.Substring(7,8)                
                dt_shipDate = DateTime.ParseExact(strVar, "ddMMyyyy",
                      System.Globalization.DateTimeFormatInfo.InvariantInfo)
                
                Return dt_shipDate

            Case 2  'temp code 1 date
                WriteCommand("$23007B%", 8)
                responseLen = ReadResponse(0)
                strVar = st_RCV.Substring(7,8)
                dt_ExtensionDate = DateTime.ParseExact(strVar, "ddMMyyyy",
                      System.Globalization.DateTimeFormatInfo.InvariantInfo)
                dt_ExtensionDate = dt_ExtensionDate.AddDays(28)
                Return dt_ExtensionDate
            Case 3  'temp code 2 date
                WriteCommand("$23007A%", 8)
                responseLen = ReadResponse(0)
                strVar = st_RCV.Substring(7,8)
                dt_ExtensionDate = DateTime.ParseExact(strVar, "ddMMyyyy",
                System.Globalization.DateTimeFormatInfo.InvariantInfo)
                dt_ExtensionDate = dt_ExtensionDate.AddDays(89)
                Return dt_ExtensionDate
            Case Else

        End Select

    End Function
  

    Private Sub CinderellaCode()
        Dim dt_todayDate As DateTime
        Dim dt_ShipDate As DateTime
        Dim dt_halfpumpkinDate As DateTime
        Dim dt_fullpumpkinDate As DateTime
        Dim dt_Extension1Date As DateTime
        Dim dt_Extension2Date As DateTime
        Dim DaysRemaining As Long        
             
        'Retreive Status from tool
        dt_ShipDate = GetToolDate(1)
        dt_todayDate = DateTime.Now
        dt_halfpumpkinDate = dt_ShipDate.AddDays(34) 
        dt_fullpumpkinDate = dt_ShipDate.AddDays(68) ' expiry date

        'Tool Due Dates: 
        If dt_todayDate < dt_ShipDate Then 'The date was tampered
            MsgBox("PLEASE CONTACT SERVICE@SET-NA.COM - ᓵᔑℸ ̣ ᔑᓭℸ ̣ ∷𝙹!¡⍑╎ᓵ ⎓ᔑ╎ꖎ⚍∷ᒷ:  ∴ᒷ ᔑ∷ᒷ ꖎ𝙹𝙹ꖌ╎リ⊣ ⎓𝙹∷ ||𝙹⚍")
            b_ShutDownComms = True
            Me.Close()
            Application.Exit()
        End If

        If GetExt1() And GetExt2() Then
            dt_Extension1Date = GetToolDate(2) 'returns first extension date
            dt_Extension2Date = GetToolDate(3) 'returns Second extension date
            If dt_Extension1Date > dt_Extension2Date Then 'this is because we dont know which extension came first...
                If dt_todayDate > dt_Extension1Date Then
                    AuthorizeCode(0)
                Else
                    DaysRemaining = DateDiff(DateInterval.Day, dt_todayDate, dt_Extension1Date) 'how many days betwen today and pumpkin date
                    MsgBox("WARNING: LICENSE WILL EXPIRE IN " & DaysRemaining & " DAYS.")
                End If
            Else
                If dt_todayDate > dt_Extension2Date Then '
                    AuthorizeCode(0)
                Else
                    DaysRemaining = DateDiff(DateInterval.Day, dt_todayDate, dt_Extension2Date) 'how many days betwen today and pumpkin date
                    MsgBox("WARNING: LICENSE WILL EXPIRE IN " & DaysRemaining & " DAYS.")
                End If
            End If
        Else
            If GetExt1() Then
                dt_Extension1Date = GetToolDate(2) 'returns first extension date
                If dt_todayDate > dt_Extension1Date Then ' Extension 1 is up...
                    AuthorizeCode(0)
                Else
                    DaysRemaining = DateDiff(DateInterval.Day, dt_todayDate, dt_Extension1Date) 'how many days betwen today and pumpkin date
                    MsgBox("WARNING: LICENSE WILL EXPIRE IN " & DaysRemaining & " DAYS.")
                End If
            ElseIf GetExt2() Then 'returns Second extension date
                dt_Extension2Date = GetToolDate(3)
                If dt_todayDate > dt_Extension2Date Then ' Extension 1 is up...
                    AuthorizeCode(0)
                Else
                    DaysRemaining = DateDiff(DateInterval.Day, dt_todayDate, dt_Extension2Date) 'how many days betwen today and pumpkin date
                    MsgBox("WARNING: LICENSE WILL EXPIRE IN " & DaysRemaining & " DAYS.")
                End If
            Else
                If dt_todayDate > dt_fullpumpkinDate Then 'Payment is due
                    AuthorizeCode(0)
                Else
                    If dt_todayDate > dt_halfpumpkinDate Then 'We're halfway there...WOAHHHHH
                        DaysRemaining = DateDiff(DateInterval.Day, dt_todayDate, dt_fullpumpkinDate) 'how many days betwen today and pumpkin date
                        MsgBox("WARNING: LICENSE WILL EXPIRE IN " & DaysRemaining & " DAYS.")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Operator_Mode() 'Size 1540x940
        'Operator Mode 
        b_ENG_mode = False 'Running Operator Mode

        'Plasma is disabled until a recipe is loaded
        If b_RecipeOpened = False Then 'if a recipe is open, dont disable the button
            RunRcpBtn.Enabled = False
        End If
               

        'Hide Engineer mode label
        EngLabel.Visible = False

        'Remove Save functionality 
        SaveToolStripMenuItem.Enabled = False 'Disable 'Save'
        SaveAsToolStripMenuItem.Enabled = False 'Disable 'Save As'
        LoadToolStripMenuItem.Enabled = False 'Disable 'Load To Controller'
        SetCTLToPLSimModeToolStripMenuItem.Enabled = False 'Disable 'Simulation Mode'
        SetDefaultToolStripMenuItem.Enabled = False 'Disable the Set Default button

        'Enter/Setpoint Buttons disabled
        For Each element In EnterButtons
            element.visible = False
        Next

        'Enter/Setpoint Buttons disabled
        For Each element In StageEnterButtons
            element.enabled = False
        Next

        'Stage Controls Buttons
        SetDiameterBtn.Visible = False
        SetTwoSpotBtn.Visible = False
        'RecipeButtonPurge.Visible = False
        'N2PurgeSquare.Visible = False
        AutoManBtn.Visible = False
        AUTO_MODE.Visible = False
        N2Purgelabel.Visible = False
        N2Purgebtn.Visible = False

         'Recipe Settings TURN OFF 
        form4.AutoScanChkBox.enabled = False
        form4.CollisionCheckBox.enabled = False
        
        'Com Port
        Com_Port_Label.Visible = False
        com_portBox.Visible = False
        Start_Stop_Toggle.Visible = False

    End Sub

    Private Sub Engineer_Mode() 'Default size of Form 1024, 669
        'ENG Mode 
        b_ENG_mode = True 'Running Engineer  Mode

        'The indicator label for Engineer mode
        EngLabel.Visible = True

        RunRcpBtn.Enabled = True        

        'Engineers can turn on plasma without constraints
        RunRcpBtn.FillColor = Color.BlueViolet

        'Remove Save functionality 
        If b_RecipeOpened Then
             SaveToolStripMenuItem.Enabled = True
        End If
        SaveAsToolStripMenuItem.Enabled = True 'Disable 'Save As'
        LoadToolStripMenuItem.Enabled = True 'Disable 'Load To Controller'
        SetCTLToPLSimModeToolStripMenuItem.Enabled = True
        SetDefaultToolStripMenuItem.Enabled = True 'Disable the Set Default button

        'Enter/Setpoint Buttons
        For Each element In EnterButtons
            element.visible = True
        Next

        'Enter/Setpoint Buttons disabled
        For Each element In StageEnterButtons
            element.enabled = True
        Next
        If SMInitAxes.State = IASM_INITIALIZED Then
            SetTwoSpotBtn.Visible = True
            SetDiameterBtn.Visible = True
        End If

        RunScanBtn.Enabled = True

        'Stage Controls Buttons
        AutoManBtn.Visible = True
        AUTO_MODE.Visible = True

        N2Purgelabel.Visible = True
        N2Purgebtn.Visible = True

        'Recipe Settings TURN ON 
        form4.AutoScanChkBox.enabled = true
        'form4.CollisionCheckBox.enabled = true 'disabled for amazon shipment 
        
        'Com Port
        Com_Port_Label.Visible = True
        com_portBox.Visible = True
        Start_Stop_Toggle.Visible = True

    End Sub

    Private Sub CollisionLaser()
        Dim ResponseLen As Integer

          if AxesStatus.XError = &H08 or AxesStatus.YError = &H08 or AxesStatus.ZError = &H08 Then 
            CLaser.State = CLSM_TRIPPED            
          End If

        Select Case CLaser.State

            Case CLSM_TRIPPED 'Laser Sense TRIPPED/COLLISION detected
                AC_CODE.Visible = True
                AC_CODE.Text = "LASER TRIPPED"
                WriteLogLine("Laser Sensor Tripped")
                b_ClearAbort = True
                
                ClearAbortbtn.Visible = True
                b_CollisionPassed = False 'reset the collision flag
                    
                SMScan.State = SCSM_IDLE 'disable other motor moving state machines and buttons
                SMScan.SubState = SCSM_SUB_IDLE
                SMTwoSpot.State = TSSM_IDLE
                SMCollisionPass.State = CPSM_IDLE                
                LaserSenseSquare.BackColor = Color.Red
                                
                
            Case CLSM_ACTIVATE 'Turn ON Laser Sense
                WriteCommand("$BA01%", 6) '//  'WATCH_SUBST_SENSE $BA0p%; resp[!BA0p#] p = 0, 1 turn watch (OFF, ON)
                ResponseLen = ReadResponse(0)    
                WriteLogLine("Laser Sensor Active")
                LaserSenseSquare.BackColor = Color.Lime

                CLaser.State = CLSM_IDLE
            Case CLSM_DEACTIVATE 'Turn OFF Laser Sense
                WriteCommand("$BA00%", 6) '//  'WATCH_SUBST_SENSE $BA0p%; resp[!BA0p#] p = 0, 1 turn watch (OFF, ON)
                ResponseLen = ReadResponse(0)
                WriteLogLine("Laser Sense Deactived")
                LaserSenseSquare.BackColor = Color.Gainsboro
                'The Operator Scan button is enabled when plasma is on
                CLaser.State = CLSM_IDLE
            Case CLSM_IDLE
                'DO NOTHING
        End Select

    End Sub

  

    Private Sub SetLightTower()
        Dim ResponseLen As Integer

        'All Light tower Conditions
        If (GlobalmyStatusBits And &H80) > 0 Then 'For setting the light tower red during PublishAbortCode() 
            LightTwr.State = LTSM_ERROR
        ElseIf AxesStatus.b_DoorsOpen Then 'Light Tower Red for doors open
            LightTwr.State = LTSM_ERROR        
        ElseIf b_RunRecipeOn And AxesStatus.b_DoorsOpen = False Then 'Light Tower Green for PLASMA 
            LightTwr.State = LTSM_ACTIVE
        Else 'set the tower to Yellow if its not already in yellow mode
            If LightTwr.State <> LTSM_READY Then LightTwr.State = LTSM_READY
        End If

        Select Case LightTwr.State

            Case LTSM_ERROR 'Light tower turns red - error commands and dangrous conditions
                WriteCommand("$CB01%", 6) '//  $CB0n% resp[!CB0n#] n = 0,1,2,3 (none, red, amber, green)
                ResponseLen = ReadResponse(0)
                LightTwr.State = LTSM_IDLE
            Case LTSM_READY 'Light tower turns amber - ready to recieve/process commands 
                WriteCommand("$CB02%", 6) '// $CB0n% resp[!CB0n#] n = 0,1,2,3 (none, red, amber, green)
                ResponseLen = ReadResponse(0)
                'When doors are Open, we need to turn the buttons back on
                'Disable Scan button for Operators
                LightTwr.State = LTSM_IDLE
            Case LTSM_ACTIVE
                WriteCommand("$CB03%", 6) '//  $CB0n% resp[!CB0n#] n = 0,1,2,3 (none, red, amber, green)
                ResponseLen = ReadResponse(0)
                'The Operator Scan button is enabled when plasma is on
                LightTwr.State = LTSM_IDLE
            Case LTSM_IDLE
                'DO NOTHING
        End Select

    End Sub

    Private Sub RunInitAxesSM()
        Dim ResponseLen As Integer
        Select Case SMInitAxes.State

            Case IASM_START_UP
                WriteCommand("$B3%", 4) 'Stop All Motors
                ResponseLen = ReadResponse(0)
                'turn off Substrate N2 Purge (assume it's on)
                WriteCommand("$C700%", 6) 'SET_VALVE_2 $C70n% resp[!C70n#] n = 0, 1 (off, on)
                ResponseLen = ReadResponse(0)

                SMScan.State = SCSM_IDLE 'disable other motor moving state machines and buttons
                SMScan.SubState = SCSM_SUB_IDLE

                SMHomeAxes.State = HASM_IDLE
                SMTwoSpot.State = TSSM_IDLE
                RunScanBtn.Visible = False
                SetTwoSpotBtn.Visible = False
                SetDiameterBtn.Visible = False
                HomeAxesBtn.Visible = False

                WriteLogLine("Initializing Axes")
                CurrentStepTxtBox.Text = "Initializing Axes"
                NextStepTxtBox.Text = ""

                WriteCommand("$B500%", 6) 'Start initialize X axis
                ResponseLen = ReadResponse(0)
                WriteCommand("$B501%", 6) 'Start initialize Y axis
                ResponseLen = ReadResponse(0)
                WriteCommand("$B502%", 6) 'Start initialize Z axis
                ResponseLen = ReadResponse(0)


                SMInitAxes.State = IASM_WAIT_FOR_DONE

            Case IASM_WAIT_FOR_DONE
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    SMInitAxes.State = IASM_INITIALIZED
                    WriteLogLine("Stage Initialized")

                    CurrentStepTxtBox.Text = "Stage Initialized"

                    RunScanBtn.Text = "START SCAN"
                    SetTwoSpotBtn.Text = "SET TWO SPOT"
                    SetDiameterBtn.Text = "SET DIAMETER"
                    HomeAxesBtn.Text = "LOAD POSITION"
                    RunScanBtn.Visible = True
                    HomeAxesBtn.Visible = True
                    Vacbtn.Visible = True
                    RecipeButtonPins.Visible = True
                    AutoVacSquare.Visible = True
                    PinsSquare.Visible = True
                    PinsSquare.BackColor = Color.Lime                   
                    b_HasPins = True 'This is so the first time the button is hit, the button will bury the pins
                    If b_ENG_mode Then
                        SetTwoSpotBtn.Visible = True
                        SetDiameterBtn.Visible = True
                    End If
                End If
            Case IASM_IDLE
                'do nothing
            Case IASM_INITIALIZED
                'do nothing
        End Select
    End Sub

    
    Private Sub RunHomeAxesSM()
        Dim ResponseLen As Integer
        Dim st_Command As String
        Dim db_ZParkPos As Double = 0.0

        Select Case SMHomeAxes.State

            Case HASM_START 'Start by parking Z in a safe position to move
                RunScanBtn.Visible = False
                SetTwoSpotBtn.Visible = False
                SetDiameterBtn.Visible = False
                HomeAxesBtn.Text = "STOP"
                               

                WriteLogLine("Homing Start")
                CurrentStepTxtBox.Text = "Homing Start"
                st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                ResponseLen = ReadResponse(0)
                db_ZParkPos = CoordParam.db_ZPinsBuriedPos '20200123
                st_Command = "$B602" & db_ZParkPos.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                ResponseLen = ReadResponse(0)
                WriteLogLine("Move Z Speed: " & Param.db_Z_Max_Speed.ToString("F") & " /sec " & "to " & db_ZParkPos.ToString("F"))
                               

                SMHomeAxes.State = HASM_WAIT_PARK_Z

            Case HASM_WAIT_PARK_Z 'wait until Z is parked
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    SMHomeAxes.State = HASM_HOME_XY
                    WriteLogLine("Homing Z Parked")
                End If

            Case HASM_HOME_XY
                WriteLogLine("Homing X & Y") 'set speeds
                CurrentStepTxtBox.Text = "Homing X & Y"
                st_Command = "$B400" & Param.db_X_Max_Speed.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                ResponseLen = ReadResponse(0)
                st_Command = "$B401" & Param.db_Y_Max_Speed.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                ResponseLen = ReadResponse(0)
                WriteLogLine("Move X Speed: " & Param.db_X_Max_Speed.ToString("F") & " /sec " &
                    "Move Y Speed: " & Param.db_Y_Max_Speed.ToString("F") & " /sec ")
                st_Command = "$B600" & Param.db_X_Home_Pos.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                ResponseLen = ReadResponse(0)
                st_Command = "$B601" & Param.db_Y_Home_Pos.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                ResponseLen = ReadResponse(0)
                WriteLogLine("X to: " & Param.db_X_Home_Pos.ToString("F") & " Y to: " & Param.db_Y_Home_Pos.ToString("F"))
                SMHomeAxes.State = HASM_WAIT_HOME_XY

            Case HASM_WAIT_HOME_XY
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    SMHomeAxes.State = HASM_HOME_Z
                    WriteLogLine("X & Y Homed")
                    'AxesStatusTxtBox.Text = ""
                End If

            Case HASM_HOME_Z
                WriteLogLine("Homing Z")
                CurrentStepTxtBox.Text = "Homing Z"
                'st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                'WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                'ResponseLen = ReadResponse(0)
                'LogStr = "Move Z Speed: " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                db_ZParkPos = CoordParam.db_ZPinsBuriedPos '20200123
                st_Command = "$B602" & db_ZParkPos.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                ResponseLen = ReadResponse(0)
                WriteLogLine("Z to " & db_ZParkPos.ToString("F"))
                SMHomeAxes.State = HASM_WAIT_HOME_Z

            Case HASM_WAIT_HOME_Z
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    SMHomeAxes.State = HASM_IDLE
                    WriteLogLine("Z Homed")
                    CurrentStepTxtBox.Text = ""
                    HomeAxesBtn.Text = "LOAD POSITION"

                    RunScanBtn.Visible = True
                    If b_ENG_mode Then
                        SetTwoSpotBtn.Visible = True
                        SetDiameterBtn.Visible = True
                    End If
                   
                End If
            Case HASM_SHUT_DOWN
                WriteCommand("$B3%", 4) 'stop any motors in motion
                ResponseLen = ReadResponse(0)
                WriteLogLine("Operator Abort Homing")
                CurrentStepTxtBox.Text = "Operator Abort Homing"
                'park Z
                st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                ResponseLen = ReadResponse(0)
                db_ZParkPos = CoordParam.db_ZPinsBuriedPos '20200123
                st_Command = "$B602" & db_ZParkPos.ToString("F") & "%"
                WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                ResponseLen = ReadResponse(0)
                WriteLogLine("Move Z at " & Param.db_Z_Max_Speed.ToString("F") & " /sec " & "to: " & SMScan.db_ZParkPos.ToString("F"))
                RunScanBtn.Visible = True
                If b_ENG_mode Then
                    SetTwoSpotBtn.Visible = True
                    SetDiameterBtn.Visible = True
                End If
                
                HomeAxesBtn.Text = "LOAD POSITION"
                CurrentStepTxtBox.Text = ""
                SMHomeAxes.State = HASM_IDLE
            Case HASM_IDLE 'do nothing

        End Select

    End Sub
    Private Sub RunTwoSpotSM() 'the two spot marker state machine. In polling loop, so can send commands
        Dim ResponseLen As Integer

        Select Case SMTwoSpot.State

            Case TSSM_START_UP 'turn on the joystick
                RunScanBtn.Visible = False
                HomeAxesBtn.Visible = False
                SetDiameterBtn.Visible = False
                PinsSquare.Visible = False
                RecipeButtonPins.Visible = False
                AutoVacSquare.Visible = False
                Vacbtn.Visible = False
                SetTwoSpotBtn.Text = "STOP"
                WriteLogLine("TwoSpotSM Start Up")
                WriteCommand("$BE%", 4) 'ENABLE_JOY  $BE%; resp [!BE#];
                ResponseLen = ReadResponse(1)
                SMTwoSpot.State = TSSM_GET_FIRST
                WriteLogLine("TwoSpotSM Getting First")
                CurrentStepTxtBox.Text = ("Joy Stick is Enabled")
                NextStepTxtBox.Text = ("Spot First Point")

                
            Case TSSM_GET_FIRST
                If AxesStatus.b_LEDJoyBtnOn = True Then ' get the first XY Point pair
                    WriteLogLine("TwoSpotSM Got First")
                    NextStepTxtBox.Text = ("Release JoyStick Button")
                    SMTwoSpot.db_FirstXPos = db_C_XPos_RefB_2_RefPH(AxesStatus.db_XPos) 'translate into PH coords
                    SMTwoSpot.db_FirstYPos = db_Ys_2_PH(AxesStatus.db_YPos) 'translate into PH coords
                    SMTwoSpot.State = TSSM_WAIT_JOY_BTN_OFF
                End If

            Case TSSM_WAIT_JOY_BTN_OFF
                If AxesStatus.b_LEDJoyBtnOn = False Then 'proceed to wait for the next measurement
                    SMTwoSpot.State = TSSM_GET_SECOND
                    WriteLogLine("TwoSpotSM Getting Second")
                    NextStepTxtBox.Text = ("Spot Second Point")
                End If

            Case TSSM_GET_SECOND
                If AxesStatus.b_LEDJoyBtnOn = True Then ' get the second XY Point pair
                    SMTwoSpot.db_SecondXPos = db_C_XPos_RefB_2_RefPH(AxesStatus.db_XPos) 'translate into PH coords
                    SMTwoSpot.db_SecondYPos = db_Ys_2_PH(AxesStatus.db_YPos) 'translate into PH coords
                    'determine box orientation and corners
                    If SMTwoSpot.db_FirstXPos > SMTwoSpot.db_SecondXPos Then
                        SMScan.db_XMinPos = SMTwoSpot.db_SecondXPos
                        SMScan.db_XMaxPos = SMTwoSpot.db_FirstXPos
                    Else
                        SMScan.db_XMinPos = SMTwoSpot.db_FirstXPos
                        SMScan.db_XMaxPos = SMTwoSpot.db_SecondXPos
                    End If

                    If SMTwoSpot.db_FirstYPos > SMTwoSpot.db_SecondYPos Then
                        SMScan.db_YMinPos = SMTwoSpot.db_SecondYPos
                        SMScan.db_YMaxPos = SMTwoSpot.db_FirstYPos
                    Else
                        SMScan.db_YMinPos = SMTwoSpot.db_FirstYPos
                        SMScan.db_YMaxPos = SMTwoSpot.db_SecondYPos
                    End If
                    'update the "actual" display after coord sys translation
                    RecipeXMinTxt.Text = SMScan.db_XMinPos.ToString("F") '2 decimal point
                    RecipeXMaxTxt.Text = SMScan.db_XMaxPos.ToString("F") '2 decimal point
                    RecipeYMinTxt.Text = SMScan.db_YMinPos.ToString("F") '2 decimal point
                    RecipeYMaxTxt.Text = SMScan.db_YMaxPos.ToString("F") '2 decimal point
                    WriteLogLine("TwoSpotSM Got Second - done")
                    SMTwoSpot.State = TSSM_CLOSE_DOWN
                End If

            Case TSSM_CLOSE_DOWN
                WriteCommand("$BF%", 4) 'DISABLE_JOY  $BF%; resp [!BF#];
                ResponseLen = ReadResponse(0)
                SMTwoSpot.State = TSSM_IDLE
                CurrentStepTxtBox.Text = ""
                NextStepTxtBox.Text = ""
                RunScanBtn.Visible = True
                HomeAxesBtn.Visible = True
                SetDiameterBtn.Visible = True
                PinsSquare.Visible = True
                RecipeButtonPins.Visible = True
                AutoVacSquare.Visible = True
                Vacbtn.Visible = True
                SetTwoSpotBtn.Text = "SET TWO SPOT"

                
            Case TSSM_IDLE 'do nothing

        End Select

    End Sub

    Private Sub RunDiameter() 'calculate scan recipe based on wafer diameter selected
        Dim db_Radius As Double
        Dim db_Val As Double

        'find the radius
        db_Radius = MainWindow.SelectedWaferSize / 2.0
        'find the points defining the box
        SMScan.db_XMinPos = CoordParam.db_Xp_2_Base - db_Radius
        SMScan.db_XMaxPos = CoordParam.db_Xp_2_Base + db_Radius
        SMScan.db_YMinPos = CoordParam.db_Yp_2_Base - db_Radius
        SMScan.db_YMaxPos = CoordParam.db_Yp_2_Base + db_Radius

        'update the "actual" display after coord sys translation
        db_Val = db_C_XPos_RefB_2_RefPH(SMScan.db_XMinPos)
        RecipeXMinTxt.Text = db_Val.ToString("F") '2 decimal point
        db_Val = db_C_XPos_RefB_2_RefPH(SMScan.db_XMaxPos)
        RecipeXMaxTxt.Text = db_Val.ToString("F") '2 decimal point
        db_Val = db_C_YPos_RefB_2_RefPH(SMScan.db_YMinPos)
        RecipeYMinTxt.Text = db_Val.ToString("F") '2 decimal point
        db_Val = db_C_YPos_RefB_2_RefPH(SMScan.db_YMaxPos)
        RecipeYMaxTxt.Text = db_Val.ToString("F") '2 decimal point

    End Sub

    Private Sub RunScanSM()
        Dim ResponseLen As Integer
        Dim st_Command As String
        Dim st_Message As String
        Dim db_XLengthRemaining As Double
        Dim LogStr As String
        Dim db_MinPerPH As Double
        Dim db_MaxPerPH As Double

        'enable asynch events (buttons) to change state at the top of this loop
        If SMScan.b_ExternalStateChange = True Then
            SMScan.State = SMScan.ExternalNewState
            SMScan.b_ExternalStateChange = False
        End If

        Select Case SMScan.State
            Case SCSM_START_UP 'prep all the scan parameters

                HomeAxesBtn.Visible = False
                SetTwoSpotBtn.Visible = False
                SetDiameterBtn.Visible = False
                RunScanBtn.Text = "STOP"
                'load scan variables
                'tranlate from Displayed PH coords to moveable Base coords
                db_MinPerPH = db_C_XPos_RefPH_2_RefB(Convert.ToDouble(RecipeXMinTxt.Text))
                db_MaxPerPH = db_C_XPos_RefPH_2_RefB(Convert.ToDouble(RecipeXMaxTxt.Text))
                If db_MaxPerPH > db_MinPerPH Then 'because coord systems can be flipped
                    SMScan.db_XMaxPos = db_MaxPerPH
                    SMScan.db_XMinPos = db_MinPerPH
                Else
                    SMScan.db_XMaxPos = db_MinPerPH
                    SMScan.db_XMinPos = db_MaxPerPH
                End If
                db_MinPerPH = db_C_YPos_RefPH_2_RefB(Convert.ToDouble(RecipeYMinTxt.Text))
                db_MaxPerPH = db_C_YPos_RefPH_2_RefB(Convert.ToDouble(RecipeYMaxTxt.Text))
                If db_MaxPerPH > db_MinPerPH Then 'because coord systems can be flipped
                    SMScan.db_YMaxPos = db_MaxPerPH
                    SMScan.db_YMinPos = db_MinPerPH
                Else
                    SMScan.db_YMaxPos = db_MinPerPH
                    SMScan.db_YMinPos = db_MaxPerPH
                End If

                'SMScan.db_ZParkPos = 0
                SMScan.db_ZParkPos = CoordParam.db_ZPinsBuriedPos '20200123
                SMScan.db_ZScanPos = Param.db_Z_Head_Pos - Convert.ToDouble(RecipeThicknessTxt.Text) - Convert.ToDouble(RecipeGapTxt.Text)

                'Get the Scan Row Info
                SMScan.db_RowXWidth = CoordParam.db_PlasmaHeadSlitLength - Convert.ToDouble(RecipeOverLapTxt.Text)
                db_XLengthRemaining = SMScan.db_XMaxPos - SMScan.db_XMinPos
                SMScan.NumXRows = 0
                While db_XLengthRemaining >= 0
                    SMScan.NumXRows += 1
                    db_XLengthRemaining = db_XLengthRemaining - SMScan.db_RowXWidth
                End While
                SMScan.ThisXRow = 1
                SMScan.NumCycles = Convert.ToInt32(RecipeCyclesTxt.Text)
                SMScan.ThisCycleNum = 1

                If SMScan.NumXRows = 1 Then 'have small substrate case, center the head over the center of the Box X
                    SMScan.db_StartXPosition = (SMScan.db_XMaxPos + SMScan.db_XMinPos) / 2
                Else 'multiple passes, so bias first pass to maximum edge
                    SMScan.db_StartXPosition = SMScan.db_XMaxPos - (SMScan.db_RowXWidth / 2) 'start position offset to center of slit
                End If

                'Y scan range from start to finish positions
                SMScan.db_StartYPosition = SMScan.db_YMaxPos + CoordParam.db_PlasmaHeadSlitWidth
                SMScan.db_EndYPosition = SMScan.db_YMinPos - CoordParam.db_PlasmaHeadSlitWidth
                SMScan.db_ScanYSpeed = Convert.ToDouble(RecipeSpeedTxt.Text)

                WriteLogLine("-------------Scan Start-Up--------------")
                WriteLogLine("Display MIN:(" & RecipeXMinTxt.Text & " , " & RecipeYMinTxt.Text & ") MAX:(" & RecipeXMaxTxt.Text & " , " & RecipeYMaxTxt.Text & ")")
                WriteLogLine("Num Rows: " & SMScan.NumXRows.ToString & " Row Width: " & SMScan.db_RowXWidth.ToString("F"))
                WriteLogLine("FirstX: " & SMScan.db_StartXPosition.ToString("F") & " StartY: " & SMScan.db_StartYPosition.ToString("F") & " EndY: " & SMScan.db_EndYPosition.ToString("F"))
                WriteLogLine("Scan Speed: " & SMScan.db_ScanYSpeed.ToString("F") & " Cycles: " & SMScan.NumCycles.ToString)

                If b_HasCollision = True And b_CollisionPassed <> true then 'if we have a laser, we need to perform collision test, once completed we can move into regualar scanning
                    SMScan.State = SCSM_IDLE
                    SMScan.SubState = SCSM_SUB_IDLE
                    SMCollisionPass.State = CPSM_START_UP
                Else 
                    SMScan.State = SCSM_SCAN
                    SMScan.SubState = SCSM_SUB_PARK_Z
                    CurrentStepTxtBox.Text = ("Scanning")
                End If
                

            Case SCSM_SCAN
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState = ASM_IDLE Then 'stage not moving, transition to next move

                    Select Case SMScan.SubState 'scanning substates
                        Case SCSM_SUB_PARK_Z

                            If (SMScan.ThisXRow > SMScan.NumXRows) Then
                                SMScan.SubState = SCSM_SUB_IDLE 'for completeness
                                SMScan.State = SCSM_RECYCLE 'All Done!
                                st_Message = "End Cycle #" & SMScan.ThisCycleNum.ToString & " of " & SMScan.NumCycles.ToString
                                WriteLogLine(st_Message)
                                NextStepTxtBox.Text = (st_Message)
                                RunScanBtn.Text = "STOP"
                            Else
                                SMScan.SubState = SCSM_SUB_GO_XY_START
                                st_Message = "Parking Z"
                                WriteLogLine(st_Message)
                                NextStepTxtBox.Text = (st_Message)
                                RunScanBtn.Text = "STOP"
                            End If
                            'turn off Substrate N2 Purge (assume it's on)
                            'WriteCommand("$C700%", 6) 'SET_VALVE_2 $C70n% resp[!C70n#] n = 0, 1 (off, on)
                            'ResponseLen = ReadResponse(0)

                            st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                            ResponseLen = ReadResponse(0)
                            LogStr = "Move Z Speed: " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                            st_Command = "$B602" & SMScan.db_ZParkPos.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                            ResponseLen = ReadResponse(0)
                            WriteLogLine(LogStr & "to " & SMScan.db_ZParkPos.ToString("F"))

                        Case SCSM_SUB_GO_XY_START 'note this is now the recycle re-entry sub-state
                            st_Message = "Scan Cycle #" & SMScan.ThisCycleNum.ToString & " of " & SMScan.NumCycles.ToString &
                                " Traversal #" & SMScan.ThisXRow.ToString & " of " & SMScan.NumXRows.ToString
                            WriteLogLine(st_Message)
                            NextStepTxtBox.Text = (st_Message)
                            st_Command = "$B400" & Param.db_X_Max_Speed.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                            ResponseLen = ReadResponse(0)
                            LogStr = "X Speed: " & Param.db_X_Max_Speed.ToString("F") & " /sec "

                            st_Command = "$B401" & Param.db_Y_Max_Speed.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                            ResponseLen = ReadResponse(0)
                            WriteLogLine(LogStr & "Y Speed: " & Param.db_Y_Max_Speed.ToString("F") & "/sec")

                            'If SMScan.ThisXRow > 1 Then SMScan.db_StartXPosition = SMScan.db_StartXPosition + SMScan.db_RowXWidth 'move over one
                            If SMScan.ThisXRow > 1 Then SMScan.db_StartXPosition = SMScan.db_StartXPosition - SMScan.db_RowXWidth 'move over one
                            st_Command = "$B600" & SMScan.db_StartXPosition.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                            ResponseLen = ReadResponse(0)
                            LogStr = "X to: " & SMScan.db_StartXPosition.ToString("F")
                            st_Command = "$B601" & SMScan.db_StartYPosition.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                            ResponseLen = ReadResponse(0)
                            WriteLogLine(LogStr & " Y to: " & SMScan.db_StartYPosition.ToString("F"))
                            SMScan.SubState = SCSM_SUB_GO_Z_SCAN_POS
                        Case SCSM_SUB_GO_Z_SCAN_POS

                            If b_N2PurgeRecipe = True Then 'turn on the substrate N2 Purge
                                WriteCommand("$C701%", 6) 'SET_VALVE_2 $C70n% resp[!C70n#] n = 0, 1 (off, on)
                                ResponseLen = ReadResponse(0)
                            End If

                            st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                            ResponseLen = ReadResponse(0)
                            LogStr = "Move Z at: " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                            st_Command = "$B602" & SMScan.db_ZScanPos.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                            ResponseLen = ReadResponse(0)
                            WriteLogLine(LogStr & "to: " & SMScan.db_ZScanPos.ToString("F"))
                            SMScan.SubState = SCSM_SUB_SCAN_COL
                        Case SCSM_SUB_SCAN_COL
                            st_Command = "$B401" & SMScan.db_ScanYSpeed.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                            ResponseLen = ReadResponse(0)
                            LogStr = "Move Y at " & SMScan.db_ScanYSpeed.ToString("F") & " /sec "
                            st_Command = "$B601" & SMScan.db_EndYPosition.ToString("F") & "%"
                            WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                            ResponseLen = ReadResponse(0)
                            WriteLogLine(LogStr & "to: " & SMScan.db_EndYPosition.ToString("F"))
                            SMScan.ThisXRow += 1 'increment row counter
                            SMScan.SubState = SCSM_SUB_PARK_Z

                        Case SCSM_SUB_IDLE 'do nothing
                    End Select
                End If
            Case SCSM_RECYCLE 'do it again?
                If SMScan.ThisCycleNum >= SMScan.NumCycles Then 'do not recycle
                    'Assume N2 is on, turn it off
                    WriteCommand("$C700%", 6) 'SET_VALVE_2 $C70n% resp[!C70n#] n = 0, 1 (off, on)
                    ResponseLen = ReadResponse(0)

                    CurrentStepTxtBox.Text = ("Scanning Completed")
                    HomeAxesBtn.Visible = True
                    If b_ENG_mode Then
                        SetTwoSpotBtn.Visible = True
                        SetDiameterBtn.Visible = True
                    End If
                    RunScanBtn.Text = "START SCAN"
                    SMScan.State = SCSM_IDLE
                    'Auto off will turn the recipe off and PLASMA.
                    If b_autoScanActive = true Then
                        WriteLogLine("Plasma turned off (Auto-Off is active)")
                        WriteCommand("$8700%", 6)
                        ResponseLen = ReadResponse(0)
                    End If
                    b_CollisionPassed = False 'reset the collision flag

                    SMHomeAxes.State = HASM_START 'Go to the Load position everytime you finish scanning zm 
                Else 'recycle the scan
                    SMScan.ThisCycleNum += 1
                        SMScan.ThisXRow = 1

                        If SMScan.NumXRows = 1 Then 'have small substrate case, center the head over the center of the Box X
                            SMScan.db_StartXPosition = (SMScan.db_XMaxPos + SMScan.db_XMinPos) / 2
                        Else 'multiple passes, so bias first pass to maximum edge
                            SMScan.db_StartXPosition = SMScan.db_XMaxPos - (SMScan.db_RowXWidth / 2) 'start position offset to center of slit
                        End If

                        WriteLogLine("-------------Scan Recycle Start-Up--------------" & "This Cycle: " & SMScan.ThisCycleNum.ToString)
                        WriteLogLine("Display MIN:(" & RecipeXMinTxt.Text & " , " & RecipeYMinTxt.Text & ") MAX:(" & RecipeXMaxTxt.Text & " , " & RecipeYMaxTxt.Text & ")")
                        WriteLogLine("Num Rows: " & SMScan.NumXRows.ToString & " Row Width: " & SMScan.db_RowXWidth.ToString("F"))
                        WriteLogLine("FirstX: " & SMScan.db_StartXPosition.ToString("F") & " StartY: " & SMScan.db_StartYPosition.ToString("F") & " EndY: " & SMScan.db_EndYPosition.ToString("F"))
                        WriteLogLine("Scan Speed: " & SMScan.db_ScanYSpeed.ToString("F") & " Cycles: " & SMScan.NumCycles.ToString)

                        SMScan.State = SCSM_SCAN
                        SMScan.SubState = SCSM_SUB_GO_XY_START 'reenter here because already Parked Z
                    End If
                    Case SCSM_SHUT_DOWN
                    If SMScan.SubState = SCSM_SUB_IDLE Then 'not doing anything anyway, shut 'er down
                        SMScan.State = SCSM_IDLE
                    Else 'stop and park Z
                        CurrentStepTxtBox.Text = ("Scanning Stopped - Parking Z")
                        WriteCommand("$B3%", 4) 'stop any motors in motion
                        ResponseLen = ReadResponse(0)
                        'turn of Substrate N2 Purge (assume it's on)
                        WriteCommand("$C700%", 6) 'SET_VALVE_2 $C70n% resp[!C70n#] n = 0, 1 (off, on)
                        ResponseLen = ReadResponse(0)
                        st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                        WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                        ResponseLen = ReadResponse(0)
                        LogStr = "Move Z at " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                        st_Command = "$B602" & SMScan.db_ZParkPos.ToString("F") & "%"
                        WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                        ResponseLen = ReadResponse(0)
                        WriteLogLine(LogStr & "to: " & SMScan.db_ZParkPos.ToString("F"))
                        SMScan.State = SCSM_IDLE
                        SMScan.SubState = SCSM_SUB_IDLE
                        CurrentStepTxtBox.Text = ("Scanning Manually Stopped")
                        RunScanBtn.Text = "START SCAN"
                        b_CollisionPassed = False 'reset the collision flag
                    
                        
                       
                    End If
                    HomeAxesBtn.Visible = True
                    If b_ENG_mode Then
                        SetTwoSpotBtn.Visible = True
                        SetDiameterBtn.Visible = True
                    End If
                    RunScanBtn.Text = "START SCAN"

                    Case SCSM_IDLE
        End Select
    End Sub

    Private Sub RunCollisionPassSM()
        Dim ResponseLen As Integer
        Dim st_Command As String
        Dim LogStr As String
        Dim db_MinPerPH As Double
        Dim db_MaxPerPH As Double

        
         Select Case SMCollisionPass.State
            Case CPSM_START_UP 'prep all the scan parameters

                'Watch for the Substrate Laser Sensor (ON)
                CLaser.State = CLSM_ACTIVATE
                WriteLogLine("-------------Collision Pass Start-Up--------------")            
                CurrentStepTxtBox.Text = ("Collision Test")
                SMCollisionPass.State = CPSM_GET_Z_UP
                
                If b_plasmaActive = True then
                    b_ToggleRunRecipe = True
                End If 

            
            Case CPSM_GET_Z_UP
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                    WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                    ResponseLen = ReadResponse(0)
                    LogStr = "Move Z at: " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                    st_Command = "$B602" & SMScan.db_ZScanPos.ToString("F") & "%"
                    WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                    ResponseLen = ReadResponse(0)
                    WriteLogLine(LogStr & "to: " & SMScan.db_ZScanPos.ToString("F"))
                    SMCollisionPass.State = CPSM_SCAN_Y
                End If 
            Case CPSM_SCAN_Y
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    st_Command = "$B40110%"
                    WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                    ResponseLen = ReadResponse(0)
                    LogStr = "Move Y at 10mm/sec "
                    st_Command = "$B601" & SMScan.db_EndYPosition.ToString("F") & "%"
                    WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                    ResponseLen = ReadResponse(0)
                    WriteLogLine(LogStr & "to: " & SMScan.db_EndYPosition.ToString("F"))
                    SMCollisionPass.State = CPSM_GET_Z_DOWN
                End If 
            Case CPSM_GET_Z_DOWN
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    st_Command = "$B402" & Param.db_Z_Max_Speed.ToString("F") & "%"
                    WriteCommand(st_Command, st_Command.Length) 'SET_SPEED  $B40xss.ss%; resp [!B40xss.ss#] 0x = axis number, ss.ss = mm/sec (float)
                    ResponseLen = ReadResponse(0)
                    LogStr = "Move Z Speed: " & Param.db_Z_Max_Speed.ToString("F") & " /sec "
                    st_Command = "$B602" & SMScan.db_ZParkPos.ToString("F") & "%"
                    WriteCommand(st_Command, st_Command.Length) 'ABS_MOVE $B60xaa.aa%; resp [!B60xaa.aa#] 0x = axis num, aa.aa = destination in mm (float)
                    ResponseLen = ReadResponse(0)
                    WriteLogLine(LogStr & "to " & SMScan.db_ZParkPos.ToString("F"))
                    SMCollisionPass.State = CPSM_SHUT_DOWN
                End If                     
            Case CPSM_SHUT_DOWN 
                If AxesStatus.b_XYZSameState = True And AxesStatus.XState >= ASM_IDLE Then
                    SMCollisionPass.State = CPSM_IDLE                                    
                    CurrentStepTxtBox.Text = ("Scanning")
                    CLaser.State = CLSM_DEACTIVATE
                    b_CollisionPassed = True
                    'Go here to scan
                    if b_PlannedAutoStart = True Then
                        b_ToggleRunRecipe = True 'Turn plasma on
                        b_PlannedAutoStart = False 
                    Else 
                         SMScan.ExternalNewState = SCSM_START_UP
                         SMScan.b_ExternalStateChange = True
                    End If
                    
                End If 


            Case CPSM_IDLE 'do nothing
         End Select
    End Sub
End Class
