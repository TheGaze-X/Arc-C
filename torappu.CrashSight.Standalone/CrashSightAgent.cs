using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public sealed class CrashSightAgent
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5599F10", Offset = "0x5598B10", VA = "0x185599F10")]
	public static void SetLogFilter(CrashSightAgent.LogFilterDelegate filter)
	{
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	private static event CrashSightAgent.LogCallbackDelegate _LogCallbackEventHandler
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x559E110", Offset = "0x559CD10", VA = "0x18559E110")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x559E480", Offset = "0x559D080", VA = "0x18559E480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x5598230", Offset = "0x5596E30", VA = "0x185598230")]
	public static void InitWithAppId(string appId)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x55995C0", Offset = "0x55981C0", VA = "0x1855995C0")]
	public static void ReportException(Exception e, string message)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x55992A0", Offset = "0x5597EA0", VA = "0x1855992A0")]
	public static void ReportException(string name, string message, string stackTrace)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x55994B0", Offset = "0x55980B0", VA = "0x1855994B0")]
	public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0, string errorAttachmentPath = "")
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x559A3A0", Offset = "0x5598FA0", VA = "0x18559A3A0")]
	public static void SetUserId(string userId)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x55970D0", Offset = "0x5595CD0", VA = "0x1855970D0")]
	public static void AddSceneData(string key, string value)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x559A510", Offset = "0x5599110", VA = "0x18559A510")]
	public static void SetUserValue(string key, int value)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x559A660", Offset = "0x5599260", VA = "0x18559A660")]
	public static void SetUserValue(string key, string value)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x559A5C0", Offset = "0x55991C0", VA = "0x18559A5C0")]
	public static void SetUserValue(string key, string[] value)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x55997C0", Offset = "0x55983C0", VA = "0x1855997C0")]
	public static void SetAppVersion(string appVersion)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x55975C0", Offset = "0x55961C0", VA = "0x1855975C0")]
	public static void ConfigCrashServerUrl(string crashServerUrl)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x5599F80", Offset = "0x5598B80", VA = "0x185599F80")]
	public static void SetLogPath(string logPath)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x55976D0", Offset = "0x55962D0", VA = "0x1855976D0")]
	public static void ConfigDebugMode(bool enable)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x5599AB0", Offset = "0x55986B0", VA = "0x185599AB0")]
	public static void SetDeviceId(string deviceId)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x5597570", Offset = "0x5596170", VA = "0x185597570")]
	public static void ConfigCrashReporter(int logLevel)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x5597520", Offset = "0x5596120", VA = "0x185597520")]
	public static void ConfigCrashReporter(CSLogSeverity logLevel)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x5598840", Offset = "0x5597440", VA = "0x185598840")]
	public static void PrintLog(CSLogSeverity level, string format, params object[] args)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x559ADA0", Offset = "0x55999A0", VA = "0x18559ADA0")]
	public static void TestNativeCrash()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x5599BA0", Offset = "0x55987A0", VA = "0x185599BA0")]
	public static void SetEnvironmentName(string serverEnv)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x55989A0", Offset = "0x55975A0", VA = "0x1855989A0")]
	public static void RegisterCrashCallback(CrashSightCallback callback)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x559B1E0", Offset = "0x5599DE0", VA = "0x18559B1E0")]
	public static void UnregisterCrashCallback()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x5598BF0", Offset = "0x55977F0", VA = "0x185598BF0")]
	public static void RegisterCrashLogCallback(CrashSightLogCallback callback)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x5597B60", Offset = "0x5596760", VA = "0x185597B60")]
	public static void EnableExceptionHandler()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x5598F80", Offset = "0x5597B80", VA = "0x185598F80")]
	public static void RegisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x559B2C0", Offset = "0x5599EC0", VA = "0x18559B2C0")]
	public static void UnregisterLogCallback(CrashSightAgent.LogCallbackDelegate handler)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x5599E00", Offset = "0x5598A00", VA = "0x185599E00")]
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x5597470", Offset = "0x5596070", VA = "0x185597470")]
	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000001")]
	public static bool AutoQuitApplicationAfterReport
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x559E2D0", Offset = "0x559CED0", VA = "0x18559E2D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x5597A80", Offset = "0x5596680", VA = "0x185597A80")]
	public static void DebugLog(string tag, string format, params object[] args)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000021 RID: 33 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x17000002")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x559E320", Offset = "0x559CF20", VA = "0x18559E320")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x559CEC0", Offset = "0x559BAC0", VA = "0x18559CEC0")]
	public static void _RegisterExceptionHandler()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x559D1E0", Offset = "0x559BDE0", VA = "0x18559D1E0")]
	public static void _UnregisterExceptionHandler()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public static void SetCrashSightStackTraceEnable(bool enable)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x55974D0", Offset = "0x55960D0", VA = "0x1855974D0")]
	public static void ConfigCallbackType(int callbackType)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x5599B00", Offset = "0x5598700", VA = "0x185599B00")]
	public static void SetDeviceModel(string deviceModel)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x5599760", Offset = "0x5598360", VA = "0x185599760")]
	public static void ReportLogInfo(string msgType, string msg)
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x559A120", Offset = "0x5598D20", VA = "0x18559A120")]
	public static void SetScene(string sceneId, bool upload = false)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x559A320", Offset = "0x5598F20", VA = "0x18559A320")]
	public static void SetScene(int sceneId)
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x5597C90", Offset = "0x5596890", VA = "0x185597C90")]
	public static long GetCrashThreadId()
	{
		return 0L;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x5599A10", Offset = "0x5598610", VA = "0x185599A10")]
	public static void SetCustomizedDeviceID(string deviceId)
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x5597F00", Offset = "0x5596B00", VA = "0x185597F00")]
	public static string GetSDKDefinedDeviceID()
	{
		return null;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x5599A60", Offset = "0x5598660", VA = "0x185599A60")]
	public static void SetCustomizedMatchID(string matchId)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x5597F40", Offset = "0x5596B40", VA = "0x185597F40")]
	public static string GetSDKSessionID()
	{
		return null;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x559AFC0", Offset = "0x5599BC0", VA = "0x18559AFC0")]
	public static void TestOomCrash()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x559AC90", Offset = "0x5599890", VA = "0x18559AC90")]
	public static void TestJavaCrash()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x559AB80", Offset = "0x5599780", VA = "0x18559AB80")]
	public static void TestANR()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x5597DA0", Offset = "0x55969A0", VA = "0x185597DA0")]
	public static string GetCrashUuid()
	{
		return null;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x5599FD0", Offset = "0x5598BD0", VA = "0x185599FD0")]
	public static void SetLogcatBufferSize(int size)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x559AEB0", Offset = "0x5599AB0", VA = "0x18559AEB0")]
	public static void TestOcCrash()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x559A9B0", Offset = "0x55995B0", VA = "0x18559A9B0")]
	public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x559AAB0", Offset = "0x55996B0", VA = "0x18559AAB0")]
	public static void StartMonitorFdCount(int interval, int limit, int dumpType)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x559E210", Offset = "0x559CE10", VA = "0x18559E210")]
	public static int getExceptionType(string name)
	{
		return 0;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x559B0D0", Offset = "0x5599CD0", VA = "0x18559B0D0")]
	public static void TestUseAfterFree()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x55988F0", Offset = "0x55974F0", VA = "0x1855988F0")]
	public static void ReRegistAllMonitors()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x55973D0", Offset = "0x5595FD0", VA = "0x1855973D0")]
	public static void CloseAllMonitors()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x559E580", Offset = "0x559D180", VA = "0x18559E580")]
	public static void setEnableGetPackageInfo(bool enable)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x5598730", Offset = "0x5597330", VA = "0x185598730")]
	public static bool IsLastSessionCrash()
	{
		return default(bool);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x5597DE0", Offset = "0x55969E0", VA = "0x185597DE0")]
	public static string GetLastSessionUserId()
	{
		return null;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x55972F0", Offset = "0x5595EF0", VA = "0x1855972F0")]
	public static bool CheckFdCount(int limit, int dumpType, bool upload)
	{
		return default(bool);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x559A020", Offset = "0x5598C20", VA = "0x18559A020")]
	public static void SetOomLogPath(string logPath)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x559A6E0", Offset = "0x55992E0", VA = "0x18559A6E0")]
	public static void SetVehEnable(bool enable)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x5599140", Offset = "0x5597D40", VA = "0x185599140")]
	public static void ReportCrash()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x55991E0", Offset = "0x5597DE0", VA = "0x1855991E0")]
	public static void ReportDump(string dump_path, bool is_async)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x5599D50", Offset = "0x5598950", VA = "0x185599D50")]
	public static void SetExtraHandler(bool extra_handle_enable)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x559B480", Offset = "0x559A080", VA = "0x18559B480")]
	public static void UploadGivenPathDump(string dump_dir, bool is_extra_check)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x5599B50", Offset = "0x5598750", VA = "0x185599B50")]
	public static void SetDumpType(int dump_type)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x55972A0", Offset = "0x5595EA0", VA = "0x1855972A0")]
	public static void AddValidExpCode(ulong exp_code)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x559B430", Offset = "0x559A030", VA = "0x18559B430")]
	public static void UploadCrashWithGuid(string guid)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x55998D0", Offset = "0x55984D0", VA = "0x1855998D0")]
	public static void SetCrashUploadEnable(bool enable)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x559A790", Offset = "0x5599390", VA = "0x18559A790")]
	public static void SetWorkSpace(string workspace)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x5599920", Offset = "0x5598520", VA = "0x185599920")]
	public static void SetCustomAttachDir(string path)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x5599CA0", Offset = "0x55988A0", VA = "0x185599CA0")]
	public static void SetErrorUploadInterval(int interval)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x5599BF0", Offset = "0x55987F0", VA = "0x185599BF0")]
	public static void SetErrorUploadEnable(bool enable)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x559A070", Offset = "0x5598C70", VA = "0x18559A070")]
	public static void SetRecordFileDir(string record_dir)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x5597F80", Offset = "0x5596B80", VA = "0x185597F80")]
	public static void InitContext(string userId, string version, string key)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x5598470", Offset = "0x5597070", VA = "0x185598470")]
	public static void Init(string app_id, string app_key, string app_version)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x5597840", Offset = "0x5596440", VA = "0x185597840")]
	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x559C920", Offset = "0x559B520", VA = "0x18559C920")]
	private static void _OnLogCallbackHandlerMain(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x559C9A0", Offset = "0x559B5A0", VA = "0x18559C9A0")]
	private static void _OnLogCallbackHandlerThreaded(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x559CA20", Offset = "0x559B620", VA = "0x18559CA20")]
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type, CSReportType rType)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x559CD00", Offset = "0x559B900", VA = "0x18559CD00")]
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x559B540", Offset = "0x559A140", VA = "0x18559B540")]
	private static void _HandleException(Exception e, string message, bool uncaught)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x559A7E0", Offset = "0x55993E0", VA = "0x18559A7E0")]
	private static bool ShouldSkipFrame(string frame)
	{
		return default(bool);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x559D590", Offset = "0x559C190", VA = "0x18559D590")]
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x559E680", Offset = "0x559D280", VA = "0x18559E680")]
	private static int valueOf(LogType logLevel)
	{
		return 0;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x559E370", Offset = "0x559CF70", VA = "0x18559E370")]
	private static bool isEnableAutoReport(LogType logLevel)
	{
		return default(bool);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x559BC60", Offset = "0x559A860", VA = "0x18559BC60")]
	private static void _HandleException(LogType logLevel, string name, string message, string stackTrace, bool uncaught, CSReportType rType)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	public CrashSightAgent()
	{
	}

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x0")]
	private static string crashUploadUrl;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x8")]
	public static List<int> callbackThreads;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x10")]
	public static object callbackThreadsLock;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	private static CrashSightAgent.LogFilterDelegate s_logFilter;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	private static bool _isInitialized;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x2C")]
	private static LogType _autoReportLogLevel;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x30")]
	private static bool _debugMode;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x31")]
	private static bool _autoQuitApplicationAfterReport;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x38")]
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x40")]
	private static bool _uncaughtAutoReportOnce;

	// Token: 0x02000005 RID: 5
	// (Invoke) Token: 0x0600005E RID: 94
	[Token(Token = "0x2000005")]
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);

	// Token: 0x02000006 RID: 6
	// (Invoke) Token: 0x06000062 RID: 98
	[Token(Token = "0x2000006")]
	public delegate bool LogFilterDelegate(string condition, string stackTrace, LogType type);
}
