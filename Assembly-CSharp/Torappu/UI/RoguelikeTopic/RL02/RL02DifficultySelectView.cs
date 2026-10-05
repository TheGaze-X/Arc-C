using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004602 RID: 17922
	[Token(Token = "0x2004602")]
	public class RL02DifficultySelectView : RoguelikeTopicDifficultySelectBaseView
	{
		// Token: 0x0601B3D0 RID: 111568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D0")]
		[Address(RVA = "0x145EDC0", Offset = "0x145D9C0", VA = "0x18145EDC0", Slot = "11")]
		protected override void OnRefresh(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B3D1 RID: 111569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D1")]
		[Address(RVA = "0x145F7C0", Offset = "0x145E3C0", VA = "0x18145F7C0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D2")]
		[Address(RVA = "0x145F710", Offset = "0x145E310", VA = "0x18145F710")]
		private void _OnPageChangeEnd(int itemIndex)
		{
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D3")]
		[Address(RVA = "0x145F870", Offset = "0x145E470", VA = "0x18145F870")]
		private void _OnScrollingStateChanged(bool isDraging)
		{
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D4")]
		[Address(RVA = "0x145FFF0", Offset = "0x145EBF0", VA = "0x18145FFF0")]
		private void _UpdateSelectDifficulty(int selectIdx)
		{
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D5")]
		[Address(RVA = "0x14603D0", Offset = "0x145EFD0", VA = "0x1814603D0")]
		private void _UpdateWarning(RoguelikeTopicDifficultyWarningType warningType, Color mainColor)
		{
		}

		// Token: 0x0601B3D6 RID: 111574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D6")]
		[Address(RVA = "0x145F080", Offset = "0x145DC80", VA = "0x18145F080", Slot = "10")]
		protected override void SetVisible(bool v, bool immediately)
		{
		}

		// Token: 0x0601B3D7 RID: 111575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D7")]
		[Address(RVA = "0x145F520", Offset = "0x145E120", VA = "0x18145F520")]
		private void _CleanRT()
		{
		}

		// Token: 0x0601B3D8 RID: 111576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D8")]
		[Address(RVA = "0x145EC50", Offset = "0x145D850", VA = "0x18145EC50", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B3D9 RID: 111577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3D9")]
		[Address(RVA = "0x145F3C0", Offset = "0x145DFC0", VA = "0x18145F3C0")]
		private void Update()
		{
		}

		// Token: 0x0601B3DA RID: 111578 RVA: 0x000A4C28 File Offset: 0x000A2E28
		[Token(Token = "0x601B3DA")]
		[Address(RVA = "0x145FD10", Offset = "0x145E910", VA = "0x18145FD10")]
		private int _ResumeCurrentSelected()
		{
			return 0;
		}

		// Token: 0x0601B3DB RID: 111579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3DB")]
		[Address(RVA = "0x145EAC0", Offset = "0x145D6C0", VA = "0x18145EAC0")]
		private void OnDisable()
		{
		}

		// Token: 0x0601B3DC RID: 111580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3DC")]
		[Address(RVA = "0x145E850", Offset = "0x145D450", VA = "0x18145E850")]
		public void EventOnNext()
		{
		}

		// Token: 0x0601B3DD RID: 111581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3DD")]
		[Address(RVA = "0x145E900", Offset = "0x145D500", VA = "0x18145E900")]
		public void EventOnPre()
		{
		}

		// Token: 0x0601B3DE RID: 111582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3DE")]
		[Address(RVA = "0x145E730", Offset = "0x145D330", VA = "0x18145E730")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601B3DF RID: 111583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3DF")]
		[Address(RVA = "0x145E9A0", Offset = "0x145D5A0", VA = "0x18145E9A0")]
		public void EventShowAddDetail()
		{
		}

		// Token: 0x0601B3E0 RID: 111584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E0")]
		[Address(RVA = "0x145F670", Offset = "0x145E270", VA = "0x18145F670")]
		private void _EventOnMoveTo(int index)
		{
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E1")]
		[Address(RVA = "0x145FEC0", Offset = "0x145EAC0", VA = "0x18145FEC0")]
		private void _UpdateBtnState()
		{
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E2")]
		[Address(RVA = "0x145FA80", Offset = "0x145E680", VA = "0x18145FA80")]
		private void _RebuildLockedItems(RoguelikeTopicModeViewModel viewModel, int unlockedCnt)
		{
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E3")]
		[Address(RVA = "0x1460530", Offset = "0x145F130", VA = "0x181460530")]
		public RL02DifficultySelectView()
		{
		}

		// Token: 0x0601B3E4 RID: 111588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E4")]
		[Address(RVA = "0x144A280", Offset = "0x1448E80", VA = "0x18144A280")]
		private void <>xLuaBaseProxy_SetVisible(bool P0, bool P1)
		{
		}

		// Token: 0x0601B3E5 RID: 111589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3E5")]
		[Address(RVA = "0x1414A70", Offset = "0x1413670", VA = "0x181414A70")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04023218 RID: 143896
		[Token(Token = "0x4023218")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x04023219 RID: 143897
		[Token(Token = "0x4023219")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x0402321A RID: 143898
		[Token(Token = "0x402321A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _hardTips;

		// Token: 0x0402321B RID: 143899
		[Token(Token = "0x402321B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _extremeHardTips;

		// Token: 0x0402321C RID: 143900
		[Token(Token = "0x402321C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x0402321D RID: 143901
		[Token(Token = "0x402321D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0402321E RID: 143902
		[Token(Token = "0x402321E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _unlockitemsRoot;

		// Token: 0x0402321F RID: 143903
		[Token(Token = "0x402321F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL02DifficultyItem _itemPrefab;

		// Token: 0x04023220 RID: 143904
		[Token(Token = "0x4023220")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIFadeFloatPanel[] _hideInDraging;

		// Token: 0x04023221 RID: 143905
		[Token(Token = "0x4023221")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("SelectBar")]
		private Text _bpNum;

		// Token: 0x04023222 RID: 143906
		[Token(Token = "0x4023222")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("SelectBar")]
		private Text _bossNum;

		// Token: 0x04023223 RID: 143907
		[Token(Token = "0x4023223")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("SelectBar")]
		private GameObject _addRoot;

		// Token: 0x04023224 RID: 143908
		[Token(Token = "0x4023224")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("SelectBar")]
		private Image _selectBar;

		// Token: 0x04023225 RID: 143909
		[Token(Token = "0x4023225")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("SelectBar")]
		private Image _selectHardBar;

		// Token: 0x04023226 RID: 143910
		[Token(Token = "0x4023226")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _titleImage;

		// Token: 0x04023227 RID: 143911
		[Token(Token = "0x4023227")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Sprite[] _titleSprites;

		// Token: 0x04023228 RID: 143912
		[Token(Token = "0x4023228")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button _nextBtn;

		// Token: 0x04023229 RID: 143913
		[Token(Token = "0x4023229")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button _preBtn;

		// Token: 0x0402322A RID: 143914
		[Token(Token = "0x402322A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RL02DifficultyAdditionalDetailView _addDetailView;

		// Token: 0x0402322B RID: 143915
		[Token(Token = "0x402322B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _dragAnim;

		// Token: 0x0402322C RID: 143916
		[Token(Token = "0x402322C")]
		[FieldOffset(Offset = "0xD8")]
		private RL02DifficultySelectView.PagerAdapter m_pagerAdapter;

		// Token: 0x0402322D RID: 143917
		[Token(Token = "0x402322D")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeTopicModeViewModel m_exploreModel;

		// Token: 0x0402322E RID: 143918
		[Token(Token = "0x402322E")]
		[FieldOffset(Offset = "0xE8")]
		private RL02ModeViewExtModel m_extModel;

		// Token: 0x0402322F RID: 143919
		[Token(Token = "0x402322F")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_draging;

		// Token: 0x04023230 RID: 143920
		[Token(Token = "0x4023230")]
		[FieldOffset(Offset = "0xF4")]
		private int m_currentShowIdx;

		// Token: 0x04023231 RID: 143921
		[Token(Token = "0x4023231")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x04023232 RID: 143922
		[Token(Token = "0x4023232")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x04023233 RID: 143923
		[Token(Token = "0x4023233")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPageChangeEnd;

		// Token: 0x04023234 RID: 143924
		[Token(Token = "0x4023234")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnScrollingStateChanged;

		// Token: 0x04023235 RID: 143925
		[Token(Token = "0x4023235")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateSelectDifficulty;

		// Token: 0x04023236 RID: 143926
		[Token(Token = "0x4023236")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateWarning;

		// Token: 0x04023237 RID: 143927
		[Token(Token = "0x4023237")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04023238 RID: 143928
		[Token(Token = "0x4023238")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CleanRT;

		// Token: 0x04023239 RID: 143929
		[Token(Token = "0x4023239")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402323A RID: 143930
		[Token(Token = "0x402323A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402323B RID: 143931
		[Token(Token = "0x402323B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResumeCurrentSelected;

		// Token: 0x0402323C RID: 143932
		[Token(Token = "0x402323C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402323D RID: 143933
		[Token(Token = "0x402323D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnNext;

		// Token: 0x0402323E RID: 143934
		[Token(Token = "0x402323E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnPre;

		// Token: 0x0402323F RID: 143935
		[Token(Token = "0x402323F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04023240 RID: 143936
		[Token(Token = "0x4023240")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventShowAddDetail;

		// Token: 0x04023241 RID: 143937
		[Token(Token = "0x4023241")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnMoveTo;

		// Token: 0x04023242 RID: 143938
		[Token(Token = "0x4023242")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateBtnState;

		// Token: 0x04023243 RID: 143939
		[Token(Token = "0x4023243")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RebuildLockedItems;

		// Token: 0x04023244 RID: 143940
		[Token(Token = "0x4023244")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004603 RID: 17923
		[Token(Token = "0x2004603")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601B3E6 RID: 111590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B3E6")]
			[Address(RVA = "0x145CD60", Offset = "0x145B960", VA = "0x18145CD60", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601B3E7 RID: 111591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3E7")]
			[Address(RVA = "0x145D4A0", Offset = "0x145C0A0", VA = "0x18145D4A0")]
			public PagerAdapter(RL02DifficultySelectView closure)
			{
			}

			// Token: 0x0601B3E8 RID: 111592 RVA: 0x000A4C40 File Offset: 0x000A2E40
			[Token(Token = "0x601B3E8")]
			[Address(RVA = "0x145CE90", Offset = "0x145BA90", VA = "0x18145CE90")]
			public bool RebuildListIfNeeded(RoguelikeTopicModeViewModel viewModel, out int unlockCnt)
			{
				return default(bool);
			}

			// Token: 0x0601B3E9 RID: 111593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3E9")]
			[Address(RVA = "0x145D2A0", Offset = "0x145BEA0", VA = "0x18145D2A0")]
			public void UpdateState(int selectIdx)
			{
			}

			// Token: 0x04023245 RID: 143941
			[Token(Token = "0x4023245")]
			[FieldOffset(Offset = "0x18")]
			private RL02DifficultySelectView m_closure;

			// Token: 0x04023246 RID: 143942
			[Token(Token = "0x4023246")]
			[FieldOffset(Offset = "0x20")]
			private List<RL02DifficultyItem.VirtualView> m_cells;

			// Token: 0x04023247 RID: 143943
			[Token(Token = "0x4023247")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04023248 RID: 143944
			[Token(Token = "0x4023248")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023249 RID: 143945
			[Token(Token = "0x4023249")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildListIfNeeded;

			// Token: 0x0402324A RID: 143946
			[Token(Token = "0x402324A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}
	}
}
