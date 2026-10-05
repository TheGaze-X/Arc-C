using System;
using Il2CppDummyDll;

namespace BestHTTP.Statistics
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	public struct GeneralStatistics
	{
		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x0")]
		public StatisticsQueryFlags QueryFlags;

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x4")]
		public int Connections;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x8")]
		public int ActiveConnections;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0xC")]
		public int FreeConnections;

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		[FieldOffset(Offset = "0x10")]
		public int RecycledConnections;

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x14")]
		public int RequestsInQueue;

		// Token: 0x0400164D RID: 5709
		[Token(Token = "0x400164D")]
		[FieldOffset(Offset = "0x18")]
		public int CacheEntityCount;

		// Token: 0x0400164E RID: 5710
		[Token(Token = "0x400164E")]
		[FieldOffset(Offset = "0x20")]
		public ulong CacheSize;

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x28")]
		public int CookieCount;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x2C")]
		public uint CookieJarSize;
	}
}
