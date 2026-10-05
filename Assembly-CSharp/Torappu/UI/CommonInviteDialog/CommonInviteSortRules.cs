using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BBC RID: 23484
	[Token(Token = "0x2005BBC")]
	public class CommonInviteSortRules : IHotfixable
	{
		// Token: 0x060220EF RID: 139503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60220EF")]
		[Address(RVA = "0x1C95950", Offset = "0x1C94550", VA = "0x181C95950")]
		public static Comparison<CommonInviteSortInfo> CombineRules(params Comparison<CommonInviteSortInfo>[] rules)
		{
			return null;
		}

		// Token: 0x060220F0 RID: 139504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220F0")]
		[Address(RVA = "0x1C95DF0", Offset = "0x1C949F0", VA = "0x181C95DF0")]
		public CommonInviteSortRules()
		{
		}

		// Token: 0x0402EB60 RID: 191328
		[Token(Token = "0x402EB60")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Comparison<CommonInviteSortInfo> RECENT_MATE_FIRST;

		// Token: 0x0402EB61 RID: 191329
		[Token(Token = "0x402EB61")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Comparison<CommonInviteSortInfo> STAR_MARK_FIRST;

		// Token: 0x0402EB62 RID: 191330
		[Token(Token = "0x402EB62")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Comparison<CommonInviteSortInfo> RECENT_ONLINE_FIRST;

		// Token: 0x0402EB63 RID: 191331
		[Token(Token = "0x402EB63")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Comparison<CommonInviteSortInfo> INVITED_TS_LATEST;

		// Token: 0x0402EB64 RID: 191332
		[Token(Token = "0x402EB64")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Comparison<CommonInviteSortInfo> PLAYER_LVL_LARGEST;

		// Token: 0x0402EB65 RID: 191333
		[Token(Token = "0x402EB65")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Comparison<CommonInviteSortInfo> UID_DEFAULT;

		// Token: 0x0402EB66 RID: 191334
		[Token(Token = "0x402EB66")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CombineRules;

		// Token: 0x0402EB67 RID: 191335
		[Token(Token = "0x402EB67")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
