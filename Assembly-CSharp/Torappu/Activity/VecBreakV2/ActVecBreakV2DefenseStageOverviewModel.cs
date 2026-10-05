using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E29 RID: 28201
	[Token(Token = "0x2006E29")]
	public class ActVecBreakV2DefenseStageOverviewModel : IHotfixable
	{
		// Token: 0x0602823B RID: 164411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602823B")]
		[Address(RVA = "0x2368CB0", Offset = "0x23678B0", VA = "0x182368CB0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602823C RID: 164412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602823C")]
		[Address(RVA = "0x2368DA0", Offset = "0x23679A0", VA = "0x182368DA0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0602823D RID: 164413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602823D")]
		[Address(RVA = "0x2368BF0", Offset = "0x23677F0", VA = "0x182368BF0")]
		public string GetRemoveSquadNotifyToast(string stageId)
		{
			return null;
		}

		// Token: 0x0602823E RID: 164414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602823E")]
		[Address(RVA = "0x2368F30", Offset = "0x2367B30", VA = "0x182368F30")]
		public ActVecBreakV2DefenseStageOverviewModel()
		{
		}

		// Token: 0x04039001 RID: 233473
		[Token(Token = "0x4039001")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2DefenseStageDetailViewModel stageDetailModel;

		// Token: 0x04039002 RID: 233474
		[Token(Token = "0x4039002")]
		[FieldOffset(Offset = "0x18")]
		public ActVecBreakV2DefenseBuffListViewModel buffListModel;

		// Token: 0x04039003 RID: 233475
		[Token(Token = "0x4039003")]
		[FieldOffset(Offset = "0x20")]
		public List<string> selectedBuffIdList;

		// Token: 0x04039004 RID: 233476
		[Token(Token = "0x4039004")]
		[FieldOffset(Offset = "0x28")]
		public string defenseRemoveSquadSingleText;

		// Token: 0x04039005 RID: 233477
		[Token(Token = "0x4039005")]
		[FieldOffset(Offset = "0x30")]
		public string defenseRemoveSquadGroupText;

		// Token: 0x04039006 RID: 233478
		[Token(Token = "0x4039006")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039007 RID: 233479
		[Token(Token = "0x4039007")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04039008 RID: 233480
		[Token(Token = "0x4039008")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRemoveSquadNotifyToast;

		// Token: 0x04039009 RID: 233481
		[Token(Token = "0x4039009")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
