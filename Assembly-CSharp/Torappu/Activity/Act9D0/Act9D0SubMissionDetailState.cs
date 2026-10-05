using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200715E RID: 29022
	[Token(Token = "0x200715E")]
	public class Act9D0SubMissionDetailState : PopupFloatState
	{
		// Token: 0x06029354 RID: 168788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029354")]
		[Address(RVA = "0x24A4850", Offset = "0x24A3450", VA = "0x1824A4850")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029355 RID: 168789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029355")]
		[Address(RVA = "0x24A43C0", Offset = "0x24A2FC0", VA = "0x1824A43C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029356 RID: 168790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029356")]
		[Address(RVA = "0x24A4420", Offset = "0x24A3020", VA = "0x1824A4420", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029357 RID: 168791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029357")]
		[Address(RVA = "0x24A4130", Offset = "0x24A2D30", VA = "0x1824A4130")]
		public void EventOnMissionObjClicked()
		{
		}

		// Token: 0x06029358 RID: 168792 RVA: 0x000D4C10 File Offset: 0x000D2E10
		[Token(Token = "0x6029358")]
		[Address(RVA = "0x24A4790", Offset = "0x24A3390", VA = "0x1824A4790")]
		private bool _CheckIfAbleToFinishTask()
		{
			return default(bool);
		}

		// Token: 0x06029359 RID: 168793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029359")]
		[Address(RVA = "0x24A4980", Offset = "0x24A3580", VA = "0x1824A4980")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602935A RID: 168794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602935A")]
		[Address(RVA = "0x24A4A50", Offset = "0x24A3650", VA = "0x1824A4A50")]
		public Act9D0SubMissionDetailState()
		{
		}

		// Token: 0x0602935C RID: 168796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602935C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403AD57 RID: 240983
		[Token(Token = "0x403AD57")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act9D0SubMissionDetailView _detailView;

		// Token: 0x0403AD58 RID: 240984
		[Token(Token = "0x403AD58")]
		[FieldOffset(Offset = "0x78")]
		private Act9D0SubMissionStateBean m_stateBean;

		// Token: 0x0403AD59 RID: 240985
		[Token(Token = "0x403AD59")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isMissionConfirmSent;

		// Token: 0x0403AD5A RID: 240986
		[Token(Token = "0x403AD5A")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isInited;

		// Token: 0x0403AD5B RID: 240987
		[Token(Token = "0x403AD5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AD5C RID: 240988
		[Token(Token = "0x403AD5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AD5D RID: 240989
		[Token(Token = "0x403AD5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AD5E RID: 240990
		[Token(Token = "0x403AD5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMissionObjClicked;

		// Token: 0x0403AD5F RID: 240991
		[Token(Token = "0x403AD5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfAbleToFinishTask;

		// Token: 0x0403AD60 RID: 240992
		[Token(Token = "0x403AD60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403AD61 RID: 240993
		[Token(Token = "0x403AD61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
