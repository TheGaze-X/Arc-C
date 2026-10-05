using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C37 RID: 3127
	[Token(Token = "0x2000C37")]
	public class ActArchiveFragmentData
	{
		// Token: 0x06006917 RID: 26903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006917")]
		[Address(RVA = "0x1FF8B10", Offset = "0x1FF7710", VA = "0x181FF8B10")]
		public ActArchiveFragmentData()
		{
		}

		// Token: 0x04003FF2 RID: 16370
		[Token(Token = "0x4003FF2")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveFragmentItemData> fragment;
	}
}
