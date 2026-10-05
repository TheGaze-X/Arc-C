using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010A4 RID: 4260
	[Token(Token = "0x20010A4")]
	public class HotUpdateMetaTable
	{
		// Token: 0x06006E32 RID: 28210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E32")]
		[Address(RVA = "0x2105DA0", Offset = "0x21049A0", VA = "0x182105DA0")]
		public HotUpdateMetaTable()
		{
		}

		// Token: 0x04005AE0 RID: 23264
		[Token(Token = "0x4005AE0")]
		[FieldOffset(Offset = "0x10")]
		public List<HotUpdateMetaPicData> picList;

		// Token: 0x04005AE1 RID: 23265
		[Token(Token = "0x4005AE1")]
		[FieldOffset(Offset = "0x18")]
		public HotUpdateMetaMovieData movieInfo;
	}
}
