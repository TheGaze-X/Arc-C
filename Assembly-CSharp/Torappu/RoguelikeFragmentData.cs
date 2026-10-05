using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011A8 RID: 4520
	[Token(Token = "0x20011A8")]
	public class RoguelikeFragmentData
	{
		// Token: 0x06006F93 RID: 28563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFragmentData()
		{
		}

		// Token: 0x040060C7 RID: 24775
		[Token(Token = "0x40060C7")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040060C8 RID: 24776
		[Token(Token = "0x40060C8")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeFragmentType type;

		// Token: 0x040060C9 RID: 24777
		[Token(Token = "0x40060C9")]
		[FieldOffset(Offset = "0x1C")]
		public int value;

		// Token: 0x040060CA RID: 24778
		[Token(Token = "0x40060CA")]
		[FieldOffset(Offset = "0x20")]
		public int weight;
	}
}
