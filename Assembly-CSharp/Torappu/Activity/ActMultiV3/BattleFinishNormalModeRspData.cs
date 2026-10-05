using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ECC RID: 28364
	[Token(Token = "0x2006ECC")]
	public class BattleFinishNormalModeRspData
	{
		// Token: 0x06028543 RID: 165187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028543")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishNormalModeRspData()
		{
		}

		// Token: 0x0403952C RID: 234796
		[Token(Token = "0x403952C")]
		[FieldOffset(Offset = "0x10")]
		public bool failTip;

		// Token: 0x0403952D RID: 234797
		[Token(Token = "0x403952D")]
		[FieldOffset(Offset = "0x18")]
		public List<BattleFinishNormalModeRspData.ProgressRspData> targets;

		// Token: 0x0403952E RID: 234798
		[Token(Token = "0x403952E")]
		[FieldOffset(Offset = "0x20")]
		public bool newStar;

		// Token: 0x02006ECD RID: 28365
		[Token(Token = "0x2006ECD")]
		public class ProgressRspData
		{
			// Token: 0x06028544 RID: 165188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028544")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProgressRspData()
			{
			}

			// Token: 0x0403952F RID: 234799
			[Token(Token = "0x403952F")]
			[FieldOffset(Offset = "0x10")]
			public bool complete;

			// Token: 0x04039530 RID: 234800
			[Token(Token = "0x4039530")]
			[FieldOffset(Offset = "0x18")]
			public List<string> progressShow;

			// Token: 0x04039531 RID: 234801
			[Token(Token = "0x4039531")]
			[FieldOffset(Offset = "0x20")]
			public List<float> progressValue;
		}
	}
}
