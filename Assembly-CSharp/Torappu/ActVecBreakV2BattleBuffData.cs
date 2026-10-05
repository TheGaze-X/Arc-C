using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E66 RID: 3686
	[Token(Token = "0x2000E66")]
	public class ActVecBreakV2BattleBuffData
	{
		// Token: 0x06006B35 RID: 27445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B35")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2BattleBuffData()
		{
		}

		// Token: 0x04004D25 RID: 19749
		[Token(Token = "0x4004D25")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04004D26 RID: 19750
		[Token(Token = "0x4004D26")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04004D27 RID: 19751
		[Token(Token = "0x4004D27")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04004D28 RID: 19752
		[Token(Token = "0x4004D28")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04004D29 RID: 19753
		[Token(Token = "0x4004D29")]
		[FieldOffset(Offset = "0x30")]
		public RuneTable.PackedRuneData runeData;
	}
}
