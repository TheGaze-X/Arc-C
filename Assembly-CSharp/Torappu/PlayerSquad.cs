using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008EE RID: 2286
	[Token(Token = "0x20008EE")]
	public class PlayerSquad
	{
		// Token: 0x060065B4 RID: 26036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSquad()
		{
		}

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x10")]
		public int squadId;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSquadItem[] slots;
	}
}
