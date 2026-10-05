using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004090 RID: 16528
	[Token(Token = "0x2004090")]
	public class SandboxV2CookFoodListView : SandboxV2AdminMainContentViewBase<SandboxV2AdminMainCookPanelModelProperty>
	{
		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0601990D RID: 104717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601990E RID: 104718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CFE")]
		public Action<int> selectItemEvent
		{
			[Token(Token = "0x601990D")]
			[Address(RVA = "0x1255D70", Offset = "0x1254970", VA = "0x181255D70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601990E")]
			[Address(RVA = "0x1255DD0", Offset = "0x12549D0", VA = "0x181255DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601990F RID: 104719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601990F")]
		[Address(RVA = "0x1255680", Offset = "0x1254280", VA = "0x181255680", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainCookPanelModelProperty property)
		{
		}

		// Token: 0x06019910 RID: 104720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019910")]
		[Address(RVA = "0x1255600", Offset = "0x1254200", VA = "0x181255600", Slot = "8")]
		protected override void OnShow()
		{
		}

		// Token: 0x06019911 RID: 104721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019911")]
		[Address(RVA = "0x12554D0", Offset = "0x12540D0", VA = "0x1812554D0")]
		public void OnSetCanCookFilterEvent()
		{
		}

		// Token: 0x06019912 RID: 104722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019912")]
		[Address(RVA = "0x1255B20", Offset = "0x1254720", VA = "0x181255B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019913 RID: 104723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019913")]
		[Address(RVA = "0x1255D00", Offset = "0x1254900", VA = "0x181255D00")]
		public SandboxV2CookFoodListView()
		{
		}

		// Token: 0x0401FE78 RID: 130680
		[Token(Token = "0x401FE78")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x0401FE79 RID: 130681
		[Token(Token = "0x401FE79")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _filterFalsePanel;

		// Token: 0x0401FE7A RID: 130682
		[Token(Token = "0x401FE7A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _filterTruePanel;

		// Token: 0x0401FE7B RID: 130683
		[Token(Token = "0x401FE7B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _itemsPanel;

		// Token: 0x0401FE7C RID: 130684
		[Token(Token = "0x401FE7C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0401FE7D RID: 130685
		[Token(Token = "0x401FE7D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2CookFoodListLoopAdapter _loopAdapter;

		// Token: 0x0401FE7E RID: 130686
		[Token(Token = "0x401FE7E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LoopVerticalScrollRect _itemScrollRect;

		// Token: 0x0401FE7F RID: 130687
		[Token(Token = "0x401FE7F")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0401FE80 RID: 130688
		[Token(Token = "0x401FE80")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2CookFoodListView.Adapter m_adapter;

		// Token: 0x0401FE81 RID: 130689
		[Token(Token = "0x401FE81")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedTopicId;

		// Token: 0x0401FE82 RID: 130690
		[Token(Token = "0x401FE82")]
		[FieldOffset(Offset = "0x88")]
		private List<SandboxV2AdminMainMaterialModel> m_cachedMaterials;

		// Token: 0x0401FE83 RID: 130691
		[Token(Token = "0x401FE83")]
		[FieldOffset(Offset = "0x90")]
		private List<SandboxV2CookFoodListItemModel> m_cachedAllItems;

		// Token: 0x0401FE84 RID: 130692
		[Token(Token = "0x401FE84")]
		[FieldOffset(Offset = "0x98")]
		private List<SandboxV2CookFoodListItemModel> m_cachedCanCookItems;

		// Token: 0x0401FE85 RID: 130693
		[Token(Token = "0x401FE85")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_cachedCanCookFilter;

		// Token: 0x0401FE87 RID: 130695
		[Token(Token = "0x401FE87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectItemEvent;

		// Token: 0x0401FE88 RID: 130696
		[Token(Token = "0x401FE88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectItemEvent;

		// Token: 0x0401FE89 RID: 130697
		[Token(Token = "0x401FE89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FE8A RID: 130698
		[Token(Token = "0x401FE8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401FE8B RID: 130699
		[Token(Token = "0x401FE8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSetCanCookFilterEvent;

		// Token: 0x0401FE8C RID: 130700
		[Token(Token = "0x401FE8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FE8D RID: 130701
		[Token(Token = "0x401FE8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004091 RID: 16529
		[Token(Token = "0x2004091")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003CFF RID: 15615
			// (get) Token: 0x06019914 RID: 104724 RVA: 0x0009EA90 File Offset: 0x0009CC90
			[Token(Token = "0x17003CFF")]
			public override int count
			{
				[Token(Token = "0x6019914")]
				[Address(RVA = "0x1242CA0", Offset = "0x12418A0", VA = "0x181242CA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019915 RID: 104725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019915")]
			[Address(RVA = "0x1242AA0", Offset = "0x12416A0", VA = "0x181242AA0")]
			public Adapter(SandboxV2CookFoodListView closure)
			{
			}

			// Token: 0x06019916 RID: 104726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019916")]
			[Address(RVA = "0x1241E10", Offset = "0x1240A10", VA = "0x181241E10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FE8E RID: 130702
			[Token(Token = "0x401FE8E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2CookFoodListView m_closure;

			// Token: 0x0401FE8F RID: 130703
			[Token(Token = "0x401FE8F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FE90 RID: 130704
			[Token(Token = "0x401FE90")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FE91 RID: 130705
			[Token(Token = "0x401FE91")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
