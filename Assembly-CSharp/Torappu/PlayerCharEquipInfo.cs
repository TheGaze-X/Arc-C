using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008F7 RID: 2295
	[Token(Token = "0x20008F7")]
	[Serializable]
	public class PlayerCharEquipInfo
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCharEquipInfo()
		{
		}

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[FieldOffset(Offset = "0x10")]
		public bool locked;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[FieldOffset(Offset = "0x14")]
		public int level;
	}
}
