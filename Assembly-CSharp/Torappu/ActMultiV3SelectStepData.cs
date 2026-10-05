using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E3C RID: 3644
	[Token(Token = "0x2000E3C")]
	public class ActMultiV3SelectStepData
	{
		// Token: 0x06006B0A RID: 27402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SelectStepData()
		{
		}

		// Token: 0x04004BE0 RID: 19424
		[Token(Token = "0x4004BE0")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3PrepareStepType stepType;

		// Token: 0x04004BE1 RID: 19425
		[Token(Token = "0x4004BE1")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x04004BE2 RID: 19426
		[Token(Token = "0x4004BE2")]
		[FieldOffset(Offset = "0x18")]
		public int time;

		// Token: 0x04004BE3 RID: 19427
		[Token(Token = "0x4004BE3")]
		[FieldOffset(Offset = "0x1C")]
		public int hintTime;

		// Token: 0x04004BE4 RID: 19428
		[Token(Token = "0x4004BE4")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x04004BE5 RID: 19429
		[Token(Token = "0x4004BE5")]
		[FieldOffset(Offset = "0x28")]
		public string desc;
	}
}
