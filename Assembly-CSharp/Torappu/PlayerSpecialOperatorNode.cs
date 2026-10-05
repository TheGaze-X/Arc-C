using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	public class PlayerSpecialOperatorNode
	{
		// Token: 0x060065DB RID: 26075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSpecialOperatorNode()
		{
		}

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x18")]
		public PlayerSpecialOperatorNode.State state;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		// Token: 0x02000904 RID: 2308
		[Token(Token = "0x2000904")]
		public enum State
		{
			// Token: 0x040033A9 RID: 13225
			[Token(Token = "0x40033A9")]
			LOCK,
			// Token: 0x040033AA RID: 13226
			[Token(Token = "0x40033AA")]
			CONFIRMED
		}
	}
}
