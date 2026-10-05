using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class HalfIdleData
	{
		// Token: 0x06006997 RID: 27031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006997")]
		[Address(RVA = "0x200A020", Offset = "0x2008C20", VA = "0x18200A020")]
		public HalfIdleData()
		{
		}

		// Token: 0x04004273 RID: 17011
		[Token(Token = "0x4004273")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act1VHalfIdleItemData> itemData;
	}
}
