using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005710 RID: 22288
	[Token(Token = "0x2005710")]
	public class RL04BankWithdrawModelPlugin : RoguelikeGameBankViewModel.BankWithdrawModelForSimplePlugin
	{
		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x06020ACB RID: 133835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CA0")]
		public override string withdrawTips
		{
			[Token(Token = "0x6020ACB")]
			[Address(RVA = "0x1B0EFB0", Offset = "0x1B0DBB0", VA = "0x181B0EFB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020ACC RID: 133836 RVA: 0x000B6C70 File Offset: 0x000B4E70
		[Token(Token = "0x6020ACC")]
		[Address(RVA = "0x1B0EED0", Offset = "0x1B0DAD0", VA = "0x181B0EED0", Slot = "8")]
		public override bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x06020ACD RID: 133837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ACD")]
		[Address(RVA = "0x1B0EF50", Offset = "0x1B0DB50", VA = "0x181B0EF50")]
		public RL04BankWithdrawModelPlugin()
		{
		}

		// Token: 0x0402C57B RID: 181627
		[Token(Token = "0x402C57B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_withdrawTips;

		// Token: 0x0402C57C RID: 181628
		[Token(Token = "0x402C57C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402C57D RID: 181629
		[Token(Token = "0x402C57D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
