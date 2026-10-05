using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038A7 RID: 14503
	[Token(Token = "0x20038A7")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIWebPreloader
	{
		// Token: 0x06016F24 RID: 93988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F24")]
		[Address(RVA = "0xF694F0", Offset = "0xF680F0", VA = "0x180F694F0")]
		public static void StartPreload()
		{
		}

		// Token: 0x06016F25 RID: 93989 RVA: 0x00094140 File Offset: 0x00092340
		[Token(Token = "0x6016F25")]
		[Address(RVA = "0xF69380", Offset = "0xF67F80", VA = "0x180F69380")]
		public static bool IsPreloadReady(ref int frameCnt)
		{
			return default(bool);
		}

		// Token: 0x0401BB22 RID: 113442
		[Token(Token = "0x401BB22")]
		private const int WEB_PRELOAD_FRAMEOUT = 60;

		// Token: 0x0401BB23 RID: 113443
		[Token(Token = "0x401BB23")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_hasInitRequested;

		// Token: 0x0401BB24 RID: 113444
		[Token(Token = "0x401BB24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartPreload;

		// Token: 0x0401BB25 RID: 113445
		[Token(Token = "0x401BB25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsPreloadReady;
	}
}
