using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DC1 RID: 24001
	[Token(Token = "0x2005DC1")]
	public class ClimbTowerItemRewardModel : IHotfixable
	{
		// Token: 0x06022C85 RID: 142469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C85")]
		[Address(RVA = "0x1D55A60", Offset = "0x1D54660", VA = "0x181D55A60")]
		public void LoadData(bool isHard)
		{
		}

		// Token: 0x06022C86 RID: 142470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C86")]
		[Address(RVA = "0x1D55CE0", Offset = "0x1D548E0", VA = "0x181D55CE0")]
		public void SwitchMode(bool isHardMode)
		{
		}

		// Token: 0x06022C87 RID: 142471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C87")]
		[Address(RVA = "0x1D55D50", Offset = "0x1D54950", VA = "0x181D55D50")]
		public ClimbTowerItemRewardModel()
		{
		}

		// Token: 0x0402FD72 RID: 195954
		[Token(Token = "0x402FD72")]
		[FieldOffset(Offset = "0x10")]
		public int lowerItemCurr;

		// Token: 0x0402FD73 RID: 195955
		[Token(Token = "0x402FD73")]
		[FieldOffset(Offset = "0x14")]
		public int lowerItemTotal;

		// Token: 0x0402FD74 RID: 195956
		[Token(Token = "0x402FD74")]
		[FieldOffset(Offset = "0x18")]
		public string lowerItemName;

		// Token: 0x0402FD75 RID: 195957
		[Token(Token = "0x402FD75")]
		[FieldOffset(Offset = "0x20")]
		public int higherItemCurr;

		// Token: 0x0402FD76 RID: 195958
		[Token(Token = "0x402FD76")]
		[FieldOffset(Offset = "0x24")]
		public int higherItemTotal;

		// Token: 0x0402FD77 RID: 195959
		[Token(Token = "0x402FD77")]
		[FieldOffset(Offset = "0x28")]
		public string higherItemName;

		// Token: 0x0402FD78 RID: 195960
		[Token(Token = "0x402FD78")]
		[FieldOffset(Offset = "0x30")]
		public string countDownText;

		// Token: 0x0402FD79 RID: 195961
		[Token(Token = "0x402FD79")]
		[FieldOffset(Offset = "0x38")]
		public bool isHard;

		// Token: 0x0402FD7A RID: 195962
		[Token(Token = "0x402FD7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD7B RID: 195963
		[Token(Token = "0x402FD7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x0402FD7C RID: 195964
		[Token(Token = "0x402FD7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
