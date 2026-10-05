using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001208 RID: 4616
	[Token(Token = "0x2001208")]
	public class RoguelikeArchiveUnlockCondDesc
	{
		// Token: 0x06006FFE RID: 28670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeArchiveUnlockCondDesc()
		{
		}

		// Token: 0x04006358 RID: 25432
		[Token(Token = "0x4006358")]
		[FieldOffset(Offset = "0x10")]
		public ActArchiveType archiveType;

		// Token: 0x04006359 RID: 25433
		[Token(Token = "0x4006359")]
		[FieldOffset(Offset = "0x18")]
		public string description;
	}
}
