using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045EB RID: 17899
	[Token(Token = "0x20045EB")]
	public class Rl03OuterBuffView : DataBinder<Rl03OuterBuffProperty>
	{
		// Token: 0x0601B352 RID: 111442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B352")]
		[Address(RVA = "0x146E960", Offset = "0x146D560", VA = "0x18146E960")]
		private void Update()
		{
		}

		// Token: 0x0601B353 RID: 111443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B353")]
		[Address(RVA = "0x146DAF0", Offset = "0x146C6F0", VA = "0x18146DAF0")]
		public void Init(Rl03OuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601B354 RID: 111444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B354")]
		[Address(RVA = "0x146E1A0", Offset = "0x146CDA0", VA = "0x18146E1A0", Slot = "7")]
		public override void OnValueChanged(Rl03OuterBuffProperty property)
		{
		}

		// Token: 0x0601B355 RID: 111445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B355")]
		[Address(RVA = "0x146EAC0", Offset = "0x146D6C0", VA = "0x18146EAC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B356 RID: 111446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B356")]
		[Address(RVA = "0x146F070", Offset = "0x146DC70", VA = "0x18146F070")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601B357 RID: 111447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B357")]
		[Address(RVA = "0x146F1C0", Offset = "0x146DDC0", VA = "0x18146F1C0")]
		private void _PlayTotemAnim()
		{
		}

		// Token: 0x0601B358 RID: 111448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B358")]
		[Address(RVA = "0x146F350", Offset = "0x146DF50", VA = "0x18146F350")]
		private void _PlayUpgradeAnim(int activeDiffCount)
		{
		}

		// Token: 0x0601B359 RID: 111449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B359")]
		[Address(RVA = "0x146ED60", Offset = "0x146D960", VA = "0x18146ED60")]
		private void _InitLocationGroup(Rl03OuterBuffViewModel viewModel)
		{
		}

		// Token: 0x0601B35A RID: 111450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B35A")]
		[Address(RVA = "0x146DFD0", Offset = "0x146CBD0", VA = "0x18146DFD0")]
		public void OnLeftFocus()
		{
		}

		// Token: 0x0601B35B RID: 111451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B35B")]
		[Address(RVA = "0x146E080", Offset = "0x146CC80", VA = "0x18146E080")]
		public void OnRightFocus()
		{
		}

		// Token: 0x0601B35C RID: 111452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B35C")]
		[Address(RVA = "0x146DF50", Offset = "0x146CB50", VA = "0x18146DF50")]
		public void OnBackgroudPress()
		{
		}

		// Token: 0x0601B35D RID: 111453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B35D")]
		[Address(RVA = "0x146E130", Offset = "0x146CD30", VA = "0x18146E130")]
		public void OnSummaryClick()
		{
		}

		// Token: 0x0601B35E RID: 111454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B35E")]
		[Address(RVA = "0x146F510", Offset = "0x146E110", VA = "0x18146F510")]
		public Rl03OuterBuffView()
		{
		}

		// Token: 0x0402312D RID: 143661
		[Token(Token = "0x402312D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rl03OuterBuffContentView _contentView;

		// Token: 0x0402312E RID: 143662
		[Token(Token = "0x402312E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rl03OuterBuffBottomView _bottomView;

		// Token: 0x0402312F RID: 143663
		[Token(Token = "0x402312F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04023130 RID: 143664
		[Token(Token = "0x4023130")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UIAnimationLocation> _enterAnims;

		// Token: 0x04023131 RID: 143665
		[Token(Token = "0x4023131")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _upgradeAnimDelay;

		// Token: 0x04023132 RID: 143666
		[Token(Token = "0x4023132")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<UIAnimationLocation> _upgradeAnims;

		// Token: 0x04023133 RID: 143667
		[Token(Token = "0x4023133")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04023134 RID: 143668
		[Token(Token = "0x4023134")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRect _scroll;

		// Token: 0x04023135 RID: 143669
		[Token(Token = "0x4023135")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _contentRect;

		// Token: 0x04023136 RID: 143670
		[Token(Token = "0x4023136")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _locationRect;

		// Token: 0x04023137 RID: 143671
		[Token(Token = "0x4023137")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<Rl03OuterBuffView.LocationGroup> _locationGroups;

		// Token: 0x04023138 RID: 143672
		[Token(Token = "0x4023138")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _btnLeft;

		// Token: 0x04023139 RID: 143673
		[Token(Token = "0x4023139")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _btnRight;

		// Token: 0x0402313A RID: 143674
		[Token(Token = "0x402313A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _focusLocation;

		// Token: 0x0402313B RID: 143675
		[Token(Token = "0x402313B")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x0402313C RID: 143676
		[Token(Token = "0x402313C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _tokenName;

		// Token: 0x0402313D RID: 143677
		[Token(Token = "0x402313D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _tokenCount;

		// Token: 0x0402313E RID: 143678
		[Token(Token = "0x402313E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _activeCount;

		// Token: 0x0402313F RID: 143679
		[Token(Token = "0x402313F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _totalCount;

		// Token: 0x04023140 RID: 143680
		[Token(Token = "0x4023140")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelTokenAll;

		// Token: 0x04023141 RID: 143681
		[Token(Token = "0x4023141")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelToken;

		// Token: 0x04023142 RID: 143682
		[Token(Token = "0x4023142")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup _leftCanvasGroup;

		// Token: 0x04023143 RID: 143683
		[Token(Token = "0x4023143")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup _rightCanvasGroup;

		// Token: 0x04023144 RID: 143684
		[Token(Token = "0x4023144")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public Action<string> onNodeClick;

		// Token: 0x04023145 RID: 143685
		[Token(Token = "0x4023145")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Action<string> onUpgradeClick;

		// Token: 0x04023146 RID: 143686
		[Token(Token = "0x4023146")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public Action onSummaryClick;

		// Token: 0x04023147 RID: 143687
		[Token(Token = "0x4023147")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isInited;

		// Token: 0x04023148 RID: 143688
		[Token(Token = "0x4023148")]
		[FieldOffset(Offset = "0x100")]
		private UIPage m_page;

		// Token: 0x04023149 RID: 143689
		[Token(Token = "0x4023149")]
		[FieldOffset(Offset = "0x108")]
		private int m_cachedDiffCount;

		// Token: 0x0402314A RID: 143690
		[Token(Token = "0x402314A")]
		[FieldOffset(Offset = "0x110")]
		private Rl03OuterBuffViewModel m_cachedViewModel;

		// Token: 0x0402314B RID: 143691
		[Token(Token = "0x402314B")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x0402314C RID: 143692
		[Token(Token = "0x402314C")]
		[FieldOffset(Offset = "0x120")]
		private List<Rl03OuterBuffView.LocationData> m_locationDatas;

		// Token: 0x0402314D RID: 143693
		[Token(Token = "0x402314D")]
		[FieldOffset(Offset = "0x128")]
		private Rl03OuterBuffView.LocationHandler m_locationHandler;

		// Token: 0x0402314E RID: 143694
		[Token(Token = "0x402314E")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_totemTween;

		// Token: 0x0402314F RID: 143695
		[Token(Token = "0x402314F")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_enterTween;

		// Token: 0x04023150 RID: 143696
		[Token(Token = "0x4023150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04023151 RID: 143697
		[Token(Token = "0x4023151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023152 RID: 143698
		[Token(Token = "0x4023152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023153 RID: 143699
		[Token(Token = "0x4023153")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023154 RID: 143700
		[Token(Token = "0x4023154")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04023155 RID: 143701
		[Token(Token = "0x4023155")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayTotemAnim;

		// Token: 0x04023156 RID: 143702
		[Token(Token = "0x4023156")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayUpgradeAnim;

		// Token: 0x04023157 RID: 143703
		[Token(Token = "0x4023157")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitLocationGroup;

		// Token: 0x04023158 RID: 143704
		[Token(Token = "0x4023158")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnLeftFocus;

		// Token: 0x04023159 RID: 143705
		[Token(Token = "0x4023159")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRightFocus;

		// Token: 0x0402315A RID: 143706
		[Token(Token = "0x402315A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBackgroudPress;

		// Token: 0x0402315B RID: 143707
		[Token(Token = "0x402315B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnSummaryClick;

		// Token: 0x0402315C RID: 143708
		[Token(Token = "0x402315C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045EC RID: 17900
		[Token(Token = "0x20045EC")]
		[Serializable]
		public struct LocationGroup
		{
			// Token: 0x0402315D RID: 143709
			[Token(Token = "0x402315D")]
			[FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x0402315E RID: 143710
			[Token(Token = "0x402315E")]
			[FieldOffset(Offset = "0x8")]
			public float groupLocation;
		}

		// Token: 0x020045ED RID: 17901
		[Token(Token = "0x20045ED")]
		private class LocationData : IHotfixable, IComparable<Rl03OuterBuffView.LocationData>
		{
			// Token: 0x0601B35F RID: 111455 RVA: 0x000A4A30 File Offset: 0x000A2C30
			[Token(Token = "0x601B35F")]
			[Address(RVA = "0x145B520", Offset = "0x145A120", VA = "0x18145B520", Slot = "4")]
			public int CompareTo(Rl03OuterBuffView.LocationData other)
			{
				return 0;
			}

			// Token: 0x0601B360 RID: 111456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B360")]
			[Address(RVA = "0x145B5A0", Offset = "0x145A1A0", VA = "0x18145B5A0")]
			public LocationData()
			{
			}

			// Token: 0x0402315F RID: 143711
			[Token(Token = "0x402315F")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04023160 RID: 143712
			[Token(Token = "0x4023160")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04023161 RID: 143713
			[Token(Token = "0x4023161")]
			[FieldOffset(Offset = "0x1C")]
			public bool isComplete;

			// Token: 0x04023162 RID: 143714
			[Token(Token = "0x4023162")]
			[FieldOffset(Offset = "0x20")]
			public float location;

			// Token: 0x04023163 RID: 143715
			[Token(Token = "0x4023163")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04023164 RID: 143716
			[Token(Token = "0x4023164")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020045EE RID: 17902
		[Token(Token = "0x20045EE")]
		private class LocationHandler : IHotfixable
		{
			// Token: 0x0601B361 RID: 111457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B361")]
			[Address(RVA = "0x145BFE0", Offset = "0x145ABE0", VA = "0x18145BFE0")]
			public LocationHandler(Rl03OuterBuffView closure)
			{
			}

			// Token: 0x0601B362 RID: 111458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B362")]
			[Address(RVA = "0x145B8F0", Offset = "0x145A4F0", VA = "0x18145B8F0")]
			public void UpdateLocation()
			{
			}

			// Token: 0x0601B363 RID: 111459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B363")]
			[Address(RVA = "0x145B810", Offset = "0x145A410", VA = "0x18145B810")]
			public void FocusLeft()
			{
			}

			// Token: 0x0601B364 RID: 111460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B364")]
			[Address(RVA = "0x145B880", Offset = "0x145A480", VA = "0x18145B880")]
			public void FocusRight()
			{
			}

			// Token: 0x0601B365 RID: 111461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B365")]
			[Address(RVA = "0x145B600", Offset = "0x145A200", VA = "0x18145B600")]
			public void FocusIndex(int index, bool fastMode = false)
			{
			}

			// Token: 0x0601B366 RID: 111462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B366")]
			[Address(RVA = "0x145BC80", Offset = "0x145A880", VA = "0x18145BC80")]
			private void _UpdateLocationButtonsStatus()
			{
			}

			// Token: 0x0601B367 RID: 111463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B367")]
			[Address(RVA = "0x145BD50", Offset = "0x145A950", VA = "0x18145BD50")]
			private void _UpdateLocation()
			{
			}

			// Token: 0x0601B368 RID: 111464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B368")]
			[Address(RVA = "0x145BA00", Offset = "0x145A600", VA = "0x18145BA00")]
			private void _FocusLocationImmediately(int index)
			{
			}

			// Token: 0x0601B369 RID: 111465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B369")]
			[Address(RVA = "0x145BB30", Offset = "0x145A730", VA = "0x18145BB30")]
			private void _FocusLocation(int index)
			{
			}

			// Token: 0x04023165 RID: 143717
			[Token(Token = "0x4023165")]
			[FieldOffset(Offset = "0x10")]
			private Rl03OuterBuffView m_closure;

			// Token: 0x04023166 RID: 143718
			[Token(Token = "0x4023166")]
			[FieldOffset(Offset = "0x18")]
			private int m_leftIndex;

			// Token: 0x04023167 RID: 143719
			[Token(Token = "0x4023167")]
			[FieldOffset(Offset = "0x1C")]
			private int m_rightIndex;

			// Token: 0x04023168 RID: 143720
			[Token(Token = "0x4023168")]
			[FieldOffset(Offset = "0x20")]
			private Tween m_focusTween;

			// Token: 0x04023169 RID: 143721
			[Token(Token = "0x4023169")]
			[FieldOffset(Offset = "0x28")]
			private FadeSwitchTween m_leftSwitchTween;

			// Token: 0x0402316A RID: 143722
			[Token(Token = "0x402316A")]
			[FieldOffset(Offset = "0x30")]
			private FadeSwitchTween m_rightSwitchTween;

			// Token: 0x0402316B RID: 143723
			[Token(Token = "0x402316B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402316C RID: 143724
			[Token(Token = "0x402316C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateLocation;

			// Token: 0x0402316D RID: 143725
			[Token(Token = "0x402316D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FocusLeft;

			// Token: 0x0402316E RID: 143726
			[Token(Token = "0x402316E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FocusRight;

			// Token: 0x0402316F RID: 143727
			[Token(Token = "0x402316F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FocusIndex;

			// Token: 0x04023170 RID: 143728
			[Token(Token = "0x4023170")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__UpdateLocationButtonsStatus;

			// Token: 0x04023171 RID: 143729
			[Token(Token = "0x4023171")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__UpdateLocation;

			// Token: 0x04023172 RID: 143730
			[Token(Token = "0x4023172")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__FocusLocationImmediately;

			// Token: 0x04023173 RID: 143731
			[Token(Token = "0x4023173")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__FocusLocation;
		}
	}
}
