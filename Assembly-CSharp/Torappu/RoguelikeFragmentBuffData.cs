using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011AB RID: 4523
	[Token(Token = "0x20011AB")]
	public class RoguelikeFragmentBuffData
	{
		// Token: 0x06006F96 RID: 28566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F96")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFragmentBuffData()
		{
		}

		// Token: 0x040060DA RID: 24794
		[Token(Token = "0x40060DA")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040060DB RID: 24795
		[Token(Token = "0x40060DB")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeEventType maskType;

		// Token: 0x040060DC RID: 24796
		[Token(Token = "0x40060DC")]
		[FieldOffset(Offset = "0x20")]
		public string desc;
	}
}
