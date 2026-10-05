using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553B RID: 21819
	[Token(Token = "0x200553B")]
	public class RoguelikeStashedTicketUseDesParam : IHotfixable
	{
		// Token: 0x0602015E RID: 131422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602015E")]
		[Address(RVA = "0x1A3E580", Offset = "0x1A3D180", VA = "0x181A3E580")]
		public static RoguelikeStashedTicketUseDesParam Default()
		{
			return null;
		}

		// Token: 0x0602015F RID: 131423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602015F")]
		[Address(RVA = "0x1A3E6A0", Offset = "0x1A3D2A0", VA = "0x181A3E6A0")]
		public RoguelikeStashedTicketUseDesParam()
		{
		}

		// Token: 0x0402B56C RID: 177516
		[Token(Token = "0x402B56C")]
		[FieldOffset(Offset = "0x10")]
		public string titleName;

		// Token: 0x0402B56D RID: 177517
		[Token(Token = "0x402B56D")]
		[FieldOffset(Offset = "0x18")]
		public string specialRecruitFuncDesc;

		// Token: 0x0402B56E RID: 177518
		[Token(Token = "0x402B56E")]
		[FieldOffset(Offset = "0x20")]
		public string specialRecruitDetailDesc;

		// Token: 0x0402B56F RID: 177519
		[Token(Token = "0x402B56F")]
		[FieldOffset(Offset = "0x28")]
		public string specialRecruitReductionFormat;

		// Token: 0x0402B570 RID: 177520
		[Token(Token = "0x402B570")]
		[FieldOffset(Offset = "0x30")]
		public string emptyTips;

		// Token: 0x0402B571 RID: 177521
		[Token(Token = "0x402B571")]
		[FieldOffset(Offset = "0x38")]
		public string useLimitTipsFormat;

		// Token: 0x0402B572 RID: 177522
		[Token(Token = "0x402B572")]
		[FieldOffset(Offset = "0x40")]
		public string cantConfirmToast;

		// Token: 0x0402B573 RID: 177523
		[Token(Token = "0x402B573")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Default;

		// Token: 0x0402B574 RID: 177524
		[Token(Token = "0x402B574")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
