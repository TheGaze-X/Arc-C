using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	public class PlayerEvents
	{
		// Token: 0x060066F2 RID: 26354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F2")]
		[Address(RVA = "0x1EFA0A0", Offset = "0x1EF8CA0", VA = "0x181EFA0A0")]
		public PlayerEvents()
		{
		}

		// Token: 0x040037FA RID: 14330
		[Token(Token = "0x40037FA")]
		[FieldOffset(Offset = "0x10")]
		public DateTime building;

		// Token: 0x040037FB RID: 14331
		[Token(Token = "0x40037FB")]
		[FieldOffset(Offset = "0x18")]
		public long status;
	}
}
