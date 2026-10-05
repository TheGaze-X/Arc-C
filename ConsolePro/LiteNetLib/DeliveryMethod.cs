using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public enum DeliveryMethod : byte
	{
		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		Unreliable = 4,
		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		ReliableUnordered = 0,
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		Sequenced,
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		ReliableOrdered,
		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		ReliableSequenced
	}
}
