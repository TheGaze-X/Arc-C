using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	public class DeviceInfoUtil : IHotfixable
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x54FBDB0", Offset = "0x54FA9B0", VA = "0x1854FBDB0")]
		public static DeviceInfoUtil.SimulatorInfo EstimateSimulatorInfo()
		{
			return DeviceInfoUtil.SimulatorInfo.NONE;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x54FC050", Offset = "0x54FAC50", VA = "0x1854FC050")]
		private static DeviceInfoUtil.SimulatorInfo _SimulatorInfoAndroid()
		{
			return DeviceInfoUtil.SimulatorInfo.NONE;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x54FC400", Offset = "0x54FB000", VA = "0x1854FC400")]
		private static DeviceInfoUtil.SimulatorInfo _SimulatorInfoIOS()
		{
			return DeviceInfoUtil.SimulatorInfo.NONE;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x54FBF30", Offset = "0x54FAB30", VA = "0x1854FBF30")]
		public static int GetSystemMemorySize()
		{
			return 0;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x54FBF90", Offset = "0x54FAB90", VA = "0x1854FBF90")]
		public static bool IsPCMode()
		{
			return default(bool);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x54FBFF0", Offset = "0x54FABF0", VA = "0x1854FBFF0")]
		public static void SetPCMode(bool isPCMode)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x54FC4E0", Offset = "0x54FB0E0", VA = "0x1854FC4E0")]
		public DeviceInfoUtil()
		{
		}

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		private const string IOS_ON_MAC_SDK_IDENTIFIER = "YES";

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		private const string CPU_MODEL_INTEL = "intel";

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		private const string CPU_MODEL_AMD = "amd";

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x0")]
		private static DeviceInfoUtil.SimulatorInfo s_simInfo;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		public const int SYS_MEMORY_LIMIT_2G = 2200;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		public const int SYS_MEMORY_LIMIT_4G = 4500;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		public const string UI_PC_MODE_LOCAL_CACHE = "key_ui_pc_mode_localcache";

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate85 __Hotfix0_EstimateSimulatorInfo;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate85 __Hotfix0__SimulatorInfoAndroid;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate85 __Hotfix0__SimulatorInfoIOS;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate9 __Hotfix0_GetSystemMemorySize;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate8 __Hotfix0_IsPCMode;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate86 __Hotfix0_SetPCMode;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		public enum SimulatorInfo
		{
			// Token: 0x040004FC RID: 1276
			[Token(Token = "0x40004FC")]
			NONE,
			// Token: 0x040004FD RID: 1277
			[Token(Token = "0x40004FD")]
			MOBILE,
			// Token: 0x040004FE RID: 1278
			[Token(Token = "0x40004FE")]
			MUMU,
			// Token: 0x040004FF RID: 1279
			[Token(Token = "0x40004FF")]
			ANDROID_X86,
			// Token: 0x04000500 RID: 1280
			[Token(Token = "0x4000500")]
			IOS_ON_MAC,
			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x4000501")]
			UNKNOW_SIMULATOR,
			// Token: 0x04000502 RID: 1282
			[Token(Token = "0x4000502")]
			EDITOR,
			// Token: 0x04000503 RID: 1283
			[Token(Token = "0x4000503")]
			WINDOWS
		}
	}
}
