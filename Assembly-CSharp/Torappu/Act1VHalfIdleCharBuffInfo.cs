using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB3 RID: 3251
	[Token(Token = "0x2000CB3")]
	public class Act1VHalfIdleCharBuffInfo
	{
		// Token: 0x06006993 RID: 27027 RVA: 0x00030DC8 File Offset: 0x0002EFC8
		[Token(Token = "0x6006993")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
		public bool ShouldSerializeruneData()
		{
			return default(bool);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006994")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharBuffInfo()
		{
		}

		// Token: 0x04004253 RID: 16979
		[Token(Token = "0x4004253")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004254 RID: 16980
		[Token(Token = "0x4004254")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04004255 RID: 16981
		[Token(Token = "0x4004255")]
		[FieldOffset(Offset = "0x1C")]
		public int charCount;

		// Token: 0x04004256 RID: 16982
		[Token(Token = "0x4004256")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04004257 RID: 16983
		[Token(Token = "0x4004257")]
		[FieldOffset(Offset = "0x28")]
		public RuneTable.PackedRuneData runeData;
	}
}
