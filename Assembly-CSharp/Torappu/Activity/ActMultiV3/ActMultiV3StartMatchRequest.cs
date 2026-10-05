using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EDE RID: 28382
	[Token(Token = "0x2006EDE")]
	public class ActMultiV3StartMatchRequest
	{
		// Token: 0x06028566 RID: 165222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028566")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3StartMatchRequest()
		{
		}

		// Token: 0x0403955A RID: 234842
		[Token(Token = "0x403955A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403955B RID: 234843
		[Token(Token = "0x403955B")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3StartMatchRequest.Option option;

		// Token: 0x02006EDF RID: 28383
		[Token(Token = "0x2006EDF")]
		public class Option
		{
			// Token: 0x06028567 RID: 165223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028567")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403955C RID: 234844
			[Token(Token = "0x403955C")]
			[FieldOffset(Offset = "0x10")]
			public List<string> modeList;

			// Token: 0x0403955D RID: 234845
			[Token(Token = "0x403955D")]
			[FieldOffset(Offset = "0x18")]
			public int mentorType;

			// Token: 0x0403955E RID: 234846
			[Token(Token = "0x403955E")]
			[FieldOffset(Offset = "0x1C")]
			public int reverse;
		}
	}
}
