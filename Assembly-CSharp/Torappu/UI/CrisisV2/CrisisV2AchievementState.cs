using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200593F RID: 22847
	[Token(Token = "0x200593F")]
	public class CrisisV2AchievementState : State, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x06021480 RID: 136320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021480")]
		[Address(RVA = "0x1B8AA40", Offset = "0x1B89640", VA = "0x181B8AA40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021481 RID: 136321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021481")]
		[Address(RVA = "0x1B8AFF0", Offset = "0x1B89BF0", VA = "0x181B8AFF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06021482 RID: 136322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021482")]
		[Address(RVA = "0x1B8A9E0", Offset = "0x1B895E0", VA = "0x181B8A9E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021483 RID: 136323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021483")]
		[Address(RVA = "0x1B8B0E0", Offset = "0x1B89CE0", VA = "0x181B8B0E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021484 RID: 136324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021484")]
		[Address(RVA = "0x1B8BB80", Offset = "0x1B8A780", VA = "0x181B8BB80")]
		private void _OnJumpToMedalDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x06021485 RID: 136325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021485")]
		[Address(RVA = "0x1B8BA40", Offset = "0x1B8A640", VA = "0x181B8BA40")]
		private void _OnJumpToHistoryState(IStateBean obj)
		{
		}

		// Token: 0x06021486 RID: 136326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021486")]
		[Address(RVA = "0x1B8B2B0", Offset = "0x1B89EB0", VA = "0x181B8B2B0")]
		private void Update()
		{
		}

		// Token: 0x06021487 RID: 136327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021487")]
		[Address(RVA = "0x1B8AC80", Offset = "0x1B89880", VA = "0x181B8AC80", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06021488 RID: 136328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021488")]
		[Address(RVA = "0x1B8BDA0", Offset = "0x1B8A9A0", VA = "0x181B8BDA0")]
		private void _OnNextBtnClicked()
		{
		}

		// Token: 0x06021489 RID: 136329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021489")]
		[Address(RVA = "0x1B8BE00", Offset = "0x1B8AA00", VA = "0x181B8BE00")]
		private void _OnPrevBtnClicked()
		{
		}

		// Token: 0x0602148A RID: 136330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148A")]
		[Address(RVA = "0x1B8BCB0", Offset = "0x1B8A8B0", VA = "0x181B8BCB0")]
		private void _OnMedalGroupClicked()
		{
		}

		// Token: 0x0602148B RID: 136331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148B")]
		[Address(RVA = "0x1B8B930", Offset = "0x1B8A530", VA = "0x181B8B930")]
		private void _OnHistoryClicked()
		{
		}

		// Token: 0x0602148C RID: 136332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148C")]
		[Address(RVA = "0x1B8B380", Offset = "0x1B89F80", VA = "0x181B8B380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602148D RID: 136333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148D")]
		[Address(RVA = "0x1B8B5E0", Offset = "0x1B8A1E0", VA = "0x181B8B5E0")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0602148E RID: 136334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148E")]
		[Address(RVA = "0x1B8BE60", Offset = "0x1B8AA60", VA = "0x181B8BE60")]
		private void _SwitchToSeason(int indexDelta)
		{
		}

		// Token: 0x0602148F RID: 136335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602148F")]
		[Address(RVA = "0x1B8B790", Offset = "0x1B8A390", VA = "0x181B8B790")]
		private void _OnCrisisDataFetched()
		{
		}

		// Token: 0x06021490 RID: 136336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021490")]
		[Address(RVA = "0x1B8C150", Offset = "0x1B8AD50", VA = "0x181B8C150")]
		public CrisisV2AchievementState()
		{
		}

		// Token: 0x06021491 RID: 136337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021491")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06021492 RID: 136338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021492")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06021493 RID: 136339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021493")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402D5FD RID: 185853
		[Token(Token = "0x402D5FD")]
		private const string ENTER_ANIM_NAME = "crisis_v2_achievement_entry";

		// Token: 0x0402D5FE RID: 185854
		[Token(Token = "0x402D5FE")]
		private const string FADE_OUT_ANIM_NAME = "crisis_v2_achievement_fade_out";

		// Token: 0x0402D5FF RID: 185855
		[Token(Token = "0x402D5FF")]
		private const string FADE_IN_ANIM_NAME = "crisis_v2_achievement_fade_in";

		// Token: 0x0402D600 RID: 185856
		[Token(Token = "0x402D600")]
		[NonSerialized]
		public const int ON_NEXT_BUTTON_CLICKED = 0;

		// Token: 0x0402D601 RID: 185857
		[Token(Token = "0x402D601")]
		[NonSerialized]
		public const int ON_PREV_BUTTON_CLICKED = 1;

		// Token: 0x0402D602 RID: 185858
		[Token(Token = "0x402D602")]
		[NonSerialized]
		public const int ON_MEDAL_GROUP_CLICKED = 2;

		// Token: 0x0402D603 RID: 185859
		[Token(Token = "0x402D603")]
		[NonSerialized]
		public const int ON_HISTORY_CLICKED = 3;

		// Token: 0x0402D604 RID: 185860
		[Token(Token = "0x402D604")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CrisisV2AchievementView _achievementView;

		// Token: 0x0402D605 RID: 185861
		[Token(Token = "0x402D605")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrisisV2AchievementPageGroupView _pageView;

		// Token: 0x0402D606 RID: 185862
		[Token(Token = "0x402D606")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402D607 RID: 185863
		[Token(Token = "0x402D607")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402D608 RID: 185864
		[Token(Token = "0x402D608")]
		[FieldOffset(Offset = "0x70")]
		private CrisisV2AchievementStateBean m_stateBean;

		// Token: 0x0402D609 RID: 185865
		[Token(Token = "0x402D609")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_enterTween;

		// Token: 0x0402D60A RID: 185866
		[Token(Token = "0x402D60A")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_switchTween;

		// Token: 0x0402D60B RID: 185867
		[Token(Token = "0x402D60B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402D60C RID: 185868
		[Token(Token = "0x402D60C")]
		[FieldOffset(Offset = "0x89")]
		private bool m_requestingCrisisData;

		// Token: 0x0402D60D RID: 185869
		[Token(Token = "0x402D60D")]
		[FieldOffset(Offset = "0x8A")]
		private bool m_requestingSnapshotData;

		// Token: 0x0402D60E RID: 185870
		[Token(Token = "0x402D60E")]
		[FieldOffset(Offset = "0x90")]
		private CrisisV2DataFromServer m_crisisData;

		// Token: 0x0402D60F RID: 185871
		[Token(Token = "0x402D60F")]
		[FieldOffset(Offset = "0x98")]
		private CrisisV2SnapshotDataFromServer m_snapshotData;

		// Token: 0x0402D610 RID: 185872
		[Token(Token = "0x402D610")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D611 RID: 185873
		[Token(Token = "0x402D611")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402D612 RID: 185874
		[Token(Token = "0x402D612")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D613 RID: 185875
		[Token(Token = "0x402D613")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402D614 RID: 185876
		[Token(Token = "0x402D614")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToMedalDisplayState;

		// Token: 0x0402D615 RID: 185877
		[Token(Token = "0x402D615")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToHistoryState;

		// Token: 0x0402D616 RID: 185878
		[Token(Token = "0x402D616")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402D617 RID: 185879
		[Token(Token = "0x402D617")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402D618 RID: 185880
		[Token(Token = "0x402D618")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnNextBtnClicked;

		// Token: 0x0402D619 RID: 185881
		[Token(Token = "0x402D619")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnPrevBtnClicked;

		// Token: 0x0402D61A RID: 185882
		[Token(Token = "0x402D61A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMedalGroupClicked;

		// Token: 0x0402D61B RID: 185883
		[Token(Token = "0x402D61B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnHistoryClicked;

		// Token: 0x0402D61C RID: 185884
		[Token(Token = "0x402D61C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D61D RID: 185885
		[Token(Token = "0x402D61D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x0402D61E RID: 185886
		[Token(Token = "0x402D61E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SwitchToSeason;

		// Token: 0x0402D61F RID: 185887
		[Token(Token = "0x402D61F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCrisisDataFetched;

		// Token: 0x0402D620 RID: 185888
		[Token(Token = "0x402D620")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
