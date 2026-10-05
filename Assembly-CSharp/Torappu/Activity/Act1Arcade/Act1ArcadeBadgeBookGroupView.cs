using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007929 RID: 31017
	[Token(Token = "0x2007929")]
	public class Act1ArcadeBadgeBookGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x0602B840 RID: 178240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B841 RID: 178241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065F4")]
		public ScrollRect parentScroll
		{
			[Token(Token = "0x602B840")]
			[Address(RVA = "0x27696E0", Offset = "0x27682E0", VA = "0x1827696E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B841")]
			[Address(RVA = "0x2769740", Offset = "0x2768340", VA = "0x182769740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B842 RID: 178242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B842")]
		[Address(RVA = "0x2768FB0", Offset = "0x2767BB0", VA = "0x182768FB0")]
		public void Render(string actId, Act1ArcadeBadgeBookGroupViewModel model, BadgeBookLayoutMode layoutMode)
		{
		}

		// Token: 0x0602B843 RID: 178243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B843")]
		[Address(RVA = "0x2768ED0", Offset = "0x2767AD0", VA = "0x182768ED0")]
		public RectTransform GetItemRectByIndex(int index)
		{
			return null;
		}

		// Token: 0x0602B844 RID: 178244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B844")]
		[Address(RVA = "0x2768E10", Offset = "0x2767A10", VA = "0x182768E10")]
		public CrossAppShareTextModel GenerateGroupNameTextModel()
		{
			return null;
		}

		// Token: 0x0602B845 RID: 178245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B845")]
		[Address(RVA = "0x2768DA0", Offset = "0x27679A0", VA = "0x182768DA0")]
		public CrossAppShareLayoutContentModel GenerateGroupLayoutContentModel()
		{
			return null;
		}

		// Token: 0x0602B846 RID: 178246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B846")]
		[Address(RVA = "0x27694C0", Offset = "0x27680C0", VA = "0x1827694C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B847 RID: 178247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B847")]
		[Address(RVA = "0x2769680", Offset = "0x2768280", VA = "0x182769680")]
		public Act1ArcadeBadgeBookGroupView()
		{
		}

		// Token: 0x0403EEBA RID: 257722
		[Token(Token = "0x403EEBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Text> _groupNameTexts;

		// Token: 0x0403EEBB RID: 257723
		[Token(Token = "0x403EEBB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _groupDescText;

		// Token: 0x0403EEBC RID: 257724
		[Token(Token = "0x403EEBC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _showTailPanel;

		// Token: 0x0403EEBD RID: 257725
		[Token(Token = "0x403EEBD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hideTailPanel;

		// Token: 0x0403EEBE RID: 257726
		[Token(Token = "0x403EEBE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _groupItemContent;

		// Token: 0x0403EEBF RID: 257727
		[Token(Token = "0x403EEBF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GridLayoutGroup _contentLayout;

		// Token: 0x0403EEC0 RID: 257728
		[Token(Token = "0x403EEC0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _showTailCellSize;

		// Token: 0x0403EEC1 RID: 257729
		[Token(Token = "0x403EEC1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _hideTailCellSize;

		// Token: 0x0403EEC2 RID: 257730
		[Token(Token = "0x403EEC2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrossAppShareStartLayoutContent _shareLayoutContent;

		// Token: 0x0403EEC3 RID: 257731
		[Token(Token = "0x403EEC3")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403EEC4 RID: 257732
		[Token(Token = "0x403EEC4")]
		[FieldOffset(Offset = "0x68")]
		private Act1ArcadeBadgeBookGroupView.Adapter m_adapter;

		// Token: 0x0403EEC6 RID: 257734
		[Token(Token = "0x403EEC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parentScroll;

		// Token: 0x0403EEC7 RID: 257735
		[Token(Token = "0x403EEC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parentScroll;

		// Token: 0x0403EEC8 RID: 257736
		[Token(Token = "0x403EEC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EEC9 RID: 257737
		[Token(Token = "0x403EEC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetItemRectByIndex;

		// Token: 0x0403EECA RID: 257738
		[Token(Token = "0x403EECA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateGroupNameTextModel;

		// Token: 0x0403EECB RID: 257739
		[Token(Token = "0x403EECB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateGroupLayoutContentModel;

		// Token: 0x0403EECC RID: 257740
		[Token(Token = "0x403EECC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EECD RID: 257741
		[Token(Token = "0x403EECD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200792A RID: 31018
		[Token(Token = "0x200792A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170065F5 RID: 26101
			// (get) Token: 0x0602B848 RID: 178248 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B849 RID: 178249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065F5")]
			public ScrollRect parentScroll
			{
				[Token(Token = "0x602B848")]
				[Address(RVA = "0x277A560", Offset = "0x2779160", VA = "0x18277A560")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B849")]
				[Address(RVA = "0x277A940", Offset = "0x2779540", VA = "0x18277A940")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065F6 RID: 26102
			// (get) Token: 0x0602B84A RID: 178250 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B84B RID: 178251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065F6")]
			public string actId
			{
				[Token(Token = "0x602B84A")]
				[Address(RVA = "0x277A120", Offset = "0x2778D20", VA = "0x18277A120")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B84B")]
				[Address(RVA = "0x277A6E0", Offset = "0x27792E0", VA = "0x18277A6E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065F7 RID: 26103
			// (get) Token: 0x0602B84C RID: 178252 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B84D RID: 178253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065F7")]
			public IList<Act1ArcadeBadgeBookItemViewModel> source
			{
				[Token(Token = "0x602B84C")]
				[Address(RVA = "0x277A620", Offset = "0x2779220", VA = "0x18277A620")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B84D")]
				[Address(RVA = "0x277AA30", Offset = "0x2779630", VA = "0x18277AA30")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065F8 RID: 26104
			// (get) Token: 0x0602B84E RID: 178254 RVA: 0x000DC548 File Offset: 0x000DA748
			// (set) Token: 0x0602B84F RID: 178255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170065F8")]
			public BadgeBookLayoutMode layoutMode
			{
				[Token(Token = "0x602B84E")]
				[Address(RVA = "0x277A4A0", Offset = "0x27790A0", VA = "0x18277A4A0")]
				[CompilerGenerated]
				private get
				{
					return BadgeBookLayoutMode.SHOW_TAIL;
				}
				[Token(Token = "0x602B84F")]
				[Address(RVA = "0x277A850", Offset = "0x2779450", VA = "0x18277A850")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170065F9 RID: 26105
			// (get) Token: 0x0602B850 RID: 178256 RVA: 0x000DC560 File Offset: 0x000DA760
			[Token(Token = "0x170065F9")]
			public override int count
			{
				[Token(Token = "0x602B850")]
				[Address(RVA = "0x277A370", Offset = "0x2778F70", VA = "0x18277A370", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B851 RID: 178257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B851")]
			[Address(RVA = "0x2779A20", Offset = "0x2778620", VA = "0x182779A20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B852 RID: 178258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B852")]
			[Address(RVA = "0x277A060", Offset = "0x2778C60", VA = "0x18277A060")]
			public Adapter()
			{
			}

			// Token: 0x0403EED2 RID: 257746
			[Token(Token = "0x403EED2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_parentScroll;

			// Token: 0x0403EED3 RID: 257747
			[Token(Token = "0x403EED3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_parentScroll;

			// Token: 0x0403EED4 RID: 257748
			[Token(Token = "0x403EED4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_actId;

			// Token: 0x0403EED5 RID: 257749
			[Token(Token = "0x403EED5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_actId;

			// Token: 0x0403EED6 RID: 257750
			[Token(Token = "0x403EED6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_source;

			// Token: 0x0403EED7 RID: 257751
			[Token(Token = "0x403EED7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_source;

			// Token: 0x0403EED8 RID: 257752
			[Token(Token = "0x403EED8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_layoutMode;

			// Token: 0x0403EED9 RID: 257753
			[Token(Token = "0x403EED9")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_layoutMode;

			// Token: 0x0403EEDA RID: 257754
			[Token(Token = "0x403EEDA")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403EEDB RID: 257755
			[Token(Token = "0x403EEDB")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403EEDC RID: 257756
			[Token(Token = "0x403EEDC")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
