using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200463A RID: 17978
	[Token(Token = "0x200463A")]
	public class RL01DifficultySelectView : RoguelikeTopicDifficultySelectBaseView
	{
		// Token: 0x0601B4D2 RID: 111826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D2")]
		[Address(RVA = "0x149B330", Offset = "0x1499F30", VA = "0x18149B330", Slot = "11")]
		protected override void OnRefresh(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B4D3 RID: 111827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D3")]
		[Address(RVA = "0x149B610", Offset = "0x149A210", VA = "0x18149B610", Slot = "10")]
		protected override void SetVisible(bool v, bool immediately)
		{
		}

		// Token: 0x0601B4D4 RID: 111828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D4")]
		[Address(RVA = "0x149B1C0", Offset = "0x1499DC0", VA = "0x18149B1C0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B4D5 RID: 111829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D5")]
		[Address(RVA = "0x149BD50", Offset = "0x149A950", VA = "0x18149BD50")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x0601B4D6 RID: 111830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D6")]
		[Address(RVA = "0x149BCA0", Offset = "0x149A8A0", VA = "0x18149BCA0")]
		private void _OnPageChangeEnd(int itemIndex)
		{
		}

		// Token: 0x0601B4D7 RID: 111831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D7")]
		[Address(RVA = "0x149BE00", Offset = "0x149AA00", VA = "0x18149BE00")]
		private void _OnScrollingStateChanged(bool isDraging)
		{
		}

		// Token: 0x0601B4D8 RID: 111832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D8")]
		[Address(RVA = "0x149C580", Offset = "0x149B180", VA = "0x18149C580")]
		private void _UpdateSelectDifficulty(int selectIdx)
		{
		}

		// Token: 0x0601B4D9 RID: 111833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4D9")]
		[Address(RVA = "0x149C8D0", Offset = "0x149B4D0", VA = "0x18149C8D0")]
		private void _UpdateWarning(RoguelikeTopicDifficultyWarningType warningType, Color mainColor)
		{
		}

		// Token: 0x0601B4DA RID: 111834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4DA")]
		[Address(RVA = "0x149C450", Offset = "0x149B050", VA = "0x18149C450")]
		private void _UpdateBtnState()
		{
		}

		// Token: 0x0601B4DB RID: 111835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4DB")]
		[Address(RVA = "0x149C010", Offset = "0x149AC10", VA = "0x18149C010")]
		private void _RebuildLockedItems(RoguelikeTopicModeViewModel viewModel, int unlockedCnt)
		{
		}

		// Token: 0x0601B4DC RID: 111836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4DC")]
		[Address(RVA = "0x149BAB0", Offset = "0x149A6B0", VA = "0x18149BAB0")]
		private void _CleanRT()
		{
		}

		// Token: 0x0601B4DD RID: 111837 RVA: 0x000A4D90 File Offset: 0x000A2F90
		[Token(Token = "0x601B4DD")]
		[Address(RVA = "0x149C2A0", Offset = "0x149AEA0", VA = "0x18149C2A0")]
		private int _ResumeCurrentSelected()
		{
			return 0;
		}

		// Token: 0x0601B4DE RID: 111838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4DE")]
		[Address(RVA = "0x149B950", Offset = "0x149A550", VA = "0x18149B950")]
		private void Update()
		{
		}

		// Token: 0x0601B4DF RID: 111839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4DF")]
		[Address(RVA = "0x149B030", Offset = "0x1499C30", VA = "0x18149B030")]
		private void OnDisable()
		{
		}

		// Token: 0x0601B4E0 RID: 111840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E0")]
		[Address(RVA = "0x149ADC0", Offset = "0x14999C0", VA = "0x18149ADC0")]
		public void EventOnNext()
		{
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E1")]
		[Address(RVA = "0x149AE70", Offset = "0x1499A70", VA = "0x18149AE70")]
		public void EventOnPre()
		{
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E2")]
		[Address(RVA = "0x149ACA0", Offset = "0x14998A0", VA = "0x18149ACA0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E3")]
		[Address(RVA = "0x149AF10", Offset = "0x1499B10", VA = "0x18149AF10")]
		public void EventShowAddDetail()
		{
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E4")]
		[Address(RVA = "0x149BC00", Offset = "0x149A800", VA = "0x18149BC00")]
		private void _EventOnMoveTo(int index)
		{
		}

		// Token: 0x0601B4E5 RID: 111845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E5")]
		[Address(RVA = "0x149CA40", Offset = "0x149B640", VA = "0x18149CA40")]
		public RL01DifficultySelectView()
		{
		}

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E6")]
		[Address(RVA = "0x144A280", Offset = "0x1448E80", VA = "0x18144A280")]
		private void <>xLuaBaseProxy_SetVisible(bool P0, bool P1)
		{
		}

		// Token: 0x0601B4E7 RID: 111847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4E7")]
		[Address(RVA = "0x1414A70", Offset = "0x1413670", VA = "0x181414A70")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04023423 RID: 144419
		[Token(Token = "0x4023423")]
		private const int DEFAULT_SELECT_INDEX = 1;

		// Token: 0x04023424 RID: 144420
		[Token(Token = "0x4023424")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x04023425 RID: 144421
		[Token(Token = "0x4023425")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x04023426 RID: 144422
		[Token(Token = "0x4023426")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _hardTips;

		// Token: 0x04023427 RID: 144423
		[Token(Token = "0x4023427")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x04023428 RID: 144424
		[Token(Token = "0x4023428")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04023429 RID: 144425
		[Token(Token = "0x4023429")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _unlockitemsRoot;

		// Token: 0x0402342A RID: 144426
		[Token(Token = "0x402342A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RL01DifficultyItem _itemPrefab;

		// Token: 0x0402342B RID: 144427
		[Token(Token = "0x402342B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIFadeFloatPanel[] _hideInDraging;

		// Token: 0x0402342C RID: 144428
		[Token(Token = "0x402342C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("SelectBar")]
		private Text _bpNum;

		// Token: 0x0402342D RID: 144429
		[Token(Token = "0x402342D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("SelectBar")]
		private Image _selectBar;

		// Token: 0x0402342E RID: 144430
		[Token(Token = "0x402342E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("SelectBar")]
		private Image _selectBarInGame;

		// Token: 0x0402342F RID: 144431
		[Token(Token = "0x402342F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("SelectBar")]
		private float _inGameAlpha;

		// Token: 0x04023430 RID: 144432
		[Token(Token = "0x4023430")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL01DifficultySelectView.TitleObject[] _titles;

		// Token: 0x04023431 RID: 144433
		[Token(Token = "0x4023431")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _nextBtn;

		// Token: 0x04023432 RID: 144434
		[Token(Token = "0x4023432")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _preBtn;

		// Token: 0x04023433 RID: 144435
		[Token(Token = "0x4023433")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RL01DifficultyAdditionDetailView _addDetailView;

		// Token: 0x04023434 RID: 144436
		[Token(Token = "0x4023434")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _dragAnim;

		// Token: 0x04023435 RID: 144437
		[Token(Token = "0x4023435")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TwoStateToggle _viewMode;

		// Token: 0x04023436 RID: 144438
		[Token(Token = "0x4023436")]
		[FieldOffset(Offset = "0xC8")]
		private RL01DifficultySelectView.PagerAdapter m_pagerAdapter;

		// Token: 0x04023437 RID: 144439
		[Token(Token = "0x4023437")]
		[FieldOffset(Offset = "0xD0")]
		private RoguelikeTopicModeViewModel m_exploreModel;

		// Token: 0x04023438 RID: 144440
		[Token(Token = "0x4023438")]
		[FieldOffset(Offset = "0xD8")]
		private RL01ModeViewExtModel m_extModel;

		// Token: 0x04023439 RID: 144441
		[Token(Token = "0x4023439")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_draging;

		// Token: 0x0402343A RID: 144442
		[Token(Token = "0x402343A")]
		[FieldOffset(Offset = "0xE4")]
		private int m_currentShowIdx;

		// Token: 0x0402343B RID: 144443
		[Token(Token = "0x402343B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x0402343C RID: 144444
		[Token(Token = "0x402343C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0402343D RID: 144445
		[Token(Token = "0x402343D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402343E RID: 144446
		[Token(Token = "0x402343E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x0402343F RID: 144447
		[Token(Token = "0x402343F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPageChangeEnd;

		// Token: 0x04023440 RID: 144448
		[Token(Token = "0x4023440")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnScrollingStateChanged;

		// Token: 0x04023441 RID: 144449
		[Token(Token = "0x4023441")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSelectDifficulty;

		// Token: 0x04023442 RID: 144450
		[Token(Token = "0x4023442")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateWarning;

		// Token: 0x04023443 RID: 144451
		[Token(Token = "0x4023443")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateBtnState;

		// Token: 0x04023444 RID: 144452
		[Token(Token = "0x4023444")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RebuildLockedItems;

		// Token: 0x04023445 RID: 144453
		[Token(Token = "0x4023445")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CleanRT;

		// Token: 0x04023446 RID: 144454
		[Token(Token = "0x4023446")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResumeCurrentSelected;

		// Token: 0x04023447 RID: 144455
		[Token(Token = "0x4023447")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04023448 RID: 144456
		[Token(Token = "0x4023448")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04023449 RID: 144457
		[Token(Token = "0x4023449")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnNext;

		// Token: 0x0402344A RID: 144458
		[Token(Token = "0x402344A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnPre;

		// Token: 0x0402344B RID: 144459
		[Token(Token = "0x402344B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0402344C RID: 144460
		[Token(Token = "0x402344C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventShowAddDetail;

		// Token: 0x0402344D RID: 144461
		[Token(Token = "0x402344D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnMoveTo;

		// Token: 0x0402344E RID: 144462
		[Token(Token = "0x402344E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200463B RID: 17979
		[Token(Token = "0x200463B")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601B4E8 RID: 111848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B4E8")]
			[Address(RVA = "0x1498940", Offset = "0x1497540", VA = "0x181498940", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601B4E9 RID: 111849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4E9")]
			[Address(RVA = "0x1499080", Offset = "0x1497C80", VA = "0x181499080")]
			public PagerAdapter(RL01DifficultySelectView closure)
			{
			}

			// Token: 0x0601B4EA RID: 111850 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
			[Token(Token = "0x601B4EA")]
			[Address(RVA = "0x1498A70", Offset = "0x1497670", VA = "0x181498A70")]
			public bool RebuildListIfNeeded(RoguelikeTopicModeViewModel viewModel, out int unlockCnt)
			{
				return default(bool);
			}

			// Token: 0x0601B4EB RID: 111851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4EB")]
			[Address(RVA = "0x1498E80", Offset = "0x1497A80", VA = "0x181498E80")]
			public void UpdateState(int selectIdx)
			{
			}

			// Token: 0x0402344F RID: 144463
			[Token(Token = "0x402344F")]
			[FieldOffset(Offset = "0x18")]
			private RL01DifficultySelectView m_closure;

			// Token: 0x04023450 RID: 144464
			[Token(Token = "0x4023450")]
			[FieldOffset(Offset = "0x20")]
			private List<RL01DifficultyItem.VirtualView> m_cells;

			// Token: 0x04023451 RID: 144465
			[Token(Token = "0x4023451")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04023452 RID: 144466
			[Token(Token = "0x4023452")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023453 RID: 144467
			[Token(Token = "0x4023453")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildListIfNeeded;

			// Token: 0x04023454 RID: 144468
			[Token(Token = "0x4023454")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x0200463C RID: 17980
		[Token(Token = "0x200463C")]
		[Serializable]
		private class TitleObject
		{
			// Token: 0x0601B4EC RID: 111852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TitleObject()
			{
			}

			// Token: 0x04023455 RID: 144469
			[Token(Token = "0x4023455")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicMode diffMode;

			// Token: 0x04023456 RID: 144470
			[Token(Token = "0x4023456")]
			[FieldOffset(Offset = "0x18")]
			public GameObject obj;
		}
	}
}
