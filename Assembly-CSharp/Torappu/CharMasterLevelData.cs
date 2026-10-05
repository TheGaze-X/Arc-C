using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F73 RID: 3955
	[Token(Token = "0x2000F73")]
	public class CharMasterLevelData
	{
		// Token: 0x06006CA2 RID: 27810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharMasterLevelData()
		{
		}

		// Token: 0x040053F7 RID: 21495
		[Token(Token = "0x40053F7")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x040053F8 RID: 21496
		[Token(Token = "0x40053F8")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040053F9 RID: 21497
		[Token(Token = "0x40053F9")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x040053FA RID: 21498
		[Token(Token = "0x40053FA")]
		[FieldOffset(Offset = "0x28")]
		public string conditionDesc;
	}
}
