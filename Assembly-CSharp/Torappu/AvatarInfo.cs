using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008E7 RID: 2279
	[Token(Token = "0x20008E7")]
	[Serializable]
	public class AvatarInfo
	{
		// Token: 0x060065A0 RID: 26016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AvatarInfo()
		{
		}

		// Token: 0x0400332D RID: 13101
		[Token(Token = "0x400332D")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarType type;

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}
}
