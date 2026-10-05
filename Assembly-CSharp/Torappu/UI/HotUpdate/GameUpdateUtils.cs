using System;
using Il2CppDummyDll;
using Torappu.SDK;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AD0 RID: 19152
	[Token(Token = "0x2004AD0")]
	public class GameUpdateUtils : IHotfixable
	{
		// Token: 0x0601CC1E RID: 117790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC1E")]
		[Address(RVA = "0x1622840", Offset = "0x1621440", VA = "0x181622840")]
		public static void HandleTrivialError(int code, GameUpdateContext context, GameUpdateOptions options)
		{
		}

		// Token: 0x0601CC1F RID: 117791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC1F")]
		[Address(RVA = "0x1622990", Offset = "0x1621590", VA = "0x181622990")]
		public static void HandleVitalError(int code, GameUpdateContext context, GameUpdateOptions options)
		{
		}

		// Token: 0x0601CC20 RID: 117792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC20")]
		[Address(RVA = "0x1622730", Offset = "0x1621330", VA = "0x181622730")]
		public static void HandleProceed(GameUpdateContext context, GameUpdateOptions options)
		{
		}

		// Token: 0x0601CC21 RID: 117793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC21")]
		[Address(RVA = "0x1622AC0", Offset = "0x16216C0", VA = "0x181622AC0")]
		private static void _HandleResultCode(GameUpdateContext context, bool enableGameUpdateV2, int code, bool isError, bool forceRetry)
		{
		}

		// Token: 0x0601CC22 RID: 117794 RVA: 0x000A96F8 File Offset: 0x000A78F8
		[Token(Token = "0x601CC22")]
		[Address(RVA = "0x16224A0", Offset = "0x16210A0", VA = "0x1816224A0")]
		public static bool CheckGameInfoAction(HGLatestGameInfo gameInfo, GameUpdateContext context, GameUpdateOptions options)
		{
			return default(bool);
		}

		// Token: 0x0601CC23 RID: 117795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC23")]
		[Address(RVA = "0x1622B80", Offset = "0x1621780", VA = "0x181622B80")]
		public GameUpdateUtils()
		{
		}

		// Token: 0x04025BDD RID: 154589
		[Token(Token = "0x4025BDD")]
		public const int ERROR_INVALID_GAME_INFO = -10001;

		// Token: 0x04025BDE RID: 154590
		[Token(Token = "0x4025BDE")]
		public const int ERROR_INVALID_UPDATE_TYPE_2 = -10002;

		// Token: 0x04025BDF RID: 154591
		[Token(Token = "0x4025BDF")]
		public const int ERROR_INVALID_ACTION = -10003;

		// Token: 0x04025BE0 RID: 154592
		[Token(Token = "0x4025BE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleTrivialError;

		// Token: 0x04025BE1 RID: 154593
		[Token(Token = "0x4025BE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleVitalError;

		// Token: 0x04025BE2 RID: 154594
		[Token(Token = "0x4025BE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleProceed;

		// Token: 0x04025BE3 RID: 154595
		[Token(Token = "0x4025BE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleResultCode;

		// Token: 0x04025BE4 RID: 154596
		[Token(Token = "0x4025BE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckGameInfoAction;

		// Token: 0x04025BE5 RID: 154597
		[Token(Token = "0x4025BE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
