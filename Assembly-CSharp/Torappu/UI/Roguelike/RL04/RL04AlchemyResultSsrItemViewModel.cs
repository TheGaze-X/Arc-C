using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005666 RID: 22118
	[Token(Token = "0x2005666")]
	public class RL04AlchemyResultSsrItemViewModel : IHotfixable
	{
		// Token: 0x06020725 RID: 132901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020725")]
		[Address(RVA = "0x1A9CB30", Offset = "0x1A9B730", VA = "0x181A9CB30")]
		public RL04AlchemyResultSsrItemViewModel()
		{
		}

		// Token: 0x0402BF0D RID: 179981
		[Token(Token = "0x402BF0D")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0402BF0E RID: 179982
		[Token(Token = "0x402BF0E")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x0402BF0F RID: 179983
		[Token(Token = "0x402BF0F")]
		[FieldOffset(Offset = "0x20")]
		public string itemName;

		// Token: 0x0402BF10 RID: 179984
		[Token(Token = "0x402BF10")]
		[FieldOffset(Offset = "0x28")]
		public string itemDesc;

		// Token: 0x0402BF11 RID: 179985
		[Token(Token = "0x402BF11")]
		[FieldOffset(Offset = "0x30")]
		public bool isMulti;

		// Token: 0x0402BF12 RID: 179986
		[Token(Token = "0x402BF12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
