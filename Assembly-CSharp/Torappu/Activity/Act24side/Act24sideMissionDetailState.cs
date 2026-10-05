using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075D0 RID: 30160
	[Token(Token = "0x20075D0")]
	public class Act24sideMissionDetailState : PopupFloatState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602A76E RID: 173934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A76E")]
		[Address(RVA = "0x2624650", Offset = "0x2623250", VA = "0x182624650", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A76F RID: 173935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A76F")]
		[Address(RVA = "0x2624750", Offset = "0x2623350", VA = "0x182624750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A770 RID: 173936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A770")]
		[Address(RVA = "0x26249B0", Offset = "0x26235B0", VA = "0x1826249B0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A771 RID: 173937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A771")]
		[Address(RVA = "0x26253D0", Offset = "0x2623FD0", VA = "0x1826253D0")]
		private void _RefreshData()
		{
		}

		// Token: 0x0602A772 RID: 173938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A772")]
		[Address(RVA = "0x2625900", Offset = "0x2624500", VA = "0x182625900")]
		private void _RefreshStageMeldingData()
		{
		}

		// Token: 0x0602A773 RID: 173939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A773")]
		[Address(RVA = "0x26257C0", Offset = "0x26243C0", VA = "0x1826257C0")]
		private void _RefreshEntryMissionData()
		{
		}

		// Token: 0x0602A774 RID: 173940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A774")]
		[Address(RVA = "0x2624B00", Offset = "0x2623700", VA = "0x182624B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A775 RID: 173941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A775")]
		[Address(RVA = "0x26245D0", Offset = "0x26231D0", VA = "0x1826245D0", Slot = "32")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602A776 RID: 173942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A776")]
		[Address(RVA = "0x26246B0", Offset = "0x26232B0", VA = "0x1826246B0")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x0602A777 RID: 173943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A777")]
		[Address(RVA = "0x2625030", Offset = "0x2623C30", VA = "0x182625030")]
		private void _OnClickLeftArrowBtn()
		{
		}

		// Token: 0x0602A778 RID: 173944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A778")]
		[Address(RVA = "0x2625190", Offset = "0x2623D90", VA = "0x182625190")]
		private void _OnClickRightArrowBtn()
		{
		}

		// Token: 0x0602A779 RID: 173945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A779")]
		[Address(RVA = "0x2624D30", Offset = "0x2623930", VA = "0x182624D30")]
		private void _OnClickCompleteBtn(string missionId)
		{
		}

		// Token: 0x0602A77A RID: 173946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A77A")]
		[Address(RVA = "0x2625300", Offset = "0x2623F00", VA = "0x182625300")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602A77B RID: 173947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A77B")]
		[Address(RVA = "0x2625A80", Offset = "0x2624680", VA = "0x182625A80")]
		public Act24sideMissionDetailState()
		{
		}

		// Token: 0x0602A77D RID: 173949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A77D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A77E RID: 173950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A77E")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403D1D8 RID: 250328
		[Token(Token = "0x403D1D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideMissionDetailView _view;

		// Token: 0x0403D1D9 RID: 250329
		[Token(Token = "0x403D1D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403D1DA RID: 250330
		[Token(Token = "0x403D1DA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403D1DB RID: 250331
		[Token(Token = "0x403D1DB")]
		[FieldOffset(Offset = "0x90")]
		private Act24sideMissionDetailStateBean m_stateBean;

		// Token: 0x0403D1DC RID: 250332
		[Token(Token = "0x403D1DC")]
		[FieldOffset(Offset = "0x98")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403D1DD RID: 250333
		[Token(Token = "0x403D1DD")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403D1DE RID: 250334
		[Token(Token = "0x403D1DE")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_entryTween;

		// Token: 0x0403D1DF RID: 250335
		[Token(Token = "0x403D1DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D1E0 RID: 250336
		[Token(Token = "0x403D1E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D1E1 RID: 250337
		[Token(Token = "0x403D1E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403D1E2 RID: 250338
		[Token(Token = "0x403D1E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0403D1E3 RID: 250339
		[Token(Token = "0x403D1E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshStageMeldingData;

		// Token: 0x0403D1E4 RID: 250340
		[Token(Token = "0x403D1E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshEntryMissionData;

		// Token: 0x0403D1E5 RID: 250341
		[Token(Token = "0x403D1E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D1E6 RID: 250342
		[Token(Token = "0x403D1E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403D1E7 RID: 250343
		[Token(Token = "0x403D1E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0403D1E8 RID: 250344
		[Token(Token = "0x403D1E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClickLeftArrowBtn;

		// Token: 0x0403D1E9 RID: 250345
		[Token(Token = "0x403D1E9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClickRightArrowBtn;

		// Token: 0x0403D1EA RID: 250346
		[Token(Token = "0x403D1EA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnClickCompleteBtn;

		// Token: 0x0403D1EB RID: 250347
		[Token(Token = "0x403D1EB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403D1EC RID: 250348
		[Token(Token = "0x403D1EC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
