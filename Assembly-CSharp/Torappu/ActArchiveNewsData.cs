using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3D RID: 3133
	[Token(Token = "0x2000C3D")]
	[Serializable]
	public class ActArchiveNewsData
	{
		// Token: 0x0600691D RID: 26909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691D")]
		[Address(RVA = "0x1FF8C30", Offset = "0x1FF7830", VA = "0x181FF8C30")]
		public ActArchiveNewsData()
		{
		}

		// Token: 0x04004000 RID: 16384
		[Token(Token = "0x4004000")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveNewsItemData> news;
	}
}
