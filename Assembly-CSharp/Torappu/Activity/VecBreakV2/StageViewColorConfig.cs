using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DDC RID: 28124
	[Token(Token = "0x2006DDC")]
	[Serializable]
	public class StageViewColorConfig
	{
		// Token: 0x060280AB RID: 164011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280AB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageViewColorConfig()
		{
		}

		// Token: 0x04038C99 RID: 232601
		[Token(Token = "0x4038C99")]
		[FieldOffset(Offset = "0x10")]
		public StageViewType viewType;

		// Token: 0x04038C9A RID: 232602
		[Token(Token = "0x4038C9A")]
		[FieldOffset(Offset = "0x14")]
		public Color bgColor;

		// Token: 0x04038C9B RID: 232603
		[Token(Token = "0x4038C9B")]
		[FieldOffset(Offset = "0x24")]
		public Color contentColor;

		// Token: 0x04038C9C RID: 232604
		[Token(Token = "0x4038C9C")]
		[FieldOffset(Offset = "0x34")]
		public Color lineColor;
	}
}
