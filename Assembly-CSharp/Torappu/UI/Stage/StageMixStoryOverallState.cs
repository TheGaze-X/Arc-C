using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.Stage.MixStory;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006886 RID: 26758
	[Token(Token = "0x2006886")]
	public class StageMixStoryOverallState : UIPopupState, IValueMsgReceiver
	{
		// Token: 0x0602654F RID: 157007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602654F")]
		[Address(RVA = "0x2166490", Offset = "0x2165090", VA = "0x182166490", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026550 RID: 157008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026550")]
		[Address(RVA = "0x2166960", Offset = "0x2165560", VA = "0x182166960", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06026551 RID: 157009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026551")]
		[Address(RVA = "0x2167C30", Offset = "0x2166830", VA = "0x182167C30")]
		private void _OnSelectZone(string storySetId, string zoneId)
		{
		}

		// Token: 0x06026552 RID: 157010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026552")]
		[Address(RVA = "0x2167810", Offset = "0x2166410", VA = "0x182167810")]
		private void _JumpToZone(string storySetId, string zoneId)
		{
		}

		// Token: 0x06026553 RID: 157011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026553")]
		[Address(RVA = "0x2167AE0", Offset = "0x21666E0", VA = "0x182167AE0")]
		private void _OnSelectBrief(string storySetId)
		{
		}

		// Token: 0x06026554 RID: 157012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026554")]
		[Address(RVA = "0x2168030", Offset = "0x2166C30", VA = "0x182168030")]
		private void _OnSwitchSortMode()
		{
		}

		// Token: 0x06026555 RID: 157013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026555")]
		[Address(RVA = "0x2167EC0", Offset = "0x2166AC0", VA = "0x182167EC0")]
		private void _OnSwitchDisplayFeature(StageMixStoryOverallView.OverallDisplayFeature displayFeature)
		{
		}

		// Token: 0x06026556 RID: 157014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026556")]
		[Address(RVA = "0x2166750", Offset = "0x2165350", VA = "0x182166750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026557 RID: 157015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026557")]
		[Address(RVA = "0x2166E60", Offset = "0x2165A60", VA = "0x182166E60", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06026558 RID: 157016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026558")]
		[Address(RVA = "0x2166F70", Offset = "0x2165B70", VA = "0x182166F70", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06026559 RID: 157017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026559")]
		[Address(RVA = "0x2167010", Offset = "0x2165C10", VA = "0x182167010", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602655A RID: 157018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602655A")]
		[Address(RVA = "0x21668D0", Offset = "0x21654D0", VA = "0x1821668D0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602655B RID: 157019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602655B")]
		[Address(RVA = "0x2167120", Offset = "0x2165D20", VA = "0x182167120", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602655C RID: 157020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602655C")]
		[Address(RVA = "0x21664F0", Offset = "0x21650F0", VA = "0x1821664F0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602655D RID: 157021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602655D")]
		[Address(RVA = "0x2167260", Offset = "0x2165E60", VA = "0x182167260", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602655E RID: 157022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602655E")]
		[Address(RVA = "0x2166630", Offset = "0x2165230", VA = "0x182166630", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602655F RID: 157023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602655F")]
		[Address(RVA = "0x2167420", Offset = "0x2166020", VA = "0x182167420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026560 RID: 157024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026560")]
		[Address(RVA = "0x2167390", Offset = "0x2165F90", VA = "0x182167390")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x06026561 RID: 157025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026561")]
		[Address(RVA = "0x2168170", Offset = "0x2166D70", VA = "0x182168170")]
		private void _TutorialIfNeed()
		{
		}

		// Token: 0x06026562 RID: 157026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026562")]
		[Address(RVA = "0x2168400", Offset = "0x2167000", VA = "0x182168400")]
		private IEnumerator _Tutorial_WaitToTriggerSignal()
		{
			return null;
		}

		// Token: 0x06026563 RID: 157027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026563")]
		[Address(RVA = "0x2168330", Offset = "0x2166F30", VA = "0x182168330")]
		private void _Tutorial_TriggerRetroTutorialIfNeed()
		{
		}

		// Token: 0x06026564 RID: 157028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026564")]
		[Address(RVA = "0x21684B0", Offset = "0x21670B0", VA = "0x1821684B0")]
		public StageMixStoryOverallState()
		{
		}

		// Token: 0x06026565 RID: 157029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026565")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026566 RID: 157030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026566")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06026567 RID: 157031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026567")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06026568 RID: 157032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026568")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06026569 RID: 157033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026569")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04035FDC RID: 221148
		[Token(Token = "0x4035FDC")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x04035FDD RID: 221149
		[Token(Token = "0x4035FDD")]
		[NonSerialized]
		public const int MSG_SELECT_BRIEF = 0;

		// Token: 0x04035FDE RID: 221150
		[Token(Token = "0x4035FDE")]
		[NonSerialized]
		public const int MSG_SWITCH_SORT_MODE = 1;

		// Token: 0x04035FDF RID: 221151
		[Token(Token = "0x4035FDF")]
		[NonSerialized]
		public const int MSG_SWITCH_DISPLAY_FEATURE = 2;

		// Token: 0x04035FE0 RID: 221152
		[Token(Token = "0x4035FE0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageMixStoryOverallView _view;

		// Token: 0x04035FE1 RID: 221153
		[Token(Token = "0x4035FE1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04035FE2 RID: 221154
		[Token(Token = "0x4035FE2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _inAnimation;

		// Token: 0x04035FE3 RID: 221155
		[Token(Token = "0x4035FE3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04035FE4 RID: 221156
		[Token(Token = "0x4035FE4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _tutorialSwitches;

		// Token: 0x04035FE5 RID: 221157
		[Token(Token = "0x4035FE5")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04035FE6 RID: 221158
		[Token(Token = "0x4035FE6")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035FE7 RID: 221159
		[Token(Token = "0x4035FE7")]
		[FieldOffset(Offset = "0xA8")]
		private StageStateBean m_stageStateBean;

		// Token: 0x04035FE8 RID: 221160
		[Token(Token = "0x4035FE8")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_inTween;

		// Token: 0x04035FE9 RID: 221161
		[Token(Token = "0x4035FE9")]
		[FieldOffset(Offset = "0xB8")]
		private MixStoryGroupViewProperty m_mixStoryProperty;

		// Token: 0x04035FEA RID: 221162
		[Token(Token = "0x4035FEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035FEB RID: 221163
		[Token(Token = "0x4035FEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035FEC RID: 221164
		[Token(Token = "0x4035FEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSelectZone;

		// Token: 0x04035FED RID: 221165
		[Token(Token = "0x4035FED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__JumpToZone;

		// Token: 0x04035FEE RID: 221166
		[Token(Token = "0x4035FEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectBrief;

		// Token: 0x04035FEF RID: 221167
		[Token(Token = "0x4035FEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSwitchSortMode;

		// Token: 0x04035FF0 RID: 221168
		[Token(Token = "0x4035FF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSwitchDisplayFeature;

		// Token: 0x04035FF1 RID: 221169
		[Token(Token = "0x4035FF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035FF2 RID: 221170
		[Token(Token = "0x4035FF2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04035FF3 RID: 221171
		[Token(Token = "0x4035FF3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04035FF4 RID: 221172
		[Token(Token = "0x4035FF4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035FF5 RID: 221173
		[Token(Token = "0x4035FF5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04035FF6 RID: 221174
		[Token(Token = "0x4035FF6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04035FF7 RID: 221175
		[Token(Token = "0x4035FF7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04035FF8 RID: 221176
		[Token(Token = "0x4035FF8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04035FF9 RID: 221177
		[Token(Token = "0x4035FF9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04035FFA RID: 221178
		[Token(Token = "0x4035FFA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035FFB RID: 221179
		[Token(Token = "0x4035FFB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04035FFC RID: 221180
		[Token(Token = "0x4035FFC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TutorialIfNeed;

		// Token: 0x04035FFD RID: 221181
		[Token(Token = "0x4035FFD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__Tutorial_WaitToTriggerSignal;

		// Token: 0x04035FFE RID: 221182
		[Token(Token = "0x4035FFE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__Tutorial_TriggerRetroTutorialIfNeed;

		// Token: 0x04035FFF RID: 221183
		[Token(Token = "0x4035FFF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
