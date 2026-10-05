using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FCB RID: 4043
	[Token(Token = "0x2000FCB")]
	public class CrisisV2BagRoadData
	{
		// Token: 0x06006D19 RID: 27929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BagRoadData()
		{
		}

		// Token: 0x040055DA RID: 21978
		[Token(Token = "0x40055DA")]
		[FieldOffset(Offset = "0x10")]
		public List<string> nodeRoadList;
	}
}
