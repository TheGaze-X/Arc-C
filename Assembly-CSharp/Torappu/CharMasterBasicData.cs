using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F74 RID: 3956
	[Token(Token = "0x2000F74")]
	public class CharMasterBasicData
	{
		// Token: 0x06006CA3 RID: 27811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharMasterBasicData()
		{
		}

		// Token: 0x040053FB RID: 21499
		[Token(Token = "0x40053FB")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x040053FC RID: 21500
		[Token(Token = "0x40053FC")]
		[FieldOffset(Offset = "0x18")]
		public string masterId;

		// Token: 0x040053FD RID: 21501
		[Token(Token = "0x40053FD")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x040053FE RID: 21502
		[Token(Token = "0x40053FE")]
		[FieldOffset(Offset = "0x24")]
		public CharMasterType masterType;

		// Token: 0x040053FF RID: 21503
		[Token(Token = "0x40053FF")]
		[FieldOffset(Offset = "0x28")]
		public List<CharMasterLevelData> levelList;
	}
}
