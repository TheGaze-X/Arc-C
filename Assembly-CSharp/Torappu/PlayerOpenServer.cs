using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	public class PlayerOpenServer
	{
		// Token: 0x060065D7 RID: 26071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D7")]
		[Address(RVA = "0x1EFBFC0", Offset = "0x1EFABC0", VA = "0x181EFBFC0")]
		public PlayerOpenServer()
		{
		}

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x10")]
		public OpenServerChainLogin chainLogin;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0x18")]
		public OpenServerCheckIn checkIn;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x20")]
		public OpenServerFullOpen fullOpen;
	}
}
