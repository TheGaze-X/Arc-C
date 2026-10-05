using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007924 RID: 31012
	[Token(Token = "0x2007924")]
	public class Act1ArcadeBadgeBookDetailView : DataBinder<Act1ArcadeBadgeBookDetailProperty>
	{
		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x0602B81C RID: 178204 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B81D RID: 178205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065E8")]
		public Action closeEvent
		{
			[Token(Token = "0x602B81C")]
			[Address(RVA = "0x27689C0", Offset = "0x27675C0", VA = "0x1827689C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B81D")]
			[Address(RVA = "0x2768AE0", Offset = "0x27676E0", VA = "0x182768AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x0602B81E RID: 178206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B81F RID: 178207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065E9")]
		public Action switchForwardEvent
		{
			[Token(Token = "0x602B81E")]
			[Address(RVA = "0x2768A80", Offset = "0x2767680", VA = "0x182768A80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B81F")]
			[Address(RVA = "0x2768BE0", Offset = "0x27677E0", VA = "0x182768BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x0602B820 RID: 178208 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B821 RID: 178209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065EA")]
		public Action switchBackwardEvent
		{
			[Token(Token = "0x602B820")]
			[Address(RVA = "0x2768A20", Offset = "0x2767620", VA = "0x182768A20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B821")]
			[Address(RVA = "0x2768B60", Offset = "0x2767760", VA = "0x182768B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B822 RID: 178210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B822")]
		[Address(RVA = "0x2767E90", Offset = "0x2766A90", VA = "0x182767E90")]
		public void OnCloseEvent()
		{
		}

		// Token: 0x0602B823 RID: 178211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B823")]
		[Address(RVA = "0x27680B0", Offset = "0x2766CB0", VA = "0x1827680B0")]
		public void OnSwitchForwardEvent()
		{
		}

		// Token: 0x0602B824 RID: 178212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B824")]
		[Address(RVA = "0x2767FA0", Offset = "0x2766BA0", VA = "0x182767FA0")]
		public void OnSwitchBackwardEvent()
		{
		}

		// Token: 0x0602B825 RID: 178213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B825")]
		[Address(RVA = "0x27681C0", Offset = "0x2766DC0", VA = "0x1827681C0", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeBadgeBookDetailProperty property)
		{
		}

		// Token: 0x0602B826 RID: 178214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B826")]
		[Address(RVA = "0x2768550", Offset = "0x2767150", VA = "0x182768550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B827 RID: 178215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B827")]
		[Address(RVA = "0x27687B0", Offset = "0x27673B0", VA = "0x1827687B0")]
		private void _RenderItem()
		{
		}

		// Token: 0x0602B828 RID: 178216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B828")]
		[Address(RVA = "0x2768950", Offset = "0x2767550", VA = "0x182768950")]
		public Act1ArcadeBadgeBookDetailView()
		{
		}

		// Token: 0x0403EE7D RID: 257661
		[Token(Token = "0x403EE7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act1ArcadeBadgeBookDetailView.BadgeTypePanel> _badgeTypePanels;

		// Token: 0x0403EE7E RID: 257662
		[Token(Token = "0x403EE7E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _switchAnimation;

		// Token: 0x0403EE7F RID: 257663
		[Token(Token = "0x403EE7F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x0403EE80 RID: 257664
		[Token(Token = "0x403EE80")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_finder;

		// Token: 0x0403EE81 RID: 257665
		[Token(Token = "0x403EE81")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0403EE82 RID: 257666
		[Token(Token = "0x403EE82")]
		[FieldOffset(Offset = "0x58")]
		private Act1ArcadeBadgeBookDetailContentAnimator m_animator;

		// Token: 0x0403EE83 RID: 257667
		[Token(Token = "0x403EE83")]
		[FieldOffset(Offset = "0x60")]
		private Act1ArcadeBadgeBookDetailView.Adapter m_adapter;

		// Token: 0x0403EE84 RID: 257668
		[Token(Token = "0x403EE84")]
		[FieldOffset(Offset = "0x68")]
		private string m_actId;

		// Token: 0x0403EE85 RID: 257669
		[Token(Token = "0x403EE85")]
		[FieldOffset(Offset = "0x70")]
		private Act1ArcadeBadgeBookItemViewModel m_cachedPresentingItem;

		// Token: 0x0403EE86 RID: 257670
		[Token(Token = "0x403EE86")]
		[FieldOffset(Offset = "0x78")]
		private Act1ArcadeBadgeBookDetailContentAnimator.Direction m_direction;

		// Token: 0x0403EE8A RID: 257674
		[Token(Token = "0x403EE8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closeEvent;

		// Token: 0x0403EE8B RID: 257675
		[Token(Token = "0x403EE8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closeEvent;

		// Token: 0x0403EE8C RID: 257676
		[Token(Token = "0x403EE8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_switchForwardEvent;

		// Token: 0x0403EE8D RID: 257677
		[Token(Token = "0x403EE8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_switchForwardEvent;

		// Token: 0x0403EE8E RID: 257678
		[Token(Token = "0x403EE8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_switchBackwardEvent;

		// Token: 0x0403EE8F RID: 257679
		[Token(Token = "0x403EE8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_switchBackwardEvent;

		// Token: 0x0403EE90 RID: 257680
		[Token(Token = "0x403EE90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCloseEvent;

		// Token: 0x0403EE91 RID: 257681
		[Token(Token = "0x403EE91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSwitchForwardEvent;

		// Token: 0x0403EE92 RID: 257682
		[Token(Token = "0x403EE92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSwitchBackwardEvent;

		// Token: 0x0403EE93 RID: 257683
		[Token(Token = "0x403EE93")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403EE94 RID: 257684
		[Token(Token = "0x403EE94")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EE95 RID: 257685
		[Token(Token = "0x403EE95")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x0403EE96 RID: 257686
		[Token(Token = "0x403EE96")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007925 RID: 31013
		[Token(Token = "0x2007925")]
		[Serializable]
		public struct BadgeTypePanel
		{
			// Token: 0x0403EE97 RID: 257687
			[Token(Token = "0x403EE97")]
			[FieldOffset(Offset = "0x0")]
			public ActArcadeData.BadgeType type;

			// Token: 0x0403EE98 RID: 257688
			[Token(Token = "0x403EE98")]
			[FieldOffset(Offset = "0x8")]
			public Act1ArcadeBadgeBookItemHeadView headView;

			// Token: 0x0403EE99 RID: 257689
			[Token(Token = "0x403EE99")]
			[FieldOffset(Offset = "0x10")]
			public Act1ArcadeBadgeBookItemTailView tailView;
		}

		// Token: 0x02007926 RID: 31014
		[Token(Token = "0x2007926")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170065EB RID: 26091
			// (get) Token: 0x0602B829 RID: 178217 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B82A RID: 178218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065EB")]
			public List<Act1ArcadeBadgeBookItemViewModel> mappedItems
			{
				[Token(Token = "0x602B829")]
				[Address(RVA = "0x277A500", Offset = "0x2779100", VA = "0x18277A500")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B82A")]
				[Address(RVA = "0x277A8C0", Offset = "0x27794C0", VA = "0x18277A8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065EC RID: 26092
			// (get) Token: 0x0602B82B RID: 178219 RVA: 0x000DC4D0 File Offset: 0x000DA6D0
			// (set) Token: 0x0602B82C RID: 178220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065EC")]
			public int presentingIndex
			{
				[Token(Token = "0x602B82B")]
				[Address(RVA = "0x277A5C0", Offset = "0x27791C0", VA = "0x18277A5C0")]
				[CompilerGenerated]
				private get
				{
					return 0;
				}
				[Token(Token = "0x602B82C")]
				[Address(RVA = "0x277A9C0", Offset = "0x27795C0", VA = "0x18277A9C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065ED RID: 26093
			// (get) Token: 0x0602B82D RID: 178221 RVA: 0x000DC4E8 File Offset: 0x000DA6E8
			// (set) Token: 0x0602B82E RID: 178222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065ED")]
			public bool initShow
			{
				[Token(Token = "0x602B82D")]
				[Address(RVA = "0x277A440", Offset = "0x2779040", VA = "0x18277A440")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x602B82E")]
				[Address(RVA = "0x277A7E0", Offset = "0x27793E0", VA = "0x18277A7E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065EE RID: 26094
			// (get) Token: 0x0602B82F RID: 178223 RVA: 0x000DC500 File Offset: 0x000DA700
			[Token(Token = "0x170065EE")]
			public override int count
			{
				[Token(Token = "0x602B82F")]
				[Address(RVA = "0x277A2B0", Offset = "0x2778EB0", VA = "0x18277A2B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B830 RID: 178224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B830")]
			[Address(RVA = "0x2779650", Offset = "0x2778250", VA = "0x182779650", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B831 RID: 178225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B831")]
			[Address(RVA = "0x277A000", Offset = "0x2778C00", VA = "0x18277A000")]
			public Adapter()
			{
			}

			// Token: 0x0403EE9D RID: 257693
			[Token(Token = "0x403EE9D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_mappedItems;

			// Token: 0x0403EE9E RID: 257694
			[Token(Token = "0x403EE9E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_mappedItems;

			// Token: 0x0403EE9F RID: 257695
			[Token(Token = "0x403EE9F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_presentingIndex;

			// Token: 0x0403EEA0 RID: 257696
			[Token(Token = "0x403EEA0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_presentingIndex;

			// Token: 0x0403EEA1 RID: 257697
			[Token(Token = "0x403EEA1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_initShow;

			// Token: 0x0403EEA2 RID: 257698
			[Token(Token = "0x403EEA2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_initShow;

			// Token: 0x0403EEA3 RID: 257699
			[Token(Token = "0x403EEA3")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403EEA4 RID: 257700
			[Token(Token = "0x403EEA4")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403EEA5 RID: 257701
			[Token(Token = "0x403EEA5")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
