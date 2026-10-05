using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	[Serializable]
	public class ActArchiveRelicData
	{
		// Token: 0x06006924 RID: 26916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006924")]
		[Address(RVA = "0x1FF8E70", Offset = "0x1FF7A70", VA = "0x181FF8E70")]
		public ActArchiveRelicData()
		{
		}

		// Token: 0x0400400F RID: 16399
		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveRelicItemData> relic;
	}
}
