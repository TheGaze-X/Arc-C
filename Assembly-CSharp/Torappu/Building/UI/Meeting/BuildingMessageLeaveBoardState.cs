using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D1A RID: 7450
	[Token(Token = "0x2001D1A")]
	public class BuildingMessageLeaveBoardState : State, IPlayerDataListener, IHotfixable, ICompDialogCallBack
	{
		// Token: 0x0600B7DD RID: 47069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7DD")]
		[Address(RVA = "0x333B370", Offset = "0x3339F70", VA = "0x18333B370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DE")]
		[Address(RVA = "0x333BF80", Offset = "0x333AB80", VA = "0x18333BF80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7DF")]
		[Address(RVA = "0x333B660", Offset = "0x333A260", VA = "0x18333B660", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x000452E8 File Offset: 0x000434E8
		[Token(Token = "0x600B7E0")]
		[Address(RVA = "0x333CA90", Offset = "0x333B690", VA = "0x18333CA90")]
		private bool _TryOpenLastWeekRewardView(BuildingMessageLeaveBoardModel model)
		{
			return default(bool);
		}

		// Token: 0x0600B7E1 RID: 47073 RVA: 0x00045300 File Offset: 0x00043500
		[Token(Token = "0x600B7E1")]
		[Address(RVA = "0x333B030", Offset = "0x3339C30", VA = "0x18333B030", Slot = "23")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E2")]
		[Address(RVA = "0x333BB80", Offset = "0x333A780", VA = "0x18333BB80", Slot = "24")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E3")]
		[Address(RVA = "0x333C3B0", Offset = "0x333AFB0", VA = "0x18333C3B0")]
		private void _InitViews(BuildingMessageLeaveBoardProperty property)
		{
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7E4")]
		[Address(RVA = "0x333C860", Offset = "0x333B460", VA = "0x18333C860")]
		private IEnumerator _PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E5")]
		[Address(RVA = "0x333C2E0", Offset = "0x333AEE0", VA = "0x18333C2E0")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E6")]
		[Address(RVA = "0x333C580", Offset = "0x333B180", VA = "0x18333C580")]
		private void _OnClickClose()
		{
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E7")]
		[Address(RVA = "0x333C6F0", Offset = "0x333B2F0", VA = "0x18333C6F0")]
		private void _OnGetSocialPointProceed(BuildingPayloadConfirmMessageBoardRewardResponse response)
		{
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E8")]
		[Address(RVA = "0x333C910", Offset = "0x333B510", VA = "0x18333C910")]
		private void _ShowSocialPointRewardToast(int rewardCount)
		{
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E9")]
		[Address(RVA = "0x333BCF0", Offset = "0x333A8F0", VA = "0x18333BCF0")]
		private void _EventOnClickVisitorAvatar(IMessageBoardVisitorData visitorData)
		{
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EA")]
		[Address(RVA = "0x333B0E0", Offset = "0x3339CE0", VA = "0x18333B0E0")]
		public void EventOnClickGetSocialPointReward()
		{
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EB")]
		[Address(RVA = "0x333B600", Offset = "0x333A200", VA = "0x18333B600")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EC")]
		[Address(RVA = "0x333B5A0", Offset = "0x333A1A0", VA = "0x18333B5A0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7ED")]
		[Address(RVA = "0x333B490", Offset = "0x333A090", VA = "0x18333B490")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EE")]
		[Address(RVA = "0x333B3D0", Offset = "0x3339FD0", VA = "0x18333B3D0", Slot = "25")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EF")]
		[Address(RVA = "0x333CDE0", Offset = "0x333B9E0", VA = "0x18333CDE0")]
		public BuildingMessageLeaveBoardState()
		{
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7F2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400B5C0 RID: 46528
		[Token(Token = "0x400B5C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0400B5C1 RID: 46529
		[Token(Token = "0x400B5C1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _blurBackground;

		// Token: 0x0400B5C2 RID: 46530
		[Token(Token = "0x400B5C2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingTwoContentNotify _socialRewardNotify;

		// Token: 0x0400B5C3 RID: 46531
		[Token(Token = "0x400B5C3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingMessageLeaveBoardTopView _topView;

		// Token: 0x0400B5C4 RID: 46532
		[Token(Token = "0x400B5C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400B5C5 RID: 46533
		[Token(Token = "0x400B5C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuildingMessageLeaveBoardVisitorView _visitorsView;

		// Token: 0x0400B5C6 RID: 46534
		[Token(Token = "0x400B5C6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildingMessageLeaveBoardRewardItemView _rewardItemView;

		// Token: 0x0400B5C7 RID: 46535
		[Token(Token = "0x400B5C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildingMessageLeaveBoardBottomInfoView _bottomInfoView;

		// Token: 0x0400B5C8 RID: 46536
		[Token(Token = "0x400B5C8")]
		[FieldOffset(Offset = "0x98")]
		private BuildingMessageLeaveBoardStateBean m_stateBean;

		// Token: 0x0400B5C9 RID: 46537
		[Token(Token = "0x400B5C9")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0400B5CA RID: 46538
		[Token(Token = "0x400B5CA")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_entryTween;

		// Token: 0x0400B5CB RID: 46539
		[Token(Token = "0x400B5CB")]
		[FieldOffset(Offset = "0xB0")]
		private int m_visitorInfoDlgInstId;

		// Token: 0x0400B5CC RID: 46540
		[Token(Token = "0x400B5CC")]
		[FieldOffset(Offset = "0xB4")]
		private int m_lastWeekRewardDlgInstId;

		// Token: 0x0400B5CD RID: 46541
		[Token(Token = "0x400B5CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B5CE RID: 46542
		[Token(Token = "0x400B5CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B5CF RID: 46543
		[Token(Token = "0x400B5CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B5D0 RID: 46544
		[Token(Token = "0x400B5D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryOpenLastWeekRewardView;

		// Token: 0x0400B5D1 RID: 46545
		[Token(Token = "0x400B5D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0400B5D2 RID: 46546
		[Token(Token = "0x400B5D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400B5D3 RID: 46547
		[Token(Token = "0x400B5D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitViews;

		// Token: 0x0400B5D4 RID: 46548
		[Token(Token = "0x400B5D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0400B5D5 RID: 46549
		[Token(Token = "0x400B5D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400B5D6 RID: 46550
		[Token(Token = "0x400B5D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClickClose;

		// Token: 0x0400B5D7 RID: 46551
		[Token(Token = "0x400B5D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGetSocialPointProceed;

		// Token: 0x0400B5D8 RID: 46552
		[Token(Token = "0x400B5D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowSocialPointRewardToast;

		// Token: 0x0400B5D9 RID: 46553
		[Token(Token = "0x400B5D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnClickVisitorAvatar;

		// Token: 0x0400B5DA RID: 46554
		[Token(Token = "0x400B5DA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnClickGetSocialPointReward;

		// Token: 0x0400B5DB RID: 46555
		[Token(Token = "0x400B5DB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400B5DC RID: 46556
		[Token(Token = "0x400B5DC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400B5DD RID: 46557
		[Token(Token = "0x400B5DD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B5DE RID: 46558
		[Token(Token = "0x400B5DE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0400B5DF RID: 46559
		[Token(Token = "0x400B5DF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
