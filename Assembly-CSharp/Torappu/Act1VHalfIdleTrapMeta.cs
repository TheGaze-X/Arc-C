using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CA3 RID: 3235
	[Token(Token = "0x2000CA3")]
	public class Act1VHalfIdleTrapMeta
	{
		// Token: 0x0600697D RID: 27005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600697D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleTrapMeta()
		{
		}

		// Token: 0x04004217 RID: 16919
		[Token(Token = "0x4004217")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdlePlotType trapType;

		// Token: 0x04004218 RID: 16920
		[Token(Token = "0x4004218")]
		[FieldOffset(Offset = "0x14")]
		public HalfIdleTrapBuildableType buildType;

		// Token: 0x04004219 RID: 16921
		[Token(Token = "0x4004219")]
		[FieldOffset(Offset = "0x18")]
		public int skillIndex;

		// Token: 0x0400421A RID: 16922
		[Token(Token = "0x400421A")]
		[FieldOffset(Offset = "0x1C")]
		public float dropWeight;

		// Token: 0x0400421B RID: 16923
		[Token(Token = "0x400421B")]
		[FieldOffset(Offset = "0x20")]
		public string defaultPlotId;
	}
}
