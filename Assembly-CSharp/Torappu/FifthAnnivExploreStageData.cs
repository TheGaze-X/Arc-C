using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200104C RID: 4172
	[Token(Token = "0x200104C")]
	public class FifthAnnivExploreStageData
	{
		// Token: 0x06006DB4 RID: 28084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreStageData()
		{
		}

		// Token: 0x0400589E RID: 22686
		[Token(Token = "0x400589E")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400589F RID: 22687
		[Token(Token = "0x400589F")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040058A0 RID: 22688
		[Token(Token = "0x40058A0")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x040058A1 RID: 22689
		[Token(Token = "0x40058A1")]
		[FieldOffset(Offset = "0x28")]
		public string nextStageId;

		// Token: 0x040058A2 RID: 22690
		[Token(Token = "0x40058A2")]
		[FieldOffset(Offset = "0x30")]
		public int eventCount;

		// Token: 0x040058A3 RID: 22691
		[Token(Token = "0x40058A3")]
		[FieldOffset(Offset = "0x34")]
		public int prevNodeCount;

		// Token: 0x040058A4 RID: 22692
		[Token(Token = "0x40058A4")]
		[FieldOffset(Offset = "0x38")]
		public int stageNum;

		// Token: 0x040058A5 RID: 22693
		[Token(Token = "0x40058A5")]
		[FieldOffset(Offset = "0x3C")]
		public int stageEventNum;

		// Token: 0x040058A6 RID: 22694
		[Token(Token = "0x40058A6")]
		[FieldOffset(Offset = "0x40")]
		public string stageDisplayNum;

		// Token: 0x040058A7 RID: 22695
		[Token(Token = "0x40058A7")]
		[FieldOffset(Offset = "0x48")]
		public string stageFailureDescription;
	}
}
