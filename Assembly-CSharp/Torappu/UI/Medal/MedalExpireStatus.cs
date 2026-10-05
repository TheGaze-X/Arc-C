using System;
using Il2CppDummyDll;

namespace Torappu.UI.Medal
{
	// Token: 0x0200499A RID: 18842
	[Token(Token = "0x200499A")]
	public struct MedalExpireStatus
	{
		// Token: 0x040252EC RID: 152300
		[Token(Token = "0x40252EC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MedalExpireStatus NOT_EXPIRED;

		// Token: 0x040252ED RID: 152301
		[Token(Token = "0x40252ED")]
		[FieldOffset(Offset = "0x0")]
		public bool isExpired;

		// Token: 0x040252EE RID: 152302
		[Token(Token = "0x40252EE")]
		[FieldOffset(Offset = "0x4")]
		public MedalExpireType expireType;
	}
}
