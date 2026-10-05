using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class HandBookUnlockStoryCharBuildRequest
	{
		// Token: 0x060063D3 RID: 25555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookUnlockStoryCharBuildRequest()
		{
		}

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x18")]
		public string storyId;
	}
}
