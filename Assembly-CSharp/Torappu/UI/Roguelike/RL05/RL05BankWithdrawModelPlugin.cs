using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005614 RID: 22036
	[Token(Token = "0x2005614")]
	public class RL05BankWithdrawModelPlugin : RoguelikeGameBankViewModel.BankWithdrawModelForSimplePlugin
	{
		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x06020547 RID: 132423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BB9")]
		public override string withdrawTips
		{
			[Token(Token = "0x6020547")]
			[Address(RVA = "0x1A74780", Offset = "0x1A73380", VA = "0x181A74780", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020548 RID: 132424 RVA: 0x000B56E0 File Offset: 0x000B38E0
		[Token(Token = "0x6020548")]
		[Address(RVA = "0x1A746A0", Offset = "0x1A732A0", VA = "0x181A746A0", Slot = "8")]
		public override bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x06020549 RID: 132425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020549")]
		[Address(RVA = "0x1A74720", Offset = "0x1A73320", VA = "0x181A74720")]
		public RL05BankWithdrawModelPlugin()
		{
		}

		// Token: 0x0402BC22 RID: 179234
		[Token(Token = "0x402BC22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_withdrawTips;

		// Token: 0x0402BC23 RID: 179235
		[Token(Token = "0x402BC23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402BC24 RID: 179236
		[Token(Token = "0x402BC24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
