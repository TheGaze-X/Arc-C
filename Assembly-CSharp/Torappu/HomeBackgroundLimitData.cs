using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF1 RID: 4081
	[Token(Token = "0x2000FF1")]
	public class HomeBackgroundLimitData
	{
		// Token: 0x06006D4A RID: 27978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeBackgroundLimitData()
		{
		}

		// Token: 0x04005691 RID: 22161
		[Token(Token = "0x4005691")]
		[FieldOffset(Offset = "0x10")]
		public string bgId;

		// Token: 0x04005692 RID: 22162
		[Token(Token = "0x4005692")]
		[FieldOffset(Offset = "0x18")]
		public List<HomeBackgroundLimitInfoData> limitInfos;
	}
}
