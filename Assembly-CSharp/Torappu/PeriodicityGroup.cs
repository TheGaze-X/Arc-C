using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200089B RID: 2203
	[Token(Token = "0x200089B")]
	public class PeriodicityGroup
	{
		// Token: 0x0600653A RID: 25914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x1EED330", Offset = "0x1EEBF30", VA = "0x181EED330")]
		public PeriodicityGroup()
		{
		}

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		[FieldOffset(Offset = "0x18")]
		public long startDateTime;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		[FieldOffset(Offset = "0x20")]
		public long endDateTime;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PeriodicityGPItem> packages;
	}
}
