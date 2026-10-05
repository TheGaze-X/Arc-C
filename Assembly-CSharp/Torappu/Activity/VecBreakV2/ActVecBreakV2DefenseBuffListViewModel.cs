using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E20 RID: 28192
	[Token(Token = "0x2006E20")]
	public class ActVecBreakV2DefenseBuffListViewModel : IHotfixable
	{
		// Token: 0x06028213 RID: 164371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028213")]
		[Address(RVA = "0x235F6A0", Offset = "0x235E2A0", VA = "0x18235F6A0")]
		public void FetchSelectableList(List<string> selectableList)
		{
		}

		// Token: 0x06028214 RID: 164372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028214")]
		[Address(RVA = "0x235FDA0", Offset = "0x235E9A0", VA = "0x18235FDA0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028215 RID: 164373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028215")]
		[Address(RVA = "0x2360DF0", Offset = "0x235F9F0", VA = "0x182360DF0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x06028216 RID: 164374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028216")]
		[Address(RVA = "0x235FC30", Offset = "0x235E830", VA = "0x18235FC30")]
		public List<string> GetConflictBuffListByStageId(string stageId, out string buffId)
		{
			return null;
		}

		// Token: 0x06028217 RID: 164375 RVA: 0x000D0BC0 File Offset: 0x000CEDC0
		[Token(Token = "0x6028217")]
		[Address(RVA = "0x235FB20", Offset = "0x235E720", VA = "0x18235FB20")]
		public Vector2Int GetBuffItemIndexById(string stageId)
		{
			return default(Vector2Int);
		}

		// Token: 0x06028218 RID: 164376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028218")]
		[Address(RVA = "0x235F8E0", Offset = "0x235E4E0", VA = "0x18235F8E0")]
		public ActVecBreakV2DefenseStageBuffItemModel GetBuffItemById(string buffId)
		{
			return null;
		}

		// Token: 0x06028219 RID: 164377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028219")]
		[Address(RVA = "0x235F810", Offset = "0x235E410", VA = "0x18235F810")]
		public string GetBuffIdByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x0602821A RID: 164378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602821A")]
		[Address(RVA = "0x235FA90", Offset = "0x235E690", VA = "0x18235FA90")]
		public ActVecBreakV2DefenseStageBuffItemModel GetBuffItemByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x0602821B RID: 164379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602821B")]
		[Address(RVA = "0x2360FD0", Offset = "0x235FBD0", VA = "0x182360FD0")]
		private static void _AddBuffListItemWithFillEmpty(List<ActVecBreakV2DefenseBuffListItemModel> buffList, ActVecBreakV2DefenseBuffListItemModel itemModel)
		{
		}

		// Token: 0x0602821C RID: 164380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602821C")]
		[Address(RVA = "0x2361070", Offset = "0x235FC70", VA = "0x182361070")]
		public ActVecBreakV2DefenseBuffListViewModel()
		{
		}

		// Token: 0x04038FA7 RID: 233383
		[Token(Token = "0x4038FA7")]
		private const int BUFF_LIST_SLOT_MAXIMUM = 4;

		// Token: 0x04038FA8 RID: 233384
		[Token(Token = "0x4038FA8")]
		private const int NO_GROUP_BUFF_SLOT_NUM = 1;

		// Token: 0x04038FA9 RID: 233385
		[Token(Token = "0x4038FA9")]
		[FieldOffset(Offset = "0x10")]
		public List<ActVecBreakV2DefenseBuffListItemModel> buffListItems;

		// Token: 0x04038FAA RID: 233386
		[Token(Token = "0x4038FAA")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, ActVecBreakV2DefenseStageBuffItemModel> m_buffItemDict;

		// Token: 0x04038FAB RID: 233387
		[Token(Token = "0x4038FAB")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, ActVecBreakV2DefenseStageBuffGroupModel> m_buffGroupDict;

		// Token: 0x04038FAC RID: 233388
		[Token(Token = "0x4038FAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchSelectableList;

		// Token: 0x04038FAD RID: 233389
		[Token(Token = "0x4038FAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038FAE RID: 233390
		[Token(Token = "0x4038FAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038FAF RID: 233391
		[Token(Token = "0x4038FAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetConflictBuffListByStageId;

		// Token: 0x04038FB0 RID: 233392
		[Token(Token = "0x4038FB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBuffItemIndexById;

		// Token: 0x04038FB1 RID: 233393
		[Token(Token = "0x4038FB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBuffItemById;

		// Token: 0x04038FB2 RID: 233394
		[Token(Token = "0x4038FB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBuffIdByStageId;

		// Token: 0x04038FB3 RID: 233395
		[Token(Token = "0x4038FB3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBuffItemByStageId;

		// Token: 0x04038FB4 RID: 233396
		[Token(Token = "0x4038FB4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddBuffListItemWithFillEmpty;

		// Token: 0x04038FB5 RID: 233397
		[Token(Token = "0x4038FB5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
