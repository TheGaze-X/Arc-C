using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FDB RID: 4059
	[Token(Token = "0x2000FDB")]
	public class CrisisV2SharedData
	{
		// Token: 0x06006D30 RID: 27952 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		[Token(Token = "0x6006D30")]
		[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050")]
		public bool ShouldSerializerecalRuneData()
		{
			return default(bool);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D31")]
		[Address(RVA = "0x2101630", Offset = "0x2100230", VA = "0x182101630")]
		public CrisisV2SharedData()
		{
		}

		// Token: 0x0400561E RID: 22046
		[Token(Token = "0x400561E")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CrisisV2SeasonInfo> seasonInfoDataMap;

		// Token: 0x0400561F RID: 22047
		[Token(Token = "0x400561F")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<int, CrisisV2AppraiseWrap> scoreLevelToAppraiseDataMap;

		// Token: 0x04005620 RID: 22048
		[Token(Token = "0x4005620")]
		[FieldOffset(Offset = "0x20")]
		public CrisisV2ConstData constData;

		// Token: 0x04005621 RID: 22049
		[Token(Token = "0x4005621")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<RuneData>> battleCommentRuneData;

		// Token: 0x04005622 RID: 22050
		[Token(Token = "0x4005622")]
		[FieldOffset(Offset = "0x30")]
		public RecalRuneSharedData recalRuneData;
	}
}
