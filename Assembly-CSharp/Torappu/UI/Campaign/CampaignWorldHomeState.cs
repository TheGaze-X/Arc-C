using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060F5 RID: 24821
	[Token(Token = "0x20060F5")]
	public class CampaignWorldHomeState : PopupFadeState
	{
		// Token: 0x06023DF4 RID: 146932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023DF4")]
		[Address(RVA = "0x1E8AC40", Offset = "0x1E89840", VA = "0x181E8AC40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023DF5 RID: 146933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023DF5")]
		[Address(RVA = "0x1E8B090", Offset = "0x1E89C90", VA = "0x181E8B090", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023DF6 RID: 146934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DF6")]
		[Address(RVA = "0x1E8ACA0", Offset = "0x1E898A0", VA = "0x181E8ACA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023DF7 RID: 146935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DF7")]
		[Address(RVA = "0x1E8AEF0", Offset = "0x1E89AF0", VA = "0x181E8AEF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023DF8 RID: 146936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DF8")]
		[Address(RVA = "0x1E8AD10", Offset = "0x1E89910", VA = "0x181E8AD10", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06023DF9 RID: 146937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DF9")]
		[Address(RVA = "0x1E8AA10", Offset = "0x1E89610", VA = "0x181E8AA10")]
		public void EventOnResetFocusClicked()
		{
		}

		// Token: 0x06023DFA RID: 146938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFA")]
		[Address(RVA = "0x1E8A950", Offset = "0x1E89550", VA = "0x181E8A950")]
		public void EventOnBriefClicked()
		{
		}

		// Token: 0x06023DFB RID: 146939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFB")]
		[Address(RVA = "0x1E8BCC0", Offset = "0x1E8A8C0", VA = "0x181E8BCC0")]
		private void _EventOnCampFeeClicked()
		{
		}

		// Token: 0x06023DFC RID: 146940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFC")]
		[Address(RVA = "0x1E8BBF0", Offset = "0x1E8A7F0", VA = "0x181E8BBF0")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x06023DFD RID: 146941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFD")]
		[Address(RVA = "0x1E8BEA0", Offset = "0x1E8AAA0", VA = "0x181E8BEA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023DFE RID: 146942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFE")]
		[Address(RVA = "0x1E8C1E0", Offset = "0x1E8ADE0", VA = "0x181E8C1E0")]
		private void _OnInitCampFee(GameObject campFeeObj)
		{
		}

		// Token: 0x06023DFF RID: 146943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DFF")]
		[Address(RVA = "0x1E8C720", Offset = "0x1E8B320", VA = "0x181E8C720")]
		private void _TryStartUpdateState()
		{
		}

		// Token: 0x06023E00 RID: 146944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E00")]
		[Address(RVA = "0x1E8C650", Offset = "0x1E8B250", VA = "0x181E8C650")]
		private void _StopUpdateState()
		{
		}

		// Token: 0x06023E01 RID: 146945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E01")]
		[Address(RVA = "0x1E8C940", Offset = "0x1E8B540", VA = "0x181E8C940")]
		private IEnumerator _UpdateState()
		{
			return null;
		}

		// Token: 0x06023E02 RID: 146946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E02")]
		[Address(RVA = "0x1E8BB60", Offset = "0x1E8A760", VA = "0x181E8BB60")]
		private void _CheckGuideBook()
		{
		}

		// Token: 0x06023E03 RID: 146947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E03")]
		[Address(RVA = "0x1E8CEC0", Offset = "0x1E8BAC0", VA = "0x181E8CEC0")]
		private void _WaitGuideBook()
		{
		}

		// Token: 0x06023E04 RID: 146948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E04")]
		[Address(RVA = "0x1E8B7D0", Offset = "0x1E8A3D0", VA = "0x181E8B7D0")]
		private void _CheckBrief()
		{
		}

		// Token: 0x06023E05 RID: 146949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E05")]
		[Address(RVA = "0x1E8CBB0", Offset = "0x1E8B7B0", VA = "0x181E8CBB0")]
		private void _WaitBrief()
		{
		}

		// Token: 0x06023E06 RID: 146950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E06")]
		[Address(RVA = "0x1E8BA00", Offset = "0x1E8A600", VA = "0x181E8BA00")]
		private void _CheckFocus()
		{
		}

		// Token: 0x06023E07 RID: 146951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E07")]
		[Address(RVA = "0x1E8B5A0", Offset = "0x1E8A1A0", VA = "0x181E8B5A0")]
		private void _BeginFocus()
		{
		}

		// Token: 0x06023E08 RID: 146952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E08")]
		[Address(RVA = "0x1E8CD40", Offset = "0x1E8B940", VA = "0x181E8CD40")]
		private void _WaitFocus()
		{
		}

		// Token: 0x06023E09 RID: 146953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E09")]
		[Address(RVA = "0x1E8BD80", Offset = "0x1E8A980", VA = "0x181E8BD80")]
		private void _FogDisappear()
		{
		}

		// Token: 0x06023E0A RID: 146954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E0A")]
		[Address(RVA = "0x1E8C9F0", Offset = "0x1E8B5F0", VA = "0x181E8C9F0")]
		private void _UpdateView()
		{
		}

		// Token: 0x06023E0B RID: 146955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E0B")]
		[Address(RVA = "0x1E8C480", Offset = "0x1E8B080", VA = "0x181E8C480")]
		private void _ResetView()
		{
		}

		// Token: 0x06023E0C RID: 146956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E0C")]
		[Address(RVA = "0x1E8CF30", Offset = "0x1E8BB30", VA = "0x181E8CF30")]
		public CampaignWorldHomeState()
		{
		}

		// Token: 0x06023E0F RID: 146959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E0F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023E10 RID: 146960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E10")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023E11 RID: 146961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E11")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023E12 RID: 146962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E12")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04031C29 RID: 203817
		[Token(Token = "0x4031C29")]
		private const float FOCUS_DURATION = 0.8f;

		// Token: 0x04031C2A RID: 203818
		[Token(Token = "0x4031C2A")]
		private const float BEGIN_FOCUS_WAIT_TIME = 0.5f;

		// Token: 0x04031C2B RID: 203819
		[Token(Token = "0x4031C2B")]
		private const float FOG_DISAPPEAR_WAIT_TIME = 1f;

		// Token: 0x04031C2C RID: 203820
		[Token(Token = "0x4031C2C")]
		private const int ARROW_MAX_COUNT = 6;

		// Token: 0x04031C2D RID: 203821
		[Token(Token = "0x4031C2D")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "campaign_world_home_state";

		// Token: 0x04031C2E RID: 203822
		[Token(Token = "0x4031C2E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04031C2F RID: 203823
		[Token(Token = "0x4031C2F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PrefabInstHolder _campFeeHolder;

		// Token: 0x04031C30 RID: 203824
		[Token(Token = "0x4031C30")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CampaignWorldHomeBriefView _briefView;

		// Token: 0x04031C31 RID: 203825
		[Token(Token = "0x4031C31")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CampaignWorldSwitchTweenObj _btnResetFocus;

		// Token: 0x04031C32 RID: 203826
		[Token(Token = "0x4031C32")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _arrowContainer;

		// Token: 0x04031C33 RID: 203827
		[Token(Token = "0x4031C33")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CampaignWorldSwitchTweenObj _arrowPrefab;

		// Token: 0x04031C34 RID: 203828
		[Token(Token = "0x4031C34")]
		[FieldOffset(Offset = "0xA0")]
		private CampaignWorldHomeState.InternalState m_internalState;

		// Token: 0x04031C35 RID: 203829
		[Token(Token = "0x4031C35")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine m_updateCoroutine;

		// Token: 0x04031C36 RID: 203830
		[Token(Token = "0x4031C36")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x04031C37 RID: 203831
		[Token(Token = "0x4031C37")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_isFocusFinished;

		// Token: 0x04031C38 RID: 203832
		[Token(Token = "0x4031C38")]
		[FieldOffset(Offset = "0xB8")]
		private CampaignFeeView m_campFeeView;

		// Token: 0x04031C39 RID: 203833
		[Token(Token = "0x4031C39")]
		[FieldOffset(Offset = "0xC0")]
		private List<CampaignWorldSwitchTweenObj> m_arrows;

		// Token: 0x04031C3A RID: 203834
		[Token(Token = "0x4031C3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031C3B RID: 203835
		[Token(Token = "0x4031C3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04031C3C RID: 203836
		[Token(Token = "0x4031C3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031C3D RID: 203837
		[Token(Token = "0x4031C3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04031C3E RID: 203838
		[Token(Token = "0x4031C3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04031C3F RID: 203839
		[Token(Token = "0x4031C3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnResetFocusClicked;

		// Token: 0x04031C40 RID: 203840
		[Token(Token = "0x4031C40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBriefClicked;

		// Token: 0x04031C41 RID: 203841
		[Token(Token = "0x4031C41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnCampFeeClicked;

		// Token: 0x04031C42 RID: 203842
		[Token(Token = "0x4031C42")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x04031C43 RID: 203843
		[Token(Token = "0x4031C43")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031C44 RID: 203844
		[Token(Token = "0x4031C44")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInitCampFee;

		// Token: 0x04031C45 RID: 203845
		[Token(Token = "0x4031C45")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryStartUpdateState;

		// Token: 0x04031C46 RID: 203846
		[Token(Token = "0x4031C46")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopUpdateState;

		// Token: 0x04031C47 RID: 203847
		[Token(Token = "0x4031C47")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateState;

		// Token: 0x04031C48 RID: 203848
		[Token(Token = "0x4031C48")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckGuideBook;

		// Token: 0x04031C49 RID: 203849
		[Token(Token = "0x4031C49")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__WaitGuideBook;

		// Token: 0x04031C4A RID: 203850
		[Token(Token = "0x4031C4A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckBrief;

		// Token: 0x04031C4B RID: 203851
		[Token(Token = "0x4031C4B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__WaitBrief;

		// Token: 0x04031C4C RID: 203852
		[Token(Token = "0x4031C4C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckFocus;

		// Token: 0x04031C4D RID: 203853
		[Token(Token = "0x4031C4D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__BeginFocus;

		// Token: 0x04031C4E RID: 203854
		[Token(Token = "0x4031C4E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__WaitFocus;

		// Token: 0x04031C4F RID: 203855
		[Token(Token = "0x4031C4F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FogDisappear;

		// Token: 0x04031C50 RID: 203856
		[Token(Token = "0x4031C50")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04031C51 RID: 203857
		[Token(Token = "0x4031C51")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ResetView;

		// Token: 0x04031C52 RID: 203858
		[Token(Token = "0x4031C52")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060F6 RID: 24822
		[Token(Token = "0x20060F6")]
		public enum InternalState
		{
			// Token: 0x04031C54 RID: 203860
			[Token(Token = "0x4031C54")]
			IDLE,
			// Token: 0x04031C55 RID: 203861
			[Token(Token = "0x4031C55")]
			CHECK_GUIDDE_BOOK,
			// Token: 0x04031C56 RID: 203862
			[Token(Token = "0x4031C56")]
			WAIT_GUIDE_BOOK,
			// Token: 0x04031C57 RID: 203863
			[Token(Token = "0x4031C57")]
			CHECK_BRIEF,
			// Token: 0x04031C58 RID: 203864
			[Token(Token = "0x4031C58")]
			WAIT_BRIEF,
			// Token: 0x04031C59 RID: 203865
			[Token(Token = "0x4031C59")]
			CHECK_FOCUS,
			// Token: 0x04031C5A RID: 203866
			[Token(Token = "0x4031C5A")]
			BEGIN_FOCUS,
			// Token: 0x04031C5B RID: 203867
			[Token(Token = "0x4031C5B")]
			WAIT_FOCUS,
			// Token: 0x04031C5C RID: 203868
			[Token(Token = "0x4031C5C")]
			FOG_DISAPPEAR,
			// Token: 0x04031C5D RID: 203869
			[Token(Token = "0x4031C5D")]
			MARK_READY,
			// Token: 0x04031C5E RID: 203870
			[Token(Token = "0x4031C5E")]
			UPDATE_VIEW
		}
	}
}
