using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EAB RID: 28331
	[Token(Token = "0x2006EAB")]
	public class VecBreakV2SetDefendRequest
	{
		// Token: 0x060284D2 RID: 165074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2SetDefendRequest()
		{
		}

		// Token: 0x0403946A RID: 234602
		[Token(Token = "0x403946A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403946B RID: 234603
		[Token(Token = "0x403946B")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403946C RID: 234604
		[Token(Token = "0x403946C")]
		[FieldOffset(Offset = "0x20")]
		public List<VecBreakV2DefendSlot> squadSlots;
	}
}
