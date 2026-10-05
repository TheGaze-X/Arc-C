using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001294 RID: 4756
	[Token(Token = "0x2001294")]
	public class SandboxV2SeasonData
	{
		// Token: 0x0600720C RID: 29196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2SeasonData()
		{
		}

		// Token: 0x040068D4 RID: 26836
		[Token(Token = "0x40068D4")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2SeasonType seasonType;

		// Token: 0x040068D5 RID: 26837
		[Token(Token = "0x40068D5")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040068D6 RID: 26838
		[Token(Token = "0x40068D6")]
		[FieldOffset(Offset = "0x20")]
		public string functionDesc;

		// Token: 0x040068D7 RID: 26839
		[Token(Token = "0x40068D7")]
		[FieldOffset(Offset = "0x28")]
		public string description;

		// Token: 0x040068D8 RID: 26840
		[Token(Token = "0x40068D8")]
		[FieldOffset(Offset = "0x30")]
		public string color;
	}
}
