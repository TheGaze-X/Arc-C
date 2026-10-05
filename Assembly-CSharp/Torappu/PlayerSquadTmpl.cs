using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public class PlayerSquadTmpl
	{
		// Token: 0x060065A1 RID: 26017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSquadTmpl()
		{
		}

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x10")]
		public int skillIndex;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x18")]
		public string currentEquip;
	}
}
