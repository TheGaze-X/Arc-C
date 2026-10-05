using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200115E RID: 4446
	[Token(Token = "0x200115E")]
	public class RoguelikeReward
	{
		// Token: 0x06006F3D RID: 28477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0x21123F0", Offset = "0x2110FF0", VA = "0x1821123F0")]
		public RoguelikeReward()
		{
		}

		// Token: 0x04005F39 RID: 24377
		[Token(Token = "0x4005F39")]
		[FieldOffset(Offset = "0x10")]
		public string index;

		// Token: 0x04005F3A RID: 24378
		[Token(Token = "0x4005F3A")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeItemBundle> items;

		// Token: 0x04005F3B RID: 24379
		[Token(Token = "0x4005F3B")]
		[FieldOffset(Offset = "0x20")]
		public bool done;

		// Token: 0x04005F3C RID: 24380
		[Token(Token = "0x4005F3C")]
		[FieldOffset(Offset = "0x21")]
		public bool exDrop;

		// Token: 0x04005F3D RID: 24381
		[Token(Token = "0x4005F3D")]
		[FieldOffset(Offset = "0x28")]
		public string exDropSrc;
	}
}
