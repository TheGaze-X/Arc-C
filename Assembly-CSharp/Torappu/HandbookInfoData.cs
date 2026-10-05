using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200109A RID: 4250
	[Token(Token = "0x200109A")]
	[Serializable]
	public class HandbookInfoData
	{
		// Token: 0x06006E25 RID: 28197 RVA: 0x00031F50 File Offset: 0x00030150
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
		public bool ShouldSerializeisLimited()
		{
			return default(bool);
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0x21057E0", Offset = "0x21043E0", VA = "0x1821057E0")]
		public HandbookInfoData()
		{
		}

		// Token: 0x04005AAF RID: 23215
		[Token(Token = "0x4005AAF")]
		[FieldOffset(Offset = "0x10")]
		public string charID;

		// Token: 0x04005AB0 RID: 23216
		[Token(Token = "0x4005AB0")]
		[FieldOffset(Offset = "0x18")]
		public string infoName;

		// Token: 0x04005AB1 RID: 23217
		[Token(Token = "0x4005AB1")]
		[FieldOffset(Offset = "0x20")]
		public bool isLimited;

		// Token: 0x04005AB2 RID: 23218
		[Token(Token = "0x4005AB2")]
		[FieldOffset(Offset = "0x28")]
		public HandBookStoryViewData[] storyTextAudio;

		// Token: 0x04005AB3 RID: 23219
		[Token(Token = "0x4005AB3")]
		[FieldOffset(Offset = "0x30")]
		public List<HandbookAvgGroupData> handbookAvgList;
	}
}
