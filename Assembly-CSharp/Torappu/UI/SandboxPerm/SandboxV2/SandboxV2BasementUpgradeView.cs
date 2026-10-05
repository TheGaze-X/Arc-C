using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004152 RID: 16722
	[Token(Token = "0x2004152")]
	public class SandboxV2BasementUpgradeView : DataBinder<SandboxV2BasementUpgradeProperty>
	{
		// Token: 0x06019D23 RID: 105763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D23")]
		[Address(RVA = "0x12A76C0", Offset = "0x12A62C0", VA = "0x1812A76C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2BasementUpgradeProperty property)
		{
		}

		// Token: 0x06019D24 RID: 105764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D24")]
		[Address(RVA = "0x12A7880", Offset = "0x12A6480", VA = "0x1812A7880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D25 RID: 105765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D25")]
		[Address(RVA = "0x12A7EF0", Offset = "0x12A6AF0", VA = "0x1812A7EF0")]
		private void _Render(SandboxV2BasementUpgradeViewModel viewModel)
		{
		}

		// Token: 0x06019D26 RID: 105766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D26")]
		[Address(RVA = "0x12A7E50", Offset = "0x12A6A50", VA = "0x1812A7E50")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x06019D27 RID: 105767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D27")]
		[Address(RVA = "0x12A7D50", Offset = "0x12A6950", VA = "0x1812A7D50")]
		private void _ItemClickEvent(int idx)
		{
		}

		// Token: 0x06019D28 RID: 105768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D28")]
		[Address(RVA = "0x12A77E0", Offset = "0x12A63E0", VA = "0x1812A77E0")]
		private void _CloseState()
		{
		}

		// Token: 0x06019D29 RID: 105769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D29")]
		[Address(RVA = "0x12A7530", Offset = "0x12A6130", VA = "0x1812A7530")]
		public void EventOnUpgradeBtnClick()
		{
		}

		// Token: 0x06019D2A RID: 105770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D2A")]
		[Address(RVA = "0x12A7620", Offset = "0x12A6220", VA = "0x1812A7620")]
		public void EventOnUpgradeDetailBackClick()
		{
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x06019D2B RID: 105771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D87")]
		public AnimationWrapper animWrapper
		{
			[Token(Token = "0x6019D2B")]
			[Address(RVA = "0x12A8710", Offset = "0x12A7310", VA = "0x1812A8710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019D2C RID: 105772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D2C")]
		[Address(RVA = "0x12A8690", Offset = "0x12A7290", VA = "0x1812A8690")]
		public SandboxV2BasementUpgradeView()
		{
		}

		// Token: 0x040206B1 RID: 132785
		[Token(Token = "0x40206B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textUnlockFunc;

		// Token: 0x040206B2 RID: 132786
		[Token(Token = "0x40206B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _funcContent;

		// Token: 0x040206B3 RID: 132787
		[Token(Token = "0x40206B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curLevel;

		// Token: 0x040206B4 RID: 132788
		[Token(Token = "0x40206B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nextLevel;

		// Token: 0x040206B5 RID: 132789
		[Token(Token = "0x40206B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _detailNextLevel;

		// Token: 0x040206B6 RID: 132790
		[Token(Token = "0x40206B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _upgradeConditions;

		// Token: 0x040206B7 RID: 132791
		[Token(Token = "0x40206B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _conditionPanel;

		// Token: 0x040206B8 RID: 132792
		[Token(Token = "0x40206B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _unlockItemContent;

		// Token: 0x040206B9 RID: 132793
		[Token(Token = "0x40206B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x040206BA RID: 132794
		[Token(Token = "0x40206BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _upgradeBtn;

		// Token: 0x040206BB RID: 132795
		[Token(Token = "0x40206BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x040206BC RID: 132796
		[Token(Token = "0x40206BC")]
		private const string ANIM_ENTRY = "sandboxv2_basement_upgrade_entry";

		// Token: 0x040206BD RID: 132797
		[Token(Token = "0x40206BD")]
		private const string ANIM_UPGRADE_FINISH = "sandboxv2_basement_upgrade_completed_back";

		// Token: 0x040206BE RID: 132798
		[Token(Token = "0x40206BE")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040206BF RID: 132799
		[Token(Token = "0x40206BF")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040206C0 RID: 132800
		[Token(Token = "0x40206C0")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2BasementUpgradeView.SandboxV2BasementUpgradeFuncGroupAdapter m_groupAdapter;

		// Token: 0x040206C1 RID: 132801
		[Token(Token = "0x40206C1")]
		[FieldOffset(Offset = "0xA0")]
		private SandboxV2BasementUpgradeView.SandboxV2BasementUpgradeItemAdapter m_itemAdapter;

		// Token: 0x040206C2 RID: 132802
		[Token(Token = "0x40206C2")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2BasementUpgradeViewModel m_cachedViewModel;

		// Token: 0x040206C3 RID: 132803
		[Token(Token = "0x40206C3")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x040206C4 RID: 132804
		[Token(Token = "0x40206C4")]
		[FieldOffset(Offset = "0xB8")]
		private string m_topicId;

		// Token: 0x040206C5 RID: 132805
		[Token(Token = "0x40206C5")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_upgradeAble;

		// Token: 0x040206C6 RID: 132806
		[Token(Token = "0x40206C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040206C7 RID: 132807
		[Token(Token = "0x40206C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040206C8 RID: 132808
		[Token(Token = "0x40206C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040206C9 RID: 132809
		[Token(Token = "0x40206C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x040206CA RID: 132810
		[Token(Token = "0x40206CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ItemClickEvent;

		// Token: 0x040206CB RID: 132811
		[Token(Token = "0x40206CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseState;

		// Token: 0x040206CC RID: 132812
		[Token(Token = "0x40206CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeBtnClick;

		// Token: 0x040206CD RID: 132813
		[Token(Token = "0x40206CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeDetailBackClick;

		// Token: 0x040206CE RID: 132814
		[Token(Token = "0x40206CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_animWrapper;

		// Token: 0x040206CF RID: 132815
		[Token(Token = "0x40206CF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004153 RID: 16723
		[Token(Token = "0x2004153")]
		public class SandboxV2BasementUpgradeFuncGroupAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x06019D2D RID: 105773 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019D2E RID: 105774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D88")]
			public List<SandboxV2BasementUpgradePreviewGroupViewModel> dataSet
			{
				[Token(Token = "0x6019D2D")]
				[Address(RVA = "0x12A36E0", Offset = "0x12A22E0", VA = "0x1812A36E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019D2E")]
				[Address(RVA = "0x12A37C0", Offset = "0x12A23C0", VA = "0x1812A37C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x06019D2F RID: 105775 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019D30 RID: 105776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D89")]
			public ILoadAsset assetLoader
			{
				[Token(Token = "0x6019D2F")]
				[Address(RVA = "0x12A35C0", Offset = "0x12A21C0", VA = "0x1812A35C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019D30")]
				[Address(RVA = "0x12A3740", Offset = "0x12A2340", VA = "0x1812A3740")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D8A RID: 15754
			// (get) Token: 0x06019D31 RID: 105777 RVA: 0x0009F6A8 File Offset: 0x0009D8A8
			[Token(Token = "0x17003D8A")]
			public override int count
			{
				[Token(Token = "0x6019D31")]
				[Address(RVA = "0x12A3620", Offset = "0x12A2220", VA = "0x1812A3620", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019D32 RID: 105778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019D32")]
			[Address(RVA = "0x12A3330", Offset = "0x12A1F30", VA = "0x1812A3330", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019D33 RID: 105779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019D33")]
			[Address(RVA = "0x12A3560", Offset = "0x12A2160", VA = "0x1812A3560")]
			public SandboxV2BasementUpgradeFuncGroupAdapter()
			{
			}

			// Token: 0x040206D2 RID: 132818
			[Token(Token = "0x40206D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x040206D3 RID: 132819
			[Token(Token = "0x40206D3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x040206D4 RID: 132820
			[Token(Token = "0x40206D4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_assetLoader;

			// Token: 0x040206D5 RID: 132821
			[Token(Token = "0x40206D5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_assetLoader;

			// Token: 0x040206D6 RID: 132822
			[Token(Token = "0x40206D6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040206D7 RID: 132823
			[Token(Token = "0x40206D7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040206D8 RID: 132824
			[Token(Token = "0x40206D8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004154 RID: 16724
		[Token(Token = "0x2004154")]
		public class SandboxV2BasementUpgradeItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D8B RID: 15755
			// (get) Token: 0x06019D34 RID: 105780 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019D35 RID: 105781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D8B")]
			public ILoadAsset assetLoader
			{
				[Token(Token = "0x6019D34")]
				[Address(RVA = "0x12A3B60", Offset = "0x12A2760", VA = "0x1812A3B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019D35")]
				[Address(RVA = "0x12A3CF0", Offset = "0x12A28F0", VA = "0x1812A3CF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D8C RID: 15756
			// (get) Token: 0x06019D36 RID: 105782 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019D37 RID: 105783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D8C")]
			public string topicId
			{
				[Token(Token = "0x6019D36")]
				[Address(RVA = "0x12A3C90", Offset = "0x12A2890", VA = "0x1812A3C90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019D37")]
				[Address(RVA = "0x12A3DE0", Offset = "0x12A29E0", VA = "0x1812A3DE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x06019D38 RID: 105784 RVA: 0x0009F6C0 File Offset: 0x0009D8C0
			[Token(Token = "0x17003D8D")]
			public override int count
			{
				[Token(Token = "0x6019D38")]
				[Address(RVA = "0x12A3BC0", Offset = "0x12A27C0", VA = "0x1812A3BC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x06019D39 RID: 105785 RVA: 0x0009F6D8 File Offset: 0x0009D8D8
			// (set) Token: 0x06019D3A RID: 105786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D8E")]
			public float scaler
			{
				[Token(Token = "0x6019D39")]
				[Address(RVA = "0x12A3C30", Offset = "0x12A2830", VA = "0x1812A3C30")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6019D3A")]
				[Address(RVA = "0x12A3D70", Offset = "0x12A2970", VA = "0x1812A3D70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06019D3B RID: 105787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019D3B")]
			[Address(RVA = "0x12A3840", Offset = "0x12A2440", VA = "0x1812A3840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019D3C RID: 105788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019D3C")]
			[Address(RVA = "0x12A3B00", Offset = "0x12A2700", VA = "0x1812A3B00")]
			public SandboxV2BasementUpgradeItemAdapter()
			{
			}

			// Token: 0x040206D9 RID: 132825
			[Token(Token = "0x40206D9")]
			[FieldOffset(Offset = "0x20")]
			public List<SandboxV2BasementUpgradeResourceViewModel> dataSet;

			// Token: 0x040206DA RID: 132826
			[Token(Token = "0x40206DA")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public Action<int> onItemClick;

			// Token: 0x040206DE RID: 132830
			[Token(Token = "0x40206DE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_assetLoader;

			// Token: 0x040206DF RID: 132831
			[Token(Token = "0x40206DF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_assetLoader;

			// Token: 0x040206E0 RID: 132832
			[Token(Token = "0x40206E0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_topicId;

			// Token: 0x040206E1 RID: 132833
			[Token(Token = "0x40206E1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_topicId;

			// Token: 0x040206E2 RID: 132834
			[Token(Token = "0x40206E2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040206E3 RID: 132835
			[Token(Token = "0x40206E3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_scaler;

			// Token: 0x040206E4 RID: 132836
			[Token(Token = "0x40206E4")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_scaler;

			// Token: 0x040206E5 RID: 132837
			[Token(Token = "0x40206E5")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040206E6 RID: 132838
			[Token(Token = "0x40206E6")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
