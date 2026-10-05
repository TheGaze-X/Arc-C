using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200102A RID: 4138
	[Token(Token = "0x200102A")]
	public class StickerData
	{
		// Token: 0x06006D7B RID: 28027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7B")]
		[Address(RVA = "0x2116450", Offset = "0x2115050", VA = "0x182116450")]
		public StickerData()
		{
		}

		// Token: 0x040057E1 RID: 22497
		[Token(Token = "0x40057E1")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, StickerItemData> stickerMap;
	}
}
