using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057BE RID: 22462
	[Token(Token = "0x20057BE")]
	public class RL01BankWithdrawModelPlugin : RoguelikeGameBankViewModel.BankWithdrawModelForSimplePlugin
	{
		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x06020DAD RID: 134573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D0A")]
		public override string withdrawTips
		{
			[Token(Token = "0x6020DAD")]
			[Address(RVA = "0x1B1A350", Offset = "0x1B18F50", VA = "0x181B1A350", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020DAE RID: 134574 RVA: 0x000B7900 File Offset: 0x000B5B00
		[Token(Token = "0x6020DAE")]
		[Address(RVA = "0x1B1A280", Offset = "0x1B18E80", VA = "0x181B1A280", Slot = "8")]
		public override bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x06020DAF RID: 134575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DAF")]
		[Address(RVA = "0x1B1A2F0", Offset = "0x1B18EF0", VA = "0x181B1A2F0")]
		public RL01BankWithdrawModelPlugin()
		{
		}

		// Token: 0x0402CA4A RID: 182858
		[Token(Token = "0x402CA4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_withdrawTips;

		// Token: 0x0402CA4B RID: 182859
		[Token(Token = "0x402CA4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402CA4C RID: 182860
		[Token(Token = "0x402CA4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
