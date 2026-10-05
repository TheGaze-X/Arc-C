using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F9B RID: 3995
	[Token(Token = "0x2000F9B")]
	public class ClimbTowerCurseCardData
	{
		// Token: 0x06006CDB RID: 27867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerCurseCardData()
		{
		}

		// Token: 0x040054EA RID: 21738
		[Token(Token = "0x40054EA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054EB RID: 21739
		[Token(Token = "0x40054EB")]
		[FieldOffset(Offset = "0x18")]
		public List<string> towerIdList;

		// Token: 0x040054EC RID: 21740
		[Token(Token = "0x40054EC")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040054ED RID: 21741
		[Token(Token = "0x40054ED")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x040054EE RID: 21742
		[Token(Token = "0x40054EE")]
		[FieldOffset(Offset = "0x30")]
		public string trapId;
	}
}
