using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001180 RID: 4480
	[Token(Token = "0x2001180")]
	public struct RoguelikeWeightedValue<T>
	{
		// Token: 0x06006F6E RID: 28526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6E")]
		public RoguelikeWeightedValue(int weight, T value)
		{
		}

		// Token: 0x0400600C RID: 24588
		[Token(Token = "0x400600C")]
		[FieldOffset(Offset = "0x0")]
		public int weight;

		// Token: 0x0400600D RID: 24589
		[Token(Token = "0x400600D")]
		[FieldOffset(Offset = "0x0")]
		public T value;
	}
}
