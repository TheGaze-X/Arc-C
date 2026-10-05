using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD7 RID: 20439
	[Token(Token = "0x2004FD7")]
	public class EnemyDuelOperationModeViewModel : IHotfixable
	{
		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x0601E594 RID: 124308 RVA: 0x000AE378 File Offset: 0x000AC578
		[Token(Token = "0x170046F4")]
		public bool isMoneyEnough
		{
			[Token(Token = "0x601E594")]
			[Address(RVA = "0x1819610", Offset = "0x1818210", VA = "0x181819610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x0601E595 RID: 124309 RVA: 0x000AE390 File Offset: 0x000AC590
		[Token(Token = "0x170046F5")]
		public bool useExBet
		{
			[Token(Token = "0x601E595")]
			[Address(RVA = "0x1819670", Offset = "0x1818270", VA = "0x181819670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E596 RID: 124310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E596")]
		[Address(RVA = "0x18195B0", Offset = "0x18181B0", VA = "0x1818195B0")]
		public EnemyDuelOperationModeViewModel()
		{
		}

		// Token: 0x04028927 RID: 166183
		[Token(Token = "0x4028927")]
		[FieldOffset(Offset = "0x10")]
		public int totalMoney;

		// Token: 0x04028928 RID: 166184
		[Token(Token = "0x4028928")]
		[FieldOffset(Offset = "0x14")]
		public int betMoney;

		// Token: 0x04028929 RID: 166185
		[Token(Token = "0x4028929")]
		[FieldOffset(Offset = "0x18")]
		public int expectationMoney;

		// Token: 0x0402892A RID: 166186
		[Token(Token = "0x402892A")]
		[FieldOffset(Offset = "0x1C")]
		public bool isExBet;

		// Token: 0x0402892B RID: 166187
		[Token(Token = "0x402892B")]
		[FieldOffset(Offset = "0x20")]
		public int playerRank;

		// Token: 0x0402892C RID: 166188
		[Token(Token = "0x402892C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isMoneyEnough;

		// Token: 0x0402892D RID: 166189
		[Token(Token = "0x402892D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useExBet;

		// Token: 0x0402892E RID: 166190
		[Token(Token = "0x402892E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
