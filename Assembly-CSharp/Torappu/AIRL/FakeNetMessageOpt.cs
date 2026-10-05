using System;
using Il2CppDummyDll;

namespace Torappu.AIRL
{
	// Token: 0x0200202B RID: 8235
	[Token(Token = "0x200202B")]
	public struct FakeNetMessageOpt
	{
		// Token: 0x0400D4CF RID: 54479
		[Token(Token = "0x400D4CF")]
		[FieldOffset(Offset = "0x0")]
		public int actionType;

		// Token: 0x0400D4D0 RID: 54480
		[Token(Token = "0x400D4D0")]
		[FieldOffset(Offset = "0x4")]
		public uint uniqueId;

		// Token: 0x0400D4D1 RID: 54481
		[Token(Token = "0x400D4D1")]
		[FieldOffset(Offset = "0x8")]
		public string charId;

		// Token: 0x0400D4D2 RID: 54482
		[Token(Token = "0x400D4D2")]
		[FieldOffset(Offset = "0x10")]
		public SharedConsts.Direction direction;

		// Token: 0x0400D4D3 RID: 54483
		[Token(Token = "0x400D4D3")]
		[FieldOffset(Offset = "0x14")]
		public int row;

		// Token: 0x0400D4D4 RID: 54484
		[Token(Token = "0x400D4D4")]
		[FieldOffset(Offset = "0x18")]
		public int col;
	}
}
