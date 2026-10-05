using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DB3 RID: 23987
	[Token(Token = "0x2005DB3")]
	public class ClimbTowerEntryGodCardDetailViewModel : IHotfixable
	{
		// Token: 0x06022C66 RID: 142438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C66")]
		[Address(RVA = "0x1D52610", Offset = "0x1D51210", VA = "0x181D52610")]
		public void LoadData()
		{
		}

		// Token: 0x06022C67 RID: 142439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C67")]
		[Address(RVA = "0x1D52A80", Offset = "0x1D51680", VA = "0x181D52A80")]
		public void SetSelectId(string selectId)
		{
		}

		// Token: 0x06022C68 RID: 142440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C68")]
		[Address(RVA = "0x1D52B60", Offset = "0x1D51760", VA = "0x181D52B60")]
		public ClimbTowerEntryGodCardDetailViewModel()
		{
		}

		// Token: 0x0402FD17 RID: 195863
		[Token(Token = "0x402FD17")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402FD18 RID: 195864
		[Token(Token = "0x402FD18")]
		[FieldOffset(Offset = "0x18")]
		public string selectedCardId;

		// Token: 0x0402FD19 RID: 195865
		[Token(Token = "0x402FD19")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, ClimbTowerEntryGodCardModel> cardModelMap;

		// Token: 0x0402FD1A RID: 195866
		[Token(Token = "0x402FD1A")]
		[FieldOffset(Offset = "0x28")]
		public int seasonNum;

		// Token: 0x0402FD1B RID: 195867
		[Token(Token = "0x402FD1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD1C RID: 195868
		[Token(Token = "0x402FD1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectId;

		// Token: 0x0402FD1D RID: 195869
		[Token(Token = "0x402FD1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
