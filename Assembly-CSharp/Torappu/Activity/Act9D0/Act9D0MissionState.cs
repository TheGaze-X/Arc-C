using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007158 RID: 29016
	[Token(Token = "0x2007158")]
	public class Act9D0MissionState : PopupFloatState
	{
		// Token: 0x06029323 RID: 168739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029323")]
		[Address(RVA = "0x249B990", Offset = "0x249A590", VA = "0x18249B990", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029324 RID: 168740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029324")]
		[Address(RVA = "0x249B9F0", Offset = "0x249A5F0", VA = "0x18249B9F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029325 RID: 168741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029325")]
		[Address(RVA = "0x249C060", Offset = "0x249AC60", VA = "0x18249C060")]
		private void _RefreshView()
		{
		}

		// Token: 0x06029326 RID: 168742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029326")]
		[Address(RVA = "0x249B380", Offset = "0x2499F80", VA = "0x18249B380")]
		public void EventOnMissionClaimAllClicked()
		{
		}

		// Token: 0x06029327 RID: 168743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029327")]
		[Address(RVA = "0x249B720", Offset = "0x249A320", VA = "0x18249B720")]
		public void EventOnMissionObjClicked(string missionId)
		{
		}

		// Token: 0x06029328 RID: 168744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029328")]
		[Address(RVA = "0x249BFB0", Offset = "0x249ABB0", VA = "0x18249BFB0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06029329 RID: 168745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029329")]
		[Address(RVA = "0x249BE70", Offset = "0x249AA70", VA = "0x18249BE70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602932A RID: 168746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602932A")]
		[Address(RVA = "0x249C110", Offset = "0x249AD10", VA = "0x18249C110")]
		public Act9D0MissionState()
		{
		}

		// Token: 0x0602932E RID: 168750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602932E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403AD22 RID: 240930
		[Token(Token = "0x403AD22")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act9D0MissionBaseView _view;

		// Token: 0x0403AD23 RID: 240931
		[Token(Token = "0x403AD23")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act9D0CoinView _coinView;

		// Token: 0x0403AD24 RID: 240932
		[Token(Token = "0x403AD24")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403AD25 RID: 240933
		[Token(Token = "0x403AD25")]
		[FieldOffset(Offset = "0x88")]
		private Act9D0MissionStateBean m_stateBean;

		// Token: 0x0403AD26 RID: 240934
		[Token(Token = "0x403AD26")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403AD27 RID: 240935
		[Token(Token = "0x403AD27")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0403AD28 RID: 240936
		[Token(Token = "0x403AD28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AD29 RID: 240937
		[Token(Token = "0x403AD29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AD2A RID: 240938
		[Token(Token = "0x403AD2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0403AD2B RID: 240939
		[Token(Token = "0x403AD2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMissionClaimAllClicked;

		// Token: 0x0403AD2C RID: 240940
		[Token(Token = "0x403AD2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMissionObjClicked;

		// Token: 0x0403AD2D RID: 240941
		[Token(Token = "0x403AD2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403AD2E RID: 240942
		[Token(Token = "0x403AD2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AD2F RID: 240943
		[Token(Token = "0x403AD2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
