using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	internal static class NativeMethods
	{
		// Token: 0x060004B2 RID: 1202
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4F0C700", Offset = "0x4F0B300", VA = "0x184F0C700")]
		[PreserveSig]
		public static extern ESteamAPIInitResult SteamInternal_SteamAPI_Init(InteropHelp.UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg);

		// Token: 0x060004B3 RID: 1203
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4F097C0", Offset = "0x4F083C0", VA = "0x184F097C0")]
		[PreserveSig]
		public static extern void SteamAPI_Shutdown();

		// Token: 0x060004B4 RID: 1204
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4F09510", Offset = "0x4F08110", VA = "0x184F09510")]
		[PreserveSig]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		// Token: 0x060004B5 RID: 1205
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x4F094A0", Offset = "0x4F080A0", VA = "0x184F094A0")]
		[PreserveSig]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		// Token: 0x060004B6 RID: 1206
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4F0B7A0", Offset = "0x4F0A3A0", VA = "0x184F0B7A0")]
		[PreserveSig]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		// Token: 0x060004B7 RID: 1207
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4F09680", Offset = "0x4F08280", VA = "0x184F09680")]
		[PreserveSig]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		// Token: 0x060004B8 RID: 1208
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4F09590", Offset = "0x4F08190", VA = "0x184F09590")]
		[PreserveSig]
		public static extern void SteamAPI_RunCallbacks();

		// Token: 0x060004B9 RID: 1209
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4F09410", Offset = "0x4F08010", VA = "0x184F09410")]
		[PreserveSig]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		// Token: 0x060004BA RID: 1210
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x4F0B560", Offset = "0x4F0A160", VA = "0x184F0B560")]
		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		// Token: 0x060004BB RID: 1211
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x4F09380", Offset = "0x4F07F80", VA = "0x184F09380")]
		[PreserveSig]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x060004BC RID: 1212
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x4F0B4D0", Offset = "0x4F0A0D0", VA = "0x184F0B4D0")]
		[PreserveSig]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		// Token: 0x060004BD RID: 1213
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x4F09030", Offset = "0x4F07C30", VA = "0x184F09030")]
		[PreserveSig]
		public static extern bool SteamAPI_IsSteamRunning();

		// Token: 0x060004BE RID: 1214
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x4F08FC0", Offset = "0x4F07BC0", VA = "0x184F08FC0")]
		[PreserveSig]
		public static extern int SteamAPI_GetSteamInstallPath();

		// Token: 0x060004BF RID: 1215
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x4F08EE0", Offset = "0x4F07AE0", VA = "0x184F08EE0")]
		[PreserveSig]
		public static extern int SteamAPI_GetHSteamPipe();

		// Token: 0x060004C0 RID: 1216
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x4F09740", Offset = "0x4F08340", VA = "0x184F09740")]
		[PreserveSig]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		// Token: 0x060004C1 RID: 1217
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x4F08F50", Offset = "0x4F07B50", VA = "0x184F08F50")]
		[PreserveSig]
		public static extern int SteamAPI_GetHSteamUser();

		// Token: 0x060004C2 RID: 1218
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x4F0C280", Offset = "0x4F0AE80", VA = "0x184F0C280")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		// Token: 0x060004C3 RID: 1219
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x4F0C300", Offset = "0x4F0AF00", VA = "0x184F0C300")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		// Token: 0x060004C4 RID: 1220
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4F0C4A0", Offset = "0x4F0B0A0", VA = "0x184F0C4A0")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		// Token: 0x060004C5 RID: 1221
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4F0C3D0", Offset = "0x4F0AFD0", VA = "0x184F0C3D0")]
		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		// Token: 0x060004C6 RID: 1222
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4F0B5E0", Offset = "0x4F0A1E0", VA = "0x184F0B5E0")]
		[PreserveSig]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		// Token: 0x060004C7 RID: 1223
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x4F09600", Offset = "0x4F08200", VA = "0x184F09600")]
		[PreserveSig]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		// Token: 0x060004C8 RID: 1224
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4F09290", Offset = "0x4F07E90", VA = "0x184F09290")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_Init();

		// Token: 0x060004C9 RID: 1225
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4F09300", Offset = "0x4F07F00", VA = "0x184F09300")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

		// Token: 0x060004CA RID: 1226
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4F09200", Offset = "0x4F07E00", VA = "0x184F09200")]
		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg);

		// Token: 0x060004CB RID: 1227
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4F090A0", Offset = "0x4F07CA0", VA = "0x184F090A0")]
		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

		// Token: 0x060004CC RID: 1228
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4F09120", Offset = "0x4F07D20", VA = "0x184F09120")]
		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		// Token: 0x060004CD RID: 1229
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4F0C210", Offset = "0x4F0AE10", VA = "0x184F0C210")]
		[PreserveSig]
		public static extern void SteamGameServer_Shutdown();

		// Token: 0x060004CE RID: 1230
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4F0C1A0", Offset = "0x4F0ADA0", VA = "0x184F0C1A0")]
		[PreserveSig]
		public static extern void SteamGameServer_RunCallbacks();

		// Token: 0x060004CF RID: 1231
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4EDE430", Offset = "0x4EDD030", VA = "0x184EDE430")]
		[PreserveSig]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		// Token: 0x060004D0 RID: 1232
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x4EDDC50", Offset = "0x4EDC850", VA = "0x184EDDC50")]
		[PreserveSig]
		public static extern bool SteamGameServer_BSecure();

		// Token: 0x060004D1 RID: 1233
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4F0C130", Offset = "0x4F0AD30", VA = "0x184F0C130")]
		[PreserveSig]
		public static extern ulong SteamGameServer_GetSteamID();

		// Token: 0x060004D2 RID: 1234
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4F0C050", Offset = "0x4F0AC50", VA = "0x184F0C050")]
		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamPipe();

		// Token: 0x060004D3 RID: 1235
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x4F0C0C0", Offset = "0x4F0ACC0", VA = "0x184F0C0C0")]
		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamUser();

		// Token: 0x060004D4 RID: 1236
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x4F0C570", Offset = "0x4F0B170", VA = "0x184F0C570")]
		[PreserveSig]
		public static extern ESteamAPIInitResult SteamInternal_GameServer_Init_V2(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString, InteropHelp.UTF8StringHandle pszInternalCheckInterfaceVersions, IntPtr pOutErrMsg);

		// Token: 0x060004D5 RID: 1237
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x4F0B840", Offset = "0x4F0A440", VA = "0x184F0B840")]
		[PreserveSig]
		public static extern IntPtr SteamClient();

		// Token: 0x060004D6 RID: 1238
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x4F0BFE0", Offset = "0x4F0ABE0", VA = "0x184F0BFE0")]
		[PreserveSig]
		public static extern IntPtr SteamGameServerClient();

		// Token: 0x060004D7 RID: 1239
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x4F09830", Offset = "0x4F08430", VA = "0x184F09830")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self);

		// Token: 0x060004D8 RID: 1240
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x4F09DB0", Offset = "0x4F089B0", VA = "0x184F09DB0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self);

		// Token: 0x060004D9 RID: 1241
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x4F0A290", Offset = "0x4F08E90", VA = "0x184F0A290")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, [In] [Out] byte[] ipv6, ushort nPort);

		// Token: 0x060004DA RID: 1242
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x4F0A0C0", Offset = "0x4F08CC0", VA = "0x184F0A0C0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort);

		// Token: 0x060004DB RID: 1243
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x4F09CD0", Offset = "0x4F088D0", VA = "0x184F09CD0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self);

		// Token: 0x060004DC RID: 1244
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x4F099E0", Offset = "0x4F085E0", VA = "0x184F099E0")]
		[PreserveSig]
		public static extern uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self);

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x4F0A1B0", Offset = "0x4F08DB0", VA = "0x184F0A1B0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort);

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x4F09E90", Offset = "0x4F08A90", VA = "0x184F09E90")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self);

		// Token: 0x060004DF RID: 1247
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x4F0A380", Offset = "0x4F08F80", VA = "0x184F0A380")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort);

		// Token: 0x060004E0 RID: 1248
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x4F09F70", Offset = "0x4F08B70", VA = "0x184F09F70")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x060004E1 RID: 1249
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4F09AC0", Offset = "0x4F086C0", VA = "0x184F09AC0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x);

		// Token: 0x060004E2 RID: 1250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4F09900", Offset = "0x4F08500", VA = "0x184F09900")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr self);

		// Token: 0x060004E3 RID: 1251
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4F09BF0", Offset = "0x4F087F0", VA = "0x184F09BF0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIPAddr_IsFakeIP(ref SteamNetworkingIPAddr self);

		// Token: 0x060004E4 RID: 1252
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4F0A480", Offset = "0x4F09080", VA = "0x184F0A480")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self);

		// Token: 0x060004E5 RID: 1253
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4F0AB20", Offset = "0x4F09720", VA = "0x184F0AB20")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self);

		// Token: 0x060004E6 RID: 1254
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4F0B240", Offset = "0x4F09E40", VA = "0x184F0B240")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID);

		// Token: 0x060004E7 RID: 1255
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4F0A910", Offset = "0x4F09510", VA = "0x184F0A910")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self);

		// Token: 0x060004E8 RID: 1256
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4F0B1B0", Offset = "0x4F09DB0", VA = "0x184F0B1B0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID);

		// Token: 0x060004E9 RID: 1257
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4F0A890", Offset = "0x4F09490", VA = "0x184F0A890")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self);

		// Token: 0x060004EA RID: 1258
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4F0B2D0", Offset = "0x4F09ED0", VA = "0x184F0B2D0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		// Token: 0x060004EB RID: 1259
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4F0A990", Offset = "0x4F09590", VA = "0x184F0A990")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self);

		// Token: 0x060004EC RID: 1260
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4F0B090", Offset = "0x4F09C90", VA = "0x184F0B090")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetPSNID(ref SteamNetworkingIdentity self, ulong id);

		// Token: 0x060004ED RID: 1261
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4F0A790", Offset = "0x4F09390", VA = "0x184F0A790")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetPSNID(ref SteamNetworkingIdentity self);

		// Token: 0x060004EE RID: 1262
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4F0B120", Offset = "0x4F09D20", VA = "0x184F0B120")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetStadiaID(ref SteamNetworkingIdentity self, ulong id);

		// Token: 0x060004EF RID: 1263
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x4F0A810", Offset = "0x4F09410", VA = "0x184F0A810")]
		[PreserveSig]
		public static extern ulong SteamAPI_SteamNetworkingIdentity_GetStadiaID(ref SteamNetworkingIdentity self);

		// Token: 0x060004F0 RID: 1264
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x4F0AE90", Offset = "0x4F09A90", VA = "0x184F0AE90")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr);

		// Token: 0x060004F1 RID: 1265
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4F0A690", Offset = "0x4F09290", VA = "0x184F0A690")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self);

		// Token: 0x060004F2 RID: 1266
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4F0AF70", Offset = "0x4F09B70", VA = "0x184F0AF70")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetIPv4Addr(ref SteamNetworkingIdentity self, uint nIPv4, ushort nPort);

		// Token: 0x060004F3 RID: 1267
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4F0A710", Offset = "0x4F09310", VA = "0x184F0A710")]
		[PreserveSig]
		public static extern uint SteamAPI_SteamNetworkingIdentity_GetIPv4(ref SteamNetworkingIdentity self);

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4F0A500", Offset = "0x4F09100", VA = "0x184F0A500")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType SteamAPI_SteamNetworkingIdentity_GetFakeIPType(ref SteamNetworkingIdentity self);

		// Token: 0x060004F5 RID: 1269
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4F0AAA0", Offset = "0x4F096A0", VA = "0x184F0AAA0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsFakeIP(ref SteamNetworkingIdentity self);

		// Token: 0x060004F6 RID: 1270
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x4F0B010", Offset = "0x4F09C10", VA = "0x184F0B010")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self);

		// Token: 0x060004F7 RID: 1271
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4F0ABA0", Offset = "0x4F097A0", VA = "0x184F0ABA0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self);

		// Token: 0x060004F8 RID: 1272
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4F0ADB0", Offset = "0x4F099B0", VA = "0x184F0ADB0")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszString);

		// Token: 0x060004F9 RID: 1273
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4F0A610", Offset = "0x4F09210", VA = "0x184F0A610")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self);

		// Token: 0x060004FA RID: 1274
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4F0AD00", Offset = "0x4F09900", VA = "0x184F0AD00")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, [In] [Out] byte[] data, uint cbLen);

		// Token: 0x060004FB RID: 1275
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x4F0A580", Offset = "0x4F09180", VA = "0x184F0A580")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen);

		// Token: 0x060004FC RID: 1276
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4F0AA10", Offset = "0x4F09610", VA = "0x184F0AA10")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x);

		// Token: 0x060004FD RID: 1277
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4F0B3B0", Offset = "0x4F09FB0", VA = "0x184F0B3B0")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf);

		// Token: 0x060004FE RID: 1278
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x4F0AC20", Offset = "0x4F09820", VA = "0x184F0AC20")]
		[PreserveSig]
		public static extern bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x060004FF RID: 1279
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4F0B450", Offset = "0x4F0A050", VA = "0x184F0B450")]
		[PreserveSig]
		public static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self);

		// Token: 0x06000500 RID: 1280
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x4EE0970", Offset = "0x4EDF570", VA = "0x184EE0970")]
		[PreserveSig]
		public static extern bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg);

		// Token: 0x06000501 RID: 1281
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4EE08F0", Offset = "0x4EDF4F0", VA = "0x184EE08F0")]
		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self);

		// Token: 0x06000502 RID: 1282
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4EE0B10", Offset = "0x4EDF710", VA = "0x184EE0B10")]
		[PreserveSig]
		public static extern IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort);

		// Token: 0x06000503 RID: 1283
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4EE0BB0", Offset = "0x4EDF7B0", VA = "0x184EE0BB0")]
		[PreserveSig]
		public static extern void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg);

		// Token: 0x06000504 RID: 1284
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4F0B8B0", Offset = "0x4F0A4B0", VA = "0x184F0B8B0")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket([In] [Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In] [Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		// Token: 0x06000505 RID: 1285
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4F0BAE0", Offset = "0x4F0A6E0", VA = "0x184F0BAE0")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x06000506 RID: 1286
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4F0BE10", Offset = "0x4F0AA10", VA = "0x184F0BE10")]
		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x06000507 RID: 1287
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4F0BEA0", Offset = "0x4F0AAA0", VA = "0x184F0BEA0")]
		[PreserveSig]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		// Token: 0x06000508 RID: 1288
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4F0BD80", Offset = "0x4F0A980", VA = "0x184F0BD80")]
		[PreserveSig]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x06000509 RID: 1289
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4F0BCE0", Offset = "0x4F0A8E0", VA = "0x184F0BCE0")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4F0BC40", Offset = "0x4F0A840", VA = "0x184F0BC40")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4F0BF40", Offset = "0x4F0AB40", VA = "0x184F0BF40")]
		[PreserveSig]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4F0BB80", Offset = "0x4F0A780", VA = "0x184F0BB80")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsTicketSigned([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, [In] [Out] byte[] pubRSAKey, uint cubRSAKey);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4F0B9A0", Offset = "0x4F0A5A0", VA = "0x184F0B9A0")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseBorrowed([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4F0BA40", Offset = "0x4F0A640", VA = "0x184F0BA40")]
		[PreserveSig]
		public static extern bool SteamEncryptedAppTicket_BIsLicenseTemporary([In] [Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4EE25B0", Offset = "0x4EE11B0", VA = "0x184EE25B0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x4EE23A0", Offset = "0x4EE0FA0", VA = "0x184EE23A0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4EE2290", Offset = "0x4EE0E90", VA = "0x184EE2290")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		// Token: 0x06000512 RID: 1298
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4EE26D0", Offset = "0x4EE12D0", VA = "0x184EE26D0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		// Token: 0x06000513 RID: 1299
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4EE2AF0", Offset = "0x4EE16F0", VA = "0x184EE2AF0")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		// Token: 0x06000514 RID: 1300
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4EE28F0", Offset = "0x4EE14F0", VA = "0x184EE28F0")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		// Token: 0x06000515 RID: 1301
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4EE2420", Offset = "0x4EE1020", VA = "0x184EE2420")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000516 RID: 1302
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x4EE2310", Offset = "0x4EE0F10", VA = "0x184EE2310")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x4EE2CA0", Offset = "0x4EE18A0", VA = "0x184EE2CA0")]
		[PreserveSig]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x06000518 RID: 1304
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4EE2530", Offset = "0x4EE1130", VA = "0x184EE2530")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		// Token: 0x06000519 RID: 1305
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4EE2B70", Offset = "0x4EE1770", VA = "0x184EE2B70")]
		[PreserveSig]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		// Token: 0x0600051A RID: 1306
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x4EE2120", Offset = "0x4EE0D20", VA = "0x184EE2120")]
		[PreserveSig]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4EE30E0", Offset = "0x4EE1CE0", VA = "0x184EE30E0")]
		[PreserveSig]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x4EE3480", Offset = "0x4EE2080", VA = "0x184EE3480")]
		[PreserveSig]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x4EE3280", Offset = "0x4EE1E80", VA = "0x184EE3280")]
		[PreserveSig]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x4EE2A50", Offset = "0x4EE1650", VA = "0x184EE2A50")]
		[PreserveSig]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		// Token: 0x0600051F RID: 1311
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x4EE3170", Offset = "0x4EE1D70", VA = "0x184EE3170")]
		[PreserveSig]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly);

		// Token: 0x06000520 RID: 1312
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x4EE2E10", Offset = "0x4EE1A10", VA = "0x184EE2E10")]
		[PreserveSig]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In] [Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		// Token: 0x06000521 RID: 1313
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x4EE27D0", Offset = "0x4EE13D0", VA = "0x184EE27D0")]
		[PreserveSig]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		// Token: 0x06000522 RID: 1314
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4EE2200", Offset = "0x4EE0E00", VA = "0x184EE2200")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		// Token: 0x06000523 RID: 1315
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4EE2870", Offset = "0x4EE1470", VA = "0x184EE2870")]
		[PreserveSig]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		// Token: 0x06000524 RID: 1316
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4EE2F60", Offset = "0x4EE1B60", VA = "0x184EE2F60")]
		[PreserveSig]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4EE2BF0", Offset = "0x4EE17F0", VA = "0x184EE2BF0")]
		[PreserveSig]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x06000526 RID: 1318
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x4EE2750", Offset = "0x4EE1350", VA = "0x184EE2750")]
		[PreserveSig]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		// Token: 0x06000527 RID: 1319
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x4EE3200", Offset = "0x4EE1E00", VA = "0x184EE3200")]
		[PreserveSig]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		// Token: 0x06000528 RID: 1320
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x4EE2D30", Offset = "0x4EE1930", VA = "0x184EE2D30")]
		[PreserveSig]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		// Token: 0x06000529 RID: 1321
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x4EE2EC0", Offset = "0x4EE1AC0", VA = "0x184EE2EC0")]
		[PreserveSig]
		public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine);

		// Token: 0x0600052A RID: 1322
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x4EE24B0", Offset = "0x4EE10B0", VA = "0x184EE24B0")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr);

		// Token: 0x0600052B RID: 1323
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x4EE2630", Offset = "0x4EE1230", VA = "0x184EE2630")]
		[PreserveSig]
		public static extern bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed);

		// Token: 0x0600052C RID: 1324
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x4EE33F0", Offset = "0x4EE1FF0", VA = "0x184EE33F0")]
		[PreserveSig]
		public static extern bool ISteamApps_SetDlcContext(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x4EE3040", Offset = "0x4EE1C40", VA = "0x184EE3040")]
		[PreserveSig]
		public static extern int ISteamApps_GetNumBetas(IntPtr instancePtr, out int pnAvailable, out int pnPrivate);

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x4EE2970", Offset = "0x4EE1570", VA = "0x184EE2970")]
		[PreserveSig]
		public static extern bool ISteamApps_GetBetaInfo(IntPtr instancePtr, int iBetaIndex, out uint punFlags, out uint punBuildID, IntPtr pchBetaName, int cchBetaName, IntPtr pchDescription, int cchDescription);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x4EE3310", Offset = "0x4EE1F10", VA = "0x184EE3310")]
		[PreserveSig]
		public static extern bool ISteamApps_SetActiveBeta(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchBetaName);

		// Token: 0x06000530 RID: 1328
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x4EE3750", Offset = "0x4EE2350", VA = "0x184EE3750")]
		[PreserveSig]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		// Token: 0x06000531 RID: 1329
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x4EE3510", Offset = "0x4EE2110", VA = "0x184EE3510")]
		[PreserveSig]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000532 RID: 1330
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x4EE3620", Offset = "0x4EE2220", VA = "0x184EE3620")]
		[PreserveSig]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		// Token: 0x06000533 RID: 1331
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4EE36B0", Offset = "0x4EE22B0", VA = "0x184EE36B0")]
		[PreserveSig]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		// Token: 0x06000534 RID: 1332
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x4EE50A0", Offset = "0x4EE3CA0", VA = "0x184EE50A0")]
		[PreserveSig]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		// Token: 0x06000535 RID: 1333
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x4EE4DE0", Offset = "0x4EE39E0", VA = "0x184EE4DE0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000536 RID: 1334
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x4EE3D00", Offset = "0x4EE2900", VA = "0x184EE3D00")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000537 RID: 1335
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x4EE5140", Offset = "0x4EE3D40", VA = "0x184EE5140")]
		[PreserveSig]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort);

		// Token: 0x06000538 RID: 1336
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x4EE3A30", Offset = "0x4EE2630", VA = "0x184EE3A30")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4EE4ED0", Offset = "0x4EE3AD0", VA = "0x184EE4ED0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053A RID: 1338
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x4EE4390", Offset = "0x4EE2F90", VA = "0x184EE4390")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053B RID: 1339
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x4EE42A0", Offset = "0x4EE2EA0", VA = "0x184EE42A0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053C RID: 1340
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4EE3DF0", Offset = "0x4EE29F0", VA = "0x184EE3DF0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053D RID: 1341
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x4EE4CF0", Offset = "0x4EE38F0", VA = "0x184EE4CF0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053E RID: 1342
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x4EE3C10", Offset = "0x4EE2810", VA = "0x184EE3C10")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600053F RID: 1343
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x4EE3850", Offset = "0x4EE2450", VA = "0x184EE3850")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x4EE4660", Offset = "0x4EE3260", VA = "0x184EE4660")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000541 RID: 1345
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x4EE4A20", Offset = "0x4EE3620", VA = "0x184EE4A20")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000542 RID: 1346
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x4EE4B10", Offset = "0x4EE3710", VA = "0x184EE4B10")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000543 RID: 1347
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x4EE3B20", Offset = "0x4EE2720", VA = "0x184EE3B20")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000544 RID: 1348
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4EE37D0", Offset = "0x4EE23D0", VA = "0x184EE37D0")]
		[PreserveSig]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x06000545 RID: 1349
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4EE51E0", Offset = "0x4EE3DE0", VA = "0x184EE51E0")]
		[PreserveSig]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x06000546 RID: 1350
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4EE35A0", Offset = "0x4EE21A0", VA = "0x184EE35A0")]
		[PreserveSig]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		// Token: 0x06000547 RID: 1351
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4EE3FD0", Offset = "0x4EE2BD0", VA = "0x184EE3FD0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000548 RID: 1352
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x4EE3940", Offset = "0x4EE2540", VA = "0x184EE3940")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000549 RID: 1353
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x4EE4C00", Offset = "0x4EE3800", VA = "0x184EE4C00")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054A RID: 1354
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x4EE4570", Offset = "0x4EE3170", VA = "0x184EE4570")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054B RID: 1355
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x4EE4480", Offset = "0x4EE3080", VA = "0x184EE4480")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054C RID: 1356
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x4EE3EE0", Offset = "0x4EE2AE0", VA = "0x184EE3EE0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054D RID: 1357
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x4EE41B0", Offset = "0x4EE2DB0", VA = "0x184EE41B0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054E RID: 1358
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4EE4FB0", Offset = "0x4EE3BB0", VA = "0x184EE4FB0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x0600054F RID: 1359
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x4EE4750", Offset = "0x4EE3350", VA = "0x184EE4750")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000550 RID: 1360
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x4EE40C0", Offset = "0x4EE2CC0", VA = "0x184EE40C0")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000551 RID: 1361
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x4EE4840", Offset = "0x4EE3440", VA = "0x184EE4840")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000552 RID: 1362
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x4EE4930", Offset = "0x4EE3530", VA = "0x184EE4930")]
		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		// Token: 0x06000553 RID: 1363
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x4EE7120", Offset = "0x4EE5D20", VA = "0x184EE7120")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		// Token: 0x06000554 RID: 1364
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x4EE81F0", Offset = "0x4EE6DF0", VA = "0x184EE81F0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		// Token: 0x06000555 RID: 1365
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x4EE71A0", Offset = "0x4EE5DA0", VA = "0x184EE71A0")]
		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x4EE6520", Offset = "0x4EE5120", VA = "0x184EE6520")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		// Token: 0x06000557 RID: 1367
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x4EE62D0", Offset = "0x4EE4ED0", VA = "0x184EE62D0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000558 RID: 1368
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4EE6970", Offset = "0x4EE5570", VA = "0x184EE6970")]
		[PreserveSig]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000559 RID: 1369
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4EE68E0", Offset = "0x4EE54E0", VA = "0x184EE68E0")]
		[PreserveSig]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600055A RID: 1370
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4EE6850", Offset = "0x4EE5450", VA = "0x184EE6850")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600055B RID: 1371
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4EE6650", Offset = "0x4EE5250", VA = "0x184EE6650")]
		[PreserveSig]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x4EE67B0", Offset = "0x4EE53B0", VA = "0x184EE67B0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		// Token: 0x0600055D RID: 1373
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4EE6C10", Offset = "0x4EE5810", VA = "0x184EE6C10")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x0600055E RID: 1374
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x4EE7220", Offset = "0x4EE5E20", VA = "0x184EE7220")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		// Token: 0x0600055F RID: 1375
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x4EE6CA0", Offset = "0x4EE58A0", VA = "0x184EE6CA0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		// Token: 0x06000560 RID: 1376
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x4EE6D20", Offset = "0x4EE5920", VA = "0x184EE6D20")]
		[PreserveSig]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		// Token: 0x06000561 RID: 1377
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x4EE6EF0", Offset = "0x4EE5AF0", VA = "0x184EE6EF0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000562 RID: 1378
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x4EE6DB0", Offset = "0x4EE59B0", VA = "0x184EE6DB0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		// Token: 0x06000563 RID: 1379
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x4EE6E40", Offset = "0x4EE5A40", VA = "0x184EE6E40")]
		[PreserveSig]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In] [Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x4EE7520", Offset = "0x4EE6120", VA = "0x184EE7520")]
		[PreserveSig]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		// Token: 0x06000565 RID: 1381
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x4EE5DD0", Offset = "0x4EE49D0", VA = "0x184EE5DD0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		// Token: 0x06000566 RID: 1382
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x4EE5BE0", Offset = "0x4EE47E0", VA = "0x184EE5BE0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		// Token: 0x06000567 RID: 1383
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x4EE5E50", Offset = "0x4EE4A50", VA = "0x184EE5E50")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000568 RID: 1384
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x4EE60A0", Offset = "0x4EE4CA0", VA = "0x184EE60A0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x4EE5B20", Offset = "0x4EE4720", VA = "0x184EE5B20")]
		[PreserveSig]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x4EE5950", Offset = "0x4EE4550", VA = "0x184EE5950")]
		[PreserveSig]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In] [Out] CSteamID[] psteamIDClans, int cClansToRequest);

		// Token: 0x0600056B RID: 1387
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x4EE6490", Offset = "0x4EE5090", VA = "0x184EE6490")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		// Token: 0x0600056C RID: 1388
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x4EE65B0", Offset = "0x4EE51B0", VA = "0x184EE65B0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x4EE7980", Offset = "0x4EE6580", VA = "0x184EE7980")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		// Token: 0x0600056E RID: 1390
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x4EE80C0", Offset = "0x4EE6CC0", VA = "0x184EE80C0")]
		[PreserveSig]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking);

		// Token: 0x0600056F RID: 1391
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x4EE56D0", Offset = "0x4EE42D0", VA = "0x184EE56D0")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x4EE5510", Offset = "0x4EE4110", VA = "0x184EE5510")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		// Token: 0x06000571 RID: 1393
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x4EE55F0", Offset = "0x4EE41F0", VA = "0x184EE55F0")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode);

		// Token: 0x06000572 RID: 1394
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4EE5470", Offset = "0x4EE4070", VA = "0x184EE5470")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		// Token: 0x06000573 RID: 1395
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x4EE82D0", Offset = "0x4EE6ED0", VA = "0x184EE82D0")]
		[PreserveSig]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		// Token: 0x06000574 RID: 1396
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x4EE5350", Offset = "0x4EE3F50", VA = "0x184EE5350")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000575 RID: 1397
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x4EE7410", Offset = "0x4EE6010", VA = "0x184EE7410")]
		[PreserveSig]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000576 RID: 1398
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x4EE7010", Offset = "0x4EE5C10", VA = "0x184EE7010")]
		[PreserveSig]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000577 RID: 1399
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x4EE6F80", Offset = "0x4EE5B80", VA = "0x184EE6F80")]
		[PreserveSig]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x4EE7F40", Offset = "0x4EE6B40", VA = "0x184EE7F40")]
		[PreserveSig]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly);

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x4EE7D90", Offset = "0x4EE6990", VA = "0x184EE7D90")]
		[PreserveSig]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x4EE6010", Offset = "0x4EE4C10", VA = "0x184EE6010")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x4EE5F80", Offset = "0x4EE4B80", VA = "0x184EE5F80")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x4EE5EE0", Offset = "0x4EE4AE0", VA = "0x184EE5EE0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x4EE74A0", Offset = "0x4EE60A0", VA = "0x184EE74A0")]
		[PreserveSig]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		// Token: 0x0600057E RID: 1406
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x4EE8360", Offset = "0x4EE6F60", VA = "0x184EE8360")]
		[PreserveSig]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600057F RID: 1407
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x4EE5840", Offset = "0x4EE4440", VA = "0x184EE5840")]
		[PreserveSig]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		// Token: 0x06000580 RID: 1408
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x4EE6B30", Offset = "0x4EE5730", VA = "0x184EE6B30")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000581 RID: 1409
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x4EE6AA0", Offset = "0x4EE56A0", VA = "0x184EE6AA0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000582 RID: 1410
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x4EE6A00", Offset = "0x4EE5600", VA = "0x184EE6A00")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x4EE7EB0", Offset = "0x4EE6AB0", VA = "0x184EE7EB0")]
		[PreserveSig]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x4EE75C0", Offset = "0x4EE61C0", VA = "0x184EE75C0")]
		[PreserveSig]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x4EE6130", Offset = "0x4EE4D30", VA = "0x184EE6130")]
		[PreserveSig]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x4EE61B0", Offset = "0x4EE4DB0", VA = "0x184EE61B0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x4EE6400", Offset = "0x4EE5000", VA = "0x184EE6400")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x4EE6370", Offset = "0x4EE4F70", VA = "0x184EE6370")]
		[PreserveSig]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x4EE7A20", Offset = "0x4EE6620", VA = "0x184EE7A20")]
		[PreserveSig]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x4EE7AB0", Offset = "0x4EE66B0", VA = "0x184EE7AB0")]
		[PreserveSig]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x4EE5C70", Offset = "0x4EE4870", VA = "0x184EE5C70")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x4EE5A80", Offset = "0x4EE4680", VA = "0x184EE5A80")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x4EE7FE0", Offset = "0x4EE6BE0", VA = "0x184EE7FE0")]
		[PreserveSig]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x4EE5D00", Offset = "0x4EE4900", VA = "0x184EE5D00")]
		[PreserveSig]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		// Token: 0x0600058F RID: 1423
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x4EE76A0", Offset = "0x4EE62A0", VA = "0x184EE76A0")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		// Token: 0x06000590 RID: 1424
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x4EE7740", Offset = "0x4EE6340", VA = "0x184EE7740")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000591 RID: 1425
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x4EE7B40", Offset = "0x4EE6740", VA = "0x184EE7B40")]
		[PreserveSig]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000592 RID: 1426
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x4EE58C0", Offset = "0x4EE44C0", VA = "0x184EE58C0")]
		[PreserveSig]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		// Token: 0x06000593 RID: 1427
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x4EE8160", Offset = "0x4EE6D60", VA = "0x184EE8160")]
		[PreserveSig]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled);

		// Token: 0x06000594 RID: 1428
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4EE7CB0", Offset = "0x4EE68B0", VA = "0x184EE7CB0")]
		[PreserveSig]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		// Token: 0x06000595 RID: 1429
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x4EE66F0", Offset = "0x4EE52F0", VA = "0x184EE66F0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x06000596 RID: 1430
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x4EE6240", Offset = "0x4EE4E40", VA = "0x184EE6240")]
		[PreserveSig]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000597 RID: 1431
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x4EE78F0", Offset = "0x4EE64F0", VA = "0x184EE78F0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x06000598 RID: 1432
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x4EE59F0", Offset = "0x4EE45F0", VA = "0x184EE59F0")]
		[PreserveSig]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x06000599 RID: 1433
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x4EE7860", Offset = "0x4EE6460", VA = "0x184EE7860")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600059A RID: 1434
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4EE77D0", Offset = "0x4EE63D0", VA = "0x184EE77D0")]
		[PreserveSig]
		public static extern bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x0600059B RID: 1435
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x4EE70A0", Offset = "0x4EE5CA0", VA = "0x184EE70A0")]
		[PreserveSig]
		public static extern int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr);

		// Token: 0x0600059C RID: 1436
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x4EE53E0", Offset = "0x4EE3FE0", VA = "0x184EE53E0")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600059D RID: 1437
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x4EE7BD0", Offset = "0x4EE67D0", VA = "0x184EE7BD0")]
		[PreserveSig]
		public static extern bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchProtocol);

		// Token: 0x0600059E RID: 1438
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x4EE5280", Offset = "0x4EE3E80", VA = "0x184EE5280")]
		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectString);

		// Token: 0x0600059F RID: 1439
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x4EE7E20", Offset = "0x4EE6A20", VA = "0x184EE7E20")]
		[PreserveSig]
		public static extern ulong ISteamFriends_RequestEquippedProfileItems(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060005A0 RID: 1440
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4EE57A0", Offset = "0x4EE43A0", VA = "0x184EE57A0")]
		[PreserveSig]
		public static extern bool ISteamFriends_BHasEquippedProfileItem(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType);

		// Token: 0x060005A1 RID: 1441
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x4EE72B0", Offset = "0x4EE5EB0", VA = "0x184EE72B0")]
		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetProfileItemPropertyString(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop);

		// Token: 0x060005A2 RID: 1442
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x4EE7360", Offset = "0x4EE5F60", VA = "0x184EE7360")]
		[PreserveSig]
		public static extern uint ISteamFriends_GetProfileItemPropertyUint(IntPtr instancePtr, CSteamID steamID, ECommunityProfileItemType itemType, ECommunityProfileItemProperty prop);

		// Token: 0x060005A3 RID: 1443
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x4EEAD60", Offset = "0x4EE9960", VA = "0x184EEAD60")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		// Token: 0x060005A4 RID: 1444
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x4EEA7D0", Offset = "0x4EE93D0", VA = "0x184EEA7D0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		// Token: 0x060005A5 RID: 1445
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x4EEAC00", Offset = "0x4EE9800", VA = "0x184EEAC00")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		// Token: 0x060005A6 RID: 1446
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x4EEA670", Offset = "0x4EE9270", VA = "0x184EEA670")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated);

		// Token: 0x060005A7 RID: 1447
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x4EEA290", Offset = "0x4EE8E90", VA = "0x184EEA290")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		// Token: 0x060005A8 RID: 1448
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x4EEA210", Offset = "0x4EE8E10", VA = "0x184EEA210")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		// Token: 0x060005A9 RID: 1449
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x4EEA190", Offset = "0x4EE8D90", VA = "0x184EEA190")]
		[PreserveSig]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		// Token: 0x060005AA RID: 1450
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x4EE97D0", Offset = "0x4EE83D0", VA = "0x184EE97D0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		// Token: 0x060005AB RID: 1451
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x4EE9850", Offset = "0x4EE8450", VA = "0x184EE9850")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		// Token: 0x060005AC RID: 1452
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x4EEA040", Offset = "0x4EE8C40", VA = "0x184EEA040")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		// Token: 0x060005AD RID: 1453
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x4EEB1D0", Offset = "0x4EE9DD0", VA = "0x184EEB1D0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		// Token: 0x060005AE RID: 1454
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x4EEAB70", Offset = "0x4EE9770", VA = "0x184EEAB70")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		// Token: 0x060005AF RID: 1455
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x4EEA5E0", Offset = "0x4EE91E0", VA = "0x184EEA5E0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		// Token: 0x060005B0 RID: 1456
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x4EEAF00", Offset = "0x4EE9B00", VA = "0x184EEAF00")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		// Token: 0x060005B1 RID: 1457
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x4EEAAA0", Offset = "0x4EE96A0", VA = "0x184EEAAA0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		// Token: 0x060005B2 RID: 1458
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x4EEACD0", Offset = "0x4EE98D0", VA = "0x184EEACD0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected);

		// Token: 0x060005B3 RID: 1459
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x4EEAFD0", Offset = "0x4EE9BD0", VA = "0x184EEAFD0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		// Token: 0x060005B4 RID: 1460
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x4EEB060", Offset = "0x4EE9C60", VA = "0x184EEB060")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		// Token: 0x060005B5 RID: 1461
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x4EE9B00", Offset = "0x4EE8700", VA = "0x184EE9B00")]
		[PreserveSig]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x4EEA970", Offset = "0x4EE9570", VA = "0x184EEA970")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x060005B7 RID: 1463
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x4EEA8A0", Offset = "0x4EE94A0", VA = "0x184EEA8A0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x4EEA700", Offset = "0x4EE9300", VA = "0x184EEA700")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x4EEAE30", Offset = "0x4EE9A30", VA = "0x184EEAE30")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		// Token: 0x060005BA RID: 1466
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x4EEA550", Offset = "0x4EE9150", VA = "0x184EEA550")]
		[PreserveSig]
		public static extern void ISteamGameServer_SetAdvertiseServerActive(IntPtr instancePtr, bool bActive);

		// Token: 0x060005BB RID: 1467
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x4EE9D20", Offset = "0x4EE8920", VA = "0x184EE9D20")]
		[PreserveSig]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid);

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x4EE99C0", Offset = "0x4EE85C0", VA = "0x184EE99C0")]
		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x060005BD RID: 1469
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x4EE9C90", Offset = "0x4EE8890", VA = "0x184EE9C90")]
		[PreserveSig]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x060005BE RID: 1470
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x4EE9A70", Offset = "0x4EE8670", VA = "0x184EE9A70")]
		[PreserveSig]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x060005BF RID: 1471
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x4EEB130", Offset = "0x4EE9D30", VA = "0x184EEB130")]
		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x060005C0 RID: 1472
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x4EEA360", Offset = "0x4EE8F60", VA = "0x184EEA360")]
		[PreserveSig]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		// Token: 0x060005C1 RID: 1473
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x4EE9DE0", Offset = "0x4EE89E0", VA = "0x184EE9DE0")]
		[PreserveSig]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		// Token: 0x060005C2 RID: 1474
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x4EE9FC0", Offset = "0x4EE8BC0", VA = "0x184EE9FC0")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		// Token: 0x060005C3 RID: 1475
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x4EE9F20", Offset = "0x4EE8B20", VA = "0x184EE9F20")]
		[PreserveSig]
		public static extern SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		// Token: 0x060005C4 RID: 1476
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x4EEA0C0", Offset = "0x4EE8CC0", VA = "0x184EEA0C0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		// Token: 0x060005C5 RID: 1477
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x4EE9E60", Offset = "0x4EE8A60", VA = "0x184EE9E60")]
		[PreserveSig]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		// Token: 0x060005C6 RID: 1478
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x4EE9740", Offset = "0x4EE8340", VA = "0x184EE9740")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		// Token: 0x060005C7 RID: 1479
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x4EE9B80", Offset = "0x4EE8780", VA = "0x184EE9B80")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		// Token: 0x060005C8 RID: 1480
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x4EEA400", Offset = "0x4EE9000", VA = "0x184EEA400")]
		[PreserveSig]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		// Token: 0x060005C9 RID: 1481
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x4EE9C10", Offset = "0x4EE8810", VA = "0x184EE9C10")]
		[PreserveSig]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		// Token: 0x060005CA RID: 1482
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x4EEA4C0", Offset = "0x4EE90C0", VA = "0x184EEA4C0")]
		[PreserveSig]
		public static extern void ISteamGameServer_SendUserDisconnect_DEPRECATED(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005CB RID: 1483
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x4EE98D0", Offset = "0x4EE84D0", VA = "0x184EE98D0")]
		[PreserveSig]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		// Token: 0x060005CC RID: 1484
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x4EE9240", Offset = "0x4EE7E40", VA = "0x184EE9240")]
		[PreserveSig]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005CD RID: 1485
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x4EE9150", Offset = "0x4EE7D50", VA = "0x184EE9150")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x060005CE RID: 1486
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x4EE9060", Offset = "0x4EE7C60", VA = "0x184EE9060")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x060005CF RID: 1487
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x4EE8F50", Offset = "0x4EE7B50", VA = "0x184EE8F50")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x060005D0 RID: 1488
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x4EE94B0", Offset = "0x4EE80B0", VA = "0x184EE94B0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x060005D1 RID: 1489
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x4EE93B0", Offset = "0x4EE7FB0", VA = "0x184EE93B0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x060005D2 RID: 1490
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x4EE9630", Offset = "0x4EE8230", VA = "0x184EE9630")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x060005D3 RID: 1491
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x4EE92D0", Offset = "0x4EE7ED0", VA = "0x184EE92D0")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060005D4 RID: 1492
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x4EE8E70", Offset = "0x4EE7A70", VA = "0x184EE8E70")]
		[PreserveSig]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060005D5 RID: 1493
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x4EE95A0", Offset = "0x4EE81A0", VA = "0x184EE95A0")]
		[PreserveSig]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x060005D6 RID: 1494
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4EEBA50", Offset = "0x4EEA650", VA = "0x184EEBA50")]
		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		// Token: 0x060005D7 RID: 1495
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4EECAC0", Offset = "0x4EEB6C0", VA = "0x184EECAC0")]
		[PreserveSig]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		// Token: 0x060005D8 RID: 1496
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x4EEB4D0", Offset = "0x4EEA0D0", VA = "0x184EEB4D0")]
		[PreserveSig]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		// Token: 0x060005D9 RID: 1497
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x4EEC380", Offset = "0x4EEAF80", VA = "0x184EEC380")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005DA RID: 1498
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x4EEBD60", Offset = "0x4EEA960", VA = "0x184EEBD60")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		// Token: 0x060005DB RID: 1499
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x4EEC980", Offset = "0x4EEB580", VA = "0x184EEC980")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		// Token: 0x060005DC RID: 1500
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x4EECBD0", Offset = "0x4EEB7D0", VA = "0x184EECBD0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005DD RID: 1501
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x4EEC2F0", Offset = "0x4EEAEF0", VA = "0x184EEC2F0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005DE RID: 1502
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x4EEB930", Offset = "0x4EEA530", VA = "0x184EEB930")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005DF RID: 1503
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x4EEB9C0", Offset = "0x4EEA5C0", VA = "0x184EEB9C0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005E0 RID: 1504
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4EEB250", Offset = "0x4EE9E50", VA = "0x184EEB250")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060005E1 RID: 1505
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4EEB610", Offset = "0x4EEA210", VA = "0x184EEB610")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		// Token: 0x060005E2 RID: 1506
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4EEC090", Offset = "0x4EEAC90", VA = "0x184EEC090")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005E3 RID: 1507
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x4EEBF50", Offset = "0x4EEAB50", VA = "0x184EEBF50")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005E4 RID: 1508
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x4EEBEB0", Offset = "0x4EEAAB0", VA = "0x184EEBEB0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		// Token: 0x060005E5 RID: 1509
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x4EEBFF0", Offset = "0x4EEABF0", VA = "0x184EEBFF0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x060005E6 RID: 1510
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x4EEC130", Offset = "0x4EEAD30", VA = "0x184EEC130")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		// Token: 0x060005E7 RID: 1511
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x4EEBC10", Offset = "0x4EEA810", VA = "0x184EEBC10")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey);

		// Token: 0x060005E8 RID: 1512
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x4EEBCC0", Offset = "0x4EEA8C0", VA = "0x184EEBCC0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x060005E9 RID: 1513
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x4EEBB70", Offset = "0x4EEA770", VA = "0x184EEBB70")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		// Token: 0x060005EA RID: 1514
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x4EEC790", Offset = "0x4EEB390", VA = "0x184EEC790")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x060005EB RID: 1515
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x4EECA20", Offset = "0x4EEB620", VA = "0x184EECA20")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		// Token: 0x060005EC RID: 1516
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4EEC830", Offset = "0x4EEB430", VA = "0x184EEC830")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		// Token: 0x060005ED RID: 1517
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x4EECC60", Offset = "0x4EEB860", VA = "0x184EECC60")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005EE RID: 1518
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x4EEB440", Offset = "0x4EEA040", VA = "0x184EEB440")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005EF RID: 1519
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x4EEC260", Offset = "0x4EEAE60", VA = "0x184EEC260")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005F0 RID: 1520
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x4EEB790", Offset = "0x4EEA390", VA = "0x184EEB790")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		// Token: 0x060005F1 RID: 1521
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x4EECB40", Offset = "0x4EEB740", VA = "0x184EECB40")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005F2 RID: 1522
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x4EEB890", Offset = "0x4EEA490", VA = "0x184EEB890")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		// Token: 0x060005F3 RID: 1523
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x4EEC4B0", Offset = "0x4EEB0B0", VA = "0x184EEC4B0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		// Token: 0x060005F4 RID: 1524
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4EEC8D0", Offset = "0x4EEB4D0", VA = "0x184EEC8D0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		// Token: 0x060005F5 RID: 1525
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x4EEC410", Offset = "0x4EEB010", VA = "0x184EEC410")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		// Token: 0x060005F6 RID: 1526
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x4EEC6F0", Offset = "0x4EEB2F0", VA = "0x184EEC6F0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		// Token: 0x060005F7 RID: 1527
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x4EEC1D0", Offset = "0x4EEADD0", VA = "0x184EEC1D0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		// Token: 0x060005F8 RID: 1528
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x4EEB3A0", Offset = "0x4EE9FA0", VA = "0x184EEB3A0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed);

		// Token: 0x060005F9 RID: 1529
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x4EEBAD0", Offset = "0x4EEA6D0", VA = "0x184EEBAD0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult);

		// Token: 0x060005FA RID: 1530
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x4EEB6F0", Offset = "0x4EEA2F0", VA = "0x184EEB6F0")]
		[PreserveSig]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		// Token: 0x060005FB RID: 1531
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x4EECD80", Offset = "0x4EEB980", VA = "0x184EECD80")]
		[PreserveSig]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		// Token: 0x060005FC RID: 1532
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4EED9A0", Offset = "0x4EEC5A0", VA = "0x184EED9A0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		// Token: 0x060005FD RID: 1533
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4EEDD80", Offset = "0x4EEC980", VA = "0x184EEDD80")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		// Token: 0x060005FE RID: 1534
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4EEDC30", Offset = "0x4EEC830", VA = "0x184EEDC30")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		// Token: 0x060005FF RID: 1535
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4EEDAE0", Offset = "0x4EEC6E0", VA = "0x184EEDAE0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		// Token: 0x06000600 RID: 1536
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x4EED6A0", Offset = "0x4EEC2A0", VA = "0x184EED6A0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x06000601 RID: 1537
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x4EED600", Offset = "0x4EEC200", VA = "0x184EED600")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		// Token: 0x06000602 RID: 1538
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4EECE60", Offset = "0x4EEBA60", VA = "0x184EECE60")]
		[PreserveSig]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x06000603 RID: 1539
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4EED450", Offset = "0x4EEC050", VA = "0x184EED450")]
		[PreserveSig]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x06000604 RID: 1540
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x4EED190", Offset = "0x4EEBD90", VA = "0x184EED190")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		// Token: 0x06000605 RID: 1541
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x4EED280", Offset = "0x4EEBE80", VA = "0x184EED280")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		// Token: 0x06000606 RID: 1542
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4EED0F0", Offset = "0x4EEBCF0", VA = "0x184EED0F0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		// Token: 0x06000607 RID: 1543
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4EED040", Offset = "0x4EEBC40", VA = "0x184EED040")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x06000608 RID: 1544
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4EED390", Offset = "0x4EEBF90", VA = "0x184EED390")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		// Token: 0x06000609 RID: 1545
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4EED570", Offset = "0x4EEC170", VA = "0x184EED570")]
		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		// Token: 0x0600060A RID: 1546
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4EECEF0", Offset = "0x4EEBAF0", VA = "0x184EECEF0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		// Token: 0x0600060B RID: 1547
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4EEDE20", Offset = "0x4EECA20", VA = "0x184EEDE20")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		// Token: 0x0600060C RID: 1548
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x4EECCF0", Offset = "0x4EEB8F0", VA = "0x184EECCF0")]
		[PreserveSig]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify);

		// Token: 0x0600060D RID: 1549
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x4EED4E0", Offset = "0x4EEC0E0", VA = "0x184EED4E0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x0600060E RID: 1550
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x4EED740", Offset = "0x4EEC340", VA = "0x184EED740")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		// Token: 0x0600060F RID: 1551
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4EEDA40", Offset = "0x4EEC640", VA = "0x184EEDA40")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		// Token: 0x06000610 RID: 1552
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x4EEDFD0", Offset = "0x4EECBD0", VA = "0x184EEDFD0")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		// Token: 0x06000611 RID: 1553
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x4EEDF30", Offset = "0x4EECB30", VA = "0x184EEDF30")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		// Token: 0x06000612 RID: 1554
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x4EED900", Offset = "0x4EEC500", VA = "0x184EED900")]
		[PreserveSig]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		// Token: 0x06000613 RID: 1555
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x4EECF90", Offset = "0x4EEBB90", VA = "0x184EECF90")]
		[PreserveSig]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		// Token: 0x06000614 RID: 1556
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x4EEF620", Offset = "0x4EEE220", VA = "0x184EEF620")]
		[PreserveSig]
		public static extern bool ISteamInput_Init(IntPtr instancePtr, bool bExplicitlyCallRunFrame);

		// Token: 0x06000615 RID: 1557
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x4EEFB90", Offset = "0x4EEE790", VA = "0x184EEFB90")]
		[PreserveSig]
		public static extern bool ISteamInput_Shutdown(IntPtr instancePtr);

		// Token: 0x06000616 RID: 1558
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x4EEF960", Offset = "0x4EEE560", VA = "0x184EEF960")]
		[PreserveSig]
		public static extern bool ISteamInput_SetInputActionManifestFilePath(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchInputActionManifestAbsolutePath);

		// Token: 0x06000617 RID: 1559
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x4EEF830", Offset = "0x4EEE430", VA = "0x184EEF830")]
		[PreserveSig]
		public static extern void ISteamInput_RunFrame(IntPtr instancePtr, bool bReservedValue);

		// Token: 0x06000618 RID: 1560
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x4EEE270", Offset = "0x4EECE70", VA = "0x184EEE270")]
		[PreserveSig]
		public static extern bool ISteamInput_BWaitForData(IntPtr instancePtr, bool bWaitForever, uint unTimeout);

		// Token: 0x06000619 RID: 1561
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4EEE1F0", Offset = "0x4EECDF0", VA = "0x184EEE1F0")]
		[PreserveSig]
		public static extern bool ISteamInput_BNewDataAvailable(IntPtr instancePtr);

		// Token: 0x0600061A RID: 1562
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4EEE9E0", Offset = "0x4EED5E0", VA = "0x184EEE9E0")]
		[PreserveSig]
		public static extern int ISteamInput_GetConnectedControllers(IntPtr instancePtr, [In] [Out] InputHandle_t[] handlesOut);

		// Token: 0x0600061B RID: 1563
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x4EEE4E0", Offset = "0x4EED0E0", VA = "0x184EEE4E0")]
		[PreserveSig]
		public static extern void ISteamInput_EnableDeviceCallbacks(IntPtr instancePtr);

		// Token: 0x0600061C RID: 1564
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x4EEE440", Offset = "0x4EED040", VA = "0x184EEE440")]
		[PreserveSig]
		public static extern void ISteamInput_EnableActionEventCallbacks(IntPtr instancePtr, SteamInputActionEventCallbackPointer pCallback);

		// Token: 0x0600061D RID: 1565
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x4EEE600", Offset = "0x4EED200", VA = "0x184EEE600")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		// Token: 0x0600061E RID: 1566
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x4EEE150", Offset = "0x4EECD50", VA = "0x184EEE150")]
		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle);

		// Token: 0x0600061F RID: 1567
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x4EEEB10", Offset = "0x4EED710", VA = "0x184EEEB10")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000620 RID: 1568
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x4EEE0B0", Offset = "0x4EECCB0", VA = "0x184EEE0B0")]
		[PreserveSig]
		public static extern void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		// Token: 0x06000621 RID: 1569
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4EEE310", Offset = "0x4EECF10", VA = "0x184EEE310")]
		[PreserveSig]
		public static extern void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle);

		// Token: 0x06000622 RID: 1570
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x4EEE3B0", Offset = "0x4EECFB0", VA = "0x184EEE3B0")]
		[PreserveSig]
		public static extern void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000623 RID: 1571
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4EEE6E0", Offset = "0x4EED2E0", VA = "0x184EEE6E0")]
		[PreserveSig]
		public static extern int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, [In] [Out] InputActionSetHandle_t[] handlesOut);

		// Token: 0x06000624 RID: 1572
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x4EEECF0", Offset = "0x4EED8F0", VA = "0x184EEECF0")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000625 RID: 1573
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x4EEEC50", Offset = "0x4EED850", VA = "0x184EEEC50")]
		[PreserveSig]
		public static extern InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle);

		// Token: 0x06000626 RID: 1574
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x4EEEDD0", Offset = "0x4EED9D0", VA = "0x184EEEDD0")]
		[PreserveSig]
		public static extern int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, [In] [Out] EInputActionOrigin[] originsOut);

		// Token: 0x06000627 RID: 1575
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4EEF500", Offset = "0x4EEE100", VA = "0x184EEF500")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForDigitalActionName(IntPtr instancePtr, InputDigitalActionHandle_t eActionHandle);

		// Token: 0x06000628 RID: 1576
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x4EEE840", Offset = "0x4EED440", VA = "0x184EEE840")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		// Token: 0x06000629 RID: 1577
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x4EEE780", Offset = "0x4EED380", VA = "0x184EEE780")]
		[PreserveSig]
		public static extern InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle);

		// Token: 0x0600062A RID: 1578
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x4EEE920", Offset = "0x4EED520", VA = "0x184EEE920")]
		[PreserveSig]
		public static extern int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, [In] [Out] EInputActionOrigin[] originsOut);

		// Token: 0x0600062B RID: 1579
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x4EEF040", Offset = "0x4EEDC40", VA = "0x184EEF040")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphPNGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags);

		// Token: 0x0600062C RID: 1580
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x4EEF0E0", Offset = "0x4EEDCE0", VA = "0x184EEF0E0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphSVGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, uint unFlags);

		// Token: 0x0600062D RID: 1581
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x4EEEF20", Offset = "0x4EEDB20", VA = "0x184EEEF20")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForActionOrigin_Legacy(IntPtr instancePtr, EInputActionOrigin eOrigin);

		// Token: 0x0600062E RID: 1582
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x4EEF3E0", Offset = "0x4EEDFE0", VA = "0x184EEF3E0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin);

		// Token: 0x0600062F RID: 1583
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4EEF470", Offset = "0x4EEE070", VA = "0x184EEF470")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForAnalogActionName(IntPtr instancePtr, InputAnalogActionHandle_t eActionHandle);

		// Token: 0x06000630 RID: 1584
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4EEFC10", Offset = "0x4EEE810", VA = "0x184EEFC10")]
		[PreserveSig]
		public static extern void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction);

		// Token: 0x06000631 RID: 1585
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x4EEF210", Offset = "0x4EEDE10", VA = "0x184EEF210")]
		[PreserveSig]
		public static extern InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000632 RID: 1586
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4EEFEF0", Offset = "0x4EEEAF0", VA = "0x184EEFEF0")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed);

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4EEFE20", Offset = "0x4EEEA20", VA = "0x184EEFE20")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerVibrationExtended(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed);

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x4EEFD50", Offset = "0x4EEE950", VA = "0x184EEFD50")]
		[PreserveSig]
		public static extern void ISteamInput_TriggerSimpleHapticEvent(IntPtr instancePtr, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB);

		// Token: 0x06000635 RID: 1589
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x4EEFA40", Offset = "0x4EEE640", VA = "0x184EEFA40")]
		[PreserveSig]
		public static extern void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		// Token: 0x06000636 RID: 1590
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x4EEF6B0", Offset = "0x4EEE2B0", VA = "0x184EEF6B0")]
		[PreserveSig]
		public static extern void ISteamInput_Legacy_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x4EEF760", Offset = "0x4EEE360", VA = "0x184EEF760")]
		[PreserveSig]
		public static extern void ISteamInput_Legacy_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x4EEFB00", Offset = "0x4EEE700", VA = "0x184EEFB00")]
		[PreserveSig]
		public static extern bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000639 RID: 1593
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x4EEF180", Offset = "0x4EEDD80", VA = "0x184EEF180")]
		[PreserveSig]
		public static extern ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x0600063A RID: 1594
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x4EEEA80", Offset = "0x4EED680", VA = "0x184EEEA80")]
		[PreserveSig]
		public static extern ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x4EEEE90", Offset = "0x4EEDA90", VA = "0x184EEEE90")]
		[PreserveSig]
		public static extern int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle);

		// Token: 0x0600063C RID: 1596
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x4EEF590", Offset = "0x4EEE190", VA = "0x184EEF590")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		// Token: 0x0600063D RID: 1597
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x4EEEFB0", Offset = "0x4EEDBB0", VA = "0x184EEEFB0")]
		[PreserveSig]
		public static extern IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin);

		// Token: 0x0600063E RID: 1598
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x4EEE560", Offset = "0x4EED160", VA = "0x184EEE560")]
		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin);

		// Token: 0x0600063F RID: 1599
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x4EEFCB0", Offset = "0x4EEE8B0", VA = "0x184EEFCB0")]
		[PreserveSig]
		public static extern EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin);

		// Token: 0x06000640 RID: 1600
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x4EEEBA0", Offset = "0x4EED7A0", VA = "0x184EEEBA0")]
		[PreserveSig]
		public static extern bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor);

		// Token: 0x06000641 RID: 1601
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x4EEF2D0", Offset = "0x4EEDED0", VA = "0x184EEF2D0")]
		[PreserveSig]
		public static extern uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle);

		// Token: 0x06000642 RID: 1602
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x4EEF360", Offset = "0x4EEDF60", VA = "0x184EEF360")]
		[PreserveSig]
		public static extern ushort ISteamInput_GetSessionInputConfigurationSettings(IntPtr instancePtr);

		// Token: 0x06000643 RID: 1603
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x4EEF8C0", Offset = "0x4EEE4C0", VA = "0x184EEF8C0")]
		[PreserveSig]
		public static extern void ISteamInput_SetDualSenseTriggerEffect(IntPtr instancePtr, InputHandle_t inputHandle, IntPtr pParam);

		// Token: 0x06000644 RID: 1604
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4EF0D30", Offset = "0x4EEF930", VA = "0x184EF0D30")]
		[PreserveSig]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000645 RID: 1605
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4EF0C80", Offset = "0x4EEF880", VA = "0x184EF0C80")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		// Token: 0x06000646 RID: 1606
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x4EF0B60", Offset = "0x4EEF760", VA = "0x184EF0B60")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x06000647 RID: 1607
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4EF0DC0", Offset = "0x4EEF9C0", VA = "0x184EF0DC0")]
		[PreserveSig]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x06000648 RID: 1608
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x4EF0100", Offset = "0x4EEED00", VA = "0x184EF0100")]
		[PreserveSig]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		// Token: 0x06000649 RID: 1609
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4EF0310", Offset = "0x4EEEF10", VA = "0x184EF0310")]
		[PreserveSig]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		// Token: 0x0600064A RID: 1610
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x4EF0580", Offset = "0x4EEF180", VA = "0x184EF0580")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x0600064B RID: 1611
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x4EF0940", Offset = "0x4EEF540", VA = "0x184EF0940")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		// Token: 0x0600064C RID: 1612
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x4EF12D0", Offset = "0x4EEFED0", VA = "0x184EF12D0")]
		[PreserveSig]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		// Token: 0x0600064D RID: 1613
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4EF0250", Offset = "0x4EEEE50", VA = "0x184EF0250")]
		[PreserveSig]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		// Token: 0x0600064E RID: 1614
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x4EF04B0", Offset = "0x4EEF0B0", VA = "0x184EF04B0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x0600064F RID: 1615
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x4EF0E50", Offset = "0x4EEFA50", VA = "0x184EF0E50")]
		[PreserveSig]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000650 RID: 1616
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x4EEFFA0", Offset = "0x4EEEBA0", VA = "0x184EEFFA0")]
		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		// Token: 0x06000651 RID: 1617
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x4EF0040", Offset = "0x4EEEC40", VA = "0x184EF0040")]
		[PreserveSig]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		// Token: 0x06000652 RID: 1618
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4EF01A0", Offset = "0x4EEEDA0", VA = "0x184EF01A0")]
		[PreserveSig]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		// Token: 0x06000653 RID: 1619
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4EF03A0", Offset = "0x4EEEFA0", VA = "0x184EF03A0")]
		[PreserveSig]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In] [Out] SteamItemDef_t[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] SteamItemInstanceID_t[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		// Token: 0x06000654 RID: 1620
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4EF1B20", Offset = "0x4EF0720", VA = "0x184EF1B20")]
		[PreserveSig]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		// Token: 0x06000655 RID: 1621
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4EF1250", Offset = "0x4EEFE50", VA = "0x184EF1250")]
		[PreserveSig]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		// Token: 0x06000656 RID: 1622
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4EF1BE0", Offset = "0x4EF07E0", VA = "0x184EF1BE0")]
		[PreserveSig]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		// Token: 0x06000657 RID: 1623
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4EF1A00", Offset = "0x4EF0600", VA = "0x184EF1A00")]
		[PreserveSig]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In] [Out] SteamItemInstanceID_t[] pArrayGive, [In] [Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In] [Out] SteamItemInstanceID_t[] pArrayGet, [In] [Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		// Token: 0x06000658 RID: 1624
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4EF0FD0", Offset = "0x4EEFBD0", VA = "0x184EF0FD0")]
		[PreserveSig]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		// Token: 0x06000659 RID: 1625
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4EF06D0", Offset = "0x4EEF2D0", VA = "0x184EF06D0")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		// Token: 0x0600065A RID: 1626
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x4EF0780", Offset = "0x4EEF380", VA = "0x184EF0780")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		// Token: 0x0600065B RID: 1627
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x4EF1140", Offset = "0x4EEFD40", VA = "0x184EF1140")]
		[PreserveSig]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x0600065C RID: 1628
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x4EF0610", Offset = "0x4EEF210", VA = "0x184EF0610")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In] [Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		// Token: 0x0600065D RID: 1629
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x4EF1820", Offset = "0x4EF0420", VA = "0x184EF1820")]
		[PreserveSig]
		public static extern ulong ISteamInventory_StartPurchase(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength);

		// Token: 0x0600065E RID: 1630
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x4EF11D0", Offset = "0x4EEFDD0", VA = "0x184EF11D0")]
		[PreserveSig]
		public static extern ulong ISteamInventory_RequestPrices(IntPtr instancePtr);

		// Token: 0x0600065F RID: 1631
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x4EF0AE0", Offset = "0x4EEF6E0", VA = "0x184EF0AE0")]
		[PreserveSig]
		public static extern uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr);

		// Token: 0x06000660 RID: 1632
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x4EF0A00", Offset = "0x4EEF600", VA = "0x184EF0A00")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, [In] [Out] SteamItemDef_t[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength);

		// Token: 0x06000661 RID: 1633
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x4EF0890", Offset = "0x4EEF490", VA = "0x184EF0890")]
		[PreserveSig]
		public static extern bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice);

		// Token: 0x06000662 RID: 1634
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4EF18E0", Offset = "0x4EF04E0", VA = "0x184EF18E0")]
		[PreserveSig]
		public static extern ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr);

		// Token: 0x06000663 RID: 1635
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x4EF1050", Offset = "0x4EEFC50", VA = "0x184EF1050")]
		[PreserveSig]
		public static extern bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName);

		// Token: 0x06000664 RID: 1636
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x4EF16B0", Offset = "0x4EF02B0", VA = "0x184EF16B0")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, InteropHelp.UTF8StringHandle pchPropertyValue);

		// Token: 0x06000665 RID: 1637
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4EF1380", Offset = "0x4EEFF80", VA = "0x184EF1380")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, bool bValue);

		// Token: 0x06000666 RID: 1638
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x4EF15A0", Offset = "0x4EF01A0", VA = "0x184EF15A0")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, long nValue);

		// Token: 0x06000667 RID: 1639
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x4EF1490", Offset = "0x4EF0090", VA = "0x184EF1490")]
		[PreserveSig]
		public static extern bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, InteropHelp.UTF8StringHandle pchPropertyName, float flValue);

		// Token: 0x06000668 RID: 1640
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x4EF1960", Offset = "0x4EF0560", VA = "0x184EF1960")]
		[PreserveSig]
		public static extern bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle);

		// Token: 0x06000669 RID: 1641
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x4EF0EE0", Offset = "0x4EEFAE0", VA = "0x184EF0EE0")]
		[PreserveSig]
		public static extern bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, InteropHelp.UTF8StringHandle pchItemToken);

		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x4EF2EF0", Offset = "0x4EF1AF0", VA = "0x184EF2EF0")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		// Token: 0x0600066B RID: 1643
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x4EF2F70", Offset = "0x4EF1B70", VA = "0x184EF2F70")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		// Token: 0x0600066C RID: 1644
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x4EF2740", Offset = "0x4EF1340", VA = "0x184EF2740")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		// Token: 0x0600066D RID: 1645
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x4EF39C0", Offset = "0x4EF25C0", VA = "0x184EF39C0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		// Token: 0x0600066E RID: 1646
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x4EF3B20", Offset = "0x4EF2720", VA = "0x184EF3B20")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x4EF2C20", Offset = "0x4EF1820", VA = "0x184EF2C20")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4EF2AA0", Offset = "0x4EF16A0", VA = "0x184EF2AA0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		// Token: 0x06000671 RID: 1649
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x4EF29C0", Offset = "0x4EF15C0", VA = "0x184EF29C0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		// Token: 0x06000672 RID: 1650
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x4EF2930", Offset = "0x4EF1530", VA = "0x184EF2930")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		// Token: 0x06000673 RID: 1651
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x4EF28A0", Offset = "0x4EF14A0", VA = "0x184EF28A0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		// Token: 0x06000674 RID: 1652
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x4EF2B90", Offset = "0x4EF1790", VA = "0x184EF2B90")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		// Token: 0x06000675 RID: 1653
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4EF2810", Offset = "0x4EF1410", VA = "0x184EF2810")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000676 RID: 1654
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x4EF3050", Offset = "0x4EF1C50", VA = "0x184EF3050")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		// Token: 0x06000677 RID: 1655
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x4EF2D70", Offset = "0x4EF1970", VA = "0x184EF2D70")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		// Token: 0x06000678 RID: 1656
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x4EF38A0", Offset = "0x4EF24A0", VA = "0x184EF38A0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000679 RID: 1657
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x4EF3930", Offset = "0x4EF2530", VA = "0x184EF3930")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600067A RID: 1658
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x4EF3800", Offset = "0x4EF2400", VA = "0x184EF3800")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		// Token: 0x0600067B RID: 1659
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x4EF3770", Offset = "0x4EF2370", VA = "0x184EF3770")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600067C RID: 1660
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x4EF34C0", Offset = "0x4EF20C0", VA = "0x184EF34C0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		// Token: 0x0600067D RID: 1661
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x4EF3320", Offset = "0x4EF1F20", VA = "0x184EF3320")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600067E RID: 1662
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x4EF3D00", Offset = "0x4EF2900", VA = "0x184EF3D00")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x0600067F RID: 1663
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x4EF3290", Offset = "0x4EF1E90", VA = "0x184EF3290")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000680 RID: 1664
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x4EF31C0", Offset = "0x4EF1DC0", VA = "0x184EF31C0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		// Token: 0x06000681 RID: 1665
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x4EF2E10", Offset = "0x4EF1A10", VA = "0x184EF2E10")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000682 RID: 1666
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x4EF3560", Offset = "0x4EF2160", VA = "0x184EF3560")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x06000683 RID: 1667
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x4EF3FB0", Offset = "0x4EF2BB0", VA = "0x184EF3FB0")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x06000684 RID: 1668
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x4EF3BA0", Offset = "0x4EF27A0", VA = "0x184EF3BA0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		// Token: 0x06000685 RID: 1669
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x4EF30E0", Offset = "0x4EF1CE0", VA = "0x184EF30E0")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		// Token: 0x06000686 RID: 1670
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x4EF3A90", Offset = "0x4EF2690", VA = "0x184EF3A90")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x06000687 RID: 1671
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x4EF3E50", Offset = "0x4EF2A50", VA = "0x184EF3E50")]
		[PreserveSig]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		// Token: 0x06000688 RID: 1672
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x4EF3400", Offset = "0x4EF2000", VA = "0x184EF3400")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		// Token: 0x06000689 RID: 1673
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x4EF4100", Offset = "0x4EF2D00", VA = "0x184EF4100")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		// Token: 0x0600068A RID: 1674
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x4EF3650", Offset = "0x4EF2250", VA = "0x184EF3650")]
		[PreserveSig]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600068B RID: 1675
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x4EF4240", Offset = "0x4EF2E40", VA = "0x184EF4240")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		// Token: 0x0600068C RID: 1676
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x4EF3F10", Offset = "0x4EF2B10", VA = "0x184EF3F10")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable);

		// Token: 0x0600068D RID: 1677
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x4EF36E0", Offset = "0x4EF22E0", VA = "0x184EF36E0")]
		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		// Token: 0x0600068E RID: 1678
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x4EF41A0", Offset = "0x4EF2DA0", VA = "0x184EF41A0")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		// Token: 0x0600068F RID: 1679
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x4EF3C60", Offset = "0x4EF2860", VA = "0x184EF3C60")]
		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		// Token: 0x06000690 RID: 1680
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x4EF2490", Offset = "0x4EF1090", VA = "0x184EF2490")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000691 RID: 1681
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x4EF2540", Offset = "0x4EF1140", VA = "0x184EF2540")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x4EF2330", Offset = "0x4EF0F30", VA = "0x184EF2330")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x4EF2280", Offset = "0x4EF0E80", VA = "0x184EF2280")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x4EF23E0", Offset = "0x4EF0FE0", VA = "0x184EF23E0")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x4EF25E0", Offset = "0x4EF11E0", VA = "0x184EF25E0")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x4EF21F0", Offset = "0x4EF0DF0", VA = "0x184EF21F0")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x4EF1E30", Offset = "0x4EF0A30", VA = "0x184EF1E30")]
		[PreserveSig]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x4EF1C80", Offset = "0x4EF0880", VA = "0x184EF1C80")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x4EF20C0", Offset = "0x4EF0CC0", VA = "0x184EF20C0")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x4EF1ED0", Offset = "0x4EF0AD0", VA = "0x184EF1ED0")]
		[PreserveSig]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x4EF1DA0", Offset = "0x4EF09A0", VA = "0x184EF1DA0")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x4EF2150", Offset = "0x4EF0D50", VA = "0x184EF2150")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x4EF1F60", Offset = "0x4EF0B60", VA = "0x184EF1F60")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x0600069E RID: 1694
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x4EF2010", Offset = "0x4EF0C10", VA = "0x184EF2010")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x0600069F RID: 1695
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x4EF2690", Offset = "0x4EF1290", VA = "0x184EF2690")]
		[PreserveSig]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		// Token: 0x060006A0 RID: 1696
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x4EF1D10", Offset = "0x4EF0910", VA = "0x184EF1D10")]
		[PreserveSig]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		// Token: 0x060006A1 RID: 1697
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4EE8520", Offset = "0x4EE7120", VA = "0x184EE8520")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToFind, InteropHelp.UTF8StringHandle pchValuesToFind);

		// Token: 0x060006A2 RID: 1698
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x4EE8AF0", Offset = "0x4EE76F0", VA = "0x184EE8AF0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax);

		// Token: 0x060006A3 RID: 1699
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x4EE8A50", Offset = "0x4EE7650", VA = "0x184EE8A50")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax);

		// Token: 0x060006A4 RID: 1700
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x4EE84A0", Offset = "0x4EE70A0", VA = "0x184EE84A0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr);

		// Token: 0x060006A5 RID: 1701
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x4EE86E0", Offset = "0x4EE72E0", VA = "0x184EE86E0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr);

		// Token: 0x060006A6 RID: 1702
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x4EE89A0", Offset = "0x4EE75A0", VA = "0x184EE89A0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails);

		// Token: 0x060006A7 RID: 1703
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x4EE8760", Offset = "0x4EE7360", VA = "0x184EE8760")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr);

		// Token: 0x060006A8 RID: 1704
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x4EE8C80", Offset = "0x4EE7880", VA = "0x184EE8C80")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060006A9 RID: 1705
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x4EE8BA0", Offset = "0x4EE77A0", VA = "0x184EE8BA0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchConnectionDetails, int cubConnectionDetails);

		// Token: 0x060006AA RID: 1706
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x4EE8900", Offset = "0x4EE7500", VA = "0x184EE8900")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);

		// Token: 0x060006AB RID: 1707
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x4EE8870", Offset = "0x4EE7470", VA = "0x184EE8870")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID);

		// Token: 0x060006AC RID: 1708
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x4EE8660", Offset = "0x4EE7260", VA = "0x184EE8660")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr);

		// Token: 0x060006AD RID: 1709
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x4EE8DC0", Offset = "0x4EE79C0", VA = "0x184EE8DC0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult);

		// Token: 0x060006AE RID: 1710
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x4EE87E0", Offset = "0x4EE73E0", VA = "0x184EE87E0")]
		[PreserveSig]
		public static extern EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID);

		// Token: 0x060006AF RID: 1711
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x4EFB8E0", Offset = "0x4EFA4E0", VA = "0x184EFB8E0")]
		[PreserveSig]
		public static extern uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr);

		// Token: 0x060006B0 RID: 1712
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x4EFB6C0", Offset = "0x4EFA2C0", VA = "0x184EFB6C0")]
		[PreserveSig]
		public static extern ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex);

		// Token: 0x060006B1 RID: 1713
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x4EFB750", Offset = "0x4EFA350", VA = "0x184EFB750")]
		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata);

		// Token: 0x060006B2 RID: 1714
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x4EFB9F0", Offset = "0x4EFA5F0", VA = "0x184EFB9F0")]
		[PreserveSig]
		public static extern ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID);

		// Token: 0x060006B3 RID: 1715
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x4EFB960", Offset = "0x4EFA560", VA = "0x184EFB960")]
		[PreserveSig]
		public static extern bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations);

		// Token: 0x060006B4 RID: 1716
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x4EFB610", Offset = "0x4EFA210", VA = "0x184EFB610")]
		[PreserveSig]
		public static extern bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, [In] [Out] SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations);

		// Token: 0x060006B5 RID: 1717
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x4EFB410", Offset = "0x4EFA010", VA = "0x184EFB410")]
		[PreserveSig]
		public static extern ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, InteropHelp.UTF8StringHandle pchConnectString, InteropHelp.UTF8StringHandle pchMetadata);

		// Token: 0x060006B6 RID: 1718
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x4EFBA80", Offset = "0x4EFA680", VA = "0x184EFBA80")]
		[PreserveSig]
		public static extern void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		// Token: 0x060006B7 RID: 1719
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x4EFB2D0", Offset = "0x4EF9ED0", VA = "0x184EFB2D0")]
		[PreserveSig]
		public static extern void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser);

		// Token: 0x060006B8 RID: 1720
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x4EFB370", Offset = "0x4EF9F70", VA = "0x184EFB370")]
		[PreserveSig]
		public static extern ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots);

		// Token: 0x060006B9 RID: 1721
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x4EFB580", Offset = "0x4EFA180", VA = "0x184EFB580")]
		[PreserveSig]
		public static extern bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon);

		// Token: 0x060006BA RID: 1722
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x4EFB820", Offset = "0x4EFA420", VA = "0x184EFB820")]
		[PreserveSig]
		public static extern bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut);

		// Token: 0x060006BB RID: 1723
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x4EF5630", Offset = "0x4EF4230", VA = "0x184EF5630")]
		[PreserveSig]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		// Token: 0x060006BC RID: 1724
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x4EF56B0", Offset = "0x4EF42B0", VA = "0x184EF56B0")]
		[PreserveSig]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		// Token: 0x060006BD RID: 1725
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x4EF5730", Offset = "0x4EF4330", VA = "0x184EF5730")]
		[PreserveSig]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		// Token: 0x060006BE RID: 1726
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4EF59B0", Offset = "0x4EF45B0", VA = "0x184EF59B0")]
		[PreserveSig]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		// Token: 0x060006BF RID: 1727
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x4EF5830", Offset = "0x4EF4430", VA = "0x184EF5830")]
		[PreserveSig]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		// Token: 0x060006C0 RID: 1728
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x4EF5930", Offset = "0x4EF4530", VA = "0x184EF5930")]
		[PreserveSig]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		// Token: 0x060006C1 RID: 1729
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x4EF58B0", Offset = "0x4EF44B0", VA = "0x184EF58B0")]
		[PreserveSig]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		// Token: 0x060006C2 RID: 1730
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x4EF5A30", Offset = "0x4EF4630", VA = "0x184EF5A30")]
		[PreserveSig]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		// Token: 0x060006C3 RID: 1731
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x4EF57B0", Offset = "0x4EF43B0", VA = "0x184EF57B0")]
		[PreserveSig]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		// Token: 0x060006C4 RID: 1732
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x4EF4B60", Offset = "0x4EF3760", VA = "0x184EF4B60")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x060006C5 RID: 1733
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x4EF4580", Offset = "0x4EF3180", VA = "0x184EF4580")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		// Token: 0x060006C6 RID: 1734
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x4EF4370", Offset = "0x4EF2F70", VA = "0x184EF4370")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		// Token: 0x060006C7 RID: 1735
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x4EF42E0", Offset = "0x4EF2EE0", VA = "0x184EF42E0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue);

		// Token: 0x060006C8 RID: 1736
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x4EF4E60", Offset = "0x4EF3A60", VA = "0x184EF4E60")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		// Token: 0x060006C9 RID: 1737
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x4EF4F40", Offset = "0x4EF3B40", VA = "0x184EF4F40")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x060006CA RID: 1738
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x4EF4720", Offset = "0x4EF3320", VA = "0x184EF4720")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue);

		// Token: 0x060006CB RID: 1739
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x4EF4690", Offset = "0x4EF3290", VA = "0x184EF4690")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue);

		// Token: 0x060006CC RID: 1740
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x4EF48D0", Offset = "0x4EF34D0", VA = "0x184EF48D0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue);

		// Token: 0x060006CD RID: 1741
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x4EF4600", Offset = "0x4EF3200", VA = "0x184EF4600")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue);

		// Token: 0x060006CE RID: 1742
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x4EF4840", Offset = "0x4EF3440", VA = "0x184EF4840")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue);

		// Token: 0x060006CF RID: 1743
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x4EF47B0", Offset = "0x4EF33B0", VA = "0x184EF47B0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue);

		// Token: 0x060006D0 RID: 1744
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x4EF5480", Offset = "0x4EF4080", VA = "0x184EF5480")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		// Token: 0x060006D1 RID: 1745
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x4EF5510", Offset = "0x4EF4110", VA = "0x184EF5510")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue);

		// Token: 0x060006D2 RID: 1746
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x4EF53F0", Offset = "0x4EF3FF0", VA = "0x184EF53F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue);

		// Token: 0x060006D3 RID: 1747
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x4EF55A0", Offset = "0x4EF41A0", VA = "0x184EF55A0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		// Token: 0x060006D4 RID: 1748
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x4EF4500", Offset = "0x4EF3100", VA = "0x184EF4500")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		// Token: 0x060006D5 RID: 1749
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x4EF4470", Offset = "0x4EF3070", VA = "0x184EF4470")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable);

		// Token: 0x060006D6 RID: 1750
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x4EF5310", Offset = "0x4EF3F10", VA = "0x184EF5310")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		// Token: 0x060006D7 RID: 1751
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x4EF5280", Offset = "0x4EF3E80", VA = "0x184EF5280")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		// Token: 0x060006D8 RID: 1752
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x4EF51D0", Offset = "0x4EF3DD0", VA = "0x184EF51D0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		// Token: 0x060006D9 RID: 1753
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x4EF43F0", Offset = "0x4EF2FF0", VA = "0x184EF43F0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		// Token: 0x060006DA RID: 1754
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x4EF4AE0", Offset = "0x4EF36E0", VA = "0x184EF4AE0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		// Token: 0x060006DB RID: 1755
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x4EF4CC0", Offset = "0x4EF38C0", VA = "0x184EF4CC0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		// Token: 0x060006DC RID: 1756
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x4EF50E0", Offset = "0x4EF3CE0", VA = "0x184EF50E0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060006DD RID: 1757
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x4EF4DD0", Offset = "0x4EF39D0", VA = "0x184EF4DD0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		// Token: 0x060006DE RID: 1758
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x4EF4A60", Offset = "0x4EF3660", VA = "0x184EF4A60")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		// Token: 0x060006DF RID: 1759
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x4EF49E0", Offset = "0x4EF35E0", VA = "0x184EF49E0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		// Token: 0x060006E0 RID: 1760
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x4EF4C40", Offset = "0x4EF3840", VA = "0x184EF4C40")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		// Token: 0x060006E1 RID: 1761
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x4EF4FF0", Offset = "0x4EF3BF0", VA = "0x184EF4FF0")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		// Token: 0x060006E2 RID: 1762
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x4EF4D40", Offset = "0x4EF3940", VA = "0x184EF4D40")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		// Token: 0x060006E3 RID: 1763
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x4EF4960", Offset = "0x4EF3560", VA = "0x184EF4960")]
		[PreserveSig]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		// Token: 0x060006E4 RID: 1764
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x4EFAEC0", Offset = "0x4EF9AC0", VA = "0x184EFAEC0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		// Token: 0x060006E5 RID: 1765
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x4EFAB00", Offset = "0x4EF9700", VA = "0x184EFAB00")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		// Token: 0x060006E6 RID: 1766
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x4EFABA0", Offset = "0x4EF97A0", VA = "0x184EFABA0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		// Token: 0x060006E7 RID: 1767
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x4EFA090", Offset = "0x4EF8C90", VA = "0x184EFA090")]
		[PreserveSig]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060006E8 RID: 1768
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x4EFA250", Offset = "0x4EF8E50", VA = "0x184EFA250")]
		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		// Token: 0x060006E9 RID: 1769
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x4EFA1B0", Offset = "0x4EF8DB0", VA = "0x184EFA1B0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		// Token: 0x060006EA RID: 1770
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x4EFA7B0", Offset = "0x4EF93B0", VA = "0x184EFA7B0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		// Token: 0x060006EB RID: 1771
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x4EFA120", Offset = "0x4EF8D20", VA = "0x184EFA120")]
		[PreserveSig]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow);

		// Token: 0x060006EC RID: 1772
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x4EFA3A0", Offset = "0x4EF8FA0", VA = "0x184EFA3A0")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		// Token: 0x060006ED RID: 1773
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x4EFA470", Offset = "0x4EF9070", VA = "0x184EFA470")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		// Token: 0x060006EE RID: 1774
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x4EFA2E0", Offset = "0x4EF8EE0", VA = "0x184EFA2E0")]
		[PreserveSig]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec);

		// Token: 0x060006EF RID: 1775
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x4EFA5D0", Offset = "0x4EF91D0", VA = "0x184EFA5D0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		// Token: 0x060006F0 RID: 1776
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x4EFA530", Offset = "0x4EF9130", VA = "0x184EFA530")]
		[PreserveSig]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		// Token: 0x060006F1 RID: 1777
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x4EFAE00", Offset = "0x4EF9A00", VA = "0x184EFAE00")]
		[PreserveSig]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable);

		// Token: 0x060006F2 RID: 1778
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x4EFA9B0", Offset = "0x4EF95B0", VA = "0x184EFA9B0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		// Token: 0x060006F3 RID: 1779
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x4EFAC70", Offset = "0x4EF9870", VA = "0x184EFAC70")]
		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		// Token: 0x060006F4 RID: 1780
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x4EFAA50", Offset = "0x4EF9650", VA = "0x184EFAA50")]
		[PreserveSig]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060006F5 RID: 1781
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x4EFAD30", Offset = "0x4EF9930", VA = "0x184EFAD30")]
		[PreserveSig]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		// Token: 0x060006F6 RID: 1782
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x4EFA8E0", Offset = "0x4EF94E0", VA = "0x184EFA8E0")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote);

		// Token: 0x060006F7 RID: 1783
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x4EFA670", Offset = "0x4EF9270", VA = "0x184EFA670")]
		[PreserveSig]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort);

		// Token: 0x060006F8 RID: 1784
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x4EFA850", Offset = "0x4EF9450", VA = "0x184EFA850")]
		[PreserveSig]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060006F9 RID: 1785
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x4EFA720", Offset = "0x4EF9320", VA = "0x184EFA720")]
		[PreserveSig]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		// Token: 0x060006FA RID: 1786
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x4EF5F30", Offset = "0x4EF4B30", VA = "0x184EF5F30")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel);

		// Token: 0x060006FB RID: 1787
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x4EF5E80", Offset = "0x4EF4A80", VA = "0x184EF5E80")]
		[PreserveSig]
		public static extern int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x060006FC RID: 1788
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x4EF5AC0", Offset = "0x4EF46C0", VA = "0x184EF5AC0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		// Token: 0x060006FD RID: 1789
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x4EF5BF0", Offset = "0x4EF47F0", VA = "0x184EF5BF0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote);

		// Token: 0x060006FE RID: 1790
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x4EF5B50", Offset = "0x4EF4750", VA = "0x184EF5B50")]
		[PreserveSig]
		public static extern bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel);

		// Token: 0x060006FF RID: 1791
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x4EF5C80", Offset = "0x4EF4880", VA = "0x184EF5C80")]
		[PreserveSig]
		public static extern ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus);

		// Token: 0x06000700 RID: 1792
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x4EF6810", Offset = "0x4EF5410", VA = "0x184EF6810")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000701 RID: 1793
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x4EF6380", Offset = "0x4EF4F80", VA = "0x184EF6380")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000702 RID: 1794
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x4EF69C0", Offset = "0x4EF55C0", VA = "0x184EF69C0")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000703 RID: 1795
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x4EF6550", Offset = "0x4EF5150", VA = "0x184EF6550")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000704 RID: 1796
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x4EF5FF0", Offset = "0x4EF4BF0", VA = "0x184EF5FF0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		// Token: 0x06000705 RID: 1797
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x4EF6110", Offset = "0x4EF4D10", VA = "0x184EF6110")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, InteropHelp.UTF8StringHandle pszDebug, bool bEnableLinger);

		// Token: 0x06000706 RID: 1798
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x4EF6220", Offset = "0x4EF4E20", VA = "0x184EF6220")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket);

		// Token: 0x06000707 RID: 1799
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4EF88B0", Offset = "0x4EF74B0", VA = "0x184EF88B0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData);

		// Token: 0x06000708 RID: 1800
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x4EF76D0", Offset = "0x4EF62D0", VA = "0x184EF76D0")]
		[PreserveSig]
		public static extern long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer);

		// Token: 0x06000709 RID: 1801
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x4EF8730", Offset = "0x4EF7330", VA = "0x184EF8730")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, InteropHelp.UTF8StringHandle pszName);

		// Token: 0x0600070A RID: 1802
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x4EF7250", Offset = "0x4EF5E50", VA = "0x184EF7250")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen);

		// Token: 0x0600070B RID: 1803
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x4EF84B0", Offset = "0x4EF70B0", VA = "0x184EF84B0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber);

		// Token: 0x0600070C RID: 1804
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x4EF8570", Offset = "0x4EF7170", VA = "0x184EF8570")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, [In] [Out] IntPtr[] pMessages, [In] [Out] long[] pOutMessageNumberOrResult);

		// Token: 0x0600070D RID: 1805
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x4EF6DE0", Offset = "0x4EF59E0", VA = "0x184EF6DE0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn);

		// Token: 0x0600070E RID: 1806
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x4EF7FF0", Offset = "0x4EF6BF0", VA = "0x184EF7FF0")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x0600070F RID: 1807
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x4EF70D0", Offset = "0x4EF5CD0", VA = "0x184EF70D0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo);

		// Token: 0x06000710 RID: 1808
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x4EF7300", Offset = "0x4EF5F00", VA = "0x184EF7300")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetConnectionRealTimeStatus(IntPtr instancePtr, HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes);

		// Token: 0x06000711 RID: 1809
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x4EF7760", Offset = "0x4EF6360", VA = "0x184EF7760")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf);

		// Token: 0x06000712 RID: 1810
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x4EF7DB0", Offset = "0x4EF69B0", VA = "0x184EF7DB0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address);

		// Token: 0x06000713 RID: 1811
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x4EF6AF0", Offset = "0x4EF56F0", VA = "0x184EF6AF0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2);

		// Token: 0x06000714 RID: 1812
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x4EF62B0", Offset = "0x4EF4EB0", VA = "0x184EF62B0")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_ConfigureConnectionLanes(IntPtr instancePtr, HSteamNetConnection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights);

		// Token: 0x06000715 RID: 1813
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x4EF7D20", Offset = "0x4EF6920", VA = "0x184EF7D20")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity);

		// Token: 0x06000716 RID: 1814
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x4EF7F70", Offset = "0x4EF6B70", VA = "0x184EF7F70")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr);

		// Token: 0x06000717 RID: 1815
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x4EF6E70", Offset = "0x4EF5A70", VA = "0x184EF6E70")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails);

		// Token: 0x06000718 RID: 1816
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x4EF6A70", Offset = "0x4EF5670", VA = "0x184EF6A70")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr);

		// Token: 0x06000719 RID: 1817
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x4EF6BC0", Offset = "0x4EF57C0", VA = "0x184EF6BC0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup);

		// Token: 0x0600071A RID: 1818
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x4EF8810", Offset = "0x4EF7410", VA = "0x184EF8810")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup);

		// Token: 0x0600071B RID: 1819
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x4EF80A0", Offset = "0x4EF6CA0", VA = "0x184EF80A0")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, [In] [Out] IntPtr[] ppOutMessages, int nMaxMessages);

		// Token: 0x0600071C RID: 1820
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x4EF8200", Offset = "0x4EF6E00", VA = "0x184EF8200")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		// Token: 0x0600071D RID: 1821
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x4EF6C50", Offset = "0x4EF5850", VA = "0x184EF6C50")]
		[PreserveSig]
		public static extern int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket);

		// Token: 0x0600071E RID: 1822
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x4EF6610", Offset = "0x4EF5210", VA = "0x184EF6610")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x0600071F RID: 1823
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x4EF7CA0", Offset = "0x4EF68A0", VA = "0x184EF7CA0")]
		[PreserveSig]
		public static extern ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr);

		// Token: 0x06000720 RID: 1824
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x4EF7C20", Offset = "0x4EF6820", VA = "0x184EF7C20")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr);

		// Token: 0x06000721 RID: 1825
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x4EF7B10", Offset = "0x4EF6710", VA = "0x184EF7B10")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting);

		// Token: 0x06000722 RID: 1826
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x4EF6760", Offset = "0x4EF5360", VA = "0x184EF6760")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000723 RID: 1827
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x4EF7A60", Offset = "0x4EF6660", VA = "0x184EF7A60")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob);

		// Token: 0x06000724 RID: 1828
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x4EF6480", Offset = "0x4EF5080", VA = "0x184EF6480")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x06000725 RID: 1829
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x4EF8150", Offset = "0x4EF6D50", VA = "0x184EF8150")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext);

		// Token: 0x06000726 RID: 1830
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x4EF6FD0", Offset = "0x4EF5BD0", VA = "0x184EF6FD0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg);

		// Token: 0x06000727 RID: 1831
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x4EF8630", Offset = "0x4EF7230", VA = "0x184EF8630")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg);

		// Token: 0x06000728 RID: 1832
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x4EF83A0", Offset = "0x4EF6FA0", VA = "0x184EF83A0")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_ResetIdentity(IntPtr instancePtr, ref SteamNetworkingIdentity pIdentity);

		// Token: 0x06000729 RID: 1833
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x4EF8430", Offset = "0x4EF7030", VA = "0x184EF8430")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr);

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x4EF6080", Offset = "0x4EF4C80", VA = "0x184EF6080")]
		[PreserveSig]
		public static extern bool ISteamNetworkingSockets_BeginAsyncRequestFakeIP(IntPtr instancePtr, int nNumPorts);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x4EF7800", Offset = "0x4EF6400", VA = "0x184EF7800")]
		[PreserveSig]
		public static extern void ISteamNetworkingSockets_GetFakeIP(IntPtr instancePtr, int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo);

		// Token: 0x0600072C RID: 1836
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x4EF6910", Offset = "0x4EF5510", VA = "0x184EF6910")]
		[PreserveSig]
		public static extern uint ISteamNetworkingSockets_CreateListenSocketP2PFakeIP(IntPtr instancePtr, int idxFakePort, int nOptions, [In] [Out] SteamNetworkingConfigValue_t[] pOptions);

		// Token: 0x0600072D RID: 1837
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x4EF7E90", Offset = "0x4EF6A90", VA = "0x184EF7E90")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingSockets_GetRemoteFakeIPForConnection(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr);

		// Token: 0x0600072E RID: 1838
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x4EF66D0", Offset = "0x4EF52D0", VA = "0x184EF66D0")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingSockets_CreateFakeUDPPort(IntPtr instancePtr, int idxFakeServerPort);

		// Token: 0x0600072F RID: 1839
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x4EF8950", Offset = "0x4EF7550", VA = "0x184EF8950")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer);

		// Token: 0x06000730 RID: 1840
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x4EF9790", Offset = "0x4EF8390", VA = "0x184EF9790")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr);

		// Token: 0x06000731 RID: 1841
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x4EF9600", Offset = "0x4EF8200", VA = "0x184EF9600")]
		[PreserveSig]
		public static extern ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails);

		// Token: 0x06000732 RID: 1842
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4EF91D0", Offset = "0x4EF7DD0", VA = "0x184EF91D0")]
		[PreserveSig]
		public static extern float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result);

		// Token: 0x06000733 RID: 1843
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4EF8BD0", Offset = "0x4EF77D0", VA = "0x184EF8BD0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2);

		// Token: 0x06000734 RID: 1844
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4EF8DF0", Offset = "0x4EF79F0", VA = "0x184EF8DF0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation);

		// Token: 0x06000735 RID: 1845
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4EF8A70", Offset = "0x4EF7670", VA = "0x184EF8A70")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize);

		// Token: 0x06000736 RID: 1846
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4EF9940", Offset = "0x4EF8540", VA = "0x184EF9940")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszString, out SteamNetworkPingLocation_t result);

		// Token: 0x06000737 RID: 1847
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4EF89E0", Offset = "0x4EF75E0", VA = "0x184EF89E0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds);

		// Token: 0x06000738 RID: 1848
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4EF9470", Offset = "0x4EF8070", VA = "0x184EF9470")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP);

		// Token: 0x06000739 RID: 1849
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x4EF90B0", Offset = "0x4EF7CB0", VA = "0x184EF90B0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID);

		// Token: 0x0600073A RID: 1850
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x4EF9350", Offset = "0x4EF7F50", VA = "0x184EF9350")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr);

		// Token: 0x0600073B RID: 1851
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x4EF93D0", Offset = "0x4EF7FD0", VA = "0x184EF93D0")]
		[PreserveSig]
		public static extern int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz);

		// Token: 0x0600073C RID: 1852
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4EF92D0", Offset = "0x4EF7ED0", VA = "0x184EF92D0")]
		[PreserveSig]
		public static extern long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr);

		// Token: 0x0600073D RID: 1853
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4EF9B40", Offset = "0x4EF8740", VA = "0x184EF9B40")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc);

		// Token: 0x0600073E RID: 1854
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4EF9810", Offset = "0x4EF8410", VA = "0x184EF9810")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_IsFakeIPv4(IntPtr instancePtr, uint nIPv4);

		// Token: 0x0600073F RID: 1855
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x4EF9140", Offset = "0x4EF7D40", VA = "0x184EF9140")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_GetIPv4FakeIPType(IntPtr instancePtr, uint nIPv4);

		// Token: 0x06000740 RID: 1856
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x4EF9510", Offset = "0x4EF8110", VA = "0x184EF9510")]
		[PreserveSig]
		public static extern EResult ISteamNetworkingUtils_GetRealIdentityForFakeIP(IntPtr instancePtr, ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity);

		// Token: 0x06000741 RID: 1857
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x4EF9A80", Offset = "0x4EF8680", VA = "0x184EF9A80")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg);

		// Token: 0x06000742 RID: 1858
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x4EF8FE0", Offset = "0x4EF7BE0", VA = "0x184EF8FE0")]
		[PreserveSig]
		public static extern ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult);

		// Token: 0x06000743 RID: 1859
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x4EF8F40", Offset = "0x4EF7B40", VA = "0x184EF8F40")]
		[PreserveSig]
		public static extern IntPtr ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope);

		// Token: 0x06000744 RID: 1860
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4EF98A0", Offset = "0x4EF84A0", VA = "0x184EF98A0")]
		[PreserveSig]
		public static extern ESteamNetworkingConfigValue ISteamNetworkingUtils_IterateGenericEditableConfigValues(IntPtr instancePtr, ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars);

		// Token: 0x06000745 RID: 1861
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4EF9DF0", Offset = "0x4EF89F0", VA = "0x184EF9DF0")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort);

		// Token: 0x06000746 RID: 1862
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x4EF9CC0", Offset = "0x4EF88C0", VA = "0x184EF9CC0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x06000747 RID: 1863
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x4EF9BE0", Offset = "0x4EF87E0", VA = "0x184EF9BE0")]
		[PreserveSig]
		public static extern ESteamNetworkingFakeIPType ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType(IntPtr instancePtr, ref SteamNetworkingIPAddr addr);

		// Token: 0x06000748 RID: 1864
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x4EF9FE0", Offset = "0x4EF8BE0", VA = "0x184EF9FE0")]
		[PreserveSig]
		public static extern void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf);

		// Token: 0x06000749 RID: 1865
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x4EF9EF0", Offset = "0x4EF8AF0", VA = "0x184EF9EF0")]
		[PreserveSig]
		public static extern bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, InteropHelp.UTF8StringHandle pszStr);

		// Token: 0x0600074A RID: 1866
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x4EFB1D0", Offset = "0x4EF9DD0", VA = "0x184EFB1D0")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		// Token: 0x0600074B RID: 1867
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x4EFB250", Offset = "0x4EF9E50", VA = "0x184EFB250")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		// Token: 0x0600074C RID: 1868
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x4EFAF90", Offset = "0x4EF9B90", VA = "0x184EFAF90")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600074D RID: 1869
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x4EFB020", Offset = "0x4EF9C20", VA = "0x184EFB020")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		// Token: 0x0600074E RID: 1870
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4EFB0B0", Offset = "0x4EF9CB0", VA = "0x184EFB0B0")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x0600074F RID: 1871
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x4EFB140", Offset = "0x4EF9D40", VA = "0x184EFB140")]
		[PreserveSig]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		// Token: 0x06000750 RID: 1872
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4EFBE10", Offset = "0x4EFAA10", VA = "0x184EFBE10")]
		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr);

		// Token: 0x06000751 RID: 1873
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4EFBE90", Offset = "0x4EFAA90", VA = "0x184EFBE90")]
		[PreserveSig]
		public static extern uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex);

		// Token: 0x06000752 RID: 1874
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4EFBF20", Offset = "0x4EFAB20", VA = "0x184EFBF20")]
		[PreserveSig]
		public static extern ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x06000753 RID: 1875
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4EFBD80", Offset = "0x4EFA980", VA = "0x184EFBD80")]
		[PreserveSig]
		public static extern IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x06000754 RID: 1876
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4EFBCF0", Offset = "0x4EFA8F0", VA = "0x184EFBCF0")]
		[PreserveSig]
		public static extern ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID);

		// Token: 0x06000755 RID: 1877
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4EFBB20", Offset = "0x4EFA720", VA = "0x184EFBB20")]
		[PreserveSig]
		public static extern bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY);

		// Token: 0x06000756 RID: 1878
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4EFBC60", Offset = "0x4EFA860", VA = "0x184EFBC60")]
		[PreserveSig]
		public static extern bool ISteamRemotePlay_BStartRemotePlayTogether(IntPtr instancePtr, bool bShowOverlay);

		// Token: 0x06000757 RID: 1879
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4EFBBD0", Offset = "0x4EFA7D0", VA = "0x184EFBBD0")]
		[PreserveSig]
		public static extern bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend);

		// Token: 0x06000758 RID: 1880
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4EFD080", Offset = "0x4EFBC80", VA = "0x184EFD080")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		// Token: 0x06000759 RID: 1881
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x4EFCAE0", Offset = "0x4EFB6E0", VA = "0x184EFCAE0")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		// Token: 0x0600075A RID: 1882
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x4EFCCC0", Offset = "0x4EFB8C0", VA = "0x184EFCCC0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		// Token: 0x0600075B RID: 1883
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4EFC9F0", Offset = "0x4EFB5F0", VA = "0x184EFC9F0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		// Token: 0x0600075C RID: 1884
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x4EFC930", Offset = "0x4EFB530", VA = "0x184EFC930")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		// Token: 0x0600075D RID: 1885
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x4EFC770", Offset = "0x4EFB370", VA = "0x184EFC770")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x0600075E RID: 1886
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4EFC5B0", Offset = "0x4EFB1B0", VA = "0x184EFC5B0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x0600075F RID: 1887
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x4EFCBE0", Offset = "0x4EFB7E0", VA = "0x184EFCBE0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000760 RID: 1888
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x4EFE1B0", Offset = "0x4EFCDB0", VA = "0x184EFE1B0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		// Token: 0x06000761 RID: 1889
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x4EFCEE0", Offset = "0x4EFBAE0", VA = "0x184EFCEE0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000762 RID: 1890
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4EFCFC0", Offset = "0x4EFBBC0", VA = "0x184EFCFC0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		// Token: 0x06000763 RID: 1891
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4EFCE50", Offset = "0x4EFBA50", VA = "0x184EFCE50")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x06000764 RID: 1892
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4EFCDC0", Offset = "0x4EFB9C0", VA = "0x184EFCDC0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		// Token: 0x06000765 RID: 1893
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4EFC690", Offset = "0x4EFB290", VA = "0x184EFC690")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000766 RID: 1894
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4EFC850", Offset = "0x4EFB450", VA = "0x184EFC850")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000767 RID: 1895
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4EFD3B0", Offset = "0x4EFBFB0", VA = "0x184EFD3B0")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000768 RID: 1896
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x4EFD480", Offset = "0x4EFC080", VA = "0x184EFD480")]
		[PreserveSig]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000769 RID: 1897
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x4EFD850", Offset = "0x4EFC450", VA = "0x184EFD850")]
		[PreserveSig]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x0600076A RID: 1898
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x4EFD290", Offset = "0x4EFBE90", VA = "0x184EFD290")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		// Token: 0x0600076B RID: 1899
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4EFD310", Offset = "0x4EFBF10", VA = "0x184EFD310")]
		[PreserveSig]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		// Token: 0x0600076C RID: 1900
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4EFD7B0", Offset = "0x4EFC3B0", VA = "0x184EFD7B0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		// Token: 0x0600076D RID: 1901
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4EFDB30", Offset = "0x4EFC730", VA = "0x184EFDB30")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		// Token: 0x0600076E RID: 1902
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4EFDBB0", Offset = "0x4EFC7B0", VA = "0x184EFDBB0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		// Token: 0x0600076F RID: 1903
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4EFE120", Offset = "0x4EFCD20", VA = "0x184EFE120")]
		[PreserveSig]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled);

		// Token: 0x06000770 RID: 1904
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x4EFE4C0", Offset = "0x4EFD0C0", VA = "0x184EFE4C0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		// Token: 0x06000771 RID: 1905
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x4EFD9F0", Offset = "0x4EFC5F0", VA = "0x184EFD9F0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		// Token: 0x06000772 RID: 1906
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4EFD920", Offset = "0x4EFC520", VA = "0x184EFD920")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		// Token: 0x06000773 RID: 1907
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x4EFE560", Offset = "0x4EFD160", VA = "0x184EFE560")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		// Token: 0x06000774 RID: 1908
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x4EFD180", Offset = "0x4EFBD80", VA = "0x184EFD180")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		// Token: 0x06000775 RID: 1909
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x4EFD200", Offset = "0x4EFBE00", VA = "0x184EFD200")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		// Token: 0x06000776 RID: 1910
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x4EFDEC0", Offset = "0x4EFCAC0", VA = "0x184EFDEC0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		// Token: 0x06000777 RID: 1911
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x4EFC0C0", Offset = "0x4EFACC0", VA = "0x184EFC0C0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000778 RID: 1912
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4EFE7A0", Offset = "0x4EFD3A0", VA = "0x184EFE7A0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		// Token: 0x06000779 RID: 1913
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4EFE880", Offset = "0x4EFD480", VA = "0x184EFE880")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		// Token: 0x0600077A RID: 1914
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x4EFEAE0", Offset = "0x4EFD6E0", VA = "0x184EFEAE0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x0600077B RID: 1915
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4EFE6C0", Offset = "0x4EFD2C0", VA = "0x184EFE6C0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x0600077C RID: 1916
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x4EFEBC0", Offset = "0x4EFD7C0", VA = "0x184EFEBC0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x0600077D RID: 1917
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4EFEA40", Offset = "0x4EFD640", VA = "0x184EFEA40")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		// Token: 0x0600077E RID: 1918
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x4EFC030", Offset = "0x4EFAC30", VA = "0x184EFC030")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		// Token: 0x0600077F RID: 1919
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x4EFD680", Offset = "0x4EFC280", VA = "0x184EFD680")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		// Token: 0x06000780 RID: 1920
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x4EFC150", Offset = "0x4EFAD50", VA = "0x184EFC150")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000781 RID: 1921
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4EFC3D0", Offset = "0x4EFAFD0", VA = "0x184EFC3D0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x06000782 RID: 1922
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x4EFE340", Offset = "0x4EFCF40", VA = "0x184EFE340")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000783 RID: 1923
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4EFC520", Offset = "0x4EFB120", VA = "0x184EFC520")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		// Token: 0x06000784 RID: 1924
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x4EFE630", Offset = "0x4EFD230", VA = "0x184EFE630")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000785 RID: 1925
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4EFE960", Offset = "0x4EFD560", VA = "0x184EFE960")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		// Token: 0x06000786 RID: 1926
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x4EFD720", Offset = "0x4EFC320", VA = "0x184EFD720")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000787 RID: 1927
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x4EFEC60", Offset = "0x4EFD860", VA = "0x184EFEC60")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp);

		// Token: 0x06000788 RID: 1928
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x4EFDAA0", Offset = "0x4EFC6A0", VA = "0x184EFDAA0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		// Token: 0x06000789 RID: 1929
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x4EFC460", Offset = "0x4EFB060", VA = "0x184EFC460")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		// Token: 0x0600078A RID: 1930
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x4EFDC30", Offset = "0x4EFC830", VA = "0x184EFDC30")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		// Token: 0x0600078B RID: 1931
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x4EFE2A0", Offset = "0x4EFCEA0", VA = "0x184EFE2A0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		// Token: 0x0600078C RID: 1932
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x4EFC260", Offset = "0x4EFAE60", VA = "0x184EFC260")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		// Token: 0x0600078D RID: 1933
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x4EFC300", Offset = "0x4EFAF00", VA = "0x184EFC300")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		// Token: 0x0600078E RID: 1934
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x4EFE3D0", Offset = "0x4EFCFD0", VA = "0x184EFE3D0")]
		[PreserveSig]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		// Token: 0x0600078F RID: 1935
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x4EFD560", Offset = "0x4EFC160", VA = "0x184EFD560")]
		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetLocalFileChangeCount(IntPtr instancePtr);

		// Token: 0x06000790 RID: 1936
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x4EFD5E0", Offset = "0x4EFC1E0", VA = "0x184EFD5E0")]
		[PreserveSig]
		public static extern IntPtr ISteamRemoteStorage_GetLocalFileChange(IntPtr instancePtr, int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType);

		// Token: 0x06000791 RID: 1937
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x4EFBFB0", Offset = "0x4EFABB0", VA = "0x184EFBFB0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_BeginFileWriteBatch(IntPtr instancePtr);

		// Token: 0x06000792 RID: 1938
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x4EFC1E0", Offset = "0x4EFADE0", VA = "0x184EFC1E0")]
		[PreserveSig]
		public static extern bool ISteamRemoteStorage_EndFileWriteBatch(IntPtr instancePtr);

		// Token: 0x06000793 RID: 1939
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x4EFF360", Offset = "0x4EFDF60", VA = "0x184EFF360")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		// Token: 0x06000794 RID: 1940
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x4EFED00", Offset = "0x4EFD900", VA = "0x184EFED00")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		// Token: 0x06000795 RID: 1941
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4EFF2E0", Offset = "0x4EFDEE0", VA = "0x184EFF2E0")]
		[PreserveSig]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		// Token: 0x06000796 RID: 1942
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x4EFEFB0", Offset = "0x4EFDBB0", VA = "0x184EFEFB0")]
		[PreserveSig]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook);

		// Token: 0x06000797 RID: 1943
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x4EFF0C0", Offset = "0x4EFDCC0", VA = "0x184EFF0C0")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		// Token: 0x06000798 RID: 1944
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x4EFF240", Offset = "0x4EFDE40", VA = "0x184EFF240")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		// Token: 0x06000799 RID: 1945
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x4EFF1A0", Offset = "0x4EFDDA0", VA = "0x184EFF1A0")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		// Token: 0x0600079A RID: 1946
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x4EFF040", Offset = "0x4EFDC40", VA = "0x184EFF040")]
		[PreserveSig]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		// Token: 0x0600079B RID: 1947
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4EFEE60", Offset = "0x4EFDA60", VA = "0x184EFEE60")]
		[PreserveSig]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		// Token: 0x0600079C RID: 1948
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4EFF720", Offset = "0x4EFE320", VA = "0x184EFF720")]
		[PreserveSig]
		public static extern void ISteamTimeline_SetTimelineStateDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDescription, float flTimeDelta);

		// Token: 0x0600079D RID: 1949
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x4EFF600", Offset = "0x4EFE200", VA = "0x184EFF600")]
		[PreserveSig]
		public static extern void ISteamTimeline_ClearTimelineStateDescription(IntPtr instancePtr, float flTimeDelta);

		// Token: 0x0600079E RID: 1950
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x4EFF420", Offset = "0x4EFE020", VA = "0x184EFF420")]
		[PreserveSig]
		public static extern void ISteamTimeline_AddTimelineEvent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchIcon, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip);

		// Token: 0x0600079F RID: 1951
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4EFF690", Offset = "0x4EFE290", VA = "0x184EFF690")]
		[PreserveSig]
		public static extern void ISteamTimeline_SetTimelineGameMode(IntPtr instancePtr, ETimelineGameMode eMode);

		// Token: 0x060007A0 RID: 1952
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4F00550", Offset = "0x4EFF150", VA = "0x184F00550")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x060007A1 RID: 1953
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x4F003F0", Offset = "0x4EFEFF0", VA = "0x184F003F0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		// Token: 0x060007A2 RID: 1954
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x4F002D0", Offset = "0x4EFEED0", VA = "0x184F002D0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, InteropHelp.UTF8StringHandle pchCursor);

		// Token: 0x060007A3 RID: 1955
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x4F004B0", Offset = "0x4EFF0B0", VA = "0x184F004B0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x060007A4 RID: 1956
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x4F02050", Offset = "0x4F00C50", VA = "0x184F02050")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x060007A5 RID: 1957
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x4F01390", Offset = "0x4EFFF90", VA = "0x184F01390")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		// Token: 0x060007A6 RID: 1958
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x4F01230", Offset = "0x4EFFE30", VA = "0x184F01230")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x060007A7 RID: 1959
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x4F016A0", Offset = "0x4F002A0", VA = "0x184F016A0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		// Token: 0x060007A8 RID: 1960
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x4F015D0", Offset = "0x4F001D0", VA = "0x184F015D0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize);

		// Token: 0x060007A9 RID: 1961
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x4F012D0", Offset = "0x4EFFED0", VA = "0x184F012D0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		// Token: 0x060007AA RID: 1962
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x4F01030", Offset = "0x4EFFC30", VA = "0x184F01030")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		// Token: 0x060007AB RID: 1963
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x4F00DD0", Offset = "0x4EFF9D0", VA = "0x184F00DD0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x060007AC RID: 1964
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x4F01510", Offset = "0x4F00110", VA = "0x184F01510")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		// Token: 0x060007AD RID: 1965
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x4F010F0", Offset = "0x4EFFCF0", VA = "0x184F010F0")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x060007AE RID: 1966
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x4F00CE0", Offset = "0x4EFF8E0", VA = "0x184F00CE0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		// Token: 0x060007AF RID: 1967
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x4F01190", Offset = "0x4EFFD90", VA = "0x184F01190")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x060007B0 RID: 1968
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4F00F50", Offset = "0x4EFFB50", VA = "0x184F00F50")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		// Token: 0x060007B1 RID: 1969
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x4F00BC0", Offset = "0x4EFF7C0", VA = "0x184F00BC0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, InteropHelp.UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize);

		// Token: 0x060007B2 RID: 1970
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x4F00B20", Offset = "0x4EFF720", VA = "0x184F00B20")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetNumSupportedGameVersions(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		// Token: 0x060007B3 RID: 1971
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x4F01810", Offset = "0x4F00410", VA = "0x184F01810")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetSupportedGameVersionData(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint versionIndex, IntPtr pchGameBranchMin, IntPtr pchGameBranchMax, uint cchGameBranchSize);

		// Token: 0x060007B4 RID: 1972
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x4F00E90", Offset = "0x4EFFA90", VA = "0x184F00E90")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetQueryUGCContentDescriptors(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In] [Out] EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries);

		// Token: 0x060007B5 RID: 1973
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x4F01A90", Offset = "0x4F00690", VA = "0x184F01A90")]
		[PreserveSig]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		// Token: 0x060007B6 RID: 1974
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x4F00070", Offset = "0x4EFEC70", VA = "0x184F00070")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x060007B7 RID: 1975
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4EFFFD0", Offset = "0x4EFEBD0", VA = "0x184EFFFD0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups);

		// Token: 0x060007B8 RID: 1976
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x4EFF9E0", Offset = "0x4EFE5E0", VA = "0x184EFF9E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		// Token: 0x060007B9 RID: 1977
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x4F030C0", Offset = "0x4F01CC0", VA = "0x184F030C0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		// Token: 0x060007BA RID: 1978
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x4F02EE0", Offset = "0x4F01AE0", VA = "0x184F02EE0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		// Token: 0x060007BB RID: 1979
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4F02F80", Offset = "0x4F01B80", VA = "0x184F02F80")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription);

		// Token: 0x060007BC RID: 1980
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4F03020", Offset = "0x4F01C20", VA = "0x184F03020")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata);

		// Token: 0x060007BD RID: 1981
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x4F02E40", Offset = "0x4F01A40", VA = "0x184F02E40")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren);

		// Token: 0x060007BE RID: 1982
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4F02DA0", Offset = "0x4F019A0", VA = "0x184F02DA0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x4F03200", Offset = "0x4F01E00", VA = "0x184F03200")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly);

		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x4F03160", Offset = "0x4F01D60", VA = "0x184F03160")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x4F02A30", Offset = "0x4F01630", VA = "0x184F02A30")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x060007C2 RID: 1986
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4F02180", Offset = "0x4F00D80", VA = "0x184F02180")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		// Token: 0x060007C3 RID: 1987
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x4F020E0", Offset = "0x4F00CE0", VA = "0x184F020E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetAdminQuery(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAdminQuery);

		// Token: 0x060007C4 RID: 1988
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x4F022C0", Offset = "0x4F00EC0", VA = "0x184F022C0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x4F02B10", Offset = "0x4F01710", VA = "0x184F02B10")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag);

		// Token: 0x060007C6 RID: 1990
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4F032A0", Offset = "0x4F01EA0", VA = "0x184F032A0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		// Token: 0x060007C7 RID: 1991
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4F02BB0", Offset = "0x4F017B0", VA = "0x184F02BB0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		// Token: 0x060007C8 RID: 1992
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x4F03380", Offset = "0x4F01F80", VA = "0x184F03380")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetTimeCreatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd);

		// Token: 0x060007C9 RID: 1993
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x4F03430", Offset = "0x4F02030", VA = "0x184F03430")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetTimeUpdatedDateRange(IntPtr instancePtr, UGCQueryHandle_t handle, uint rtStart, uint rtEnd);

		// Token: 0x060007CA RID: 1994
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x4EFFE80", Offset = "0x4EFEA80", VA = "0x184EFFE80")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		// Token: 0x060007CB RID: 1995
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x4F01FB0", Offset = "0x4F00BB0", VA = "0x184F01FB0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		// Token: 0x060007CC RID: 1996
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x4F00230", Offset = "0x4EFEE30", VA = "0x184F00230")]
		[PreserveSig]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		// Token: 0x060007CD RID: 1997
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x4F03600", Offset = "0x4F02200", VA = "0x184F03600")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007CE RID: 1998
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x4F027D0", Offset = "0x4F013D0", VA = "0x184F027D0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		// Token: 0x060007CF RID: 1999
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x4F02480", Offset = "0x4F01080", VA = "0x184F02480")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		// Token: 0x060007D0 RID: 2000
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x4F028B0", Offset = "0x4F014B0", VA = "0x184F028B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		// Token: 0x060007D1 RID: 2001
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4F02560", Offset = "0x4F01160", VA = "0x184F02560")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		// Token: 0x060007D2 RID: 2002
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4F02990", Offset = "0x4F01590", VA = "0x184F02990")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		// Token: 0x060007D3 RID: 2003
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x4F02720", Offset = "0x4F01320", VA = "0x184F02720")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags, bool bAllowAdminTags);

		// Token: 0x060007D4 RID: 2004
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x4F023A0", Offset = "0x4F00FA0", VA = "0x184F023A0")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		// Token: 0x060007D5 RID: 2005
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x4F02640", Offset = "0x4F01240", VA = "0x184F02640")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x060007D6 RID: 2006
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x4F02220", Offset = "0x4F00E20", VA = "0x184F02220")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload);

		// Token: 0x060007D7 RID: 2007
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x4F01B20", Offset = "0x4F00720", VA = "0x184F01B20")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle);

		// Token: 0x060007D8 RID: 2008
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x4F01E30", Offset = "0x4F00A30", VA = "0x184F01E30")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x060007D9 RID: 2009
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x4EFFAC0", Offset = "0x4EFE6C0", VA = "0x184EFFAC0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		// Token: 0x060007DA RID: 2010
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x4EFFC10", Offset = "0x4EFE810", VA = "0x184EFFC10")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		// Token: 0x060007DB RID: 2011
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x4EFFD00", Offset = "0x4EFE900", VA = "0x184EFFD00")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x060007DC RID: 2012
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x4F03AF0", Offset = "0x4F026F0", VA = "0x184F03AF0")]
		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		// Token: 0x060007DD RID: 2013
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x4F03BE0", Offset = "0x4F027E0", VA = "0x184F03BE0")]
		[PreserveSig]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		// Token: 0x060007DE RID: 2014
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x4F01F10", Offset = "0x4F00B10", VA = "0x184F01F10")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		// Token: 0x060007DF RID: 2015
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x4EFF8A0", Offset = "0x4EFE4A0", VA = "0x184EFF8A0")]
		[PreserveSig]
		public static extern bool ISteamUGC_AddContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid);

		// Token: 0x060007E0 RID: 2016
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x4F01C50", Offset = "0x4F00850", VA = "0x184F01C50")]
		[PreserveSig]
		public static extern bool ISteamUGC_RemoveContentDescriptor(IntPtr instancePtr, UGCUpdateHandle_t handle, EUGCContentDescriptorID descid);

		// Token: 0x060007E1 RID: 2017
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x4F02C50", Offset = "0x4F01850", VA = "0x184F02C50")]
		[PreserveSig]
		public static extern bool ISteamUGC_SetRequiredGameVersions(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszGameBranchMin, InteropHelp.UTF8StringHandle pszGameBranchMax);

		// Token: 0x060007E2 RID: 2018
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x4F03860", Offset = "0x4F02460", VA = "0x184F03860")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		// Token: 0x060007E3 RID: 2019
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x4F009F0", Offset = "0x4EFF5F0", VA = "0x184F009F0")]
		[PreserveSig]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		// Token: 0x060007E4 RID: 2020
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x4F034E0", Offset = "0x4F020E0", VA = "0x184F034E0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp);

		// Token: 0x060007E5 RID: 2021
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x4F01980", Offset = "0x4F00580", VA = "0x184F01980")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007E6 RID: 2022
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x4EFFDE0", Offset = "0x4EFE9E0", VA = "0x184EFFDE0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007E7 RID: 2023
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x4F01D90", Offset = "0x4F00990", VA = "0x184F01D90")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007E8 RID: 2024
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x4F03940", Offset = "0x4F02540", VA = "0x184F03940")]
		[PreserveSig]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x4F03A60", Offset = "0x4F02660", VA = "0x184F03A60")]
		[PreserveSig]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007EA RID: 2026
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x4F00AA0", Offset = "0x4EFF6A0", VA = "0x184F00AA0")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		// Token: 0x060007EB RID: 2027
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x4F01770", Offset = "0x4F00370", VA = "0x184F01770")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		// Token: 0x060007EC RID: 2028
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x4F00960", Offset = "0x4EFF560", VA = "0x184F00960")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007ED RID: 2029
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x4F00890", Offset = "0x4EFF490", VA = "0x184F00890")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		// Token: 0x060007EE RID: 2030
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x4F007E0", Offset = "0x4EFF3E0", VA = "0x184F007E0")]
		[PreserveSig]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		// Token: 0x060007EF RID: 2031
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x4F006B0", Offset = "0x4EFF2B0", VA = "0x184F006B0")]
		[PreserveSig]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority);

		// Token: 0x060007F0 RID: 2032
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x4F00150", Offset = "0x4EFED50", VA = "0x184F00150")]
		[PreserveSig]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		// Token: 0x060007F1 RID: 2033
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x4F039D0", Offset = "0x4F025D0", VA = "0x184F039D0")]
		[PreserveSig]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend);

		// Token: 0x060007F2 RID: 2034
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x4F036A0", Offset = "0x4F022A0", VA = "0x184F036A0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x060007F3 RID: 2035
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x4F037C0", Offset = "0x4F023C0", VA = "0x184F037C0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In] [Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		// Token: 0x060007F4 RID: 2036
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x4F03740", Offset = "0x4F02340", VA = "0x184F03740")]
		[PreserveSig]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		// Token: 0x060007F5 RID: 2037
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x4EFF940", Offset = "0x4EFE540", VA = "0x184EFF940")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x060007F6 RID: 2038
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x4F01CF0", Offset = "0x4F008F0", VA = "0x184F01CF0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x4EFF800", Offset = "0x4EFE400", VA = "0x184EFF800")]
		[PreserveSig]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x4F01BB0", Offset = "0x4F007B0", VA = "0x184F01BB0")]
		[PreserveSig]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x4F00750", Offset = "0x4EFF350", VA = "0x184F00750")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x4F00620", Offset = "0x4EFF220", VA = "0x184F00620")]
		[PreserveSig]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x4F03580", Offset = "0x4F02180", VA = "0x184F03580")]
		[PreserveSig]
		public static extern bool ISteamUGC_ShowWorkshopEULA(IntPtr instancePtr);

		// Token: 0x060007FC RID: 2044
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x4F01A10", Offset = "0x4F00610", VA = "0x184F01A10")]
		[PreserveSig]
		public static extern ulong ISteamUGC_GetWorkshopEULAStatus(IntPtr instancePtr);

		// Token: 0x060007FD RID: 2045
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x4F018E0", Offset = "0x4F004E0", VA = "0x184F018E0")]
		[PreserveSig]
		public static extern uint ISteamUGC_GetUserContentDescriptorPreferences(IntPtr instancePtr, [In] [Out] EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries);

		// Token: 0x060007FE RID: 2046
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x4F06C60", Offset = "0x4F05860", VA = "0x184F06C60")]
		[PreserveSig]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		// Token: 0x060007FF RID: 2047
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x4F06480", Offset = "0x4F05080", VA = "0x184F06480")]
		[PreserveSig]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		// Token: 0x06000800 RID: 2048
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x4F06DE0", Offset = "0x4F059E0", VA = "0x184F06DE0")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		// Token: 0x06000801 RID: 2049
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x4F07090", Offset = "0x4F05C90", VA = "0x184F07090")]
		[PreserveSig]
		public static extern int ISteamUser_InitiateGameConnection_DEPRECATED(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		// Token: 0x06000802 RID: 2050
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x4F073F0", Offset = "0x4F05FF0", VA = "0x184F073F0")]
		[PreserveSig]
		public static extern void ISteamUser_TerminateGameConnection_DEPRECATED(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		// Token: 0x06000803 RID: 2051
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x4F07490", Offset = "0x4F06090", VA = "0x184F07490")]
		[PreserveSig]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		// Token: 0x06000804 RID: 2052
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x4F06E60", Offset = "0x4F05A60", VA = "0x184F06E60")]
		[PreserveSig]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		// Token: 0x06000805 RID: 2053
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x4F072F0", Offset = "0x4F05EF0", VA = "0x184F072F0")]
		[PreserveSig]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		// Token: 0x06000806 RID: 2054
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x4F07370", Offset = "0x4F05F70", VA = "0x184F07370")]
		[PreserveSig]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		// Token: 0x06000807 RID: 2055
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x4F069D0", Offset = "0x4F055D0", VA = "0x184F069D0")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x06000808 RID: 2056
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x4F06F80", Offset = "0x4F05B80", VA = "0x184F06F80")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		// Token: 0x06000809 RID: 2057
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x4F066D0", Offset = "0x4F052D0", VA = "0x184F066D0")]
		[PreserveSig]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		// Token: 0x0600080A RID: 2058
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x4F06F00", Offset = "0x4F05B00", VA = "0x184F06F00")]
		[PreserveSig]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		// Token: 0x0600080B RID: 2059
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x4F06840", Offset = "0x4F05440", VA = "0x184F06840")]
		[PreserveSig]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity);

		// Token: 0x0600080C RID: 2060
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4F06900", Offset = "0x4F05500", VA = "0x184F06900")]
		[PreserveSig]
		public static extern uint ISteamUser_GetAuthTicketForWebApi(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchIdentity);

		// Token: 0x0600080D RID: 2061
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x4F06590", Offset = "0x4F05190", VA = "0x184F06590")]
		[PreserveSig]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		// Token: 0x0600080E RID: 2062
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x4F067B0", Offset = "0x4F053B0", VA = "0x184F067B0")]
		[PreserveSig]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		// Token: 0x0600080F RID: 2063
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x4F06640", Offset = "0x4F05240", VA = "0x184F06640")]
		[PreserveSig]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		// Token: 0x06000810 RID: 2064
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x4F07580", Offset = "0x4F06180", VA = "0x184F07580")]
		[PreserveSig]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		// Token: 0x06000811 RID: 2065
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x4F06200", Offset = "0x4F04E00", VA = "0x184F06200")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		// Token: 0x06000812 RID: 2066
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x4F06150", Offset = "0x4F04D50", VA = "0x184F06150")]
		[PreserveSig]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		// Token: 0x06000813 RID: 2067
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x4F07170", Offset = "0x4F05D70", VA = "0x184F07170")]
		[PreserveSig]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		// Token: 0x06000814 RID: 2068
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x4F06B00", Offset = "0x4F05700", VA = "0x184F06B00")]
		[PreserveSig]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		// Token: 0x06000815 RID: 2069
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4F06BC0", Offset = "0x4F057C0", VA = "0x184F06BC0")]
		[PreserveSig]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil);

		// Token: 0x06000816 RID: 2070
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4F06D60", Offset = "0x4F05960", VA = "0x184F06D60")]
		[PreserveSig]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		// Token: 0x06000817 RID: 2071
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x4F07210", Offset = "0x4F05E10", VA = "0x184F07210")]
		[PreserveSig]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		// Token: 0x06000818 RID: 2072
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x4F06380", Offset = "0x4F04F80", VA = "0x184F06380")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		// Token: 0x06000819 RID: 2073
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x4F06400", Offset = "0x4F05000", VA = "0x184F06400")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		// Token: 0x0600081A RID: 2074
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x4F06280", Offset = "0x4F04E80", VA = "0x184F06280")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		// Token: 0x0600081B RID: 2075
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x4F06300", Offset = "0x4F04F00", VA = "0x184F06300")]
		[PreserveSig]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		// Token: 0x0600081C RID: 2076
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x4F06CE0", Offset = "0x4F058E0", VA = "0x184F06CE0")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr);

		// Token: 0x0600081D RID: 2077
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x4F06A80", Offset = "0x4F05680", VA = "0x184F06A80")]
		[PreserveSig]
		public static extern ulong ISteamUser_GetDurationControl(IntPtr instancePtr);

		// Token: 0x0600081E RID: 2078
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x4F06500", Offset = "0x4F05100", VA = "0x184F06500")]
		[PreserveSig]
		public static extern bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState);

		// Token: 0x0600081F RID: 2079
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x4F05980", Offset = "0x4F04580", VA = "0x184F05980")]
		[PreserveSig]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		// Token: 0x06000820 RID: 2080
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x4F05390", Offset = "0x4F03F90", VA = "0x184F05390")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x06000821 RID: 2081
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x4F052A0", Offset = "0x4F03EA0", VA = "0x184F052A0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x06000822 RID: 2082
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x4F05E00", Offset = "0x4F04A00", VA = "0x184F05E00")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		// Token: 0x06000823 RID: 2083
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x4F05D10", Offset = "0x4F04910", VA = "0x184F05D10")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		// Token: 0x06000824 RID: 2084
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x4F05F70", Offset = "0x4F04B70", VA = "0x184F05F70")]
		[PreserveSig]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		// Token: 0x06000825 RID: 2085
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x4F04800", Offset = "0x4F03400", VA = "0x184F04800")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x06000826 RID: 2086
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x4F05C30", Offset = "0x4F04830", VA = "0x184F05C30")]
		[PreserveSig]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x06000827 RID: 2087
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x4F03D70", Offset = "0x4F02970", VA = "0x184F03D70")]
		[PreserveSig]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x06000828 RID: 2088
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x4F04270", Offset = "0x4F02E70", VA = "0x184F04270")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x06000829 RID: 2089
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x4F05EF0", Offset = "0x4F04AF0", VA = "0x184F05EF0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		// Token: 0x0600082A RID: 2090
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x4F044C0", Offset = "0x4F030C0", VA = "0x184F044C0")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		// Token: 0x0600082B RID: 2091
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x4F04380", Offset = "0x4F02F80", VA = "0x184F04380")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		// Token: 0x0600082C RID: 2092
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x4F05890", Offset = "0x4F04490", VA = "0x184F05890")]
		[PreserveSig]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		// Token: 0x0600082D RID: 2093
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x4F051A0", Offset = "0x4F03DA0", VA = "0x184F051A0")]
		[PreserveSig]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		// Token: 0x0600082E RID: 2094
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x4F04590", Offset = "0x4F03190", VA = "0x184F04590")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		// Token: 0x0600082F RID: 2095
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x4F05B10", Offset = "0x4F04710", VA = "0x184F05B10")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		// Token: 0x06000830 RID: 2096
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x4F057A0", Offset = "0x4F043A0", VA = "0x184F057A0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		// Token: 0x06000831 RID: 2097
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x4F056B0", Offset = "0x4F042B0", VA = "0x184F056B0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		// Token: 0x06000832 RID: 2098
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x4F055A0", Offset = "0x4F041A0", VA = "0x184F055A0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		// Token: 0x06000833 RID: 2099
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x4F05480", Offset = "0x4F04080", VA = "0x184F05480")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		// Token: 0x06000834 RID: 2100
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x4F05BA0", Offset = "0x4F047A0", VA = "0x184F05BA0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo);

		// Token: 0x06000835 RID: 2101
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x4F04090", Offset = "0x4F02C90", VA = "0x184F04090")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		// Token: 0x06000836 RID: 2102
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4F03FB0", Offset = "0x4F02BB0", VA = "0x184F03FB0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		// Token: 0x06000837 RID: 2103
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x4F04ED0", Offset = "0x4F03AD0", VA = "0x184F04ED0")]
		[PreserveSig]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000838 RID: 2104
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x4F04E40", Offset = "0x4F03A40", VA = "0x184F04E40")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x06000839 RID: 2105
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x4F04F60", Offset = "0x4F03B60", VA = "0x184F04F60")]
		[PreserveSig]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x0600083A RID: 2106
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x4F04DB0", Offset = "0x4F039B0", VA = "0x184F04DB0")]
		[PreserveSig]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		// Token: 0x0600083B RID: 2107
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x4F03F00", Offset = "0x4F02B00", VA = "0x184F03F00")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		// Token: 0x0600083C RID: 2108
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x4F03E50", Offset = "0x4F02A50", VA = "0x184F03E50")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In] [Out] CSteamID[] prgUsers, int cUsers);

		// Token: 0x0600083D RID: 2109
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x4F04900", Offset = "0x4F03500", VA = "0x184F04900")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In] [Out] int[] pDetails, int cDetailsMax);

		// Token: 0x0600083E RID: 2110
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x4F06080", Offset = "0x4F04C80", VA = "0x184F06080")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] int[] pScoreDetails, int cScoreDetailsCount);

		// Token: 0x0600083F RID: 2111
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x4F03CD0", Offset = "0x4F028D0", VA = "0x184F03CD0")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		// Token: 0x06000840 RID: 2112
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x4F05220", Offset = "0x4F03E20", VA = "0x184F05220")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		// Token: 0x06000841 RID: 2113
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x4F05A00", Offset = "0x4F04600", VA = "0x184F05A00")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		// Token: 0x06000842 RID: 2114
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x4F04FF0", Offset = "0x4F03BF0", VA = "0x184F04FF0")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x06000843 RID: 2115
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x4F050C0", Offset = "0x4F03CC0", VA = "0x184F050C0")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		// Token: 0x06000844 RID: 2116
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x4F04180", Offset = "0x4F02D80", VA = "0x184F04180")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		// Token: 0x06000845 RID: 2117
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x4F05A80", Offset = "0x4F04680", VA = "0x184F05A80")]
		[PreserveSig]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		// Token: 0x06000846 RID: 2118
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x4F04CC0", Offset = "0x4F038C0", VA = "0x184F04CC0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		// Token: 0x06000847 RID: 2119
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x4F049D0", Offset = "0x4F035D0", VA = "0x184F049D0")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		// Token: 0x06000848 RID: 2120
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x4F04BC0", Offset = "0x4F037C0", VA = "0x184F04BC0")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] long[] pData, uint cubData);

		// Token: 0x06000849 RID: 2121
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x4F04AC0", Offset = "0x4F036C0", VA = "0x184F04AC0")]
		[PreserveSig]
		public static extern int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In] [Out] double[] pData, uint cubData);

		// Token: 0x0600084A RID: 2122
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x4F04710", Offset = "0x4F03310", VA = "0x184F04710")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress);

		// Token: 0x0600084B RID: 2123
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x4F04620", Offset = "0x4F03220", VA = "0x184F04620")]
		[PreserveSig]
		public static extern bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress);

		// Token: 0x0600084C RID: 2124
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x4F08090", Offset = "0x4F06C90", VA = "0x184F08090")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		// Token: 0x0600084D RID: 2125
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x4F08110", Offset = "0x4F06D10", VA = "0x184F08110")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		// Token: 0x0600084E RID: 2126
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x4F07B80", Offset = "0x4F06780", VA = "0x184F07B80")]
		[PreserveSig]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		// Token: 0x0600084F RID: 2127
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x4F08190", Offset = "0x4F06D90", VA = "0x184F08190")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		// Token: 0x06000850 RID: 2128
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x4F07E20", Offset = "0x4F06A20", VA = "0x184F07E20")]
		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		// Token: 0x06000851 RID: 2129
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x4F07FE0", Offset = "0x4F06BE0", VA = "0x184F07FE0")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		// Token: 0x06000852 RID: 2130
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x4F07F30", Offset = "0x4F06B30", VA = "0x184F07F30")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		// Token: 0x06000853 RID: 2131
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x4F07C00", Offset = "0x4F06800", VA = "0x184F07C00")]
		[PreserveSig]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		// Token: 0x06000854 RID: 2132
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x4F07B00", Offset = "0x4F06700", VA = "0x184F07B00")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		// Token: 0x06000855 RID: 2133
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x4F08800", Offset = "0x4F07400", VA = "0x184F08800")]
		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		// Token: 0x06000856 RID: 2134
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x4F08320", Offset = "0x4F06F20", VA = "0x184F08320")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		// Token: 0x06000857 RID: 2135
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x4F07990", Offset = "0x4F06590", VA = "0x184F07990")]
		[PreserveSig]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		// Token: 0x06000858 RID: 2136
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x4F07A20", Offset = "0x4F06620", VA = "0x184F07A20")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		// Token: 0x06000859 RID: 2137
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x4F07DA0", Offset = "0x4F069A0", VA = "0x184F07DA0")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		// Token: 0x0600085A RID: 2138
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x4F08920", Offset = "0x4F07520", VA = "0x184F08920")]
		[PreserveSig]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		// Token: 0x0600085B RID: 2139
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x4F083D0", Offset = "0x4F06FD0", VA = "0x184F083D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		// Token: 0x0600085C RID: 2140
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x4F07620", Offset = "0x4F06220", VA = "0x184F07620")]
		[PreserveSig]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		// Token: 0x0600085D RID: 2141
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x4F076A0", Offset = "0x4F062A0", VA = "0x184F076A0")]
		[PreserveSig]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		// Token: 0x0600085E RID: 2142
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x4F08A80", Offset = "0x4F07680", VA = "0x184F08A80")]
		[PreserveSig]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		// Token: 0x0600085F RID: 2143
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x4F07D20", Offset = "0x4F06920", VA = "0x184F07D20")]
		[PreserveSig]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		// Token: 0x06000860 RID: 2144
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x4F07C80", Offset = "0x4F06880", VA = "0x184F07C80")]
		[PreserveSig]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		// Token: 0x06000861 RID: 2145
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x4F08210", Offset = "0x4F06E10", VA = "0x184F08210")]
		[PreserveSig]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		// Token: 0x06000862 RID: 2146
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x4F08550", Offset = "0x4F07150", VA = "0x184F08550")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		// Token: 0x06000863 RID: 2147
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4F08760", Offset = "0x4F07360", VA = "0x184F08760")]
		[PreserveSig]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		// Token: 0x06000864 RID: 2148
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4F084D0", Offset = "0x4F070D0", VA = "0x184F084D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		// Token: 0x06000865 RID: 2149
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x4F08C00", Offset = "0x4F07800", VA = "0x184F08C00")]
		[PreserveSig]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		// Token: 0x06000866 RID: 2150
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x4F08650", Offset = "0x4F07250", VA = "0x184F08650")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		// Token: 0x06000867 RID: 2151
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x4F08890", Offset = "0x4F07490", VA = "0x184F08890")]
		[PreserveSig]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled);

		// Token: 0x06000868 RID: 2152
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x4F08450", Offset = "0x4F07050", VA = "0x184F08450")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr);

		// Token: 0x06000869 RID: 2153
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x4F08290", Offset = "0x4F06E90", VA = "0x184F08290")]
		[PreserveSig]
		public static extern bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions);

		// Token: 0x0600086A RID: 2154
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x4F07880", Offset = "0x4F06480", VA = "0x184F07880")]
		[PreserveSig]
		public static extern int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, InteropHelp.UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText);

		// Token: 0x0600086B RID: 2155
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x4F07EA0", Offset = "0x4F06AA0", VA = "0x184F07EA0")]
		[PreserveSig]
		public static extern ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol);

		// Token: 0x0600086C RID: 2156
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x4F085D0", Offset = "0x4F071D0", VA = "0x184F085D0")]
		[PreserveSig]
		public static extern bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr);

		// Token: 0x0600086D RID: 2157
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x4F089C0", Offset = "0x4F075C0", VA = "0x184F089C0")]
		[PreserveSig]
		public static extern bool ISteamUtils_ShowFloatingGamepadTextInput(IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);

		// Token: 0x0600086E RID: 2158
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x4F086D0", Offset = "0x4F072D0", VA = "0x184F086D0")]
		[PreserveSig]
		public static extern void ISteamUtils_SetGameLauncherMode(IntPtr instancePtr, bool bLauncherMode);

		// Token: 0x0600086F RID: 2159
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x4F07780", Offset = "0x4F06380", VA = "0x184F07780")]
		[PreserveSig]
		public static extern bool ISteamUtils_DismissFloatingGamepadTextInput(IntPtr instancePtr);

		// Token: 0x06000870 RID: 2160
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x4F07800", Offset = "0x4F06400", VA = "0x184F07800")]
		[PreserveSig]
		public static extern bool ISteamUtils_DismissGamepadTextInput(IntPtr instancePtr);

		// Token: 0x06000871 RID: 2161
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x4F08DC0", Offset = "0x4F079C0", VA = "0x184F08DC0")]
		[PreserveSig]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x06000872 RID: 2162
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4F08E50", Offset = "0x4F07A50", VA = "0x184F08E50")]
		[PreserveSig]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		// Token: 0x06000873 RID: 2163
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4F08C80", Offset = "0x4F07880", VA = "0x184F08C80")]
		[PreserveSig]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		// Token: 0x06000874 RID: 2164
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x4F08D10", Offset = "0x4F07910", VA = "0x184F08D10")]
		[PreserveSig]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		internal const string NativeLibraryName = "steam_api64";

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64";
	}
}
