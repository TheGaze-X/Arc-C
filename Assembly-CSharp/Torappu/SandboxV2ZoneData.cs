using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001296 RID: 4758
	[Token(Token = "0x2001296")]
	public class SandboxV2ZoneData
	{
		// Token: 0x0600720E RID: 29198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ZoneData()
		{
		}

		// Token: 0x040068E0 RID: 26848
		[Token(Token = "0x40068E0")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x040068E1 RID: 26849
		[Token(Token = "0x40068E1")]
		[FieldOffset(Offset = "0x18")]
		public string zoneName;

		// Token: 0x040068E2 RID: 26850
		[Token(Token = "0x40068E2")]
		[FieldOffset(Offset = "0x20")]
		public bool displayName;

		// Token: 0x040068E3 RID: 26851
		[Token(Token = "0x40068E3")]
		[FieldOffset(Offset = "0x28")]
		public string appellation;
	}
}
