using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200714E RID: 29006
	[Token(Token = "0x200714E")]
	public class Act9D0StageEntry : ActivityStageSingleComponent, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x060292DF RID: 168671 RVA: 0x000D4B20 File Offset: 0x000D2D20
		[Token(Token = "0x60292DF")]
		[Address(RVA = "0x24A1EE0", Offset = "0x24A0AE0", VA = "0x1824A1EE0", Slot = "10")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x060292E0 RID: 168672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292E0")]
		[Address(RVA = "0x24A2AD0", Offset = "0x24A16D0", VA = "0x1824A2AD0", Slot = "8")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x060292E1 RID: 168673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E1")]
		[Address(RVA = "0x24A2C60", Offset = "0x24A1860", VA = "0x1824A2C60", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x060292E2 RID: 168674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E2")]
		[Address(RVA = "0x24A2B80", Offset = "0x24A1780", VA = "0x1824A2B80", Slot = "6")]
		protected override void OnBindToParent()
		{
		}

		// Token: 0x060292E3 RID: 168675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E3")]
		[Address(RVA = "0x24A33D0", Offset = "0x24A1FD0", VA = "0x1824A33D0")]
		private void _EventOnStageTimeout()
		{
		}

		// Token: 0x060292E4 RID: 168676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E4")]
		[Address(RVA = "0x24A3310", Offset = "0x24A1F10", VA = "0x1824A3310")]
		private void _EventOnRewardTimeout()
		{
		}

		// Token: 0x060292E5 RID: 168677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E5")]
		[Address(RVA = "0x24A2630", Offset = "0x24A1230", VA = "0x1824A2630")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x060292E6 RID: 168678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E6")]
		[Address(RVA = "0x24A2830", Offset = "0x24A1430", VA = "0x1824A2830")]
		public void EventOnTrapClicked()
		{
		}

		// Token: 0x060292E7 RID: 168679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E7")]
		[Address(RVA = "0x24A21F0", Offset = "0x24A0DF0", VA = "0x1824A21F0")]
		public void EventOnMissionClicked()
		{
		}

		// Token: 0x060292E8 RID: 168680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E8")]
		[Address(RVA = "0x24A2560", Offset = "0x24A1160", VA = "0x1824A2560")]
		public void EventOnReplicateClicked()
		{
		}

		// Token: 0x060292E9 RID: 168681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292E9")]
		[Address(RVA = "0x24A2120", Offset = "0x24A0D20", VA = "0x1824A2120")]
		public void EventOnMedalGroupClicked()
		{
		}

		// Token: 0x060292EA RID: 168682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292EA")]
		[Address(RVA = "0x24A2010", Offset = "0x24A0C10", VA = "0x1824A2010")]
		public void EventOnFavorUpClicked()
		{
		}

		// Token: 0x060292EB RID: 168683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292EB")]
		[Address(RVA = "0x24A2A20", Offset = "0x24A1620", VA = "0x1824A2A20")]
		public void EventOnZoneAllTimeoutClicked()
		{
		}

		// Token: 0x060292EC RID: 168684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292EC")]
		[Address(RVA = "0x24A2330", Offset = "0x24A0F30", VA = "0x1824A2330")]
		public void EventOnReplayEntryAVG()
		{
		}

		// Token: 0x060292ED RID: 168685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292ED")]
		[Address(RVA = "0x24A1E80", Offset = "0x24A0A80", VA = "0x1824A1E80")]
		private void Awake()
		{
		}

		// Token: 0x060292EE RID: 168686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292EE")]
		[Address(RVA = "0x24A2BF0", Offset = "0x24A17F0", VA = "0x1824A2BF0")]
		private void OnEnable()
		{
		}

		// Token: 0x060292EF RID: 168687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292EF")]
		[Address(RVA = "0x24A3430", Offset = "0x24A2030", VA = "0x1824A3430")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x060292F0 RID: 168688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F0")]
		[Address(RVA = "0x24A36C0", Offset = "0x24A22C0", VA = "0x1824A36C0")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x060292F1 RID: 168689 RVA: 0x000D4B38 File Offset: 0x000D2D38
		[Token(Token = "0x60292F1")]
		[Address(RVA = "0x24A3880", Offset = "0x24A2480", VA = "0x1824A3880")]
		private bool _TryResetAnim()
		{
			return default(bool);
		}

		// Token: 0x060292F2 RID: 168690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292F2")]
		[Address(RVA = "0x24A3B30", Offset = "0x24A2730", VA = "0x1824A3B30")]
		private IEnumerator _TryStartAnim()
		{
			return null;
		}

		// Token: 0x060292F3 RID: 168691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F3")]
		[Address(RVA = "0x24A3BE0", Offset = "0x24A27E0", VA = "0x1824A3BE0")]
		private void _UpdateBindToParentStatus()
		{
		}

		// Token: 0x060292F4 RID: 168692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F4")]
		[Address(RVA = "0x24A3750", Offset = "0x24A2350", VA = "0x1824A3750")]
		private void _OnZoneViewClicked(string zoneId)
		{
		}

		// Token: 0x060292F5 RID: 168693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F5")]
		[Address(RVA = "0x24A3CB0", Offset = "0x24A28B0", VA = "0x1824A3CB0")]
		public Act9D0StageEntry()
		{
		}

		// Token: 0x060292F7 RID: 168695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292F7")]
		[Address(RVA = "0x22F6710", Offset = "0x22F5310", VA = "0x1822F6710")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x060292F8 RID: 168696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F8")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x060292F9 RID: 168697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292F9")]
		[Address(RVA = "0x22DDCD0", Offset = "0x22DC8D0", VA = "0x1822DDCD0")]
		private void <>xLuaBaseProxy_OnBindToParent()
		{
		}

		// Token: 0x0403ACD6 RID: 240854
		[Token(Token = "0x403ACD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Animator> _animatorList;

		// Token: 0x0403ACD7 RID: 240855
		[Token(Token = "0x403ACD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act9D0CustomTopMenuBase _customTopMenu;

		// Token: 0x0403ACD8 RID: 240856
		[Token(Token = "0x403ACD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act9D0EntryView _view;

		// Token: 0x0403ACD9 RID: 240857
		[Token(Token = "0x403ACD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act9D0CoinView _coinView;

		// Token: 0x0403ACDA RID: 240858
		[Token(Token = "0x403ACDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act9D0EntryZoneGroupView _zoneGroupView;

		// Token: 0x0403ACDB RID: 240859
		[Token(Token = "0x403ACDB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _favorUpTrackPoint;

		// Token: 0x0403ACDC RID: 240860
		[Token(Token = "0x403ACDC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIActTrackPoint _missionTrackPoint;

		// Token: 0x0403ACDD RID: 240861
		[Token(Token = "0x403ACDD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _templateTrapTrackPoint;

		// Token: 0x0403ACDE RID: 240862
		[Token(Token = "0x403ACDE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _buttonShop;

		// Token: 0x0403ACDF RID: 240863
		[Token(Token = "0x403ACDF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _buttonMission;

		// Token: 0x0403ACE0 RID: 240864
		[Token(Token = "0x403ACE0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403ACE1 RID: 240865
		[Token(Token = "0x403ACE1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _favorUpObj;

		// Token: 0x0403ACE2 RID: 240866
		[Token(Token = "0x403ACE2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _noFavorUpObj;

		// Token: 0x0403ACE3 RID: 240867
		[Token(Token = "0x403ACE3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("BindComponents")]
		[Tooltip("Objects to enable when component binded")]
		private GameObject[] _enableWhenBinded;

		// Token: 0x0403ACE4 RID: 240868
		[Token(Token = "0x403ACE4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("Can be empty if not replicate.")]
		private Act9D0RetroPassRewardView _retroPassRewardView;

		// Token: 0x0403ACE5 RID: 240869
		[Token(Token = "0x403ACE5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Act9D0EntryCgBtnView _cgBtnView;

		// Token: 0x0403ACE6 RID: 240870
		[Token(Token = "0x403ACE6")]
		[FieldOffset(Offset = "0xA0")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403ACE7 RID: 240871
		[Token(Token = "0x403ACE7")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isLoaded;

		// Token: 0x0403ACE8 RID: 240872
		[Token(Token = "0x403ACE8")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_isAnimPlayed;

		// Token: 0x0403ACE9 RID: 240873
		[Token(Token = "0x403ACE9")]
		[FieldOffset(Offset = "0xAA")]
		private bool m_isBindToParent;

		// Token: 0x0403ACEA RID: 240874
		[Token(Token = "0x403ACEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x0403ACEB RID: 240875
		[Token(Token = "0x403ACEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403ACEC RID: 240876
		[Token(Token = "0x403ACEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403ACED RID: 240877
		[Token(Token = "0x403ACED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBindToParent;

		// Token: 0x0403ACEE RID: 240878
		[Token(Token = "0x403ACEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnStageTimeout;

		// Token: 0x0403ACEF RID: 240879
		[Token(Token = "0x403ACEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnRewardTimeout;

		// Token: 0x0403ACF0 RID: 240880
		[Token(Token = "0x403ACF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x0403ACF1 RID: 240881
		[Token(Token = "0x403ACF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnTrapClicked;

		// Token: 0x0403ACF2 RID: 240882
		[Token(Token = "0x403ACF2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnMissionClicked;

		// Token: 0x0403ACF3 RID: 240883
		[Token(Token = "0x403ACF3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnReplicateClicked;

		// Token: 0x0403ACF4 RID: 240884
		[Token(Token = "0x403ACF4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnMedalGroupClicked;

		// Token: 0x0403ACF5 RID: 240885
		[Token(Token = "0x403ACF5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnFavorUpClicked;

		// Token: 0x0403ACF6 RID: 240886
		[Token(Token = "0x403ACF6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnZoneAllTimeoutClicked;

		// Token: 0x0403ACF7 RID: 240887
		[Token(Token = "0x403ACF7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnReplayEntryAVG;

		// Token: 0x0403ACF8 RID: 240888
		[Token(Token = "0x403ACF8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0403ACF9 RID: 240889
		[Token(Token = "0x403ACF9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403ACFA RID: 240890
		[Token(Token = "0x403ACFA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403ACFB RID: 240891
		[Token(Token = "0x403ACFB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0403ACFC RID: 240892
		[Token(Token = "0x403ACFC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryResetAnim;

		// Token: 0x0403ACFD RID: 240893
		[Token(Token = "0x403ACFD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryStartAnim;

		// Token: 0x0403ACFE RID: 240894
		[Token(Token = "0x403ACFE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateBindToParentStatus;

		// Token: 0x0403ACFF RID: 240895
		[Token(Token = "0x403ACFF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnZoneViewClicked;

		// Token: 0x0403AD00 RID: 240896
		[Token(Token = "0x403AD00")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
