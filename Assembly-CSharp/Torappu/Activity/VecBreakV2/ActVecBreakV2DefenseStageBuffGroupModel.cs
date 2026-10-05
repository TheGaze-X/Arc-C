using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E1E RID: 28190
	[Token(Token = "0x2006E1E")]
	public class ActVecBreakV2DefenseStageBuffGroupModel : IHotfixable, IComparable<ActVecBreakV2DefenseStageBuffGroupModel>
	{
		// Token: 0x0602820F RID: 164367 RVA: 0x000D0BA8 File Offset: 0x000CEDA8
		[Token(Token = "0x602820F")]
		[Address(RVA = "0x2364480", Offset = "0x2363080", VA = "0x182364480", Slot = "4")]
		public int CompareTo(ActVecBreakV2DefenseStageBuffGroupModel other)
		{
			return 0;
		}

		// Token: 0x06028210 RID: 164368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028210")]
		[Address(RVA = "0x2364560", Offset = "0x2363160", VA = "0x182364560")]
		public void LoadData(string stageGroupId, ActVecBreakV2DefenseGroupData groupData, ListDict<string, ActVecBreakV2DefenseStageBuffItemModel> buffItemDict)
		{
		}

		// Token: 0x06028211 RID: 164369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028211")]
		[Address(RVA = "0x2364800", Offset = "0x2363400", VA = "0x182364800")]
		public ActVecBreakV2DefenseStageBuffGroupModel()
		{
		}

		// Token: 0x04038F9B RID: 233371
		[Token(Token = "0x4038F9B")]
		[FieldOffset(Offset = "0x10")]
		public string stageGroupId;

		// Token: 0x04038F9C RID: 233372
		[Token(Token = "0x4038F9C")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04038F9D RID: 233373
		[Token(Token = "0x4038F9D")]
		[FieldOffset(Offset = "0x20")]
		public List<ActVecBreakV2DefenseStageBuffItemModel> buffList;

		// Token: 0x04038F9E RID: 233374
		[Token(Token = "0x4038F9E")]
		[FieldOffset(Offset = "0x28")]
		public List<string> conflictBuffIdList;

		// Token: 0x04038F9F RID: 233375
		[Token(Token = "0x4038F9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04038FA0 RID: 233376
		[Token(Token = "0x4038FA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038FA1 RID: 233377
		[Token(Token = "0x4038FA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
