using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC7 RID: 8135
	[Token(Token = "0x2001FC7")]
	public class MusicData
	{
		// Token: 0x0600C9FE RID: 51710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MusicData()
		{
		}

		// Token: 0x0400D286 RID: 53894
		[Token(Token = "0x400D286")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400D287 RID: 53895
		[Token(Token = "0x400D287")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400D288 RID: 53896
		[Token(Token = "0x400D288")]
		[FieldOffset(Offset = "0x20")]
		public string bank;
	}
}
