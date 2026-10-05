using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010A1 RID: 4257
	[Token(Token = "0x20010A1")]
	public class HotUpdateMetaMovieData : ITimeValidInfo
	{
		// Token: 0x06006E2C RID: 28204 RVA: 0x00031F68 File Offset: 0x00030168
		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x00031F80 File Offset: 0x00030180
		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HotUpdateMetaMovieData()
		{
		}

		// Token: 0x04005AD0 RID: 23248
		[Token(Token = "0x4005AD0")]
		[FieldOffset(Offset = "0x10")]
		public string videoId;

		// Token: 0x04005AD1 RID: 23249
		[Token(Token = "0x4005AD1")]
		[FieldOffset(Offset = "0x18")]
		public string videoPath;

		// Token: 0x04005AD2 RID: 23250
		[Token(Token = "0x4005AD2")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04005AD3 RID: 23251
		[Token(Token = "0x4005AD3")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
