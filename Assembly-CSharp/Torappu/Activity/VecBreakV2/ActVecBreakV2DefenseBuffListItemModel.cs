using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E1F RID: 28191
	[Token(Token = "0x2006E1F")]
	public class ActVecBreakV2DefenseBuffListItemModel : IHotfixable
	{
		// Token: 0x06028212 RID: 164370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028212")]
		[Address(RVA = "0x235EB70", Offset = "0x235D770", VA = "0x18235EB70")]
		public ActVecBreakV2DefenseBuffListItemModel()
		{
		}

		// Token: 0x04038FA2 RID: 233378
		[Token(Token = "0x4038FA2")]
		[FieldOffset(Offset = "0x10")]
		public List<ActVecBreakV2DefenseStageBuffItemModel> buffItemList;

		// Token: 0x04038FA3 RID: 233379
		[Token(Token = "0x4038FA3")]
		[FieldOffset(Offset = "0x18")]
		public List<ActVecBreakV2DefenseStageBuffGroupModel> buffGroupList;

		// Token: 0x04038FA4 RID: 233380
		[Token(Token = "0x4038FA4")]
		[FieldOffset(Offset = "0x20")]
		public int buffSlotNum;

		// Token: 0x04038FA5 RID: 233381
		[Token(Token = "0x4038FA5")]
		[FieldOffset(Offset = "0x24")]
		public int emptySlotNum;

		// Token: 0x04038FA6 RID: 233382
		[Token(Token = "0x4038FA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
