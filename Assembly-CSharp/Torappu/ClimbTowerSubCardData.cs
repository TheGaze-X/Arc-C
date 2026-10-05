using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F9A RID: 3994
	[Token(Token = "0x2000F9A")]
	public class ClimbTowerSubCardData
	{
		// Token: 0x06006CDA RID: 27866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSubCardData()
		{
		}

		// Token: 0x040054E3 RID: 21731
		[Token(Token = "0x40054E3")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054E4 RID: 21732
		[Token(Token = "0x40054E4")]
		[FieldOffset(Offset = "0x18")]
		public string mainCardId;

		// Token: 0x040054E5 RID: 21733
		[Token(Token = "0x40054E5")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x040054E6 RID: 21734
		[Token(Token = "0x40054E6")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x040054E7 RID: 21735
		[Token(Token = "0x40054E7")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x040054E8 RID: 21736
		[Token(Token = "0x40054E8")]
		[FieldOffset(Offset = "0x38")]
		public RuneTable.PackedRuneData runeData;

		// Token: 0x040054E9 RID: 21737
		[Token(Token = "0x40054E9")]
		[FieldOffset(Offset = "0x40")]
		public List<string> trapIds;
	}
}
