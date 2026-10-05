using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C4D RID: 3149
	[Token(Token = "0x2000C4D")]
	[Serializable]
	public class ActArchiveTrapData
	{
		// Token: 0x06006931 RID: 26929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006931")]
		[Address(RVA = "0x1FF9100", Offset = "0x1FF7D00", VA = "0x181FF9100")]
		public ActArchiveTrapData()
		{
		}

		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x400402C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveTrapItemData> trap;
	}
}
