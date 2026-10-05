using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200584E RID: 22606
	[Token(Token = "0x200584E")]
	public class RL03BankWithdrawModelPlugin : RoguelikeGameBankViewModel.BankWithdrawModelForSimplePlugin
	{
		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x0602105D RID: 135261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D7B")]
		public override string withdrawTips
		{
			[Token(Token = "0x602105D")]
			[Address(RVA = "0x1B5C970", Offset = "0x1B5B570", VA = "0x181B5C970", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602105E RID: 135262 RVA: 0x000B8338 File Offset: 0x000B6538
		[Token(Token = "0x602105E")]
		[Address(RVA = "0x1B5C890", Offset = "0x1B5B490", VA = "0x181B5C890", Slot = "8")]
		public override bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x0602105F RID: 135263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602105F")]
		[Address(RVA = "0x1B5C910", Offset = "0x1B5B510", VA = "0x181B5C910")]
		public RL03BankWithdrawModelPlugin()
		{
		}

		// Token: 0x0402CEA5 RID: 183973
		[Token(Token = "0x402CEA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_withdrawTips;

		// Token: 0x0402CEA6 RID: 183974
		[Token(Token = "0x402CEA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402CEA7 RID: 183975
		[Token(Token = "0x402CEA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
