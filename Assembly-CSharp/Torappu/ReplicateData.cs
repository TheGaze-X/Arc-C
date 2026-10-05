using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001134 RID: 4404
	[Token(Token = "0x2001134")]
	public class ReplicateData
	{
		// Token: 0x06006F0A RID: 28426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReplicateData()
		{
		}

		// Token: 0x04005E62 RID: 24162
		[Token(Token = "0x4005E62")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle item;

		// Token: 0x04005E63 RID: 24163
		[Token(Token = "0x4005E63")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle replicateTokenItem;
	}
}
