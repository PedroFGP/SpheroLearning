namespace Sphero
{
    public static class StorageCode
    {
        public static byte Temporary
        {
            get
            {
                return 0x00;
            }
        }

        public static byte Persistent
        {
            get
            {
                return 0x01;
            }
        }
    }

    public enum DeviceID
    {
        DID_CORE = 0x00,
        DID_BOOTLOADER = 0x01,
        DID_SPHERO = 0x02
    }

    public enum CoreCommand
    {
        CMD_PING = 0x01,
        CMD_VERSION = 0x02,
        CMD_CONTROL_UART_TX = 0x03,
        CMD_SET_BT_NAME = 0x10,
        CMD_GET_BT_NAME = 0x11,
        CMD_SET_AUTO_RECONNECT = 0x12,
        CMD_GET_AUTO_RECONNECT = 0x13,
        CMD_GET_PWR_STATE = 0x20,
        CMD_SET_PWR_NOTIFY = 0x21,
        CMD_SLEEP = 0x22,
        GET_POWER_TRIPS = 0x23,
        SET_POWER_TRIPS = 0x24,
        SET_INACTIVE_TIMER = 0x25,
        CMD_GOTO_BL = 0x30,
        CMD_RUN_L1_DIAGS = 0x40,
        CMD_RUN_L2_DIAGS = 0x41,
        CMD_CLEAR_COUNTERS = 0x42,
        CMD_ASSIGN_TIME = 0x50,
        CMD_POLL_TIMES = 0x51
    }

    public enum SpheroCommand
    {
        CMD_SET_CAL = 0x01,
        CMD_SET_STABILIZ = 0x02,
        CMD_SET_ROTATION_RATE = 0x03,
        CMD_SET_CREATION_DATE = 0x04,
        CMD_GET_BALL_REG_WEBSITE = 0x05,
        CMD_REENABLE_DEMO = 0x06,
        CMD_GET_CHASSIS_ID = 0x07,
        CMD_SET_CHASSIS_ID = 0x08,
        CMD_SELF_LEVEL = 0x09,
        CMD_SET_VDL = 0x0A,
        CMD_SET_DATA_STREAMING = 0x11,
        CMD_SET_COLLISION_DET = 0x12,
        CMD_LOCATOR = 0x13,
        CMD_SET_ACCELERO = 0x14,
        CMD_READ_LOCATOR = 0x15,
        CMD_SET_RGB_LED = 0x20,
        CMD_SET_BACK_LED = 0x21,
        CMD_GET_RGB_LED = 0x22,
        CMD_ROLL = 0x30,
        CMD_BOOST = 0x31,
        CMD_MOVE = 0x32,
        CMD_SET_RAW_MOTORS = 0x33,
        CMD_SET_MOTION_TO = 0x34,
        CMD_SET_OPTIONS_FLAG = 0x35,
        CMD_GET_OPTIONS_FLAG = 0x36,
        CMD_SET_TEMP_OPTIONS_FLAG = 0x37,
        CMD_GET_TEMP_OPTIONS_FLAG = 0x38,
        CMD_GET_CONFIG_BLK = 0x40,
        CMD_SET_SSB_PARAMS = 0x41,
        CMD_SET_DEVICE_MODE = 0x42,
        CMD_SET_CFG_BLOCK = 0x43,
        CMD_GET_DEVICE_MODE = 0x44,
        CMD_GET_SSB = 0x46,
        CMD_SET_SSB = 0x47,
        CMD_SSB_REFILL = 0x48,
        CMD_SSB_BUY = 0x49,
        CMD_SSB_USE_CONSUMEABLE = 0x4A,
        CMD_SSB_GRANT_CORES = 0x4B,
        CMD_SSB_ADD_XP = 0x4C,
        CMD_SSB_LEVEL_UP_ATTR = 0x4D,
        CMD_GET_PW_SEED = 0x4E,
        CMD_SSB_ENABLE_ASYNC = 0x4F,
        CMD_RUN_MACRO = 0x50,
        CMD_SAVE_TEMP_MACRO = 0x51,
        CMD_SAVE_MACRO = 0x52,
        CMD_INIT_MACRO_EXECUTIVE = 0x54,
        CMD_ABORT_MACRO = 0x55,
        CMD_MACRO_STATUS = 0x56,
        CMD_SET_MACRO_PARAM = 0x57,
        CMD_APPEND_TEMP_MACRO_CHUNK = 0x58,
        CMD_ERASE_ORBBAS = 0x60,
        CMD_APPEND_FRAG = 0x61,
        CMD_EXEC_ORBBAS = 0x62,
        CMD_ABORT_ORBBAS = 0x63,
        CMD_ANSWER_INPUT = 0x64,
        CMD_COMMIT_TO_FLASH = 0x65
        //CMD_COMMIT_TO_FLASH = 0x70,
    }
    public enum ResponseCode
    {
        CommandOK = 0x00,                   // Command succeeded
        ErrorGeneral = 0x01,                // General, non-specific error
        ErrorChecksum = 0x02,               // Received checksum failure
        ErrorFragment = 0x03,               // Received command fragment
        UnknownCommand = 0x04,              // Unknown command ID
        UnsupportedCommand = 0x05,          // Command currently unsupported
        BadMessageFormat = 0x06,            // Bad message format
        ParameterValuesInvalid = 0x07,      // Parameter value(s) invalid
        CommandExecutionFailed = 0x08,      // Failed to execute command
        UnknownDeviceID = 0x09,             // Unknown Device ID
        MemoryBusy = 0x0A,                  // Generic RAM access needed but it is busy
        BadPassword = 0x0B,                 // Supplied password incorrect
        VoltageTooLow = 0x31,               // Voltage too low for reflash operation
        IllegalPageNumber = 0x32,           // Illegal page number provided
        FlashPageProgramFail = 0x33,        // Page did not reprogram correctly
        MainApplicationCorrupt = 0x34,      // Main Application corrupt
        StateMachineTimedOut = 0x35,        // Msg state machine timed out
        None = 0xFF
    }

    public enum AsyncIDCode
    {
        PowerNotification = 0x01,
        Level1DiagnosticResponse = 0x02,
        SensorDataStream = 0x03,
        ConfigBlockContents = 0x04,
        PreSleepWarning = 0x05,
        MacroMarkers = 0x06,
        CollisionDetected = 0x07,
        OrbBasicPrint = 0x08,
        OrbBasicErrorASCII = 0x09,
        OrbBasicErrorBinary = 0x0A,
        SelfLevelResult = 0x0B,
        GyroAxisLimitExceeded = 0x0C,
        SpheroSoulData = 0x0D,
        LevelUpNotification = 0x0E,
        ShieldDamageNotification = 0x0F,
        XPUpdateNotification = 0x10,
        BoostUpdateNotification = 0x11
    }

    public static class CodeToStringConverter
    {
        public static string FullName(this AsyncIDCode code)
        {
            switch (code)
            {
                case AsyncIDCode.BoostUpdateNotification:
                    return "Boost Update Notification";
                case AsyncIDCode.OrbBasicErrorASCII:
                    return "orbBasic Error, ASCII";
                case AsyncIDCode.OrbBasicErrorBinary:
                    return "orbBasic Error, Binary";
                case AsyncIDCode.OrbBasicPrint:
                    return "orbBasic Print";
                case AsyncIDCode.PowerNotification:
                    return "Power Notification";
                case AsyncIDCode.PreSleepWarning:
                    return "Pre-sleep Warning";
                case AsyncIDCode.SelfLevelResult:
                    return "Self Level Result";
                case AsyncIDCode.SensorDataStream:
                    return "Sensor Data Stream";
                case AsyncIDCode.ShieldDamageNotification:
                    return "Shield Damage Notification";
                case AsyncIDCode.SpheroSoulData:
                    return "Sphero Soul Data";
                case AsyncIDCode.XPUpdateNotification:
                    return "XP Update Notification";
                default:
                    return "Unknown Code";
            }
        }

        public static string FullName(this ResponseCode code)
        {
            switch (code)
            {
                case ResponseCode.BadMessageFormat:
                    return "Bad Message Format";
                case ResponseCode.BadPassword:
                    return "Bad Password";
                case ResponseCode.CommandExecutionFailed:
                    return "Command Execution Failed";
                case ResponseCode.CommandOK:
                    return "Command Successful";
                case ResponseCode.ErrorChecksum:
                    return "Checksum Error";
                case ResponseCode.ErrorFragment:
                    return "Code Fragment Error";
                case ResponseCode.ErrorGeneral:
                    return "General Error";
                case ResponseCode.FlashPageProgramFail:
                    return "Flash Page Program Fail";
                case ResponseCode.IllegalPageNumber:
                    return "Illegal Page Number";
                case ResponseCode.MainApplicationCorrupt:
                    return "Main Application Corrupt";
                case ResponseCode.MemoryBusy:
                    return "Memory Busy";
                case ResponseCode.None:
                    return "None";
                case ResponseCode.ParameterValuesInvalid:
                    return "Parameter Values Invalid";
                case ResponseCode.StateMachineTimedOut:
                    return "State Machine Timed Out";
                case ResponseCode.UnknownCommand:
                    return "Unknown Command";
                case ResponseCode.UnknownDeviceID:
                    return "Unknown Device ID";
                case ResponseCode.UnsupportedCommand:
                    return "Unsupported Command";
                case ResponseCode.VoltageTooLow:
                    return "Voltage Too Low";
                default:
                    return "Unknown Code";
            }
        }

        public static string FullName(this SpheroCommand code)
        {
            switch (code)
            {
                case SpheroCommand.CMD_ABORT_MACRO:
                    return "Abort Macro";
                case SpheroCommand.CMD_ABORT_ORBBAS:
                    return "Abort orbBasic Program";
                case SpheroCommand.CMD_ANSWER_INPUT:
                    return "Return Answer Input";
                case SpheroCommand.CMD_APPEND_FRAG:
                    return "Append orbBasic Fragment";
                case SpheroCommand.CMD_APPEND_TEMP_MACRO_CHUNK:
                    return "Append Macro Chunk";
                case SpheroCommand.CMD_BOOST:
                    return "Boost";
                case SpheroCommand.CMD_COMMIT_TO_FLASH:
                    return "Commit Program to Flash";
                case SpheroCommand.CMD_ERASE_ORBBAS:
                    return "Erase orbBasic Code";
                case SpheroCommand.CMD_EXEC_ORBBAS:
                    return "Execute orbBasic Program";
                case SpheroCommand.CMD_GET_CHASSIS_ID:
                    return "Get Chassis ID";
                case SpheroCommand.CMD_GET_CONFIG_BLK:
                    return "Get Config Block";
                case SpheroCommand.CMD_GET_DEVICE_MODE:
                    return "Get Device Mode";
                case SpheroCommand.CMD_GET_OPTIONS_FLAG:
                    return "Get Options";
                case SpheroCommand.CMD_GET_PW_SEED:
                    return "Set PW Seed";
                case SpheroCommand.CMD_GET_RGB_LED:
                    return "Get RGB LED";
                case SpheroCommand.CMD_GET_SSB:
                    return "Get SSB";
                case SpheroCommand.CMD_GET_TEMP_OPTIONS_FLAG:
                    return "Get Temp Options";
                case SpheroCommand.CMD_INIT_MACRO_EXECUTIVE:
                    return "Init Macro Executive";
                case SpheroCommand.CMD_LOCATOR:
                    return "Locator";
                case SpheroCommand.CMD_MACRO_STATUS:
                    return "Macro Status";
                case SpheroCommand.CMD_MOVE:
                    return "Move";
                case SpheroCommand.CMD_READ_LOCATOR:
                    return "Read Locator";
                case SpheroCommand.CMD_REENABLE_DEMO:
                    return "Re-enable Demo";
                case SpheroCommand.CMD_ROLL:
                    return "Roll";
                case SpheroCommand.CMD_RUN_MACRO:
                    return "Run Macro";
                case SpheroCommand.CMD_SAVE_MACRO:
                    return "Save Macro";
                case SpheroCommand.CMD_SAVE_TEMP_MACRO:
                    return "Save Temp Macro";
                case SpheroCommand.CMD_SELF_LEVEL:
                    return "Self Level";
                case SpheroCommand.CMD_SET_ACCELERO:
                    return "Set Accelerometer";
                case SpheroCommand.CMD_SET_BACK_LED:
                    return "Set Back LED";
                case SpheroCommand.CMD_SET_CAL:
                    return "Set Heading";
                case SpheroCommand.CMD_SET_CFG_BLOCK:
                    return "Set Config Block";
                case SpheroCommand.CMD_SET_CHASSIS_ID:
                    return "Set Chassis ID";
                case SpheroCommand.CMD_SET_COLLISION_DET:
                    return "Set Collision Detection";
                case SpheroCommand.CMD_SET_CREATION_DATE:
                    return "Set Creation Date";
                case SpheroCommand.CMD_SET_DATA_STREAMING:
                    return "Set Data Streaming";
                case SpheroCommand.CMD_SET_DEVICE_MODE:
                    return "Set Device Mode";
                case SpheroCommand.CMD_SET_MACRO_PARAM:
                    return "Set Macro Parameters";
                case SpheroCommand.CMD_SET_MOTION_TO:
                    return "Set Motion To";
                case SpheroCommand.CMD_SET_OPTIONS_FLAG:
                    return "Set Options";
                case SpheroCommand.CMD_SET_RAW_MOTORS:
                    return "Set Raw Motors";
                case SpheroCommand.CMD_SET_RGB_LED:
                    return "Set RGB LED";
                case SpheroCommand.CMD_SET_ROTATION_RATE:
                    return "Set Rotation Rate";
                case SpheroCommand.CMD_SET_SSB:
                    return "Set SSB";
                case SpheroCommand.CMD_SET_SSB_PARAMS:
                    return "Set SSB Params";
                case SpheroCommand.CMD_SET_STABILIZ:
                    return "Set Stabilization";
                case SpheroCommand.CMD_SET_TEMP_OPTIONS_FLAG:
                    return "Set Temp Options";
                case SpheroCommand.CMD_SET_VDL:
                    return "Set VDL";
                case SpheroCommand.CMD_SSB_ADD_XP:
                    return "SSB Add XP";
                case SpheroCommand.CMD_SSB_BUY:
                    return "SSB Buy";
                case SpheroCommand.CMD_SSB_ENABLE_ASYNC:
                    return "SSB Enable Async";
                case SpheroCommand.CMD_SSB_GRANT_CORES:
                    return "SSB Grant Cores";
                case SpheroCommand.CMD_SSB_LEVEL_UP_ATTR:
                    return "SSB Level Up Attribute";
                case SpheroCommand.CMD_SSB_REFILL:
                    return "SSB Refill";
                case SpheroCommand.CMD_SSB_USE_CONSUMEABLE:
                    return "SSB Use Consumable";
                default:
                    return "Unknown Code";
            }
        }

        public static string FullName(this CoreCommand code)
        {
            switch (code)
            {
                case CoreCommand.CMD_ASSIGN_TIME:
                    return "Assign Time";
                case CoreCommand.CMD_CLEAR_COUNTERS:
                    return "Clear Counters";
                case CoreCommand.CMD_CONTROL_UART_TX:
                    return "Control UART TX";
                case CoreCommand.CMD_GET_AUTO_RECONNECT:
                    return "Get Auto Reconnect";
                case CoreCommand.CMD_GET_BT_NAME:
                    return "Get BT Name";
                case CoreCommand.CMD_GET_PWR_STATE:
                    return "Get Power State";
                case CoreCommand.CMD_GOTO_BL:
                    return "Goto BL";
                case CoreCommand.CMD_PING:
                    return "Ping";
                case CoreCommand.CMD_POLL_TIMES:
                    return "Poll Times";
                case CoreCommand.CMD_RUN_L1_DIAGS:
                    return "Run L1 Diagnostics";
                case CoreCommand.CMD_RUN_L2_DIAGS:
                    return "Run L2 Diagnostics";
                case CoreCommand.CMD_SET_AUTO_RECONNECT:
                    return "Set Auto Reconnect";
                case CoreCommand.CMD_SET_BT_NAME:
                    return "Set By Name";
                case CoreCommand.CMD_SET_PWR_NOTIFY:
                    return "Set Power Notify";
                case CoreCommand.CMD_SLEEP:
                    return "Sleep";
                case CoreCommand.CMD_VERSION:
                    return "Version";
                case CoreCommand.GET_POWER_TRIPS:
                    return "Get Power Trips";
                case CoreCommand.SET_INACTIVE_TIMER:
                    return "Set Inactive Timer";
                case CoreCommand.SET_POWER_TRIPS:
                    return "Set Power Trips";
                default:
                    return "Unknown Code";
            }
        }
    }
}
