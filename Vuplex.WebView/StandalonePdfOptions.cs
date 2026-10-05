using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public class StandalonePdfOptions
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x56B5700", Offset = "0x56B4300", VA = "0x1856B5700")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x56B5700", Offset = "0x56B4300", VA = "0x1856B5700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x5BBB010", Offset = "0x5BB9C10", VA = "0x185BBB010")]
		public StandalonePdfOptions()
		{
		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x10")]
		public bool Landscape;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x14")]
		public float MarginBottom;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x18")]
		public float MarginLeft;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x1C")]
		public float MarginRight;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x20")]
		public float MarginTop;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x24")]
		public StandalonePdfMarginType MarginType;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		public string PageRanges;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x30")]
		public float PaperHeight;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x34")]
		public float PaperWidth;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x38")]
		public bool PreferCssPageSize;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x39")]
		public bool PrintBackground;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x3C")]
		public float Scale;
	}
}
