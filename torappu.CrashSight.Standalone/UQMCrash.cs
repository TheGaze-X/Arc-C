using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCloud.UQM
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public static class UQMCrash
	{
		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x55A1180", Offset = "0x559FD80", VA = "0x1855A1180")]
		[PreserveSig]
		private static extern void CS_InitContext(string id, string version, string key);

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x55A1550", Offset = "0x55A0150", VA = "0x1855A1550")]
		[PreserveSig]
		private static extern void CS_ReportExceptionW(int type, string name, string message, string stack_trace, string extras, bool is_async, string attachmentPath = "");

		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x55A1C50", Offset = "0x55A0850", VA = "0x1855A1C50")]
		[PreserveSig]
		private static extern void CS_SetUserValue(string key, string value);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x55A1D00", Offset = "0x55A0900", VA = "0x1855A1D00")]
		[PreserveSig]
		private static extern void CS_SetVehEnable(bool enable);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x55A1B40", Offset = "0x55A0740", VA = "0x1855A1B40")]
		[PreserveSig]
		private static extern void CS_SetExtraHandler(bool extra_handle_enable);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x55A1820", Offset = "0x55A0420", VA = "0x1855A1820")]
		[PreserveSig]
		private static extern void CS_SetCustomLogDirW(string log_path);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x55A1BC0", Offset = "0x55A07C0", VA = "0x1855A1BC0")]
		[PreserveSig]
		private static extern void CS_SetUserId(string user_id);

		// Token: 0x06000087 RID: 135
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x55A12E0", Offset = "0x559FEE0", VA = "0x1855A12E0")]
		[PreserveSig]
		private static extern void CS_MonitorEnable(bool enable);

		// Token: 0x06000088 RID: 136
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x55A1360", Offset = "0x559FF60", VA = "0x1855A1360")]
		[PreserveSig]
		private static extern void CS_PrintLog(int level, string tag, string format, string arg);

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x55A1F10", Offset = "0x55A0B10", VA = "0x1855A1F10")]
		[PreserveSig]
		private static extern void CS_UploadGivenPathDump(string dump_dir, bool is_extra_check);

		// Token: 0x0600008A RID: 138
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x55A1440", Offset = "0x55A0040", VA = "0x1855A1440")]
		[PreserveSig]
		private static extern void CS_ReportCrash();

		// Token: 0x0600008B RID: 139
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x55A14B0", Offset = "0x55A00B0", VA = "0x1855A14B0")]
		[PreserveSig]
		private static extern void CS_ReportDump(string dump_dir, bool is_async);

		// Token: 0x0600008C RID: 140
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x55A1AB0", Offset = "0x55A06B0", VA = "0x1855A1AB0")]
		[PreserveSig]
		private static extern void CS_SetEnvironmentName(string name);

		// Token: 0x0600008D RID: 141
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x55A1250", Offset = "0x559FE50", VA = "0x1855A1250")]
		[PreserveSig]
		private static extern void CS_InitWithAppId(string app_id);

		// Token: 0x0600008E RID: 142
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x55A1680", Offset = "0x55A0280", VA = "0x1855A1680")]
		[PreserveSig]
		private static extern void CS_SetAppVersion(string app_version);

		// Token: 0x0600008F RID: 143
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x55A1070", Offset = "0x559FC70", VA = "0x1855A1070")]
		[PreserveSig]
		private static extern void CS_ConfigCrashServerUrl(string crash_server_url);

		// Token: 0x06000090 RID: 144
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x55A1100", Offset = "0x559FD00", VA = "0x1855A1100")]
		[PreserveSig]
		private static extern void CS_ConfigDebugMode(bool enable);

		// Token: 0x06000091 RID: 145
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x55A18B0", Offset = "0x55A04B0", VA = "0x1855A18B0")]
		[PreserveSig]
		private static extern void CS_SetDeviceId(string device_id);

		// Token: 0x06000092 RID: 146
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x55A0FF0", Offset = "0x559FBF0", VA = "0x1855A0FF0")]
		[PreserveSig]
		private static extern void CS_ConfigCrashReporter(int log_level);

		// Token: 0x06000093 RID: 147
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x55A1E10", Offset = "0x55A0A10", VA = "0x1855A1E10")]
		[PreserveSig]
		private static extern void CS_TestNativeCrash();

		// Token: 0x06000094 RID: 148
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x55A1940", Offset = "0x55A0540", VA = "0x1855A1940")]
		[PreserveSig]
		private static extern void CS_SetDumpType(int dump_type);

		// Token: 0x06000095 RID: 149
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x55A0F70", Offset = "0x559FB70", VA = "0x1855A0F70")]
		[PreserveSig]
		private static extern void CS_AddValidExpCode(ulong exp_code);

		// Token: 0x06000096 RID: 150
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x55A1E80", Offset = "0x55A0A80", VA = "0x1855A1E80")]
		[PreserveSig]
		private static extern void CS_UploadCrashWithGuid(string guid);

		// Token: 0x06000097 RID: 151
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x55A1710", Offset = "0x55A0310", VA = "0x1855A1710")]
		[PreserveSig]
		private static extern void CS_SetCrashUploadEnable(bool enable);

		// Token: 0x06000098 RID: 152
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x55A1D80", Offset = "0x55A0980", VA = "0x1855A1D80")]
		[PreserveSig]
		private static extern void CS_SetWorkSpaceW(string workspace);

		// Token: 0x06000099 RID: 153
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x55A19C0", Offset = "0x55A05C0", VA = "0x1855A19C0")]
		[PreserveSig]
		private static extern void CS_SetEngineInfo(string version, string buildConfig, string language, string locale);

		// Token: 0x0600009A RID: 154
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x55A1790", Offset = "0x55A0390", VA = "0x1855A1790")]
		[PreserveSig]
		private static extern void CS_SetCustomAttachDirW(string log_path);

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event OnUQMStringRetEventHandler<int> CrashBaseRetEvent
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x55A9530", Offset = "0x55A8130", VA = "0x1855A9530")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x55A9AB0", Offset = "0x55A86B0", VA = "0x1855A9AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event OnUQMStringRetSetLogPathEventHandler<int> CrashSetLogPathRetEvent
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x55A9750", Offset = "0x55A8350", VA = "0x1855A9750")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x55A9CD0", Offset = "0x55A88D0", VA = "0x1855A9CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public static event OnUQMRetLogUploadEventHandler<int> CrashLogUploadRetEvent
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x55A9640", Offset = "0x55A8240", VA = "0x1855A9640")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x55A9BC0", Offset = "0x55A87C0", VA = "0x1855A9BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x17000003")]
		public static AndroidJavaClass CrashSightPlatform
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x55A99A0", Offset = "0x55A85A0", VA = "0x1855A99A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void LoadCrashSightCoreSo()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x55A26B0", Offset = "0x55A12B0", VA = "0x1855A26B0")]
		public static void ConfigCallbackType(int callbackType)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x55A3050", Offset = "0x55A1C50", VA = "0x1855A3050")]
		public static void ConfigGameType(int gameType)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x55A2490", Offset = "0x55A1090", VA = "0x1855A2490")]
		public static void ConfigAutoReportLogLevel(int level)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x55A2800", Offset = "0x55A1400", VA = "0x1855A2800")]
		public static void ConfigCrashServerUrl(string serverUrl)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x55A29C0", Offset = "0x55A15C0", VA = "0x1855A29C0")]
		public static void ConfigDebugMode(bool enable)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x55A2C10", Offset = "0x55A1810", VA = "0x1855A2C10")]
		public static void ConfigDefault(string channel, string version, string user, long delay)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x55A3A80", Offset = "0x55A2680", VA = "0x1855A3A80")]
		public static void InitWithAppId(string appId)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x55A3820", Offset = "0x55A2420", VA = "0x1855A3820")]
		public static void InitContext(string userId, string version, string key)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x55A40E0", Offset = "0x55A2CE0", VA = "0x1855A40E0")]
		public static void LogRecord(int level, string message)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x55A0BC0", Offset = "0x559F7C0", VA = "0x1855A0BC0")]
		public static void AddSceneData(string k, string v)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x55A53C0", Offset = "0x55A3FC0", VA = "0x1855A53C0")]
		public static void ReportException(int type, string name, string message, string stackTrace, string extras, bool quitProgram)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x55A5120", Offset = "0x55A3D20", VA = "0x1855A5120")]
		public static void ReportException(int type, string exceptionName, string exceptionMsg, string exceptionStack, Dictionary<string, string> extInfo, int dumpNativeType = 0, string errorAttachmentPath = "")
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x55A77C0", Offset = "0x55A63C0", VA = "0x1855A77C0")]
		public static void SetUserId(string userId)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x55A7470", Offset = "0x55A6070", VA = "0x1855A7470")]
		public static void SetScene(string sceneId, bool upload)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x55A4C40", Offset = "0x55A3840", VA = "0x1855A4C40")]
		public static void ReRegistAllMonitors()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x55A2360", Offset = "0x55A0F60", VA = "0x1855A2360")]
		public static void CloseAllMonitors()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x55A55A0", Offset = "0x55A41A0", VA = "0x1855A55A0")]
		public static void ReportLogInfo(string msgType, string msg)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x55A56D0", Offset = "0x55A42D0", VA = "0x1855A56D0")]
		public static void SetAppVersion(string appVersion)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x55A6110", Offset = "0x55A4D10", VA = "0x1855A6110")]
		public static void SetDeviceId(string deviceId)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x55A5E90", Offset = "0x55A4A90", VA = "0x1855A5E90")]
		public static void SetCustomizedDeviceID(string deviceId)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x55A35A0", Offset = "0x55A21A0", VA = "0x1855A35A0")]
		public static string GetSDKDefinedDeviceID()
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x55A5FD0", Offset = "0x55A4BD0", VA = "0x1855A5FD0")]
		public static void SetCustomizedMatchID(string matchId)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x55A36E0", Offset = "0x55A22E0", VA = "0x1855A36E0")]
		public static string GetSDKSessionID()
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x55A3320", Offset = "0x55A1F20", VA = "0x1855A3320")]
		public static string GetCrashUuid()
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x55A62D0", Offset = "0x55A4ED0", VA = "0x1855A62D0")]
		public static void SetDeviceModel(string deviceModel)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x55A6F30", Offset = "0x55A5B30", VA = "0x1855A6F30")]
		public static void SetLogPath(string logPath)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x55A59D0", Offset = "0x55A45D0", VA = "0x1855A59D0")]
		public static void SetCrashCallback()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x55A8F80", Offset = "0x55A7B80", VA = "0x1855A8F80")]
		public static void UnsetCrashCallback()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x55A5AE0", Offset = "0x55A46E0", VA = "0x1855A5AE0")]
		public static void SetCrashLogCallback()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x55A4500", Offset = "0x55A3100", VA = "0x1855A4500")]
		internal static string OnCrashCallbackMessage(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x55A4330", Offset = "0x55A2F30", VA = "0x1855A4330")]
		internal static string OnCrashCallbackData(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x55A4A70", Offset = "0x55A3670", VA = "0x1855A4A70")]
		internal static string OnCrashSetLogPathMessage(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x55A48A0", Offset = "0x55A34A0", VA = "0x1855A48A0")]
		internal static string OnCrashLogUploadMessage(int methodId, int crashType, int result)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x55A46D0", Offset = "0x55A32D0", VA = "0x1855A46D0")]
		internal static string OnCrashCallbackNoRet(int methodId, int crashType)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x55A2650", Offset = "0x55A1250", VA = "0x1855A2650")]
		public static void ConfigCallBack()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x55A8ED0", Offset = "0x55A7AD0", VA = "0x1855A8ED0")]
		public static void UnregisterCallBack()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x55A31B0", Offset = "0x55A1DB0", VA = "0x1855A31B0")]
		public static void ConfigLogCallBack()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x55A8C70", Offset = "0x55A7870", VA = "0x1855A8C70")]
		public static void TestOomCrash()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x55A8880", Offset = "0x55A7480", VA = "0x1855A8880")]
		public static void TestJavaCrash()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x55A8B40", Offset = "0x55A7740", VA = "0x1855A8B40")]
		public static void TestOcCrash()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x55A89B0", Offset = "0x55A75B0", VA = "0x1855A89B0")]
		public static void TestNativeCrash()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x55A8750", Offset = "0x55A7350", VA = "0x1855A8750")]
		public static void TestANR()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x55A3210", Offset = "0x55A1E10", VA = "0x1855A3210")]
		public static long GetCrashThreadId()
		{
			return 0L;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x55A70E0", Offset = "0x55A5CE0", VA = "0x1855A70E0")]
		public static void SetLogcatBufferSize(int size)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x55A5890", Offset = "0x55A4490", VA = "0x1855A5890")]
		public static void SetCallbackMsg(string data)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x55A7D10", Offset = "0x55A6910", VA = "0x1855A7D10")]
		public static void StartDumpRoutine(int dumpMode, int startTimeMode, long startTime, long dumpInterval, int dumpTimes, bool saveLocal, string savePath)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x55A83C0", Offset = "0x55A6FC0", VA = "0x1855A83C0")]
		public static void StartMonitorFdCount(int interval, int limit, int dumpType)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x55A9860", Offset = "0x55A8460", VA = "0x1855A9860")]
		public static int getExceptionType(string name)
		{
			return 0;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x55A8DA0", Offset = "0x55A79A0", VA = "0x1855A8DA0")]
		public static void TestUseAfterFree()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x55A7600", Offset = "0x55A6200", VA = "0x1855A7600")]
		public static void SetServerEnv(string serverEnv)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x55A7980", Offset = "0x55A6580", VA = "0x1855A7980")]
		public static void SetVehEnable(bool enable)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x55A4D70", Offset = "0x55A3970", VA = "0x1855A4D70")]
		public static void ReportCrash()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x55A4F00", Offset = "0x55A3B00", VA = "0x1855A4F00")]
		public static void ReportDump(string dump_path, bool is_async)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x55A6D50", Offset = "0x55A5950", VA = "0x1855A6D50")]
		public static void SetExtraHandler(bool extra_handle_enable)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x55A9250", Offset = "0x55A7E50", VA = "0x1855A9250")]
		public static void UploadGivenPathDump(string dump_dir, bool is_extra_check)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x55A6C20", Offset = "0x55A5820", VA = "0x1855A6C20")]
		public static void SetErrorUploadInterval(int interval)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x55A6AD0", Offset = "0x55A56D0", VA = "0x1855A6AD0")]
		public static void SetErrorUploadEnable(bool enable)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x55A7350", Offset = "0x55A5F50", VA = "0x1855A7350")]
		public static void SetRecordFileDir(string record_dir)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x55A3C80", Offset = "0x55A2880", VA = "0x1855A3C80")]
		public static void Init(string app_id, string app_key, string app_version)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x55A9DE0", Offset = "0x55A89E0", VA = "0x1855A9DE0")]
		public static void setEnableGetPackageInfo(bool enable)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x55A6410", Offset = "0x55A5010", VA = "0x1855A6410")]
		public static void SetDumpType(int dump_type)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x55A0DB0", Offset = "0x559F9B0", VA = "0x1855A0DB0")]
		public static void AddValidExpCode(ulong exp_code)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x55A9090", Offset = "0x55A7C90", VA = "0x1855A9090")]
		public static void UploadCrashWithGuid(string guid)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x55A5BF0", Offset = "0x55A47F0", VA = "0x1855A5BF0")]
		public static void SetCrashUploadEnable(bool enable)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x55A7B60", Offset = "0x55A6760", VA = "0x1855A7B60")]
		public static void SetWorkSpace(string workspace)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x55A65D0", Offset = "0x55A51D0", VA = "0x1855A65D0")]
		public static void SetEngineInfo(string version, string buildConfig, string language, string locale)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x55A5DD0", Offset = "0x55A49D0", VA = "0x1855A5DD0")]
		public static void SetCustomAttachDir(string path)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x55A3FD0", Offset = "0x55A2BD0", VA = "0x1855A3FD0")]
		public static bool IsLastSessionCrash()
		{
			return default(bool);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x55A3460", Offset = "0x55A2060", VA = "0x1855A3460")]
		public static string GetLastSessionUserId()
		{
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x55A1FB0", Offset = "0x55A0BB0", VA = "0x1855A1FB0")]
		public static bool CheckFdCount(int limit, int dumpType, bool upload)
		{
			return default(bool);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x55A7210", Offset = "0x55A5E10", VA = "0x1855A7210")]
		public static void SetOomLogPath(string logPath)
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaClass _gameAgentClass;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _isLoadedSo;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int _gameType;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly string GAME_AGENT_CLASS;
	}
}
