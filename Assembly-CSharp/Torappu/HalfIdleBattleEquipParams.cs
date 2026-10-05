using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001082 RID: 4226
	[Token(Token = "0x2001082")]
	public class HalfIdleBattleEquipParams
	{
		// Token: 0x06006E12 RID: 28178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HalfIdleBattleEquipParams()
		{
		}

		// Token: 0x04005A44 RID: 23108
		[Token(Token = "0x4005A44")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleEquipData equipData;

		// Token: 0x04005A45 RID: 23109
		[Token(Token = "0x4005A45")]
		[FieldOffset(Offset = "0x18")]
		public uint equipUid;
	}
}
