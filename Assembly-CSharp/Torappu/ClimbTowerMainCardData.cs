using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F99 RID: 3993
	[Token(Token = "0x2000F99")]
	public class ClimbTowerMainCardData
	{
		// Token: 0x06006CD9 RID: 27865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerMainCardData()
		{
		}

		// Token: 0x040054DA RID: 21722
		[Token(Token = "0x40054DA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054DB RID: 21723
		[Token(Token = "0x40054DB")]
		[FieldOffset(Offset = "0x18")]
		public ClimbTowerCardType type;

		// Token: 0x040054DC RID: 21724
		[Token(Token = "0x40054DC")]
		[FieldOffset(Offset = "0x20")]
		public string linkedTowerId;

		// Token: 0x040054DD RID: 21725
		[Token(Token = "0x40054DD")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x040054DE RID: 21726
		[Token(Token = "0x40054DE")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x040054DF RID: 21727
		[Token(Token = "0x40054DF")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x040054E0 RID: 21728
		[Token(Token = "0x40054E0")]
		[FieldOffset(Offset = "0x40")]
		public List<string> subCardIds;

		// Token: 0x040054E1 RID: 21729
		[Token(Token = "0x40054E1")]
		[FieldOffset(Offset = "0x48")]
		public RuneTable.PackedRuneData runeData;

		// Token: 0x040054E2 RID: 21730
		[Token(Token = "0x40054E2")]
		[FieldOffset(Offset = "0x50")]
		public List<string> trapIds;
	}
}
