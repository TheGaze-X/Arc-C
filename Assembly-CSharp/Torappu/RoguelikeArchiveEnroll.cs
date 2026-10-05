using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001209 RID: 4617
	[Token(Token = "0x2001209")]
	public class RoguelikeArchiveEnroll
	{
		// Token: 0x06006FFF RID: 28671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeArchiveEnroll()
		{
		}

		// Token: 0x0400635A RID: 25434
		[Token(Token = "0x400635A")]
		[FieldOffset(Offset = "0x10")]
		public ActArchiveType archiveType;

		// Token: 0x0400635B RID: 25435
		[Token(Token = "0x400635B")]
		[FieldOffset(Offset = "0x18")]
		public string enrollId;
	}
}
