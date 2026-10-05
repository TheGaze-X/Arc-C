using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x0200181D RID: 6173
	[Token(Token = "0x200181D")]
	public struct TradingOrderRequireStruct
	{
		// Token: 0x06009C20 RID: 39968 RVA: 0x0003CD98 File Offset: 0x0003AF98
		[Token(Token = "0x6009C20")]
		[Address(RVA = "0x3189570", Offset = "0x3188170", VA = "0x183189570")]
		public bool IsFulfilled()
		{
			return default(bool);
		}

		// Token: 0x04009313 RID: 37651
		[Token(Token = "0x4009313")]
		[FieldOffset(Offset = "0x0")]
		public string itemId;

		// Token: 0x04009314 RID: 37652
		[Token(Token = "0x4009314")]
		[FieldOffset(Offset = "0x8")]
		public ItemType itemType;

		// Token: 0x04009315 RID: 37653
		[Token(Token = "0x4009315")]
		[FieldOffset(Offset = "0xC")]
		public int requireCount;

		// Token: 0x04009316 RID: 37654
		[Token(Token = "0x4009316")]
		[FieldOffset(Offset = "0x10")]
		public int reserve;
	}
}
